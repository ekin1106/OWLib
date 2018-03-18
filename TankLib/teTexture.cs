﻿using System.IO;
using System.Text;

namespace TankLib {
    /// <summary>Tank Texture, type 004</summary>
    public class teTexture {
        public teTexturePayload Payload;
        public bool PayloadRequired;

        // non-payload
        public byte[] Data;
        public TextureTypes.TextureHeader Header;
        public uint Size;
        public TextureTypes.DXGI_PIXEL_FORMAT Format;
        
        /// <summary>Load texture from a stream</summary>
        public teTexture(Stream stream) {
            using (BinaryReader imageReader = new BinaryReader(stream)) {
                Header = imageReader.Read<TextureTypes.TextureHeader>();
                Size = Header.DataSize;
                Format = Header.Format;

                if (Header.DataSize == 0) {
                    PayloadRequired = true;
                    return;
                }

                stream.Seek(128, SeekOrigin.Begin);
                Data = new byte[Header.DataSize];
                stream.Read(Data, 0, (int)Header.DataSize);
            }
        }

        /// <summary>Load the texture payload</summary>
        /// <param name="payloadStream">The payload stream</param>
        public void LoadPayload(Stream payloadStream) {
            if (!PayloadRequired) throw new Exceptions.TexturePayloadNotRequiredException();
            if (Payload != null) throw new Exceptions.TexturePayloadAlreadyExistsException();
            
            Payload = new teTexturePayload(this, payloadStream);
        }

        /// <summary>Save DDS to stream</summary>
        /// <param name="stream">Stream to be written to</param>
        /// <param name="keepOpen">Keep the stream open after writing</param>
        public void SaveToDDS(Stream stream, bool keepOpen=false) {
            if (PayloadRequired) {
                if (Payload == null) {
                    throw new Exceptions.TexturePayloadMissingException();
                }
                Payload.SaveToDDS(stream, keepOpen);
            } else {
                using (BinaryWriter ddsWriter = new BinaryWriter(stream, Encoding.Default, keepOpen)) {
                    TextureTypes.DDSHeader dds = Header.ToDDSHeader();
                    ddsWriter.Write(dds);
                    if (dds.Format.FourCC == 808540228) {
                        TextureTypes.DDS_HEADER_DXT10 d10 = new TextureTypes.DDS_HEADER_DXT10 {
                            Format = (uint)Header.Format,
                            Dimension = TextureTypes.D3D10_RESOURCE_DIMENSION.TEXTURE2D,
                            Misc = (uint)(Header.IsCubemap() ? 0x4 : 0),
                            Size = (uint)(Header.IsCubemap() ? 1 : Header.Surfaces),
                            Misc2 = 0
                        };
                        ddsWriter.Write(d10);
                    }
                    ddsWriter.Write(Data, 0, (int)Header.DataSize);
                }
            }
        }

        /// <summary>Save DDS to stream</summary>
        /// <param name="keepOpen">Keep the stream open after writing</param>
        public Stream SaveToDDS(bool keepOpen=false) {
            MemoryStream stream = new MemoryStream();
            SaveToDDS(stream, keepOpen);
            return stream;
        }
    }
}
// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x99007908, "STUAnimationTrackOverride")]
    public class STUAnimationTrackOverride : STUInstance {
        [STUFieldAttribute(0xF46C7A7F, "m_animCurve", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAnimCurve m_animCurve;

        [STUFieldAttribute(0xBA891264, "m_dataFlow")]
        public teStructuredDataAssetRef<ulong> m_dataFlow;

        [STUFieldAttribute(0x07DD813E, "m_value")]
        public float m_value;
    }
}

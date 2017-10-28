﻿// File auto generated by STUHashTool
using static STULib.Types.Generic.Common;
using STULib.Types.Gamemodes.Unknown;
using STULib.Types.Gamemodes.Unknown.Enums;

namespace STULib.Types.Gamemodes {
    [STU(0x2E1A0A0B)]
    public class STUBrawlInfo : STUInstance {
        [STUField(0xEB4F2408)]
        public STUGUID Gamemode;  // STULib.Types.STUGamemode

        [STUField(0x3CE93B76)]
        public STU_9783E116[] Virtual1;

        [STUField(0xAD4BF17F)]
        public STU_9783E116[] Virtual2;

        [STUField(0xD440A0F7)]
        public STUBrawlTeam[] TeamConfig;

        [STUField(0xDB2577DB)]
        public STUEnum_56DF3C94[] UnknownEnum;

        [STUField(0xCA7E6EDC)]
        public STUGUID Name;
    }
}

// File auto generated by STUHashTool
using STULib.Types.Generic;

namespace STULib.Types {
    [STU(0x866672AD)]
    public class STU_866672AD : Common.STUInstance {  // needs own home
    }

    
    [STU(0xC881FD3B)]
    public class STUGlobalInventoryMaster : STU_866672AD {
        [STUField(0xBF482AA3)]
        public STUHeroUnlocks.UnlockInfo AchievementUnlocks;

        [STUField(0xC84D463F)]
        public Common.STUGUID[] UnknownLootboxUnlocksA;  // STULib.Types.STUUnlock.Cosmetic

        [STUField(0x50C6BC40)]
        public STUGlobInvLootbox[] Lootboxes;

        [STUField(0x22D62B2D)]
        public STUGlobInvUnknownLootbox[] UnknownLootboxUnlocksB;

        [STUField(0x9A4245F2)]
        public STUGlobInvLevelUnlocks[] LevelUnlocks; // Includes default sprays/icons and every level portrait

        [STUField(0x473494FF)]
        public STUHeroUnlocks.EventUnlockInfo[] EventGeneralUnlocks;

        [STUField(0x03F27C01)]
        public STUGlobInvEventCreditUnlocks[] CurrencyUnlocks;

        [STUField(0x88922C14)]
        public ulong[] m_88922C14;

        [STUField(0x11AEB3FB)]
        public int m_11AEB3FB;

        [STUField(0xE7377888)]
        public uint m_E7377888;
    }
}

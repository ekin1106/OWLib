// Instance generated by TankLibHelper.InstanceBuilder
using TankLib.Math;
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0x7C3457DC, "STUHero")]
    public class STUHero : STUShippable {
        [STUFieldAttribute(0x950BBA06, "m_gameplayEntity")]
        public teStructuredDataAssetRef<ulong> m_gameplayEntity;

        [STUFieldAttribute(0x0EDCE350)]
        public teStructuredDataAssetRef<ulong> m_0EDCE350;

        [STUFieldAttribute(0xE04197AF, "m_gameRulesetSchemas")]
        public teStructuredDataAssetRef<ulong>[] m_gameRulesetSchemas;

        [STUFieldAttribute(0x2C54AEAF, "m_category")]
        public teStructuredDataAssetRef<ulong> m_category;

        [STUFieldAttribute(0xF2D8DE15)]
        public teStructuredDataAssetRef<ulong>[] m_F2D8DE15;

        [STUFieldAttribute(0x3446F580)]
        public teStructuredDataAssetRef<ulong> m_3446F580;

        [STUFieldAttribute(0x322C521A)]
        public teStructuredDataAssetRef<ulong> m_322C521A;

        [STUFieldAttribute(0x26D71549)]
        public teStructuredDataAssetRef<ulong> m_26D71549;

        [STUFieldAttribute(0x8125713E)]
        public teStructuredDataAssetRef<ulong> m_8125713E;

        [STUFieldAttribute(0xAC91BECC, "m_previewEmoteEntity")]
        public teStructuredDataAssetRef<ulong> m_previewEmoteEntity;

        [STUFieldAttribute(0xFCD2B649, "m_previewWeaponEntities", ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_A0872511[] m_previewWeaponEntities;

        [STUFieldAttribute(0xC2FE396F, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_A0872511[] m_C2FE396F;

        [STUFieldAttribute(0x8203BFE1, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_1A496D3C[] m_8203BFE1;

        [STUFieldAttribute(0xFC833C02, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_C0D5117B[] m_FC833C02;

        [STUFieldAttribute(0xA341183E, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_8A1F18F9[] m_A341183E;

        [STUFieldAttribute(0x77FED604, "m_heroLoadout")]
        public teStructuredDataAssetRef<ulong>[] m_heroLoadout;

        [STUFieldAttribute(0xD12CB4EA)]
        public teStructuredDataAssetRef<ulong>[] m_D12CB4EA;

        [STUFieldAttribute(0x485AA39C, "m_heroProgression")]
        public teStructuredDataAssetRef<ulong> m_heroProgression;

        [STUFieldAttribute(0x418F797D, ReaderType = typeof(InlineInstanceFieldReader))]
        public StatEventScoreScaler[] m_418F797D;

        [STUFieldAttribute(0xFF3C2071, "m_achievements")]
        public teStructuredDataAssetRef<ulong>[] m_achievements;

        [STUFieldAttribute(0xA5C9CA02, "m_internalName")]
        public teString m_internalName;

        [STUFieldAttribute(0x893AAB2B, "m_heroEffects")]
        public teStructuredDataAssetRef<ulong>[] m_heroEffects;

        [STUFieldAttribute(0xE1258EC1, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_5E493D8B[] m_E1258EC1;

        [STUFieldAttribute(0x84625AA3, "m_skinThemes", ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_63172E83[] m_skinThemes;

        [STUFieldAttribute(0xE25DDDA1, "m_heroColor")]
        public teColorRGBA m_heroColor;

        [STUFieldAttribute(0x44D13CC2)]
        public int m_44D13CC2;

        [STUFieldAttribute(0xAF4EC410, "m_heroSize")]
        public Enum_C1DAF32A m_heroSize;

        [STUFieldAttribute(0x7D88A63A, "m_gender")]
        public Enum_0C014B4A m_gender;

        [STUFieldAttribute(0x62746D34)]
        public byte m_62746D34;
    }
}

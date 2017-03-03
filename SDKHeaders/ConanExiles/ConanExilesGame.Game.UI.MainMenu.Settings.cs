using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;
using ConanExilesGame.Game.UI.MainMenu.Settings;


namespace ConanExilesGame.Game.UI.MainMenu.Settings
{
	/// <summary>
	/// UW_Settings_Server_C:USettingsServerBase
	/// Size: 0x8E0
	/// Properties: 94
	/// </summary>
	public class UW_Settings_Server_C:USettingsServerBase
	{
		public override int ObjectSize => 2272;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5C8);
		
		/// <summary>
		/// Name: B_MakeMeAdmin
		/// Type: ObjectProperty
		/// Offset: 0x5D0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_MakeMeAdmin => ReadUObject<UW_ButtonCustom_C>(0x5D0);
		
		/// <summary>
		/// Name: CB_AvatarsDisabled
		/// Type: ObjectProperty
		/// Offset: 0x5D8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_AvatarsDisabled => ReadUObject<UW_ButtonNormal_C>(0x5D8);
		
		/// <summary>
		/// Name: CB_CanDamagePlayerStructures
		/// Type: ObjectProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_CanDamagePlayerStructures => ReadUObject<UW_ButtonNormal_C>(0x5E0);
		
		/// <summary>
		/// Name: CB_ChatHasGlobal
		/// Type: ObjectProperty
		/// Offset: 0x5E8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_ChatHasGlobal => ReadUObject<UW_ButtonNormal_C>(0x5E8);
		
		/// <summary>
		/// Name: CB_DropBackpackOnDeath
		/// Type: ObjectProperty
		/// Offset: 0x5F0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_DropBackpackOnDeath => ReadUObject<UW_ButtonNormal_C>(0x5F0);
		
		/// <summary>
		/// Name: CB_DropEquipmentOnDeath
		/// Type: ObjectProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_DropEquipmentOnDeath => ReadUObject<UW_ButtonNormal_C>(0x5F8);
		
		/// <summary>
		/// Name: CB_DropShortcutbarOnDeath
		/// Type: ObjectProperty
		/// Offset: 0x600
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_DropShortcutbarOnDeath => ReadUObject<UW_ButtonNormal_C>(0x600);
		
		/// <summary>
		/// Name: CB_EnableCatchUpTime
		/// Type: ObjectProperty
		/// Offset: 0x608
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_EnableCatchUpTime => ReadUObject<UW_ButtonNormal_C>(0x608);
		
		/// <summary>
		/// Name: CB_EnableSandStorm
		/// Type: ObjectProperty
		/// Offset: 0x610
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_EnableSandStorm => ReadUObject<UW_ButtonNormal_C>(0x610);
		
		/// <summary>
		/// Name: CB_EverybodyCanLootCorpse
		/// Type: ObjectProperty
		/// Offset: 0x618
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_EverybodyCanLootCorpse => ReadUObject<UW_ButtonNormal_C>(0x618);
		
		/// <summary>
		/// Name: CB_IsBattlEyeEnabled
		/// Type: ObjectProperty
		/// Offset: 0x620
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_IsBattlEyeEnabled => ReadUObject<UW_ButtonNormal_C>(0x620);
		
		/// <summary>
		/// Name: CB_IsLoadErrorsFatal
		/// Type: ObjectProperty
		/// Offset: 0x628
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_IsLoadErrorsFatal => ReadUObject<UW_ButtonNormal_C>(0x628);
		
		/// <summary>
		/// Name: CB_LogoutCharactersRemainInTheWorld
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_LogoutCharactersRemainInTheWorld => ReadUObject<UW_ButtonNormal_C>(0x630);
		
		/// <summary>
		/// Name: CB_NoOwnership
		/// Type: ObjectProperty
		/// Offset: 0x638
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_NoOwnership => ReadUObject<UW_ButtonNormal_C>(0x638);
		
		/// <summary>
		/// Name: CB_PVPEnabled
		/// Type: ObjectProperty
		/// Offset: 0x640
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_PVPEnabled => ReadUObject<UW_ButtonNormal_C>(0x640);
		
		/// <summary>
		/// Name: CB_PVPRestrictToTime
		/// Type: ObjectProperty
		/// Offset: 0x648
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_PVPRestrictToTime => ReadUObject<UW_ButtonNormal_C>(0x648);
		
		/// <summary>
		/// Name: CB_RegionAllowAfrica
		/// Type: ObjectProperty
		/// Offset: 0x650
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowAfrica => ReadUObject<UW_ButtonNormal_C>(0x650);
		
		/// <summary>
		/// Name: CB_RegionAllowAsia
		/// Type: ObjectProperty
		/// Offset: 0x658
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowAsia => ReadUObject<UW_ButtonNormal_C>(0x658);
		
		/// <summary>
		/// Name: CB_RegionAllowCentralEurope
		/// Type: ObjectProperty
		/// Offset: 0x660
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowCentralEurope => ReadUObject<UW_ButtonNormal_C>(0x660);
		
		/// <summary>
		/// Name: CB_RegionAllowEasternEurope
		/// Type: ObjectProperty
		/// Offset: 0x668
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowEasternEurope => ReadUObject<UW_ButtonNormal_C>(0x668);
		
		/// <summary>
		/// Name: CB_RegionAllowNorthAmerica
		/// Type: ObjectProperty
		/// Offset: 0x670
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowNorthAmerica => ReadUObject<UW_ButtonNormal_C>(0x670);
		
		/// <summary>
		/// Name: CB_RegionAllowOceania
		/// Type: ObjectProperty
		/// Offset: 0x678
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowOceania => ReadUObject<UW_ButtonNormal_C>(0x678);
		
		/// <summary>
		/// Name: CB_RegionAllowSouthAmerica
		/// Type: ObjectProperty
		/// Offset: 0x680
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowSouthAmerica => ReadUObject<UW_ButtonNormal_C>(0x680);
		
		/// <summary>
		/// Name: CB_RegionAllowWesternEurope
		/// Type: ObjectProperty
		/// Offset: 0x688
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RegionAllowWesternEurope => ReadUObject<UW_ButtonNormal_C>(0x688);
		
		/// <summary>
		/// Name: CB_TimeRestrictAvatarSummoning
		/// Type: ObjectProperty
		/// Offset: 0x690
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_TimeRestrictAvatarSummoning => ReadUObject<UW_ButtonNormal_C>(0x690);
		
		/// <summary>
		/// Name: CB_TimeRestrictPVPBuildingDamage
		/// Type: ObjectProperty
		/// Offset: 0x698
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_TimeRestrictPVPBuildingDamage => ReadUObject<UW_ButtonNormal_C>(0x698);
		
		/// <summary>
		/// Name: CBS_Community
		/// Type: ObjectProperty
		/// Offset: 0x6A0
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_Community => ReadUObject<UW_FCComboBoxString_C>(0x6A0);
		
		/// <summary>
		/// Name: CBS_MaxNudity
		/// Type: ObjectProperty
		/// Offset: 0x6A8
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_MaxNudity => ReadUObject<UW_FCComboBoxString_C>(0x6A8);
		
		/// <summary>
		/// Name: CBS_ServerRegion
		/// Type: ObjectProperty
		/// Offset: 0x6B0
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_ServerRegion => ReadUObject<UW_FCComboBoxString_C>(0x6B0);
		
		/// <summary>
		/// Name: CBS_ServerVoiceChat
		/// Type: ObjectProperty
		/// Offset: 0x6B8
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_ServerVoiceChat => ReadUObject<UW_FCComboBoxString_C>(0x6B8);
		
		/// <summary>
		/// Name: ETXT_AdminPW
		/// Type: ObjectProperty
		/// Offset: 0x6C0
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C ETXT_AdminPW => ReadUObject<UW_FCEditableTextBlock_C>(0x6C0);
		
		/// <summary>
		/// Name: ETXT_RegionBlockList
		/// Type: ObjectProperty
		/// Offset: 0x6C8
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C ETXT_RegionBlockList => ReadUObject<UW_FCEditableTextBlock_C>(0x6C8);
		
		/// <summary>
		/// Name: ETXT_ServerPW
		/// Type: ObjectProperty
		/// Offset: 0x6D0
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C ETXT_ServerPW => ReadUObject<UW_FCEditableTextBlock_C>(0x6D0);
		
		/// <summary>
		/// Name: Group_AvatarSummoningTimeRestriction
		/// Type: ObjectProperty
		/// Offset: 0x6D8
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Group_AvatarSummoningTimeRestriction => ReadUObject<UVerticalBox>(0x6D8);
		
		/// <summary>
		/// Name: Group_PVPBuildingDamageTimeRestriction
		/// Type: ObjectProperty
		/// Offset: 0x6E0
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Group_PVPBuildingDamageTimeRestriction => ReadUObject<UVerticalBox>(0x6E0);
		
		/// <summary>
		/// Name: Group_PVPTimeRestriction
		/// Type: ObjectProperty
		/// Offset: 0x6E8
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Group_PVPTimeRestriction => ReadUObject<UVerticalBox>(0x6E8);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x6F0
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x6F0);
		
		/// <summary>
		/// Name: Image1
		/// Type: ObjectProperty
		/// Offset: 0x6F8
		/// Size: 0x08
		/// </summary>
		public UImage Image1 => ReadUObject<UImage>(0x6F8);
		
		/// <summary>
		/// Name: Image2
		/// Type: ObjectProperty
		/// Offset: 0x700
		/// Size: 0x08
		/// </summary>
		public UImage Image2 => ReadUObject<UImage>(0x700);
		
		/// <summary>
		/// Name: S_AvatarLifeTime
		/// Type: ObjectProperty
		/// Offset: 0x708
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_AvatarLifeTime => ReadUObject<UW_EditableLabeledSlider_C>(0x708);
		
		/// <summary>
		/// Name: S_BuildingRadialDestructionForceMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x710
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_BuildingRadialDestructionForceMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x710);
		
		/// <summary>
		/// Name: S_ChatLocalRadius
		/// Type: ObjectProperty
		/// Offset: 0x718
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ChatLocalRadius => ReadUObject<UW_EditableLabeledSlider_C>(0x718);
		
		/// <summary>
		/// Name: S_ChatMaxMessageLength
		/// Type: ObjectProperty
		/// Offset: 0x720
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ChatMaxMessageLength => ReadUObject<UW_EditableLabeledSlider_C>(0x720);
		
		/// <summary>
		/// Name: S_ClanMaxSize
		/// Type: ObjectProperty
		/// Offset: 0x728
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ClanMaxSize => ReadUObject<UW_EditableLabeledSlider_C>(0x728);
		
		/// <summary>
		/// Name: S_ClientCatchUpTime
		/// Type: ObjectProperty
		/// Offset: 0x730
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ClientCatchUpTime => ReadUObject<UW_EditableLabeledSlider_C>(0x730);
		
		/// <summary>
		/// Name: S_DawnDuskTimeSpeedScale
		/// Type: ObjectProperty
		/// Offset: 0x738
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_DawnDuskTimeSpeedScale => ReadUObject<UW_EditableLabeledSlider_C>(0x738);
		
		/// <summary>
		/// Name: S_DayCycleSpeedScale
		/// Type: ObjectProperty
		/// Offset: 0x740
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_DayCycleSpeedScale => ReadUObject<UW_EditableLabeledSlider_C>(0x740);
		
		/// <summary>
		/// Name: S_DayTimeSpeedScale
		/// Type: ObjectProperty
		/// Offset: 0x748
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_DayTimeSpeedScale => ReadUObject<UW_EditableLabeledSlider_C>(0x748);
		
		/// <summary>
		/// Name: S_HarvestAmountMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x750
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_HarvestAmountMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x750);
		
		/// <summary>
		/// Name: S_ItemConvertionMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x758
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ItemConvertionMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x758);
		
		/// <summary>
		/// Name: S_ItemSpoilRateScale
		/// Type: ObjectProperty
		/// Offset: 0x760
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ItemSpoilRateScale => ReadUObject<UW_EditableLabeledSlider_C>(0x760);
		
		/// <summary>
		/// Name: S_LandClaimRadiusMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x768
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_LandClaimRadiusMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x768);
		
		/// <summary>
		/// Name: S_NightTimeSpeedScale
		/// Type: ObjectProperty
		/// Offset: 0x770
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_NightTimeSpeedScale => ReadUObject<UW_EditableLabeledSlider_C>(0x770);
		
		/// <summary>
		/// Name: S_NPCDamageMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x778
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_NPCDamageMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x778);
		
		/// <summary>
		/// Name: S_NPCRespawnMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x780
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_NPCRespawnMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x780);
		
		/// <summary>
		/// Name: S_PlayerActiveHungerMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x788
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerActiveHungerMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x788);
		
		/// <summary>
		/// Name: S_PlayerActiveThirstMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x790
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerActiveThirstMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x790);
		
		/// <summary>
		/// Name: S_PlayerDamageMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x798
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerDamageMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x798);
		
		/// <summary>
		/// Name: S_PlayerXPCraftMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7A0
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerXPCraftMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7A0);
		
		/// <summary>
		/// Name: S_PlayerXPHarvestMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7A8
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerXPHarvestMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7A8);
		
		/// <summary>
		/// Name: S_PlayerXPKillMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7B0
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerXPKillMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7B0);
		
		/// <summary>
		/// Name: S_PlayerXPRateMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7B8
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerXPRateMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7B8);
		
		/// <summary>
		/// Name: S_PlayerXPTimeMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7C0
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_PlayerXPTimeMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7C0);
		
		/// <summary>
		/// Name: S_ResourceRespawnSpeedMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7C8
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_ResourceRespawnSpeedMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7C8);
		
		/// <summary>
		/// Name: S_StaminaCostMultiplier
		/// Type: ObjectProperty
		/// Offset: 0x7D0
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_StaminaCostMultiplier => ReadUObject<UW_EditableLabeledSlider_C>(0x7D0);
		
		/// <summary>
		/// Name: S_UnconsciousTimeSeconds
		/// Type: ObjectProperty
		/// Offset: 0x7D8
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C S_UnconsciousTimeSeconds => ReadUObject<UW_EditableLabeledSlider_C>(0x7D8);
		
		/// <summary>
		/// Name: TIME_AvatarSummoningRestrictionWeekdayEnd
		/// Type: ObjectProperty
		/// Offset: 0x7E0
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_AvatarSummoningRestrictionWeekdayEnd => ReadUObject<UW_TimeInputBox_C>(0x7E0);
		
		/// <summary>
		/// Name: TIME_AvatarSummoningRestrictionWeekdayStart
		/// Type: ObjectProperty
		/// Offset: 0x7E8
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_AvatarSummoningRestrictionWeekdayStart => ReadUObject<UW_TimeInputBox_C>(0x7E8);
		
		/// <summary>
		/// Name: TIME_AvatarSummoningRestrictionWeekendEnd
		/// Type: ObjectProperty
		/// Offset: 0x7F0
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_AvatarSummoningRestrictionWeekendEnd => ReadUObject<UW_TimeInputBox_C>(0x7F0);
		
		/// <summary>
		/// Name: TIME_AvatarSummoningRestrictionWeekendStart
		/// Type: ObjectProperty
		/// Offset: 0x7F8
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_AvatarSummoningRestrictionWeekendStart => ReadUObject<UW_TimeInputBox_C>(0x7F8);
		
		/// <summary>
		/// Name: TIME_PVPBuildingDamageRestrictionWeekdayEnd
		/// Type: ObjectProperty
		/// Offset: 0x800
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPBuildingDamageRestrictionWeekdayEnd => ReadUObject<UW_TimeInputBox_C>(0x800);
		
		/// <summary>
		/// Name: TIME_PVPBuildingDamageRestrictionWeekdayStart
		/// Type: ObjectProperty
		/// Offset: 0x808
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPBuildingDamageRestrictionWeekdayStart => ReadUObject<UW_TimeInputBox_C>(0x808);
		
		/// <summary>
		/// Name: TIME_PVPBuildingDamageRestrictionWeekendEnd
		/// Type: ObjectProperty
		/// Offset: 0x810
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPBuildingDamageRestrictionWeekendEnd => ReadUObject<UW_TimeInputBox_C>(0x810);
		
		/// <summary>
		/// Name: TIME_PVPBuildingDamageRestrictionWeekendStart
		/// Type: ObjectProperty
		/// Offset: 0x818
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPBuildingDamageRestrictionWeekendStart => ReadUObject<UW_TimeInputBox_C>(0x818);
		
		/// <summary>
		/// Name: TIME_PVPRestrictionWeekdayEnd
		/// Type: ObjectProperty
		/// Offset: 0x820
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPRestrictionWeekdayEnd => ReadUObject<UW_TimeInputBox_C>(0x820);
		
		/// <summary>
		/// Name: TIME_PVPRestrictionWeekdayStart
		/// Type: ObjectProperty
		/// Offset: 0x828
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPRestrictionWeekdayStart => ReadUObject<UW_TimeInputBox_C>(0x828);
		
		/// <summary>
		/// Name: TIME_PVPRestrictionWeekendEnd
		/// Type: ObjectProperty
		/// Offset: 0x830
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPRestrictionWeekendEnd => ReadUObject<UW_TimeInputBox_C>(0x830);
		
		/// <summary>
		/// Name: TIME_PVPRestrictionWeekendStart
		/// Type: ObjectProperty
		/// Offset: 0x838
		/// Size: 0x08
		/// </summary>
		public UW_TimeInputBox_C TIME_PVPRestrictionWeekendStart => ReadUObject<UW_TimeInputBox_C>(0x838);
		
		/// <summary>
		/// Name: TXT_CategoryChat
		/// Type: ObjectProperty
		/// Offset: 0x840
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryChat => ReadUObject<UTextBlock>(0x840);
		
		/// <summary>
		/// Name: TXT_CategoryCombat
		/// Type: ObjectProperty
		/// Offset: 0x848
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryCombat => ReadUObject<UTextBlock>(0x848);
		
		/// <summary>
		/// Name: TXT_CategoryCrafting
		/// Type: ObjectProperty
		/// Offset: 0x850
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryCrafting => ReadUObject<UTextBlock>(0x850);
		
		/// <summary>
		/// Name: TXT_CategoryDayNightCycle
		/// Type: ObjectProperty
		/// Offset: 0x858
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryDayNightCycle => ReadUObject<UTextBlock>(0x858);
		
		/// <summary>
		/// Name: TXT_CategoryGeneral
		/// Type: ObjectProperty
		/// Offset: 0x860
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryGeneral => ReadUObject<UTextBlock>(0x860);
		
		/// <summary>
		/// Name: TXT_CategoryHarvesting
		/// Type: ObjectProperty
		/// Offset: 0x868
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryHarvesting => ReadUObject<UTextBlock>(0x868);
		
		/// <summary>
		/// Name: TXT_CategoryProgression
		/// Type: ObjectProperty
		/// Offset: 0x870
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryProgression => ReadUObject<UTextBlock>(0x870);
		
		/// <summary>
		/// Name: TXT_CategoryRegionAccessControl
		/// Type: ObjectProperty
		/// Offset: 0x878
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategoryRegionAccessControl => ReadUObject<UTextBlock>(0x878);
		
		/// <summary>
		/// Name: TXT_CategorySurvival
		/// Type: ObjectProperty
		/// Offset: 0x880
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_CategorySurvival => ReadUObject<UTextBlock>(0x880);
		
		/// <summary>
		/// Name: TXT_ServerLocalTime
		/// Type: ObjectProperty
		/// Offset: 0x888
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_ServerLocalTime => ReadUObject<UTextBlock>(0x888);
		
		/// <summary>
		/// Name: CommunityOptions
		/// Type: TArray<>
		/// Offset: 0x890
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: RegionOpstions
		/// Type: TArray<>
		/// Offset: 0x8A0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: nudityOptions
		/// Type: TArray<>
		/// Offset: 0x8B0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: VoiceChatOptions
		/// Type: TArray<>
		/// Offset: 0x8C0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ServerDayName
		/// Type: StrProperty
		/// Offset: 0x8D0
		/// Size: 0x10
		/// </summary>
		public FString ServerDayName => new FString(BaseAddress+0x8D0);
		
	}


	/// <summary>
	/// UW_Settings_C:USettingsBase
	/// Size: 0x4A0
	/// Properties: 24
	/// </summary>
	public class UW_Settings_C:USettingsBase
	{
		public override int ObjectSize => 1184;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: B_Apply
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Apply => ReadUObject<UW_ButtonLarge_C>(0x3D8);
		
		/// <summary>
		/// Name: B_Back
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Back => ReadUObject<UW_ButtonLarge_C>(0x3E0);
		
		/// <summary>
		/// Name: B_ConfirmDialog_Accept
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_ConfirmDialog_Accept => ReadUObject<UW_ButtonLarge_C>(0x3E8);
		
		/// <summary>
		/// Name: B_ConfirmDialog_Revert
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_ConfirmDialog_Revert => ReadUObject<UW_ButtonLarge_C>(0x3F0);
		
		/// <summary>
		/// Name: B_Cross
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Cross => ReadUObject<UW_ButtonNormal_C>(0x3F8);
		
		/// <summary>
		/// Name: B_RestoreDefaults
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_RestoreDefaults => ReadUObject<UW_ButtonLarge_C>(0x400);
		
		/// <summary>
		/// Name: B_Submenu_Audio
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_Audio => ReadUObject<UW_TabButton_C>(0x408);
		
		/// <summary>
		/// Name: B_Submenu_Control
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_Control => ReadUObject<UW_TabButton_C>(0x410);
		
		/// <summary>
		/// Name: B_Submenu_Gameplay
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_Gameplay => ReadUObject<UW_TabButton_C>(0x418);
		
		/// <summary>
		/// Name: B_Submenu_KeyBindings
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_KeyBindings => ReadUObject<UW_TabButton_C>(0x420);
		
		/// <summary>
		/// Name: B_Submenu_ServerSettings
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_ServerSettings => ReadUObject<UW_TabButton_C>(0x428);
		
		/// <summary>
		/// Name: B_Submenu_Video
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UW_TabButton_C B_Submenu_Video => ReadUObject<UW_TabButton_C>(0x430);
		
		/// <summary>
		/// Name: ConfirmSettings
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UBorder ConfirmSettings => ReadUObject<UBorder>(0x438);
		
		/// <summary>
		/// Name: MenuSwitcher
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UWidgetSwitcher MenuSwitcher => ReadUObject<UWidgetSwitcher>(0x440);
		
		/// <summary>
		/// Name: T_RestoreDefaultLabel
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_RestoreDefaultLabel => ReadUObject<UTextBlock>(0x448);
		
		/// <summary>
		/// Name: Timer
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UTextBlock Timer => ReadUObject<UTextBlock>(0x450);
		
		/// <summary>
		/// Name: W_Settings_Audio
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Audio_C W_Settings_Audio => ReadUObject<UW_Settings_Audio_C>(0x458);
		
		/// <summary>
		/// Name: W_Settings_Control
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Control_C W_Settings_Control => ReadUObject<UW_Settings_Control_C>(0x460);
		
		/// <summary>
		/// Name: W_Settings_Gameplay
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Gameplay_C W_Settings_Gameplay => ReadUObject<UW_Settings_Gameplay_C>(0x468);
		
		/// <summary>
		/// Name: W_Settings_KeyBindings
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UW_Settings_KeyBindings_C W_Settings_KeyBindings => ReadUObject<UW_Settings_KeyBindings_C>(0x470);
		
		/// <summary>
		/// Name: W_Settings_Server
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Server_C W_Settings_Server => ReadUObject<UW_Settings_Server_C>(0x478);
		
		/// <summary>
		/// Name: W_Settings_Video
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Video_C W_Settings_Video => ReadUObject<UW_Settings_Video_C>(0x480);
		
		/// <summary>
		/// Name: TimerValue
		/// Type: IntProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public int TimerValue
		{
			get
			{
				return ReadInt32(0x488);
			}
			set
			{
				WriteInt32(0x488,value);
			}
		}
		
	}


	/// <summary>
	/// UW_Settings_Audio_C:USettingsAudioBase
	/// Size: 0x438
	/// Properties: 16
	/// </summary>
	public class UW_Settings_Audio_C:USettingsAudioBase
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: C_EditGuildNameCont
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UOverlay C_EditGuildNameCont => ReadUObject<UOverlay>(0x3B8);
		
		/// <summary>
		/// Name: CB_SubtitlesEnabled
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_SubtitlesEnabled => ReadUObject<UW_ButtonNormal_C>(0x3C0);
		
		/// <summary>
		/// Name: Overlay
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay => ReadUObject<UOverlay>(0x3C8);
		
		/// <summary>
		/// Name: Overlay1
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay1 => ReadUObject<UOverlay>(0x3D0);
		
		/// <summary>
		/// Name: Overlay2
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay2 => ReadUObject<UOverlay>(0x3D8);
		
		/// <summary>
		/// Name: Overlay3
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay3 => ReadUObject<UOverlay>(0x3E0);
		
		/// <summary>
		/// Name: S_MasterVolume
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_MasterVolume => ReadUObject<UW_FCSlider_C>(0x3E8);
		
		/// <summary>
		/// Name: S_MusicVolume
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_MusicVolume => ReadUObject<UW_FCSlider_C>(0x3F0);
		
		/// <summary>
		/// Name: S_SFXVolume
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_SFXVolume => ReadUObject<UW_FCSlider_C>(0x3F8);
		
		/// <summary>
		/// Name: S_VoiceChatVolume
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_VoiceChatVolume => ReadUObject<UW_FCSlider_C>(0x400);
		
		/// <summary>
		/// Name: S_VoiceVolume
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_VoiceVolume => ReadUObject<UW_FCSlider_C>(0x408);
		
		/// <summary>
		/// Name: TextMaster
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextMaster => ReadUObject<UTextBlock>(0x410);
		
		/// <summary>
		/// Name: TextMusic
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextMusic => ReadUObject<UTextBlock>(0x418);
		
		/// <summary>
		/// Name: TextSFX
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextSFX => ReadUObject<UTextBlock>(0x420);
		
		/// <summary>
		/// Name: TextVoice
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextVoice => ReadUObject<UTextBlock>(0x428);
		
		/// <summary>
		/// Name: TextVoiceChat
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextVoiceChat => ReadUObject<UTextBlock>(0x430);
		
	}


	/// <summary>
	/// UW_Settings_Control_C:USettingsControlBase
	/// Size: 0x438
	/// Properties: 17
	/// </summary>
	public class UW_Settings_Control_C:USettingsControlBase
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3B0);
		
		/// <summary>
		/// Name: Category
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UTextBlock Category => ReadUObject<UTextBlock>(0x3B8);
		
		/// <summary>
		/// Name: CB_MouseInvertY
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_MouseInvertY => ReadUObject<UW_ButtonNormal_C>(0x3C0);
		
		/// <summary>
		/// Name: CB_RightAxisInvertY
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_RightAxisInvertY => ReadUObject<UW_ButtonNormal_C>(0x3C8);
		
		/// <summary>
		/// Name: Overlay
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay => ReadUObject<UOverlay>(0x3D0);
		
		/// <summary>
		/// Name: Overlay1
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay1 => ReadUObject<UOverlay>(0x3D8);
		
		/// <summary>
		/// Name: Overlay2
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay2 => ReadUObject<UOverlay>(0x3E0);
		
		/// <summary>
		/// Name: Overlay3
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay3 => ReadUObject<UOverlay>(0x3E8);
		
		/// <summary>
		/// Name: S_LeftAxisDeadzone
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_LeftAxisDeadzone => ReadUObject<UW_FCSlider_C>(0x3F0);
		
		/// <summary>
		/// Name: S_RightAxisDeadzone
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_RightAxisDeadzone => ReadUObject<UW_FCSlider_C>(0x3F8);
		
		/// <summary>
		/// Name: S_RightAxisSensitivity
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_RightAxisSensitivity => ReadUObject<UW_FCSlider_C>(0x400);
		
		/// <summary>
		/// Name: S_Sensitivity
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_Sensitivity => ReadUObject<UW_FCSlider_C>(0x408);
		
		/// <summary>
		/// Name: TextBlock
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextBlock => ReadUObject<UTextBlock>(0x410);
		
		/// <summary>
		/// Name: TextLeftAxisDead
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextLeftAxisDead => ReadUObject<UTextBlock>(0x418);
		
		/// <summary>
		/// Name: TextMouseSens
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextMouseSens => ReadUObject<UTextBlock>(0x420);
		
		/// <summary>
		/// Name: TextRightAxisDead
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextRightAxisDead => ReadUObject<UTextBlock>(0x428);
		
		/// <summary>
		/// Name: TextRightAxisSens
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextRightAxisSens => ReadUObject<UTextBlock>(0x430);
		
	}


	/// <summary>
	/// UW_Settings_Gameplay_C:USettingsGameplayBase
	/// Size: 0x4D0
	/// Properties: 6
	/// </summary>
	public class UW_Settings_Gameplay_C:USettingsGameplayBase
	{
		public override int ObjectSize => 1232;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4A0);
		
		/// <summary>
		/// Name: CB_FloatingNames
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_FloatingNames => ReadUObject<UW_ButtonNormal_C>(0x4A8);
		
		/// <summary>
		/// Name: CB_ToggleDodge
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_ToggleDodge => ReadUObject<UW_ButtonNormal_C>(0x4B0);
		
		/// <summary>
		/// Name: CBS_ChatVisibility
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_ChatVisibility => ReadUObject<UW_FCComboBoxString_C>(0x4B8);
		
		/// <summary>
		/// Name: CBS_Language
		/// Type: ObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_Language => ReadUObject<UW_FCComboBoxString_C>(0x4C0);
		
		/// <summary>
		/// Name: NudityOption
		/// Type: ObjectProperty
		/// Offset: 0x4C8
		/// Size: 0x08
		/// </summary>
		public UW_NudityOption_C NudityOption => ReadUObject<UW_NudityOption_C>(0x4C8);
		
	}


	/// <summary>
	/// UW_NudityOption_C:URootWidget
	/// Size: 0xA78
	/// Properties: 13
	/// </summary>
	public class UW_NudityOption_C:URootWidget
	{
		public override int ObjectSize => 2680;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x308);
		
		/// <summary>
		/// Name: CB_Full
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_Full => ReadUObject<UW_ButtonNormal_C>(0x310);
		
		/// <summary>
		/// Name: CB_No
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_No => ReadUObject<UW_ButtonNormal_C>(0x318);
		
		/// <summary>
		/// Name: CB_Partial
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_Partial => ReadUObject<UW_ButtonNormal_C>(0x320);
		
		/// <summary>
		/// Name: MaximumNudityText
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UTextBlock MaximumNudityText => ReadUObject<UTextBlock>(0x328);
		
		/// <summary>
		/// Name: CharacterCreation
		/// Type: BoolProperty
		/// Offset: 0x340
		/// Size: 0x01
		/// </summary>
		public bool CharacterCreation
		{
			get
			{
				return ReadBool(0x340);
			}
			set
			{
				WriteBool(0x340,value);
			}
		}
		
		/// <summary>
		/// Name: ImageSize
		/// Type: StructProperty
		/// Offset: 0x344
		/// Size: 0x08
		/// </summary>
		public FVector2D ImageSize => ReadStruct<FVector2D>(0x344);
		
		/// <summary>
		/// Name: CheckedTexture
		/// Type: ObjectProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		public UTexture2D CheckedTexture => ReadUObject<UTexture2D>(0x350);
		
		/// <summary>
		/// Name: HoverTexture
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UTexture2D HoverTexture => ReadUObject<UTexture2D>(0x358);
		
		/// <summary>
		/// Name: UnCheckedTexture
		/// Type: ObjectProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public UTexture2D UnCheckedTexture => ReadUObject<UTexture2D>(0x360);
		
		/// <summary>
		/// Name: FontColorUnChecked
		/// Type: StructProperty
		/// Offset: 0x368
		/// Size: 0x28
		/// </summary>
		public FSlateColor FontColorUnChecked => ReadStruct<FSlateColor>(0x368);
		
		/// <summary>
		/// Name: FontColorChecked
		/// Type: StructProperty
		/// Offset: 0x390
		/// Size: 0x28
		/// </summary>
		public FSlateColor FontColorChecked => ReadStruct<FSlateColor>(0x390);
		
		/// <summary>
		/// Name: NudityButtonStyleCharacterCreation
		/// Type: StructProperty
		/// Offset: 0x3B8
		/// Size: 0x6C0
		/// </summary>
		public FFCButtonStyle NudityButtonStyleCharacterCreation => ReadStruct<FFCButtonStyle>(0x3B8);
		
	}


	/// <summary>
	/// UW_Settings_KeyBindings_C:USettingsKeyBindingsBase
	/// Size: 0x3A0
	/// Properties: 3
	/// </summary>
	public class UW_Settings_KeyBindings_C:USettingsKeyBindingsBase
	{
		public override int ObjectSize => 928;
		/// <summary>
		/// Name: Commands
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UW_KeyBindings_Commands_C Commands => ReadUObject<UW_KeyBindings_Commands_C>(0x388);
		
		/// <summary>
		/// Name: MappingsScrollBox
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UScrollBox MappingsScrollBox => ReadUObject<UScrollBox>(0x390);
		
		/// <summary>
		/// Name: VB_KeyBindingsList
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UVerticalBox VB_KeyBindingsList => ReadUObject<UVerticalBox>(0x398);
		
	}


	/// <summary>
	/// UW_KeyBindings_Commands_C:UKeyBindingsCommandBase
	/// Size: 0x3F0
	/// Properties: 6
	/// </summary>
	public class UW_KeyBindings_Commands_C:UKeyBindingsCommandBase
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: Category
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UTextBlock Category => ReadUObject<UTextBlock>(0x3C0);
		
		/// <summary>
		/// Name: Five
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_Keybindings_Command_C Five => ReadUObject<UW_Keybindings_Command_C>(0x3C8);
		
		/// <summary>
		/// Name: Four
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_Keybindings_Command_C Four => ReadUObject<UW_Keybindings_Command_C>(0x3D0);
		
		/// <summary>
		/// Name: One
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UW_Keybindings_Command_C One => ReadUObject<UW_Keybindings_Command_C>(0x3D8);
		
		/// <summary>
		/// Name: Three
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UW_Keybindings_Command_C Three => ReadUObject<UW_Keybindings_Command_C>(0x3E0);
		
		/// <summary>
		/// Name: Two
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_Keybindings_Command_C Two => ReadUObject<UW_Keybindings_Command_C>(0x3E8);
		
	}


	/// <summary>
	/// UW_Keybindings_Command_C:UKeyBindingsCommandEntryBase
	/// Size: 0x3F0
	/// Properties: 6
	/// </summary>
	public class UW_Keybindings_Command_C:UKeyBindingsCommandEntryBase
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3B0);
		
		/// <summary>
		/// Name: ActionMapping
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_KeyBindings_Button_C ActionMapping => ReadUObject<UW_KeyBindings_Button_C>(0x3B8);
		
		/// <summary>
		/// Name: ActionName
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UTextBlock ActionName => ReadUObject<UTextBlock>(0x3C0);
		
		/// <summary>
		/// Name: B_Reset
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Reset => ReadUObject<UW_ButtonNormal_C>(0x3C8);
		
		/// <summary>
		/// Name: TextField
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C TextField => ReadUObject<UW_FCEditableTextBlock_C>(0x3D0);
		
		/// <summary>
		/// Name: Name
		/// Type: TextProperty
		/// Offset: 0x3D8
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UW_KeyBindings_Button_C:UKeyBindingsKeyBase
	/// Size: 0x448
	/// Properties: 3
	/// </summary>
	public class UW_KeyBindings_Button_C:UKeyBindingsKeyBase
	{
		public override int ObjectSize => 1096;
		/// <summary>
		/// Name: BoundKeyIcon
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UW_HotkeyIcon_C BoundKeyIcon => ReadUObject<UW_HotkeyIcon_C>(0x430);
		
		/// <summary>
		/// Name: BoundKeyName
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UTextBlock BoundKeyName => ReadUObject<UTextBlock>(0x438);
		
		/// <summary>
		/// Name: MappingButton
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UButton MappingButton => ReadUObject<UButton>(0x440);
		
	}


	/// <summary>
	/// UW_KeyBindings_Category_C:UKeyBindingsCategoryBase
	/// Size: 0x420
	/// Properties: 2
	/// </summary>
	public class UW_KeyBindings_Category_C:UKeyBindingsCategoryBase
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: Bindings
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Bindings => ReadUObject<UVerticalBox>(0x410);
		
		/// <summary>
		/// Name: Category
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UTextBlock Category => ReadUObject<UTextBlock>(0x418);
		
	}


	/// <summary>
	/// UW_KeyBindings_Entry_C:UKeyBindingsEntryBase
	/// Size: 0x458
	/// Properties: 7
	/// </summary>
	public class UW_KeyBindings_Entry_C:UKeyBindingsEntryBase
	{
		public override int ObjectSize => 1112;
		/// <summary>
		/// Name: ActionMapping
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UTextBlock ActionMapping => ReadUObject<UTextBlock>(0x420);
		
		/// <summary>
		/// Name: B_ClearFirst
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UButton B_ClearFirst => ReadUObject<UButton>(0x428);
		
		/// <summary>
		/// Name: B_ClearSecond
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UButton B_ClearSecond => ReadUObject<UButton>(0x430);
		
		/// <summary>
		/// Name: B_ResetFirst
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UButton B_ResetFirst => ReadUObject<UButton>(0x438);
		
		/// <summary>
		/// Name: B_ResetSecond
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UButton B_ResetSecond => ReadUObject<UButton>(0x440);
		
		/// <summary>
		/// Name: FirstButton
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UW_KeyBindings_Button_C FirstButton => ReadUObject<UW_KeyBindings_Button_C>(0x448);
		
		/// <summary>
		/// Name: SecondButton
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UW_KeyBindings_Button_C SecondButton => ReadUObject<UW_KeyBindings_Button_C>(0x450);
		
	}


	/// <summary>
	/// UW_Settings_Video_C:USettingsVideoBase
	/// Size: 0x500
	/// Properties: 26
	/// </summary>
	public class UW_Settings_Video_C:USettingsVideoBase
	{
		public override int ObjectSize => 1280;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x430);
		
		/// <summary>
		/// Name: CB_FilmGrain
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_FilmGrain => ReadUObject<UW_ButtonNormal_C>(0x438);
		
		/// <summary>
		/// Name: CB_LowEndLaptopMode
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_LowEndLaptopMode => ReadUObject<UW_ButtonNormal_C>(0x440);
		
		/// <summary>
		/// Name: CB_MotionBlur
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_MotionBlur => ReadUObject<UW_ButtonNormal_C>(0x448);
		
		/// <summary>
		/// Name: CB_Vsync
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_Vsync => ReadUObject<UW_ButtonNormal_C>(0x450);
		
		/// <summary>
		/// Name: CBS_AntiAliasing
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_AntiAliasing => ReadUObject<UW_FCComboBoxString_C>(0x458);
		
		/// <summary>
		/// Name: CBS_EffectsQuality
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_EffectsQuality => ReadUObject<UW_FCComboBoxString_C>(0x460);
		
		/// <summary>
		/// Name: CBS_FoliageQuality
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_FoliageQuality => ReadUObject<UW_FCComboBoxString_C>(0x468);
		
		/// <summary>
		/// Name: CBS_GeneralShadows
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_GeneralShadows => ReadUObject<UW_FCComboBoxString_C>(0x470);
		
		/// <summary>
		/// Name: CBS_GraphicsQuality
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_GraphicsQuality => ReadUObject<UW_FCComboBoxString_C>(0x478);
		
		/// <summary>
		/// Name: CBS_MaxFPS
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_MaxFPS => ReadUObject<UW_FCComboBoxString_C>(0x480);
		
		/// <summary>
		/// Name: CBS_PostProcessing
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_PostProcessing => ReadUObject<UW_FCComboBoxString_C>(0x488);
		
		/// <summary>
		/// Name: CBS_Resolution
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_Resolution => ReadUObject<UW_FCComboBoxString_C>(0x490);
		
		/// <summary>
		/// Name: CBS_TerrainShadows
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_TerrainShadows => ReadUObject<UW_FCComboBoxString_C>(0x498);
		
		/// <summary>
		/// Name: CBS_TextureQuality
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_TextureQuality => ReadUObject<UW_FCComboBoxString_C>(0x4A0);
		
		/// <summary>
		/// Name: CBS_ViewDistance
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_ViewDistance => ReadUObject<UW_FCComboBoxString_C>(0x4A8);
		
		/// <summary>
		/// Name: CBS_WindowMode
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_WindowMode => ReadUObject<UW_FCComboBoxString_C>(0x4B0);
		
		/// <summary>
		/// Name: HorizontalBox_Resolution
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UHorizontalBox HorizontalBox_Resolution => ReadUObject<UHorizontalBox>(0x4B8);
		
		/// <summary>
		/// Name: Overlay
		/// Type: ObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay => ReadUObject<UOverlay>(0x4C0);
		
		/// <summary>
		/// Name: Overlay1
		/// Type: ObjectProperty
		/// Offset: 0x4C8
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay1 => ReadUObject<UOverlay>(0x4C8);
		
		/// <summary>
		/// Name: Overlay2
		/// Type: ObjectProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay2 => ReadUObject<UOverlay>(0x4D0);
		
		/// <summary>
		/// Name: S_FOV
		/// Type: ObjectProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_FOV => ReadUObject<UW_FCSlider_C>(0x4D8);
		
		/// <summary>
		/// Name: S_Gamma
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_Gamma => ReadUObject<UW_FCSlider_C>(0x4E0);
		
		/// <summary>
		/// Name: TextGammaValue
		/// Type: ObjectProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextGammaValue => ReadUObject<UTextBlock>(0x4E8);
		
		/// <summary>
		/// Name: TextHFOVValue
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextHFOVValue => ReadUObject<UTextBlock>(0x4F0);
		
		/// <summary>
		/// Name: TextVFOVValue
		/// Type: ObjectProperty
		/// Offset: 0x4F8
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextVFOVValue => ReadUObject<UTextBlock>(0x4F8);
		
	}


}

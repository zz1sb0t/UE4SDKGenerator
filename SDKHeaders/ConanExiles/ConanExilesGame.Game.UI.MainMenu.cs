using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.MainMenu;
using ConanExilesGame.Game.UI.Framework;
using ConanExilesGame.Game.UI.MainMenu.Settings;


namespace ConanExilesGame.Game.UI.MainMenu
{
	/// <summary>
	/// UW_MainMenu_MainMenu_C:UMainMenuBase
	/// Size: 0x488
	/// Properties: 17
	/// </summary>
	public class UW_MainMenu_MainMenu_C:UMainMenuBase
	{
		public override int ObjectSize => 1160;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E0);
		
		/// <summary>
		/// Name: B_ClaimContent
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_ClaimContent => ReadUObject<UW_MainMenuButton_C>(0x3E8);
		
		/// <summary>
		/// Name: B_Credits
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_Credits => ReadUObject<UW_MainMenuButton_C>(0x3F0);
		
		/// <summary>
		/// Name: B_Exit
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_Exit => ReadUObject<UW_MainMenuButton_C>(0x3F8);
		
		/// <summary>
		/// Name: B_HostLocal
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_HostLocal => ReadUObject<UW_MainMenuButton_C>(0x400);
		
		/// <summary>
		/// Name: B_Mods
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_Mods => ReadUObject<UW_MainMenuButton_C>(0x408);
		
		/// <summary>
		/// Name: B_Options
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_Options => ReadUObject<UW_MainMenuButton_C>(0x410);
		
		/// <summary>
		/// Name: B_PatchNotes
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_PatchNotes => ReadUObject<UW_MainMenuButton_C>(0x418);
		
		/// <summary>
		/// Name: B_PlayOnline
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UW_MainMenuButton_C B_PlayOnline => ReadUObject<UW_MainMenuButton_C>(0x420);
		
		/// <summary>
		/// Name: DWInfo
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UTextBlock DWInfo => ReadUObject<UTextBlock>(0x428);
		
		/// <summary>
		/// Name: EAWarning
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UW_EarlyAccessWarning_C EAWarning => ReadUObject<UW_EarlyAccessWarning_C>(0x430);
		
		/// <summary>
		/// Name: HB_SignedIn
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UHorizontalBox HB_SignedIn => ReadUObject<UHorizontalBox>(0x438);
		
		/// <summary>
		/// Name: I_Blood
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UImage I_Blood => ReadUObject<UImage>(0x440);
		
		/// <summary>
		/// Name: T_PlayerNickname
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C T_PlayerNickname => ReadUObject<UW_FCEditableTextBlock_C>(0x448);
		
		/// <summary>
		/// Name: DefaultMap
		/// Type: NameProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Settings
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UW_Settings_C Settings => ReadUObject<UW_Settings_C>(0x468);
		
		/// <summary>
		/// Name: userName
		/// Type: TextProperty
		/// Offset: 0x470
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UW_HostLocal_C:UHostLocalBase
	/// Size: 0x421
	/// Properties: 18
	/// </summary>
	public class UW_HostLocal_C:UHostLocalBase
	{
		public override int ObjectSize => 1057;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x388);
		
		/// <summary>
		/// Name: AcceptAndBack
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UHorizontalBox AcceptAndBack => ReadUObject<UHorizontalBox>(0x390);
		
		/// <summary>
		/// Name: B_Back
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Back => ReadUObject<UW_ButtonLarge_C>(0x398);
		
		/// <summary>
		/// Name: B_Back1
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Back1 => ReadUObject<UW_ButtonLarge_C>(0x3A0);
		
		/// <summary>
		/// Name: B_Continue
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Continue => ReadUObject<UW_ButtonLarge_C>(0x3A8);
		
		/// <summary>
		/// Name: B_Host
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Host => ReadUObject<UW_ButtonLarge_C>(0x3B0);
		
		/// <summary>
		/// Name: B_Recreate
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Recreate => ReadUObject<UW_ButtonLarge_C>(0x3B8);
		
		/// <summary>
		/// Name: Background
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UImage Background => ReadUObject<UImage>(0x3C0);
		
		/// <summary>
		/// Name: ELS_NumberOfPlayers
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_EditableLabeledSlider_C ELS_NumberOfPlayers => ReadUObject<UW_EditableLabeledSlider_C>(0x3C8);
		
		/// <summary>
		/// Name: ET_ServerName
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C ET_ServerName => ReadUObject<UW_FCEditableTextBlock_C>(0x3D0);
		
		/// <summary>
		/// Name: I_Background
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UImage I_Background => ReadUObject<UImage>(0x3D8);
		
		/// <summary>
		/// Name: Overlay_RecreateInfo
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay_RecreateInfo => ReadUObject<UOverlay>(0x3E0);
		
		/// <summary>
		/// Name: RecreateContinueAndBack
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UHorizontalBox RecreateContinueAndBack => ReadUObject<UHorizontalBox>(0x3E8);
		
		/// <summary>
		/// Name: T_Error
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Error => ReadUObject<UTextBlock>(0x3F0);
		
		/// <summary>
		/// Name: VerticalBox_Settings
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UVerticalBox VerticalBox_Settings => ReadUObject<UVerticalBox>(0x3F8);
		
		/// <summary>
		/// Name: W_ServerSettings
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_Settings_Server_C W_ServerSettings => ReadUObject<UW_Settings_Server_C>(0x400);
		
		/// <summary>
		/// Name: Map
		/// Type: NameProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: LocalDBFileExist
		/// Type: BoolProperty
		/// Offset: 0x420
		/// Size: 0x01
		/// </summary>
		public bool LocalDBFileExist
		{
			get
			{
				return ReadBool(0x420);
			}
			set
			{
				WriteBool(0x420,value);
			}
		}
		
	}


	/// <summary>
	/// UW_EarlyAccessWarning_C:URootWidget
	/// Size: 0x358
	/// Properties: 8
	/// </summary>
	public class UW_EarlyAccessWarning_C:URootWidget
	{
		public override int ObjectSize => 856;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x308);
		
		/// <summary>
		/// Name: Anim_FadeIn
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_FadeIn => ReadUObject<UWidgetAnimation>(0x310);
		
		/// <summary>
		/// Name: Anim_ShowAll
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_ShowAll => ReadUObject<UWidgetAnimation>(0x318);
		
		/// <summary>
		/// Name: Anim_FadeAll
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_FadeAll => ReadUObject<UWidgetAnimation>(0x320);
		
		/// <summary>
		/// Name: Brd_Background
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UBorder Brd_Background => ReadUObject<UBorder>(0x328);
		
		/// <summary>
		/// Name: T_Line9
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Line9 => ReadUObject<UTextBlock>(0x330);
		
		/// <summary>
		/// Name: Throbber_Wait
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UThrobber Throbber_Wait => ReadUObject<UThrobber>(0x338);
		
		/// <summary>
		/// Name: Skippable
		/// Type: BoolProperty
		/// Offset: 0x340
		/// Size: 0x01
		/// </summary>
		public bool Skippable
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
		
	}


	/// <summary>
	/// UW_MainMenuButton_C:UW_FCButton_C
	/// Size: 0xC10
	/// Properties: 6
	/// </summary>
	public class UW_MainMenuButton_C:UW_FCButton_C
	{
		public override int ObjectSize => 3088;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xB90);
		
		/// <summary>
		/// Name: Button
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UButton Button => ReadUObject<UButton>(0xB98);
		
		/// <summary>
		/// Name: LabelView
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UTextBlock LabelView => ReadUObject<UTextBlock>(0xBA0);
		
		/// <summary>
		/// Name: label
		/// Type: TextProperty
		/// Offset: 0xBA8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HoverColor
		/// Type: StructProperty
		/// Offset: 0xBC0
		/// Size: 0x28
		/// </summary>
		public FSlateColor HoverColor => ReadStruct<FSlateColor>(0xBC0);
		
		/// <summary>
		/// Name: DefaultColor
		/// Type: StructProperty
		/// Offset: 0xBE8
		/// Size: 0x28
		/// </summary>
		public FSlateColor DefaultColor => ReadStruct<FSlateColor>(0xBE8);
		
	}


	/// <summary>
	/// UW_ServerList_C:UWindowRoot
	/// Size: 0x6A0
	/// Properties: 73
	/// </summary>
	public class UW_ServerList_C:UWindowRoot
	{
		public override int ObjectSize => 1696;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: B_Back
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Back => ReadUObject<UW_ButtonNormal_C>(0x380);
		
		/// <summary>
		/// Name: B_BattleEyeOk
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_BattleEyeOk => ReadUObject<UW_ButtonNormal_C>(0x388);
		
		/// <summary>
		/// Name: B_DConnectBack
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_DConnectBack => ReadUObject<UW_ButtonNormal_C>(0x390);
		
		/// <summary>
		/// Name: B_DConnectOk
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_DConnectOk => ReadUObject<UW_ButtonNormal_C>(0x398);
		
		/// <summary>
		/// Name: B_DirectConnect
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_DirectConnect => ReadUObject<UW_ButtonNormal_C>(0x3A0);
		
		/// <summary>
		/// Name: B_MainBack
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_MainBack => ReadUObject<UW_ButtonNormal_C>(0x3A8);
		
		/// <summary>
		/// Name: B_MainFavorite
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_MainFavorite => ReadUObject<UW_ButtonNormal_C>(0x3B0);
		
		/// <summary>
		/// Name: B_MainGPortal
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_MainGPortal => ReadUObject<UW_ButtonNormal_C>(0x3B8);
		
		/// <summary>
		/// Name: B_MainJoin
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_MainJoin => ReadUObject<UW_ButtonNormal_C>(0x3C0);
		
		/// <summary>
		/// Name: B_MainUnfavorite
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_MainUnfavorite => ReadUObject<UW_ButtonNormal_C>(0x3C8);
		
		/// <summary>
		/// Name: B_ManiRefresh
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_ManiRefresh => ReadUObject<UW_ButtonNormal_C>(0x3D0);
		
		/// <summary>
		/// Name: B_ServerFullOk
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_ServerFullOk => ReadUObject<UW_ButtonNormal_C>(0x3D8);
		
		/// <summary>
		/// Name: B_SkipToList
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_SkipToList => ReadUObject<UW_ButtonNormal_C>(0x3E0);
		
		/// <summary>
		/// Name: B_SortOnBattleEye
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnBattleEye => ReadUObject<UW_ButtonCustom_C>(0x3E8);
		
		/// <summary>
		/// Name: B_SortOnName
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnName => ReadUObject<UW_ButtonCustom_C>(0x3F0);
		
		/// <summary>
		/// Name: B_SortOnOfficial
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnOfficial => ReadUObject<UW_ButtonCustom_C>(0x3F8);
		
		/// <summary>
		/// Name: B_SortOnPing
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnPing => ReadUObject<UW_ButtonCustom_C>(0x400);
		
		/// <summary>
		/// Name: B_SortOnPlayers
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnPlayers => ReadUObject<UW_ButtonCustom_C>(0x408);
		
		/// <summary>
		/// Name: B_SortOnRegion
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnRegion => ReadUObject<UW_ButtonCustom_C>(0x410);
		
		/// <summary>
		/// Name: B_SortOnType
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnType => ReadUObject<UW_ButtonCustom_C>(0x418);
		
		/// <summary>
		/// Name: B_SortOnVersion
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_SortOnVersion => ReadUObject<UW_ButtonCustom_C>(0x420);
		
		/// <summary>
		/// Name: Brd_SelectBackground
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UBorder Brd_SelectBackground => ReadUObject<UBorder>(0x428);
		
		/// <summary>
		/// Name: CB_FullServers
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_FullServers => ReadUObject<UW_ButtonNormal_C>(0x430);
		
		/// <summary>
		/// Name: CB_ModsEnabled
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_ModsEnabled => ReadUObject<UW_ButtonNormal_C>(0x438);
		
		/// <summary>
		/// Name: CB_NEVERAGAIN
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_NEVERAGAIN => ReadUObject<UW_ButtonNormal_C>(0x440);
		
		/// <summary>
		/// Name: CB_SearchLAN
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UCheckBox CB_SearchLAN => ReadUObject<UCheckBox>(0x448);
		
		/// <summary>
		/// Name: CB_ShowInvalidServers
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_ShowInvalidServers => ReadUObject<UW_ButtonNormal_C>(0x450);
		
		/// <summary>
		/// Name: CBS_CombatType
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_CombatType => ReadUObject<UW_FCComboBoxString_C>(0x458);
		
		/// <summary>
		/// Name: CBS_Community
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_Community => ReadUObject<UW_FCComboBoxString_C>(0x460);
		
		/// <summary>
		/// Name: CBS_SteamFilter
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UW_FCComboBoxString_C CBS_SteamFilter => ReadUObject<UW_FCComboBoxString_C>(0x468);
		
		/// <summary>
		/// Name: CheckingHistory
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UBorder CheckingHistory => ReadUObject<UBorder>(0x470);
		
		/// <summary>
		/// Name: GPortalLabel
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UTextBlock GPortalLabel => ReadUObject<UTextBlock>(0x478);
		
		/// <summary>
		/// Name: I_CommunityBackground
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UImage I_CommunityBackground => ReadUObject<UImage>(0x480);
		
		/// <summary>
		/// Name: I_SortArrowBattleye
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowBattleye => ReadUObject<UImage>(0x488);
		
		/// <summary>
		/// Name: I_SortArrowMode
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowMode => ReadUObject<UImage>(0x490);
		
		/// <summary>
		/// Name: I_SortArrowName
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowName => ReadUObject<UImage>(0x498);
		
		/// <summary>
		/// Name: I_SortArrowOfficial
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowOfficial => ReadUObject<UImage>(0x4A0);
		
		/// <summary>
		/// Name: I_SortArrowPing
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowPing => ReadUObject<UImage>(0x4A8);
		
		/// <summary>
		/// Name: I_SortArrowPlayers
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowPlayers => ReadUObject<UImage>(0x4B0);
		
		/// <summary>
		/// Name: I_SortArrowRegion
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowRegion => ReadUObject<UImage>(0x4B8);
		
		/// <summary>
		/// Name: I_SortArrowVersion
		/// Type: ObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public UImage I_SortArrowVersion => ReadUObject<UImage>(0x4C0);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x4C8
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x4C8);
		
		/// <summary>
		/// Name: Image1
		/// Type: ObjectProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		public UImage Image1 => ReadUObject<UImage>(0x4D0);
		
		/// <summary>
		/// Name: InputT_NameSearch
		/// Type: ObjectProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C InputT_NameSearch => ReadUObject<UW_FCEditableTextBlock_C>(0x4D8);
		
		/// <summary>
		/// Name: ListUpdateProgressView
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public UTextBlock ListUpdateProgressView => ReadUObject<UTextBlock>(0x4E0);
		
		/// <summary>
		/// Name: MainGPortalBox
		/// Type: ObjectProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public USizeBox MainGPortalBox => ReadUObject<USizeBox>(0x4E8);
		
		/// <summary>
		/// Name: ServerList
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public UW_ServerListView_C ServerList => ReadUObject<UW_ServerListView_C>(0x4F0);
		
		/// <summary>
		/// Name: ServerListScrollBox
		/// Type: ObjectProperty
		/// Offset: 0x4F8
		/// Size: 0x08
		/// </summary>
		public UScrollBox ServerListScrollBox => ReadUObject<UScrollBox>(0x4F8);
		
		/// <summary>
		/// Name: ServerMods
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public UVerticalBox ServerMods => ReadUObject<UVerticalBox>(0x500);
		
		/// <summary>
		/// Name: ServerSettings
		/// Type: ObjectProperty
		/// Offset: 0x508
		/// Size: 0x08
		/// </summary>
		public UVerticalBox ServerSettings => ReadUObject<UVerticalBox>(0x508);
		
		/// <summary>
		/// Name: T_DConnectIP
		/// Type: ObjectProperty
		/// Offset: 0x510
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C T_DConnectIP => ReadUObject<UW_FCEditableTextBlock_C>(0x510);
		
		/// <summary>
		/// Name: T_DConnectPassword
		/// Type: ObjectProperty
		/// Offset: 0x518
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C T_DConnectPassword => ReadUObject<UW_FCEditableTextBlock_C>(0x518);
		
		/// <summary>
		/// Name: T_DConnectTimeOut
		/// Type: ObjectProperty
		/// Offset: 0x520
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_DConnectTimeOut => ReadUObject<UTextBlock>(0x520);
		
		/// <summary>
		/// Name: Throbber_DConnect
		/// Type: ObjectProperty
		/// Offset: 0x528
		/// Size: 0x08
		/// </summary>
		public UThrobber Throbber_DConnect => ReadUObject<UThrobber>(0x528);
		
		/// <summary>
		/// Name: Throbber_SeacrhIndicator
		/// Type: ObjectProperty
		/// Offset: 0x530
		/// Size: 0x08
		/// </summary>
		public UThrobber Throbber_SeacrhIndicator => ReadUObject<UThrobber>(0x530);
		
		/// <summary>
		/// Name: W_BattleEyeDialog
		/// Type: ObjectProperty
		/// Offset: 0x538
		/// Size: 0x08
		/// </summary>
		public UBorder W_BattleEyeDialog => ReadUObject<UBorder>(0x538);
		
		/// <summary>
		/// Name: W_CombatModePicker
		/// Type: ObjectProperty
		/// Offset: 0x540
		/// Size: 0x08
		/// </summary>
		public UW_PvPSelection_C W_CombatModePicker => ReadUObject<UW_PvPSelection_C>(0x540);
		
		/// <summary>
		/// Name: W_CommunityPicker
		/// Type: ObjectProperty
		/// Offset: 0x548
		/// Size: 0x08
		/// </summary>
		public UW_IntentionPicker_C W_CommunityPicker => ReadUObject<UW_IntentionPicker_C>(0x548);
		
		/// <summary>
		/// Name: W_DirectConnect
		/// Type: ObjectProperty
		/// Offset: 0x550
		/// Size: 0x08
		/// </summary>
		public UBorder W_DirectConnect => ReadUObject<UBorder>(0x550);
		
		/// <summary>
		/// Name: W_MainWindow
		/// Type: ObjectProperty
		/// Offset: 0x558
		/// Size: 0x08
		/// </summary>
		public UBorder W_MainWindow => ReadUObject<UBorder>(0x558);
		
		/// <summary>
		/// Name: W_ServerIsFullDialog
		/// Type: ObjectProperty
		/// Offset: 0x560
		/// Size: 0x08
		/// </summary>
		public UBorder W_ServerIsFullDialog => ReadUObject<UBorder>(0x560);
		
		/// <summary>
		/// Name: selectedServer
		/// Type: ObjectProperty
		/// Offset: 0x568
		/// Size: 0x08
		/// </summary>
		public UW_ServerInfo_C selectedServer => ReadUObject<UW_ServerInfo_C>(0x568);
		
		/// <summary>
		/// Name: ServerTypeOptions
		/// Type: TArray<>
		/// Offset: 0x570
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CombatTypeOptions
		/// Type: TArray<>
		/// Offset: 0x580
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CommunityOptions
		/// Type: TArray<>
		/// Offset: 0x590
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CurrentState
		/// Type: IntProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public int CurrentState
		{
			get
			{
				return ReadInt32(0x5A0);
			}
			set
			{
				WriteInt32(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: NoConnectionError
		/// Type: BoolProperty
		/// Offset: 0x5A4
		/// Size: 0x01
		/// </summary>
		public bool NoConnectionError
		{
			get
			{
				return ReadBool(0x5A4);
			}
			set
			{
				WriteBool(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: ConnectTimeOutHandle
		/// Type: StructProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ConnectTimeOutHandle => ReadStruct<FTimerHandle>(0x5A8);
		
		/// <summary>
		/// Name: FindOffical
		/// Type: BoolProperty
		/// Offset: 0x5B0
		/// Size: 0x01
		/// </summary>
		public bool FindOffical
		{
			get
			{
				return ReadBool(0x5B0);
			}
			set
			{
				WriteBool(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: DeselectedColor
		/// Type: StructProperty
		/// Offset: 0x5B4
		/// Size: 0x10
		/// </summary>
		public FLinearColor DeselectedColor => ReadStruct<FLinearColor>(0x5B4);
		
		/// <summary>
		/// Name: SelectedColor
		/// Type: StructProperty
		/// Offset: 0x5C4
		/// Size: 0x10
		/// </summary>
		public FLinearColor SelectedColor => ReadStruct<FLinearColor>(0x5C4);
		
		/// <summary>
		/// Name: JoiningSession
		/// Type: StructProperty
		/// Offset: 0x5D8
		/// Size: 0xC8
		/// </summary>
		public FBlueprintSessionResult JoiningSession => ReadStruct<FBlueprintSessionResult>(0x5D8);
		
	}


	/// <summary>
	/// UW_IntentionPicker_C:UWindowRoot
	/// Size: 0x3D8
	/// Properties: 10
	/// </summary>
	public class UW_IntentionPicker_C:UWindowRoot
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: B_Experimental
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_Experimental => ReadUObject<UW_CommunityButton_C>(0x380);
		
		/// <summary>
		/// Name: B_HardCore
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_HardCore => ReadUObject<UW_CommunityButton_C>(0x388);
		
		/// <summary>
		/// Name: B_Purist
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_Purist => ReadUObject<UW_CommunityButton_C>(0x390);
		
		/// <summary>
		/// Name: B_Random
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_Random => ReadUObject<UW_CommunityButton_C>(0x398);
		
		/// <summary>
		/// Name: B_Relaxed
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_Relaxed => ReadUObject<UW_CommunityButton_C>(0x3A0);
		
		/// <summary>
		/// Name: B_RolePlaying
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C B_RolePlaying => ReadUObject<UW_CommunityButton_C>(0x3A8);
		
		/// <summary>
		/// Name: Description
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UTextBlock Description => ReadUObject<UTextBlock>(0x3B0);
		
		/// <summary>
		/// Name: ServerIntention
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UTextBlock ServerIntention => ReadUObject<UTextBlock>(0x3B8);
		
		/// <summary>
		/// Name: serverType
		/// Type: IntProperty
		/// Offset: 0x3C0
		/// Size: 0x04
		/// </summary>
		public int serverType
		{
			get
			{
				return ReadInt32(0x3C0);
			}
			set
			{
				WriteInt32(0x3C0,value);
			}
		}
		
	}


	/// <summary>
	/// UW_CommunityButton_C:UFCButton
	/// Size: 0xBF0
	/// Properties: 8
	/// </summary>
	public class UW_CommunityButton_C:UFCButton
	{
		public override int ObjectSize => 3056;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xB90);
		
		/// <summary>
		/// Name: Anim_Blood
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Blood => ReadUObject<UWidgetAnimation>(0xB98);
		
		/// <summary>
		/// Name: Anim_Fade
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Fade => ReadUObject<UWidgetAnimation>(0xBA0);
		
		/// <summary>
		/// Name: Button
		/// Type: ObjectProperty
		/// Offset: 0xBA8
		/// Size: 0x08
		/// </summary>
		public UImage Button => ReadUObject<UImage>(0xBA8);
		
		/// <summary>
		/// Name: CommunityLabel
		/// Type: ObjectProperty
		/// Offset: 0xBB0
		/// Size: 0x08
		/// </summary>
		public UTextBlock CommunityLabel => ReadUObject<UTextBlock>(0xBB0);
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0xBB8
		/// Size: 0x08
		/// </summary>
		public UImage Icon => ReadUObject<UImage>(0xBB8);
		
		/// <summary>
		/// Name: CommunityIcon
		/// Type: ObjectProperty
		/// Offset: 0xBC0
		/// Size: 0x08
		/// </summary>
		public UTexture2D CommunityIcon => ReadUObject<UTexture2D>(0xBC0);
		
		/// <summary>
		/// Name: Description
		/// Type: TextProperty
		/// Offset: 0xBC8
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UW_PasswordDialog_C:UPasswordDialogBase
	/// Size: 0x608
	/// Properties: 5
	/// </summary>
	public class UW_PasswordDialog_C:UPasswordDialogBase
	{
		public override int ObjectSize => 1544;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5E0);
		
		/// <summary>
		/// Name: B_Back
		/// Type: ObjectProperty
		/// Offset: 0x5E8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Back => ReadUObject<UW_ButtonNormal_C>(0x5E8);
		
		/// <summary>
		/// Name: B_OK
		/// Type: ObjectProperty
		/// Offset: 0x5F0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_OK => ReadUObject<UW_ButtonNormal_C>(0x5F0);
		
		/// <summary>
		/// Name: CB_SavePassword
		/// Type: ObjectProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C CB_SavePassword => ReadUObject<UW_ButtonNormal_C>(0x5F8);
		
		/// <summary>
		/// Name: T_Password
		/// Type: ObjectProperty
		/// Offset: 0x600
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C T_Password => ReadUObject<UW_FCEditableTextBlock_C>(0x600);
		
	}


	/// <summary>
	/// UW_PvPSelection_C:URootWidget
	/// Size: 0x340
	/// Properties: 5
	/// </summary>
	public class UW_PvPSelection_C:URootWidget
	{
		public override int ObjectSize => 832;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x308);
		
		/// <summary>
		/// Name: Description
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UTextBlock Description => ReadUObject<UTextBlock>(0x310);
		
		/// <summary>
		/// Name: PvEButton
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C PvEButton => ReadUObject<UW_CommunityButton_C>(0x318);
		
		/// <summary>
		/// Name: PvPBlizButton
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UW_BlitzButton_C PvPBlizButton => ReadUObject<UW_BlitzButton_C>(0x320);
		
		/// <summary>
		/// Name: PvPButton
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UW_CommunityButton_C PvPButton => ReadUObject<UW_CommunityButton_C>(0x328);
		
	}


	/// <summary>
	/// UW_BlitzButton_C:UFCButton
	/// Size: 0xBE8
	/// Properties: 7
	/// </summary>
	public class UW_BlitzButton_C:UFCButton
	{
		public override int ObjectSize => 3048;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xB90);
		
		/// <summary>
		/// Name: Anim_Blood
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Blood => ReadUObject<UWidgetAnimation>(0xB98);
		
		/// <summary>
		/// Name: Anim_Fade
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Fade => ReadUObject<UWidgetAnimation>(0xBA0);
		
		/// <summary>
		/// Name: Button
		/// Type: ObjectProperty
		/// Offset: 0xBA8
		/// Size: 0x08
		/// </summary>
		public UImage Button => ReadUObject<UImage>(0xBA8);
		
		/// <summary>
		/// Name: CommunityLabel
		/// Type: ObjectProperty
		/// Offset: 0xBB0
		/// Size: 0x08
		/// </summary>
		public UTextBlock CommunityLabel => ReadUObject<UTextBlock>(0xBB0);
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0xBB8
		/// Size: 0x08
		/// </summary>
		public UImage Icon => ReadUObject<UImage>(0xBB8);
		
		/// <summary>
		/// Name: Description
		/// Type: TextProperty
		/// Offset: 0xBC0
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UW_ServerInfo_C:UServerInfoBase
	/// Size: 0xB18
	/// Properties: 18
	/// </summary>
	public class UW_ServerInfo_C:UServerInfoBase
	{
		public override int ObjectSize => 2840;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x548
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x548);
		
		/// <summary>
		/// Name: Anim_FavoriteAdded
		/// Type: ObjectProperty
		/// Offset: 0x550
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_FavoriteAdded => ReadUObject<UWidgetAnimation>(0x550);
		
		/// <summary>
		/// Name: B_SelectThis
		/// Type: ObjectProperty
		/// Offset: 0x558
		/// Size: 0x08
		/// </summary>
		public UButton B_SelectThis => ReadUObject<UButton>(0x558);
		
		/// <summary>
		/// Name: Border
		/// Type: ObjectProperty
		/// Offset: 0x560
		/// Size: 0x08
		/// </summary>
		public UBorder Border => ReadUObject<UBorder>(0x560);
		
		/// <summary>
		/// Name: Brd_ActiveIndicator
		/// Type: ObjectProperty
		/// Offset: 0x568
		/// Size: 0x08
		/// </summary>
		public UBorder Brd_ActiveIndicator => ReadUObject<UBorder>(0x568);
		
		/// <summary>
		/// Name: I_Battleye
		/// Type: ObjectProperty
		/// Offset: 0x570
		/// Size: 0x08
		/// </summary>
		public UImage I_Battleye => ReadUObject<UImage>(0x570);
		
		/// <summary>
		/// Name: I_Favorite
		/// Type: ObjectProperty
		/// Offset: 0x578
		/// Size: 0x08
		/// </summary>
		public UImage I_Favorite => ReadUObject<UImage>(0x578);
		
		/// <summary>
		/// Name: I_Official
		/// Type: ObjectProperty
		/// Offset: 0x580
		/// Size: 0x08
		/// </summary>
		public UImage I_Official => ReadUObject<UImage>(0x580);
		
		/// <summary>
		/// Name: I_Password
		/// Type: ObjectProperty
		/// Offset: 0x588
		/// Size: 0x08
		/// </summary>
		public UImage I_Password => ReadUObject<UImage>(0x588);
		
		/// <summary>
		/// Name: T_CombatMode
		/// Type: ObjectProperty
		/// Offset: 0x590
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_CombatMode => ReadUObject<UTextBlock>(0x590);
		
		/// <summary>
		/// Name: T_Name
		/// Type: ObjectProperty
		/// Offset: 0x598
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Name => ReadUObject<UTextBlock>(0x598);
		
		/// <summary>
		/// Name: T_Ping
		/// Type: ObjectProperty
		/// Offset: 0x5A0
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Ping => ReadUObject<UTextBlock>(0x5A0);
		
		/// <summary>
		/// Name: T_Players
		/// Type: ObjectProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Players => ReadUObject<UTextBlock>(0x5A8);
		
		/// <summary>
		/// Name: T_Region
		/// Type: ObjectProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Region => ReadUObject<UTextBlock>(0x5B0);
		
		/// <summary>
		/// Name: T_Version
		/// Type: ObjectProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Version => ReadUObject<UTextBlock>(0x5B8);
		
		/// <summary>
		/// Name: TextBlock
		/// Type: ObjectProperty
		/// Offset: 0x5C0
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextBlock => ReadUObject<UTextBlock>(0x5C0);
		
		/// <summary>
		/// Name: ValidStyle
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0x2A8
		/// </summary>
		public FButtonStyle ValidStyle => ReadStruct<FButtonStyle>(0x5C8);
		
		/// <summary>
		/// Name: InvalidStyle
		/// Type: StructProperty
		/// Offset: 0x870
		/// Size: 0x2A8
		/// </summary>
		public FButtonStyle InvalidStyle => ReadStruct<FButtonStyle>(0x870);
		
	}


	/// <summary>
	/// UW_ServerListView_C:UServerListView
	/// Size: 0x498
	/// Properties: 1
	/// </summary>
	public class UW_ServerListView_C:UServerListView
	{
		public override int ObjectSize => 1176;
		/// <summary>
		/// Name: ServerList
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public UGridPanel ServerList => ReadUObject<UGridPanel>(0x490);
		
	}


	/// <summary>
	/// UW_ServerSetting_C:UUserWidget
	/// Size: 0x248
	/// Properties: 2
	/// </summary>
	public class UW_ServerSetting_C:UUserWidget
	{
		public override int ObjectSize => 584;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: setting
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UTextBlock setting => ReadUObject<UTextBlock>(0x240);
		
	}


}

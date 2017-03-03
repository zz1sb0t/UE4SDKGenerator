using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;
using ConanExilesGame.Game.Systems.Buffs;
using ConanExilesGame.Game.UI.HUD.Notifications;
using ConanExilesGame.Game.UI.HUD;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Systems;


namespace ConanExilesGame.Game.UI.HUD
{
	/// <summary>
	/// UW_IngameLoadingScreen_C:UConanIngameLoadingScreen
	/// Size: 0x398
	/// Properties: 4
	/// </summary>
	public class UW_IngameLoadingScreen_C:UConanIngameLoadingScreen
	{
		public override int ObjectSize => 920;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: StartUpAnimation
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation StartUpAnimation => ReadUObject<UWidgetAnimation>(0x380);
		
		/// <summary>
		/// Name: LongThrobber
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UThrobber LongThrobber => ReadUObject<UThrobber>(0x388);
		
		/// <summary>
		/// Name: Text
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UTextBlock Text => ReadUObject<UTextBlock>(0x390);
		
	}


	/// <summary>
	/// UW_InputBox_C:UInputBoxWidget
	/// Size: 0x3E0
	/// Properties: 5
	/// </summary>
	public class UW_InputBox_C:UInputBoxWidget
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: B_Cancel
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Cancel => ReadUObject<UW_ButtonLarge_C>(0x3B8);
		
		/// <summary>
		/// Name: B_OK
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_OK => ReadUObject<UW_ButtonLarge_C>(0x3C0);
		
		/// <summary>
		/// Name: ETXT_Input
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C ETXT_Input => ReadUObject<UW_FCEditableTextBlock_C>(0x3C8);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x3D0);
		
		/// <summary>
		/// Name: TXT_Description
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_Description => ReadUObject<UTextBlock>(0x3D8);
		
	}


	/// <summary>
	/// UW_AvatarHUD_C:UWindowRoot
	/// Size: 0x390
	/// Properties: 3
	/// </summary>
	public class UW_AvatarHUD_C:UWindowRoot
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: HealthBar
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C HealthBar => ReadUObject<UW_CircularProgressbar_C>(0x380);
		
		/// <summary>
		/// Name: TXT_RemainingTime
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UTextBlock TXT_RemainingTime => ReadUObject<UTextBlock>(0x388);
		
	}


	/// <summary>
	/// UW_FullScreenBuffEffect_C:UUserWidget
	/// Size: 0x2A0
	/// Properties: 10
	/// </summary>
	public class UW_FullScreenBuffEffect_C:UUserWidget
	{
		public override int ObjectSize => 672;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: Anim_FadeFast
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_FadeFast => ReadUObject<UWidgetAnimation>(0x240);
		
		/// <summary>
		/// Name: Anim_Puls
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Puls => ReadUObject<UWidgetAnimation>(0x248);
		
		/// <summary>
		/// Name: Anim_FadeSlow
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_FadeSlow => ReadUObject<UWidgetAnimation>(0x250);
		
		/// <summary>
		/// Name: Effect
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UBorder Effect => ReadUObject<UBorder>(0x258);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x260);
		
		/// <summary>
		/// Name: Playing
		/// Type: BoolProperty
		/// Offset: 0x278
		/// Size: 0x01
		/// </summary>
		public bool Playing
		{
			get
			{
				return ReadBool(0x278);
			}
			set
			{
				WriteBool(0x278,value);
			}
		}
		
		/// <summary>
		/// Name: Importance
		/// Type: IntProperty
		/// Offset: 0x27C
		/// Size: 0x04
		/// </summary>
		public int Importance
		{
			get
			{
				return ReadInt32(0x27C);
			}
			set
			{
				WriteInt32(0x27C,value);
			}
		}
		
		/// <summary>
		/// Name: Handle
		/// Type: StructProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		public FTimerHandle Handle => ReadStruct<FTimerHandle>(0x280);
		
		/// <summary>
		/// Name: Buff
		/// Type: ObjectProperty
		/// Offset: 0x298
		/// Size: 0x08
		/// </summary>
		public U01_BP_AC_Buff_Master_C Buff => ReadUObject<U01_BP_AC_Buff_Master_C>(0x298);
		
	}


	/// <summary>
	/// ABaseGameHUD_C:AConanHUD
	/// Size: 0x524
	/// Properties: 7
	/// </summary>
	public class ABaseGameHUD_C:AConanHUD
	{
		public override int ObjectSize => 1316;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x4F0);
		
		/// <summary>
		/// Name: BuffList
		/// Type: ObjectProperty
		/// Offset: 0x4F8
		/// Size: 0x08
		/// </summary>
		public UW_HUD_BuffList_C BuffList => ReadUObject<UW_HUD_BuffList_C>(0x4F8);
		
		/// <summary>
		/// Name: BuffFullScreen
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public UW_FullScreenEffectContainer_C BuffFullScreen => ReadUObject<UW_FullScreenEffectContainer_C>(0x500);
		
		/// <summary>
		/// Name: HudWidget
		/// Type: ObjectProperty
		/// Offset: 0x508
		/// Size: 0x08
		/// </summary>
		public UW_HUD_C HudWidget => ReadUObject<UW_HUD_C>(0x508);
		
		/// <summary>
		/// Name: IngameMenu
		/// Type: ObjectProperty
		/// Offset: 0x510
		/// Size: 0x08
		/// </summary>
		public UW_IngameMenu_C IngameMenu => ReadUObject<UW_IngameMenu_C>(0x510);
		
		/// <summary>
		/// Name: DisplayCharacterPosition
		/// Type: StructProperty
		/// Offset: 0x518
		/// Size: 0x0C
		/// </summary>
		public FVector DisplayCharacterPosition => ReadStruct<FVector>(0x518);
		
	}


	/// <summary>
	/// UW_FullScreenEffectContainer_C:UWindowRoot
	/// Size: 0x3C0
	/// Properties: 8
	/// </summary>
	public class UW_FullScreenEffectContainer_C:UWindowRoot
	{
		public override int ObjectSize => 960;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: EffectContainer
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UOverlay EffectContainer => ReadUObject<UOverlay>(0x380);
		
		/// <summary>
		/// Name: HitIndicators
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UOverlay HitIndicators => ReadUObject<UOverlay>(0x388);
		
		/// <summary>
		/// Name: Owner
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public AConanCharacter Owner => ReadUObject<AConanCharacter>(0x390);
		
		/// <summary>
		/// Name: ActiveEffects
		/// Type: TArray<UW_FullScreenBuffEffect_C>
		/// Offset: 0x398
		/// Size: 0x10
		/// SubElement Size: 0x2A0
		/// </summary>
		public TArray<UW_FullScreenBuffEffect_C> ActiveEffects => new TArray<UW_FullScreenBuffEffect_C>(BaseAddress+0x398);
		
		/// <summary>
		/// Name: Playing
		/// Type: BoolProperty
		/// Offset: 0x3A8
		/// Size: 0x01
		/// </summary>
		public bool Playing
		{
			get
			{
				return ReadBool(0x3A8);
			}
			set
			{
				WriteBool(0x3A8,value);
			}
		}
		
		/// <summary>
		/// Name: ActiveDamageEffect
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_FullScreenBuffEffect_C ActiveDamageEffect => ReadUObject<UW_FullScreenBuffEffect_C>(0x3B0);
		
		/// <summary>
		/// Name: CurrentDamageTexture
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UTexture2D CurrentDamageTexture => ReadUObject<UTexture2D>(0x3B8);
		
	}


	/// <summary>
	/// UW_HudDamageIndicator_C:UWindowRoot
	/// Size: 0x402
	/// Properties: 15
	/// </summary>
	public class UW_HudDamageIndicator_C:UWindowRoot
	{
		public override int ObjectSize => 1026;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: Anim_Splatter
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Splatter => ReadUObject<UWidgetAnimation>(0x380);
		
		/// <summary>
		/// Name: Anim_Fade
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Fade => ReadUObject<UWidgetAnimation>(0x388);
		
		/// <summary>
		/// Name: Effect
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UOverlay Effect => ReadUObject<UOverlay>(0x390);
		
		/// <summary>
		/// Name: Image1
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UImage Image1 => ReadUObject<UImage>(0x398);
		
		/// <summary>
		/// Name: Image2
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UImage Image2 => ReadUObject<UImage>(0x3A0);
		
		/// <summary>
		/// Name: Image3
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UImage Image3 => ReadUObject<UImage>(0x3A8);
		
		/// <summary>
		/// Name: BasePlayerChar
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public ABasePlayerChar_C BasePlayerChar => ReadUObject<ABasePlayerChar_C>(0x3B0);
		
		/// <summary>
		/// Name: Material
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic Material => ReadUObject<UMaterialInstanceDynamic>(0x3B8);
		
		/// <summary>
		/// Name: Tint
		/// Type: StructProperty
		/// Offset: 0x3C0
		/// Size: 0x28
		/// </summary>
		public FSlateColor Tint => ReadStruct<FSlateColor>(0x3C0);
		
		/// <summary>
		/// Name: Texture1
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UTexture2D Texture1 => ReadUObject<UTexture2D>(0x3E8);
		
		/// <summary>
		/// Name: Texture2
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UTexture2D Texture2 => ReadUObject<UTexture2D>(0x3F0);
		
		/// <summary>
		/// Name: Texture3
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UTexture2D Texture3 => ReadUObject<UTexture2D>(0x3F8);
		
		/// <summary>
		/// Name: Mirroring
		/// Type: ByteProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public byte Mirroring
		{
			get
			{
				return ReadByte(0x400);
			}
			set
			{
				WriteByte(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: Flip
		/// Type: BoolProperty
		/// Offset: 0x401
		/// Size: 0x01
		/// </summary>
		public bool Flip
		{
			get
			{
				return ReadBool(0x401);
			}
			set
			{
				WriteBool(0x401,value);
			}
		}
		
	}


	/// <summary>
	/// UW_HUD_C:UUserWidget
	/// Size: 0x280
	/// Properties: 10
	/// </summary>
	public class UW_HUD_C:UUserWidget
	{
		public override int ObjectSize => 640;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: HitConfirm
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation HitConfirm => ReadUObject<UWidgetAnimation>(0x240);
		
		/// <summary>
		/// Name: CrossHair
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UImage CrossHair => ReadUObject<UImage>(0x248);
		
		/// <summary>
		/// Name: HitConfrim
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UImage HitConfrim => ReadUObject<UImage>(0x250);
		
		/// <summary>
		/// Name: LootLog
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UW_HUD_LootLog_C LootLog => ReadUObject<UW_HUD_LootLog_C>(0x258);
		
		/// <summary>
		/// Name: NotificationList
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UW_HUD_NotificationList_C NotificationList => ReadUObject<UW_HUD_NotificationList_C>(0x260);
		
		/// <summary>
		/// Name: LootLogPositionX
		/// Type: FloatProperty
		/// Offset: 0x268
		/// Size: 0x04
		/// </summary>
		public float LootLogPositionX
		{
			get
			{
				return ReadSingle(0x268);
			}
			set
			{
				WriteSingle(0x268,value);
			}
		}
		
		/// <summary>
		/// Name: LootLogPositionY
		/// Type: FloatProperty
		/// Offset: 0x26C
		/// Size: 0x04
		/// </summary>
		public float LootLogPositionY
		{
			get
			{
				return ReadSingle(0x26C);
			}
			set
			{
				WriteSingle(0x26C,value);
			}
		}
		
		/// <summary>
		/// Name: BasePlayerChar
		/// Type: ObjectProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		public ABasePlayerChar_C BasePlayerChar => ReadUObject<ABasePlayerChar_C>(0x270);
		
		/// <summary>
		/// Name: FuncomPlayerController
		/// Type: ObjectProperty
		/// Offset: 0x278
		/// Size: 0x08
		/// </summary>
		public AFunCombat_PlayerController_C FuncomPlayerController => ReadUObject<AFunCombat_PlayerController_C>(0x278);
		
	}


	/// <summary>
	/// UW_HUD_LootLog_C:UUserWidget
	/// Size: 0x250
	/// Properties: 3
	/// </summary>
	public class UW_HUD_LootLog_C:UUserWidget
	{
		public override int ObjectSize => 592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: LogScrollBox
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UScrollBox LogScrollBox => ReadUObject<UScrollBox>(0x240);
		
		/// <summary>
		/// Name: LootLog
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UVerticalBox LootLog => ReadUObject<UVerticalBox>(0x248);
		
	}


	/// <summary>
	/// UW_HUD_LootLogElement_C:UUserWidget
	/// Size: 0x280
	/// Properties: 9
	/// </summary>
	public class UW_HUD_LootLogElement_C:UUserWidget
	{
		public override int ObjectSize => 640;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: Animation_Fade
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Animation_Fade => ReadUObject<UWidgetAnimation>(0x240);
		
		/// <summary>
		/// Name: Brd_Background
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UBorder Brd_Background => ReadUObject<UBorder>(0x248);
		
		/// <summary>
		/// Name: I_Icon
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UImage I_Icon => ReadUObject<UImage>(0x250);
		
		/// <summary>
		/// Name: T_Quantity
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Quantity => ReadUObject<UTextBlock>(0x258);
		
		/// <summary>
		/// Name: T_Total
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Total => ReadUObject<UTextBlock>(0x260);
		
		/// <summary>
		/// Name: T_Type
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Type => ReadUObject<UTextBlock>(0x268);
		
		/// <summary>
		/// Name: AddTexture
		/// Type: ObjectProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		public UTexture2D AddTexture => ReadUObject<UTexture2D>(0x270);
		
		/// <summary>
		/// Name: RemoveTexture
		/// Type: ObjectProperty
		/// Offset: 0x278
		/// Size: 0x08
		/// </summary>
		public UTexture2D RemoveTexture => ReadUObject<UTexture2D>(0x278);
		
	}


	/// <summary>
	/// UW_IngameMenu_C:UWindowRoot
	/// Size: 0x3E0
	/// Properties: 13
	/// </summary>
	public class UW_IngameMenu_C:UWindowRoot
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: B_AdminPanel
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_AdminPanel => ReadUObject<UW_ButtonLarge_C>(0x380);
		
		/// <summary>
		/// Name: B_Continue
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Continue => ReadUObject<UW_ButtonLarge_C>(0x388);
		
		/// <summary>
		/// Name: B_Disconnect
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Disconnect => ReadUObject<UW_ButtonLarge_C>(0x390);
		
		/// <summary>
		/// Name: B_Exit
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Exit => ReadUObject<UW_ButtonLarge_C>(0x398);
		
		/// <summary>
		/// Name: B_Guild
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Guild => ReadUObject<UW_ButtonLarge_C>(0x3A0);
		
		/// <summary>
		/// Name: B_InviteFriend
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_InviteFriend => ReadUObject<UW_ButtonLarge_C>(0x3A8);
		
		/// <summary>
		/// Name: B_Options
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Options => ReadUObject<UW_ButtonLarge_C>(0x3B0);
		
		/// <summary>
		/// Name: B_RecreateCharacter
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_RecreateCharacter => ReadUObject<UW_ButtonLarge_C>(0x3B8);
		
		/// <summary>
		/// Name: B_Suicide
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Suicide => ReadUObject<UW_ButtonLarge_C>(0x3C0);
		
		/// <summary>
		/// Name: Logo
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UImage Logo => ReadUObject<UImage>(0x3C8);
		
		/// <summary>
		/// Name: ServerName
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UTextBlock ServerName => ReadUObject<UTextBlock>(0x3D0);
		
		/// <summary>
		/// Name: VersionNumber
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UTextBlock VersionNumber => ReadUObject<UTextBlock>(0x3D8);
		
	}


	/// <summary>
	/// UW_HUD_Crafting_C:UHUDCraftingBase
	/// Size: 0x3B0
	/// Properties: 4
	/// </summary>
	public class UW_HUD_Crafting_C:UHUDCraftingBase
	{
		public override int ObjectSize => 944;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x390);
		
		/// <summary>
		/// Name: CraftingIcon
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UImage CraftingIcon => ReadUObject<UImage>(0x398);
		
		/// <summary>
		/// Name: CurrentItemIcon
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UInventoryIconView_C CurrentItemIcon => ReadUObject<UInventoryIconView_C>(0x3A0);
		
		/// <summary>
		/// Name: IconContainer
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UOverlay IconContainer => ReadUObject<UOverlay>(0x3A8);
		
	}


	/// <summary>
	/// UW_ShortcutIcon_C:UShortcutIconBase
	/// Size: 0x4B0
	/// Properties: 8
	/// </summary>
	public class UW_ShortcutIcon_C:UShortcutIconBase
	{
		public override int ObjectSize => 1200;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x470);
		
		/// <summary>
		/// Name: ActionMappingDisplay
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UTextBlock ActionMappingDisplay => ReadUObject<UTextBlock>(0x478);
		
		/// <summary>
		/// Name: DurabilityContainer
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UBorder DurabilityContainer => ReadUObject<UBorder>(0x480);
		
		/// <summary>
		/// Name: HotkeyIcon
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public UW_HotkeyIcon_C HotkeyIcon => ReadUObject<UW_HotkeyIcon_C>(0x488);
		
		/// <summary>
		/// Name: IconSlotView
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public UInventoryGridSlotView_C IconSlotView => ReadUObject<UInventoryGridSlotView_C>(0x490);
		
		/// <summary>
		/// Name: IconView
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UInventoryIconView_C IconView => ReadUObject<UInventoryIconView_C>(0x498);
		
		/// <summary>
		/// Name: IsActiveView
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public UImage IsActiveView => ReadUObject<UImage>(0x4A0);
		
		/// <summary>
		/// Name: PB_Durabilty
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UProgressBar PB_Durabilty => ReadUObject<UProgressBar>(0x4A8);
		
	}


	/// <summary>
	/// UW_ShortcutBar_C:UShortcutBarBase
	/// Size: 0x458
	/// Properties: 10
	/// </summary>
	public class UW_ShortcutBar_C:UShortcutBarBase
	{
		public override int ObjectSize => 1112;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x408);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x410);
		
		/// <summary>
		/// Name: Slot0
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot0 => ReadUObject<UW_ShortcutIcon_C>(0x418);
		
		/// <summary>
		/// Name: Slot1
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot1 => ReadUObject<UW_ShortcutIcon_C>(0x420);
		
		/// <summary>
		/// Name: Slot2
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot2 => ReadUObject<UW_ShortcutIcon_C>(0x428);
		
		/// <summary>
		/// Name: Slot3
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot3 => ReadUObject<UW_ShortcutIcon_C>(0x430);
		
		/// <summary>
		/// Name: Slot4
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot4 => ReadUObject<UW_ShortcutIcon_C>(0x438);
		
		/// <summary>
		/// Name: Slot5
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot5 => ReadUObject<UW_ShortcutIcon_C>(0x440);
		
		/// <summary>
		/// Name: Slot6
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot6 => ReadUObject<UW_ShortcutIcon_C>(0x448);
		
		/// <summary>
		/// Name: Slot7
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UW_ShortcutIcon_C Slot7 => ReadUObject<UW_ShortcutIcon_C>(0x450);
		
	}


	/// <summary>
	/// UW_HUDCharacterStatIndicators_C:UHUDCharacterStatIndicators
	/// Size: 0x418
	/// Properties: 14
	/// </summary>
	public class UW_HUDCharacterStatIndicators_C:UHUDCharacterStatIndicators
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3A8);
		
		/// <summary>
		/// Name: Anim_StopLevelUp
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_StopLevelUp => ReadUObject<UWidgetAnimation>(0x3B0);
		
		/// <summary>
		/// Name: Anim_LevelUp
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_LevelUp => ReadUObject<UWidgetAnimation>(0x3B8);
		
		/// <summary>
		/// Name: CorruptionBar
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C CorruptionBar => ReadUObject<UW_CircularProgressbar_C>(0x3C0);
		
		/// <summary>
		/// Name: EncumbranceBar
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C EncumbranceBar => ReadUObject<UW_CircularProgressbar_C>(0x3C8);
		
		/// <summary>
		/// Name: FoodBar
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C FoodBar => ReadUObject<UW_CircularProgressbar_C>(0x3D0);
		
		/// <summary>
		/// Name: HealthBar
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C HealthBar => ReadUObject<UW_CircularProgressbar_C>(0x3D8);
		
		/// <summary>
		/// Name: LevelUpCircle
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UImage LevelUpCircle => ReadUObject<UImage>(0x3E0);
		
		/// <summary>
		/// Name: LevelUpXP
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UImage LevelUpXP => ReadUObject<UImage>(0x3E8);
		
		/// <summary>
		/// Name: StaminaBar
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C StaminaBar => ReadUObject<UW_CircularProgressbar_C>(0x3F0);
		
		/// <summary>
		/// Name: StaminaCorruptionBar
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C StaminaCorruptionBar => ReadUObject<UW_CircularProgressbar_C>(0x3F8);
		
		/// <summary>
		/// Name: WaterBar
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C WaterBar => ReadUObject<UW_CircularProgressbar_C>(0x400);
		
		/// <summary>
		/// Name: XPBar
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UW_CircularProgressbar_C XPBar => ReadUObject<UW_CircularProgressbar_C>(0x408);
		
		/// <summary>
		/// Name: InsideBuff
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UW_HUD_BuffEntry_C InsideBuff => ReadUObject<UW_HUD_BuffEntry_C>(0x410);
		
	}


}

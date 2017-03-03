using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Buffs;


namespace ConanExilesGame.Game.UI.HUD.Notifications
{
	/// <summary>
	/// UW_HUD_BuffEntry_C:UUserWidget
	/// Size: 0x2E0
	/// Properties: 22
	/// </summary>
	public class UW_HUD_BuffEntry_C:UUserWidget
	{
		public override int ObjectSize => 736;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: Anim_LockBuff
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_LockBuff => ReadUObject<UWidgetAnimation>(0x240);
		
		/// <summary>
		/// Name: SetInventoryLook2
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation SetInventoryLook2 => ReadUObject<UWidgetAnimation>(0x248);
		
		/// <summary>
		/// Name: Anim_StackChange
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_StackChange => ReadUObject<UWidgetAnimation>(0x250);
		
		/// <summary>
		/// Name: Set_InventoryLook
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Set_InventoryLook => ReadUObject<UWidgetAnimation>(0x258);
		
		/// <summary>
		/// Name: Anim_Timer
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Timer => ReadUObject<UWidgetAnimation>(0x260);
		
		/// <summary>
		/// Name: Anim_Fade
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Fade => ReadUObject<UWidgetAnimation>(0x268);
		
		/// <summary>
		/// Name: Anim_SlideIn
		/// Type: ObjectProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_SlideIn => ReadUObject<UWidgetAnimation>(0x270);
		
		/// <summary>
		/// Name: Clock
		/// Type: ObjectProperty
		/// Offset: 0x278
		/// Size: 0x08
		/// </summary>
		public UProgressBar Clock => ReadUObject<UProgressBar>(0x278);
		
		/// <summary>
		/// Name: Container
		/// Type: ObjectProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		public UBorder Container => ReadUObject<UBorder>(0x280);
		
		/// <summary>
		/// Name: Durutation
		/// Type: ObjectProperty
		/// Offset: 0x288
		/// Size: 0x08
		/// </summary>
		public UProgressBar Durutation => ReadUObject<UProgressBar>(0x288);
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0x290
		/// Size: 0x08
		/// </summary>
		public UProgressBar Icon => ReadUObject<UProgressBar>(0x290);
		
		/// <summary>
		/// Name: Name
		/// Type: ObjectProperty
		/// Offset: 0x298
		/// Size: 0x08
		/// </summary>
		public UTextBlock Name => ReadUObject<UTextBlock>(0x298);
		
		/// <summary>
		/// Name: Stack
		/// Type: ObjectProperty
		/// Offset: 0x2A0
		/// Size: 0x08
		/// </summary>
		public UTextBlock Stack => ReadUObject<UTextBlock>(0x2A0);
		
		/// <summary>
		/// Name: ID
		/// Type: IntProperty
		/// Offset: 0x2A8
		/// Size: 0x04
		/// </summary>
		public int ID
		{
			get
			{
				return ReadInt32(0x2A8);
			}
			set
			{
				WriteInt32(0x2A8,value);
			}
		}
		
		/// <summary>
		/// Name: RemaingPercent
		/// Type: FloatProperty
		/// Offset: 0x2AC
		/// Size: 0x04
		/// </summary>
		public float RemaingPercent
		{
			get
			{
				return ReadSingle(0x2AC);
			}
			set
			{
				WriteSingle(0x2AC,value);
			}
		}
		
		/// <summary>
		/// Name: Diff
		/// Type: FloatProperty
		/// Offset: 0x2B0
		/// Size: 0x04
		/// </summary>
		public float Diff
		{
			get
			{
				return ReadSingle(0x2B0);
			}
			set
			{
				WriteSingle(0x2B0,value);
			}
		}
		
		/// <summary>
		/// Name: UpdateInterval
		/// Type: FloatProperty
		/// Offset: 0x2B4
		/// Size: 0x04
		/// </summary>
		public float UpdateInterval
		{
			get
			{
				return ReadSingle(0x2B4);
			}
			set
			{
				WriteSingle(0x2B4,value);
			}
		}
		
		/// <summary>
		/// Name: Locked
		/// Type: BoolProperty
		/// Offset: 0x2B8
		/// Size: 0x01
		/// </summary>
		public bool Locked
		{
			get
			{
				return ReadBool(0x2B8);
			}
			set
			{
				WriteBool(0x2B8,value);
			}
		}
		
		/// <summary>
		/// Name: Handle
		/// Type: StructProperty
		/// Offset: 0x2C0
		/// Size: 0x08
		/// </summary>
		public FTimerHandle Handle => ReadStruct<FTimerHandle>(0x2C0);
		
		/// <summary>
		/// Name: Buff
		/// Type: ObjectProperty
		/// Offset: 0x2C8
		/// Size: 0x08
		/// </summary>
		public U01_BP_AC_Buff_Master_C Buff => ReadUObject<U01_BP_AC_Buff_Master_C>(0x2C8);
		
		/// <summary>
		/// Name: Tint
		/// Type: StructProperty
		/// Offset: 0x2D0
		/// Size: 0x10
		/// </summary>
		public FLinearColor Tint => ReadStruct<FLinearColor>(0x2D0);
		
	}


	/// <summary>
	/// UW_HUD_BuffList_C:UWindowRoot
	/// Size: 0x398
	/// Properties: 2
	/// </summary>
	public class UW_HUD_BuffList_C:UWindowRoot
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
		/// Name: Buffs
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Buffs => ReadUObject<UVerticalBox>(0x380);
		
	}


	/// <summary>
	/// UW_HUD_NotificationList_C:UUserWidget
	/// Size: 0x248
	/// Properties: 2
	/// </summary>
	public class UW_HUD_NotificationList_C:UUserWidget
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
		/// Name: Notifications
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UVerticalBox Notifications => ReadUObject<UVerticalBox>(0x240);
		
	}


	/// <summary>
	/// UW_HUD_NotificationEntry_C:UUserWidget
	/// Size: 0x260
	/// Properties: 5
	/// </summary>
	public class UW_HUD_NotificationEntry_C:UUserWidget
	{
		public override int ObjectSize => 608;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
		/// <summary>
		/// Name: Anim_Fade
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_Fade => ReadUObject<UWidgetAnimation>(0x240);
		
		/// <summary>
		/// Name: Anim_SlideIn
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Anim_SlideIn => ReadUObject<UWidgetAnimation>(0x248);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UBorder Image => ReadUObject<UBorder>(0x250);
		
		/// <summary>
		/// Name: Message
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UTextBlock Message => ReadUObject<UTextBlock>(0x258);
		
	}


}

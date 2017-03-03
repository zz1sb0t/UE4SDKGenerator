using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;


namespace ConanExilesGame.Game.UI.Framework
{
	/// <summary>
	/// UW_MouseBlockWindow_C:UWindowRoot
	/// Size: 0x388
	/// Properties: 2
	/// </summary>
	public class UW_MouseBlockWindow_C:UWindowRoot
	{
		public override int ObjectSize => 904;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: MouseBlocker
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public USpacer MouseBlocker => ReadUObject<USpacer>(0x380);
		
	}


	/// <summary>
	/// UW_FCButton_C:UFCButton
	/// Size: 0xB90
	/// Properties: 0
	/// </summary>
	public class UW_FCButton_C:UFCButton
	{
		public override int ObjectSize => 2960;
	}


	/// <summary>
	/// UW_KeyNavIndicator_C:UKeyNavIndicator
	/// Size: 0x318
	/// Properties: 1
	/// </summary>
	public class UW_KeyNavIndicator_C:UKeyNavIndicator
	{
		public override int ObjectSize => 792;
		/// <summary>
		/// Name: Content
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UNamedSlot Content => ReadUObject<UNamedSlot>(0x310);
		
	}


	/// <summary>
	/// UW_ButtonLarge_C:UW_FCButton_C
	/// Size: 0xBB0
	/// Properties: 4
	/// </summary>
	public class UW_ButtonLarge_C:UW_FCButton_C
	{
		public override int ObjectSize => 2992;
		/// <summary>
		/// Name: ButtonOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public UNamedSlot ButtonOverlay => ReadUObject<UNamedSlot>(0xB90);
		
		/// <summary>
		/// Name: CheckboxOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UNamedSlot CheckboxOverlay => ReadUObject<UNamedSlot>(0xB98);
		
		/// <summary>
		/// Name: HotkeyIcon
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UW_HotkeyIcon_C HotkeyIcon => ReadUObject<UW_HotkeyIcon_C>(0xBA0);
		
		/// <summary>
		/// Name: MenuAnchor
		/// Type: ObjectProperty
		/// Offset: 0xBA8
		/// Size: 0x08
		/// </summary>
		public UMenuAnchor MenuAnchor => ReadUObject<UMenuAnchor>(0xBA8);
		
	}


	/// <summary>
	/// UW_HotkeyIcon_C:UHotkeyIcon
	/// Size: 0x400
	/// Properties: 1
	/// </summary>
	public class UW_HotkeyIcon_C:UHotkeyIcon
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: IconView
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UImage IconView => ReadUObject<UImage>(0x3F8);
		
	}


	/// <summary>
	/// UFCButtonSubMenu_C:UUserWidget
	/// Size: 0x238
	/// Properties: 0
	/// </summary>
	public class UFCButtonSubMenu_C:UUserWidget
	{
		public override int ObjectSize => 568;
	}


	/// <summary>
	/// UW_FCEditableTextBlock_C:UFCEditableTextBox
	/// Size: 0xBF8
	/// Properties: 0
	/// </summary>
	public class UW_FCEditableTextBlock_C:UFCEditableTextBox
	{
		public override int ObjectSize => 3064;
	}


	/// <summary>
	/// UW_CircularProgressbar_C:UCircularProgressbar
	/// Size: 0x400
	/// Properties: 1
	/// </summary>
	public class UW_CircularProgressbar_C:UCircularProgressbar
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: IconView
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UImage IconView => ReadUObject<UImage>(0x3F8);
		
	}


	/// <summary>
	/// UW_ButtonNormal_C:UW_FCButton_C
	/// Size: 0xBA8
	/// Properties: 3
	/// </summary>
	public class UW_ButtonNormal_C:UW_FCButton_C
	{
		public override int ObjectSize => 2984;
		/// <summary>
		/// Name: ButtonOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public UNamedSlot ButtonOverlay => ReadUObject<UNamedSlot>(0xB90);
		
		/// <summary>
		/// Name: CheckboxOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UNamedSlot CheckboxOverlay => ReadUObject<UNamedSlot>(0xB98);
		
		/// <summary>
		/// Name: HotkeyIcon
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UW_HotkeyIcon_C HotkeyIcon => ReadUObject<UW_HotkeyIcon_C>(0xBA0);
		
	}


	/// <summary>
	/// UW_EditableLabeledSlider_C:UEditableLabeledSlider
	/// Size: 0xDE8
	/// Properties: 3
	/// </summary>
	public class UW_EditableLabeledSlider_C:UEditableLabeledSlider
	{
		public override int ObjectSize => 3560;
		/// <summary>
		/// Name: Overlay
		/// Type: ObjectProperty
		/// Offset: 0xDD0
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay => ReadUObject<UOverlay>(0xDD0);
		
		/// <summary>
		/// Name: S_Value
		/// Type: ObjectProperty
		/// Offset: 0xDD8
		/// Size: 0x08
		/// </summary>
		public UW_FCSlider_C S_Value => ReadUObject<UW_FCSlider_C>(0xDD8);
		
		/// <summary>
		/// Name: TXT_Value
		/// Type: ObjectProperty
		/// Offset: 0xDE0
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C TXT_Value => ReadUObject<UW_FCEditableTextBlock_C>(0xDE0);
		
	}


	/// <summary>
	/// UW_FCSlider_C:UFCSlider
	/// Size: 0x5A8
	/// Properties: 0
	/// </summary>
	public class UW_FCSlider_C:UFCSlider
	{
		public override int ObjectSize => 1448;
	}


	/// <summary>
	/// UW_ButtonCustom_C:UW_FCButton_C
	/// Size: 0xBA8
	/// Properties: 3
	/// </summary>
	public class UW_ButtonCustom_C:UW_FCButton_C
	{
		public override int ObjectSize => 2984;
		/// <summary>
		/// Name: ButtonOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB90
		/// Size: 0x08
		/// </summary>
		public UNamedSlot ButtonOverlay => ReadUObject<UNamedSlot>(0xB90);
		
		/// <summary>
		/// Name: CheckboxOverlay
		/// Type: ObjectProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public UNamedSlot CheckboxOverlay => ReadUObject<UNamedSlot>(0xB98);
		
		/// <summary>
		/// Name: HotkeyIcon
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UW_HotkeyIcon_C HotkeyIcon => ReadUObject<UW_HotkeyIcon_C>(0xBA0);
		
	}


	/// <summary>
	/// UW_FCComboBoxString_C:UFCComboBoxString
	/// Size: 0x378
	/// Properties: 1
	/// </summary>
	public class UW_FCComboBoxString_C:UFCComboBoxString
	{
		public override int ObjectSize => 888;
		/// <summary>
		/// Name: ComboBox
		/// Type: ObjectProperty
		/// Offset: 0x370
		/// Size: 0x08
		/// </summary>
		public UComboBoxString ComboBox => ReadUObject<UComboBoxString>(0x370);
		
	}


	/// <summary>
	/// UW_DropDownText_C:UUserWidget
	/// Size: 0x248
	/// Properties: 2
	/// </summary>
	public class UW_DropDownText_C:UUserWidget
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
		/// Name: label
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UTextBlock label => ReadUObject<UTextBlock>(0x240);
		
	}


	/// <summary>
	/// UW_TimeInputBox_C:UTimeInputBox
	/// Size: 0x360
	/// Properties: 4
	/// </summary>
	public class UW_TimeInputBox_C:UTimeInputBox
	{
		public override int ObjectSize => 864;
		/// <summary>
		/// Name: Overlay
		/// Type: ObjectProperty
		/// Offset: 0x340
		/// Size: 0x08
		/// </summary>
		public UOverlay Overlay => ReadUObject<UOverlay>(0x340);
		
		/// <summary>
		/// Name: TXT_ColonSeparator
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C TXT_ColonSeparator => ReadUObject<UW_FCEditableTextBlock_C>(0x348);
		
		/// <summary>
		/// Name: TXT_Hours
		/// Type: ObjectProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C TXT_Hours => ReadUObject<UW_FCEditableTextBlock_C>(0x350);
		
		/// <summary>
		/// Name: TXT_Minutes
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UW_FCEditableTextBlock_C TXT_Minutes => ReadUObject<UW_FCEditableTextBlock_C>(0x358);
		
	}


	/// <summary>
	/// UW_TabButton_C:UTabButtonBase
	/// Size: 0xBC0
	/// Properties: 5
	/// </summary>
	public class UW_TabButton_C:UTabButtonBase
	{
		public override int ObjectSize => 3008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xB98
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xB98);
		
		/// <summary>
		/// Name: CheckboxOverlay
		/// Type: ObjectProperty
		/// Offset: 0xBA0
		/// Size: 0x08
		/// </summary>
		public UNamedSlot CheckboxOverlay => ReadUObject<UNamedSlot>(0xBA0);
		
		/// <summary>
		/// Name: LabelView
		/// Type: ObjectProperty
		/// Offset: 0xBA8
		/// Size: 0x08
		/// </summary>
		public UTextBlock LabelView => ReadUObject<UTextBlock>(0xBA8);
		
		/// <summary>
		/// Name: Size
		/// Type: ObjectProperty
		/// Offset: 0xBB0
		/// Size: 0x08
		/// </summary>
		public USizeBox Size => ReadUObject<USizeBox>(0xBB0);
		
		/// <summary>
		/// Name: SizeOverride
		/// Type: StructProperty
		/// Offset: 0xBB8
		/// Size: 0x08
		/// </summary>
		public FVector2D SizeOverride => ReadStruct<FVector2D>(0xBB8);
		
	}


	/// <summary>
	/// UW_RadialMenu_C:URadialMenu
	/// Size: 0x480
	/// Properties: 1
	/// </summary>
	public class UW_RadialMenu_C:URadialMenu
	{
		public override int ObjectSize => 1152;
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x478);
		
	}


	/// <summary>
	/// UW_RadialMenuSegment_C:URadialMenuSegment
	/// Size: 0x368
	/// Properties: 4
	/// </summary>
	public class UW_RadialMenuSegment_C:URadialMenuSegment
	{
		public override int ObjectSize => 872;
		/// <summary>
		/// Name: EndCapRenderer
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public UImage EndCapRenderer => ReadUObject<UImage>(0x348);
		
		/// <summary>
		/// Name: IconView
		/// Type: ObjectProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		public UImage IconView => ReadUObject<UImage>(0x350);
		
		/// <summary>
		/// Name: PieRenderer
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UPieRenderWidget PieRenderer => ReadUObject<UPieRenderWidget>(0x358);
		
		/// <summary>
		/// Name: StartCapRenderer
		/// Type: ObjectProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public UImage StartCapRenderer => ReadUObject<UImage>(0x360);
		
	}


	/// <summary>
	/// UW_TooltipWidget_C:UTooltipWidget
	/// Size: 0x248
	/// Properties: 1
	/// </summary>
	public class UW_TooltipWidget_C:UTooltipWidget
	{
		public override int ObjectSize => 584;
		/// <summary>
		/// Name: textView
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UTextBlock textView => ReadUObject<UTextBlock>(0x240);
		
	}


	/// <summary>
	/// UInventoryIconView_C:UInventoryIconViewBase
	/// Size: 0x3A8
	/// Properties: 7
	/// </summary>
	public class UInventoryIconView_C:UInventoryIconViewBase
	{
		public override int ObjectSize => 936;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x370
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x370);
		
		/// <summary>
		/// Name: ActiveAmmo
		/// Type: ObjectProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public UImage ActiveAmmo => ReadUObject<UImage>(0x378);
		
		/// <summary>
		/// Name: BitmapView
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UImage BitmapView => ReadUObject<UImage>(0x380);
		
		/// <summary>
		/// Name: DragView
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public USizeBox DragView => ReadUObject<USizeBox>(0x388);
		
		/// <summary>
		/// Name: ProgressBar
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UProgressBar ProgressBar => ReadUObject<UProgressBar>(0x390);
		
		/// <summary>
		/// Name: ProgressBarContainer
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UBorder ProgressBarContainer => ReadUObject<UBorder>(0x398);
		
		/// <summary>
		/// Name: StackSizeTextView
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UTextBlock StackSizeTextView => ReadUObject<UTextBlock>(0x3A0);
		
	}


	/// <summary>
	/// UInventoryGridSlotView_C:UInventoryGridSlotViewBase
	/// Size: 0x4B8
	/// Properties: 5
	/// </summary>
	public class UInventoryGridSlotView_C:UInventoryGridSlotViewBase
	{
		public override int ObjectSize => 1208;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x490);
		
		/// <summary>
		/// Name: AnimSelect
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation AnimSelect => ReadUObject<UWidgetAnimation>(0x498);
		
		/// <summary>
		/// Name: AnimMouseOver
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation AnimMouseOver => ReadUObject<UWidgetAnimation>(0x4A0);
		
		/// <summary>
		/// Name: IconSlot
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UNamedSlot IconSlot => ReadUObject<UNamedSlot>(0x4A8);
		
		/// <summary>
		/// Name: SlotImage
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UImage SlotImage => ReadUObject<UImage>(0x4B0);
		
	}


}

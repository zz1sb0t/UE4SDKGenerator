using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;


namespace ConanExilesGame.Game.UI.Inventory
{
	/// <summary>
	/// UW_ItemStatView_C:UItemStatView
	/// Size: 0x350
	/// Properties: 4
	/// </summary>
	public class UW_ItemStatView_C:UItemStatView
	{
		public override int ObjectSize => 848;
		/// <summary>
		/// Name: Description
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UTextBlock Description => ReadUObject<UTextBlock>(0x330);
		
		/// <summary>
		/// Name: Empty
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UTextBlock Empty => ReadUObject<UTextBlock>(0x338);
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0x340
		/// Size: 0x08
		/// </summary>
		public UImage Icon => ReadUObject<UImage>(0x340);
		
		/// <summary>
		/// Name: Name
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public UTextBlock Name => ReadUObject<UTextBlock>(0x348);
		
	}


	/// <summary>
	/// UW_LoreDisplay_C:UItemInfoPopup
	/// Size: 0x3F8
	/// Properties: 10
	/// </summary>
	public class UW_LoreDisplay_C:UItemInfoPopup
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3A8);
		
		/// <summary>
		/// Name: B_Close
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Close => ReadUObject<UW_ButtonNormal_C>(0x3B0);
		
		/// <summary>
		/// Name: B_Play
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonCustom_C B_Play => ReadUObject<UW_ButtonCustom_C>(0x3B8);
		
		/// <summary>
		/// Name: CenterPanel2
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public USizeBox CenterPanel2 => ReadUObject<USizeBox>(0x3C0);
		
		/// <summary>
		/// Name: Description1
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UFCRichTextBlock Description1 => ReadUObject<UFCRichTextBlock>(0x3C8);
		
		/// <summary>
		/// Name: Description2
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UFCRichTextBlock Description2 => ReadUObject<UFCRichTextBlock>(0x3D0);
		
		/// <summary>
		/// Name: Description3
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UFCRichTextBlock Description3 => ReadUObject<UFCRichTextBlock>(0x3D8);
		
		/// <summary>
		/// Name: Name
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UTextBlock Name => ReadUObject<UTextBlock>(0x3E0);
		
		/// <summary>
		/// Name: ObjectImage
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UImage ObjectImage => ReadUObject<UImage>(0x3E8);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio => ReadUObject<USoundCue>(0x3F0);
		
	}


	/// <summary>
	/// UW_ItemIconTooltipView_C:UInventoryIconTooltipView
	/// Size: 0x258
	/// Properties: 1
	/// </summary>
	public class UW_ItemIconTooltipView_C:UInventoryIconTooltipView
	{
		public override int ObjectSize => 600;
		/// <summary>
		/// Name: NameView
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public UTextBlock NameView => ReadUObject<UTextBlock>(0x250);
		
	}


}

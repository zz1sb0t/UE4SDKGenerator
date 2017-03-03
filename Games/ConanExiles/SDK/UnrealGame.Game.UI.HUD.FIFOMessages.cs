using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.HUD.FIFOMessages
{
	/// <summary>
	/// UW_FIFOWindow_C:UFIFOWindow
	/// Size: 0x388
	/// Properties: 2
	/// </summary>
	public class UW_FIFOWindow_C:UFIFOWindow
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
		/// Name: MessageListView
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UVerticalBox MessageListView => ReadUObject<UVerticalBox>(0x380);
		
	}


	/// <summary>
	/// UW_FIFOMessageView_C:UFIFOMessageView
	/// Size: 0x328
	/// Properties: 4
	/// </summary>
	public class UW_FIFOMessageView_C:UFIFOMessageView
	{
		public override int ObjectSize => 808;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x308);
		
		/// <summary>
		/// Name: FadeOut
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation FadeOut => ReadUObject<UWidgetAnimation>(0x310);
		
		/// <summary>
		/// Name: FadeIn
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation FadeIn => ReadUObject<UWidgetAnimation>(0x318);
		
		/// <summary>
		/// Name: textView
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UTextBlock textView => ReadUObject<UTextBlock>(0x320);
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.Chat
{
	/// <summary>
	/// UW_ChatLine_C:UUserWidget
	/// Size: 0x238
	/// Properties: 0
	/// </summary>
	public class UW_ChatLine_C:UUserWidget
	{
		public override int ObjectSize => 568;
	}


	/// <summary>
	/// UW_ChatWindow_C:UChatWindow
	/// Size: 0x3C0
	/// Properties: 2
	/// </summary>
	public class UW_ChatWindow_C:UChatWindow
	{
		public override int ObjectSize => 960;
		/// <summary>
		/// Name: ScrollBox
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UScrollBox ScrollBox => ReadUObject<UScrollBox>(0x3B0);
		
		/// <summary>
		/// Name: TextInputChannel
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UTextBlock TextInputChannel => ReadUObject<UTextBlock>(0x3B8);
		
	}


}

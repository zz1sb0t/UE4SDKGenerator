using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;


namespace ConanExilesGame.Game.UI.MessageBox
{
	/// <summary>
	/// UW_MessageBox_C:UMessageBoxWidget
	/// Size: 0x408
	/// Properties: 6
	/// </summary>
	public class UW_MessageBox_C:UMessageBoxWidget
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: B_Cancel
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Cancel => ReadUObject<UW_ButtonLarge_C>(0x3D8);
		
		/// <summary>
		/// Name: B_No
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_No => ReadUObject<UW_ButtonLarge_C>(0x3E0);
		
		/// <summary>
		/// Name: B_OK
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_OK => ReadUObject<UW_ButtonLarge_C>(0x3E8);
		
		/// <summary>
		/// Name: B_Yes
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonLarge_C B_Yes => ReadUObject<UW_ButtonLarge_C>(0x3F0);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x3F8);
		
		/// <summary>
		/// Name: T_Message
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UTextBlock T_Message => ReadUObject<UTextBlock>(0x400);
		
	}


}

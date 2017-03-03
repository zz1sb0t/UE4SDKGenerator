using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.Debug
{
	/// <summary>
	/// UDebug_GrabLocationWidget_C:UUserWidget
	/// Size: 0x240
	/// Properties: 1
	/// </summary>
	public class UDebug_GrabLocationWidget_C:UUserWidget
	{
		public override int ObjectSize => 576;
		/// <summary>
		/// Name: EditableTextBox
		/// Type: ObjectProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public UEditableTextBox EditableTextBox => ReadUObject<UEditableTextBox>(0x238);
		
	}


}

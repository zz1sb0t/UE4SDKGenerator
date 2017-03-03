using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;


namespace UnrealGame.Game.UI.Debug
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

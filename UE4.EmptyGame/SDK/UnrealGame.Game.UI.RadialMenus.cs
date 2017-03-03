using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;
using UnrealGame.Game.UI.Framework;


namespace UnrealGame.Game.UI.RadialMenus
{
	/// <summary>
	/// UW_MainRadialMenu_C:UMainRadialMenu
	/// Size: 0x388
	/// Properties: 1
	/// </summary>
	public class UW_MainRadialMenu_C:UMainRadialMenu
	{
		public override int ObjectSize => 904;
		/// <summary>
		/// Name: menu
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UW_RadialMenu_C menu => ReadUObject<UW_RadialMenu_C>(0x380);
		
	}


}

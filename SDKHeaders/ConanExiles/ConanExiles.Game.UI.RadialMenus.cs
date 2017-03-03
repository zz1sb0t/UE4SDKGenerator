using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Script;
using ConanExiles.Game.UI.Framework;


namespace ConanExiles.Game.UI.RadialMenus
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

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Inventory
{
	/// <summary>
	/// UBPGameItem_C:UGameItem
	/// Size: 0x360
	/// Properties: 0
	/// </summary>
	public class UBPGameItem_C:UGameItem
	{
		public override int ObjectSize => 864;
	}


	/// <summary>
	/// UBPGameItemInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBPGameItemInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;


namespace UnrealGame.Game.Systems.Inventory
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

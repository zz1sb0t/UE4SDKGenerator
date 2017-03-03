using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Master_AnimBP;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.NPCs.Bat_Demon.Animations
{
	/// <summary>
	/// UAB_Bat_Demon_C:UAB_Master_Quadropeds_C
	/// Size: 0x14E0
	/// Properties: 1
	/// </summary>
	public class UAB_Bat_Demon_C:UAB_Master_Quadropeds_C
	{
		public override int ObjectSize => 5344;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x14D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x14D8);
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Rabbit.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Rabbit.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Rabbit_C:ABaseBPWildlife_C
	/// Size: 0x1118
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Rabbit_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4376;
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1110);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Rabbit_C:ABP_NPC_Wildlife_Rabbit_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Rabbit_C:ABP_NPC_Wildlife_Rabbit_C
	{
		public override int ObjectSize => 4376;
	}


}

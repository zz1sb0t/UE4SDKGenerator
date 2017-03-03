using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Characters;
using UnrealGame.Script;
using UnrealGame.Game.Characters.NPCs.Rabbit.Blueprints;


namespace UnrealGame.Game.Characters.NPCs.Rabbit.Blueprints
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

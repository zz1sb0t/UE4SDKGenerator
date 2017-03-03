using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Characters;
using UnrealGame.Script;
using UnrealGame.Game.Characters.NPCs.Ostrich.Blueprints;


namespace UnrealGame.Game.Characters.NPCs.Ostrich.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Ostrich_C:ABaseBPWildlife_C
	/// Size: 0x1118
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Ostrich_C:ABaseBPWildlife_C
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
	/// ABP_NPC_Wildlife_Ostrich_Blue_C:ABP_NPC_Wildlife_Ostrich_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Ostrich_Blue_C:ABP_NPC_Wildlife_Ostrich_C
	{
		public override int ObjectSize => 4376;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Ostrich_Red_C:ABP_NPC_Wildlife_Ostrich_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Ostrich_Red_C:ABP_NPC_Wildlife_Ostrich_C
	{
		public override int ObjectSize => 4376;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Ostrich_C:ABP_NPC_Wildlife_Ostrich_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Ostrich_C:ABP_NPC_Wildlife_Ostrich_C
	{
		public override int ObjectSize => 4376;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Ostrich_Blue_C:ABP_NPC_Wildlife_Ostrich_Blue_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Ostrich_Blue_C:ABP_NPC_Wildlife_Ostrich_Blue_C
	{
		public override int ObjectSize => 4376;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Ostrich_Red_C:ABP_NPC_Wildlife_Ostrich_Red_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Ostrich_Red_C:ABP_NPC_Wildlife_Ostrich_Red_C
	{
		public override int ObjectSize => 4376;
	}


}

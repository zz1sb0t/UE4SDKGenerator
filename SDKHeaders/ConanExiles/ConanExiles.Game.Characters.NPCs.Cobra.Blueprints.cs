using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Game.Characters;
using ConanExiles.Script;
using ConanExiles.Game.Characters.NPCs.Cobra.Blueprints;


namespace ConanExiles.Game.Characters.NPCs.Cobra.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Cobra_C:ABaseBPWildlife_C
	/// Size: 0x1118
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Cobra_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4376;
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1110);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Cobra_C:ABP_NPC_Wildlife_Cobra_C
	/// Size: 0x1118
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Cobra_C:ABP_NPC_Wildlife_Cobra_C
	{
		public override int ObjectSize => 4376;
	}


}

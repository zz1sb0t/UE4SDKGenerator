using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.NPCs.Elephant.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Elephant_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Elephant_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


}

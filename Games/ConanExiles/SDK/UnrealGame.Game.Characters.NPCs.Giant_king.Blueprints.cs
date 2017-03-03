using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.NPCs.Giant_king.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_GiantKingGhost_C:ABaseBPWildlife_C
	/// Size: 0x1140
	/// Properties: 6
	/// </summary>
	public class ABP_NPC_Wildlife_GiantKingGhost_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4416;
		/// <summary>
		/// Name: HitLoc_LeftLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegLower => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_RightLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegLower => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: Hitloc_Rightleg
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightleg => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: Hitloc_Leftleg
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftleg => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1138);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_GiantKing_C:ABaseBPWildlife_C
	/// Size: 0x1110
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_GiantKing_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4368;
	}


}

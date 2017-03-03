using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Serpent_people_skeleton.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Serpent_people_skeleton.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Serpentpeople_Skeleton_C:ABaseBPWildlife_C
	/// Size: 0x1148
	/// Properties: 7
	/// </summary>
	public class ABP_NPC_Wildlife_Serpentpeople_Skeleton_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4424;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: Hitloc_Leftleg
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftleg => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: Hitloc_Rightleg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightleg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: Hitloc_Leftarm
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftarm => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: Hitloc_Rightarm
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightarm => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1140);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Serpentpeople_Skeleton2_C:ABP_NPC_Wildlife_Serpentpeople_Skeleton_C
	/// Size: 0x1148
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Serpentpeople_Skeleton2_C:ABP_NPC_Wildlife_Serpentpeople_Skeleton_C
	{
		public override int ObjectSize => 4424;
	}


}

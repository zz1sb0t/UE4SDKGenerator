using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Dragon.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Dragon.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_C:ABaseBPWildlife_C
	/// Size: 0x1150
	/// Properties: 8
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4432;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Tail
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Tail => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_RightLegBack
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegBack => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LeftLegBack
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegBack => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_RightLegFront
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegFront => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftLegFront
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegFront => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1148);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_Red_C:ABP_NPC_Wildlife_Dragon_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_Red_C:ABP_NPC_Wildlife_Dragon_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_Green_C:ABP_NPC_Wildlife_Dragon_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_Green_C:ABP_NPC_Wildlife_Dragon_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_Red_Hatchling_C:ABP_NPC_Wildlife_Dragon_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_Red_Hatchling_C:ABP_NPC_Wildlife_Dragon_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_Green_Hatchling_C:ABP_NPC_Wildlife_Dragon_Green_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_Green_Hatchling_C:ABP_NPC_Wildlife_Dragon_Green_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Dragon_Undead_Boss_C:ABP_NPC_Wildlife_Dragon_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Dragon_Undead_Boss_C:ABP_NPC_Wildlife_Dragon_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Dragon_Undead_Boss_C:ABP_NPC_Wildlife_Dragon_Undead_Boss_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Dragon_Undead_Boss_C:ABP_NPC_Wildlife_Dragon_Undead_Boss_C
	{
		public override int ObjectSize => 4432;
	}


}

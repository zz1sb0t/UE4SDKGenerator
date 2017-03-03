using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Locust_Monster.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Locust_Monster.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Locust_melee_C:ABaseBPWildlife_C
	/// Size: 0x1170
	/// Properties: 12
	/// </summary>
	public class ABP_NPC_Wildlife_Locust_melee_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4464;
		/// <summary>
		/// Name: HitLoc_RightBackUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightBackUpperLeg => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_RightBackLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightBackLowerLeg => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_LeftBackUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftBackUpperLeg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LeftBackLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftBackLowerLeg => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_RightFrontUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightFrontUpperLeg => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_RightFrontLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightFrontLowerLeg => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_LeftFrontUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftFrontUpperLeg => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_LeftFrontLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftFrontLowerLeg => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_LeftWing
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftWing => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_RightWing
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightWing => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1168);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Locust_yellow_C:ABP_NPC_Wildlife_Locust_melee_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Locust_yellow_C:ABP_NPC_Wildlife_Locust_melee_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Locust_white_C:ABP_NPC_Wildlife_Locust_melee_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Locust_white_C:ABP_NPC_Wildlife_Locust_melee_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Locust_green_C:ABP_NPC_Wildlife_Locust_melee_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Locust_green_C:ABP_NPC_Wildlife_Locust_melee_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Locust_melee_C:ABP_NPC_Wildlife_Locust_melee_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Locust_melee_C:ABP_NPC_Wildlife_Locust_melee_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Locust_green_C:ABP_NPC_Wildlife_Locust_green_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Locust_green_C:ABP_NPC_Wildlife_Locust_green_C
	{
		public override int ObjectSize => 4464;
	}


}

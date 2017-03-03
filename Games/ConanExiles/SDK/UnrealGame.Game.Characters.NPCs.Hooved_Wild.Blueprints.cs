using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Characters.NPCs.Hooved_Wild.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Hooved_Wild.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Hooved_C:ABaseBPWildlife_C
	/// Size: 0x1198
	/// Properties: 17
	/// </summary>
	public class ABP_NPC_Wildlife_Hooved_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4504;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: AttackPoint_Right
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Right => ReadUObject<UBP_CharacterAttackPoint_C>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_Left
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Left => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1130);
		
		/// <summary>
		/// Name: AttackPoint_Front
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Front => ReadUObject<UBP_CharacterAttackPoint_C>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_LeftLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegLower => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_LeftLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegUpper => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_RightLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegLower => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_RightLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegUpper => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LeftArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmLower => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_LeftArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmUpper => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_RightArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmLower => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: HitLoc_RightArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmUpper => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: HitLoc_Neck
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Neck => ReadUObject<UCapsuleComponent>(0x1180);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1188);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1190
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1190);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RocknoseRocky2_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x1198
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_RocknoseRocky2_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4504;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RocknoseWhite_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x1198
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_RocknoseWhite_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4504;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Antilope_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x11A0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Antilope_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4512;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1198);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Gazelle_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x11A0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Gazelle_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4512;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1198);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kudo_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x11A0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Kudo_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4512;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1198);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RocknoseRocky2_C:ABP_NPC_Wildlife_RocknoseRocky2_C
	/// Size: 0x1198
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RocknoseRocky2_C:ABP_NPC_Wildlife_RocknoseRocky2_C
	{
		public override int ObjectSize => 4504;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RocknoseMolten_C:ABP_NPC_Wildlife_Hooved_C
	/// Size: 0x1198
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_RocknoseMolten_C:ABP_NPC_Wildlife_Hooved_C
	{
		public override int ObjectSize => 4504;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RocknoseMolten_C:ABP_NPC_Wildlife_RocknoseMolten_C
	/// Size: 0x1198
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RocknoseMolten_C:ABP_NPC_Wildlife_RocknoseMolten_C
	{
		public override int ObjectSize => 4504;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Gazelle_C:ABP_NPC_Wildlife_Gazelle_C
	/// Size: 0x11A0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Gazelle_C:ABP_NPC_Wildlife_Gazelle_C
	{
		public override int ObjectSize => 4512;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Kudo_C:ABP_NPC_Wildlife_Kudo_C
	/// Size: 0x11A0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Kudo_C:ABP_NPC_Wildlife_Kudo_C
	{
		public override int ObjectSize => 4512;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Antilope_C:ABP_NPC_Wildlife_Antilope_C
	/// Size: 0x11A0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Antilope_C:ABP_NPC_Wildlife_Antilope_C
	{
		public override int ObjectSize => 4512;
	}


}

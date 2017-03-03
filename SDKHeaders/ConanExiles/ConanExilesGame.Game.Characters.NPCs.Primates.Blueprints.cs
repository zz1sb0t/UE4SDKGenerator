using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Characters.NPCs.Primates.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Primates.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_RocknoseKing2_C:ABaseBPWildlife_C
	/// Size: 0x1160
	/// Properties: 10
	/// </summary>
	public class ABP_NPC_Wildlife_RocknoseKing2_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4448;
		/// <summary>
		/// Name: HitLoc_LeftLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegLower => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_LeftLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegUpper => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_RightLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegLower => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_RightLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegUpper => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_LeftArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmLower => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmUpper => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmLower => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmUpper => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1158);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kappa_C:ABaseBPWildlife_C
	/// Size: 0x1188
	/// Properties: 15
	/// </summary>
	public class ABP_NPC_Wildlife_Kappa_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4488;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: AttackPoint_Right
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Right => ReadUObject<UBP_CharacterAttackPoint_C>(0x1118);
		
		/// <summary>
		/// Name: AttackPoint_Left
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Left => ReadUObject<UBP_CharacterAttackPoint_C>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_Front
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Front => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegLower => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_LeftLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegUpper => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegLower => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_RightLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegUpper => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_LeftArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmLower => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LeftArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmUpper => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_RightArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmLower => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_RightArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmUpper => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1180);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_KappaUndead_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_KappaUndead_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_KappaBaby_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_KappaBaby_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kappa_Green_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Kappa_Green_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kappa_Red_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Kappa_Red_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kappa_Purple_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Kappa_Purple_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Kappa_Blue_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Kappa_Blue_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_KappaKing_C:ABP_NPC_Wildlife_Kappa_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_KappaKing_C:ABP_NPC_Wildlife_Kappa_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_KappaUndead_C:ABP_NPC_Wildlife_KappaUndead_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_KappaUndead_C:ABP_NPC_Wildlife_KappaUndead_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RocknoseKing_C:ABaseBPWildlife_C
	/// Size: 0x1160
	/// Properties: 10
	/// </summary>
	public class ABP_NPC_Wildlife_RocknoseKing_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4448;
		/// <summary>
		/// Name: HitLoc_LeftLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegLower => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_LeftLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLegUpper => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_RightLegLower
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegLower => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_RightLegUpper
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLegUpper => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_LeftArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmLower => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftArmUpper => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightArmLower
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmLower => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightArmUpper
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightArmUpper => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1158);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RocknoseKing_C:ABP_NPC_Wildlife_RocknoseKing_C
	/// Size: 0x1160
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RocknoseKing_C:ABP_NPC_Wildlife_RocknoseKing_C
	{
		public override int ObjectSize => 4448;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RocknoseKing2_C:ABP_NPC_Wildlife_RocknoseKing2_C
	/// Size: 0x1160
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RocknoseKing2_C:ABP_NPC_Wildlife_RocknoseKing2_C
	{
		public override int ObjectSize => 4448;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_KappaBaby_C:ABP_NPC_Wildlife_KappaBaby_C
	/// Size: 0x1120
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_KappaBaby_C:ABP_NPC_Wildlife_KappaBaby_C
	{
		public override int ObjectSize => 4384;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Kappa_Green_C:ABP_NPC_Wildlife_Kappa_Green_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Kappa_Green_C:ABP_NPC_Wildlife_Kappa_Green_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Kappa_Red_C:ABP_NPC_Wildlife_Kappa_Red_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Kappa_Red_C:ABP_NPC_Wildlife_Kappa_Red_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Kappa_Blue_C:ABP_NPC_Wildlife_Kappa_Blue_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Kappa_Blue_C:ABP_NPC_Wildlife_Kappa_Blue_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Kappa_Purple_C:ABP_NPC_Wildlife_Kappa_Purple_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Kappa_Purple_C:ABP_NPC_Wildlife_Kappa_Purple_C
	{
		public override int ObjectSize => 4488;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_KappaKing_C:ABP_NPC_Wildlife_KappaKing_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_KappaKing_C:ABP_NPC_Wildlife_KappaKing_C
	{
		public override int ObjectSize => 4488;
	}


}

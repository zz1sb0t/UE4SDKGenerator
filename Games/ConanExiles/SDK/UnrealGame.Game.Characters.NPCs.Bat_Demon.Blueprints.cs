using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Bat_Demon.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Bat_Demon.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Bat_Demon_C:ABaseBPWildlife_C
	/// Size: 0x1190
	/// Properties: 16
	/// </summary>
	public class ABP_NPC_Wildlife_Bat_Demon_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4496;
		/// <summary>
		/// Name: AttackPoint_RightSide
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_RightSide => ReadUObject<UBP_CharacterAttackPoint_C>(0x1110);
		
		/// <summary>
		/// Name: AttackPoint_LeftSide
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_LeftSide => ReadUObject<UBP_CharacterAttackPoint_C>(0x1118);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_Head
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Head => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_LeftLowerArm => ReadUObject<UBoxComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_LeftUpperArm => ReadUObject<UBoxComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_RightLowerArm => ReadUObject<UBoxComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_RightUpperArm => ReadUObject<UBoxComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_RightMiddleLeg
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightMiddleLeg => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_LeftMiddleLeg
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftMiddleLeg => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1180);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1188);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Bat_Demon_White_C:ABP_NPC_Wildlife_Bat_Demon_C
	/// Size: 0x1190
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Bat_Demon_White_C:ABP_NPC_Wildlife_Bat_Demon_C
	{
		public override int ObjectSize => 4496;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Bat_Demon_C:ABP_NPC_Wildlife_Bat_Demon_C
	/// Size: 0x1190
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Bat_Demon_C:ABP_NPC_Wildlife_Bat_Demon_C
	{
		public override int ObjectSize => 4496;
	}


}

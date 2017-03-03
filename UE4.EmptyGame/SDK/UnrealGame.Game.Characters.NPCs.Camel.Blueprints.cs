using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Characters;
using UnrealGame.Script;
using UnrealGame.Game.Systems.AI;
using UnrealGame.Game.Characters.NPCs.Camel.Blueprints;


namespace UnrealGame.Game.Characters.NPCs.Camel.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Camel_C:ABaseBPWildlife_C
	/// Size: 0x1158
	/// Properties: 9
	/// </summary>
	public class ABP_NPC_Wildlife_Camel_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4440;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: AttackPoint_RightFront
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_RightFront => ReadUObject<UBP_CharacterAttackPoint_C>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_RightBack
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_RightBack => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: AttackPoint_LeftBack
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_LeftBack => ReadUObject<UBP_CharacterAttackPoint_C>(0x1130);
		
		/// <summary>
		/// Name: AttackPoint_LeftFront
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_LeftFront => ReadUObject<UBP_CharacterAttackPoint_C>(0x1138);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1140);
		
		/// <summary>
		/// Name: AttackPoint_Head
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Head => ReadUObject<UBP_CharacterAttackPoint_C>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1150);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Camel_C:ABP_NPC_Wildlife_Camel_C
	/// Size: 0x1158
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Camel_C:ABP_NPC_Wildlife_Camel_C
	{
		public override int ObjectSize => 4440;
	}


}

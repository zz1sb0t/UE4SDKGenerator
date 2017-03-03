using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Undead.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Undead.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Undead_C:ABaseBPWildlife_C
	/// Size: 0x1188
	/// Properties: 13
	/// </summary>
	public class ABP_NPC_Wildlife_Undead_C:ABaseBPWildlife_C
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
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: MainHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1168
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OffHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1178
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_UndeadArcher_C:ABaseBPWildlife_C
	/// Size: 0x1188
	/// Properties: 13
	/// </summary>
	public class ABP_NPC_Wildlife_UndeadArcher_C:ABaseBPWildlife_C
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
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: MainHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1168
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OffHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1178
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_UndeadTorch_C:ABaseBPWildlife_C
	/// Size: 0x1188
	/// Properties: 13
	/// </summary>
	public class ABP_NPC_Wildlife_UndeadTorch_C:ABaseBPWildlife_C
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
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: MainHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1168
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OffHandWeaponArray
		/// Type: TArray<>
		/// Offset: 0x1178
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Undead_C:ABP_NPC_Wildlife_Undead_C
	/// Size: 0x1188
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Undead_C:ABP_NPC_Wildlife_Undead_C
	{
		public override int ObjectSize => 4488;
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Effects.blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Humanoid
{
	/// <summary>
	/// ABaseHumanoidNPC_C:ABaseNPC_C
	/// Size: 0x1380
	/// Properties: 28
	/// </summary>
	public class ABaseHumanoidNPC_C:ABaseNPC_C
	{
		public override int ObjectSize => 4992;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x10E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x10E8);
		
		/// <summary>
		/// Name: FloatingName
		/// Type: ObjectProperty
		/// Offset: 0x10F0
		/// Size: 0x08
		/// </summary>
		public UWidgetComponent FloatingName => ReadUObject<UWidgetComponent>(0x10F0);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x10F8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio => ReadUObject<UConanAudioComponent>(0x10F8);
		
		/// <summary>
		/// Name: AttackPoint_Front
		/// Type: ObjectProperty
		/// Offset: 0x1100
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Front => ReadUObject<UBP_CharacterAttackPoint_C>(0x1100);
		
		/// <summary>
		/// Name: AttackPoint_Left
		/// Type: ObjectProperty
		/// Offset: 0x1108
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Left => ReadUObject<UBP_CharacterAttackPoint_C>(0x1108);
		
		/// <summary>
		/// Name: AttackPoint_Right
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Right => ReadUObject<UBP_CharacterAttackPoint_C>(0x1110);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1118);
		
		/// <summary>
		/// Name: BP_CharacterCustomizationComponent
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterCustomizationComponent_C BP_CharacterCustomizationComponent => ReadUObject<UBP_CharacterCustomizationComponent_C>(0x1120);
		
		/// <summary>
		/// Name: DynamicMaterialParamController
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UDynamicMaterialParamController_C DynamicMaterialParamController => ReadUObject<UDynamicMaterialParamController_C>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: CharacterLayout
		/// Type: StructProperty
		/// Offset: 0x1180
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout CharacterLayout => ReadStruct<FCharacterLayout>(0x1180);
		
		/// <summary>
		/// Name: HasBegunPlay
		/// Type: BoolProperty
		/// Offset: 0x12A4
		/// Size: 0x01
		/// </summary>
		public bool HasBegunPlay
		{
			get
			{
				return ReadBool(0x12A4);
			}
			set
			{
				WriteBool(0x12A4,value);
			}
		}
		
		/// <summary>
		/// Name: ConstraintActor
		/// Type: TArray<APhysicsConstraintActor>
		/// Offset: 0x12A8
		/// Size: 0x10
		/// SubElement Size: 0x3F0
		/// </summary>
		public TArray<APhysicsConstraintActor> ConstraintActor => new TArray<APhysicsConstraintActor>(BaseAddress+0x12A8);
		
		/// <summary>
		/// Name: GettingUp
		/// Type: BoolProperty
		/// Offset: 0x12B8
		/// Size: 0x01
		/// </summary>
		public bool GettingUp
		{
			get
			{
				return ReadBool(0x12B8);
			}
			set
			{
				WriteBool(0x12B8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayRate
		/// Type: FloatProperty
		/// Offset: 0x12BC
		/// Size: 0x04
		/// </summary>
		public float PlayRate
		{
			get
			{
				return ReadSingle(0x12BC);
			}
			set
			{
				WriteSingle(0x12BC,value);
			}
		}
		
		/// <summary>
		/// Name: GetUpSequence
		/// Type: ObjectProperty
		/// Offset: 0x12E0
		/// Size: 0x08
		/// </summary>
		public UAnimSequence GetUpSequence => ReadUObject<UAnimSequence>(0x12E0);
		
		/// <summary>
		/// Name: ThrallRopeOwner
		/// Type: InterfaceProperty
		/// Offset: 0x12E8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: TimeUnconscious
		/// Type: FloatProperty
		/// Offset: 0x12F8
		/// Size: 0x04
		/// </summary>
		public float TimeUnconscious
		{
			get
			{
				return ReadSingle(0x12F8);
			}
			set
			{
				WriteSingle(0x12F8,value);
			}
		}
		
		/// <summary>
		/// Name: ThrallInfo
		/// Type: StructProperty
		/// Offset: 0x1300
		/// Size: 0x80
		/// </summary>
		public FThrallInfo ThrallInfo => ReadStruct<FThrallInfo>(0x1300);
		
	}


	/// <summary>
	/// UHumanoidNPCInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UHumanoidNPCInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

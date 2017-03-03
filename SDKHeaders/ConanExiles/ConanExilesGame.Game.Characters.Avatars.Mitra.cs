using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters.Avatars;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Combat;


namespace ConanExilesGame.Game.Characters.Avatars.Mitra
{
	/// <summary>
	/// ABP_AvatarMitraCharacter_C:ABP_AvatarCharacter_C
	/// Size: 0xB60
	/// Properties: 20
	/// </summary>
	public class ABP_AvatarMitraCharacter_C:ABP_AvatarCharacter_C
	{
		public override int ObjectSize => 2912;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xAC0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xAC0);
		
		/// <summary>
		/// Name: LeftFootRadialSphere
		/// Type: ObjectProperty
		/// Offset: 0xAC8
		/// Size: 0x08
		/// </summary>
		public USphereComponent LeftFootRadialSphere => ReadUObject<USphereComponent>(0xAC8);
		
		/// <summary>
		/// Name: SweepBoxLeftLeg
		/// Type: ObjectProperty
		/// Offset: 0xAD0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxLeftLeg => ReadUObject<UBoxComponent>(0xAD0);
		
		/// <summary>
		/// Name: SweepBoxRightLeg
		/// Type: ObjectProperty
		/// Offset: 0xAD8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxRightLeg => ReadUObject<UBoxComponent>(0xAD8);
		
		/// <summary>
		/// Name: SweepBoxRightArm
		/// Type: ObjectProperty
		/// Offset: 0xAE0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxRightArm => ReadUObject<UBoxComponent>(0xAE0);
		
		/// <summary>
		/// Name: SweepBoxTorso
		/// Type: ObjectProperty
		/// Offset: 0xAE8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxTorso => ReadUObject<UBoxComponent>(0xAE8);
		
		/// <summary>
		/// Name: SweepBoxLeftArm
		/// Type: ObjectProperty
		/// Offset: 0xAF0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxLeftArm => ReadUObject<UBoxComponent>(0xAF0);
		
		/// <summary>
		/// Name: SweepBoxLeftFoot
		/// Type: ObjectProperty
		/// Offset: 0xAF8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxLeftFoot => ReadUObject<UBoxComponent>(0xAF8);
		
		/// <summary>
		/// Name: SweepDamageComponent
		/// Type: ObjectProperty
		/// Offset: 0xB00
		/// Size: 0x08
		/// </summary>
		public USweepDamageComponent_C SweepDamageComponent => ReadUObject<USweepDamageComponent_C>(0xB00);
		
		/// <summary>
		/// Name: SweepBoxRightFoot
		/// Type: ObjectProperty
		/// Offset: 0xB08
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SweepBoxRightFoot => ReadUObject<UBoxComponent>(0xB08);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0xB10
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0xB10);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0xB18
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0xB18);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0xB20
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0xB20);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0xB28
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0xB28);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0xB30
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0xB30);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0xB38
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0xB38);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0xB40
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0xB40);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0xB48
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0xB48);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0xB50
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0xB50);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0xB58
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0xB58);
		
	}


	/// <summary>
	/// Uab_avatar_mitra_C:UAnimInstance
	/// Size: 0xA88
	/// Properties: 40
	/// </summary>
	public class Uab_avatar_mitra_C:UAnimInstance
	{
		public override int ObjectSize => 2696;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_2DDE1DCF4B38F33042C7AE86547AA215
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_2DDE1DCF4B38F33042C7AE86547AA215 => ReadStruct<FAnimNode_ModifyBone>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_F20F09FE42BDC25F35F52A84EEF4B371
		/// Type: StructProperty
		/// Offset: 0x538
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_F20F09FE42BDC25F35F52A84EEF4B371 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x538);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_87214CD34ED242EABCFE108EE1D4F4C1
		/// Type: StructProperty
		/// Offset: 0x580
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_87214CD34ED242EABCFE108EE1D4F4C1 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x580);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E7CD57E041C7924EE0F55C93D50DCFF4
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E7CD57E041C7924EE0F55C93D50DCFF4 => ReadStruct<FAnimNode_ModifyBone>(0x5C8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_B7C1B9D547EA69063C84E1B5BCF37B2A
		/// Type: StructProperty
		/// Offset: 0x678
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_B7C1B9D547EA69063C84E1B5BCF37B2A => ReadStruct<FAnimNode_BlendSpacePlayer>(0x678);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_0C8381F543BF104E424964BCB7D1116D
		/// Type: StructProperty
		/// Offset: 0x7A8
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_0C8381F543BF104E424964BCB7D1116D => ReadStruct<FAnimNode_Slot>(0x7A8);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_E4D517A14B0E8EFDC7D932ADE430FE0D
		/// Type: StructProperty
		/// Offset: 0x808
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_E4D517A14B0E8EFDC7D932ADE430FE0D => ReadStruct<FAnimNode_Root>(0x808);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_B66C07064686B1E45EB08BB0D773C72B
		/// Type: StructProperty
		/// Offset: 0x850
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_B66C07064686B1E45EB08BB0D773C72B => ReadStruct<FAnimNode_BlendListByBool>(0x850);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_9F8B87DA4A7A169DF50BB2B53031B915
		/// Type: StructProperty
		/// Offset: 0x920
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_9F8B87DA4A7A169DF50BB2B53031B915 => ReadStruct<FAnimNode_SequencePlayer>(0x920);
		
		/// <summary>
		/// Name: Direction
		/// Type: FloatProperty
		/// Offset: 0x990
		/// Size: 0x04
		/// </summary>
		public float Direction
		{
			get
			{
				return ReadSingle(0x990);
			}
			set
			{
				WriteSingle(0x990,value);
			}
		}
		
		/// <summary>
		/// Name: SpeedXY
		/// Type: FloatProperty
		/// Offset: 0x994
		/// Size: 0x04
		/// </summary>
		public float SpeedXY
		{
			get
			{
				return ReadSingle(0x994);
			}
			set
			{
				WriteSingle(0x994,value);
			}
		}
		
		/// <summary>
		/// Name: ResetAnimCounter
		/// Type: IntProperty
		/// Offset: 0x998
		/// Size: 0x04
		/// </summary>
		public int ResetAnimCounter
		{
			get
			{
				return ReadInt32(0x998);
			}
			set
			{
				WriteInt32(0x998,value);
			}
		}
		
		/// <summary>
		/// Name: PrevSpeedXY
		/// Type: FloatProperty
		/// Offset: 0x99C
		/// Size: 0x04
		/// </summary>
		public float PrevSpeedXY
		{
			get
			{
				return ReadSingle(0x99C);
			}
			set
			{
				WriteSingle(0x99C,value);
			}
		}
		
		/// <summary>
		/// Name: PrevDirection
		/// Type: StructProperty
		/// Offset: 0x9A0
		/// Size: 0x0C
		/// </summary>
		public FVector PrevDirection => ReadStruct<FVector>(0x9A0);
		
		/// <summary>
		/// Name: HeadRotator
		/// Type: StructProperty
		/// Offset: 0x9AC
		/// Size: 0x0C
		/// </summary>
		public FRotator HeadRotator => ReadStruct<FRotator>(0x9AC);
		
		/// <summary>
		/// Name: PrevHeadRotator
		/// Type: StructProperty
		/// Offset: 0x9B8
		/// Size: 0x0C
		/// </summary>
		public FRotator PrevHeadRotator => ReadStruct<FRotator>(0x9B8);
		
		/// <summary>
		/// Name: rightKnee
		/// Type: StructProperty
		/// Offset: 0x9C4
		/// Size: 0x0C
		/// </summary>
		public FVector rightKnee => ReadStruct<FVector>(0x9C4);
		
		/// <summary>
		/// Name: LeftKnee
		/// Type: StructProperty
		/// Offset: 0x9D0
		/// Size: 0x0C
		/// </summary>
		public FVector LeftKnee => ReadStruct<FVector>(0x9D0);
		
		/// <summary>
		/// Name: HipsAlpha
		/// Type: FloatProperty
		/// Offset: 0x9DC
		/// Size: 0x04
		/// </summary>
		public float HipsAlpha
		{
			get
			{
				return ReadSingle(0x9DC);
			}
			set
			{
				WriteSingle(0x9DC,value);
			}
		}
		
		/// <summary>
		/// Name: OldRightFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0x9E0
		/// Size: 0x04
		/// </summary>
		public float OldRightFootIKAlpha
		{
			get
			{
				return ReadSingle(0x9E0);
			}
			set
			{
				WriteSingle(0x9E0,value);
			}
		}
		
		/// <summary>
		/// Name: OldLeftFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0x9E4
		/// Size: 0x04
		/// </summary>
		public float OldLeftFootIKAlpha
		{
			get
			{
				return ReadSingle(0x9E4);
			}
			set
			{
				WriteSingle(0x9E4,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0x9E8
		/// Size: 0x04
		/// </summary>
		public float RightFootIKAlpha
		{
			get
			{
				return ReadSingle(0x9E8);
			}
			set
			{
				WriteSingle(0x9E8,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0x9EC
		/// Size: 0x04
		/// </summary>
		public float LeftFootIKAlpha
		{
			get
			{
				return ReadSingle(0x9EC);
			}
			set
			{
				WriteSingle(0x9EC,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootIKOffset
		/// Type: FloatProperty
		/// Offset: 0x9F0
		/// Size: 0x04
		/// </summary>
		public float RightFootIKOffset
		{
			get
			{
				return ReadSingle(0x9F0);
			}
			set
			{
				WriteSingle(0x9F0,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFootIKOffset
		/// Type: FloatProperty
		/// Offset: 0x9F4
		/// Size: 0x04
		/// </summary>
		public float LeftFootIKOffset
		{
			get
			{
				return ReadSingle(0x9F4);
			}
			set
			{
				WriteSingle(0x9F4,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootIKTarget
		/// Type: StructProperty
		/// Offset: 0x9F8
		/// Size: 0x0C
		/// </summary>
		public FVector RightFootIKTarget => ReadStruct<FVector>(0x9F8);
		
		/// <summary>
		/// Name: LeftFootIKTarget
		/// Type: StructProperty
		/// Offset: 0xA04
		/// Size: 0x0C
		/// </summary>
		public FVector LeftFootIKTarget => ReadStruct<FVector>(0xA04);
		
		/// <summary>
		/// Name: OldHipsTarget
		/// Type: StructProperty
		/// Offset: 0xA10
		/// Size: 0x0C
		/// </summary>
		public FVector OldHipsTarget => ReadStruct<FVector>(0xA10);
		
		/// <summary>
		/// Name: HipTarget
		/// Type: StructProperty
		/// Offset: 0xA1C
		/// Size: 0x0C
		/// </summary>
		public FVector HipTarget => ReadStruct<FVector>(0xA1C);
		
		/// <summary>
		/// Name: HipsOffsetDistance
		/// Type: FloatProperty
		/// Offset: 0xA28
		/// Size: 0x04
		/// </summary>
		public float HipsOffsetDistance
		{
			get
			{
				return ReadSingle(0xA28);
			}
			set
			{
				WriteSingle(0xA28,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootRotation
		/// Type: StructProperty
		/// Offset: 0xA2C
		/// Size: 0x0C
		/// </summary>
		public FRotator RightFootRotation => ReadStruct<FRotator>(0xA2C);
		
		/// <summary>
		/// Name: LeftFootRotation
		/// Type: StructProperty
		/// Offset: 0xA38
		/// Size: 0x0C
		/// </summary>
		public FRotator LeftFootRotation => ReadStruct<FRotator>(0xA38);
		
		/// <summary>
		/// Name: UpVector
		/// Type: StructProperty
		/// Offset: 0xA44
		/// Size: 0x0C
		/// </summary>
		public FVector UpVector => ReadStruct<FVector>(0xA44);
		
		/// <summary>
		/// Name: HeadRotatorX
		/// Type: StructProperty
		/// Offset: 0xA50
		/// Size: 0x0C
		/// </summary>
		public FRotator HeadRotatorX => ReadStruct<FRotator>(0xA50);
		
		/// <summary>
		/// Name: HeadRotatorZ
		/// Type: StructProperty
		/// Offset: 0xA5C
		/// Size: 0x0C
		/// </summary>
		public FRotator HeadRotatorZ => ReadStruct<FRotator>(0xA5C);
		
		/// <summary>
		/// Name: InterpolationSpeed
		/// Type: FloatProperty
		/// Offset: 0xA68
		/// Size: 0x04
		/// </summary>
		public float InterpolationSpeed
		{
			get
			{
				return ReadSingle(0xA68);
			}
			set
			{
				WriteSingle(0xA68,value);
			}
		}
		
		/// <summary>
		/// Name: IsSpawning
		/// Type: BoolProperty
		/// Offset: 0xA6C
		/// Size: 0x01
		/// </summary>
		public bool IsSpawning
		{
			get
			{
				return ReadBool(0xA6C);
			}
			set
			{
				WriteBool(0xA6C,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootZ
		/// Type: StructProperty
		/// Offset: 0xA70
		/// Size: 0x0C
		/// </summary>
		public FVector RightFootZ => ReadStruct<FVector>(0xA70);
		
		/// <summary>
		/// Name: LeftFootZ
		/// Type: StructProperty
		/// Offset: 0xA7C
		/// Size: 0x0C
		/// </summary>
		public FVector LeftFootZ => ReadStruct<FVector>(0xA7C);
		
	}


}

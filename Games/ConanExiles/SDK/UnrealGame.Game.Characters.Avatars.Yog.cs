using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters.Avatars;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Combat;


namespace ConanExilesGame.Game.Characters.Avatars.Yog
{
	/// <summary>
	/// ABP_AvatarYogCharacter_C:ABP_AvatarCharacter_C
	/// Size: 0xB95
	/// Properties: 31
	/// </summary>
	public class ABP_AvatarYogCharacter_C:ABP_AvatarCharacter_C
	{
		public override int ObjectSize => 2965;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xAC0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xAC0);
		
		/// <summary>
		/// Name: MovingSound
		/// Type: ObjectProperty
		/// Offset: 0xAC8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent MovingSound => ReadUObject<UConanAudioComponent>(0xAC8);
		
		/// <summary>
		/// Name: CorruptionDecal
		/// Type: ObjectProperty
		/// Offset: 0xAD0
		/// Size: 0x08
		/// </summary>
		public UDecalComponent CorruptionDecal => ReadUObject<UDecalComponent>(0xAD0);
		
		/// <summary>
		/// Name: Drool
		/// Type: ObjectProperty
		/// Offset: 0xAD8
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent Drool => ReadUObject<UParticleSystemComponent>(0xAD8);
		
		/// <summary>
		/// Name: DroolSmoke
		/// Type: ObjectProperty
		/// Offset: 0xAE0
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent DroolSmoke => ReadUObject<UParticleSystemComponent>(0xAE0);
		
		/// <summary>
		/// Name: b_tentacle_front_09
		/// Type: ObjectProperty
		/// Offset: 0xAE8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_tentacle_front_09 => ReadUObject<UCapsuleComponent>(0xAE8);
		
		/// <summary>
		/// Name: b_tentacle_front_03
		/// Type: ObjectProperty
		/// Offset: 0xAF0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_tentacle_front_03 => ReadUObject<UCapsuleComponent>(0xAF0);
		
		/// <summary>
		/// Name: b_R_tentacle_1_09
		/// Type: ObjectProperty
		/// Offset: 0xAF8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_1_09 => ReadUObject<UCapsuleComponent>(0xAF8);
		
		/// <summary>
		/// Name: b_R_tentacle_1_03
		/// Type: ObjectProperty
		/// Offset: 0xB00
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_1_03 => ReadUObject<UCapsuleComponent>(0xB00);
		
		/// <summary>
		/// Name: b_L_tentacle_1_09
		/// Type: ObjectProperty
		/// Offset: 0xB08
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_1_09 => ReadUObject<UCapsuleComponent>(0xB08);
		
		/// <summary>
		/// Name: b_L_tentacle_1_03
		/// Type: ObjectProperty
		/// Offset: 0xB10
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_1_03 => ReadUObject<UCapsuleComponent>(0xB10);
		
		/// <summary>
		/// Name: b_R_tentacle_2_09
		/// Type: ObjectProperty
		/// Offset: 0xB18
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_2_09 => ReadUObject<UCapsuleComponent>(0xB18);
		
		/// <summary>
		/// Name: b_R_tentacle_2_03
		/// Type: ObjectProperty
		/// Offset: 0xB20
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_2_03 => ReadUObject<UCapsuleComponent>(0xB20);
		
		/// <summary>
		/// Name: b_L_tentacle_3_09
		/// Type: ObjectProperty
		/// Offset: 0xB28
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_3_09 => ReadUObject<UCapsuleComponent>(0xB28);
		
		/// <summary>
		/// Name: b_L_tentacle_3_03
		/// Type: ObjectProperty
		/// Offset: 0xB30
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_3_03 => ReadUObject<UCapsuleComponent>(0xB30);
		
		/// <summary>
		/// Name: b_L_tentacle_2_09
		/// Type: ObjectProperty
		/// Offset: 0xB38
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_2_09 => ReadUObject<UCapsuleComponent>(0xB38);
		
		/// <summary>
		/// Name: b_L_tentacle_2_03
		/// Type: ObjectProperty
		/// Offset: 0xB40
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_L_tentacle_2_03 => ReadUObject<UCapsuleComponent>(0xB40);
		
		/// <summary>
		/// Name: b_R_tentacle_3_09
		/// Type: ObjectProperty
		/// Offset: 0xB48
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_3_09 => ReadUObject<UCapsuleComponent>(0xB48);
		
		/// <summary>
		/// Name: b_R_tentacle_3_03
		/// Type: ObjectProperty
		/// Offset: 0xB50
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent b_R_tentacle_3_03 => ReadUObject<UCapsuleComponent>(0xB50);
		
		/// <summary>
		/// Name: Sweep_Body
		/// Type: ObjectProperty
		/// Offset: 0xB58
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Sweep_Body => ReadUObject<UCapsuleComponent>(0xB58);
		
		/// <summary>
		/// Name: SweepDamageComponent
		/// Type: ObjectProperty
		/// Offset: 0xB60
		/// Size: 0x08
		/// </summary>
		public USweepDamageComponent_C SweepDamageComponent => ReadUObject<USweepDamageComponent_C>(0xB60);
		
		/// <summary>
		/// Name: SlamAttackMaxVelocity
		/// Type: FloatProperty
		/// Offset: 0xB68
		/// Size: 0x04
		/// </summary>
		public float SlamAttackMaxVelocity
		{
			get
			{
				return ReadSingle(0xB68);
			}
			set
			{
				WriteSingle(0xB68,value);
			}
		}
		
		/// <summary>
		/// Name: SlamAttackAcceleration
		/// Type: FloatProperty
		/// Offset: 0xB6C
		/// Size: 0x04
		/// </summary>
		public float SlamAttackAcceleration
		{
			get
			{
				return ReadSingle(0xB6C);
			}
			set
			{
				WriteSingle(0xB6C,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterState
		/// Type: ByteProperty
		/// Offset: 0xB70
		/// Size: 0x01
		/// </summary>
		public byte CharacterState
		{
			get
			{
				return ReadByte(0xB70);
			}
			set
			{
				WriteByte(0xB70,value);
			}
		}
		
		/// <summary>
		/// Name: LastLocation
		/// Type: StructProperty
		/// Offset: 0xB74
		/// Size: 0x0C
		/// </summary>
		public FVector LastLocation => ReadStruct<FVector>(0xB74);
		
		/// <summary>
		/// Name: OriginalMaxFlySpeed
		/// Type: FloatProperty
		/// Offset: 0xB80
		/// Size: 0x04
		/// </summary>
		public float OriginalMaxFlySpeed
		{
			get
			{
				return ReadSingle(0xB80);
			}
			set
			{
				WriteSingle(0xB80,value);
			}
		}
		
		/// <summary>
		/// Name: OriginalMaxAcceleration
		/// Type: FloatProperty
		/// Offset: 0xB84
		/// Size: 0x04
		/// </summary>
		public float OriginalMaxAcceleration
		{
			get
			{
				return ReadSingle(0xB84);
			}
			set
			{
				WriteSingle(0xB84,value);
			}
		}
		
		/// <summary>
		/// Name: MaxFlyHeight
		/// Type: FloatProperty
		/// Offset: 0xB88
		/// Size: 0x04
		/// </summary>
		public float MaxFlyHeight
		{
			get
			{
				return ReadSingle(0xB88);
			}
			set
			{
				WriteSingle(0xB88,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentFlyingHeight
		/// Type: FloatProperty
		/// Offset: 0xB8C
		/// Size: 0x04
		/// </summary>
		public float CurrentFlyingHeight
		{
			get
			{
				return ReadSingle(0xB8C);
			}
			set
			{
				WriteSingle(0xB8C,value);
			}
		}
		
		/// <summary>
		/// Name: GroundZ
		/// Type: FloatProperty
		/// Offset: 0xB90
		/// Size: 0x04
		/// </summary>
		public float GroundZ
		{
			get
			{
				return ReadSingle(0xB90);
			}
			set
			{
				WriteSingle(0xB90,value);
			}
		}
		
		/// <summary>
		/// Name: IsPlayingMoveSound
		/// Type: BoolProperty
		/// Offset: 0xB94
		/// Size: 0x01
		/// </summary>
		public bool IsPlayingMoveSound
		{
			get
			{
				return ReadBool(0xB94);
			}
			set
			{
				WriteBool(0xB94,value);
			}
		}
		
	}


	/// <summary>
	/// Uab_avatar_yog_C:UAnimInstance
	/// Size: 0x7AC
	/// Properties: 10
	/// </summary>
	public class Uab_avatar_yog_C:UAnimInstance
	{
		public override int ObjectSize => 1964;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_B95F0BFD44EB57EA86C9989E5A06FE9B
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_B95F0BFD44EB57EA86C9989E5A06FE9B => ReadStruct<FAnimNode_Slot>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_EDC6288041F711BFE77FA7B927A28B79
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_EDC6288041F711BFE77FA7B927A28B79 => ReadStruct<FAnimNode_Root>(0x4E8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_76F8B41F46BCC27A19737B81DC18A6A1
		/// Type: StructProperty
		/// Offset: 0x530
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_76F8B41F46BCC27A19737B81DC18A6A1 => ReadStruct<FAnimNode_BlendListByBool>(0x530);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_E4D4A764445CF94D0C59F7B0D61C4D00
		/// Type: StructProperty
		/// Offset: 0x600
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_E4D4A764445CF94D0C59F7B0D61C4D00 => ReadStruct<FAnimNode_SequencePlayer>(0x600);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_85A76E614FA30E5C5058A691FA10EDF1
		/// Type: StructProperty
		/// Offset: 0x670
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_85A76E614FA30E5C5058A691FA10EDF1 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x670);
		
		/// <summary>
		/// Name: IsAttacking
		/// Type: BoolProperty
		/// Offset: 0x7A0
		/// Size: 0x01
		/// </summary>
		public bool IsAttacking
		{
			get
			{
				return ReadBool(0x7A0);
			}
			set
			{
				WriteBool(0x7A0,value);
			}
		}
		
		/// <summary>
		/// Name: IsSpawning
		/// Type: BoolProperty
		/// Offset: 0x7A1
		/// Size: 0x01
		/// </summary>
		public bool IsSpawning
		{
			get
			{
				return ReadBool(0x7A1);
			}
			set
			{
				WriteBool(0x7A1,value);
			}
		}
		
		/// <summary>
		/// Name: Direction
		/// Type: FloatProperty
		/// Offset: 0x7A4
		/// Size: 0x04
		/// </summary>
		public float Direction
		{
			get
			{
				return ReadSingle(0x7A4);
			}
			set
			{
				WriteSingle(0x7A4,value);
			}
		}
		
		/// <summary>
		/// Name: Speed
		/// Type: FloatProperty
		/// Offset: 0x7A8
		/// Size: 0x04
		/// </summary>
		public float Speed
		{
			get
			{
				return ReadSingle(0x7A8);
			}
			set
			{
				WriteSingle(0x7A8,value);
			}
		}
		
	}


}

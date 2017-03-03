using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.Avatars
{
	/// <summary>
	/// UBP_AvatarCharacterInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AvatarCharacterInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_Avatar_ABInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_Avatar_ABInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABP_AvatarCharacter_C:AAvatarCharacter
	/// Size: 0xABC
	/// Properties: 12
	/// </summary>
	public class ABP_AvatarCharacter_C:AAvatarCharacter
	{
		public override int ObjectSize => 2748;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA70
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA70);
		
		/// <summary>
		/// Name: ThirdPersonCamera
		/// Type: ObjectProperty
		/// Offset: 0xA78
		/// Size: 0x08
		/// </summary>
		public UCameraComponent ThirdPersonCamera => ReadUObject<UCameraComponent>(0xA78);
		
		/// <summary>
		/// Name: ThirdPersonSpringArm
		/// Type: ObjectProperty
		/// Offset: 0xA80
		/// Size: 0x08
		/// </summary>
		public USpringArmComponent ThirdPersonSpringArm => ReadUObject<USpringArmComponent>(0xA80);
		
		/// <summary>
		/// Name: ReplicatedSpringArmRot
		/// Type: StructProperty
		/// Offset: 0xA88
		/// Size: 0x0C
		/// </summary>
		public FRotator ReplicatedSpringArmRot => ReadStruct<FRotator>(0xA88);
		
		/// <summary>
		/// Name: SpringArmRepTimer
		/// Type: FloatProperty
		/// Offset: 0xA94
		/// Size: 0x04
		/// </summary>
		public float SpringArmRepTimer
		{
			get
			{
				return ReadSingle(0xA94);
			}
			set
			{
				WriteSingle(0xA94,value);
			}
		}
		
		/// <summary>
		/// Name: TurnRate
		/// Type: FloatProperty
		/// Offset: 0xA98
		/// Size: 0x04
		/// </summary>
		public float TurnRate
		{
			get
			{
				return ReadSingle(0xA98);
			}
			set
			{
				WriteSingle(0xA98,value);
			}
		}
		
		/// <summary>
		/// Name: DiagonalMovementScale
		/// Type: FloatProperty
		/// Offset: 0xA9C
		/// Size: 0x04
		/// </summary>
		public float DiagonalMovementScale
		{
			get
			{
				return ReadSingle(0xA9C);
			}
			set
			{
				WriteSingle(0xA9C,value);
			}
		}
		
		/// <summary>
		/// Name: BaseLookUpRate
		/// Type: FloatProperty
		/// Offset: 0xAA0
		/// Size: 0x04
		/// </summary>
		public float BaseLookUpRate
		{
			get
			{
				return ReadSingle(0xAA0);
			}
			set
			{
				WriteSingle(0xAA0,value);
			}
		}
		
		/// <summary>
		/// Name: BaseTurnRate
		/// Type: FloatProperty
		/// Offset: 0xAA4
		/// Size: 0x04
		/// </summary>
		public float BaseTurnRate
		{
			get
			{
				return ReadSingle(0xAA4);
			}
			set
			{
				WriteSingle(0xAA4,value);
			}
		}
		
		/// <summary>
		/// Name: TimeOfSummoning
		/// Type: FloatProperty
		/// Offset: 0xAA8
		/// Size: 0x04
		/// </summary>
		public float TimeOfSummoning
		{
			get
			{
				return ReadSingle(0xAA8);
			}
			set
			{
				WriteSingle(0xAA8,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarHUD
		/// Type: ObjectProperty
		/// Offset: 0xAB0
		/// Size: 0x08
		/// </summary>
		public URootWidget AvatarHUD => ReadUObject<URootWidget>(0xAB0);
		
		/// <summary>
		/// Name: SpawnFinishedTimeSeconds
		/// Type: FloatProperty
		/// Offset: 0xAB8
		/// Size: 0x04
		/// </summary>
		public float SpawnFinishedTimeSeconds
		{
			get
			{
				return ReadSingle(0xAB8);
			}
			set
			{
				WriteSingle(0xAB8,value);
			}
		}
		
	}


}

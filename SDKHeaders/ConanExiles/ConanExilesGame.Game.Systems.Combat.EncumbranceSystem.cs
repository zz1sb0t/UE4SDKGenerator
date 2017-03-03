using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Progression;


namespace ConanExilesGame.Game.Systems.Combat.EncumbranceSystem
{
	/// <summary>
	/// UI_EncumbranceSystemInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_EncumbranceSystemInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_EncumbranceSystem_C:UEncumbranceSystem
	/// Size: 0x16C
	/// Properties: 12
	/// </summary>
	public class UBP_EncumbranceSystem_C:UEncumbranceSystem
	{
		public override int ObjectSize => 364;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF8);
		
		/// <summary>
		/// Name: EncumbranceStaminaEffect
		/// Type: TArray<>
		/// Offset: 0x100
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: EncumbranceCurrent
		/// Type: FloatProperty
		/// Offset: 0x110
		/// Size: 0x04
		/// </summary>
		public float EncumbranceCurrent
		{
			get
			{
				return ReadSingle(0x110);
			}
			set
			{
				WriteSingle(0x110,value);
			}
		}
		
		/// <summary>
		/// Name: EncumbranceBase
		/// Type: FloatProperty
		/// Offset: 0x114
		/// Size: 0x04
		/// </summary>
		public float EncumbranceBase
		{
			get
			{
				return ReadSingle(0x114);
			}
			set
			{
				WriteSingle(0x114,value);
			}
		}
		
		/// <summary>
		/// Name: OwnerInventories
		/// Type: TArray<UItemInventory>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x280
		/// </summary>
		public TArray<UItemInventory> OwnerInventories => new TArray<UItemInventory>(BaseAddress+0x118);
		
		/// <summary>
		/// Name: ProgressionSystem
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public UBP_ProgressionSystem_C ProgressionSystem => ReadUObject<UBP_ProgressionSystem_C>(0x138);
		
		/// <summary>
		/// Name: CharacterMovement
		/// Type: ObjectProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public UCharacterMovementComponent CharacterMovement => ReadUObject<UCharacterMovementComponent>(0x140);
		
		/// <summary>
		/// Name: TimeFIDOSinceLast
		/// Type: FloatProperty
		/// Offset: 0x158
		/// Size: 0x04
		/// </summary>
		public float TimeFIDOSinceLast
		{
			get
			{
				return ReadSingle(0x158);
			}
			set
			{
				WriteSingle(0x158,value);
			}
		}
		
		/// <summary>
		/// Name: TimeFIFOCooldown
		/// Type: FloatProperty
		/// Offset: 0x15C
		/// Size: 0x04
		/// </summary>
		public float TimeFIFOCooldown
		{
			get
			{
				return ReadSingle(0x15C);
			}
			set
			{
				WriteSingle(0x15C,value);
			}
		}
		
		/// <summary>
		/// Name: CarryPeopleLimit
		/// Type: FloatProperty
		/// Offset: 0x160
		/// Size: 0x04
		/// </summary>
		public float CarryPeopleLimit
		{
			get
			{
				return ReadSingle(0x160);
			}
			set
			{
				WriteSingle(0x160,value);
			}
		}
		
		/// <summary>
		/// Name: OriginalMaxSwimSpeed
		/// Type: FloatProperty
		/// Offset: 0x164
		/// Size: 0x04
		/// </summary>
		public float OriginalMaxSwimSpeed
		{
			get
			{
				return ReadSingle(0x164);
			}
			set
			{
				WriteSingle(0x164,value);
			}
		}
		
		/// <summary>
		/// Name: OriginalMaxCrouchedWalkSpeed
		/// Type: FloatProperty
		/// Offset: 0x168
		/// Size: 0x04
		/// </summary>
		public float OriginalMaxCrouchedWalkSpeed
		{
			get
			{
				return ReadSingle(0x168);
			}
			set
			{
				WriteSingle(0x168,value);
			}
		}
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Inventory;
using ConanExilesGame.Game.Items;


namespace ConanExilesGame.Game.Items
{
	/// <summary>
	/// UBP_GameItemWeaponInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_GameItemWeaponInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBPGameItemWeapon_C:UBPGameItem_C
	/// Size: 0x381
	/// Properties: 8
	/// </summary>
	public class UBPGameItemWeapon_C:UBPGameItem_C
	{
		public override int ObjectSize => 897;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x360);
		
		/// <summary>
		/// Name: CurrentAttackType
		/// Type: ByteProperty
		/// Offset: 0x368
		/// Size: 0x01
		/// </summary>
		public byte CurrentAttackType
		{
			get
			{
				return ReadByte(0x368);
			}
			set
			{
				WriteByte(0x368,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponType
		/// Type: ByteProperty
		/// Offset: 0x369
		/// Size: 0x01
		/// </summary>
		public byte WeaponType
		{
			get
			{
				return ReadByte(0x369);
			}
			set
			{
				WriteByte(0x369,value);
			}
		}
		
		/// <summary>
		/// Name: BuffStackMax
		/// Type: IntProperty
		/// Offset: 0x36C
		/// Size: 0x04
		/// </summary>
		public int BuffStackMax
		{
			get
			{
				return ReadInt32(0x36C);
			}
			set
			{
				WriteInt32(0x36C,value);
			}
		}
		
		/// <summary>
		/// Name: BuffStackCurrent
		/// Type: IntProperty
		/// Offset: 0x370
		/// Size: 0x04
		/// </summary>
		public int BuffStackCurrent
		{
			get
			{
				return ReadInt32(0x370);
			}
			set
			{
				WriteInt32(0x370,value);
			}
		}
		
		/// <summary>
		/// Name: BuffPotency
		/// Type: IntProperty
		/// Offset: 0x374
		/// Size: 0x04
		/// </summary>
		public int BuffPotency
		{
			get
			{
				return ReadInt32(0x374);
			}
			set
			{
				WriteInt32(0x374,value);
			}
		}
		
		/// <summary>
		/// Name: BuffClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CanApplyBuff
		/// Type: BoolProperty
		/// Offset: 0x380
		/// Size: 0x01
		/// </summary>
		public bool CanApplyBuff
		{
			get
			{
				return ReadBool(0x380);
			}
			set
			{
				WriteBool(0x380,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_ProjectileWeapon_C:UBPGameItemWeapon_C
	/// Size: 0x3BC
	/// Properties: 4
	/// </summary>
	public class UBP_ProjectileWeapon_C:UBPGameItemWeapon_C
	{
		public override int ObjectSize => 956;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x388);
		
		/// <summary>
		/// Name: ProjectileActorClass
		/// Type: AssetClassProperty
		/// Offset: 0x390
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: ProjectileWeaponGravityCurve
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ProjectileWeaponGravityCurve => ReadUObject<UCurveFloat>(0x3B0);
		
		/// <summary>
		/// Name: ProjectileInitialVelocityModifier
		/// Type: FloatProperty
		/// Offset: 0x3B8
		/// Size: 0x04
		/// </summary>
		public float ProjectileInitialVelocityModifier
		{
			get
			{
				return ReadSingle(0x3B8);
			}
			set
			{
				WriteSingle(0x3B8,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_ProjectileWeaponInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_ProjectileWeaponInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_ProjectileWeaponThrown_C:UBP_ProjectileWeapon_C
	/// Size: 0x3BE
	/// Properties: 2
	/// </summary>
	public class UBP_ProjectileWeaponThrown_C:UBP_ProjectileWeapon_C
	{
		public override int ObjectSize => 958;
		/// <summary>
		/// Name: DeleteAfterThrow
		/// Type: BoolProperty
		/// Offset: 0x3BC
		/// Size: 0x01
		/// </summary>
		public bool DeleteAfterThrow
		{
			get
			{
				return ReadBool(0x3BC);
			}
			set
			{
				WriteBool(0x3BC,value);
			}
		}
		
		/// <summary>
		/// Name: HasFinishedWeaponAttack
		/// Type: BoolProperty
		/// Offset: 0x3BD
		/// Size: 0x01
		/// </summary>
		public bool HasFinishedWeaponAttack
		{
			get
			{
				return ReadBool(0x3BD);
			}
			set
			{
				WriteBool(0x3BD,value);
			}
		}
		
	}


	/// <summary>
	/// UBPI_ProjectileWeaponThrown_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBPI_ProjectileWeaponThrown_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBPGameItemArmor_C:UBPGameItem_C
	/// Size: 0x370
	/// Properties: 3
	/// </summary>
	public class UBPGameItemArmor_C:UBPGameItem_C
	{
		public override int ObjectSize => 880;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x360);
		
		/// <summary>
		/// Name: Slot
		/// Type: ByteProperty
		/// Offset: 0x368
		/// Size: 0x01
		/// </summary>
		public byte Slot
		{
			get
			{
				return ReadByte(0x368);
			}
			set
			{
				WriteByte(0x368,value);
			}
		}
		
		/// <summary>
		/// Name: Key
		/// Type: IntProperty
		/// Offset: 0x36C
		/// Size: 0x04
		/// </summary>
		public int Key
		{
			get
			{
				return ReadInt32(0x36C);
			}
			set
			{
				WriteInt32(0x36C,value);
			}
		}
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.humans.animations.generic.Pickup
{
	/// <summary>
	/// FPickupAnimationMapperStruct:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FPickupAnimationMapperStruct:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: WeaponType_2_75F7775A4B204543AE43999A7BF48C2C
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte WeaponType_2_75F7775A4B204543AE43999A7BF48C2C
		{
			get
			{
				return ReadByte(0x00);
			}
			set
			{
				WriteByte(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: _1stPerson_5_977531B44EB6E3BAD51ED986C7021052
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public UAnimMontage _1stPerson_5_977531B44EB6E3BAD51ED986C7021052 => ReadUObject<UAnimMontage>(0x08);
		
		/// <summary>
		/// Name: _3rdPerson_7_DEE5B4DF4E039AE24EF216B267F3B43A
		/// Type: ObjectProperty
		/// Offset: 0x10
		/// Size: 0x08
		/// </summary>
		public UAnimMontage _3rdPerson_7_DEE5B4DF4E039AE24EF216B267F3B43A => ReadUObject<UAnimMontage>(0x10);
		
	}


}

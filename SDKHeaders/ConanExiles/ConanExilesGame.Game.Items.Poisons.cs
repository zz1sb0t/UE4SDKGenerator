using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Systems.Inventory;


namespace ConanExilesGame.Game.Items.Poisons
{
	/// <summary>
	/// UBP_GameItem_BasePoison_C:UBPGameItem_C
	/// Size: 0x378
	/// Properties: 4
	/// </summary>
	public class UBP_GameItem_BasePoison_C:UBPGameItem_C
	{
		public override int ObjectSize => 888;
		/// <summary>
		/// Name: BuffStackMax
		/// Type: IntProperty
		/// Offset: 0x360
		/// Size: 0x04
		/// </summary>
		public int BuffStackMax
		{
			get
			{
				return ReadInt32(0x360);
			}
			set
			{
				WriteInt32(0x360,value);
			}
		}
		
		/// <summary>
		/// Name: BuffStackCurrent
		/// Type: IntProperty
		/// Offset: 0x364
		/// Size: 0x04
		/// </summary>
		public int BuffStackCurrent
		{
			get
			{
				return ReadInt32(0x364);
			}
			set
			{
				WriteInt32(0x364,value);
			}
		}
		
		/// <summary>
		/// Name: BuffPotency
		/// Type: IntProperty
		/// Offset: 0x368
		/// Size: 0x04
		/// </summary>
		public int BuffPotency
		{
			get
			{
				return ReadInt32(0x368);
			}
			set
			{
				WriteInt32(0x368,value);
			}
		}
		
		/// <summary>
		/// Name: BuffClass
		/// Type: ClassProperty
		/// Offset: 0x370
		/// Size: 0x08
		/// </summary>
		
	}


}

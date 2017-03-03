using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;


namespace ConanExilesGame.Game.Systems.Spawning.SpawnInputs
{
	/// <summary>
	/// FNPCHumanSpawnEntry:
	/// Size: 0x28
	/// Properties: 9
	/// </summary>
	public class FNPCHumanSpawnEntry:MemoryObject
	{
		public override int ObjectSize => 40;
		/// <summary>
		/// Name: NPCType_17_A92728F642BFD6A47C0BF9BBC6499E8F
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte NPCType_17_A92728F642BFD6A47C0BF9BBC6499E8F
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
		/// Name: MaxCap_16_88F1C51A458682777DE049A54A44D624
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int MaxCap_16_88F1C51A458682777DE049A54A44D624
		{
			get
			{
				return ReadInt32(0x04);
			}
			set
			{
				WriteInt32(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentCount_18_A79DBDBB44390DED41438FB26CD6120B
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int CurrentCount_18_A79DBDBB44390DED41438FB26CD6120B
		{
			get
			{
				return ReadInt32(0x08);
			}
			set
			{
				WriteInt32(0x08,value);
			}
		}
		
		/// <summary>
		/// Name: Tribe_12_DE47E80749FF5E0FED6E3C8613986463
		/// Type: ByteProperty
		/// Offset: 0x0C
		/// Size: 0x01
		/// </summary>
		public byte Tribe_12_DE47E80749FF5E0FED6E3C8613986463
		{
			get
			{
				return ReadByte(0x0C);
			}
			set
			{
				WriteByte(0x0C,value);
			}
		}
		
		/// <summary>
		/// Name: DayNightSpawning_22_AF8063434B6B57B2F30441A21B18CBDA
		/// Type: BoolProperty
		/// Offset: 0x0D
		/// Size: 0x01
		/// </summary>
		public bool DayNightSpawning_22_AF8063434B6B57B2F30441A21B18CBDA
		{
			get
			{
				return ReadBool(0x0D);
			}
			set
			{
				WriteBool(0x0D,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnTime_25_BB54621B416DE3DC7538D28F77088C1A
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int SpawnTime_25_BB54621B416DE3DC7538D28F77088C1A
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: DespawnTime_26_413E990142FD42A85D8011A087565A72
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int DespawnTime_26_413E990142FD42A85D8011A087565A72
		{
			get
			{
				return ReadInt32(0x14);
			}
			set
			{
				WriteInt32(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnTable_30_55B76307407B46D88AE3C5A22F286391
		/// Type: NameProperty
		/// Offset: 0x18
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BehaviorParameters_33_B8BC05E6421A1A0E7C84B99316C4DBFA
		/// Type: ClassProperty
		/// Offset: 0x20
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// FNPCSpawnEntry:
	/// Size: 0x28
	/// Properties: 8
	/// </summary>
	public class FNPCSpawnEntry:MemoryObject
	{
		public override int ObjectSize => 40;
		/// <summary>
		/// Name: NPCType_2_A92728F642BFD6A47C0BF9BBC6499E8F
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte NPCType_2_A92728F642BFD6A47C0BF9BBC6499E8F
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
		/// Name: MaxCap_5_88F1C51A458682777DE049A54A44D624
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int MaxCap_5_88F1C51A458682777DE049A54A44D624
		{
			get
			{
				return ReadInt32(0x04);
			}
			set
			{
				WriteInt32(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentCount_8_A79DBDBB44390DED41438FB26CD6120B
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int CurrentCount_8_A79DBDBB44390DED41438FB26CD6120B
		{
			get
			{
				return ReadInt32(0x08);
			}
			set
			{
				WriteInt32(0x08,value);
			}
		}
		
		/// <summary>
		/// Name: DayNightSpawning_11_DD3F75BF44C8C041870F3C83A7A9EDBA
		/// Type: BoolProperty
		/// Offset: 0x0C
		/// Size: 0x01
		/// </summary>
		public bool DayNightSpawning_11_DD3F75BF44C8C041870F3C83A7A9EDBA
		{
			get
			{
				return ReadBool(0x0C);
			}
			set
			{
				WriteBool(0x0C,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnTime_14_7CEDB02943C6095588A42686CE3B3324
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int SpawnTime_14_7CEDB02943C6095588A42686CE3B3324
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: DespawnTime_17_241AD7FC478F78697909FBB56CEC6740
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int DespawnTime_17_241AD7FC478F78697909FBB56CEC6740
		{
			get
			{
				return ReadInt32(0x14);
			}
			set
			{
				WriteInt32(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnTable_21_9B6CF66C4B8E19679B24C5B47BA42F2E
		/// Type: NameProperty
		/// Offset: 0x18
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BehaviorParameters_25_1A1C7CA248E576DB5CF573A19CCE5F46
		/// Type: ClassProperty
		/// Offset: 0x20
		/// Size: 0x08
		/// </summary>
		
	}


}

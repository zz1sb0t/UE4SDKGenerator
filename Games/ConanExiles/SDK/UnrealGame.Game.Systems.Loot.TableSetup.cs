using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building.BuildingActorComponents;


namespace ConanExilesGame.Game.Systems.Loot.TableSetup
{
	/// <summary>
	/// FLootTable_Weight_Structure:
	/// Size: 0x14
	/// Properties: 2
	/// </summary>
	public class FLootTable_Weight_Structure:MemoryObject
	{
		public override int ObjectSize => 20;
		/// <summary>
		/// Name: Table_2_1BEB0F9A47D79913E6F6CBADBF587378
		/// Type: StructProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle Table_2_1BEB0F9A47D79913E6F6CBADBF587378 => ReadStruct<FDataTableRowHandle>(0x00);
		
		/// <summary>
		/// Name: Weight_6_231AF1E847BE5D214EFC8892B1803816
		/// Type: FloatProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public float Weight_6_231AF1E847BE5D214EFC8892B1803816
		{
			get
			{
				return ReadSingle(0x10);
			}
			set
			{
				WriteSingle(0x10,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_AC_LootSpawner_C:U00_BP_AC_Building_MasterActorComp_C
	/// Size: 0x148
	/// Properties: 16
	/// </summary>
	public class UBP_AC_LootSpawner_C:U00_BP_AC_Building_MasterActorComp_C
	{
		public override int ObjectSize => 328;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xE0);
		
		/// <summary>
		/// Name: Roll
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float Roll
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: ParsedRange
		/// Type: FloatProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public float ParsedRange
		{
			get
			{
				return ReadSingle(0xEC);
			}
			set
			{
				WriteSingle(0xEC,value);
			}
		}
		
		/// <summary>
		/// Name: ChosenLootTable
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle ChosenLootTable => ReadStruct<FDataTableRowHandle>(0xF0);
		
		/// <summary>
		/// Name: LootHasBeenSpawned
		/// Type: BoolProperty
		/// Offset: 0x100
		/// Size: 0x01
		/// </summary>
		public bool LootHasBeenSpawned
		{
			get
			{
				return ReadBool(0x100);
			}
			set
			{
				WriteBool(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: ShouldExpire
		/// Type: BoolProperty
		/// Offset: 0x101
		/// Size: 0x01
		/// </summary>
		public bool ShouldExpire
		{
			get
			{
				return ReadBool(0x101);
			}
			set
			{
				WriteBool(0x101,value);
			}
		}
		
		/// <summary>
		/// Name: ExpirationTime
		/// Type: FloatProperty
		/// Offset: 0x104
		/// Size: 0x04
		/// </summary>
		public float ExpirationTime
		{
			get
			{
				return ReadSingle(0x104);
			}
			set
			{
				WriteSingle(0x104,value);
			}
		}
		
		/// <summary>
		/// Name: ItemInventory
		/// Type: ObjectProperty
		/// Offset: 0x108
		/// Size: 0x08
		/// </summary>
		public UItemInventory ItemInventory => ReadUObject<UItemInventory>(0x108);
		
		/// <summary>
		/// Name: OwnerID
		/// Type: ObjectProperty
		/// Offset: 0x110
		/// Size: 0x08
		/// </summary>
		public UUniqueID OwnerID => ReadUObject<UUniqueID>(0x110);
		
		/// <summary>
		/// Name: IsPlayer
		/// Type: BoolProperty
		/// Offset: 0x118
		/// Size: 0x01
		/// </summary>
		public bool IsPlayer
		{
			get
			{
				return ReadBool(0x118);
			}
			set
			{
				WriteBool(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: LootTableFromSpawnTable
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle LootTableFromSpawnTable => ReadStruct<FDataTableRowHandle>(0x120);
		
		/// <summary>
		/// Name: IgnoreGuiOpeningLogic
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool IgnoreGuiOpeningLogic
		{
			get
			{
				return ReadBool(0x130);
			}
			set
			{
				WriteBool(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: ReplenishLoot
		/// Type: BoolProperty
		/// Offset: 0x131
		/// Size: 0x01
		/// </summary>
		public bool ReplenishLoot
		{
			get
			{
				return ReadBool(0x131);
			}
			set
			{
				WriteBool(0x131,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnLootTimeStamp
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public FDateTime SpawnLootTimeStamp => ReadStruct<FDateTime>(0x138);
		
		/// <summary>
		/// Name: ReplenishLootTimerInSeconds
		/// Type: IntProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public int ReplenishLootTimerInSeconds
		{
			get
			{
				return ReadInt32(0x140);
			}
			set
			{
				WriteInt32(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: Counter
		/// Type: IntProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public int Counter
		{
			get
			{
				return ReadInt32(0x144);
			}
			set
			{
				WriteInt32(0x144,value);
			}
		}
		
	}


}

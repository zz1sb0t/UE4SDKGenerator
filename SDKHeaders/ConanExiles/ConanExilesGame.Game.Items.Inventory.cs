using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Items.Inventory
{
	/// <summary>
	/// ABP_LootContainer_C:ALootContainer
	/// Size: 0x434
	/// Properties: 13
	/// </summary>
	public class ABP_LootContainer_C:ALootContainer
	{
		public override int ObjectSize => 1076;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
		/// <summary>
		/// Name: Sphere
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USphereComponent Sphere => ReadUObject<USphereComponent>(0x3F0);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3F8);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x400);
		
		/// <summary>
		/// Name: ItemInventory
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UItemInventory ItemInventory => ReadUObject<UItemInventory>(0x408);
		
		/// <summary>
		/// Name: GuiIsOpen
		/// Type: BoolProperty
		/// Offset: 0x410
		/// Size: 0x01
		/// </summary>
		public bool GuiIsOpen
		{
			get
			{
				return ReadBool(0x410);
			}
			set
			{
				WriteBool(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: PlayersInteractingWithChest
		/// Type: TArray<APlayerController>
		/// Offset: 0x418
		/// Size: 0x10
		/// SubElement Size: 0x6C8
		/// </summary>
		public TArray<APlayerController> PlayersInteractingWithChest => new TArray<APlayerController>(BaseAddress+0x418);
		
		/// <summary>
		/// Name: ShouldDespawn
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool ShouldDespawn
		{
			get
			{
				return ReadBool(0x428);
			}
			set
			{
				WriteBool(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: DespawnTimer
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float DespawnTimer
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: IsBeingInteractedWith
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool IsBeingInteractedWith
		{
			get
			{
				return ReadBool(0x430);
			}
			set
			{
				WriteBool(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: TimerExpired
		/// Type: BoolProperty
		/// Offset: 0x431
		/// Size: 0x01
		/// </summary>
		public bool TimerExpired
		{
			get
			{
				return ReadBool(0x431);
			}
			set
			{
				WriteBool(0x431,value);
			}
		}
		
		/// <summary>
		/// Name: HasTriedMerging
		/// Type: BoolProperty
		/// Offset: 0x432
		/// Size: 0x01
		/// </summary>
		public bool HasTriedMerging
		{
			get
			{
				return ReadBool(0x432);
			}
			set
			{
				WriteBool(0x432,value);
			}
		}
		
		/// <summary>
		/// Name: IsMasterLootbag
		/// Type: BoolProperty
		/// Offset: 0x433
		/// Size: 0x01
		/// </summary>
		public bool IsMasterLootbag
		{
			get
			{
				return ReadBool(0x433);
			}
			set
			{
				WriteBool(0x433,value);
			}
		}
		
	}


	/// <summary>
	/// AInventoryItem_C:AInventoryItemBase
	/// Size: 0x3F0
	/// Properties: 1
	/// </summary>
	public class AInventoryItem_C:AInventoryItemBase
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
	}


	/// <summary>
	/// UInventoryItemInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInventoryItemInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Systems.Camps;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building.BuildingActorComponents;
using ConanExilesGame.Game.Systems.Loot.TableSetup;
using ConanExilesGame.Game.Items.Inventory;
using ConanExilesGame.Game.Systems.Building.Placeables.LootChests;


namespace ConanExilesGame.Game.Systems.Building.Placeables.LootChests
{
	/// <summary>
	/// ABP_LootContainer_Chest_C:ABP_MasterCampPlaceable_C
	/// Size: 0x428
	/// Properties: 6
	/// </summary>
	public class ABP_LootContainer_Chest_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3F8);
		
		/// <summary>
		/// Name: BP_BAC_SpawnLootOnDestroyed
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UBP_BAC_SpawnLootOnDestroyed_C BP_BAC_SpawnLootOnDestroyed => ReadUObject<UBP_BAC_SpawnLootOnDestroyed_C>(0x400);
		
		/// <summary>
		/// Name: BP_BAC_Storage
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UBP_BAC_Storage_C BP_BAC_Storage => ReadUObject<UBP_BAC_Storage_C>(0x408);
		
		/// <summary>
		/// Name: BP_AC_LootSpawner
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UBP_AC_LootSpawner_C BP_AC_LootSpawner => ReadUObject<UBP_AC_LootSpawner_C>(0x410);
		
		/// <summary>
		/// Name: ItemInventoryReplicateToAll
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UItemInventoryReplicateToAll ItemInventoryReplicateToAll => ReadUObject<UItemInventoryReplicateToAll>(0x418);
		
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x420);
		
	}


	/// <summary>
	/// ABP_PL_LootBag_DestroyedContainer_C:ABP_LootContainer_C
	/// Size: 0x440
	/// Properties: 1
	/// </summary>
	public class ABP_PL_LootBag_DestroyedContainer_C:ABP_LootContainer_C
	{
		public override int ObjectSize => 1088;
		/// <summary>
		/// Name: BP_AC_LootSpawner
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UBP_AC_LootSpawner_C BP_AC_LootSpawner => ReadUObject<UBP_AC_LootSpawner_C>(0x438);
		
	}


	/// <summary>
	/// ABP_PL_LootChest_Exiles_T2_C:ABP_LootContainer_Chest_C
	/// Size: 0x428
	/// Properties: 0
	/// </summary>
	public class ABP_PL_LootChest_Exiles_T2_C:ABP_LootContainer_Chest_C
	{
		public override int ObjectSize => 1064;
	}


	/// <summary>
	/// ABP_PL_LootChest_Exiles_T1_C:ABP_LootContainer_Chest_C
	/// Size: 0x428
	/// Properties: 0
	/// </summary>
	public class ABP_PL_LootChest_Exiles_T1_C:ABP_LootContainer_Chest_C
	{
		public override int ObjectSize => 1064;
	}


	/// <summary>
	/// ABP_PL_LootChest_Darfari_T2_C:ABP_LootContainer_Chest_C
	/// Size: 0x428
	/// Properties: 0
	/// </summary>
	public class ABP_PL_LootChest_Darfari_T2_C:ABP_LootContainer_Chest_C
	{
		public override int ObjectSize => 1064;
	}


	/// <summary>
	/// ABP_PL_LootChest_Darfari_T1_C:ABP_LootContainer_Chest_C
	/// Size: 0x428
	/// Properties: 0
	/// </summary>
	public class ABP_PL_LootChest_Darfari_T1_C:ABP_LootContainer_Chest_C
	{
		public override int ObjectSize => 1064;
	}


}

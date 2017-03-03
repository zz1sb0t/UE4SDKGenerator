using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Loot.TableSetup;
using ConanExilesGame.Game.Systems.AI.Navigation;
using ConanExilesGame.Game.Systems.Spawning.SpawnInputs;
using ConanExilesGame.Game.Systems.Spawning.Humans;
using ConanExilesGame.Game.Systems.Spawning;


namespace ConanExilesGame.Game.Systems.Spawning
{
	/// <summary>
	/// FNPCList_Structure:
	/// Size: 0x48
	/// Properties: 5
	/// </summary>
	public class FNPCList_Structure:MemoryObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: npc_34_588C227040DB08254679EA96FB2B6AB7
		/// Type: ClassProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: behavior_tree_49_1E7F3963407E0067CFB1BD98A1B26920
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree behavior_tree_49_1E7F3963407E0067CFB1BD98A1B26920 => ReadUObject<UBehaviorTree>(0x08);
		
		/// <summary>
		/// Name: loottable_54_89440A274E3C89697A2B71A4B2779643
		/// Type: StructProperty
		/// Offset: 0x10
		/// Size: 0x18
		/// </summary>
		public FLootTable_Weight_Structure loottable_54_89440A274E3C89697A2B71A4B2779643 => ReadStruct<FLootTable_Weight_Structure>(0x10);
		
		/// <summary>
		/// Name: controller_60_A611BEA44E68F4081D632EA1007F5DE1
		/// Type: ClassProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Name_63_F6EC3AF84647F1AF0FB82CAC647DD814
		/// Type: TextProperty
		/// Offset: 0x30
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// ANPCTerritorySpawner_C:AActor
	/// Size: 0x578
	/// Properties: 52
	/// </summary>
	public class ANPCTerritorySpawner_C:AActor
	{
		public override int ObjectSize => 1400;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: TextRender
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UTextRenderComponent TextRender => ReadUObject<UTextRenderComponent>(0x3D8);
		
		/// <summary>
		/// Name: StaticNavigationGenerator
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UStaticNavigationGenerator_C StaticNavigationGenerator => ReadUObject<UStaticNavigationGenerator_C>(0x3E0);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x3E8);
		
		/// <summary>
		/// Name: SpawnVolume
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SpawnVolume => ReadUObject<UBoxComponent>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: TerritoryInitialSpawn
		/// Type: BoolProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public bool TerritoryInitialSpawn
		{
			get
			{
				return ReadBool(0x400);
			}
			set
			{
				WriteBool(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: TerritorySpawnVolume
		/// Type: NameProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: TerritoryHomeLocation
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0x0C
		/// </summary>
		public FVector TerritoryHomeLocation => ReadStruct<FVector>(0x410);
		
		/// <summary>
		/// Name: HomeLocation
		/// Type: NameProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: TerritorySuperRegion
		/// Type: ByteProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public byte TerritorySuperRegion
		{
			get
			{
				return ReadByte(0x428);
			}
			set
			{
				WriteByte(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: TerritorySubRegion
		/// Type: ByteProperty
		/// Offset: 0x429
		/// Size: 0x01
		/// </summary>
		public byte TerritorySubRegion
		{
			get
			{
				return ReadByte(0x429);
			}
			set
			{
				WriteByte(0x429,value);
			}
		}
		
		/// <summary>
		/// Name: NPCs
		/// Type: TArray<FNPCSpawnEntry>
		/// Offset: 0x430
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FNPCSpawnEntry> NPCs => new TArray<FNPCSpawnEntry>(BaseAddress+0x430);
		
		/// <summary>
		/// Name: HumanNPCs
		/// Type: TArray<FNPCHumanSpawnEntry>
		/// Offset: 0x440
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FNPCHumanSpawnEntry> HumanNPCs => new TArray<FNPCHumanSpawnEntry>(BaseAddress+0x440);
		
		/// <summary>
		/// Name: CurrentNPCIndex
		/// Type: IntProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public int CurrentNPCIndex
		{
			get
			{
				return ReadInt32(0x450);
			}
			set
			{
				WriteInt32(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: RoamRadius
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float RoamRadius
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: TerritorySpawnVolumeRadius
		/// Type: NameProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Color
		/// Type: ByteProperty
		/// Offset: 0x460
		/// Size: 0x01
		/// </summary>
		public byte Color
		{
			get
			{
				return ReadByte(0x460);
			}
			set
			{
				WriteByte(0x460,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentHumanNPCIndex
		/// Type: IntProperty
		/// Offset: 0x464
		/// Size: 0x04
		/// </summary>
		public int CurrentHumanNPCIndex
		{
			get
			{
				return ReadInt32(0x464);
			}
			set
			{
				WriteInt32(0x464,value);
			}
		}
		
		/// <summary>
		/// Name: HumanNPCVisuals
		/// Type: TArray<FNPC_Human_Visuals_Structure>
		/// Offset: 0x468
		/// Size: 0x10
		/// SubElement Size: 0x3C
		/// </summary>
		public TArray<FNPC_Human_Visuals_Structure> HumanNPCVisuals => new TArray<FNPC_Human_Visuals_Structure>(BaseAddress+0x468);
		
		/// <summary>
		/// Name: TempNPCCreationArray
		/// Type: TArray<>
		/// Offset: 0x478
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: Hair
		/// Type: IntProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public int Hair
		{
			get
			{
				return ReadInt32(0x488);
			}
			set
			{
				WriteInt32(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: Head
		/// Type: IntProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public int Head
		{
			get
			{
				return ReadInt32(0x48C);
			}
			set
			{
				WriteInt32(0x48C,value);
			}
		}
		
		/// <summary>
		/// Name: Feet
		/// Type: IntProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public int Feet
		{
			get
			{
				return ReadInt32(0x490);
			}
			set
			{
				WriteInt32(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: lowerBody
		/// Type: IntProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public int lowerBody
		{
			get
			{
				return ReadInt32(0x494);
			}
			set
			{
				WriteInt32(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: UpperBody
		/// Type: IntProperty
		/// Offset: 0x498
		/// Size: 0x04
		/// </summary>
		public int UpperBody
		{
			get
			{
				return ReadInt32(0x498);
			}
			set
			{
				WriteInt32(0x498,value);
			}
		}
		
		/// <summary>
		/// Name: Helmet
		/// Type: IntProperty
		/// Offset: 0x49C
		/// Size: 0x04
		/// </summary>
		public int Helmet
		{
			get
			{
				return ReadInt32(0x49C);
			}
			set
			{
				WriteInt32(0x49C,value);
			}
		}
		
		/// <summary>
		/// Name: SkinColor
		/// Type: StructProperty
		/// Offset: 0x4A0
		/// Size: 0x10
		/// </summary>
		public FLinearColor SkinColor => ReadStruct<FLinearColor>(0x4A0);
		
		/// <summary>
		/// Name: Hands
		/// Type: IntProperty
		/// Offset: 0x4B0
		/// Size: 0x04
		/// </summary>
		public int Hands
		{
			get
			{
				return ReadInt32(0x4B0);
			}
			set
			{
				WriteInt32(0x4B0,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnTotalCount
		/// Type: IntProperty
		/// Offset: 0x4B4
		/// Size: 0x04
		/// </summary>
		public int SpawnTotalCount
		{
			get
			{
				return ReadInt32(0x4B4);
			}
			set
			{
				WriteInt32(0x4B4,value);
			}
		}
		
		/// <summary>
		/// Name: HumanTribeItemDataList
		/// Type: BoolProperty
		/// Offset: 0x4B8
		/// Size: 0x01
		/// </summary>
		public bool HumanTribeItemDataList
		{
			get
			{
				return ReadBool(0x4B8);
			}
			set
			{
				WriteBool(0x4B8,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnUnderneathRoof
		/// Type: BoolProperty
		/// Offset: 0x4B9
		/// Size: 0x01
		/// </summary>
		public bool SpawnUnderneathRoof
		{
			get
			{
				return ReadBool(0x4B9);
			}
			set
			{
				WriteBool(0x4B9,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnPointsPerNPCSlot
		/// Type: FloatProperty
		/// Offset: 0x4BC
		/// Size: 0x04
		/// </summary>
		public float SpawnPointsPerNPCSlot
		{
			get
			{
				return ReadSingle(0x4BC);
			}
			set
			{
				WriteSingle(0x4BC,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathsSampled
		/// Type: IntProperty
		/// Offset: 0x4C0
		/// Size: 0x04
		/// </summary>
		public int RoamingPathsSampled
		{
			get
			{
				return ReadInt32(0x4C0);
			}
			set
			{
				WriteInt32(0x4C0,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathsTargetCount
		/// Type: IntProperty
		/// Offset: 0x4C4
		/// Size: 0x04
		/// </summary>
		public int RoamingPathsTargetCount
		{
			get
			{
				return ReadInt32(0x4C4);
			}
			set
			{
				WriteInt32(0x4C4,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathsPerNPCSlot
		/// Type: FloatProperty
		/// Offset: 0x4C8
		/// Size: 0x04
		/// </summary>
		public float RoamingPathsPerNPCSlot
		{
			get
			{
				return ReadSingle(0x4C8);
			}
			set
			{
				WriteSingle(0x4C8,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnPointAndRoamingPathFilter
		/// Type: ClassProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: StaticNavigationOverride
		/// Type: InterfaceProperty
		/// Offset: 0x4D8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: CachedStaticOverridePaths
		/// Type: TArray<UPathPoints>
		/// Offset: 0x4E8
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UPathPoints> CachedStaticOverridePaths => new TArray<UPathPoints>(BaseAddress+0x4E8);
		
		/// <summary>
		/// Name: StaticOverridePathIndex
		/// Type: IntProperty
		/// Offset: 0x4F8
		/// Size: 0x04
		/// </summary>
		public int StaticOverridePathIndex
		{
			get
			{
				return ReadInt32(0x4F8);
			}
			set
			{
				WriteInt32(0x4F8,value);
			}
		}
		
		/// <summary>
		/// Name: Camp
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public AActor Camp => ReadUObject<AActor>(0x500);
		
		/// <summary>
		/// Name: StaticOverrideSpawnPointIndex
		/// Type: IntProperty
		/// Offset: 0x508
		/// Size: 0x04
		/// </summary>
		public int StaticOverrideSpawnPointIndex
		{
			get
			{
				return ReadInt32(0x508);
			}
			set
			{
				WriteInt32(0x508,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentSpawnSourceType
		/// Type: ByteProperty
		/// Offset: 0x50C
		/// Size: 0x01
		/// </summary>
		public byte CurrentSpawnSourceType
		{
			get
			{
				return ReadByte(0x50C);
			}
			set
			{
				WriteByte(0x50C,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentStaticSpawnPoint
		/// Type: ObjectProperty
		/// Offset: 0x510
		/// Size: 0x08
		/// </summary>
		public AStaticSpawnPoint CurrentStaticSpawnPoint => ReadUObject<AStaticSpawnPoint>(0x510);
		
		/// <summary>
		/// Name: SpawnTries
		/// Type: IntProperty
		/// Offset: 0x518
		/// Size: 0x04
		/// </summary>
		public int SpawnTries
		{
			get
			{
				return ReadInt32(0x518);
			}
			set
			{
				WriteInt32(0x518,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnFromTriggerEvent
		/// Type: BoolProperty
		/// Offset: 0x51C
		/// Size: 0x01
		/// </summary>
		public bool SpawnFromTriggerEvent
		{
			get
			{
				return ReadBool(0x51C);
			}
			set
			{
				WriteBool(0x51C,value);
			}
		}
		
		/// <summary>
		/// Name: ConstructShowSpawnCount
		/// Type: TArray<>
		/// Offset: 0x520
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ConstructShowOnMap
		/// Type: BoolProperty
		/// Offset: 0x530
		/// Size: 0x01
		/// </summary>
		public bool ConstructShowOnMap
		{
			get
			{
				return ReadBool(0x530);
			}
			set
			{
				WriteBool(0x530,value);
			}
		}
		
		/// <summary>
		/// Name: ConstructShowpawnName
		/// Type: TArray<>
		/// Offset: 0x538
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ConstructShowSpawnText
		/// Type: TextProperty
		/// Offset: 0x548
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ConstructTempCounter
		/// Type: IntProperty
		/// Offset: 0x560
		/// Size: 0x04
		/// </summary>
		public int ConstructTempCounter
		{
			get
			{
				return ReadInt32(0x560);
			}
			set
			{
				WriteInt32(0x560,value);
			}
		}
		
		/// <summary>
		/// Name: ConstructText
		/// Type: StrProperty
		/// Offset: 0x568
		/// Size: 0x10
		/// </summary>
		public FString ConstructText => new FString(BaseAddress+0x568);
		
	}


	/// <summary>
	/// ABP_NPC_TriggerSpawn_C:AActor
	/// Size: 0x45C
	/// Properties: 16
	/// </summary>
	public class ABP_NPC_TriggerSpawn_C:AActor
	{
		public override int ObjectSize => 1116;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x3D8);
		
		/// <summary>
		/// Name: DebugVisualObject
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent DebugVisualObject => ReadUObject<UStaticMeshComponent>(0x3E0);
		
		/// <summary>
		/// Name: TextRender2
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UTextRenderComponent TextRender2 => ReadUObject<UTextRenderComponent>(0x3E8);
		
		/// <summary>
		/// Name: TextRender
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UTextRenderComponent TextRender => ReadUObject<UTextRenderComponent>(0x3F0);
		
		/// <summary>
		/// Name: TriggerBox
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent TriggerBox => ReadUObject<UBoxComponent>(0x3F8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x400);
		
		/// <summary>
		/// Name: TriggeredTerritories
		/// Type: TArray<ANPCTerritorySpawner_C>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x578
		/// </summary>
		public TArray<ANPCTerritorySpawner_C> TriggeredTerritories => new TArray<ANPCTerritorySpawner_C>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: TempCounter
		/// Type: IntProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public int TempCounter
		{
			get
			{
				return ReadInt32(0x418);
			}
			set
			{
				WriteInt32(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: IsInteractionTrigger
		/// Type: BoolProperty
		/// Offset: 0x41C
		/// Size: 0x01
		/// </summary>
		public bool IsInteractionTrigger
		{
			get
			{
				return ReadBool(0x41C);
			}
			set
			{
				WriteBool(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: NPCTerritorySpawner
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public ANPCTerritorySpawner_C NPCTerritorySpawner => ReadUObject<ANPCTerritorySpawner_C>(0x420);
		
		/// <summary>
		/// Name: TextToShow
		/// Type: TextProperty
		/// Offset: 0x428
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextScale
		/// Type: FloatProperty
		/// Offset: 0x440
		/// Size: 0x04
		/// </summary>
		public float TextScale
		{
			get
			{
				return ReadSingle(0x440);
			}
			set
			{
				WriteSingle(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: TextColor
		/// Type: StructProperty
		/// Offset: 0x444
		/// Size: 0x10
		/// </summary>
		public FLinearColor TextColor => ReadStruct<FLinearColor>(0x444);
		
		/// <summary>
		/// Name: OnCooldown
		/// Type: BoolProperty
		/// Offset: 0x454
		/// Size: 0x01
		/// </summary>
		public bool OnCooldown
		{
			get
			{
				return ReadBool(0x454);
			}
			set
			{
				WriteBool(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: Cooldown
		/// Type: FloatProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public float Cooldown
		{
			get
			{
				return ReadSingle(0x458);
			}
			set
			{
				WriteSingle(0x458,value);
			}
		}
		
	}


}

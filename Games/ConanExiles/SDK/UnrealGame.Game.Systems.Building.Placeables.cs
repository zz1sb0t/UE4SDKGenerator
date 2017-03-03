using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building;
using ConanExilesGame.Game.Systems.Building.Placeables;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Systems.Building.BuildingActorComponents;


namespace ConanExilesGame.Game.Systems.Building.Placeables
{
	/// <summary>
	/// ABP_Master_Placeables_C:APlaceableBase
	/// Size: 0x6F8
	/// Properties: 44
	/// </summary>
	public class ABP_Master_Placeables_C:APlaceableBase
	{
		public override int ObjectSize => 1784;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4D8);
		
		/// <summary>
		/// Name: DirectionIndicator
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public UArrowComponent DirectionIndicator => ReadUObject<UArrowComponent>(0x4E0);
		
		/// <summary>
		/// Name: OverlappingBuildingBlockerBoxCheck
		/// Type: ObjectProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent OverlappingBuildingBlockerBoxCheck => ReadUObject<UBoxComponent>(0x4E8);
		
		/// <summary>
		/// Name: ConanBuildingPersistence
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public UConanBuildingPersistenceComponent ConanBuildingPersistence => ReadUObject<UConanBuildingPersistenceComponent>(0x4F0);
		
		/// <summary>
		/// Name: ExclusivePlacementSphere
		/// Type: ObjectProperty
		/// Offset: 0x4F8
		/// Size: 0x08
		/// </summary>
		public USphereComponent ExclusivePlacementSphere => ReadUObject<USphereComponent>(0x4F8);
		
		/// <summary>
		/// Name: AILOD
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public UAILODComponent AILOD => ReadUObject<UAILODComponent>(0x500);
		
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x508
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x508);
		
		/// <summary>
		/// Name: CheckForContactBox
		/// Type: ObjectProperty
		/// Offset: 0x510
		/// Size: 0x08
		/// </summary>
		public UBoxComponent CheckForContactBox => ReadUObject<UBoxComponent>(0x510);
		
		/// <summary>
		/// Name: CheckCornersBox
		/// Type: ObjectProperty
		/// Offset: 0x518
		/// Size: 0x08
		/// </summary>
		public UBoxComponent CheckCornersBox => ReadUObject<UBoxComponent>(0x518);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x520
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x520);
		
		/// <summary>
		/// Name: PlacementCheckBox
		/// Type: ObjectProperty
		/// Offset: 0x528
		/// Size: 0x08
		/// </summary>
		public UBoxComponent PlacementCheckBox => ReadUObject<UBoxComponent>(0x528);
		
		/// <summary>
		/// Name: CanBeRotated
		/// Type: BoolProperty
		/// Offset: 0x530
		/// Size: 0x01
		/// </summary>
		public bool CanBeRotated
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
		/// Name: CanBeHeightAdjusted
		/// Type: BoolProperty
		/// Offset: 0x531
		/// Size: 0x01
		/// </summary>
		public bool CanBeHeightAdjusted
		{
			get
			{
				return ReadBool(0x531);
			}
			set
			{
				WriteBool(0x531,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeTilted
		/// Type: BoolProperty
		/// Offset: 0x532
		/// Size: 0x01
		/// </summary>
		public bool CanBeTilted
		{
			get
			{
				return ReadBool(0x532);
			}
			set
			{
				WriteBool(0x532,value);
			}
		}
		
		/// <summary>
		/// Name: PlaceableCornerTraceResults
		/// Type: TArray<>
		/// Offset: 0x538
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: PlacementCheckBoxExtent
		/// Type: StructProperty
		/// Offset: 0x548
		/// Size: 0x0C
		/// </summary>
		public FVector PlacementCheckBoxExtent => ReadStruct<FVector>(0x548);
		
		/// <summary>
		/// Name: IsInBuildingMode
		/// Type: BoolProperty
		/// Offset: 0x554
		/// Size: 0x01
		/// </summary>
		public bool IsInBuildingMode
		{
			get
			{
				return ReadBool(0x554);
			}
			set
			{
				WriteBool(0x554,value);
			}
		}
		
		/// <summary>
		/// Name: PlaceOnWall
		/// Type: BoolProperty
		/// Offset: 0x555
		/// Size: 0x01
		/// </summary>
		public bool PlaceOnWall
		{
			get
			{
				return ReadBool(0x555);
			}
			set
			{
				WriteBool(0x555,value);
			}
		}
		
		/// <summary>
		/// Name: PlacementImpactNormalRotation
		/// Type: StructProperty
		/// Offset: 0x558
		/// Size: 0x0C
		/// </summary>
		public FRotator PlacementImpactNormalRotation => ReadStruct<FRotator>(0x558);
		
		/// <summary>
		/// Name: GetCornerPositionLengthMod
		/// Type: FloatProperty
		/// Offset: 0x564
		/// Size: 0x04
		/// </summary>
		public float GetCornerPositionLengthMod
		{
			get
			{
				return ReadSingle(0x564);
			}
			set
			{
				WriteSingle(0x564,value);
			}
		}
		
		/// <summary>
		/// Name: GetCornerPositionVerticalLengthMod
		/// Type: FloatProperty
		/// Offset: 0x568
		/// Size: 0x04
		/// </summary>
		public float GetCornerPositionVerticalLengthMod
		{
			get
			{
				return ReadSingle(0x568);
			}
			set
			{
				WriteSingle(0x568,value);
			}
		}
		
		/// <summary>
		/// Name: HasBeenPlacedInWorld
		/// Type: BoolProperty
		/// Offset: 0x56C
		/// Size: 0x01
		/// </summary>
		public bool HasBeenPlacedInWorld
		{
			get
			{
				return ReadBool(0x56C);
			}
			set
			{
				WriteBool(0x56C,value);
			}
		}
		
		/// <summary>
		/// Name: TooSteepCornerAngleTraceResult
		/// Type: TArray<>
		/// Offset: 0x570
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: MaxTiltAngle
		/// Type: FloatProperty
		/// Offset: 0x580
		/// Size: 0x04
		/// </summary>
		public float MaxTiltAngle
		{
			get
			{
				return ReadSingle(0x580);
			}
			set
			{
				WriteSingle(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: ActiveBuildSystem
		/// Type: ObjectProperty
		/// Offset: 0x588
		/// Size: 0x08
		/// </summary>
		public UBP_BuildSystem_v2_C ActiveBuildSystem => ReadUObject<UBP_BuildSystem_v2_C>(0x588);
		
		/// <summary>
		/// Name: MustSnapToSocket
		/// Type: BoolProperty
		/// Offset: 0x590
		/// Size: 0x01
		/// </summary>
		public bool MustSnapToSocket
		{
			get
			{
				return ReadBool(0x590);
			}
			set
			{
				WriteBool(0x590,value);
			}
		}
		
		/// <summary>
		/// Name: isExclusive
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool isExclusive
		{
			get
			{
				return ReadBool(0x5D8);
			}
			set
			{
				WriteBool(0x5D8,value);
			}
		}
		
		/// <summary>
		/// Name: ExclusiveOverlapList
		/// Type: TArray<>
		/// Offset: 0x5E0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: IsNPCPlaceable
		/// Type: BoolProperty
		/// Offset: 0x5F0
		/// Size: 0x01
		/// </summary>
		public bool IsNPCPlaceable
		{
			get
			{
				return ReadBool(0x5F0);
			}
			set
			{
				WriteBool(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: OverlapBuildingBoxChecker
		/// Type: ObjectProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent OverlapBuildingBoxChecker => ReadUObject<UBoxComponent>(0x5F8);
		
		/// <summary>
		/// Name: Error_OverlappingWithExclusive
		/// Type: TextProperty
		/// Offset: 0x600
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_Overlapping
		/// Type: TextProperty
		/// Offset: 0x618
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_RequiresSocket
		/// Type: TextProperty
		/// Offset: 0x630
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_SurfaceNotVerticalEnough
		/// Type: TextProperty
		/// Offset: 0x648
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_NotBuilding
		/// Type: TextProperty
		/// Offset: 0x660
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_CornerFailWall
		/// Type: TextProperty
		/// Offset: 0x678
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_CheckForGroundFail
		/// Type: TextProperty
		/// Offset: 0x690
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_GroundTooSteep
		/// Type: TextProperty
		/// Offset: 0x6A8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ShowDirectionArrow
		/// Type: BoolProperty
		/// Offset: 0x6C0
		/// Size: 0x01
		/// </summary>
		public bool ShowDirectionArrow
		{
			get
			{
				return ReadBool(0x6C0);
			}
			set
			{
				WriteBool(0x6C0,value);
			}
		}
		
		/// <summary>
		/// Name: BuildModeRotationOffset
		/// Type: StructProperty
		/// Offset: 0x6C4
		/// Size: 0x0C
		/// </summary>
		public FRotator BuildModeRotationOffset => ReadStruct<FRotator>(0x6C4);
		
		/// <summary>
		/// Name: PlacementOffsetVector
		/// Type: StructProperty
		/// Offset: 0x6D0
		/// Size: 0x0C
		/// </summary>
		public FVector PlacementOffsetVector => ReadStruct<FVector>(0x6D0);
		
		/// <summary>
		/// Name: CanBeDismantled
		/// Type: BoolProperty
		/// Offset: 0x6DC
		/// Size: 0x01
		/// </summary>
		public bool CanBeDismantled
		{
			get
			{
				return ReadBool(0x6DC);
			}
			set
			{
				WriteBool(0x6DC,value);
			}
		}
		
		/// <summary>
		/// Name: CanStackOnTopOfSelf
		/// Type: BoolProperty
		/// Offset: 0x6DD
		/// Size: 0x01
		/// </summary>
		public bool CanStackOnTopOfSelf
		{
			get
			{
				return ReadBool(0x6DD);
			}
			set
			{
				WriteBool(0x6DD,value);
			}
		}
		
		/// <summary>
		/// Name: Error_CannotBeStacked
		/// Type: TextProperty
		/// Offset: 0x6E0
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// ABP_PL_Altar_Yog_T3_C:ABP_PL_Altar_Yog_C
	/// Size: 0x790
	/// Properties: 0
	/// </summary>
	public class ABP_PL_Altar_Yog_T3_C:ABP_PL_Altar_Yog_C
	{
		public override int ObjectSize => 1936;
	}


	/// <summary>
	/// ABP_PL_Altar_Yog_T2_C:ABP_PL_Altar_Yog_C
	/// Size: 0x790
	/// Properties: 0
	/// </summary>
	public class ABP_PL_Altar_Yog_T2_C:ABP_PL_Altar_Yog_C
	{
		public override int ObjectSize => 1936;
	}


	/// <summary>
	/// ABP_PL_Altar_Yog_C:ABP_PL_Altar_C
	/// Size: 0x790
	/// Properties: 7
	/// </summary>
	public class ABP_PL_Altar_Yog_C:ABP_PL_Altar_C
	{
		public override int ObjectSize => 1936;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x758
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x758);
		
		/// <summary>
		/// Name: PointLight2
		/// Type: ObjectProperty
		/// Offset: 0x760
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight2 => ReadUObject<UPointLightComponent>(0x760);
		
		/// <summary>
		/// Name: ParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x768
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystem => ReadUObject<UParticleSystemComponent>(0x768);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x770
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x770);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x778
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x778);
		
		/// <summary>
		/// Name: ThrallInventory
		/// Type: ObjectProperty
		/// Offset: 0x780
		/// Size: 0x08
		/// </summary>
		public UItemInventoryReplicateToAll ThrallInventory => ReadUObject<UItemInventoryReplicateToAll>(0x780);
		
		/// <summary>
		/// Name: AltarMesh
		/// Type: ObjectProperty
		/// Offset: 0x788
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent AltarMesh => ReadUObject<UStaticMeshComponent>(0x788);
		
	}


	/// <summary>
	/// ABP_PL_Altar_C:ABP_PL_Crafting_Station_C
	/// Size: 0x758
	/// Properties: 3
	/// </summary>
	public class ABP_PL_Altar_C:ABP_PL_Crafting_Station_C
	{
		public override int ObjectSize => 1880;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x748
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x748);
		
		/// <summary>
		/// Name: God
		/// Type: ByteProperty
		/// Offset: 0x750
		/// Size: 0x01
		/// </summary>
		public byte God
		{
			get
			{
				return ReadByte(0x750);
			}
			set
			{
				WriteByte(0x750,value);
			}
		}
		
		/// <summary>
		/// Name: Tribute
		/// Type: FloatProperty
		/// Offset: 0x754
		/// Size: 0x04
		/// </summary>
		public float Tribute
		{
			get
			{
				return ReadSingle(0x754);
			}
			set
			{
				WriteSingle(0x754,value);
			}
		}
		
	}


	/// <summary>
	/// ABP_PL_Crafting_Station_C:ABP_PlaceableItemContainer_C
	/// Size: 0x748
	/// Properties: 8
	/// </summary>
	public class ABP_PL_Crafting_Station_C:ABP_PlaceableItemContainer_C
	{
		public override int ObjectSize => 1864;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x708
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x708);
		
		/// <summary>
		/// Name: BP_CharacterCustomizationComponent
		/// Type: ObjectProperty
		/// Offset: 0x710
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterCustomizationComponent_C BP_CharacterCustomizationComponent => ReadUObject<UBP_CharacterCustomizationComponent_C>(0x710);
		
		/// <summary>
		/// Name: ThrallWorker
		/// Type: ObjectProperty
		/// Offset: 0x718
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent ThrallWorker => ReadUObject<USkeletalMeshComponent>(0x718);
		
		/// <summary>
		/// Name: ArtisanRecipeInventory
		/// Type: ObjectProperty
		/// Offset: 0x720
		/// Size: 0x08
		/// </summary>
		public UItemInventoryReplicateToAll ArtisanRecipeInventory => ReadUObject<UItemInventoryReplicateToAll>(0x720);
		
		/// <summary>
		/// Name: CraftingQueue
		/// Type: ObjectProperty
		/// Offset: 0x728
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue CraftingQueue => ReadUObject<UCraftingQueue>(0x728);
		
		/// <summary>
		/// Name: BP_BAC_CraftingStation
		/// Type: ObjectProperty
		/// Offset: 0x730
		/// Size: 0x08
		/// </summary>
		public UBP_BAC_CraftingStation_C BP_BAC_CraftingStation => ReadUObject<UBP_BAC_CraftingStation_C>(0x730);
		
		/// <summary>
		/// Name: IsOpen
		/// Type: BoolProperty
		/// Offset: 0x738
		/// Size: 0x01
		/// </summary>
		public bool IsOpen
		{
			get
			{
				return ReadBool(0x738);
			}
			set
			{
				WriteBool(0x738,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentArtisanThrallItem
		/// Type: ObjectProperty
		/// Offset: 0x740
		/// Size: 0x08
		/// </summary>
		public UThrallItem CurrentArtisanThrallItem => ReadUObject<UThrallItem>(0x740);
		
	}


	/// <summary>
	/// ABP_PlaceableItemContainer_C:ABP_Master_Placeables_C
	/// Size: 0x708
	/// Properties: 2
	/// </summary>
	public class ABP_PlaceableItemContainer_C:ABP_Master_Placeables_C
	{
		public override int ObjectSize => 1800;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x6F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x6F8);
		
		/// <summary>
		/// Name: PlaceableInventory
		/// Type: ObjectProperty
		/// Offset: 0x700
		/// Size: 0x08
		/// </summary>
		public UItemInventoryReplicateToAll PlaceableInventory => ReadUObject<UItemInventoryReplicateToAll>(0x700);
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building;
using ConanExilesGame.Game.UI.Building;
using ConanExilesGame.Game.Systems.Building.Placeables;


namespace ConanExilesGame.Game.Systems.Building
{
	/// <summary>
	/// ABuildingBlockerVolume_C:AActor
	/// Size: 0x410
	/// Properties: 5
	/// </summary>
	public class ABuildingBlockerVolume_C:AActor
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: BoxExtent
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x0C
		/// </summary>
		public FVector BoxExtent => ReadStruct<FVector>(0x3E8);
		
		/// <summary>
		/// Name: MessageToPlayer
		/// Type: TextProperty
		/// Offset: 0x3F8
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UBP_BuildSystem_v2_C:UBuildSystemComponent
	/// Size: 0x2B0
	/// Properties: 30
	/// </summary>
	public class UBP_BuildSystem_v2_C:UBuildSystemComponent
	{
		public override int ObjectSize => 688;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1A0);
		
		/// <summary>
		/// Name: BuildingBrushStructure
		/// Type: ObjectProperty
		/// Offset: 0x1A8
		/// Size: 0x08
		/// </summary>
		public ABP_BuildingBase_C BuildingBrushStructure => ReadUObject<ABP_BuildingBase_C>(0x1A8);
		
		/// <summary>
		/// Name: BuildRange
		/// Type: FloatProperty
		/// Offset: 0x1B0
		/// Size: 0x04
		/// </summary>
		public float BuildRange
		{
			get
			{
				return ReadSingle(0x1B0);
			}
			set
			{
				WriteSingle(0x1B0,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentBuildingTarget
		/// Type: ObjectProperty
		/// Offset: 0x1B8
		/// Size: 0x08
		/// </summary>
		public ABP_BuildingBase_C CurrentBuildingTarget => ReadUObject<ABP_BuildingBase_C>(0x1B8);
		
		/// <summary>
		/// Name: PrevBuildingTarget
		/// Type: ObjectProperty
		/// Offset: 0x1C0
		/// Size: 0x08
		/// </summary>
		public ABP_BuildingBase_C PrevBuildingTarget => ReadUObject<ABP_BuildingBase_C>(0x1C0);
		
		/// <summary>
		/// Name: OverlappingActors
		/// Type: TArray<AActor>
		/// Offset: 0x1C8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> OverlappingActors => new TArray<AActor>(BaseAddress+0x1C8);
		
		/// <summary>
		/// Name: CanBePlaced
		/// Type: BoolProperty
		/// Offset: 0x1D8
		/// Size: 0x01
		/// </summary>
		public bool CanBePlaced
		{
			get
			{
				return ReadBool(0x1D8);
			}
			set
			{
				WriteBool(0x1D8,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingBrushRecipe
		/// Type: ObjectProperty
		/// Offset: 0x1E0
		/// Size: 0x08
		/// </summary>
		public URecipeItem BuildingBrushRecipe => ReadUObject<URecipeItem>(0x1E0);
		
		/// <summary>
		/// Name: TickTraceCurrentHitComponent
		/// Type: ObjectProperty
		/// Offset: 0x1E8
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent TickTraceCurrentHitComponent => ReadUObject<UPrimitiveComponent>(0x1E8);
		
		/// <summary>
		/// Name: TickTraceCurrentHitItemIndex
		/// Type: IntProperty
		/// Offset: 0x1F0
		/// Size: 0x04
		/// </summary>
		public int TickTraceCurrentHitItemIndex
		{
			get
			{
				return ReadInt32(0x1F0);
			}
			set
			{
				WriteInt32(0x1F0,value);
			}
		}
		
		/// <summary>
		/// Name: CameraWorldRotation
		/// Type: StructProperty
		/// Offset: 0x1F4
		/// Size: 0x0C
		/// </summary>
		public FRotator CameraWorldRotation => ReadStruct<FRotator>(0x1F4);
		
		/// <summary>
		/// Name: BuildingRotationOffset
		/// Type: FloatProperty
		/// Offset: 0x200
		/// Size: 0x04
		/// </summary>
		public float BuildingRotationOffset
		{
			get
			{
				return ReadSingle(0x200);
			}
			set
			{
				WriteSingle(0x200,value);
			}
		}
		
		/// <summary>
		/// Name: HeightAdjustmentOffset
		/// Type: FloatProperty
		/// Offset: 0x204
		/// Size: 0x04
		/// </summary>
		public float HeightAdjustmentOffset
		{
			get
			{
				return ReadSingle(0x204);
			}
			set
			{
				WriteSingle(0x204,value);
			}
		}
		
		/// <summary>
		/// Name: IsHidingSockets
		/// Type: BoolProperty
		/// Offset: 0x208
		/// Size: 0x01
		/// </summary>
		public bool IsHidingSockets
		{
			get
			{
				return ReadBool(0x208);
			}
			set
			{
				WriteBool(0x208,value);
			}
		}
		
		/// <summary>
		/// Name: TiltAdjustmentOffset
		/// Type: FloatProperty
		/// Offset: 0x220
		/// Size: 0x04
		/// </summary>
		public float TiltAdjustmentOffset
		{
			get
			{
				return ReadSingle(0x220);
			}
			set
			{
				WriteSingle(0x220,value);
			}
		}
		
		/// <summary>
		/// Name: StartBuildingHasTriggered
		/// Type: BoolProperty
		/// Offset: 0x224
		/// Size: 0x01
		/// </summary>
		public bool StartBuildingHasTriggered
		{
			get
			{
				return ReadBool(0x224);
			}
			set
			{
				WriteBool(0x224,value);
			}
		}
		
		/// <summary>
		/// Name: CanBuildIndicatorWidget
		/// Type: ObjectProperty
		/// Offset: 0x228
		/// Size: 0x08
		/// </summary>
		public UW_CanBuildIndicator_C CanBuildIndicatorWidget => ReadUObject<UW_CanBuildIndicator_C>(0x228);
		
		/// <summary>
		/// Name: BuildingBrushPlaceable
		/// Type: ObjectProperty
		/// Offset: 0x230
		/// Size: 0x08
		/// </summary>
		public ABP_Master_Placeables_C BuildingBrushPlaceable => ReadUObject<ABP_Master_Placeables_C>(0x230);
		
		/// <summary>
		/// Name: PlacementImpactNormalRotation
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x0C
		/// </summary>
		public FRotator PlacementImpactNormalRotation => ReadStruct<FRotator>(0x238);
		
		/// <summary>
		/// Name: CanBePlacedMessage
		/// Type: TextProperty
		/// Offset: 0x248
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: LineTraceActorsToIgnore
		/// Type: TArray<AActor>
		/// Offset: 0x260
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> LineTraceActorsToIgnore => new TArray<AActor>(BaseAddress+0x260);
		
		/// <summary>
		/// Name: IsBuildingPlaceables
		/// Type: BoolProperty
		/// Offset: 0x270
		/// Size: 0x01
		/// </summary>
		public bool IsBuildingPlaceables
		{
			get
			{
				return ReadBool(0x270);
			}
			set
			{
				WriteBool(0x270,value);
			}
		}
		
		/// <summary>
		/// Name: GhostsTimer
		/// Type: FloatProperty
		/// Offset: 0x274
		/// Size: 0x04
		/// </summary>
		public float GhostsTimer
		{
			get
			{
				return ReadSingle(0x274);
			}
			set
			{
				WriteSingle(0x274,value);
			}
		}
		
		/// <summary>
		/// Name: PreviousSnapTarget
		/// Type: IntProperty
		/// Offset: 0x278
		/// Size: 0x04
		/// </summary>
		public int PreviousSnapTarget
		{
			get
			{
				return ReadInt32(0x278);
			}
			set
			{
				WriteInt32(0x278,value);
			}
		}
		
		/// <summary>
		/// Name: PreviousSnapComponent
		/// Type: ObjectProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent PreviousSnapComponent => ReadUObject<UPrimitiveComponent>(0x280);
		
		/// <summary>
		/// Name: RedXGUIModule
		/// Type: ObjectProperty
		/// Offset: 0x288
		/// Size: 0x08
		/// </summary>
		public UWindowRoot RedXGUIModule => ReadUObject<UWindowRoot>(0x288);
		
		/// <summary>
		/// Name: AutoAlignToGround
		/// Type: BoolProperty
		/// Offset: 0x290
		/// Size: 0x01
		/// </summary>
		public bool AutoAlignToGround
		{
			get
			{
				return ReadBool(0x290);
			}
			set
			{
				WriteBool(0x290,value);
			}
		}
		
		/// <summary>
		/// Name: MaxRoll
		/// Type: FloatProperty
		/// Offset: 0x294
		/// Size: 0x04
		/// </summary>
		public float MaxRoll
		{
			get
			{
				return ReadSingle(0x294);
			}
			set
			{
				WriteSingle(0x294,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPitch
		/// Type: FloatProperty
		/// Offset: 0x298
		/// Size: 0x04
		/// </summary>
		public float MaxPitch
		{
			get
			{
				return ReadSingle(0x298);
			}
			set
			{
				WriteSingle(0x298,value);
			}
		}
		
		/// <summary>
		/// Name: DisabledCollisionComponents
		/// Type: TArray<UPrimitiveComponent>
		/// Offset: 0x2A0
		/// Size: 0x10
		/// SubElement Size: 0x5A0
		/// </summary>
		public TArray<UPrimitiveComponent> DisabledCollisionComponents => new TArray<UPrimitiveComponent>(BaseAddress+0x2A0);
		
	}


	/// <summary>
	/// ABP_BuildingBase_C:ABuildingBase
	/// Size: 0x740
	/// Properties: 24
	/// </summary>
	public class ABP_BuildingBase_C:ABuildingBase
	{
		public override int ObjectSize => 1856;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x608
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x608);
		
		/// <summary>
		/// Name: AILOD
		/// Type: ObjectProperty
		/// Offset: 0x610
		/// Size: 0x08
		/// </summary>
		public UAILODComponent AILOD => ReadUObject<UAILODComponent>(0x610);
		
		/// <summary>
		/// Name: SecondaryOverlapPlaceablesBoxChecker
		/// Type: ObjectProperty
		/// Offset: 0x618
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SecondaryOverlapPlaceablesBoxChecker => ReadUObject<UBoxComponent>(0x618);
		
		/// <summary>
		/// Name: SecondaryOverlapBuildingBoxChecker
		/// Type: ObjectProperty
		/// Offset: 0x620
		/// Size: 0x08
		/// </summary>
		public UBoxComponent SecondaryOverlapBuildingBoxChecker => ReadUObject<UBoxComponent>(0x620);
		
		/// <summary>
		/// Name: TextRender
		/// Type: ObjectProperty
		/// Offset: 0x628
		/// Size: 0x08
		/// </summary>
		public UTextRenderComponent TextRender => ReadUObject<UTextRenderComponent>(0x628);
		
		/// <summary>
		/// Name: AIPerceptionStimuliSource
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionStimuliSourceComponent AIPerceptionStimuliSource => ReadUObject<UAIPerceptionStimuliSourceComponent>(0x630);
		
		/// <summary>
		/// Name: OverlapPlaceablesBoxChecker
		/// Type: ObjectProperty
		/// Offset: 0x638
		/// Size: 0x08
		/// </summary>
		public UBoxComponent OverlapPlaceablesBoxChecker => ReadUObject<UBoxComponent>(0x638);
		
		/// <summary>
		/// Name: ConanBuildingPersistence
		/// Type: ObjectProperty
		/// Offset: 0x640
		/// Size: 0x08
		/// </summary>
		public UConanBuildingPersistenceComponent ConanBuildingPersistence => ReadUObject<UConanBuildingPersistenceComponent>(0x640);
		
		/// <summary>
		/// Name: OverlapBuildingBoxChecker
		/// Type: ObjectProperty
		/// Offset: 0x648
		/// Size: 0x08
		/// </summary>
		public UBoxComponent OverlapBuildingBoxChecker => ReadUObject<UBoxComponent>(0x648);
		
		/// <summary>
		/// Name: MustSnapToExistingBuilding
		/// Type: BoolProperty
		/// Offset: 0x650
		/// Size: 0x01
		/// </summary>
		public bool MustSnapToExistingBuilding
		{
			get
			{
				return ReadBool(0x650);
			}
			set
			{
				WriteBool(0x650,value);
			}
		}
		
		/// <summary>
		/// Name: IsBeingFlipped
		/// Type: BoolProperty
		/// Offset: 0x651
		/// Size: 0x01
		/// </summary>
		public bool IsBeingFlipped
		{
			get
			{
				return ReadBool(0x651);
			}
			set
			{
				WriteBool(0x651,value);
			}
		}
		
		/// <summary>
		/// Name: DistanceToPlayer
		/// Type: FloatProperty
		/// Offset: 0x654
		/// Size: 0x04
		/// </summary>
		public float DistanceToPlayer
		{
			get
			{
				return ReadSingle(0x654);
			}
			set
			{
				WriteSingle(0x654,value);
			}
		}
		
		/// <summary>
		/// Name: SocketTransform
		/// Type: StructProperty
		/// Offset: 0x660
		/// Size: 0x30
		/// </summary>
		public FTransform SocketTransform => ReadStruct<FTransform>(0x660);
		
		/// <summary>
		/// Name: IgnoreOverlappingTheseMeshes
		/// Type: TArray<UStaticMesh>
		/// Offset: 0x690
		/// Size: 0x10
		/// SubElement Size: 0x118
		/// </summary>
		public TArray<UStaticMesh> IgnoreOverlappingTheseMeshes => new TArray<UStaticMesh>(BaseAddress+0x690);
		
		/// <summary>
		/// Name: Time
		/// Type: FloatProperty
		/// Offset: 0x6A0
		/// Size: 0x04
		/// </summary>
		public float Time
		{
			get
			{
				return ReadSingle(0x6A0);
			}
			set
			{
				WriteSingle(0x6A0,value);
			}
		}
		
		/// <summary>
		/// Name: IgnoreOverlappingTheseFoilageMeshes
		/// Type: TArray<UStaticMesh>
		/// Offset: 0x6A8
		/// Size: 0x10
		/// SubElement Size: 0x118
		/// </summary>
		public TArray<UStaticMesh> IgnoreOverlappingTheseFoilageMeshes => new TArray<UStaticMesh>(BaseAddress+0x6A8);
		
		/// <summary>
		/// Name: ShowOutsideTextWhenPlacing
		/// Type: BoolProperty
		/// Offset: 0x6D8
		/// Size: 0x01
		/// </summary>
		public bool ShowOutsideTextWhenPlacing
		{
			get
			{
				return ReadBool(0x6D8);
			}
			set
			{
				WriteBool(0x6D8,value);
			}
		}
		
		/// <summary>
		/// Name: FlipOutsideText
		/// Type: BoolProperty
		/// Offset: 0x6D9
		/// Size: 0x01
		/// </summary>
		public bool FlipOutsideText
		{
			get
			{
				return ReadBool(0x6D9);
			}
			set
			{
				WriteBool(0x6D9,value);
			}
		}
		
		/// <summary>
		/// Name: UseSecondaryOverlapBuildingBoxChecker
		/// Type: BoolProperty
		/// Offset: 0x6DA
		/// Size: 0x01
		/// </summary>
		public bool UseSecondaryOverlapBuildingBoxChecker
		{
			get
			{
				return ReadBool(0x6DA);
			}
			set
			{
				WriteBool(0x6DA,value);
			}
		}
		
		/// <summary>
		/// Name: UseSecondaryPlaceablesBoxChecker
		/// Type: BoolProperty
		/// Offset: 0x6DB
		/// Size: 0x01
		/// </summary>
		public bool UseSecondaryPlaceablesBoxChecker
		{
			get
			{
				return ReadBool(0x6DB);
			}
			set
			{
				WriteBool(0x6DB,value);
			}
		}
		
		/// <summary>
		/// Name: Error_Overlapping_Text
		/// Type: TextProperty
		/// Offset: 0x6E0
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_Not_Snapped
		/// Type: TextProperty
		/// Offset: 0x6F8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Error_BelowGround
		/// Type: TextProperty
		/// Offset: 0x710
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextRenderText
		/// Type: TextProperty
		/// Offset: 0x728
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UInsideChecker_C:UActorComponent
	/// Size: 0x151
	/// Properties: 15
	/// </summary>
	public class UInsideChecker_C:UActorComponent
	{
		public override int ObjectSize => 337;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: CheckForInsideDistance
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float CheckForInsideDistance
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: InsidePercentage
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float InsidePercentage
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: InsideCheckServerFrequency
		/// Type: IntProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public int InsideCheckServerFrequency
		{
			get
			{
				return ReadInt32(0xE8);
			}
			set
			{
				WriteInt32(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: InsideCheckClientTicks
		/// Type: IntProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public int InsideCheckClientTicks
		{
			get
			{
				return ReadInt32(0xEC);
			}
			set
			{
				WriteInt32(0xEC,value);
			}
		}
		
		/// <summary>
		/// Name: PrevInsidePercentage
		/// Type: FloatProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public float PrevInsidePercentage
		{
			get
			{
				return ReadSingle(0xF0);
			}
			set
			{
				WriteSingle(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: LastClientUpdateTimes
		/// Type: TArray<>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: LastClientUpdateRemoveIndex
		/// Type: IntProperty
		/// Offset: 0x108
		/// Size: 0x04
		/// </summary>
		public int LastClientUpdateRemoveIndex
		{
			get
			{
				return ReadInt32(0x108);
			}
			set
			{
				WriteInt32(0x108,value);
			}
		}
		
		/// <summary>
		/// Name: MaxForcedUpdates
		/// Type: IntProperty
		/// Offset: 0x10C
		/// Size: 0x04
		/// </summary>
		public int MaxForcedUpdates
		{
			get
			{
				return ReadInt32(0x10C);
			}
			set
			{
				WriteInt32(0x10C,value);
			}
		}
		
		/// <summary>
		/// Name: Weights
		/// Type: TArray<>
		/// Offset: 0x110
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: Punishments
		/// Type: TArray<>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: IsShelterSoundMixAcivated
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool IsShelterSoundMixAcivated
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
		/// Name: AudioRef
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent AudioRef => ReadUObject<UConanAudioComponent>(0x138);
		
		/// <summary>
		/// Name: InsidePPVolumes
		/// Type: TArray<APostProcessVolume>
		/// Offset: 0x140
		/// Size: 0x10
		/// SubElement Size: 0x7C0
		/// </summary>
		public TArray<APostProcessVolume> InsidePPVolumes => new TArray<APostProcessVolume>(BaseAddress+0x140);
		
		/// <summary>
		/// Name: InsidePPVolume
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool InsidePPVolume
		{
			get
			{
				return ReadBool(0x150);
			}
			set
			{
				WriteBool(0x150,value);
			}
		}
		
	}


}

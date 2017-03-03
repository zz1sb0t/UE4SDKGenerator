using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building.SplinePlaceables;
using ConanExilesGame.Game.Characters;


namespace ConanExilesGame.Game.Systems.Building.SplinePlaceables
{
	/// <summary>
	/// UBP_Building_SplinePlaceables_C:UActorComponent
	/// Size: 0x168
	/// Properties: 17
	/// </summary>
	public class UBP_Building_SplinePlaceables_C:UActorComponent
	{
		public override int ObjectSize => 360;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: IsBuilding
		/// Type: BoolProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public bool IsBuilding
		{
			get
			{
				return ReadBool(0xE0);
			}
			set
			{
				WriteBool(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: ActiveSplinePlaceable
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public ABP_Master_SplinePlaceable_C ActiveSplinePlaceable => ReadUObject<ABP_Master_SplinePlaceable_C>(0xE8);
		
		/// <summary>
		/// Name: BuildRange
		/// Type: FloatProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public float BuildRange
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
		/// Name: LineTraceActorsToIgnore
		/// Type: TArray<AActor>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> LineTraceActorsToIgnore => new TArray<AActor>(BaseAddress+0xF8);
		
		/// <summary>
		/// Name: CanBePlaced
		/// Type: BoolProperty
		/// Offset: 0x108
		/// Size: 0x01
		/// </summary>
		public bool CanBePlaced
		{
			get
			{
				return ReadBool(0x108);
			}
			set
			{
				WriteBool(0x108,value);
			}
		}
		
		/// <summary>
		/// Name: HeightAdjustmentOffset
		/// Type: FloatProperty
		/// Offset: 0x10C
		/// Size: 0x04
		/// </summary>
		public float HeightAdjustmentOffset
		{
			get
			{
				return ReadSingle(0x10C);
			}
			set
			{
				WriteSingle(0x10C,value);
			}
		}
		
		/// <summary>
		/// Name: TiltAdjustmentOffset
		/// Type: FloatProperty
		/// Offset: 0x110
		/// Size: 0x04
		/// </summary>
		public float TiltAdjustmentOffset
		{
			get
			{
				return ReadSingle(0x110);
			}
			set
			{
				WriteSingle(0x110,value);
			}
		}
		
		/// <summary>
		/// Name: PlaceableRecipes
		/// Type: TArray<>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: PlaceableBrushRecipeItem
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public URecipeItem PlaceableBrushRecipeItem => ReadUObject<URecipeItem>(0x128);
		
		/// <summary>
		/// Name: BaseSurvivalChar
		/// Type: ObjectProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public ABaseSurvivalChar_C BaseSurvivalChar => ReadUObject<ABaseSurvivalChar_C>(0x130);
		
		/// <summary>
		/// Name: SelectNext
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool SelectNext
		{
			get
			{
				return ReadBool(0x138);
			}
			set
			{
				WriteBool(0x138,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentPlaceableSplineBrushClass
		/// Type: ClassProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: IsFirstPlaced
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool IsFirstPlaced
		{
			get
			{
				return ReadBool(0x148);
			}
			set
			{
				WriteBool(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: PlacedSplinePlaceable
		/// Type: ObjectProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public ABP_Master_SplinePlaceable_C PlacedSplinePlaceable => ReadUObject<ABP_Master_SplinePlaceable_C>(0x150);
		
		/// <summary>
		/// Name: CraftingQueue
		/// Type: ObjectProperty
		/// Offset: 0x158
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue CraftingQueue => ReadUObject<UCraftingQueue>(0x158);
		
		/// <summary>
		/// Name: Camera
		/// Type: ObjectProperty
		/// Offset: 0x160
		/// Size: 0x08
		/// </summary>
		public UCameraComponent Camera => ReadUObject<UCameraComponent>(0x160);
		
	}


	/// <summary>
	/// ABP_Master_SplinePlaceable_C:AActor
	/// Size: 0x3E4
	/// Properties: 6
	/// </summary>
	public class ABP_Master_SplinePlaceable_C:AActor
	{
		public override int ObjectSize => 996;
		/// <summary>
		/// Name: SplineMesh
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public USplineMeshComponent SplineMesh => ReadUObject<USplineMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: IsInBuildingMode
		/// Type: BoolProperty
		/// Offset: 0x3E0
		/// Size: 0x01
		/// </summary>
		public bool IsInBuildingMode
		{
			get
			{
				return ReadBool(0x3E0);
			}
			set
			{
				WriteBool(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeRotated
		/// Type: BoolProperty
		/// Offset: 0x3E1
		/// Size: 0x01
		/// </summary>
		public bool CanBeRotated
		{
			get
			{
				return ReadBool(0x3E1);
			}
			set
			{
				WriteBool(0x3E1,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeHeightAdjusted
		/// Type: BoolProperty
		/// Offset: 0x3E2
		/// Size: 0x01
		/// </summary>
		public bool CanBeHeightAdjusted
		{
			get
			{
				return ReadBool(0x3E2);
			}
			set
			{
				WriteBool(0x3E2,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeTilted
		/// Type: BoolProperty
		/// Offset: 0x3E3
		/// Size: 0x01
		/// </summary>
		public bool CanBeTilted
		{
			get
			{
				return ReadBool(0x3E3);
			}
			set
			{
				WriteBool(0x3E3,value);
			}
		}
		
	}


	/// <summary>
	/// ABP_SP_Road_C:ABP_Master_SplinePlaceable_C
	/// Size: 0x3E4
	/// Properties: 0
	/// </summary>
	public class ABP_SP_Road_C:ABP_Master_SplinePlaceable_C
	{
		public override int ObjectSize => 996;
	}


}

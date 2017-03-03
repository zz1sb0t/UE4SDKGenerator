using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Thrall;


namespace ConanExilesGame.Game.Systems.Thrall
{
	/// <summary>
	/// UBP_ThrallSystemComponent_C:UThrallSystemComponent
	/// Size: 0x158
	/// Properties: 8
	/// </summary>
	public class UBP_ThrallSystemComponent_C:UThrallSystemComponent
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF0);
		
		/// <summary>
		/// Name: BrushActor
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public AActor BrushActor => ReadUObject<AActor>(0xF8);
		
		/// <summary>
		/// Name: PlaceableRange
		/// Type: FloatProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public float PlaceableRange
		{
			get
			{
				return ReadSingle(0x100);
			}
			set
			{
				WriteSingle(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: Rotation
		/// Type: StructProperty
		/// Offset: 0x104
		/// Size: 0x0C
		/// </summary>
		public FRotator Rotation => ReadStruct<FRotator>(0x104);
		
		/// <summary>
		/// Name: BrushTransform
		/// Type: StructProperty
		/// Offset: 0x110
		/// Size: 0x30
		/// </summary>
		public FTransform BrushTransform => ReadStruct<FTransform>(0x110);
		
		/// <summary>
		/// Name: BrushGroundOffset
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float BrushGroundOffset
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnedActor
		/// Type: ObjectProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		public AActor SpawnedActor => ReadUObject<AActor>(0x148);
		
		/// <summary>
		/// Name: SourceThrallItem
		/// Type: ObjectProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public UThrallItem SourceThrallItem => ReadUObject<UThrallItem>(0x150);
		
	}


	/// <summary>
	/// UBP_ThrallComponent_C:UThrallComponent
	/// Size: 0x188
	/// Properties: 1
	/// </summary>
	public class UBP_ThrallComponent_C:UThrallComponent
	{
		public override int ObjectSize => 392;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x180
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x180);
		
	}


	/// <summary>
	/// UBP_ThrallComponentWithLayout_C:UBP_ThrallComponent_C
	/// Size: 0x2B4
	/// Properties: 2
	/// </summary>
	public class UBP_ThrallComponentWithLayout_C:UBP_ThrallComponent_C
	{
		public override int ObjectSize => 692;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x188
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x188);
		
		/// <summary>
		/// Name: ThrallCharLayout
		/// Type: StructProperty
		/// Offset: 0x190
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout ThrallCharLayout => ReadStruct<FCharacterLayout>(0x190);
		
	}


	/// <summary>
	/// UThrallNPCInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UThrallNPCInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UThrallConverterInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UThrallConverterInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AThrallRopeActor_C:AActor
	/// Size: 0x418
	/// Properties: 9
	/// </summary>
	public class AThrallRopeActor_C:AActor
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: PhysicsConstraintLeft
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UPhysicsConstraintComponent PhysicsConstraintLeft => ReadUObject<UPhysicsConstraintComponent>(0x3D8);
		
		/// <summary>
		/// Name: PhysicsConstraintRight
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UPhysicsConstraintComponent PhysicsConstraintRight => ReadUObject<UPhysicsConstraintComponent>(0x3E0);
		
		/// <summary>
		/// Name: SphereTetherPoint
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SphereTetherPoint => ReadUObject<UStaticMeshComponent>(0x3E8);
		
		/// <summary>
		/// Name: Cable
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UCableComponent Cable => ReadUObject<UCableComponent>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: PlayerActor
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public AActor PlayerActor => ReadUObject<AActor>(0x400);
		
		/// <summary>
		/// Name: DragDistance
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float DragDistance
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: ThrallMesh
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent ThrallMesh => ReadUObject<USkeletalMeshComponent>(0x410);
		
	}


	/// <summary>
	/// UI_ThrallBaseInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_ThrallBaseInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Effects.blueprints;


namespace ConanExilesGame.Game.Effects.blueprints
{
	/// <summary>
	/// UDynamicMaterialParamController_C:UActorComponent
	/// Size: 0x10C
	/// Properties: 8
	/// </summary>
	public class UDynamicMaterialParamController_C:UActorComponent
	{
		public override int ObjectSize => 268;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: DynamicMaterialInstances
		/// Type: TArray<UMaterialInstanceDynamic>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x1C8
		/// </summary>
		public TArray<UMaterialInstanceDynamic> DynamicMaterialInstances => new TArray<UMaterialInstanceDynamic>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: ParamName
		/// Type: NameProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DefaultVal
		/// Type: FloatProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public float DefaultVal
		{
			get
			{
				return ReadSingle(0xF8);
			}
			set
			{
				WriteSingle(0xF8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetVal
		/// Type: FloatProperty
		/// Offset: 0xFC
		/// Size: 0x04
		/// </summary>
		public float TargetVal
		{
			get
			{
				return ReadSingle(0xFC);
			}
			set
			{
				WriteSingle(0xFC,value);
			}
		}
		
		/// <summary>
		/// Name: FadeRate
		/// Type: FloatProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public float FadeRate
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
		/// Name: ParamVal
		/// Type: FloatProperty
		/// Offset: 0x104
		/// Size: 0x04
		/// </summary>
		public float ParamVal
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
		/// Name: FadeDirection
		/// Type: FloatProperty
		/// Offset: 0x108
		/// Size: 0x04
		/// </summary>
		public float FadeDirection
		{
			get
			{
				return ReadSingle(0x108);
			}
			set
			{
				WriteSingle(0x108,value);
			}
		}
		
	}


	/// <summary>
	/// ABP_blood_impact_01_C:AActor
	/// Size: 0x450
	/// Properties: 10
	/// </summary>
	public class ABP_blood_impact_01_C:AActor
	{
		public override int ObjectSize => 1104;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: stain_timeline_NewTrack_2_74A2E95B4AA9BFB1601042982BCD9745
		/// Type: FloatProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public float stain_timeline_NewTrack_2_74A2E95B4AA9BFB1601042982BCD9745
		{
			get
			{
				return ReadSingle(0x3E0);
			}
			set
			{
				WriteSingle(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: stain_timeline__Direction_74A2E95B4AA9BFB1601042982BCD9745
		/// Type: ByteProperty
		/// Offset: 0x3E4
		/// Size: 0x01
		/// </summary>
		public byte stain_timeline__Direction_74A2E95B4AA9BFB1601042982BCD9745
		{
			get
			{
				return ReadByte(0x3E4);
			}
			set
			{
				WriteByte(0x3E4,value);
			}
		}
		
		/// <summary>
		/// Name: stain_timeline
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent stain_timeline => ReadUObject<UTimelineComponent>(0x3E8);
		
		/// <summary>
		/// Name: stains
		/// Type: TArray<ABP_bloodstain_01_C>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x3FC
		/// </summary>
		public TArray<ABP_bloodstain_01_C> stains => new TArray<ABP_bloodstain_01_C>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: ParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UParticleSystem ParticleSystem => ReadUObject<UParticleSystem>(0x400);
		
		/// <summary>
		/// Name: LocalTransform
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0x30
		/// </summary>
		public FTransform LocalTransform => ReadStruct<FTransform>(0x410);
		
		/// <summary>
		/// Name: AttachTo
		/// Type: NameProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AttachComponent
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public USceneComponent AttachComponent => ReadUObject<USceneComponent>(0x448);
		
	}


	/// <summary>
	/// ABP_bloodstain_01_C:AActor
	/// Size: 0x3FC
	/// Properties: 7
	/// </summary>
	public class ABP_bloodstain_01_C:AActor
	{
		public override int ObjectSize => 1020;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Decal
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UDecalComponent Decal => ReadUObject<UDecalComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: bloodstain_timeline_life_6CB03BCA428F3FA64805BE8BFC5F70E8
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float bloodstain_timeline_life_6CB03BCA428F3FA64805BE8BFC5F70E8
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: bloodstain_timeline__Direction_6CB03BCA428F3FA64805BE8BFC5F70E8
		/// Type: ByteProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public byte bloodstain_timeline__Direction_6CB03BCA428F3FA64805BE8BFC5F70E8
		{
			get
			{
				return ReadByte(0x3EC);
			}
			set
			{
				WriteByte(0x3EC,value);
			}
		}
		
		/// <summary>
		/// Name: bloodstain_timeline
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent bloodstain_timeline => ReadUObject<UTimelineComponent>(0x3F0);
		
		/// <summary>
		/// Name: stain_opacity
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float stain_opacity
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
	}


	/// <summary>
	/// ABP_SummonRay_C:AActor
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class ABP_SummonRay_C:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: Cone
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Cone => ReadUObject<UStaticMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
	}


	/// <summary>
	/// ABP_sand_affected_by_wind_C:AActor
	/// Size: 0x408
	/// Properties: 7
	/// </summary>
	public class ABP_sand_affected_by_wind_C:AActor
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: P_sand
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent P_sand => ReadUObject<UParticleSystemComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: lookat_timeline__Direction_0DE4112142F19AEF621CBEA0ECC0E9CC
		/// Type: ByteProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public byte lookat_timeline__Direction_0DE4112142F19AEF621CBEA0ECC0E9CC
		{
			get
			{
				return ReadByte(0x3E8);
			}
			set
			{
				WriteByte(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: lookat_timeline
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent lookat_timeline => ReadUObject<UTimelineComponent>(0x3F0);
		
		/// <summary>
		/// Name: rotatefrequency
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float rotatefrequency
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: ground_normal
		/// Type: StructProperty
		/// Offset: 0x3FC
		/// Size: 0x0C
		/// </summary>
		public FVector ground_normal => ReadStruct<FVector>(0x3FC);
		
	}


}

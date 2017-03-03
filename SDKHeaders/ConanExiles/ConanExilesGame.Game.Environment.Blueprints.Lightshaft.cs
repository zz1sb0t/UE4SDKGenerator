using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Environment.Blueprints.Lightshaft
{
	/// <summary>
	/// ABP_GodRay_C:AActor
	/// Size: 0x426
	/// Properties: 14
	/// </summary>
	public class ABP_GodRay_C:AActor
	{
		public override int ObjectSize => 1062;
		/// <summary>
		/// Name: StaticMesh1
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh1 => ReadUObject<UStaticMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: UISprite
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent UISprite => ReadUObject<UBillboardComponent>(0x3D8);
		
		/// <summary>
		/// Name: GodRayMesh
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent GodRayMesh => ReadUObject<UStaticMeshComponent>(0x3E0);
		
		/// <summary>
		/// Name: Sun
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public AActor Sun => ReadUObject<AActor>(0x3E8);
		
		/// <summary>
		/// Name: Width
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float Width
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: Length
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float Length
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: Dynamicmaterial
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic Dynamicmaterial => ReadUObject<UMaterialInstanceDynamic>(0x3F8);
		
		/// <summary>
		/// Name: Color
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x10
		/// </summary>
		public FLinearColor Color => ReadStruct<FLinearColor>(0x400);
		
		/// <summary>
		/// Name: Brightness
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float Brightness
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: FadeDistance
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float FadeDistance
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: Animated
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool Animated
		{
			get
			{
				return ReadBool(0x418);
			}
			set
			{
				WriteBool(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: RandomTime
		/// Type: StructProperty
		/// Offset: 0x41C
		/// Size: 0x08
		/// </summary>
		public FRandomStream RandomTime => ReadStruct<FRandomStream>(0x41C);
		
		/// <summary>
		/// Name: SpotLight
		/// Type: BoolProperty
		/// Offset: 0x424
		/// Size: 0x01
		/// </summary>
		public bool SpotLight
		{
			get
			{
				return ReadBool(0x424);
			}
			set
			{
				WriteBool(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: UseSun
		/// Type: BoolProperty
		/// Offset: 0x425
		/// Size: 0x01
		/// </summary>
		public bool UseSun
		{
			get
			{
				return ReadBool(0x425);
			}
			set
			{
				WriteBool(0x425,value);
			}
		}
		
	}


}

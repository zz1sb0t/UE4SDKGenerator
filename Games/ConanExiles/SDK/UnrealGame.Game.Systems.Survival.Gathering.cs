using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Survival.Gathering.Gathering_v2;
using ConanExilesGame.Game.Systems.Survival.Gathering;


namespace ConanExilesGame.Game.Systems.Survival.Gathering
{
	/// <summary>
	/// ABP_ResourceActor_C:AResourceActorBase
	/// Size: 0x4B8
	/// Properties: 22
	/// </summary>
	public class ABP_ResourceActor_C:AResourceActorBase
	{
		public override int ObjectSize => 1208;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: HarvestableComponent_v2
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UHarvestableComponent_v2_C HarvestableComponent_v2 => ReadUObject<UHarvestableComponent_v2_C>(0x3D8);
		
		/// <summary>
		/// Name: ItemInventory
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UItemInventory ItemInventory => ReadUObject<UItemInventory>(0x3E0);
		
		/// <summary>
		/// Name: Destructible
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent Destructible => ReadUObject<UDestructibleComponent>(0x3E8);
		
		/// <summary>
		/// Name: StaticMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMeshComponent => ReadUObject<UStaticMeshComponent>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: TargetStaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public AStaticMeshActor TargetStaticMesh => ReadUObject<AStaticMeshActor>(0x400);
		
		/// <summary>
		/// Name: Health
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float Health
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
		/// Name: MaxHealth
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float MaxHealth
		{
			get
			{
				return ReadSingle(0x40C);
			}
			set
			{
				WriteSingle(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: VisualMesh
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UStaticMesh VisualMesh => ReadUObject<UStaticMesh>(0x410);
		
		/// <summary>
		/// Name: DeathAnimPlayRate
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float DeathAnimPlayRate
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: OwningFoliageInstanceActor
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UFoliageInstancedStaticMeshComponent OwningFoliageInstanceActor => ReadUObject<UFoliageInstancedStaticMeshComponent>(0x420);
		
		/// <summary>
		/// Name: ResourceData
		/// Type: StructProperty
		/// Offset: 0x428
		/// Size: 0x38
		/// </summary>
		public FResourceDataStructure ResourceData => ReadStruct<FResourceDataStructure>(0x428);
		
		/// <summary>
		/// Name: shouldRespawn
		/// Type: BoolProperty
		/// Offset: 0x460
		/// Size: 0x01
		/// </summary>
		public bool shouldRespawn
		{
			get
			{
				return ReadBool(0x460);
			}
			set
			{
				WriteBool(0x460,value);
			}
		}
		
		/// <summary>
		/// Name: ResetTime
		/// Type: FloatProperty
		/// Offset: 0x464
		/// Size: 0x04
		/// </summary>
		public float ResetTime
		{
			get
			{
				return ReadSingle(0x464);
			}
			set
			{
				WriteSingle(0x464,value);
			}
		}
		
		/// <summary>
		/// Name: InstanceIndex
		/// Type: IntProperty
		/// Offset: 0x468
		/// Size: 0x04
		/// </summary>
		public int InstanceIndex
		{
			get
			{
				return ReadInt32(0x468);
			}
			set
			{
				WriteInt32(0x468,value);
			}
		}
		
		/// <summary>
		/// Name: ResourceCollisionProfileName
		/// Type: NameProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ResetTimerHandle
		/// Type: StructProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ResetTimerHandle => ReadStruct<FTimerHandle>(0x498);
		
		/// <summary>
		/// Name: ResetProximityRadius
		/// Type: FloatProperty
		/// Offset: 0x4A0
		/// Size: 0x04
		/// </summary>
		public float ResetProximityRadius
		{
			get
			{
				return ReadSingle(0x4A0);
			}
			set
			{
				WriteSingle(0x4A0,value);
			}
		}
		
		/// <summary>
		/// Name: InitialHitLocation
		/// Type: StructProperty
		/// Offset: 0x4A4
		/// Size: 0x0C
		/// </summary>
		public FVector InitialHitLocation => ReadStruct<FVector>(0x4A4);
		
		/// <summary>
		/// Name: InitialHitWeaponType
		/// Type: IntProperty
		/// Offset: 0x4B0
		/// Size: 0x04
		/// </summary>
		public int InitialHitWeaponType
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
		/// Name: InitialHitWeaponTier
		/// Type: IntProperty
		/// Offset: 0x4B4
		/// Size: 0x04
		/// </summary>
		public int InitialHitWeaponTier
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
		
	}


	/// <summary>
	/// FResourceDataStructure:
	/// Size: 0x35
	/// Properties: 14
	/// </summary>
	public class FResourceDataStructure:MemoryObject
	{
		public override int ObjectSize => 53;
		/// <summary>
		/// Name: TierLevel_11_8AB2FD3D42EC7BC3FC61A3B619937895
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int TierLevel_11_8AB2FD3D42EC7BC3FC61A3B619937895
		{
			get
			{
				return ReadInt32(0x00);
			}
			set
			{
				WriteInt32(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: RespawnTime_2_944E2D814A200D8BA69F6B83EBCCEBC1
		/// Type: FloatProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public float RespawnTime_2_944E2D814A200D8BA69F6B83EBCCEBC1
		{
			get
			{
				return ReadSingle(0x04);
			}
			set
			{
				WriteSingle(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: Resource_01_46_CD24F53943AA780F124DF8A44F63E950
		/// Type: ByteProperty
		/// Offset: 0x08
		/// Size: 0x01
		/// </summary>
		public byte Resource_01_46_CD24F53943AA780F124DF8A44F63E950
		{
			get
			{
				return ReadByte(0x08);
			}
			set
			{
				WriteByte(0x08,value);
			}
		}
		
		/// <summary>
		/// Name: Resource_01_MaxAmount_47_581A7A43485260FC3B2B94A2B692F16E
		/// Type: IntProperty
		/// Offset: 0x0C
		/// Size: 0x04
		/// </summary>
		public int Resource_01_MaxAmount_47_581A7A43485260FC3B2B94A2B692F16E
		{
			get
			{
				return ReadInt32(0x0C);
			}
			set
			{
				WriteInt32(0x0C,value);
			}
		}
		
		/// <summary>
		/// Name: Resource_02_48_F0D0C21A4CDD255E523056B9A646E455
		/// Type: ByteProperty
		/// Offset: 0x10
		/// Size: 0x01
		/// </summary>
		public byte Resource_02_48_F0D0C21A4CDD255E523056B9A646E455
		{
			get
			{
				return ReadByte(0x10);
			}
			set
			{
				WriteByte(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: Resource_02_MaxAmount_49_A45DE5194B6563ED487062A70732D76D
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int Resource_02_MaxAmount_49_A45DE5194B6563ED487062A70732D76D
		{
			get
			{
				return ReadInt32(0x14);
			}
			set
			{
				WriteInt32(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: ScaleFactorDivider_45_CA564F424A6E379E562EE9B8F8DC3E9C
		/// Type: FloatProperty
		/// Offset: 0x18
		/// Size: 0x04
		/// </summary>
		public float ScaleFactorDivider_45_CA564F424A6E379E562EE9B8F8DC3E9C
		{
			get
			{
				return ReadSingle(0x18);
			}
			set
			{
				WriteSingle(0x18,value);
			}
		}
		
		/// <summary>
		/// Name: RareResource_67_3362C60A44E37F4ABBC12EABAED08038
		/// Type: ByteProperty
		/// Offset: 0x1C
		/// Size: 0x01
		/// </summary>
		public byte RareResource_67_3362C60A44E37F4ABBC12EABAED08038
		{
			get
			{
				return ReadByte(0x1C);
			}
			set
			{
				WriteByte(0x1C,value);
			}
		}
		
		/// <summary>
		/// Name: RareResource_MaxAmount_66_18BE00124D688D2A85254D90FC04E8FF
		/// Type: IntProperty
		/// Offset: 0x20
		/// Size: 0x04
		/// </summary>
		public int RareResource_MaxAmount_66_18BE00124D688D2A85254D90FC04E8FF
		{
			get
			{
				return ReadInt32(0x20);
			}
			set
			{
				WriteInt32(0x20,value);
			}
		}
		
		/// <summary>
		/// Name: RareResource_DCP_65_A11A8EE84170399295290390576F225B
		/// Type: FloatProperty
		/// Offset: 0x24
		/// Size: 0x04
		/// </summary>
		public float RareResource_DCP_65_A11A8EE84170399295290390576F225B
		{
			get
			{
				return ReadSingle(0x24);
			}
			set
			{
				WriteSingle(0x24,value);
			}
		}
		
		/// <summary>
		/// Name: EpicResource_68_18E2614C4F9D95C942F6238B11B8244A
		/// Type: ByteProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public byte EpicResource_68_18E2614C4F9D95C942F6238B11B8244A
		{
			get
			{
				return ReadByte(0x28);
			}
			set
			{
				WriteByte(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: EpicResource_MaxAmount_63_C30501DE499AADA87A3DA2BFC01D45C9
		/// Type: IntProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public int EpicResource_MaxAmount_63_C30501DE499AADA87A3DA2BFC01D45C9
		{
			get
			{
				return ReadInt32(0x2C);
			}
			set
			{
				WriteInt32(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: EpicResource_DCP_62_E6206E804230E19922E78B8B0C4367D9
		/// Type: FloatProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public float EpicResource_DCP_62_E6206E804230E19922E78B8B0C4367D9
		{
			get
			{
				return ReadSingle(0x30);
			}
			set
			{
				WriteSingle(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: IsOneShottable_41_C1BD9F9A442CEF139B0A1687D1A2581C
		/// Type: BoolProperty
		/// Offset: 0x34
		/// Size: 0x01
		/// </summary>
		public bool IsOneShottable_41_C1BD9F9A442CEF139B0A1687D1A2581C
		{
			get
			{
				return ReadBool(0x34);
			}
			set
			{
				WriteBool(0x34,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_Gathering_C:UActorComponent
	/// Size: 0xD8
	/// Properties: 0
	/// </summary>
	public class UBP_Gathering_C:UActorComponent
	{
		public override int ObjectSize => 216;
	}


	/// <summary>
	/// UResourceFoliageComponent_C:UHarvestFoliage
	/// Size: 0xA68
	/// Properties: 5
	/// </summary>
	public class UResourceFoliageComponent_C:UHarvestFoliage
	{
		public override int ObjectSize => 2664;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA50
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA50);
		
		/// <summary>
		/// Name: UniqueID
		/// Type: IntProperty
		/// Offset: 0xA58
		/// Size: 0x04
		/// </summary>
		public int UniqueID
		{
			get
			{
				return ReadInt32(0xA58);
			}
			set
			{
				WriteInt32(0xA58,value);
			}
		}
		
		/// <summary>
		/// Name: NewVar
		/// Type: BoolProperty
		/// Offset: 0xA5C
		/// Size: 0x01
		/// </summary>
		public bool NewVar
		{
			get
			{
				return ReadBool(0xA5C);
			}
			set
			{
				WriteBool(0xA5C,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponType
		/// Type: IntProperty
		/// Offset: 0xA60
		/// Size: 0x04
		/// </summary>
		public int WeaponType
		{
			get
			{
				return ReadInt32(0xA60);
			}
			set
			{
				WriteInt32(0xA60,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponItemTier
		/// Type: IntProperty
		/// Offset: 0xA64
		/// Size: 0x04
		/// </summary>
		public int WeaponItemTier
		{
			get
			{
				return ReadInt32(0xA64);
			}
			set
			{
				WriteInt32(0xA64,value);
			}
		}
		
	}


	/// <summary>
	/// UPickupFoliageComponent_C:UPickupFoliage
	/// Size: 0xA08
	/// Properties: 1
	/// </summary>
	public class UPickupFoliageComponent_C:UPickupFoliage
	{
		public override int ObjectSize => 2568;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA00
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA00);
		
	}


}

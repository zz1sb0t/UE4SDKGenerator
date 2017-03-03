using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Survival.Gathering.Gathering_v2;
using ConanExilesGame.Game.Items.Weapons;


namespace ConanExilesGame.Game.Systems.Survival.Gathering.Gathering_v2
{
	/// <summary>
	/// UHarvestableComponent_v2_C:UActorComponent
	/// Size: 0x180
	/// Properties: 29
	/// </summary>
	public class UHarvestableComponent_v2_C:UActorComponent
	{
		public override int ObjectSize => 384;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: MinHitPoints
		/// Type: IntProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public int MinHitPoints
		{
			get
			{
				return ReadInt32(0xE0);
			}
			set
			{
				WriteInt32(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: NodeResourceTier
		/// Type: IntProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public int NodeResourceTier
		{
			get
			{
				return ReadInt32(0xE4);
			}
			set
			{
				WriteInt32(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: GenericResources
		/// Type: TArray<FResourceLootStructure>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLootStructure> GenericResources => new TArray<FResourceLootStructure>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: SpecialResources
		/// Type: TArray<FResourceLootStructure>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLootStructure> SpecialResources => new TArray<FResourceLootStructure>(BaseAddress+0xF8);
		
		/// <summary>
		/// Name: LimitedResources
		/// Type: TArray<FResourceLimitedLoot>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLimitedLoot> LimitedResources => new TArray<FResourceLimitedLoot>(BaseAddress+0x108);
		
		/// <summary>
		/// Name: bIsDead
		/// Type: BoolProperty
		/// Offset: 0x118
		/// Size: 0x01
		/// </summary>
		public bool bIsDead
		{
			get
			{
				return ReadBool(0x118);
			}
			set
			{
				WriteBool(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: MaxHitPoints
		/// Type: IntProperty
		/// Offset: 0x11C
		/// Size: 0x04
		/// </summary>
		public int MaxHitPoints
		{
			get
			{
				return ReadInt32(0x11C);
			}
			set
			{
				WriteInt32(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentHitPoints
		/// Type: IntProperty
		/// Offset: 0x120
		/// Size: 0x04
		/// </summary>
		public int CurrentHitPoints
		{
			get
			{
				return ReadInt32(0x120);
			}
			set
			{
				WriteInt32(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: RespawnTime
		/// Type: FloatProperty
		/// Offset: 0x124
		/// Size: 0x04
		/// </summary>
		public float RespawnTime
		{
			get
			{
				return ReadSingle(0x124);
			}
			set
			{
				WriteSingle(0x124,value);
			}
		}
		
		/// <summary>
		/// Name: FailureDurabilityChange
		/// Type: FloatProperty
		/// Offset: 0x128
		/// Size: 0x04
		/// </summary>
		public float FailureDurabilityChange
		{
			get
			{
				return ReadSingle(0x128);
			}
			set
			{
				WriteSingle(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: SuccessDurabilityChange
		/// Type: FloatProperty
		/// Offset: 0x12C
		/// Size: 0x04
		/// </summary>
		public float SuccessDurabilityChange
		{
			get
			{
				return ReadSingle(0x12C);
			}
			set
			{
				WriteSingle(0x12C,value);
			}
		}
		
		/// <summary>
		/// Name: Instigator
		/// Type: ObjectProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public AController Instigator => ReadUObject<AController>(0x130);
		
		/// <summary>
		/// Name: WeaponItem
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public ABaseWeapon_C WeaponItem => ReadUObject<ABaseWeapon_C>(0x138);
		
		/// <summary>
		/// Name: DamageCauser
		/// Type: ObjectProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public AActor DamageCauser => ReadUObject<AActor>(0x140);
		
		/// <summary>
		/// Name: PhysicalMaterial
		/// Type: ObjectProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial PhysicalMaterial => ReadUObject<UPhysicalMaterial>(0x148);
		
		/// <summary>
		/// Name: DamagedActor
		/// Type: ObjectProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public AActor DamagedActor => ReadUObject<AActor>(0x150);
		
		/// <summary>
		/// Name: isPickup
		/// Type: BoolProperty
		/// Offset: 0x158
		/// Size: 0x01
		/// </summary>
		public bool isPickup
		{
			get
			{
				return ReadBool(0x158);
			}
			set
			{
				WriteBool(0x158,value);
			}
		}
		
		/// <summary>
		/// Name: isDropAll
		/// Type: BoolProperty
		/// Offset: 0x159
		/// Size: 0x01
		/// </summary>
		public bool isDropAll
		{
			get
			{
				return ReadBool(0x159);
			}
			set
			{
				WriteBool(0x159,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPickupDropValue
		/// Type: IntProperty
		/// Offset: 0x15C
		/// Size: 0x04
		/// </summary>
		public int MaxPickupDropValue
		{
			get
			{
				return ReadInt32(0x15C);
			}
			set
			{
				WriteInt32(0x15C,value);
			}
		}
		
		/// <summary>
		/// Name: IsDropOneLimitedResource
		/// Type: BoolProperty
		/// Offset: 0x160
		/// Size: 0x01
		/// </summary>
		public bool IsDropOneLimitedResource
		{
			get
			{
				return ReadBool(0x160);
			}
			set
			{
				WriteBool(0x160,value);
			}
		}
		
		/// <summary>
		/// Name: isTree
		/// Type: BoolProperty
		/// Offset: 0x161
		/// Size: 0x01
		/// </summary>
		public bool isTree
		{
			get
			{
				return ReadBool(0x161);
			}
			set
			{
				WriteBool(0x161,value);
			}
		}
		
		/// <summary>
		/// Name: isRock
		/// Type: BoolProperty
		/// Offset: 0x162
		/// Size: 0x01
		/// </summary>
		public bool isRock
		{
			get
			{
				return ReadBool(0x162);
			}
			set
			{
				WriteBool(0x162,value);
			}
		}
		
		/// <summary>
		/// Name: spawnedThisAttack
		/// Type: BoolProperty
		/// Offset: 0x163
		/// Size: 0x01
		/// </summary>
		public bool spawnedThisAttack
		{
			get
			{
				return ReadBool(0x163);
			}
			set
			{
				WriteBool(0x163,value);
			}
		}
		
		/// <summary>
		/// Name: initialDoubleHitPreventionHack
		/// Type: BoolProperty
		/// Offset: 0x164
		/// Size: 0x01
		/// </summary>
		public bool initialDoubleHitPreventionHack
		{
			get
			{
				return ReadBool(0x164);
			}
			set
			{
				WriteBool(0x164,value);
			}
		}
		
		/// <summary>
		/// Name: isFirstHit
		/// Type: BoolProperty
		/// Offset: 0x165
		/// Size: 0x01
		/// </summary>
		public bool isFirstHit
		{
			get
			{
				return ReadBool(0x165);
			}
			set
			{
				WriteBool(0x165,value);
			}
		}
		
		/// <summary>
		/// Name: Damage
		/// Type: FloatProperty
		/// Offset: 0x168
		/// Size: 0x04
		/// </summary>
		public float Damage
		{
			get
			{
				return ReadSingle(0x168);
			}
			set
			{
				WriteSingle(0x168,value);
			}
		}
		
		/// <summary>
		/// Name: DamageType
		/// Type: ObjectProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		public UDamageType DamageType => ReadUObject<UDamageType>(0x170);
		
		/// <summary>
		/// Name: ConanCharacter
		/// Type: ObjectProperty
		/// Offset: 0x178
		/// Size: 0x08
		/// </summary>
		public AConanCharacter ConanCharacter => ReadUObject<AConanCharacter>(0x178);
		
	}


	/// <summary>
	/// FWeaponTypeResourceStatStruct:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FWeaponTypeResourceStatStruct:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: WeaponType_8_3EAB30AC4CFDBD3DEED599B1429F20A9
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte WeaponType_8_3EAB30AC4CFDBD3DEED599B1429F20A9
		{
			get
			{
				return ReadByte(0x00);
			}
			set
			{
				WriteByte(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: IsWhitelist_14_21517FE04F5D19613AC2F0A2034082D3
		/// Type: BoolProperty
		/// Offset: 0x01
		/// Size: 0x01
		/// </summary>
		public bool IsWhitelist_14_21517FE04F5D19613AC2F0A2034082D3
		{
			get
			{
				return ReadBool(0x01);
			}
			set
			{
				WriteBool(0x01,value);
			}
		}
		
		/// <summary>
		/// Name: Resources_11_0E46116C4D6989EC8A2F4489ED029702
		/// Type: TArray<FResourceBonusStruct>
		/// Offset: 0x08
		/// Size: 0x10
		/// SubElement Size: 0x14
		/// </summary>
		public TArray<FResourceBonusStruct> Resources_11_0E46116C4D6989EC8A2F4489ED029702 => new TArray<FResourceBonusStruct>(BaseAddress+0x08);
		
	}


	/// <summary>
	/// FResourceBonusStruct:
	/// Size: 0x14
	/// Properties: 2
	/// </summary>
	public class FResourceBonusStruct:MemoryObject
	{
		public override int ObjectSize => 20;
		/// <summary>
		/// Name: Resource_8_45DAED0545BADA4CB1412D9DA9D0CFA8
		/// Type: StructProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle Resource_8_45DAED0545BADA4CB1412D9DA9D0CFA8 => ReadStruct<FDataTableRowHandle>(0x00);
		
		/// <summary>
		/// Name: DropAmountMultiplier_6_3CC13DBF4AA59F4FD8DB478A738CA1D5
		/// Type: FloatProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public float DropAmountMultiplier_6_3CC13DBF4AA59F4FD8DB478A738CA1D5
		{
			get
			{
				return ReadSingle(0x10);
			}
			set
			{
				WriteSingle(0x10,value);
			}
		}
		
	}


	/// <summary>
	/// FResourceStatStructure:
	/// Size: 0x16
	/// Properties: 4
	/// </summary>
	public class FResourceStatStructure:MemoryObject
	{
		public override int ObjectSize => 22;
		/// <summary>
		/// Name: CorrectToolType_30_E2FC2F0146DF48D2D4561F850454A3FE
		/// Type: TArray<>
		/// Offset: 0x00
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ResourceTier_25_4139E9C8403817C6EB7B2BB6D9B26969
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int ResourceTier_25_4139E9C8403817C6EB7B2BB6D9B26969
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: bIsToolExclusive_27_AB01E23B47588C9D7BA293877258A474
		/// Type: BoolProperty
		/// Offset: 0x14
		/// Size: 0x01
		/// </summary>
		public bool bIsToolExclusive_27_AB01E23B47588C9D7BA293877258A474
		{
			get
			{
				return ReadBool(0x14);
			}
			set
			{
				WriteBool(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: bIsTierExclusive_29_A4F02F5F463705DCF3B799936B3D525F
		/// Type: BoolProperty
		/// Offset: 0x15
		/// Size: 0x01
		/// </summary>
		public bool bIsTierExclusive_29_A4F02F5F463705DCF3B799936B3D525F
		{
			get
			{
				return ReadBool(0x15);
			}
			set
			{
				WriteBool(0x15,value);
			}
		}
		
	}


	/// <summary>
	/// FResourceLimitedLoot:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FResourceLimitedLoot:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: Resource_12_5DA81F3140D746F0E43467BFE3DA6896
		/// Type: StructProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle Resource_12_5DA81F3140D746F0E43467BFE3DA6896 => ReadStruct<FDataTableRowHandle>(0x00);
		
		/// <summary>
		/// Name: MaxDropAmounts_6_D648793F4F03E035E44F9A845107D0A0
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int MaxDropAmounts_6_D648793F4F03E035E44F9A845107D0A0
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: DropChancePercentage_11_3878A61E4E1F452DCF4AFAA331ABDCD5
		/// Type: FloatProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public float DropChancePercentage_11_3878A61E4E1F452DCF4AFAA331ABDCD5
		{
			get
			{
				return ReadSingle(0x14);
			}
			set
			{
				WriteSingle(0x14,value);
			}
		}
		
	}


	/// <summary>
	/// FResourceLootStructure:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FResourceLootStructure:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: Resource_26_55F19B984A8CB8C4C7D426A2B505B6FD
		/// Type: StructProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FDataTableRowHandle Resource_26_55F19B984A8CB8C4C7D426A2B505B6FD => ReadStruct<FDataTableRowHandle>(0x00);
		
		/// <summary>
		/// Name: LootWeight_15_0C9B296748A709054241C68DADA76EA3
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int LootWeight_15_0C9B296748A709054241C68DADA76EA3
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: DropChancePercentage_25_006E66F140717C325D2CCFB7133705BE
		/// Type: FloatProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public float DropChancePercentage_25_006E66F140717C325D2CCFB7133705BE
		{
			get
			{
				return ReadSingle(0x14);
			}
			set
			{
				WriteSingle(0x14,value);
			}
		}
		
	}


	/// <summary>
	/// FLootTableStructure:
	/// Size: 0x50
	/// Properties: 12
	/// </summary>
	public class FLootTableStructure:MemoryObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: isRock_41_2DBF35244B6D2B912FCB5389A943EE17
		/// Type: BoolProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public bool isRock_41_2DBF35244B6D2B912FCB5389A943EE17
		{
			get
			{
				return ReadBool(0x00);
			}
			set
			{
				WriteBool(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: isTree_39_A6D61DAB4ED3DD2CFDD688B98540A3BB
		/// Type: BoolProperty
		/// Offset: 0x01
		/// Size: 0x01
		/// </summary>
		public bool isTree_39_A6D61DAB4ED3DD2CFDD688B98540A3BB
		{
			get
			{
				return ReadBool(0x01);
			}
			set
			{
				WriteBool(0x01,value);
			}
		}
		
		/// <summary>
		/// Name: shouldDropAll_45_EE2B1E0A4AD5C87389F6069522CDC300
		/// Type: BoolProperty
		/// Offset: 0x02
		/// Size: 0x01
		/// </summary>
		public bool shouldDropAll_45_EE2B1E0A4AD5C87389F6069522CDC300
		{
			get
			{
				return ReadBool(0x02);
			}
			set
			{
				WriteBool(0x02,value);
			}
		}
		
		/// <summary>
		/// Name: MinHitPoints_21_AA528073469AFDFC7EC659825E67CCE9
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int MinHitPoints_21_AA528073469AFDFC7EC659825E67CCE9
		{
			get
			{
				return ReadInt32(0x04);
			}
			set
			{
				WriteInt32(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: MaxHitPoints_23_A8B2A0C7450E677963FC04A6F5D98277
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int MaxHitPoints_23_A8B2A0C7450E677963FC04A6F5D98277
		{
			get
			{
				return ReadInt32(0x08);
			}
			set
			{
				WriteInt32(0x08,value);
			}
		}
		
		/// <summary>
		/// Name: NodeTier_19_475933EC48FB18DC98B99A9D99141227
		/// Type: IntProperty
		/// Offset: 0x0C
		/// Size: 0x04
		/// </summary>
		public int NodeTier_19_475933EC48FB18DC98B99A9D99141227
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
		/// Name: RespawnTime_26_BACB634C4617EDC500774DB0AC132FC0
		/// Type: FloatProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public float RespawnTime_26_BACB634C4617EDC500774DB0AC132FC0
		{
			get
			{
				return ReadSingle(0x10);
			}
			set
			{
				WriteSingle(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPickupDropValue_29_8697616C4991670AAB6258B562CC8F95
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int MaxPickupDropValue_29_8697616C4991670AAB6258B562CC8F95
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
		/// Name: DropOneLimitedResource_37_97D9CABC4CBD16A99228A8BFE0462DEA
		/// Type: BoolProperty
		/// Offset: 0x18
		/// Size: 0x01
		/// </summary>
		public bool DropOneLimitedResource_37_97D9CABC4CBD16A99228A8BFE0462DEA
		{
			get
			{
				return ReadBool(0x18);
			}
			set
			{
				WriteBool(0x18,value);
			}
		}
		
		/// <summary>
		/// Name: GenericResource_4_782BD8F64E6C539029536CA594BDEE25
		/// Type: TArray<FResourceLootStructure>
		/// Offset: 0x20
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLootStructure> GenericResource_4_782BD8F64E6C539029536CA594BDEE25 => new TArray<FResourceLootStructure>(BaseAddress+0x20);
		
		/// <summary>
		/// Name: SpecialResource_8_017543E74611C6C00B37A9B9A09E94B7
		/// Type: TArray<FResourceLootStructure>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLootStructure> SpecialResource_8_017543E74611C6C00B37A9B9A09E94B7 => new TArray<FResourceLootStructure>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: LimitedResource_35_E11EE230451BD53EE884479A1E627EE1
		/// Type: TArray<FResourceLimitedLoot>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FResourceLimitedLoot> LimitedResource_35_E11EE230451BD53EE884479A1E627EE1 => new TArray<FResourceLimitedLoot>(BaseAddress+0x40);
		
	}


	/// <summary>
	/// UI_HarvestableCompInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_HarvestableCompInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AResourceDestructibleMeshActor_C:AActor
	/// Size: 0x431
	/// Properties: 9
	/// </summary>
	public class AResourceDestructibleMeshActor_C:AActor
	{
		public override int ObjectSize => 1073;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: TreeDestructibleMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent TreeDestructibleMeshComponent => ReadUObject<UDestructibleComponent>(0x3D8);
		
		/// <summary>
		/// Name: Cube
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Cube => ReadUObject<UStaticMeshComponent>(0x3E0);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x3E8);
		
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x3F0);
		
		/// <summary>
		/// Name: Scene
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent Scene => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: GeneralDestructibleMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent GeneralDestructibleMeshComponent => ReadUObject<UDestructibleComponent>(0x400);
		
		/// <summary>
		/// Name: VisualMesh
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UStaticMesh VisualMesh => ReadUObject<UStaticMesh>(0x428);
		
		/// <summary>
		/// Name: isTree
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool isTree
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
		
	}


	/// <summary>
	/// FItemNameToTemplateIDStruct:
	/// Size: 0x04
	/// Properties: 1
	/// </summary>
	public class FItemNameToTemplateIDStruct:MemoryObject
	{
		public override int ObjectSize => 4;
		/// <summary>
		/// Name: ID_XX_6_7ED8A4BD4E9D07B8E7077B82BED9F5D7
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int ID_XX_6_7ED8A4BD4E9D07B8E7077B82BED9F5D7
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
		
	}


}

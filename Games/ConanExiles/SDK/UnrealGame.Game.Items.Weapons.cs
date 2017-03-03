using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Items.Inventory;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Items.Weapons;
using ConanExilesGame.Game.Effects.blueprints;
using ConanExilesGame.Game.Items.Weapons.AnimPackage;
using ConanExilesGame.Game.Systems.Combat;


namespace ConanExilesGame.Game.Items.Weapons
{
	/// <summary>
	/// ABaseHitActor_C:AInventoryItem_C
	/// Size: 0x421
	/// Properties: 6
	/// </summary>
	public class ABaseHitActor_C:AInventoryItem_C
	{
		public override int ObjectSize => 1057;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3F0);
		
		/// <summary>
		/// Name: HitActorType
		/// Type: ByteProperty
		/// Offset: 0x3F8
		/// Size: 0x01
		/// </summary>
		public byte HitActorType
		{
			get
			{
				return ReadByte(0x3F8);
			}
			set
			{
				WriteByte(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterOwner
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public ABaseBPCombat_C CharacterOwner => ReadUObject<ABaseBPCombat_C>(0x400);
		
		/// <summary>
		/// Name: CollisionEnabled
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool CollisionEnabled
		{
			get
			{
				return ReadBool(0x408);
			}
			set
			{
				WriteBool(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: HitTargets
		/// Type: TArray<AActor>
		/// Offset: 0x410
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> HitTargets => new TArray<AActor>(BaseAddress+0x410);
		
		/// <summary>
		/// Name: SoundTransmitterType
		/// Type: ByteProperty
		/// Offset: 0x420
		/// Size: 0x01
		/// </summary>
		public byte SoundTransmitterType
		{
			get
			{
				return ReadByte(0x420);
			}
			set
			{
				WriteByte(0x420,value);
			}
		}
		
	}


	/// <summary>
	/// ABaseWeapon_C:ABaseHitActor_C
	/// Size: 0x4E8
	/// Properties: 16
	/// </summary>
	public class ABaseWeapon_C:ABaseHitActor_C
	{
		public override int ObjectSize => 1256;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x428);
		
		/// <summary>
		/// Name: WeaponMeshDestructible
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent WeaponMeshDestructible => ReadUObject<UDestructibleComponent>(0x430);
		
		/// <summary>
		/// Name: DynamicMaterialParamController
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UDynamicMaterialParamController_C DynamicMaterialParamController => ReadUObject<UDynamicMaterialParamController_C>(0x438);
		
		/// <summary>
		/// Name: FollowWeaponCollision
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UBoxComponent FollowWeaponCollision => ReadUObject<UBoxComponent>(0x440);
		
		/// <summary>
		/// Name: AnimTrail
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent AnimTrail => ReadUObject<UParticleSystemComponent>(0x448);
		
		/// <summary>
		/// Name: StaticWeaponMesh
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticWeaponMesh => ReadUObject<UStaticMeshComponent>(0x450);
		
		/// <summary>
		/// Name: WeaponCollision
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UBoxComponent WeaponCollision => ReadUObject<UBoxComponent>(0x458);
		
		/// <summary>
		/// Name: WeaponSkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent WeaponSkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x460);
		
		/// <summary>
		/// Name: _3rdAnimPackageClass
		/// Type: ClassProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: _3rdAnimPackage
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UBP_AnimPackage_Base_C _3rdAnimPackage => ReadUObject<UBP_AnimPackage_Base_C>(0x470);
		
		/// <summary>
		/// Name: _1stAnimPackageClass
		/// Type: ClassProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: _1stAnimPackage
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UBP_AnimPackage_Base_C _1stAnimPackage => ReadUObject<UBP_AnimPackage_Base_C>(0x480);
		
		/// <summary>
		/// Name: EquipmentRules
		/// Type: ByteProperty
		/// Offset: 0x488
		/// Size: 0x01
		/// </summary>
		public byte EquipmentRules
		{
			get
			{
				return ReadByte(0x488);
			}
			set
			{
				WriteByte(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: BasicAttackCollision
		/// Type: StructProperty
		/// Offset: 0x490
		/// Size: 0x40
		/// </summary>
		public FSTR_WeaponCollision BasicAttackCollision => ReadStruct<FSTR_WeaponCollision>(0x490);
		
		/// <summary>
		/// Name: CollisionSizeMultiplier
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0x0C
		/// </summary>
		public FVector CollisionSizeMultiplier => ReadStruct<FVector>(0x4D0);
		
		/// <summary>
		/// Name: AnimMontageSectionName
		/// Type: NameProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBaseWeaponInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBaseWeaponInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABP_BaseProjectile_C:AInventoryItemBase
	/// Size: 0x47C
	/// Properties: 22
	/// </summary>
	public class ABP_BaseProjectile_C:AInventoryItemBase
	{
		public override int ObjectSize => 1148;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
		/// <summary>
		/// Name: TracerSoundSystem
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent TracerSoundSystem => ReadUObject<UConanAudioComponent>(0x3F0);
		
		/// <summary>
		/// Name: TracerParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent TracerParticleSystem => ReadUObject<UParticleSystemComponent>(0x3F8);
		
		/// <summary>
		/// Name: ProjectileMesh
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent ProjectileMesh => ReadUObject<UStaticMeshComponent>(0x400);
		
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x408);
		
		/// <summary>
		/// Name: ProjectileMovement
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UConanProjectileMovementComponent ProjectileMovement => ReadUObject<UConanProjectileMovementComponent>(0x410);
		
		/// <summary>
		/// Name: TickParticleScaling__Direction_8E3EE5DB4A1BD424D612CD83A8206B8B
		/// Type: ByteProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public byte TickParticleScaling__Direction_8E3EE5DB4A1BD424D612CD83A8206B8B
		{
			get
			{
				return ReadByte(0x418);
			}
			set
			{
				WriteByte(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: TickParticleScaling
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent TickParticleScaling => ReadUObject<UTimelineComponent>(0x420);
		
		/// <summary>
		/// Name: Damage
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float Damage
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: community
		/// Type: IntProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public int community
		{
			get
			{
				return ReadInt32(0x42C);
			}
			set
			{
				WriteInt32(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnAttached
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool SpawnAttached
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
		
		/// <summary>
		/// Name: AmmoItem
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UGameItem AmmoItem => ReadUObject<UGameItem>(0x438);
		
		/// <summary>
		/// Name: SoundTransmitterType
		/// Type: ByteProperty
		/// Offset: 0x440
		/// Size: 0x01
		/// </summary>
		public byte SoundTransmitterType
		{
			get
			{
				return ReadByte(0x440);
			}
			set
			{
				WriteByte(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: MyInstigator
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public APawn MyInstigator => ReadUObject<APawn>(0x448);
		
		/// <summary>
		/// Name: StaticMeshOverride
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UStaticMesh StaticMeshOverride => ReadUObject<UStaticMesh>(0x450);
		
		/// <summary>
		/// Name: ProjectileGravityCurve
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ProjectileGravityCurve => ReadUObject<UCurveFloat>(0x458);
		
		/// <summary>
		/// Name: ProjectileSpeedCurve
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ProjectileSpeedCurve => ReadUObject<UCurveFloat>(0x460);
		
		/// <summary>
		/// Name: ScalingParticle
		/// Type: FloatProperty
		/// Offset: 0x468
		/// Size: 0x04
		/// </summary>
		public float ScalingParticle
		{
			get
			{
				return ReadSingle(0x468);
			}
			set
			{
				WriteSingle(0x468,value);
			}
		}
		
		/// <summary>
		/// Name: ScalingMesh
		/// Type: FloatProperty
		/// Offset: 0x46C
		/// Size: 0x04
		/// </summary>
		public float ScalingMesh
		{
			get
			{
				return ReadSingle(0x46C);
			}
			set
			{
				WriteSingle(0x46C,value);
			}
		}
		
		/// <summary>
		/// Name: ScalingEnabled
		/// Type: BoolProperty
		/// Offset: 0x470
		/// Size: 0x01
		/// </summary>
		public bool ScalingEnabled
		{
			get
			{
				return ReadBool(0x470);
			}
			set
			{
				WriteBool(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: ProjectileInitialSpeed
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float ProjectileInitialSpeed
		{
			get
			{
				return ReadSingle(0x474);
			}
			set
			{
				WriteSingle(0x474,value);
			}
		}
		
		/// <summary>
		/// Name: ProjectileGravityScale
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float ProjectileGravityScale
		{
			get
			{
				return ReadSingle(0x478);
			}
			set
			{
				WriteSingle(0x478,value);
			}
		}
		
	}


	/// <summary>
	/// UBPI_BaseProjectile_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBPI_BaseProjectile_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABP_BaseVisualProjectileWeapon_C:ABaseWeapon_C
	/// Size: 0x534
	/// Properties: 8
	/// </summary>
	public class ABP_BaseVisualProjectileWeapon_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1332;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
		/// <summary>
		/// Name: ProjectileAmmoTemplateID
		/// Type: IntProperty
		/// Offset: 0x4F0
		/// Size: 0x04
		/// </summary>
		public int ProjectileAmmoTemplateID
		{
			get
			{
				return ReadInt32(0x4F0);
			}
			set
			{
				WriteInt32(0x4F0,value);
			}
		}
		
		/// <summary>
		/// Name: LoadedProjectile
		/// Type: ObjectProperty
		/// Offset: 0x4F8
		/// Size: 0x08
		/// </summary>
		public ABP_BaseProjectile_C LoadedProjectile => ReadUObject<ABP_BaseProjectile_C>(0x4F8);
		
		/// <summary>
		/// Name: HasAmmo
		/// Type: BoolProperty
		/// Offset: 0x500
		/// Size: 0x01
		/// </summary>
		public bool HasAmmo
		{
			get
			{
				return ReadBool(0x500);
			}
			set
			{
				WriteBool(0x500,value);
			}
		}
		
		/// <summary>
		/// Name: ProjectileLaunchLocationBasic1st
		/// Type: StructProperty
		/// Offset: 0x504
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectileLaunchLocationBasic1st => ReadStruct<FVector>(0x504);
		
		/// <summary>
		/// Name: ProjectileLaunchLocationBasic3rd
		/// Type: StructProperty
		/// Offset: 0x510
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectileLaunchLocationBasic3rd => ReadStruct<FVector>(0x510);
		
		/// <summary>
		/// Name: ProjectileLaunchLocationSpecial1st
		/// Type: StructProperty
		/// Offset: 0x51C
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectileLaunchLocationSpecial1st => ReadStruct<FVector>(0x51C);
		
		/// <summary>
		/// Name: ProjectileLaunchLocationSpecial3rd
		/// Type: StructProperty
		/// Offset: 0x528
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectileLaunchLocationSpecial3rd => ReadStruct<FVector>(0x528);
		
	}


	/// <summary>
	/// UBP_VisualProjectileWeaponInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_VisualProjectileWeaponInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Items.Weapons;


namespace ConanExilesGame.Game.Systems.Combat
{
	/// <summary>
	/// FSTR_WeaponCollision:
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class FSTR_WeaponCollision:MemoryObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: CollisionMesh_6_51987881443F62ADDC74CCA4B89614FD
		/// Type: ObjectProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		public UStaticMesh CollisionMesh_6_51987881443F62ADDC74CCA4B89614FD => ReadUObject<UStaticMesh>(0x00);
		
		/// <summary>
		/// Name: Transform_5_E1AF10B64812859A5A43799B3F89F83A
		/// Type: StructProperty
		/// Offset: 0x10
		/// Size: 0x30
		/// </summary>
		public FTransform Transform_5_E1AF10B64812859A5A43799B3F89F83A => ReadStruct<FTransform>(0x10);
		
	}


	/// <summary>
	/// UBP_CollisionComponent_C:UCollisionSystemComponent
	/// Size: 0x300
	/// Properties: 17
	/// </summary>
	public class UBP_CollisionComponent_C:UCollisionSystemComponent
	{
		public override int ObjectSize => 768;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1A0);
		
		/// <summary>
		/// Name: OldDebugTransform
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x30
		/// </summary>
		public FTransform OldDebugTransform => ReadStruct<FTransform>(0x1B0);
		
		/// <summary>
		/// Name: HasOldDebugTransform
		/// Type: BoolProperty
		/// Offset: 0x1E0
		/// Size: 0x01
		/// </summary>
		public bool HasOldDebugTransform
		{
			get
			{
				return ReadBool(0x1E0);
			}
			set
			{
				WriteBool(0x1E0,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentWeaponRange
		/// Type: FloatProperty
		/// Offset: 0x1E4
		/// Size: 0x04
		/// </summary>
		public float CurrentWeaponRange
		{
			get
			{
				return ReadSingle(0x1E4);
			}
			set
			{
				WriteSingle(0x1E4,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentAttackDirection
		/// Type: StructProperty
		/// Offset: 0x1E8
		/// Size: 0x0C
		/// </summary>
		public FVector CurrentAttackDirection => ReadStruct<FVector>(0x1E8);
		
		/// <summary>
		/// Name: HitActor
		/// Type: ObjectProperty
		/// Offset: 0x1F8
		/// Size: 0x08
		/// </summary>
		public AActor HitActor => ReadUObject<AActor>(0x1F8);
		
		/// <summary>
		/// Name: HitItem
		/// Type: IntProperty
		/// Offset: 0x200
		/// Size: 0x04
		/// </summary>
		public int HitItem
		{
			get
			{
				return ReadInt32(0x200);
			}
			set
			{
				WriteInt32(0x200,value);
			}
		}
		
		/// <summary>
		/// Name: HitResult
		/// Type: StructProperty
		/// Offset: 0x208
		/// Size: 0x88
		/// </summary>
		public FHitResult HitResult => ReadStruct<FHitResult>(0x208);
		
		/// <summary>
		/// Name: HitComponent
		/// Type: ObjectProperty
		/// Offset: 0x290
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent HitComponent => ReadUObject<UPrimitiveComponent>(0x290);
		
		/// <summary>
		/// Name: CurrentWeapon
		/// Type: ObjectProperty
		/// Offset: 0x298
		/// Size: 0x08
		/// </summary>
		public ABaseWeapon_C CurrentWeapon => ReadUObject<ABaseWeapon_C>(0x298);
		
		/// <summary>
		/// Name: OwnerLocation
		/// Type: StructProperty
		/// Offset: 0x2A0
		/// Size: 0x0C
		/// </summary>
		public FVector OwnerLocation => ReadStruct<FVector>(0x2A0);
		
		/// <summary>
		/// Name: OwnerController
		/// Type: ObjectProperty
		/// Offset: 0x2B0
		/// Size: 0x08
		/// </summary>
		public AController OwnerController => ReadUObject<AController>(0x2B0);
		
		/// <summary>
		/// Name: OwnerCommunity
		/// Type: IntProperty
		/// Offset: 0x2B8
		/// Size: 0x04
		/// </summary>
		public int OwnerCommunity
		{
			get
			{
				return ReadInt32(0x2B8);
			}
			set
			{
				WriteInt32(0x2B8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetBlocked
		/// Type: BoolProperty
		/// Offset: 0x2D0
		/// Size: 0x01
		/// </summary>
		public bool TargetBlocked
		{
			get
			{
				return ReadBool(0x2D0);
			}
			set
			{
				WriteBool(0x2D0,value);
			}
		}
		
		/// <summary>
		/// Name: IsFromServer
		/// Type: BoolProperty
		/// Offset: 0x2D1
		/// Size: 0x01
		/// </summary>
		public bool IsFromServer
		{
			get
			{
				return ReadBool(0x2D1);
			}
			set
			{
				WriteBool(0x2D1,value);
			}
		}
		
		/// <summary>
		/// Name: HitDirection
		/// Type: StructProperty
		/// Offset: 0x2E8
		/// Size: 0x0C
		/// </summary>
		public FVector HitDirection => ReadStruct<FVector>(0x2E8);
		
		/// <summary>
		/// Name: FeedbackTimer
		/// Type: StructProperty
		/// Offset: 0x2F8
		/// Size: 0x08
		/// </summary>
		public FDateTime FeedbackTimer => ReadStruct<FDateTime>(0x2F8);
		
	}


	/// <summary>
	/// UI_CollisionComponentInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_CollisionComponentInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_Durability_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_Durability_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UCombatLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCombatLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_DamageMonitor_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_DamageMonitor_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_KnockbackNotifyState_C:UAnimNotifyState
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBP_KnockbackNotifyState_C:UAnimNotifyState
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// USweepDamageComponent_C:UCollisionSystemComponent
	/// Size: 0x208
	/// Properties: 10
	/// </summary>
	public class USweepDamageComponent_C:UCollisionSystemComponent
	{
		public override int ObjectSize => 520;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1A0);
		
		/// <summary>
		/// Name: CollisionComponents
		/// Type: TArray<UPrimitiveComponent>
		/// Offset: 0x1A8
		/// Size: 0x10
		/// SubElement Size: 0x5A0
		/// </summary>
		public TArray<UPrimitiveComponent> CollisionComponents => new TArray<UPrimitiveComponent>(BaseAddress+0x1A8);
		
		/// <summary>
		/// Name: CollisionComponentTags
		/// Type: TArray<FName>
		/// Offset: 0x1B8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> CollisionComponentTags => new TArray<FName>(BaseAddress+0x1B8);
		
		/// <summary>
		/// Name: LastSweepTransforms
		/// Type: TArray<FTransform>
		/// Offset: 0x1C8
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FTransform> LastSweepTransforms => new TArray<FTransform>(BaseAddress+0x1C8);
		
		/// <summary>
		/// Name: LastSweepDelta
		/// Type: FloatProperty
		/// Offset: 0x1D8
		/// Size: 0x04
		/// </summary>
		public float LastSweepDelta
		{
			get
			{
				return ReadSingle(0x1D8);
			}
			set
			{
				WriteSingle(0x1D8,value);
			}
		}
		
		/// <summary>
		/// Name: SweepFrequency
		/// Type: FloatProperty
		/// Offset: 0x1F0
		/// Size: 0x04
		/// </summary>
		public float SweepFrequency
		{
			get
			{
				return ReadSingle(0x1F0);
			}
			set
			{
				WriteSingle(0x1F0,value);
			}
		}
		
		/// <summary>
		/// Name: MinSweepDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0x1F4
		/// Size: 0x04
		/// </summary>
		public float MinSweepDistanceThreshold
		{
			get
			{
				return ReadSingle(0x1F4);
			}
			set
			{
				WriteSingle(0x1F4,value);
			}
		}
		
		/// <summary>
		/// Name: SweepComponentIterator
		/// Type: IntProperty
		/// Offset: 0x1F8
		/// Size: 0x04
		/// </summary>
		public int SweepComponentIterator
		{
			get
			{
				return ReadInt32(0x1F8);
			}
			set
			{
				WriteInt32(0x1F8,value);
			}
		}
		
		/// <summary>
		/// Name: SweepsPerSecond
		/// Type: IntProperty
		/// Offset: 0x1FC
		/// Size: 0x04
		/// </summary>
		public int SweepsPerSecond
		{
			get
			{
				return ReadInt32(0x1FC);
			}
			set
			{
				WriteInt32(0x1FC,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentSweepComponent
		/// Type: ObjectProperty
		/// Offset: 0x200
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent CurrentSweepComponent => ReadUObject<UPrimitiveComponent>(0x200);
		
	}


	/// <summary>
	/// UBP_SweepToTargetAttack_C:UAnimNotifyState
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UBP_SweepToTargetAttack_C:UAnimNotifyState
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: BoneName
		/// Type: NameProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBP_SweepAttack_C:UAnimNotify
	/// Size: 0xC8
	/// Properties: 9
	/// </summary>
	public class UBP_SweepAttack_C:UAnimNotify
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: CollisionTransform
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x30
		/// </summary>
		public FTransform CollisionTransform => ReadStruct<FTransform>(0x40);
		
		/// <summary>
		/// Name: EndCollisionTransform
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x30
		/// </summary>
		public FTransform EndCollisionTransform => ReadStruct<FTransform>(0x70);
		
		/// <summary>
		/// Name: CollisionExtent
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x0C
		/// </summary>
		public FVector CollisionExtent => ReadStruct<FVector>(0xA0);
		
		/// <summary>
		/// Name: CapsuleHalfHeight
		/// Type: FloatProperty
		/// Offset: 0xAC
		/// Size: 0x04
		/// </summary>
		public float CapsuleHalfHeight
		{
			get
			{
				return ReadSingle(0xAC);
			}
			set
			{
				WriteSingle(0xAC,value);
			}
		}
		
		/// <summary>
		/// Name: DrawDebug
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool DrawDebug
		{
			get
			{
				return ReadBool(0xB0);
			}
			set
			{
				WriteBool(0xB0,value);
			}
		}
		
		/// <summary>
		/// Name: isHumanoid
		/// Type: BoolProperty
		/// Offset: 0xB1
		/// Size: 0x01
		/// </summary>
		public bool isHumanoid
		{
			get
			{
				return ReadBool(0xB1);
			}
			set
			{
				WriteBool(0xB1,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionReach
		/// Type: FloatProperty
		/// Offset: 0xB4
		/// Size: 0x04
		/// </summary>
		public float CollisionReach
		{
			get
			{
				return ReadSingle(0xB4);
			}
			set
			{
				WriteSingle(0xB4,value);
			}
		}
		
		/// <summary>
		/// Name: DebugDrawDuration
		/// Type: FloatProperty
		/// Offset: 0xB8
		/// Size: 0x04
		/// </summary>
		public float DebugDrawDuration
		{
			get
			{
				return ReadSingle(0xB8);
			}
			set
			{
				WriteSingle(0xB8,value);
			}
		}
		
		/// <summary>
		/// Name: BoneName
		/// Type: NameProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBP_CollisionNotifyState_C:UWeaponCollisionAnimNotifyState
	/// Size: 0x31
	/// Properties: 1
	/// </summary>
	public class UBP_CollisionNotifyState_C:UWeaponCollisionAnimNotifyState
	{
		public override int ObjectSize => 49;
		/// <summary>
		/// Name: DrawDebug
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool DrawDebug
		{
			get
			{
				return ReadBool(0x30);
			}
			set
			{
				WriteBool(0x30,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_WeaponBreakNotifyState_C:UAnimNotifyState
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBP_WeaponBreakNotifyState_C:UAnimNotifyState
	{
		public override int ObjectSize => 48;
	}


}

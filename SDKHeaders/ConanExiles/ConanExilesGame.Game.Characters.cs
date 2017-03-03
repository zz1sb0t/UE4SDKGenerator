using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Characters.Emotes;
using ConanExilesGame.Game.Systems.Progression;
using ConanExilesGame.Game.Systems.Buffs;
using ConanExilesGame.Game.Systems.Combat;
using ConanExilesGame.Game.Systems.Religion;
using ConanExilesGame.Game.Items.Weapons.AnimPackage;
using ConanExilesGame.Game.Systems.Inventory;
using ConanExilesGame.Game.Systems.Building.BuildingActorComponents;
using ConanExilesGame.Game.Systems;
using ConanExilesGame.Game.Systems.Components;
using ConanExilesGame.Game.Systems.Thrall;
using ConanExilesGame.Game.Items.LoreObjects;
using ConanExilesGame.Game.Systems.Building;
using ConanExilesGame.Game.Effects.blueprints;
using ConanExilesGame.Game.Environment.Sandstorm;
using ConanExilesGame.Game.Systems.Hunger;
using ConanExilesGame.Game.Systems.Building.SplinePlaceables;
using ConanExilesGame.Game.Systems.Survival.Gathering;
using ConanExilesGame.Game.Systems.Combat.EncumbranceSystem;
using ConanExilesGame.Game.Effects.Particles;
using ConanExilesGame.Game.Systems.Loot.TableSetup;
using ConanExilesGame.Game.Systems.Survival.Gathering.Gathering_v2;


namespace ConanExilesGame.Game.Characters
{
	/// <summary>
	/// ABaseBPCombat_C:ABaseBPChar_C
	/// Size: 0xF5A
	/// Properties: 147
	/// </summary>
	public class ABaseBPCombat_C:ABaseBPChar_C
	{
		public override int ObjectSize => 3930;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xB30
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xB30);
		
		/// <summary>
		/// Name: BP_CharacterAttackPointAllocatorComponent
		/// Type: ObjectProperty
		/// Offset: 0xB38
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPointAllocatorComponent_C BP_CharacterAttackPointAllocatorComponent => ReadUObject<UBP_CharacterAttackPointAllocatorComponent_C>(0xB38);
		
		/// <summary>
		/// Name: BPEmoteController
		/// Type: ObjectProperty
		/// Offset: 0xB40
		/// Size: 0x08
		/// </summary>
		public UBPEmoteController_C BPEmoteController => ReadUObject<UBPEmoteController_C>(0xB40);
		
		/// <summary>
		/// Name: OverlapTriggerCapsule
		/// Type: ObjectProperty
		/// Offset: 0xB48
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent OverlapTriggerCapsule => ReadUObject<UCapsuleComponent>(0xB48);
		
		/// <summary>
		/// Name: BP_XPHolder
		/// Type: ObjectProperty
		/// Offset: 0xB50
		/// Size: 0x08
		/// </summary>
		public UBP_XPHolder_C BP_XPHolder => ReadUObject<UBP_XPHolder_C>(0xB50);
		
		/// <summary>
		/// Name: _00_BP_AC_BuffSystem
		/// Type: ObjectProperty
		/// Offset: 0xB58
		/// Size: 0x08
		/// </summary>
		public U00_BP_AC_BuffSystem_C _00_BP_AC_BuffSystem => ReadUObject<U00_BP_AC_BuffSystem_C>(0xB58);
		
		/// <summary>
		/// Name: BP_CollisionComponent
		/// Type: ObjectProperty
		/// Offset: 0xB60
		/// Size: 0x08
		/// </summary>
		public UBP_CollisionComponent_C BP_CollisionComponent => ReadUObject<UBP_CollisionComponent_C>(0xB60);
		
		/// <summary>
		/// Name: WeaponCollisionFollow
		/// Type: ObjectProperty
		/// Offset: 0xB68
		/// Size: 0x08
		/// </summary>
		public UBoxComponent WeaponCollisionFollow => ReadUObject<UBoxComponent>(0xB68);
		
		/// <summary>
		/// Name: ReligionData
		/// Type: ObjectProperty
		/// Offset: 0xB70
		/// Size: 0x08
		/// </summary>
		public UReligionData_C ReligionData => ReadUObject<UReligionData_C>(0xB70);
		
		/// <summary>
		/// Name: HitBlendWeightTimeline_Value_FBCD72D64539C6F4714C1ABEA6DBDC00
		/// Type: FloatProperty
		/// Offset: 0xB78
		/// Size: 0x04
		/// </summary>
		public float HitBlendWeightTimeline_Value_FBCD72D64539C6F4714C1ABEA6DBDC00
		{
			get
			{
				return ReadSingle(0xB78);
			}
			set
			{
				WriteSingle(0xB78,value);
			}
		}
		
		/// <summary>
		/// Name: HitBlendWeightTimeline__Direction_FBCD72D64539C6F4714C1ABEA6DBDC00
		/// Type: ByteProperty
		/// Offset: 0xB7C
		/// Size: 0x01
		/// </summary>
		public byte HitBlendWeightTimeline__Direction_FBCD72D64539C6F4714C1ABEA6DBDC00
		{
			get
			{
				return ReadByte(0xB7C);
			}
			set
			{
				WriteByte(0xB7C,value);
			}
		}
		
		/// <summary>
		/// Name: HitBlendWeightTimeline
		/// Type: ObjectProperty
		/// Offset: 0xB80
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent HitBlendWeightTimeline => ReadUObject<UTimelineComponent>(0xB80);
		
		/// <summary>
		/// Name: StaminaCurrent
		/// Type: IntProperty
		/// Offset: 0xB88
		/// Size: 0x04
		/// </summary>
		public int StaminaCurrent
		{
			get
			{
				return ReadInt32(0xB88);
			}
			set
			{
				WriteInt32(0xB88,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaMax
		/// Type: IntProperty
		/// Offset: 0xB8C
		/// Size: 0x04
		/// </summary>
		public int StaminaMax
		{
			get
			{
				return ReadInt32(0xB8C);
			}
			set
			{
				WriteInt32(0xB8C,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaRegenCharStationary
		/// Type: FloatProperty
		/// Offset: 0xB90
		/// Size: 0x04
		/// </summary>
		public float StaminaRegenCharStationary
		{
			get
			{
				return ReadSingle(0xB90);
			}
			set
			{
				WriteSingle(0xB90,value);
			}
		}
		
		/// <summary>
		/// Name: HealthRegen
		/// Type: FloatProperty
		/// Offset: 0xB94
		/// Size: 0x04
		/// </summary>
		public float HealthRegen
		{
			get
			{
				return ReadSingle(0xB94);
			}
			set
			{
				WriteSingle(0xB94,value);
			}
		}
		
		/// <summary>
		/// Name: HealthDamageOnHit
		/// Type: IntProperty
		/// Offset: 0xB98
		/// Size: 0x04
		/// </summary>
		public int HealthDamageOnHit
		{
			get
			{
				return ReadInt32(0xB98);
			}
			set
			{
				WriteInt32(0xB98,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaDamageOnHit
		/// Type: IntProperty
		/// Offset: 0xB9C
		/// Size: 0x04
		/// </summary>
		public int StaminaDamageOnHit
		{
			get
			{
				return ReadInt32(0xB9C);
			}
			set
			{
				WriteInt32(0xB9C,value);
			}
		}
		
		/// <summary>
		/// Name: HealthDamageOnBlock
		/// Type: IntProperty
		/// Offset: 0xBA0
		/// Size: 0x04
		/// </summary>
		public int HealthDamageOnBlock
		{
			get
			{
				return ReadInt32(0xBA0);
			}
			set
			{
				WriteInt32(0xBA0,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaDamageOnBlock
		/// Type: IntProperty
		/// Offset: 0xBA4
		/// Size: 0x04
		/// </summary>
		public int StaminaDamageOnBlock
		{
			get
			{
				return ReadInt32(0xBA4);
			}
			set
			{
				WriteInt32(0xBA4,value);
			}
		}
		
		/// <summary>
		/// Name: ConeMaxDistance
		/// Type: FloatProperty
		/// Offset: 0xBA8
		/// Size: 0x04
		/// </summary>
		public float ConeMaxDistance
		{
			get
			{
				return ReadSingle(0xBA8);
			}
			set
			{
				WriteSingle(0xBA8,value);
			}
		}
		
		/// <summary>
		/// Name: ConeAngle
		/// Type: FloatProperty
		/// Offset: 0xBAC
		/// Size: 0x04
		/// </summary>
		public float ConeAngle
		{
			get
			{
				return ReadSingle(0xBAC);
			}
			set
			{
				WriteSingle(0xBAC,value);
			}
		}
		
		/// <summary>
		/// Name: SimpleAttackHit
		/// Type: BoolProperty
		/// Offset: 0xBB0
		/// Size: 0x01
		/// </summary>
		public bool SimpleAttackHit
		{
			get
			{
				return ReadBool(0xBB0);
			}
			set
			{
				WriteBool(0xBB0,value);
			}
		}
		
		/// <summary>
		/// Name: PrimaryActionHold
		/// Type: BoolProperty
		/// Offset: 0xBB1
		/// Size: 0x01
		/// </summary>
		public bool PrimaryActionHold
		{
			get
			{
				return ReadBool(0xBB1);
			}
			set
			{
				WriteBool(0xBB1,value);
			}
		}
		
		/// <summary>
		/// Name: Defending
		/// Type: BoolProperty
		/// Offset: 0xBB2
		/// Size: 0x01
		/// </summary>
		public bool Defending
		{
			get
			{
				return ReadBool(0xBB2);
			}
			set
			{
				WriteBool(0xBB2,value);
			}
		}
		
		/// <summary>
		/// Name: WasBlocked
		/// Type: BoolProperty
		/// Offset: 0xBB3
		/// Size: 0x01
		/// </summary>
		public bool WasBlocked
		{
			get
			{
				return ReadBool(0xBB3);
			}
			set
			{
				WriteBool(0xBB3,value);
			}
		}
		
		/// <summary>
		/// Name: SecondaryActionHold
		/// Type: BoolProperty
		/// Offset: 0xBB4
		/// Size: 0x01
		/// </summary>
		public bool SecondaryActionHold
		{
			get
			{
				return ReadBool(0xBB4);
			}
			set
			{
				WriteBool(0xBB4,value);
			}
		}
		
		/// <summary>
		/// Name: InThirdPerson
		/// Type: BoolProperty
		/// Offset: 0xBB5
		/// Size: 0x01
		/// </summary>
		public bool InThirdPerson
		{
			get
			{
				return ReadBool(0xBB5);
			}
			set
			{
				WriteBool(0xBB5,value);
			}
		}
		
		/// <summary>
		/// Name: CanQueueAttack
		/// Type: BoolProperty
		/// Offset: 0xBB6
		/// Size: 0x01
		/// </summary>
		public bool CanQueueAttack
		{
			get
			{
				return ReadBool(0xBB6);
			}
			set
			{
				WriteBool(0xBB6,value);
			}
		}
		
		/// <summary>
		/// Name: AttackType
		/// Type: ByteProperty
		/// Offset: 0xBB7
		/// Size: 0x01
		/// </summary>
		public byte AttackType
		{
			get
			{
				return ReadByte(0xBB7);
			}
			set
			{
				WriteByte(0xBB7,value);
			}
		}
		
		/// <summary>
		/// Name: DevTriggerQ
		/// Type: BoolProperty
		/// Offset: 0xBB8
		/// Size: 0x01
		/// </summary>
		public bool DevTriggerQ
		{
			get
			{
				return ReadBool(0xBB8);
			}
			set
			{
				WriteBool(0xBB8,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackDirection
		/// Type: ByteProperty
		/// Offset: 0xBB9
		/// Size: 0x01
		/// </summary>
		public byte KnockbackDirection
		{
			get
			{
				return ReadByte(0xBB9);
			}
			set
			{
				WriteByte(0xBB9,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackPower
		/// Type: ByteProperty
		/// Offset: 0xBBA
		/// Size: 0x01
		/// </summary>
		public byte KnockbackPower
		{
			get
			{
				return ReadByte(0xBBA);
			}
			set
			{
				WriteByte(0xBBA,value);
			}
		}
		
		/// <summary>
		/// Name: ArmorTargetConstant
		/// Type: FloatProperty
		/// Offset: 0xBBC
		/// Size: 0x04
		/// </summary>
		public float ArmorTargetConstant
		{
			get
			{
				return ReadSingle(0xBBC);
			}
			set
			{
				WriteSingle(0xBBC,value);
			}
		}
		
		/// <summary>
		/// Name: HealthAccumulation
		/// Type: FloatProperty
		/// Offset: 0xBC0
		/// Size: 0x04
		/// </summary>
		public float HealthAccumulation
		{
			get
			{
				return ReadSingle(0xBC0);
			}
			set
			{
				WriteSingle(0xBC0,value);
			}
		}
		
		/// <summary>
		/// Name: PreyRank
		/// Type: IntProperty
		/// Offset: 0xBC4
		/// Size: 0x04
		/// </summary>
		public int PreyRank
		{
			get
			{
				return ReadInt32(0xBC4);
			}
			set
			{
				WriteInt32(0xBC4,value);
			}
		}
		
		/// <summary>
		/// Name: IsCombatMode
		/// Type: BoolProperty
		/// Offset: 0xBC8
		/// Size: 0x01
		/// </summary>
		public bool IsCombatMode
		{
			get
			{
				return ReadBool(0xBC8);
			}
			set
			{
				WriteBool(0xBC8,value);
			}
		}
		
		/// <summary>
		/// Name: FallStatus
		/// Type: BoolProperty
		/// Offset: 0xBC9
		/// Size: 0x01
		/// </summary>
		public bool FallStatus
		{
			get
			{
				return ReadBool(0xBC9);
			}
			set
			{
				WriteBool(0xBC9,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaExhusted
		/// Type: BoolProperty
		/// Offset: 0xBCA
		/// Size: 0x01
		/// </summary>
		public bool StaminaExhusted
		{
			get
			{
				return ReadBool(0xBCA);
			}
			set
			{
				WriteBool(0xBCA,value);
			}
		}
		
		/// <summary>
		/// Name: SprintSpeedModifier
		/// Type: FloatProperty
		/// Offset: 0xBCC
		/// Size: 0x04
		/// </summary>
		public float SprintSpeedModifier
		{
			get
			{
				return ReadSingle(0xBCC);
			}
			set
			{
				WriteSingle(0xBCC,value);
			}
		}
		
		/// <summary>
		/// Name: SprintStaminaCost
		/// Type: FloatProperty
		/// Offset: 0xBD0
		/// Size: 0x04
		/// </summary>
		public float SprintStaminaCost
		{
			get
			{
				return ReadSingle(0xBD0);
			}
			set
			{
				WriteSingle(0xBD0,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaExhustedDuration
		/// Type: FloatProperty
		/// Offset: 0xBD4
		/// Size: 0x04
		/// </summary>
		public float StaminaExhustedDuration
		{
			get
			{
				return ReadSingle(0xBD4);
			}
			set
			{
				WriteSingle(0xBD4,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaAccumulation
		/// Type: FloatProperty
		/// Offset: 0xBE8
		/// Size: 0x04
		/// </summary>
		public float StaminaAccumulation
		{
			get
			{
				return ReadSingle(0xBE8);
			}
			set
			{
				WriteSingle(0xBE8,value);
			}
		}
		
		/// <summary>
		/// Name: HealthRegenInterrupted
		/// Type: BoolProperty
		/// Offset: 0xC00
		/// Size: 0x01
		/// </summary>
		public bool HealthRegenInterrupted
		{
			get
			{
				return ReadBool(0xC00);
			}
			set
			{
				WriteBool(0xC00,value);
			}
		}
		
		/// <summary>
		/// Name: HealthRegenInterruptedDuration
		/// Type: FloatProperty
		/// Offset: 0xC04
		/// Size: 0x04
		/// </summary>
		public float HealthRegenInterruptedDuration
		{
			get
			{
				return ReadSingle(0xC04);
			}
			set
			{
				WriteSingle(0xC04,value);
			}
		}
		
		/// <summary>
		/// Name: TurnRight
		/// Type: BoolProperty
		/// Offset: 0xC08
		/// Size: 0x01
		/// </summary>
		public bool TurnRight
		{
			get
			{
				return ReadBool(0xC08);
			}
			set
			{
				WriteBool(0xC08,value);
			}
		}
		
		/// <summary>
		/// Name: TurnLeft
		/// Type: BoolProperty
		/// Offset: 0xC09
		/// Size: 0x01
		/// </summary>
		public bool TurnLeft
		{
			get
			{
				return ReadBool(0xC09);
			}
			set
			{
				WriteBool(0xC09,value);
			}
		}
		
		/// <summary>
		/// Name: EquipTrigger
		/// Type: BoolProperty
		/// Offset: 0xC0A
		/// Size: 0x01
		/// </summary>
		public bool EquipTrigger
		{
			get
			{
				return ReadBool(0xC0A);
			}
			set
			{
				WriteBool(0xC0A,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultHealth
		/// Type: IntProperty
		/// Offset: 0xC20
		/// Size: 0x04
		/// </summary>
		public int DefaultHealth
		{
			get
			{
				return ReadInt32(0xC20);
			}
			set
			{
				WriteInt32(0xC20,value);
			}
		}
		
		/// <summary>
		/// Name: TriggerSecondaryByPrimary
		/// Type: BoolProperty
		/// Offset: 0xC48
		/// Size: 0x01
		/// </summary>
		public bool TriggerSecondaryByPrimary
		{
			get
			{
				return ReadBool(0xC48);
			}
			set
			{
				WriteBool(0xC48,value);
			}
		}
		
		/// <summary>
		/// Name: TriggerPrimaryBySecondary
		/// Type: BoolProperty
		/// Offset: 0xC49
		/// Size: 0x01
		/// </summary>
		public bool TriggerPrimaryBySecondary
		{
			get
			{
				return ReadBool(0xC49);
			}
			set
			{
				WriteBool(0xC49,value);
			}
		}
		
		/// <summary>
		/// Name: StartFallHeight
		/// Type: FloatProperty
		/// Offset: 0xC4C
		/// Size: 0x04
		/// </summary>
		public float StartFallHeight
		{
			get
			{
				return ReadSingle(0xC4C);
			}
			set
			{
				WriteSingle(0xC4C,value);
			}
		}
		
		/// <summary>
		/// Name: EndFallHeight
		/// Type: FloatProperty
		/// Offset: 0xC50
		/// Size: 0x04
		/// </summary>
		public float EndFallHeight
		{
			get
			{
				return ReadSingle(0xC50);
			}
			set
			{
				WriteSingle(0xC50,value);
			}
		}
		
		/// <summary>
		/// Name: SafeFallDistance
		/// Type: FloatProperty
		/// Offset: 0xC54
		/// Size: 0x04
		/// </summary>
		public float SafeFallDistance
		{
			get
			{
				return ReadSingle(0xC54);
			}
			set
			{
				WriteSingle(0xC54,value);
			}
		}
		
		/// <summary>
		/// Name: DeadlyFallDistance
		/// Type: FloatProperty
		/// Offset: 0xC58
		/// Size: 0x04
		/// </summary>
		public float DeadlyFallDistance
		{
			get
			{
				return ReadSingle(0xC58);
			}
			set
			{
				WriteSingle(0xC58,value);
			}
		}
		
		/// <summary>
		/// Name: FallDistance
		/// Type: FloatProperty
		/// Offset: 0xC5C
		/// Size: 0x04
		/// </summary>
		public float FallDistance
		{
			get
			{
				return ReadSingle(0xC5C);
			}
			set
			{
				WriteSingle(0xC5C,value);
			}
		}
		
		/// <summary>
		/// Name: FallDamagePercent
		/// Type: FloatProperty
		/// Offset: 0xC60
		/// Size: 0x04
		/// </summary>
		public float FallDamagePercent
		{
			get
			{
				return ReadSingle(0xC60);
			}
			set
			{
				WriteSingle(0xC60,value);
			}
		}
		
		/// <summary>
		/// Name: DeadlyFallVelocity
		/// Type: FloatProperty
		/// Offset: 0xC64
		/// Size: 0x04
		/// </summary>
		public float DeadlyFallVelocity
		{
			get
			{
				return ReadSingle(0xC64);
			}
			set
			{
				WriteSingle(0xC64,value);
			}
		}
		
		/// <summary>
		/// Name: MinDamageVelocity
		/// Type: FloatProperty
		/// Offset: 0xC68
		/// Size: 0x04
		/// </summary>
		public float MinDamageVelocity
		{
			get
			{
				return ReadSingle(0xC68);
			}
			set
			{
				WriteSingle(0xC68,value);
			}
		}
		
		/// <summary>
		/// Name: FallDamageInPercentofMaxHealth
		/// Type: FloatProperty
		/// Offset: 0xC6C
		/// Size: 0x04
		/// </summary>
		public float FallDamageInPercentofMaxHealth
		{
			get
			{
				return ReadSingle(0xC6C);
			}
			set
			{
				WriteSingle(0xC6C,value);
			}
		}
		
		/// <summary>
		/// Name: CapsuleRootOffset
		/// Type: FloatProperty
		/// Offset: 0xC70
		/// Size: 0x04
		/// </summary>
		public float CapsuleRootOffset
		{
			get
			{
				return ReadSingle(0xC70);
			}
			set
			{
				WriteSingle(0xC70,value);
			}
		}
		
		/// <summary>
		/// Name: RightfootIK
		/// Type: StructProperty
		/// Offset: 0xC74
		/// Size: 0x0C
		/// </summary>
		public FVector RightfootIK => ReadStruct<FVector>(0xC74);
		
		/// <summary>
		/// Name: RightFootHit
		/// Type: BoolProperty
		/// Offset: 0xC80
		/// Size: 0x01
		/// </summary>
		public bool RightFootHit
		{
			get
			{
				return ReadBool(0xC80);
			}
			set
			{
				WriteBool(0xC80,value);
			}
		}
		
		/// <summary>
		/// Name: rightfootAlpha
		/// Type: FloatProperty
		/// Offset: 0xC84
		/// Size: 0x04
		/// </summary>
		public float rightfootAlpha
		{
			get
			{
				return ReadSingle(0xC84);
			}
			set
			{
				WriteSingle(0xC84,value);
			}
		}
		
		/// <summary>
		/// Name: LeftfootIK
		/// Type: StructProperty
		/// Offset: 0xC88
		/// Size: 0x0C
		/// </summary>
		public FVector LeftfootIK => ReadStruct<FVector>(0xC88);
		
		/// <summary>
		/// Name: LeftFootHit
		/// Type: BoolProperty
		/// Offset: 0xC94
		/// Size: 0x01
		/// </summary>
		public bool LeftFootHit
		{
			get
			{
				return ReadBool(0xC94);
			}
			set
			{
				WriteBool(0xC94,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFootAlpha
		/// Type: FloatProperty
		/// Offset: 0xC98
		/// Size: 0x04
		/// </summary>
		public float LeftFootAlpha
		{
			get
			{
				return ReadSingle(0xC98);
			}
			set
			{
				WriteSingle(0xC98,value);
			}
		}
		
		/// <summary>
		/// Name: HipOffset
		/// Type: FloatProperty
		/// Offset: 0xC9C
		/// Size: 0x04
		/// </summary>
		public float HipOffset
		{
			get
			{
				return ReadSingle(0xC9C);
			}
			set
			{
				WriteSingle(0xC9C,value);
			}
		}
		
		/// <summary>
		/// Name: TurnDirection
		/// Type: IntProperty
		/// Offset: 0xCB0
		/// Size: 0x04
		/// </summary>
		public int TurnDirection
		{
			get
			{
				return ReadInt32(0xCB0);
			}
			set
			{
				WriteInt32(0xCB0,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveBaseSpeed
		/// Type: FloatProperty
		/// Offset: 0xCB4
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveBaseSpeed
		{
			get
			{
				return ReadSingle(0xCB4);
			}
			set
			{
				WriteSingle(0xCB4,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveMultiplierGlobal
		/// Type: FloatProperty
		/// Offset: 0xCB8
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveMultiplierGlobal
		{
			get
			{
				return ReadSingle(0xCB8);
			}
			set
			{
				WriteSingle(0xCB8,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveMultiplierSprint
		/// Type: FloatProperty
		/// Offset: 0xCBC
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveMultiplierSprint
		{
			get
			{
				return ReadSingle(0xCBC);
			}
			set
			{
				WriteSingle(0xCBC,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveMultiplierFront
		/// Type: FloatProperty
		/// Offset: 0xCC0
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveMultiplierFront
		{
			get
			{
				return ReadSingle(0xCC0);
			}
			set
			{
				WriteSingle(0xCC0,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveMultiplierSide
		/// Type: FloatProperty
		/// Offset: 0xCC4
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveMultiplierSide
		{
			get
			{
				return ReadSingle(0xCC4);
			}
			set
			{
				WriteSingle(0xCC4,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedPassiveMultiplierBack
		/// Type: FloatProperty
		/// Offset: 0xCC8
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedPassiveMultiplierBack
		{
			get
			{
				return ReadSingle(0xCC8);
			}
			set
			{
				WriteSingle(0xCC8,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveBaseSpeed
		/// Type: FloatProperty
		/// Offset: 0xCCC
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveBaseSpeed
		{
			get
			{
				return ReadSingle(0xCCC);
			}
			set
			{
				WriteSingle(0xCCC,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveMultiplierGlobal
		/// Type: FloatProperty
		/// Offset: 0xCD0
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveMultiplierGlobal
		{
			get
			{
				return ReadSingle(0xCD0);
			}
			set
			{
				WriteSingle(0xCD0,value);
			}
		}
		
		/// <summary>
		/// Name: ConcussiveRegenInterrupted
		/// Type: BoolProperty
		/// Offset: 0xCD4
		/// Size: 0x01
		/// </summary>
		public bool ConcussiveRegenInterrupted
		{
			get
			{
				return ReadBool(0xCD4);
			}
			set
			{
				WriteBool(0xCD4,value);
			}
		}
		
		/// <summary>
		/// Name: ConcussiveRegen
		/// Type: FloatProperty
		/// Offset: 0xCD8
		/// Size: 0x04
		/// </summary>
		public float ConcussiveRegen
		{
			get
			{
				return ReadSingle(0xCD8);
			}
			set
			{
				WriteSingle(0xCD8,value);
			}
		}
		
		/// <summary>
		/// Name: ConcussiveAccumulation
		/// Type: FloatProperty
		/// Offset: 0xCDC
		/// Size: 0x04
		/// </summary>
		public float ConcussiveAccumulation
		{
			get
			{
				return ReadSingle(0xCDC);
			}
			set
			{
				WriteSingle(0xCDC,value);
			}
		}
		
		/// <summary>
		/// Name: CanLoseDurabilityWeapon
		/// Type: BoolProperty
		/// Offset: 0xD20
		/// Size: 0x01
		/// </summary>
		public bool CanLoseDurabilityWeapon
		{
			get
			{
				return ReadBool(0xD20);
			}
			set
			{
				WriteBool(0xD20,value);
			}
		}
		
		/// <summary>
		/// Name: CanLoseDurabilityShield
		/// Type: BoolProperty
		/// Offset: 0xD21
		/// Size: 0x01
		/// </summary>
		public bool CanLoseDurabilityShield
		{
			get
			{
				return ReadBool(0xD21);
			}
			set
			{
				WriteBool(0xD21,value);
			}
		}
		
		/// <summary>
		/// Name: isWalk
		/// Type: BoolProperty
		/// Offset: 0xD22
		/// Size: 0x01
		/// </summary>
		public bool isWalk
		{
			get
			{
				return ReadBool(0xD22);
			}
			set
			{
				WriteBool(0xD22,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultStamina
		/// Type: IntProperty
		/// Offset: 0xD24
		/// Size: 0x04
		/// </summary>
		public int DefaultStamina
		{
			get
			{
				return ReadInt32(0xD24);
			}
			set
			{
				WriteInt32(0xD24,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaJumpCost
		/// Type: IntProperty
		/// Offset: 0xD28
		/// Size: 0x04
		/// </summary>
		public int StaminaJumpCost
		{
			get
			{
				return ReadInt32(0xD28);
			}
			set
			{
				WriteInt32(0xD28,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveMultiplierSprint
		/// Type: FloatProperty
		/// Offset: 0xD2C
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveMultiplierSprint
		{
			get
			{
				return ReadSingle(0xD2C);
			}
			set
			{
				WriteSingle(0xD2C,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveMultiplierFront
		/// Type: FloatProperty
		/// Offset: 0xD30
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveMultiplierFront
		{
			get
			{
				return ReadSingle(0xD30);
			}
			set
			{
				WriteSingle(0xD30,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveMultiplierSide
		/// Type: FloatProperty
		/// Offset: 0xD34
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveMultiplierSide
		{
			get
			{
				return ReadSingle(0xD34);
			}
			set
			{
				WriteSingle(0xD34,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedAggressiveMultiplierBack
		/// Type: FloatProperty
		/// Offset: 0xD38
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedAggressiveMultiplierBack
		{
			get
			{
				return ReadSingle(0xD38);
			}
			set
			{
				WriteSingle(0xD38,value);
			}
		}
		
		/// <summary>
		/// Name: isMovementSprint
		/// Type: BoolProperty
		/// Offset: 0xD3C
		/// Size: 0x01
		/// </summary>
		public bool isMovementSprint
		{
			get
			{
				return ReadBool(0xD3C);
			}
			set
			{
				WriteBool(0xD3C,value);
			}
		}
		
		/// <summary>
		/// Name: isMovementFront
		/// Type: BoolProperty
		/// Offset: 0xD3D
		/// Size: 0x01
		/// </summary>
		public bool isMovementFront
		{
			get
			{
				return ReadBool(0xD3D);
			}
			set
			{
				WriteBool(0xD3D,value);
			}
		}
		
		/// <summary>
		/// Name: isMovementSide
		/// Type: BoolProperty
		/// Offset: 0xD3E
		/// Size: 0x01
		/// </summary>
		public bool isMovementSide
		{
			get
			{
				return ReadBool(0xD3E);
			}
			set
			{
				WriteBool(0xD3E,value);
			}
		}
		
		/// <summary>
		/// Name: isMovementBack
		/// Type: BoolProperty
		/// Offset: 0xD3F
		/// Size: 0x01
		/// </summary>
		public bool isMovementBack
		{
			get
			{
				return ReadBool(0xD3F);
			}
			set
			{
				WriteBool(0xD3F,value);
			}
		}
		
		/// <summary>
		/// Name: IsSprinting
		/// Type: BoolProperty
		/// Offset: 0xD40
		/// Size: 0x01
		/// </summary>
		public bool IsSprinting
		{
			get
			{
				return ReadBool(0xD40);
			}
			set
			{
				WriteBool(0xD40,value);
			}
		}
		
		/// <summary>
		/// Name: isSprintStaminaCostAffected
		/// Type: BoolProperty
		/// Offset: 0xD41
		/// Size: 0x01
		/// </summary>
		public bool isSprintStaminaCostAffected
		{
			get
			{
				return ReadBool(0xD41);
			}
			set
			{
				WriteBool(0xD41,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkBaseSpeed
		/// Type: FloatProperty
		/// Offset: 0xD44
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkBaseSpeed
		{
			get
			{
				return ReadSingle(0xD44);
			}
			set
			{
				WriteSingle(0xD44,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkMultiplierGlobal
		/// Type: FloatProperty
		/// Offset: 0xD48
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkMultiplierGlobal
		{
			get
			{
				return ReadSingle(0xD48);
			}
			set
			{
				WriteSingle(0xD48,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkMultiplierBack
		/// Type: FloatProperty
		/// Offset: 0xD4C
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkMultiplierBack
		{
			get
			{
				return ReadSingle(0xD4C);
			}
			set
			{
				WriteSingle(0xD4C,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkMultiplierSide
		/// Type: FloatProperty
		/// Offset: 0xD50
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkMultiplierSide
		{
			get
			{
				return ReadSingle(0xD50);
			}
			set
			{
				WriteSingle(0xD50,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkMultiplierFront
		/// Type: FloatProperty
		/// Offset: 0xD54
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkMultiplierFront
		{
			get
			{
				return ReadSingle(0xD54);
			}
			set
			{
				WriteSingle(0xD54,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedWalkMultiplierSprint
		/// Type: FloatProperty
		/// Offset: 0xD58
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedWalkMultiplierSprint
		{
			get
			{
				return ReadSingle(0xD58);
			}
			set
			{
				WriteSingle(0xD58,value);
			}
		}
		
		/// <summary>
		/// Name: RightFistTemplateID
		/// Type: IntProperty
		/// Offset: 0xD5C
		/// Size: 0x04
		/// </summary>
		public int RightFistTemplateID
		{
			get
			{
				return ReadInt32(0xD5C);
			}
			set
			{
				WriteInt32(0xD5C,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFistTemplateID
		/// Type: IntProperty
		/// Offset: 0xD60
		/// Size: 0x04
		/// </summary>
		public int LeftFistTemplateID
		{
			get
			{
				return ReadInt32(0xD60);
			}
			set
			{
				WriteInt32(0xD60,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaExhustedClientNotification
		/// Type: TextProperty
		/// Offset: 0xD68
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: KnockbackDefense
		/// Type: IntProperty
		/// Offset: 0xD80
		/// Size: 0x04
		/// </summary>
		public int KnockbackDefense
		{
			get
			{
				return ReadInt32(0xD80);
			}
			set
			{
				WriteInt32(0xD80,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaDegen
		/// Type: FloatProperty
		/// Offset: 0xD84
		/// Size: 0x04
		/// </summary>
		public float StaminaDegen
		{
			get
			{
				return ReadSingle(0xD84);
			}
			set
			{
				WriteSingle(0xD84,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaRegenPositive
		/// Type: BoolProperty
		/// Offset: 0xD88
		/// Size: 0x01
		/// </summary>
		public bool StaminaRegenPositive
		{
			get
			{
				return ReadBool(0xD88);
			}
			set
			{
				WriteBool(0xD88,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaDegenStack
		/// Type: IntProperty
		/// Offset: 0xD8C
		/// Size: 0x04
		/// </summary>
		public int StaminaDegenStack
		{
			get
			{
				return ReadInt32(0xD8C);
			}
			set
			{
				WriteInt32(0xD8C,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaDegenerationSourceBitmask
		/// Type: IntProperty
		/// Offset: 0xDA0
		/// Size: 0x04
		/// </summary>
		public int StaminaDegenerationSourceBitmask
		{
			get
			{
				return ReadInt32(0xDA0);
			}
			set
			{
				WriteInt32(0xDA0,value);
			}
		}
		
		/// <summary>
		/// Name: AttackMontageQueued
		/// Type: ObjectProperty
		/// Offset: 0xDA8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontageQueued => ReadUObject<UAnimMontage>(0xDA8);
		
		/// <summary>
		/// Name: AttackMontagePrevious
		/// Type: ObjectProperty
		/// Offset: 0xDB0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontagePrevious => ReadUObject<UAnimMontage>(0xDB0);
		
		/// <summary>
		/// Name: AttackMontageActive
		/// Type: ObjectProperty
		/// Offset: 0xDB8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontageActive => ReadUObject<UAnimMontage>(0xDB8);
		
		/// <summary>
		/// Name: RandomSeed
		/// Type: IntProperty
		/// Offset: 0xDC0
		/// Size: 0x04
		/// </summary>
		public int RandomSeed
		{
			get
			{
				return ReadInt32(0xDC0);
			}
			set
			{
				WriteInt32(0xDC0,value);
			}
		}
		
		/// <summary>
		/// Name: AttackAnimPackageActive
		/// Type: ObjectProperty
		/// Offset: 0xDC8
		/// Size: 0x08
		/// </summary>
		public UBP_AnimPackage_Base_C AttackAnimPackageActive => ReadUObject<UBP_AnimPackage_Base_C>(0xDC8);
		
		/// <summary>
		/// Name: ActionTypeActive
		/// Type: ByteProperty
		/// Offset: 0xDD0
		/// Size: 0x01
		/// </summary>
		public byte ActionTypeActive
		{
			get
			{
				return ReadByte(0xDD0);
			}
			set
			{
				WriteByte(0xDD0,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeStaminaCost
		/// Type: FloatProperty
		/// Offset: 0xDF8
		/// Size: 0x04
		/// </summary>
		public float DodgeStaminaCost
		{
			get
			{
				return ReadSingle(0xDF8);
			}
			set
			{
				WriteSingle(0xDF8,value);
			}
		}
		
		/// <summary>
		/// Name: IsHitBlending
		/// Type: BoolProperty
		/// Offset: 0xDFC
		/// Size: 0x01
		/// </summary>
		public bool IsHitBlending
		{
			get
			{
				return ReadBool(0xDFC);
			}
			set
			{
				WriteBool(0xDFC,value);
			}
		}
		
		/// <summary>
		/// Name: HitPhysicsBlendWeight
		/// Type: FloatProperty
		/// Offset: 0xE00
		/// Size: 0x04
		/// </summary>
		public float HitPhysicsBlendWeight
		{
			get
			{
				return ReadSingle(0xE00);
			}
			set
			{
				WriteSingle(0xE00,value);
			}
		}
		
		/// <summary>
		/// Name: AttackAnimPackageQueued
		/// Type: ObjectProperty
		/// Offset: 0xE18
		/// Size: 0x08
		/// </summary>
		public UBP_AnimPackage_Base_C AttackAnimPackageQueued => ReadUObject<UBP_AnimPackage_Base_C>(0xE18);
		
		/// <summary>
		/// Name: AttackAnimPackagePrevious
		/// Type: ObjectProperty
		/// Offset: 0xE20
		/// Size: 0x08
		/// </summary>
		public UBP_AnimPackage_Base_C AttackAnimPackagePrevious => ReadUObject<UBP_AnimPackage_Base_C>(0xE20);
		
		/// <summary>
		/// Name: ActionTypeQueued
		/// Type: ByteProperty
		/// Offset: 0xE28
		/// Size: 0x01
		/// </summary>
		public byte ActionTypeQueued
		{
			get
			{
				return ReadByte(0xE28);
			}
			set
			{
				WriteByte(0xE28,value);
			}
		}
		
		/// <summary>
		/// Name: ActionTypePrevious
		/// Type: ByteProperty
		/// Offset: 0xE29
		/// Size: 0x01
		/// </summary>
		public byte ActionTypePrevious
		{
			get
			{
				return ReadByte(0xE29);
			}
			set
			{
				WriteByte(0xE29,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaRecentlyConsumbed
		/// Type: BoolProperty
		/// Offset: 0xE2A
		/// Size: 0x01
		/// </summary>
		public bool StaminaRecentlyConsumbed
		{
			get
			{
				return ReadBool(0xE2A);
			}
			set
			{
				WriteBool(0xE2A,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaRecentlyConsumbedTimerHandle
		/// Type: StructProperty
		/// Offset: 0xE30
		/// Size: 0x08
		/// </summary>
		public FTimerHandle StaminaRecentlyConsumbedTimerHandle => ReadStruct<FTimerHandle>(0xE30);
		
		/// <summary>
		/// Name: StaminaRegenCharMoving
		/// Type: FloatProperty
		/// Offset: 0xE58
		/// Size: 0x04
		/// </summary>
		public float StaminaRegenCharMoving
		{
			get
			{
				return ReadSingle(0xE58);
			}
			set
			{
				WriteSingle(0xE58,value);
			}
		}
		
		/// <summary>
		/// Name: ProjectileLaunchLocation
		/// Type: StructProperty
		/// Offset: 0xE5C
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectileLaunchLocation => ReadStruct<FVector>(0xE5C);
		
		/// <summary>
		/// Name: ProjectileLaunchRotation
		/// Type: StructProperty
		/// Offset: 0xE68
		/// Size: 0x0C
		/// </summary>
		public FRotator ProjectileLaunchRotation => ReadStruct<FRotator>(0xE68);
		
		/// <summary>
		/// Name: ProjectileLaunchFromClient
		/// Type: BoolProperty
		/// Offset: 0xE74
		/// Size: 0x01
		/// </summary>
		public bool ProjectileLaunchFromClient
		{
			get
			{
				return ReadBool(0xE74);
			}
			set
			{
				WriteBool(0xE74,value);
			}
		}
		
		/// <summary>
		/// Name: ItemBreakGameItem
		/// Type: ObjectProperty
		/// Offset: 0xE98
		/// Size: 0x08
		/// </summary>
		public UBPGameItem_C ItemBreakGameItem => ReadUObject<UBPGameItem_C>(0xE98);
		
		/// <summary>
		/// Name: SceneCompToSitOn
		/// Type: ObjectProperty
		/// Offset: 0xEA0
		/// Size: 0x08
		/// </summary>
		public U00_BP_SC_Building_MasterSceneComponent_C SceneCompToSitOn => ReadUObject<U00_BP_SC_Building_MasterSceneComponent_C>(0xEA0);
		
		/// <summary>
		/// Name: SittingPoseToUse
		/// Type: ByteProperty
		/// Offset: 0xEA8
		/// Size: 0x01
		/// </summary>
		public byte SittingPoseToUse
		{
			get
			{
				return ReadByte(0xEA8);
			}
			set
			{
				WriteByte(0xEA8,value);
			}
		}
		
		/// <summary>
		/// Name: bIsAttacking
		/// Type: BoolProperty
		/// Offset: 0xEC0
		/// Size: 0x01
		/// </summary>
		public bool bIsAttacking
		{
			get
			{
				return ReadBool(0xEC0);
			}
			set
			{
				WriteBool(0xEC0,value);
			}
		}
		
		/// <summary>
		/// Name: MovementSpeedSnareMultiplier
		/// Type: FloatProperty
		/// Offset: 0xEC4
		/// Size: 0x04
		/// </summary>
		public float MovementSpeedSnareMultiplier
		{
			get
			{
				return ReadSingle(0xEC4);
			}
			set
			{
				WriteSingle(0xEC4,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultConsciousness
		/// Type: IntProperty
		/// Offset: 0xEC8
		/// Size: 0x04
		/// </summary>
		public int DefaultConsciousness
		{
			get
			{
				return ReadInt32(0xEC8);
			}
			set
			{
				WriteInt32(0xEC8,value);
			}
		}
		
		/// <summary>
		/// Name: ClientCameraLocation
		/// Type: StructProperty
		/// Offset: 0xECC
		/// Size: 0x0C
		/// </summary>
		public FVector ClientCameraLocation => ReadStruct<FVector>(0xECC);
		
		/// <summary>
		/// Name: ClientCameraRotation
		/// Type: StructProperty
		/// Offset: 0xED8
		/// Size: 0x0C
		/// </summary>
		public FRotator ClientCameraRotation => ReadStruct<FRotator>(0xED8);
		
		/// <summary>
		/// Name: ClientSocketLocation
		/// Type: StructProperty
		/// Offset: 0xEE4
		/// Size: 0x0C
		/// </summary>
		public FVector ClientSocketLocation => ReadStruct<FVector>(0xEE4);
		
		/// <summary>
		/// Name: ClientSocketRotation
		/// Type: StructProperty
		/// Offset: 0xEF0
		/// Size: 0x0C
		/// </summary>
		public FRotator ClientSocketRotation => ReadStruct<FRotator>(0xEF0);
		
		/// <summary>
		/// Name: ServerCameraLocation
		/// Type: StructProperty
		/// Offset: 0xEFC
		/// Size: 0x0C
		/// </summary>
		public FVector ServerCameraLocation => ReadStruct<FVector>(0xEFC);
		
		/// <summary>
		/// Name: ServerCameraRotation
		/// Type: StructProperty
		/// Offset: 0xF08
		/// Size: 0x0C
		/// </summary>
		public FRotator ServerCameraRotation => ReadStruct<FRotator>(0xF08);
		
		/// <summary>
		/// Name: ServerSocketLocation
		/// Type: StructProperty
		/// Offset: 0xF14
		/// Size: 0x0C
		/// </summary>
		public FVector ServerSocketLocation => ReadStruct<FVector>(0xF14);
		
		/// <summary>
		/// Name: ServerSocketRotation
		/// Type: StructProperty
		/// Offset: 0xF20
		/// Size: 0x0C
		/// </summary>
		public FRotator ServerSocketRotation => ReadStruct<FRotator>(0xF20);
		
		/// <summary>
		/// Name: ServerLaunchProjectileTimer
		/// Type: StructProperty
		/// Offset: 0xF30
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ServerLaunchProjectileTimer => ReadStruct<FTimerHandle>(0xF30);
		
		/// <summary>
		/// Name: ClientProjectileLaunchReceived
		/// Type: StructProperty
		/// Offset: 0xF38
		/// Size: 0x08
		/// </summary>
		public FDateTime ClientProjectileLaunchReceived => ReadStruct<FDateTime>(0xF38);
		
		/// <summary>
		/// Name: BacklogActionTimeStamp
		/// Type: StructProperty
		/// Offset: 0xF50
		/// Size: 0x08
		/// </summary>
		public FDateTime BacklogActionTimeStamp => ReadStruct<FDateTime>(0xF50);
		
		/// <summary>
		/// Name: BacklogActionAttackSource
		/// Type: ByteProperty
		/// Offset: 0xF58
		/// Size: 0x01
		/// </summary>
		public byte BacklogActionAttackSource
		{
			get
			{
				return ReadByte(0xF58);
			}
			set
			{
				WriteByte(0xF58,value);
			}
		}
		
		/// <summary>
		/// Name: ProjectileLaunched
		/// Type: BoolProperty
		/// Offset: 0xF59
		/// Size: 0x01
		/// </summary>
		public bool ProjectileLaunched
		{
			get
			{
				return ReadBool(0xF59);
			}
			set
			{
				WriteBool(0xF59,value);
			}
		}
		
	}


	/// <summary>
	/// UFuncomFunctionLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UFuncomFunctionLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABaseBPChar_C:AConanCharacter
	/// Size: 0xB29
	/// Properties: 22
	/// </summary>
	public class ABaseBPChar_C:AConanCharacter
	{
		public override int ObjectSize => 2857;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA60
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA60);
		
		/// <summary>
		/// Name: StatHolder
		/// Type: ObjectProperty
		/// Offset: 0xA68
		/// Size: 0x08
		/// </summary>
		public UStatHolder StatHolder => ReadUObject<UStatHolder>(0xA68);
		
		/// <summary>
		/// Name: VoiceAudioComp
		/// Type: ObjectProperty
		/// Offset: 0xA70
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent VoiceAudioComp => ReadUObject<UConanAudioComponent>(0xA70);
		
		/// <summary>
		/// Name: RightFootAudioComp
		/// Type: ObjectProperty
		/// Offset: 0xA78
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent RightFootAudioComp => ReadUObject<UConanAudioComponent>(0xA78);
		
		/// <summary>
		/// Name: LetfFootAudioComp
		/// Type: ObjectProperty
		/// Offset: 0xA80
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent LetfFootAudioComp => ReadUObject<UConanAudioComponent>(0xA80);
		
		/// <summary>
		/// Name: AIPerceptionStimuliSource
		/// Type: ObjectProperty
		/// Offset: 0xA88
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionStimuliSourceComponent AIPerceptionStimuliSource => ReadUObject<UAIPerceptionStimuliSourceComponent>(0xA88);
		
		/// <summary>
		/// Name: EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0xA90
		/// Size: 0x08
		/// </summary>
		public UEquipmentInventory EquipmentInventory => ReadUObject<UEquipmentInventory>(0xA90);
		
		/// <summary>
		/// Name: bJumpButtonDown
		/// Type: BoolProperty
		/// Offset: 0xA98
		/// Size: 0x01
		/// </summary>
		public bool bJumpButtonDown
		{
			get
			{
				return ReadBool(0xA98);
			}
			set
			{
				WriteBool(0xA98,value);
			}
		}
		
		/// <summary>
		/// Name: IsNPC
		/// Type: BoolProperty
		/// Offset: 0xA99
		/// Size: 0x01
		/// </summary>
		public bool IsNPC
		{
			get
			{
				return ReadBool(0xA99);
			}
			set
			{
				WriteBool(0xA99,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterState
		/// Type: ByteProperty
		/// Offset: 0xA9A
		/// Size: 0x01
		/// </summary>
		public byte CharacterState
		{
			get
			{
				return ReadByte(0xA9A);
			}
			set
			{
				WriteByte(0xA9A,value);
			}
		}
		
		/// <summary>
		/// Name: SubstateList
		/// Type: TArray<>
		/// Offset: 0xAA0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: NetworkedControlRotation
		/// Type: StructProperty
		/// Offset: 0xAB0
		/// Size: 0x0C
		/// </summary>
		public FRotator NetworkedControlRotation => ReadStruct<FRotator>(0xAB0);
		
		/// <summary>
		/// Name: SystemTickRate
		/// Type: FloatProperty
		/// Offset: 0xABC
		/// Size: 0x04
		/// </summary>
		public float SystemTickRate
		{
			get
			{
				return ReadSingle(0xABC);
			}
			set
			{
				WriteSingle(0xABC,value);
			}
		}
		
		/// <summary>
		/// Name: community
		/// Type: IntProperty
		/// Offset: 0xAC0
		/// Size: 0x04
		/// </summary>
		public int community
		{
			get
			{
				return ReadInt32(0xAC0);
			}
			set
			{
				WriteInt32(0xAC0,value);
			}
		}
		
		/// <summary>
		/// Name: FootstepType
		/// Type: ByteProperty
		/// Offset: 0xAC4
		/// Size: 0x01
		/// </summary>
		public byte FootstepType
		{
			get
			{
				return ReadByte(0xAC4);
			}
			set
			{
				WriteByte(0xAC4,value);
			}
		}
		
		/// <summary>
		/// Name: VoiceSet
		/// Type: ByteProperty
		/// Offset: 0xAC5
		/// Size: 0x01
		/// </summary>
		public byte VoiceSet
		{
			get
			{
				return ReadByte(0xAC5);
			}
			set
			{
				WriteByte(0xAC5,value);
			}
		}
		
		/// <summary>
		/// Name: TimerHandle
		/// Type: StructProperty
		/// Offset: 0xAC8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle TimerHandle => ReadStruct<FTimerHandle>(0xAC8);
		
		/// <summary>
		/// Name: SubstateRules
		/// Type: TArray<FST_SubstateRuleMaster>
		/// Offset: 0xAD0
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<FST_SubstateRuleMaster> SubstateRules => new TArray<FST_SubstateRuleMaster>(BaseAddress+0xAD0);
		
		/// <summary>
		/// Name: VoiceSetPitch
		/// Type: FloatProperty
		/// Offset: 0xB00
		/// Size: 0x04
		/// </summary>
		public float VoiceSetPitch
		{
			get
			{
				return ReadSingle(0xB00);
			}
			set
			{
				WriteSingle(0xB00,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterName
		/// Type: StrProperty
		/// Offset: 0xB08
		/// Size: 0x10
		/// </summary>
		public FString CharacterName => new FString(BaseAddress+0xB08);
		
		/// <summary>
		/// Name: PlayerName
		/// Type: StrProperty
		/// Offset: 0xB18
		/// Size: 0x10
		/// </summary>
		public FString PlayerName => new FString(BaseAddress+0xB18);
		
		/// <summary>
		/// Name: CauseOfDeath
		/// Type: ByteProperty
		/// Offset: 0xB28
		/// Size: 0x01
		/// </summary>
		public byte CauseOfDeath
		{
			get
			{
				return ReadByte(0xB28);
			}
			set
			{
				WriteByte(0xB28,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_NPCCharacterInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_NPCCharacterInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UHUDNotification_Interface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UHUDNotification_Interface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_ProjectileWeaponAimingInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_ProjectileWeaponAimingInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USurvivalFunctionLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USurvivalFunctionLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABaseNPC_C:ABaseBPCombat_C
	/// Size: 0x10E4
	/// Properties: 78
	/// </summary>
	public class ABaseNPC_C:ABaseBPCombat_C
	{
		public override int ObjectSize => 4324;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF60
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF60);
		
		/// <summary>
		/// Name: backpackInventory
		/// Type: ObjectProperty
		/// Offset: 0xF68
		/// Size: 0x08
		/// </summary>
		public UItemInventory backpackInventory => ReadUObject<UItemInventory>(0xF68);
		
		/// <summary>
		/// Name: NavigationComponent
		/// Type: ObjectProperty
		/// Offset: 0xF70
		/// Size: 0x08
		/// </summary>
		public UNavigationComponent_C NavigationComponent => ReadUObject<UNavigationComponent_C>(0xF70);
		
		/// <summary>
		/// Name: AILOD
		/// Type: ObjectProperty
		/// Offset: 0xF78
		/// Size: 0x08
		/// </summary>
		public UAILODComponent AILOD => ReadUObject<UAILODComponent>(0xF78);
		
		/// <summary>
		/// Name: MovingState
		/// Type: ByteProperty
		/// Offset: 0xF80
		/// Size: 0x01
		/// </summary>
		public byte MovingState
		{
			get
			{
				return ReadByte(0xF80);
			}
			set
			{
				WriteByte(0xF80,value);
			}
		}
		
		/// <summary>
		/// Name: Aggressiveness
		/// Type: IntProperty
		/// Offset: 0xF84
		/// Size: 0x04
		/// </summary>
		public int Aggressiveness
		{
			get
			{
				return ReadInt32(0xF84);
			}
			set
			{
				WriteInt32(0xF84,value);
			}
		}
		
		/// <summary>
		/// Name: Aggression
		/// Type: ByteProperty
		/// Offset: 0xF88
		/// Size: 0x01
		/// </summary>
		public byte Aggression
		{
			get
			{
				return ReadByte(0xF88);
			}
			set
			{
				WriteByte(0xF88,value);
			}
		}
		
		/// <summary>
		/// Name: HuntMinRank
		/// Type: IntProperty
		/// Offset: 0xF8C
		/// Size: 0x04
		/// </summary>
		public int HuntMinRank
		{
			get
			{
				return ReadInt32(0xF8C);
			}
			set
			{
				WriteInt32(0xF8C,value);
			}
		}
		
		/// <summary>
		/// Name: HuntMaxRank
		/// Type: IntProperty
		/// Offset: 0xF90
		/// Size: 0x04
		/// </summary>
		public int HuntMaxRank
		{
			get
			{
				return ReadInt32(0xF90);
			}
			set
			{
				WriteInt32(0xF90,value);
			}
		}
		
		/// <summary>
		/// Name: WalkSpeed
		/// Type: IntProperty
		/// Offset: 0xF94
		/// Size: 0x04
		/// </summary>
		public int WalkSpeed
		{
			get
			{
				return ReadInt32(0xF94);
			}
			set
			{
				WriteInt32(0xF94,value);
			}
		}
		
		/// <summary>
		/// Name: RunSpeed
		/// Type: IntProperty
		/// Offset: 0xF98
		/// Size: 0x04
		/// </summary>
		public int RunSpeed
		{
			get
			{
				return ReadInt32(0xF98);
			}
			set
			{
				WriteInt32(0xF98,value);
			}
		}
		
		/// <summary>
		/// Name: HasTaunt
		/// Type: BoolProperty
		/// Offset: 0xF9C
		/// Size: 0x01
		/// </summary>
		public bool HasTaunt
		{
			get
			{
				return ReadBool(0xF9C);
			}
			set
			{
				WriteBool(0xF9C,value);
			}
		}
		
		/// <summary>
		/// Name: TauntVariations
		/// Type: IntProperty
		/// Offset: 0xFA0
		/// Size: 0x04
		/// </summary>
		public int TauntVariations
		{
			get
			{
				return ReadInt32(0xFA0);
			}
			set
			{
				WriteInt32(0xFA0,value);
			}
		}
		
		/// <summary>
		/// Name: TauntChance
		/// Type: IntProperty
		/// Offset: 0xFA4
		/// Size: 0x04
		/// </summary>
		public int TauntChance
		{
			get
			{
				return ReadInt32(0xFA4);
			}
			set
			{
				WriteInt32(0xFA4,value);
			}
		}
		
		/// <summary>
		/// Name: AttackVariations
		/// Type: IntProperty
		/// Offset: 0xFA8
		/// Size: 0x04
		/// </summary>
		public int AttackVariations
		{
			get
			{
				return ReadInt32(0xFA8);
			}
			set
			{
				WriteInt32(0xFA8,value);
			}
		}
		
		/// <summary>
		/// Name: AttackDistance
		/// Type: FloatProperty
		/// Offset: 0xFAC
		/// Size: 0x04
		/// </summary>
		public float AttackDistance
		{
			get
			{
				return ReadSingle(0xFAC);
			}
			set
			{
				WriteSingle(0xFAC,value);
			}
		}
		
		/// <summary>
		/// Name: HasChargeAttack
		/// Type: BoolProperty
		/// Offset: 0xFB0
		/// Size: 0x01
		/// </summary>
		public bool HasChargeAttack
		{
			get
			{
				return ReadBool(0xFB0);
			}
			set
			{
				WriteBool(0xFB0,value);
			}
		}
		
		/// <summary>
		/// Name: ChargeAttackDistance
		/// Type: FloatProperty
		/// Offset: 0xFB4
		/// Size: 0x04
		/// </summary>
		public float ChargeAttackDistance
		{
			get
			{
				return ReadSingle(0xFB4);
			}
			set
			{
				WriteSingle(0xFB4,value);
			}
		}
		
		/// <summary>
		/// Name: NPCTerritoryGroup
		/// Type: IntProperty
		/// Offset: 0xFB8
		/// Size: 0x04
		/// </summary>
		public int NPCTerritoryGroup
		{
			get
			{
				return ReadInt32(0xFB8);
			}
			set
			{
				WriteInt32(0xFB8,value);
			}
		}
		
		/// <summary>
		/// Name: ChargeChance
		/// Type: IntProperty
		/// Offset: 0xFBC
		/// Size: 0x04
		/// </summary>
		public int ChargeChance
		{
			get
			{
				return ReadInt32(0xFBC);
			}
			set
			{
				WriteInt32(0xFBC,value);
			}
		}
		
		/// <summary>
		/// Name: PowerAttackChance
		/// Type: IntProperty
		/// Offset: 0xFC0
		/// Size: 0x04
		/// </summary>
		public int PowerAttackChance
		{
			get
			{
				return ReadInt32(0xFC0);
			}
			set
			{
				WriteInt32(0xFC0,value);
			}
		}
		
		/// <summary>
		/// Name: LeashRange
		/// Type: FloatProperty
		/// Offset: 0xFC4
		/// Size: 0x04
		/// </summary>
		public float LeashRange
		{
			get
			{
				return ReadSingle(0xFC4);
			}
			set
			{
				WriteSingle(0xFC4,value);
			}
		}
		
		/// <summary>
		/// Name: TerritoryVolumeSpawner
		/// Type: InterfaceProperty
		/// Offset: 0xFC8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: CanChargeAttack
		/// Type: BoolProperty
		/// Offset: 0xFD8
		/// Size: 0x01
		/// </summary>
		public bool CanChargeAttack
		{
			get
			{
				return ReadBool(0xFD8);
			}
			set
			{
				WriteBool(0xFD8,value);
			}
		}
		
		/// <summary>
		/// Name: IsCharging
		/// Type: BoolProperty
		/// Offset: 0xFD9
		/// Size: 0x01
		/// </summary>
		public bool IsCharging
		{
			get
			{
				return ReadBool(0xFD9);
			}
			set
			{
				WriteBool(0xFD9,value);
			}
		}
		
		/// <summary>
		/// Name: CanTaunt
		/// Type: BoolProperty
		/// Offset: 0xFDA
		/// Size: 0x01
		/// </summary>
		public bool CanTaunt
		{
			get
			{
				return ReadBool(0xFDA);
			}
			set
			{
				WriteBool(0xFDA,value);
			}
		}
		
		/// <summary>
		/// Name: FleeDistance
		/// Type: FloatProperty
		/// Offset: 0xFDC
		/// Size: 0x04
		/// </summary>
		public float FleeDistance
		{
			get
			{
				return ReadSingle(0xFDC);
			}
			set
			{
				WriteSingle(0xFDC,value);
			}
		}
		
		/// <summary>
		/// Name: IsPredator
		/// Type: BoolProperty
		/// Offset: 0xFE0
		/// Size: 0x01
		/// </summary>
		public bool IsPredator
		{
			get
			{
				return ReadBool(0xFE0);
			}
			set
			{
				WriteBool(0xFE0,value);
			}
		}
		
		/// <summary>
		/// Name: IsStationary
		/// Type: BoolProperty
		/// Offset: 0xFE1
		/// Size: 0x01
		/// </summary>
		public bool IsStationary
		{
			get
			{
				return ReadBool(0xFE1);
			}
			set
			{
				WriteBool(0xFE1,value);
			}
		}
		
		/// <summary>
		/// Name: isHumanoid
		/// Type: BoolProperty
		/// Offset: 0xFE2
		/// Size: 0x01
		/// </summary>
		public bool isHumanoid
		{
			get
			{
				return ReadBool(0xFE2);
			}
			set
			{
				WriteBool(0xFE2,value);
			}
		}
		
		/// <summary>
		/// Name: HasBlock
		/// Type: BoolProperty
		/// Offset: 0xFE3
		/// Size: 0x01
		/// </summary>
		public bool HasBlock
		{
			get
			{
				return ReadBool(0xFE3);
			}
			set
			{
				WriteBool(0xFE3,value);
			}
		}
		
		/// <summary>
		/// Name: NPCDefaultMainHand
		/// Type: IntProperty
		/// Offset: 0xFE4
		/// Size: 0x04
		/// </summary>
		public int NPCDefaultMainHand
		{
			get
			{
				return ReadInt32(0xFE4);
			}
			set
			{
				WriteInt32(0xFE4,value);
			}
		}
		
		/// <summary>
		/// Name: NPCDefaultOffHand
		/// Type: IntProperty
		/// Offset: 0xFE8
		/// Size: 0x04
		/// </summary>
		public int NPCDefaultOffHand
		{
			get
			{
				return ReadInt32(0xFE8);
			}
			set
			{
				WriteInt32(0xFE8,value);
			}
		}
		
		/// <summary>
		/// Name: HasTwoHandedWeapon
		/// Type: BoolProperty
		/// Offset: 0xFEC
		/// Size: 0x01
		/// </summary>
		public bool HasTwoHandedWeapon
		{
			get
			{
				return ReadBool(0xFEC);
			}
			set
			{
				WriteBool(0xFEC,value);
			}
		}
		
		/// <summary>
		/// Name: LocationAggroPoint
		/// Type: NameProperty
		/// Offset: 0xFF0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: RagdollPhysicsAsset
		/// Type: ObjectProperty
		/// Offset: 0xFF8
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset RagdollPhysicsAsset => ReadUObject<UPhysicsAsset>(0xFF8);
		
		/// <summary>
		/// Name: HasTwoLegs
		/// Type: BoolProperty
		/// Offset: 0x1000
		/// Size: 0x01
		/// </summary>
		public bool HasTwoLegs
		{
			get
			{
				return ReadBool(0x1000);
			}
			set
			{
				WriteBool(0x1000,value);
			}
		}
		
		/// <summary>
		/// Name: HasFourLegs
		/// Type: BoolProperty
		/// Offset: 0x1001
		/// Size: 0x01
		/// </summary>
		public bool HasFourLegs
		{
			get
			{
				return ReadBool(0x1001);
			}
			set
			{
				WriteBool(0x1001,value);
			}
		}
		
		/// <summary>
		/// Name: HasMoreThanFourLegs
		/// Type: BoolProperty
		/// Offset: 0x1002
		/// Size: 0x01
		/// </summary>
		public bool HasMoreThanFourLegs
		{
			get
			{
				return ReadBool(0x1002);
			}
			set
			{
				WriteBool(0x1002,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentAttackerCharacter
		/// Type: ObjectProperty
		/// Offset: 0x1008
		/// Size: 0x08
		/// </summary>
		public ABaseBPCombat_C CurrentAttackerCharacter => ReadUObject<ABaseBPCombat_C>(0x1008);
		
		/// <summary>
		/// Name: IsLeashing
		/// Type: BoolProperty
		/// Offset: 0x1010
		/// Size: 0x01
		/// </summary>
		public bool IsLeashing
		{
			get
			{
				return ReadBool(0x1010);
			}
			set
			{
				WriteBool(0x1010,value);
			}
		}
		
		/// <summary>
		/// Name: IsDomesticated
		/// Type: BoolProperty
		/// Offset: 0x1011
		/// Size: 0x01
		/// </summary>
		public bool IsDomesticated
		{
			get
			{
				return ReadBool(0x1011);
			}
			set
			{
				WriteBool(0x1011,value);
			}
		}
		
		/// <summary>
		/// Name: HighestHate
		/// Type: IntProperty
		/// Offset: 0x1014
		/// Size: 0x04
		/// </summary>
		public int HighestHate
		{
			get
			{
				return ReadInt32(0x1014);
			}
			set
			{
				WriteInt32(0x1014,value);
			}
		}
		
		/// <summary>
		/// Name: NavigationFilterType
		/// Type: ClassProperty
		/// Offset: 0x1018
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: HasEmoteState
		/// Type: BoolProperty
		/// Offset: 0x1020
		/// Size: 0x01
		/// </summary>
		public bool HasEmoteState
		{
			get
			{
				return ReadBool(0x1020);
			}
			set
			{
				WriteBool(0x1020,value);
			}
		}
		
		/// <summary>
		/// Name: IsRelaxing
		/// Type: BoolProperty
		/// Offset: 0x1021
		/// Size: 0x01
		/// </summary>
		public bool IsRelaxing
		{
			get
			{
				return ReadBool(0x1021);
			}
			set
			{
				WriteBool(0x1021,value);
			}
		}
		
		/// <summary>
		/// Name: IsExitingSocialState
		/// Type: BoolProperty
		/// Offset: 0x1022
		/// Size: 0x01
		/// </summary>
		public bool IsExitingSocialState
		{
			get
			{
				return ReadBool(0x1022);
			}
			set
			{
				WriteBool(0x1022,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteChance
		/// Type: IntProperty
		/// Offset: 0x1024
		/// Size: 0x04
		/// </summary>
		public int EmoteChance
		{
			get
			{
				return ReadInt32(0x1024);
			}
			set
			{
				WriteInt32(0x1024,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteMinTime
		/// Type: IntProperty
		/// Offset: 0x1028
		/// Size: 0x04
		/// </summary>
		public int EmoteMinTime
		{
			get
			{
				return ReadInt32(0x1028);
			}
			set
			{
				WriteInt32(0x1028,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteMaxTime
		/// Type: IntProperty
		/// Offset: 0x102C
		/// Size: 0x04
		/// </summary>
		public int EmoteMaxTime
		{
			get
			{
				return ReadInt32(0x102C);
			}
			set
			{
				WriteInt32(0x102C,value);
			}
		}
		
		/// <summary>
		/// Name: SecondsWastedBeforeGivingUpAttack
		/// Type: FloatProperty
		/// Offset: 0x1030
		/// Size: 0x04
		/// </summary>
		public float SecondsWastedBeforeGivingUpAttack
		{
			get
			{
				return ReadSingle(0x1030);
			}
			set
			{
				WriteSingle(0x1030,value);
			}
		}
		
		/// <summary>
		/// Name: ResourcePhysicalMaterial
		/// Type: ObjectProperty
		/// Offset: 0x1038
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial ResourcePhysicalMaterial => ReadUObject<UPhysicalMaterial>(0x1038);
		
		/// <summary>
		/// Name: SpawnPoint
		/// Type: ObjectProperty
		/// Offset: 0x1040
		/// Size: 0x08
		/// </summary>
		public AStaticSpawnPoint SpawnPoint => ReadUObject<AStaticSpawnPoint>(0x1040);
		
		/// <summary>
		/// Name: PreferredAttackPointGroup
		/// Type: ByteProperty
		/// Offset: 0x1048
		/// Size: 0x01
		/// </summary>
		public byte PreferredAttackPointGroup
		{
			get
			{
				return ReadByte(0x1048);
			}
			set
			{
				WriteByte(0x1048,value);
			}
		}
		
		/// <summary>
		/// Name: NextVelocityDebugDrawTime
		/// Type: FloatProperty
		/// Offset: 0x104C
		/// Size: 0x04
		/// </summary>
		public float NextVelocityDebugDrawTime
		{
			get
			{
				return ReadSingle(0x104C);
			}
			set
			{
				WriteSingle(0x104C,value);
			}
		}
		
		/// <summary>
		/// Name: PreferredAttackPointGroups
		/// Type: TArray<>
		/// Offset: 0x1050
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: AI_Controller
		/// Type: InterfaceProperty
		/// Offset: 0x1060
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: IsSelfDestructing
		/// Type: BoolProperty
		/// Offset: 0x1070
		/// Size: 0x01
		/// </summary>
		public bool IsSelfDestructing
		{
			get
			{
				return ReadBool(0x1070);
			}
			set
			{
				WriteBool(0x1070,value);
			}
		}
		
		/// <summary>
		/// Name: SD_BaseDamage
		/// Type: FloatProperty
		/// Offset: 0x1074
		/// Size: 0x04
		/// </summary>
		public float SD_BaseDamage
		{
			get
			{
				return ReadSingle(0x1074);
			}
			set
			{
				WriteSingle(0x1074,value);
			}
		}
		
		/// <summary>
		/// Name: SD_MinDamage
		/// Type: FloatProperty
		/// Offset: 0x1078
		/// Size: 0x04
		/// </summary>
		public float SD_MinDamage
		{
			get
			{
				return ReadSingle(0x1078);
			}
			set
			{
				WriteSingle(0x1078,value);
			}
		}
		
		/// <summary>
		/// Name: SD_InnerRadius
		/// Type: FloatProperty
		/// Offset: 0x107C
		/// Size: 0x04
		/// </summary>
		public float SD_InnerRadius
		{
			get
			{
				return ReadSingle(0x107C);
			}
			set
			{
				WriteSingle(0x107C,value);
			}
		}
		
		/// <summary>
		/// Name: SD_OuterRadius
		/// Type: FloatProperty
		/// Offset: 0x1080
		/// Size: 0x04
		/// </summary>
		public float SD_OuterRadius
		{
			get
			{
				return ReadSingle(0x1080);
			}
			set
			{
				WriteSingle(0x1080,value);
			}
		}
		
		/// <summary>
		/// Name: SD_DamageFalloff
		/// Type: FloatProperty
		/// Offset: 0x1084
		/// Size: 0x04
		/// </summary>
		public float SD_DamageFalloff
		{
			get
			{
				return ReadSingle(0x1084);
			}
			set
			{
				WriteSingle(0x1084,value);
			}
		}
		
		/// <summary>
		/// Name: SD_Sound
		/// Type: ObjectProperty
		/// Offset: 0x1088
		/// Size: 0x08
		/// </summary>
		public USoundBase SD_Sound => ReadUObject<USoundBase>(0x1088);
		
		/// <summary>
		/// Name: SD_CameraShake
		/// Type: ClassProperty
		/// Offset: 0x1090
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SD_CamShakeInnerRadius
		/// Type: FloatProperty
		/// Offset: 0x1098
		/// Size: 0x04
		/// </summary>
		public float SD_CamShakeInnerRadius
		{
			get
			{
				return ReadSingle(0x1098);
			}
			set
			{
				WriteSingle(0x1098,value);
			}
		}
		
		/// <summary>
		/// Name: SD_CamShakeOuterRadius
		/// Type: FloatProperty
		/// Offset: 0x109C
		/// Size: 0x04
		/// </summary>
		public float SD_CamShakeOuterRadius
		{
			get
			{
				return ReadSingle(0x109C);
			}
			set
			{
				WriteSingle(0x109C,value);
			}
		}
		
		/// <summary>
		/// Name: SD_CamShakeFalloff
		/// Type: FloatProperty
		/// Offset: 0x10A0
		/// Size: 0x04
		/// </summary>
		public float SD_CamShakeFalloff
		{
			get
			{
				return ReadSingle(0x10A0);
			}
			set
			{
				WriteSingle(0x10A0,value);
			}
		}
		
		/// <summary>
		/// Name: RotationAngleThreshold
		/// Type: FloatProperty
		/// Offset: 0x10A4
		/// Size: 0x04
		/// </summary>
		public float RotationAngleThreshold
		{
			get
			{
				return ReadSingle(0x10A4);
			}
			set
			{
				WriteSingle(0x10A4,value);
			}
		}
		
		/// <summary>
		/// Name: RotationSpeed
		/// Type: FloatProperty
		/// Offset: 0x10A8
		/// Size: 0x04
		/// </summary>
		public float RotationSpeed
		{
			get
			{
				return ReadSingle(0x10A8);
			}
			set
			{
				WriteSingle(0x10A8,value);
			}
		}
		
		/// <summary>
		/// Name: ReactionTime
		/// Type: FloatProperty
		/// Offset: 0x10AC
		/// Size: 0x04
		/// </summary>
		public float ReactionTime
		{
			get
			{
				return ReadSingle(0x10AC);
			}
			set
			{
				WriteSingle(0x10AC,value);
			}
		}
		
		/// <summary>
		/// Name: NPCDefaultInventory
		/// Type: TArray<>
		/// Offset: 0x10B0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CryForHelpOnDamageRadius
		/// Type: FloatProperty
		/// Offset: 0x10C0
		/// Size: 0x04
		/// </summary>
		public float CryForHelpOnDamageRadius
		{
			get
			{
				return ReadSingle(0x10C0);
			}
			set
			{
				WriteSingle(0x10C0,value);
			}
		}
		
		/// <summary>
		/// Name: LootBagOffset
		/// Type: StructProperty
		/// Offset: 0x10C4
		/// Size: 0x0C
		/// </summary>
		public FVector LootBagOffset => ReadStruct<FVector>(0x10C4);
		
		/// <summary>
		/// Name: ClientTargetActor
		/// Type: ObjectProperty
		/// Offset: 0x10D0
		/// Size: 0x08
		/// </summary>
		public AActor ClientTargetActor => ReadUObject<AActor>(0x10D0);
		
		/// <summary>
		/// Name: SecondsWastedBeforeGivingUpRotation
		/// Type: FloatProperty
		/// Offset: 0x10D8
		/// Size: 0x04
		/// </summary>
		public float SecondsWastedBeforeGivingUpRotation
		{
			get
			{
				return ReadSingle(0x10D8);
			}
			set
			{
				WriteSingle(0x10D8,value);
			}
		}
		
		/// <summary>
		/// Name: PredictionHistorySeconds
		/// Type: FloatProperty
		/// Offset: 0x10DC
		/// Size: 0x04
		/// </summary>
		public float PredictionHistorySeconds
		{
			get
			{
				return ReadSingle(0x10DC);
			}
			set
			{
				WriteSingle(0x10DC,value);
			}
		}
		
		/// <summary>
		/// Name: PredictionOffsetSeconds
		/// Type: FloatProperty
		/// Offset: 0x10E0
		/// Size: 0x04
		/// </summary>
		public float PredictionOffsetSeconds
		{
			get
			{
				return ReadSingle(0x10E0);
			}
			set
			{
				WriteSingle(0x10E0,value);
			}
		}
		
	}


	/// <summary>
	/// UCombatMode_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCombatMode_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABaseSurvivalChar_C:ABaseBPCombat_C
	/// Size: 0xF70
	/// Properties: 2
	/// </summary>
	public class ABaseSurvivalChar_C:ABaseBPCombat_C
	{
		public override int ObjectSize => 3952;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF60
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF60);
		
		/// <summary>
		/// Name: GatheringVolume
		/// Type: ObjectProperty
		/// Offset: 0xF68
		/// Size: 0x08
		/// </summary>
		public USphereComponent GatheringVolume => ReadUObject<USphereComponent>(0xF68);
		
	}


	/// <summary>
	/// ABasePlayerChar_C:ABaseSurvivalChar_C
	/// Size: 0x15D9
	/// Properties: 182
	/// </summary>
	public class ABasePlayerChar_C:ABaseSurvivalChar_C
	{
		public override int ObjectSize => 5593;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF70
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF70);
		
		/// <summary>
		/// Name: DialogueComponent
		/// Type: ObjectProperty
		/// Offset: 0xF78
		/// Size: 0x08
		/// </summary>
		public UDialogueComponent_C DialogueComponent => ReadUObject<UDialogueComponent_C>(0xF78);
		
		/// <summary>
		/// Name: EmoteInventory
		/// Type: ObjectProperty
		/// Offset: 0xF80
		/// Size: 0x08
		/// </summary>
		public UEmoteInventory EmoteInventory => ReadUObject<UEmoteInventory>(0xF80);
		
		/// <summary>
		/// Name: BPEnergyReceiver
		/// Type: ObjectProperty
		/// Offset: 0xF88
		/// Size: 0x08
		/// </summary>
		public UBPEnergyReceiver_C BPEnergyReceiver => ReadUObject<UBPEnergyReceiver_C>(0xF88);
		
		/// <summary>
		/// Name: ContextMusic_L1
		/// Type: ObjectProperty
		/// Offset: 0xF90
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ContextMusic_L1 => ReadUObject<UConanAudioComponent>(0xF90);
		
		/// <summary>
		/// Name: TargetingControllers
		/// Type: ObjectProperty
		/// Offset: 0xF98
		/// Size: 0x08
		/// </summary>
		public UTargetingControllersComponent TargetingControllers => ReadUObject<UTargetingControllersComponent>(0xF98);
		
		/// <summary>
		/// Name: SpringArm_VanityCamera
		/// Type: ObjectProperty
		/// Offset: 0xFA0
		/// Size: 0x08
		/// </summary>
		public USpringArmComponent SpringArm_VanityCamera => ReadUObject<USpringArmComponent>(0xFA0);
		
		/// <summary>
		/// Name: CameraVanity
		/// Type: ObjectProperty
		/// Offset: 0xFA8
		/// Size: 0x08
		/// </summary>
		public UAdjustableCameraComponent CameraVanity => ReadUObject<UAdjustableCameraComponent>(0xFA8);
		
		/// <summary>
		/// Name: DeathCamera
		/// Type: ObjectProperty
		/// Offset: 0xFB0
		/// Size: 0x08
		/// </summary>
		public UAdjustableCameraComponent DeathCamera => ReadUObject<UAdjustableCameraComponent>(0xFB0);
		
		/// <summary>
		/// Name: SpringArm_DeathCamera
		/// Type: ObjectProperty
		/// Offset: 0xFB8
		/// Size: 0x08
		/// </summary>
		public USpringArmComponent SpringArm_DeathCamera => ReadUObject<USpringArmComponent>(0xFB8);
		
		/// <summary>
		/// Name: BP_ThrallSystemComponent
		/// Type: ObjectProperty
		/// Offset: 0xFC0
		/// Size: 0x08
		/// </summary>
		public UBP_ThrallSystemComponent_C BP_ThrallSystemComponent => ReadUObject<UBP_ThrallSystemComponent_C>(0xFC0);
		
		/// <summary>
		/// Name: BP_NarratorComponent
		/// Type: ObjectProperty
		/// Offset: 0xFC8
		/// Size: 0x08
		/// </summary>
		public UBP_NarratorComponent_C BP_NarratorComponent => ReadUObject<UBP_NarratorComponent_C>(0xFC8);
		
		/// <summary>
		/// Name: ConanCharacterPersistence
		/// Type: ObjectProperty
		/// Offset: 0xFD0
		/// Size: 0x08
		/// </summary>
		public UConanCharacterPersistenceComponent ConanCharacterPersistence => ReadUObject<UConanCharacterPersistenceComponent>(0xFD0);
		
		/// <summary>
		/// Name: BP_LoreInteractor
		/// Type: ObjectProperty
		/// Offset: 0xFD8
		/// Size: 0x08
		/// </summary>
		public UBP_LoreInteractor_C BP_LoreInteractor => ReadUObject<UBP_LoreInteractor_C>(0xFD8);
		
		/// <summary>
		/// Name: BP_CharacterCustomizationComponent
		/// Type: ObjectProperty
		/// Offset: 0xFE0
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterCustomizationComponent_C BP_CharacterCustomizationComponent => ReadUObject<UBP_CharacterCustomizationComponent_C>(0xFE0);
		
		/// <summary>
		/// Name: AttackPoint_Right
		/// Type: ObjectProperty
		/// Offset: 0xFE8
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Right => ReadUObject<UBP_CharacterAttackPoint_C>(0xFE8);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0xFF0
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0xFF0);
		
		/// <summary>
		/// Name: AttackPoint_Front
		/// Type: ObjectProperty
		/// Offset: 0xFF8
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Front => ReadUObject<UBP_CharacterAttackPoint_C>(0xFF8);
		
		/// <summary>
		/// Name: AttackPoint_Left
		/// Type: ObjectProperty
		/// Offset: 0x1000
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Left => ReadUObject<UBP_CharacterAttackPoint_C>(0x1000);
		
		/// <summary>
		/// Name: InsideChecker
		/// Type: ObjectProperty
		/// Offset: 0x1008
		/// Size: 0x08
		/// </summary>
		public UInsideChecker_C InsideChecker => ReadUObject<UInsideChecker_C>(0x1008);
		
		/// <summary>
		/// Name: EnvironmentAudioTriggerSphere
		/// Type: ObjectProperty
		/// Offset: 0x1010
		/// Size: 0x08
		/// </summary>
		public USphereComponent EnvironmentAudioTriggerSphere => ReadUObject<USphereComponent>(0x1010);
		
		/// <summary>
		/// Name: DynamicMaterialParamController
		/// Type: ObjectProperty
		/// Offset: 0x1018
		/// Size: 0x08
		/// </summary>
		public UDynamicMaterialParamController_C DynamicMaterialParamController => ReadUObject<UDynamicMaterialParamController_C>(0x1018);
		
		/// <summary>
		/// Name: BP_AC_AffectedBySandstorm
		/// Type: ObjectProperty
		/// Offset: 0x1020
		/// Size: 0x08
		/// </summary>
		public UBP_AC_AffectedBySandstorm_C BP_AC_AffectedBySandstorm => ReadUObject<UBP_AC_AffectedBySandstorm_C>(0x1020);
		
		/// <summary>
		/// Name: FeatInventory
		/// Type: ObjectProperty
		/// Offset: 0x1028
		/// Size: 0x08
		/// </summary>
		public UFeatInventory FeatInventory => ReadUObject<UFeatInventory>(0x1028);
		
		/// <summary>
		/// Name: BP_HungerSystem
		/// Type: ObjectProperty
		/// Offset: 0x1030
		/// Size: 0x08
		/// </summary>
		public UBP_HungerSystem_C BP_HungerSystem => ReadUObject<UBP_HungerSystem_C>(0x1030);
		
		/// <summary>
		/// Name: CraftingQueue
		/// Type: ObjectProperty
		/// Offset: 0x1038
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue CraftingQueue => ReadUObject<UCraftingQueue>(0x1038);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1040
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1040);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1048
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerLeg => ReadUObject<UCapsuleComponent>(0x1048);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1050
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperLeg => ReadUObject<UCapsuleComponent>(0x1050);
		
		/// <summary>
		/// Name: HitLoc_RightLowerLeg
		/// Type: ObjectProperty
		/// Offset: 0x1058
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerLeg => ReadUObject<UCapsuleComponent>(0x1058);
		
		/// <summary>
		/// Name: HitLoc_RightUpperLeg
		/// Type: ObjectProperty
		/// Offset: 0x1060
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperLeg => ReadUObject<UCapsuleComponent>(0x1060);
		
		/// <summary>
		/// Name: HitLoc_RightLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1068
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightLowerArm => ReadUObject<UCapsuleComponent>(0x1068);
		
		/// <summary>
		/// Name: HitLoc_RightUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1070
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_RightUpperArm => ReadUObject<UCapsuleComponent>(0x1070);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1078
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc_Torso => ReadUObject<UBoxComponent>(0x1078);
		
		/// <summary>
		/// Name: HitLoc_LeftLowerArm
		/// Type: ObjectProperty
		/// Offset: 0x1080
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftLowerArm => ReadUObject<UCapsuleComponent>(0x1080);
		
		/// <summary>
		/// Name: HitLoc_LeftUpperArm
		/// Type: ObjectProperty
		/// Offset: 0x1088
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LeftUpperArm => ReadUObject<UCapsuleComponent>(0x1088);
		
		/// <summary>
		/// Name: TraceOrigin
		/// Type: ObjectProperty
		/// Offset: 0x1090
		/// Size: 0x08
		/// </summary>
		public UArrowComponent TraceOrigin => ReadUObject<UArrowComponent>(0x1090);
		
		/// <summary>
		/// Name: FloatingName
		/// Type: ObjectProperty
		/// Offset: 0x1098
		/// Size: 0x08
		/// </summary>
		public UWidgetComponent FloatingName => ReadUObject<UWidgetComponent>(0x1098);
		
		/// <summary>
		/// Name: PlayerNotificationComponent
		/// Type: ObjectProperty
		/// Offset: 0x10A0
		/// Size: 0x08
		/// </summary>
		public UPlayerNotificationComponent_C PlayerNotificationComponent => ReadUObject<UPlayerNotificationComponent_C>(0x10A0);
		
		/// <summary>
		/// Name: BP_Building_SplinePlaceables
		/// Type: ObjectProperty
		/// Offset: 0x10A8
		/// Size: 0x08
		/// </summary>
		public UBP_Building_SplinePlaceables_C BP_Building_SplinePlaceables => ReadUObject<UBP_Building_SplinePlaceables_C>(0x10A8);
		
		/// <summary>
		/// Name: BP_BuildSystem_v2
		/// Type: ObjectProperty
		/// Offset: 0x10B0
		/// Size: 0x08
		/// </summary>
		public UBP_BuildSystem_v2_C BP_BuildSystem_v2 => ReadUObject<UBP_BuildSystem_v2_C>(0x10B0);
		
		/// <summary>
		/// Name: RecipeManager
		/// Type: ObjectProperty
		/// Offset: 0x10B8
		/// Size: 0x08
		/// </summary>
		public URecipeManager RecipeManager => ReadUObject<URecipeManager>(0x10B8);
		
		/// <summary>
		/// Name: BP_Gathering
		/// Type: ObjectProperty
		/// Offset: 0x10C0
		/// Size: 0x08
		/// </summary>
		public UBP_Gathering_C BP_Gathering => ReadUObject<UBP_Gathering_C>(0x10C0);
		
		/// <summary>
		/// Name: BP_ProgressionSystem
		/// Type: ObjectProperty
		/// Offset: 0x10C8
		/// Size: 0x08
		/// </summary>
		public UBP_ProgressionSystem_C BP_ProgressionSystem => ReadUObject<UBP_ProgressionSystem_C>(0x10C8);
		
		/// <summary>
		/// Name: BP_EncumbranceSystem
		/// Type: ObjectProperty
		/// Offset: 0x10D0
		/// Size: 0x08
		/// </summary>
		public UBP_EncumbranceSystem_C BP_EncumbranceSystem => ReadUObject<UBP_EncumbranceSystem_C>(0x10D0);
		
		/// <summary>
		/// Name: MergedLodMesh
		/// Type: ObjectProperty
		/// Offset: 0x10D8
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent MergedLodMesh => ReadUObject<USkeletalMeshComponent>(0x10D8);
		
		/// <summary>
		/// Name: CameraThirdPerson
		/// Type: ObjectProperty
		/// Offset: 0x10E0
		/// Size: 0x08
		/// </summary>
		public UCameraComponent CameraThirdPerson => ReadUObject<UCameraComponent>(0x10E0);
		
		/// <summary>
		/// Name: SpringArm
		/// Type: ObjectProperty
		/// Offset: 0x10E8
		/// Size: 0x08
		/// </summary>
		public USpringArmComponent SpringArm => ReadUObject<USpringArmComponent>(0x10E8);
		
		/// <summary>
		/// Name: AdjustableCamera
		/// Type: ObjectProperty
		/// Offset: 0x10F0
		/// Size: 0x08
		/// </summary>
		public UAdjustableCameraComponent AdjustableCamera => ReadUObject<UAdjustableCameraComponent>(0x10F0);
		
		/// <summary>
		/// Name: FirstPersonCameraArm
		/// Type: ObjectProperty
		/// Offset: 0x10F8
		/// Size: 0x08
		/// </summary>
		public USpringArmComponent FirstPersonCameraArm => ReadUObject<USpringArmComponent>(0x10F8);
		
		/// <summary>
		/// Name: BP_CloudParticleSpawner
		/// Type: ObjectProperty
		/// Offset: 0x1100
		/// Size: 0x08
		/// </summary>
		public UBP_CloudParticleSpawner_C BP_CloudParticleSpawner => ReadUObject<UBP_CloudParticleSpawner_C>(0x1100);
		
		/// <summary>
		/// Name: ShortcutBar
		/// Type: ObjectProperty
		/// Offset: 0x1108
		/// Size: 0x08
		/// </summary>
		public UItemInventory ShortcutBar => ReadUObject<UItemInventory>(0x1108);
		
		/// <summary>
		/// Name: backpackInventory
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UItemInventory backpackInventory => ReadUObject<UItemInventory>(0x1110);
		
		/// <summary>
		/// Name: WeaponReplicatedBox
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UBoxComponent WeaponReplicatedBox => ReadUObject<UBoxComponent>(0x1118);
		
		/// <summary>
		/// Name: InteractionManager
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UInteractionManager_C InteractionManager => ReadUObject<UInteractionManager_C>(0x1120);
		
		/// <summary>
		/// Name: Timeline_0_Alpha_0518DC7F49B9167236720AB366421E9E
		/// Type: FloatProperty
		/// Offset: 0x1128
		/// Size: 0x04
		/// </summary>
		public float Timeline_0_Alpha_0518DC7F49B9167236720AB366421E9E
		{
			get
			{
				return ReadSingle(0x1128);
			}
			set
			{
				WriteSingle(0x1128,value);
			}
		}
		
		/// <summary>
		/// Name: Timeline_0__Direction_0518DC7F49B9167236720AB366421E9E
		/// Type: ByteProperty
		/// Offset: 0x112C
		/// Size: 0x01
		/// </summary>
		public byte Timeline_0__Direction_0518DC7F49B9167236720AB366421E9E
		{
			get
			{
				return ReadByte(0x112C);
			}
			set
			{
				WriteByte(0x112C,value);
			}
		}
		
		/// <summary>
		/// Name: Timeline
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UTimelineComponent Timeline => ReadUObject<UTimelineComponent>(0x1130);
		
		/// <summary>
		/// Name: Sprinting
		/// Type: BoolProperty
		/// Offset: 0x1138
		/// Size: 0x01
		/// </summary>
		public bool Sprinting
		{
			get
			{
				return ReadBool(0x1138);
			}
			set
			{
				WriteBool(0x1138,value);
			}
		}
		
		/// <summary>
		/// Name: BaseTurnRate
		/// Type: FloatProperty
		/// Offset: 0x113C
		/// Size: 0x04
		/// </summary>
		public float BaseTurnRate
		{
			get
			{
				return ReadSingle(0x113C);
			}
			set
			{
				WriteSingle(0x113C,value);
			}
		}
		
		/// <summary>
		/// Name: BaseLookUpRate
		/// Type: FloatProperty
		/// Offset: 0x1140
		/// Size: 0x04
		/// </summary>
		public float BaseLookUpRate
		{
			get
			{
				return ReadSingle(0x1140);
			}
			set
			{
				WriteSingle(0x1140,value);
			}
		}
		
		/// <summary>
		/// Name: PrimaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1144
		/// Size: 0x01
		/// </summary>
		public bool PrimaryKeyDown
		{
			get
			{
				return ReadBool(0x1144);
			}
			set
			{
				WriteBool(0x1144,value);
			}
		}
		
		/// <summary>
		/// Name: SecondaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1145
		/// Size: 0x01
		/// </summary>
		public bool SecondaryKeyDown
		{
			get
			{
				return ReadBool(0x1145);
			}
			set
			{
				WriteBool(0x1145,value);
			}
		}
		
		/// <summary>
		/// Name: LocalCheckingMainKey
		/// Type: BoolProperty
		/// Offset: 0x1146
		/// Size: 0x01
		/// </summary>
		public bool LocalCheckingMainKey
		{
			get
			{
				return ReadBool(0x1146);
			}
			set
			{
				WriteBool(0x1146,value);
			}
		}
		
		/// <summary>
		/// Name: LocalLastWasPressed
		/// Type: BoolProperty
		/// Offset: 0x1147
		/// Size: 0x01
		/// </summary>
		public bool LocalLastWasPressed
		{
			get
			{
				return ReadBool(0x1147);
			}
			set
			{
				WriteBool(0x1147,value);
			}
		}
		
		/// <summary>
		/// Name: SpecialTimerHandle
		/// Type: StructProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public FTimerHandle SpecialTimerHandle => ReadStruct<FTimerHandle>(0x1148);
		
		/// <summary>
		/// Name: SpecialReleaseTimerHandle
		/// Type: StructProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public FTimerHandle SpecialReleaseTimerHandle => ReadStruct<FTimerHandle>(0x1150);
		
		/// <summary>
		/// Name: DualSlackTime
		/// Type: FloatProperty
		/// Offset: 0x1158
		/// Size: 0x04
		/// </summary>
		public float DualSlackTime
		{
			get
			{
				return ReadSingle(0x1158);
			}
			set
			{
				WriteSingle(0x1158,value);
			}
		}
		
		/// <summary>
		/// Name: AnimClass
		/// Type: ClassProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: VoiceSelection
		/// Type: IntProperty
		/// Offset: 0x1168
		/// Size: 0x04
		/// </summary>
		public int VoiceSelection
		{
			get
			{
				return ReadInt32(0x1168);
			}
			set
			{
				WriteInt32(0x1168,value);
			}
		}
		
		/// <summary>
		/// Name: Sound_Vocal_Attack
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Attack => ReadUObject<USoundCue>(0x1170);
		
		/// <summary>
		/// Name: Sound_Vocal_Death
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Death => ReadUObject<USoundCue>(0x1178);
		
		/// <summary>
		/// Name: Sound_Vocal_Idle_Calm
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Idle_Calm => ReadUObject<USoundCue>(0x1180);
		
		/// <summary>
		/// Name: Sound_Vocal_Idle_Var
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Idle_Var => ReadUObject<USoundCue>(0x1188);
		
		/// <summary>
		/// Name: Sound_Vocal_Idle_Combat
		/// Type: ObjectProperty
		/// Offset: 0x1190
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Idle_Combat => ReadUObject<USoundCue>(0x1190);
		
		/// <summary>
		/// Name: Sound_Vocal_Eat
		/// Type: ObjectProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Eat => ReadUObject<USoundCue>(0x1198);
		
		/// <summary>
		/// Name: Sound_Vocal_Taunt
		/// Type: ObjectProperty
		/// Offset: 0x11A0
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_Taunt => ReadUObject<USoundCue>(0x11A0);
		
		/// <summary>
		/// Name: Sound_Vocal_GetHit
		/// Type: ObjectProperty
		/// Offset: 0x11A8
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Vocal_GetHit => ReadUObject<USoundCue>(0x11A8);
		
		/// <summary>
		/// Name: NPCTesterSelectedActor
		/// Type: ObjectProperty
		/// Offset: 0x11B0
		/// Size: 0x08
		/// </summary>
		public AActor NPCTesterSelectedActor => ReadUObject<AActor>(0x11B0);
		
		/// <summary>
		/// Name: ShowNPCTesterUI
		/// Type: BoolProperty
		/// Offset: 0x11B8
		/// Size: 0x01
		/// </summary>
		public bool ShowNPCTesterUI
		{
			get
			{
				return ReadBool(0x11B8);
			}
			set
			{
				WriteBool(0x11B8,value);
			}
		}
		
		/// <summary>
		/// Name: HomeLocation
		/// Type: NameProperty
		/// Offset: 0x11C0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: NPCTesterSkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x11C8
		/// Size: 0x08
		/// </summary>
		public USkeletalMesh NPCTesterSkeletalMesh => ReadUObject<USkeletalMesh>(0x11C8);
		
		/// <summary>
		/// Name: NPCTesterAnimInstanceClass
		/// Type: ClassProperty
		/// Offset: 0x11D0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: NPCTesterAggression
		/// Type: ByteProperty
		/// Offset: 0x11D8
		/// Size: 0x01
		/// </summary>
		public byte NPCTesterAggression
		{
			get
			{
				return ReadByte(0x11D8);
			}
			set
			{
				WriteByte(0x11D8,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleNPCTesterHome
		/// Type: BoolProperty
		/// Offset: 0x11D9
		/// Size: 0x01
		/// </summary>
		public bool ToggleNPCTesterHome
		{
			get
			{
				return ReadBool(0x11D9);
			}
			set
			{
				WriteBool(0x11D9,value);
			}
		}
		
		/// <summary>
		/// Name: NeedsVisualUpdateCombine
		/// Type: BoolProperty
		/// Offset: 0x11DA
		/// Size: 0x01
		/// </summary>
		public bool NeedsVisualUpdateCombine
		{
			get
			{
				return ReadBool(0x11DA);
			}
			set
			{
				WriteBool(0x11DA,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleCamera
		/// Type: BoolProperty
		/// Offset: 0x11DB
		/// Size: 0x01
		/// </summary>
		public bool ToggleCamera
		{
			get
			{
				return ReadBool(0x11DB);
			}
			set
			{
				WriteBool(0x11DB,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleMount
		/// Type: BoolProperty
		/// Offset: 0x11DC
		/// Size: 0x01
		/// </summary>
		public bool ToggleMount
		{
			get
			{
				return ReadBool(0x11DC);
			}
			set
			{
				WriteBool(0x11DC,value);
			}
		}
		
		/// <summary>
		/// Name: MountSpeed
		/// Type: FloatProperty
		/// Offset: 0x11E0
		/// Size: 0x04
		/// </summary>
		public float MountSpeed
		{
			get
			{
				return ReadSingle(0x11E0);
			}
			set
			{
				WriteSingle(0x11E0,value);
			}
		}
		
		/// <summary>
		/// Name: BaseSpeed
		/// Type: FloatProperty
		/// Offset: 0x11E4
		/// Size: 0x04
		/// </summary>
		public float BaseSpeed
		{
			get
			{
				return ReadSingle(0x11E4);
			}
			set
			{
				WriteSingle(0x11E4,value);
			}
		}
		
		/// <summary>
		/// Name: HeadVisible
		/// Type: BoolProperty
		/// Offset: 0x11E8
		/// Size: 0x01
		/// </summary>
		public bool HeadVisible
		{
			get
			{
				return ReadBool(0x11E8);
			}
			set
			{
				WriteBool(0x11E8,value);
			}
		}
		
		/// <summary>
		/// Name: NeedsVisualUpdateTint
		/// Type: BoolProperty
		/// Offset: 0x11E9
		/// Size: 0x01
		/// </summary>
		public bool NeedsVisualUpdateTint
		{
			get
			{
				return ReadBool(0x11E9);
			}
			set
			{
				WriteBool(0x11E9,value);
			}
		}
		
		/// <summary>
		/// Name: DebugTemp_JumpZVelocityValue
		/// Type: FloatProperty
		/// Offset: 0x11EC
		/// Size: 0x04
		/// </summary>
		public float DebugTemp_JumpZVelocityValue
		{
			get
			{
				return ReadSingle(0x11EC);
			}
			set
			{
				WriteSingle(0x11EC,value);
			}
		}
		
		/// <summary>
		/// Name: TerritoryRoamRadius
		/// Type: NameProperty
		/// Offset: 0x11F0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CurrentTarget
		/// Type: NameProperty
		/// Offset: 0x11F8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ToggleSelfTarget
		/// Type: BoolProperty
		/// Offset: 0x1200
		/// Size: 0x01
		/// </summary>
		public bool ToggleSelfTarget
		{
			get
			{
				return ReadBool(0x1200);
			}
			set
			{
				WriteBool(0x1200,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleExternalTarget
		/// Type: BoolProperty
		/// Offset: 0x1201
		/// Size: 0x01
		/// </summary>
		public bool ToggleExternalTarget
		{
			get
			{
				return ReadBool(0x1201);
			}
			set
			{
				WriteBool(0x1201,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleSpawnedNPC
		/// Type: BoolProperty
		/// Offset: 0x1202
		/// Size: 0x01
		/// </summary>
		public bool ToggleSpawnedNPC
		{
			get
			{
				return ReadBool(0x1202);
			}
			set
			{
				WriteBool(0x1202,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterBodyParts
		/// Type: TArray<USkeletalMeshComponent>
		/// Offset: 0x1208
		/// Size: 0x10
		/// SubElement Size: 0xD20
		/// </summary>
		public TArray<USkeletalMeshComponent> CharacterBodyParts => new TArray<USkeletalMeshComponent>(BaseAddress+0x1208);
		
		/// <summary>
		/// Name: Debug_IgnoreBuildingCosts
		/// Type: BoolProperty
		/// Offset: 0x1218
		/// Size: 0x01
		/// </summary>
		public bool Debug_IgnoreBuildingCosts
		{
			get
			{
				return ReadBool(0x1218);
			}
			set
			{
				WriteBool(0x1218,value);
			}
		}
		
		/// <summary>
		/// Name: ResourceData
		/// Type: StructProperty
		/// Offset: 0x121C
		/// Size: 0x38
		/// </summary>
		public FResourceDataStructure ResourceData => ReadStruct<FResourceDataStructure>(0x121C);
		
		/// <summary>
		/// Name: InitialCharacterData
		/// Type: TArray<FDBResult>
		/// Offset: 0x1258
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FDBResult> InitialCharacterData => new TArray<FDBResult>(BaseAddress+0x1258);
		
		/// <summary>
		/// Name: InitialInventoryData
		/// Type: TArray<FDBResult>
		/// Offset: 0x1268
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FDBResult> InitialInventoryData => new TArray<FDBResult>(BaseAddress+0x1268);
		
		/// <summary>
		/// Name: PlayerInvisibility
		/// Type: BoolProperty
		/// Offset: 0x1278
		/// Size: 0x01
		/// </summary>
		public bool PlayerInvisibility
		{
			get
			{
				return ReadBool(0x1278);
			}
			set
			{
				WriteBool(0x1278,value);
			}
		}
		
		/// <summary>
		/// Name: FirstPersonZoomValue
		/// Type: FloatProperty
		/// Offset: 0x127C
		/// Size: 0x04
		/// </summary>
		public float FirstPersonZoomValue
		{
			get
			{
				return ReadSingle(0x127C);
			}
			set
			{
				WriteSingle(0x127C,value);
			}
		}
		
		/// <summary>
		/// Name: FirstPersonZoomDuration
		/// Type: FloatProperty
		/// Offset: 0x1280
		/// Size: 0x04
		/// </summary>
		public float FirstPersonZoomDuration
		{
			get
			{
				return ReadSingle(0x1280);
			}
			set
			{
				WriteSingle(0x1280,value);
			}
		}
		
		/// <summary>
		/// Name: FirstPersonZoomTick
		/// Type: FloatProperty
		/// Offset: 0x1284
		/// Size: 0x04
		/// </summary>
		public float FirstPersonZoomTick
		{
			get
			{
				return ReadSingle(0x1284);
			}
			set
			{
				WriteSingle(0x1284,value);
			}
		}
		
		/// <summary>
		/// Name: LimitedRespawnActor
		/// Type: ObjectProperty
		/// Offset: 0x1288
		/// Size: 0x08
		/// </summary>
		public AActor LimitedRespawnActor => ReadUObject<AActor>(0x1288);
		
		/// <summary>
		/// Name: LimitedRespawnPlayerTransform
		/// Type: StructProperty
		/// Offset: 0x1290
		/// Size: 0x30
		/// </summary>
		public FTransform LimitedRespawnPlayerTransform => ReadStruct<FTransform>(0x1290);
		
		/// <summary>
		/// Name: LimitedUseSpawnWasLastSetSpawnPoint
		/// Type: BoolProperty
		/// Offset: 0x12C0
		/// Size: 0x01
		/// </summary>
		public bool LimitedUseSpawnWasLastSetSpawnPoint
		{
			get
			{
				return ReadBool(0x12C0);
			}
			set
			{
				WriteBool(0x12C0,value);
			}
		}
		
		/// <summary>
		/// Name: IsSitting
		/// Type: BoolProperty
		/// Offset: 0x12C1
		/// Size: 0x01
		/// </summary>
		public bool IsSitting
		{
			get
			{
				return ReadBool(0x12C1);
			}
			set
			{
				WriteBool(0x12C1,value);
			}
		}
		
		/// <summary>
		/// Name: SwimmingMovementMultiplier
		/// Type: FloatProperty
		/// Offset: 0x12C4
		/// Size: 0x04
		/// </summary>
		public float SwimmingMovementMultiplier
		{
			get
			{
				return ReadSingle(0x12C4);
			}
			set
			{
				WriteSingle(0x12C4,value);
			}
		}
		
		/// <summary>
		/// Name: FlyingMovementMultiplier
		/// Type: FloatProperty
		/// Offset: 0x12C8
		/// Size: 0x04
		/// </summary>
		public float FlyingMovementMultiplier
		{
			get
			{
				return ReadSingle(0x12C8);
			}
			set
			{
				WriteSingle(0x12C8,value);
			}
		}
		
		/// <summary>
		/// Name: MovementModeMultiplier
		/// Type: FloatProperty
		/// Offset: 0x12CC
		/// Size: 0x04
		/// </summary>
		public float MovementModeMultiplier
		{
			get
			{
				return ReadSingle(0x12CC);
			}
			set
			{
				WriteSingle(0x12CC,value);
			}
		}
		
		/// <summary>
		/// Name: PrevBaseTurnRate
		/// Type: FloatProperty
		/// Offset: 0x12D0
		/// Size: 0x04
		/// </summary>
		public float PrevBaseTurnRate
		{
			get
			{
				return ReadSingle(0x12D0);
			}
			set
			{
				WriteSingle(0x12D0,value);
			}
		}
		
		/// <summary>
		/// Name: PreSitTransform
		/// Type: StructProperty
		/// Offset: 0x12E0
		/// Size: 0x30
		/// </summary>
		public FTransform PreSitTransform => ReadStruct<FTransform>(0x12E0);
		
		/// <summary>
		/// Name: b_root
		/// Type: NameProperty
		/// Offset: 0x1310
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Debug_Temp_PreviousPlaceableIndex
		/// Type: IntProperty
		/// Offset: 0x1318
		/// Size: 0x04
		/// </summary>
		public int Debug_Temp_PreviousPlaceableIndex
		{
			get
			{
				return ReadInt32(0x1318);
			}
			set
			{
				WriteInt32(0x1318,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterLayout
		/// Type: StructProperty
		/// Offset: 0x131C
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout CharacterLayout => ReadStruct<FCharacterLayout>(0x131C);
		
		/// <summary>
		/// Name: BedID
		/// Type: ObjectProperty
		/// Offset: 0x1440
		/// Size: 0x08
		/// </summary>
		public UUniqueID BedID => ReadUObject<UUniqueID>(0x1440);
		
		/// <summary>
		/// Name: DismantleReimbursementRatio
		/// Type: FloatProperty
		/// Offset: 0x1448
		/// Size: 0x04
		/// </summary>
		public float DismantleReimbursementRatio
		{
			get
			{
				return ReadSingle(0x1448);
			}
			set
			{
				WriteSingle(0x1448,value);
			}
		}
		
		/// <summary>
		/// Name: ClickTimerHandle
		/// Type: StructProperty
		/// Offset: 0x1450
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ClickTimerHandle => ReadStruct<FTimerHandle>(0x1450);
		
		/// <summary>
		/// Name: WasPrimaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1458
		/// Size: 0x01
		/// </summary>
		public bool WasPrimaryKeyDown
		{
			get
			{
				return ReadBool(0x1458);
			}
			set
			{
				WriteBool(0x1458,value);
			}
		}
		
		/// <summary>
		/// Name: WasSecondaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1459
		/// Size: 0x01
		/// </summary>
		public bool WasSecondaryKeyDown
		{
			get
			{
				return ReadBool(0x1459);
			}
			set
			{
				WriteBool(0x1459,value);
			}
		}
		
		/// <summary>
		/// Name: PickedupLoreItems
		/// Type: TArray<>
		/// Offset: 0x1460
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: BedRollID
		/// Type: ObjectProperty
		/// Offset: 0x1470
		/// Size: 0x08
		/// </summary>
		public UUniqueID BedRollID => ReadUObject<UUniqueID>(0x1470);
		
		/// <summary>
		/// Name: LeftIsValid
		/// Type: BoolProperty
		/// Offset: 0x1478
		/// Size: 0x01
		/// </summary>
		public bool LeftIsValid
		{
			get
			{
				return ReadBool(0x1478);
			}
			set
			{
				WriteBool(0x1478,value);
			}
		}
		
		/// <summary>
		/// Name: RightIsValid
		/// Type: BoolProperty
		/// Offset: 0x1479
		/// Size: 0x01
		/// </summary>
		public bool RightIsValid
		{
			get
			{
				return ReadBool(0x1479);
			}
			set
			{
				WriteBool(0x1479,value);
			}
		}
		
		/// <summary>
		/// Name: LeftIsFist
		/// Type: BoolProperty
		/// Offset: 0x147A
		/// Size: 0x01
		/// </summary>
		public bool LeftIsFist
		{
			get
			{
				return ReadBool(0x147A);
			}
			set
			{
				WriteBool(0x147A,value);
			}
		}
		
		/// <summary>
		/// Name: RightIsFist
		/// Type: BoolProperty
		/// Offset: 0x147B
		/// Size: 0x01
		/// </summary>
		public bool RightIsFist
		{
			get
			{
				return ReadBool(0x147B);
			}
			set
			{
				WriteBool(0x147B,value);
			}
		}
		
		/// <summary>
		/// Name: FistsTimeout
		/// Type: FloatProperty
		/// Offset: 0x147C
		/// Size: 0x04
		/// </summary>
		public float FistsTimeout
		{
			get
			{
				return ReadSingle(0x147C);
			}
			set
			{
				WriteSingle(0x147C,value);
			}
		}
		
		/// <summary>
		/// Name: FistsTimeoutTimer
		/// Type: StructProperty
		/// Offset: 0x1480
		/// Size: 0x08
		/// </summary>
		public FTimerHandle FistsTimeoutTimer => ReadStruct<FTimerHandle>(0x1480);
		
		/// <summary>
		/// Name: HasCrossedDesert
		/// Type: BoolProperty
		/// Offset: 0x1488
		/// Size: 0x01
		/// </summary>
		public bool HasCrossedDesert
		{
			get
			{
				return ReadBool(0x1488);
			}
			set
			{
				WriteBool(0x1488,value);
			}
		}
		
		/// <summary>
		/// Name: BedSpawnTransform
		/// Type: StructProperty
		/// Offset: 0x14A0
		/// Size: 0x30
		/// </summary>
		public FTransform BedSpawnTransform => ReadStruct<FTransform>(0x14A0);
		
		/// <summary>
		/// Name: ThrallRopeActor
		/// Type: ObjectProperty
		/// Offset: 0x14D0
		/// Size: 0x08
		/// </summary>
		public AThrallRopeActor_C ThrallRopeActor => ReadUObject<AThrallRopeActor_C>(0x14D0);
		
		/// <summary>
		/// Name: PreVanity3PCameraStatus
		/// Type: BoolProperty
		/// Offset: 0x14D8
		/// Size: 0x01
		/// </summary>
		public bool PreVanity3PCameraStatus
		{
			get
			{
				return ReadBool(0x14D8);
			}
			set
			{
				WriteBool(0x14D8,value);
			}
		}
		
		/// <summary>
		/// Name: IsInVanityCameraMode
		/// Type: BoolProperty
		/// Offset: 0x14D9
		/// Size: 0x01
		/// </summary>
		public bool IsInVanityCameraMode
		{
			get
			{
				return ReadBool(0x14D9);
			}
			set
			{
				WriteBool(0x14D9,value);
			}
		}
		
		/// <summary>
		/// Name: VanityCameraDefaultTargetArmLength
		/// Type: FloatProperty
		/// Offset: 0x14DC
		/// Size: 0x04
		/// </summary>
		public float VanityCameraDefaultTargetArmLength
		{
			get
			{
				return ReadSingle(0x14DC);
			}
			set
			{
				WriteSingle(0x14DC,value);
			}
		}
		
		/// <summary>
		/// Name: NewTargetArmLength
		/// Type: FloatProperty
		/// Offset: 0x14E0
		/// Size: 0x04
		/// </summary>
		public float NewTargetArmLength
		{
			get
			{
				return ReadSingle(0x14E0);
			}
			set
			{
				WriteSingle(0x14E0,value);
			}
		}
		
		/// <summary>
		/// Name: SprintFOVChange
		/// Type: FloatProperty
		/// Offset: 0x14E4
		/// Size: 0x04
		/// </summary>
		public float SprintFOVChange
		{
			get
			{
				return ReadSingle(0x14E4);
			}
			set
			{
				WriteSingle(0x14E4,value);
			}
		}
		
		/// <summary>
		/// Name: IsMovingFwd
		/// Type: BoolProperty
		/// Offset: 0x14E8
		/// Size: 0x01
		/// </summary>
		public bool IsMovingFwd
		{
			get
			{
				return ReadBool(0x14E8);
			}
			set
			{
				WriteBool(0x14E8,value);
			}
		}
		
		/// <summary>
		/// Name: IsSprintPressed
		/// Type: BoolProperty
		/// Offset: 0x14E9
		/// Size: 0x01
		/// </summary>
		public bool IsSprintPressed
		{
			get
			{
				return ReadBool(0x14E9);
			}
			set
			{
				WriteBool(0x14E9,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeDoubleTapTrigger
		/// Type: FloatProperty
		/// Offset: 0x14EC
		/// Size: 0x04
		/// </summary>
		public float DodgeDoubleTapTrigger
		{
			get
			{
				return ReadSingle(0x14EC);
			}
			set
			{
				WriteSingle(0x14EC,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeLeftGameTime
		/// Type: FloatProperty
		/// Offset: 0x14F0
		/// Size: 0x04
		/// </summary>
		public float DodgeLeftGameTime
		{
			get
			{
				return ReadSingle(0x14F0);
			}
			set
			{
				WriteSingle(0x14F0,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeRightGameTime
		/// Type: FloatProperty
		/// Offset: 0x14F4
		/// Size: 0x04
		/// </summary>
		public float DodgeRightGameTime
		{
			get
			{
				return ReadSingle(0x14F4);
			}
			set
			{
				WriteSingle(0x14F4,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeBackwardGameTime
		/// Type: FloatProperty
		/// Offset: 0x14F8
		/// Size: 0x04
		/// </summary>
		public float DodgeBackwardGameTime
		{
			get
			{
				return ReadSingle(0x14F8);
			}
			set
			{
				WriteSingle(0x14F8,value);
			}
		}
		
		/// <summary>
		/// Name: BreathingTimerHandle
		/// Type: StructProperty
		/// Offset: 0x1500
		/// Size: 0x08
		/// </summary>
		public FTimerHandle BreathingTimerHandle => ReadStruct<FTimerHandle>(0x1500);
		
		/// <summary>
		/// Name: BreathingMeterValue
		/// Type: FloatProperty
		/// Offset: 0x1508
		/// Size: 0x04
		/// </summary>
		public float BreathingMeterValue
		{
			get
			{
				return ReadSingle(0x1508);
			}
			set
			{
				WriteSingle(0x1508,value);
			}
		}
		
		/// <summary>
		/// Name: BreathingMeterMax
		/// Type: FloatProperty
		/// Offset: 0x150C
		/// Size: 0x04
		/// </summary>
		public float BreathingMeterMax
		{
			get
			{
				return ReadSingle(0x150C);
			}
			set
			{
				WriteSingle(0x150C,value);
			}
		}
		
		/// <summary>
		/// Name: DodgeDirectionInputStack
		/// Type: TArray<>
		/// Offset: 0x1510
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: LeftKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1520
		/// Size: 0x01
		/// </summary>
		public bool LeftKeyDown
		{
			get
			{
				return ReadBool(0x1520);
			}
			set
			{
				WriteBool(0x1520,value);
			}
		}
		
		/// <summary>
		/// Name: RightKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1521
		/// Size: 0x01
		/// </summary>
		public bool RightKeyDown
		{
			get
			{
				return ReadBool(0x1521);
			}
			set
			{
				WriteBool(0x1521,value);
			}
		}
		
		/// <summary>
		/// Name: BackwardsKeyDown
		/// Type: BoolProperty
		/// Offset: 0x1522
		/// Size: 0x01
		/// </summary>
		public bool BackwardsKeyDown
		{
			get
			{
				return ReadBool(0x1522);
			}
			set
			{
				WriteBool(0x1522,value);
			}
		}
		
		/// <summary>
		/// Name: WaterPhysicsVolume
		/// Type: ObjectProperty
		/// Offset: 0x1528
		/// Size: 0x08
		/// </summary>
		public APhysicsVolume WaterPhysicsVolume => ReadUObject<APhysicsVolume>(0x1528);
		
		/// <summary>
		/// Name: BreathingMeterWindowRoot
		/// Type: ObjectProperty
		/// Offset: 0x1530
		/// Size: 0x08
		/// </summary>
		public UWindowRoot BreathingMeterWindowRoot => ReadUObject<UWindowRoot>(0x1530);
		
		/// <summary>
		/// Name: BreathingTickTimer
		/// Type: FloatProperty
		/// Offset: 0x1538
		/// Size: 0x04
		/// </summary>
		public float BreathingTickTimer
		{
			get
			{
				return ReadSingle(0x1538);
			}
			set
			{
				WriteSingle(0x1538,value);
			}
		}
		
		/// <summary>
		/// Name: BreathingDrowningTimeInSeconds
		/// Type: FloatProperty
		/// Offset: 0x153C
		/// Size: 0x04
		/// </summary>
		public float BreathingDrowningTimeInSeconds
		{
			get
			{
				return ReadSingle(0x153C);
			}
			set
			{
				WriteSingle(0x153C,value);
			}
		}
		
		/// <summary>
		/// Name: BreathingRechargeTime
		/// Type: FloatProperty
		/// Offset: 0x1540
		/// Size: 0x04
		/// </summary>
		public float BreathingRechargeTime
		{
			get
			{
				return ReadSingle(0x1540);
			}
			set
			{
				WriteSingle(0x1540,value);
			}
		}
		
		/// <summary>
		/// Name: BreathingDrainTime
		/// Type: FloatProperty
		/// Offset: 0x1544
		/// Size: 0x04
		/// </summary>
		public float BreathingDrainTime
		{
			get
			{
				return ReadSingle(0x1544);
			}
			set
			{
				WriteSingle(0x1544,value);
			}
		}
		
		/// <summary>
		/// Name: AutorunEnabled
		/// Type: BoolProperty
		/// Offset: 0x1548
		/// Size: 0x01
		/// </summary>
		public bool AutorunEnabled
		{
			get
			{
				return ReadBool(0x1548);
			}
			set
			{
				WriteBool(0x1548,value);
			}
		}
		
		/// <summary>
		/// Name: CombatMusicTimer
		/// Type: StructProperty
		/// Offset: 0x1550
		/// Size: 0x08
		/// </summary>
		public FTimerHandle CombatMusicTimer => ReadStruct<FTimerHandle>(0x1550);
		
		/// <summary>
		/// Name: TargetingNPCTestTimer
		/// Type: StructProperty
		/// Offset: 0x1578
		/// Size: 0x08
		/// </summary>
		public FTimerHandle TargetingNPCTestTimer => ReadStruct<FTimerHandle>(0x1578);
		
		/// <summary>
		/// Name: IsPossessed
		/// Type: BoolProperty
		/// Offset: 0x1580
		/// Size: 0x01
		/// </summary>
		public bool IsPossessed
		{
			get
			{
				return ReadBool(0x1580);
			}
			set
			{
				WriteBool(0x1580,value);
			}
		}
		
		/// <summary>
		/// Name: VanityCameraMaxArmLength
		/// Type: FloatProperty
		/// Offset: 0x1584
		/// Size: 0x04
		/// </summary>
		public float VanityCameraMaxArmLength
		{
			get
			{
				return ReadSingle(0x1584);
			}
			set
			{
				WriteSingle(0x1584,value);
			}
		}
		
		/// <summary>
		/// Name: VanityCameraMinArmLength
		/// Type: FloatProperty
		/// Offset: 0x1588
		/// Size: 0x04
		/// </summary>
		public float VanityCameraMinArmLength
		{
			get
			{
				return ReadSingle(0x1588);
			}
			set
			{
				WriteSingle(0x1588,value);
			}
		}
		
		/// <summary>
		/// Name: OldController
		/// Type: ObjectProperty
		/// Offset: 0x1590
		/// Size: 0x08
		/// </summary>
		public AController OldController => ReadUObject<AController>(0x1590);
		
		/// <summary>
		/// Name: ThirdPersonCameraDefaultTargetArmLength
		/// Type: FloatProperty
		/// Offset: 0x1598
		/// Size: 0x04
		/// </summary>
		public float ThirdPersonCameraDefaultTargetArmLength
		{
			get
			{
				return ReadSingle(0x1598);
			}
			set
			{
				WriteSingle(0x1598,value);
			}
		}
		
		/// <summary>
		/// Name: ThirdPersonCameraMaxArmLength
		/// Type: FloatProperty
		/// Offset: 0x159C
		/// Size: 0x04
		/// </summary>
		public float ThirdPersonCameraMaxArmLength
		{
			get
			{
				return ReadSingle(0x159C);
			}
			set
			{
				WriteSingle(0x159C,value);
			}
		}
		
		/// <summary>
		/// Name: ThirdPersonCameraMinArmLength
		/// Type: FloatProperty
		/// Offset: 0x15A0
		/// Size: 0x04
		/// </summary>
		public float ThirdPersonCameraMinArmLength
		{
			get
			{
				return ReadSingle(0x15A0);
			}
			set
			{
				WriteSingle(0x15A0,value);
			}
		}
		
		/// <summary>
		/// Name: AllowDeathCamRotation
		/// Type: BoolProperty
		/// Offset: 0x15A4
		/// Size: 0x01
		/// </summary>
		public bool AllowDeathCamRotation
		{
			get
			{
				return ReadBool(0x15A4);
			}
			set
			{
				WriteBool(0x15A4,value);
			}
		}
		
		/// <summary>
		/// Name: LockRotatingCharacter
		/// Type: BoolProperty
		/// Offset: 0x15A5
		/// Size: 0x01
		/// </summary>
		public bool LockRotatingCharacter
		{
			get
			{
				return ReadBool(0x15A5);
			}
			set
			{
				WriteBool(0x15A5,value);
			}
		}
		
		/// <summary>
		/// Name: BlockVanityCam
		/// Type: BoolProperty
		/// Offset: 0x15A6
		/// Size: 0x01
		/// </summary>
		public bool BlockVanityCam
		{
			get
			{
				return ReadBool(0x15A6);
			}
			set
			{
				WriteBool(0x15A6,value);
			}
		}
		
		/// <summary>
		/// Name: CameraZoomAmount
		/// Type: FloatProperty
		/// Offset: 0x15A8
		/// Size: 0x04
		/// </summary>
		public float CameraZoomAmount
		{
			get
			{
				return ReadSingle(0x15A8);
			}
			set
			{
				WriteSingle(0x15A8,value);
			}
		}
		
		/// <summary>
		/// Name: ZoomSmoothSpeed
		/// Type: FloatProperty
		/// Offset: 0x15AC
		/// Size: 0x04
		/// </summary>
		public float ZoomSmoothSpeed
		{
			get
			{
				return ReadSingle(0x15AC);
			}
			set
			{
				WriteSingle(0x15AC,value);
			}
		}
		
		/// <summary>
		/// Name: SummonRay
		/// Type: ObjectProperty
		/// Offset: 0x15B0
		/// Size: 0x08
		/// </summary>
		public AActor SummonRay => ReadUObject<AActor>(0x15B0);
		
		/// <summary>
		/// Name: SummoningAvatar
		/// Type: ClassProperty
		/// Offset: 0x15B8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: HasInitialised
		/// Type: BoolProperty
		/// Offset: 0x15C0
		/// Size: 0x01
		/// </summary>
		public bool HasInitialised
		{
			get
			{
				return ReadBool(0x15C0);
			}
			set
			{
				WriteBool(0x15C0,value);
			}
		}
		
		/// <summary>
		/// Name: WasQueuePrimaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x15C1
		/// Size: 0x01
		/// </summary>
		public bool WasQueuePrimaryKeyDown
		{
			get
			{
				return ReadBool(0x15C1);
			}
			set
			{
				WriteBool(0x15C1,value);
			}
		}
		
		/// <summary>
		/// Name: WasQueueSecondaryKeyDown
		/// Type: BoolProperty
		/// Offset: 0x15C2
		/// Size: 0x01
		/// </summary>
		public bool WasQueueSecondaryKeyDown
		{
			get
			{
				return ReadBool(0x15C2);
			}
			set
			{
				WriteBool(0x15C2,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerController
		/// Type: ObjectProperty
		/// Offset: 0x15C8
		/// Size: 0x08
		/// </summary>
		public AFunCombat_PlayerController_C PlayerController => ReadUObject<AFunCombat_PlayerController_C>(0x15C8);
		
		/// <summary>
		/// Name: EquipTimer
		/// Type: StructProperty
		/// Offset: 0x15D0
		/// Size: 0x08
		/// </summary>
		public FTimerHandle EquipTimer => ReadStruct<FTimerHandle>(0x15D0);
		
		/// <summary>
		/// Name: LastBoundToBedRoll
		/// Type: BoolProperty
		/// Offset: 0x15D8
		/// Size: 0x01
		/// </summary>
		public bool LastBoundToBedRoll
		{
			get
			{
				return ReadBool(0x15D8);
			}
			set
			{
				WriteBool(0x15D8,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_CharacterCustomizationComponent_C:UCharacterCustomizationComponent
	/// Size: 0x438
	/// Properties: 1
	/// </summary>
	public class UBP_CharacterCustomizationComponent_C:UCharacterCustomizationComponent
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x430);
		
	}


	/// <summary>
	/// UCharacterAssembleLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCharacterAssembleLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ACorpse_C:ACorpseBase
	/// Size: 0x48C
	/// Properties: 17
	/// </summary>
	public class ACorpse_C:ACorpseBase
	{
		public override int ObjectSize => 1164;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
		/// <summary>
		/// Name: FloatingName
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UWidgetComponent FloatingName => ReadUObject<UWidgetComponent>(0x3F0);
		
		/// <summary>
		/// Name: ItemInventory
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UItemInventory ItemInventory => ReadUObject<UItemInventory>(0x3F8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x400);
		
		/// <summary>
		/// Name: BP_AC_LootSpawner
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UBP_AC_LootSpawner_C BP_AC_LootSpawner => ReadUObject<UBP_AC_LootSpawner_C>(0x408);
		
		/// <summary>
		/// Name: DynamicMaterialParamController
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UDynamicMaterialParamController_C DynamicMaterialParamController => ReadUObject<UDynamicMaterialParamController_C>(0x410);
		
		/// <summary>
		/// Name: HarvestableComponent_v2
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UHarvestableComponent_v2_C HarvestableComponent_v2 => ReadUObject<UHarvestableComponent_v2_C>(0x418);
		
		/// <summary>
		/// Name: DespawnTime
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float DespawnTime
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: PrimaryPhysicsMaterial
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial PrimaryPhysicsMaterial => ReadUObject<UPhysicalMaterial>(0x428);
		
		/// <summary>
		/// Name: PoseSnapshot
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x10
		/// </summary>
		public FPoseSnapshot PoseSnapshot => ReadStruct<FPoseSnapshot>(0x430);
		
		/// <summary>
		/// Name: ResourcePhysicalMaterial
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial ResourcePhysicalMaterial => ReadUObject<UPhysicalMaterial>(0x440);
		
		/// <summary>
		/// Name: CorpseOwner
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public AActor CorpseOwner => ReadUObject<AActor>(0x448);
		
		/// <summary>
		/// Name: LootTableFound
		/// Type: StructProperty
		/// Offset: 0x450
		/// Size: 0x18
		/// </summary>
		public FLootTable_Weight_Structure LootTableFound => ReadStruct<FLootTable_Weight_Structure>(0x450);
		
		/// <summary>
		/// Name: Layout
		/// Type: TArray<FCharacterLayout>
		/// Offset: 0x468
		/// Size: 0x10
		/// SubElement Size: 0x124
		/// </summary>
		public TArray<FCharacterLayout> Layout => new TArray<FCharacterLayout>(BaseAddress+0x468);
		
		/// <summary>
		/// Name: deadPlayerID
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UUniqueID deadPlayerID => ReadUObject<UUniqueID>(0x478);
		
		/// <summary>
		/// Name: timeStamp
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FDateTime timeStamp => ReadStruct<FDateTime>(0x480);
		
		/// <summary>
		/// Name: HarvestInitializationDelayTime
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float HarvestInitializationDelayTime
		{
			get
			{
				return ReadSingle(0x488);
			}
			set
			{
				WriteSingle(0x488,value);
			}
		}
		
	}


	/// <summary>
	/// UBody_C:UActorComponent
	/// Size: 0x150
	/// Properties: 9
	/// </summary>
	public class UBody_C:UActorComponent
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: MainMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UDismemberedBodySkeletalMesh_C MainMeshComponent => ReadUObject<UDismemberedBodySkeletalMesh_C>(0xE0);
		
		/// <summary>
		/// Name: SkeletalMeshes
		/// Type: TArray<USkeletalMesh>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x240
		/// </summary>
		public TArray<USkeletalMesh> SkeletalMeshes => new TArray<USkeletalMesh>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: PhysicsAsset
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset PhysicsAsset => ReadUObject<UPhysicsAsset>(0xF8);
		
		/// <summary>
		/// Name: SimulateUnderBones
		/// Type: TArray<FName>
		/// Offset: 0x100
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> SimulateUnderBones => new TArray<FName>(BaseAddress+0x100);
		
		/// <summary>
		/// Name: SkeletalMeshComponents
		/// Type: TArray<USkeletalMeshComponent>
		/// Offset: 0x110
		/// Size: 0x10
		/// SubElement Size: 0xD20
		/// </summary>
		public TArray<USkeletalMeshComponent> SkeletalMeshComponents => new TArray<USkeletalMeshComponent>(BaseAddress+0x110);
		
		/// <summary>
		/// Name: ImpulseFromHit
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x0C
		/// </summary>
		public FVector ImpulseFromHit => ReadStruct<FVector>(0x120);
		
		/// <summary>
		/// Name: Materials
		/// Type: TArray<UMaterialInterface>
		/// Offset: 0x130
		/// Size: 0x10
		/// SubElement Size: 0x58
		/// </summary>
		public TArray<UMaterialInterface> Materials => new TArray<UMaterialInterface>(BaseAddress+0x130);
		
		/// <summary>
		/// Name: PoseSnapshot
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x10
		/// </summary>
		public FPoseSnapshot PoseSnapshot => ReadStruct<FPoseSnapshot>(0x140);
		
	}


	/// <summary>
	/// UDismemberedBodySkeletalMesh_C:UFuncomSkeletalMeshComponent
	/// Size: 0xD41
	/// Properties: 1
	/// </summary>
	public class UDismemberedBodySkeletalMesh_C:UFuncomSkeletalMeshComponent
	{
		public override int ObjectSize => 3393;
		/// <summary>
		/// Name: BodyPart
		/// Type: ByteProperty
		/// Offset: 0xD40
		/// Size: 0x01
		/// </summary>
		public byte BodyPart
		{
			get
			{
				return ReadByte(0xD40);
			}
			set
			{
				WriteByte(0xD40,value);
			}
		}
		
	}


	/// <summary>
	/// UDismemberedBody_C:UBP_CharacterCustomizationComponent_C
	/// Size: 0x4A8
	/// Properties: 8
	/// </summary>
	public class UDismemberedBody_C:UBP_CharacterCustomizationComponent_C
	{
		public override int ObjectSize => 1192;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x438);
		
		/// <summary>
		/// Name: PhysicsAsset
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset PhysicsAsset => ReadUObject<UPhysicsAsset>(0x440);
		
		/// <summary>
		/// Name: SimulateUnderBone
		/// Type: TArray<FName>
		/// Offset: 0x448
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> SimulateUnderBone => new TArray<FName>(BaseAddress+0x448);
		
		/// <summary>
		/// Name: OptionalParticleSystem
		/// Type: TArray<UParticleSystem>
		/// Offset: 0x458
		/// Size: 0x10
		/// SubElement Size: 0x138
		/// </summary>
		public TArray<UParticleSystem> OptionalParticleSystem => new TArray<UParticleSystem>(BaseAddress+0x458);
		
		/// <summary>
		/// Name: OptionalParticleAttachment
		/// Type: TArray<FName>
		/// Offset: 0x468
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> OptionalParticleAttachment => new TArray<FName>(BaseAddress+0x468);
		
		/// <summary>
		/// Name: OptionalParticleTransforms
		/// Type: TArray<FTransform>
		/// Offset: 0x478
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FTransform> OptionalParticleTransforms => new TArray<FTransform>(BaseAddress+0x478);
		
		/// <summary>
		/// Name: ImpulseFromHit
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x0C
		/// </summary>
		public FVector ImpulseFromHit => ReadStruct<FVector>(0x488);
		
		/// <summary>
		/// Name: PoseSnapshot
		/// Type: StructProperty
		/// Offset: 0x498
		/// Size: 0x10
		/// </summary>
		public FPoseSnapshot PoseSnapshot => ReadStruct<FPoseSnapshot>(0x498);
		
	}


	/// <summary>
	/// UI_HasCharacterLayoutInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_HasCharacterLayoutInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UCameraShake_Landing_C:UCameraShake
	/// Size: 0x160
	/// Properties: 0
	/// </summary>
	public class UCameraShake_Landing_C:UCameraShake
	{
		public override int ObjectSize => 352;
	}


	/// <summary>
	/// ABP_ConanPlayerStart_C:APlayerStart
	/// Size: 0x408
	/// Properties: 1
	/// </summary>
	public class ABP_ConanPlayerStart_C:APlayerStart
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x400);
		
	}


	/// <summary>
	/// ACinematicCharacter_C:ASkeletalMeshActor
	/// Size: 0x5B0
	/// Properties: 11
	/// </summary>
	public class ACinematicCharacter_C:ASkeletalMeshActor
	{
		public override int ObjectSize => 1456;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x458);
		
		/// <summary>
		/// Name: BP_CharacterCustomizationComponent
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterCustomizationComponent_C BP_CharacterCustomizationComponent => ReadUObject<UBP_CharacterCustomizationComponent_C>(0x460);
		
		/// <summary>
		/// Name: VoicePreviewComponent
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent VoicePreviewComponent => ReadUObject<UConanAudioComponent>(0x468);
		
		/// <summary>
		/// Name: Voice
		/// Type: ByteProperty
		/// Offset: 0x470
		/// Size: 0x01
		/// </summary>
		public byte Voice
		{
			get
			{
				return ReadByte(0x470);
			}
			set
			{
				WriteByte(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: JawHeight
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float JawHeight
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
		/// Name: NoseExtrusion
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float NoseExtrusion
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
		
		/// <summary>
		/// Name: MouthHeight
		/// Type: FloatProperty
		/// Offset: 0x47C
		/// Size: 0x04
		/// </summary>
		public float MouthHeight
		{
			get
			{
				return ReadSingle(0x47C);
			}
			set
			{
				WriteSingle(0x47C,value);
			}
		}
		
		/// <summary>
		/// Name: MouthWidth
		/// Type: FloatProperty
		/// Offset: 0x480
		/// Size: 0x04
		/// </summary>
		public float MouthWidth
		{
			get
			{
				return ReadSingle(0x480);
			}
			set
			{
				WriteSingle(0x480,value);
			}
		}
		
		/// <summary>
		/// Name: MouthScale
		/// Type: FloatProperty
		/// Offset: 0x484
		/// Size: 0x04
		/// </summary>
		public float MouthScale
		{
			get
			{
				return ReadSingle(0x484);
			}
			set
			{
				WriteSingle(0x484,value);
			}
		}
		
		/// <summary>
		/// Name: MouthExtrusion
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float MouthExtrusion
		{
			get
			{
				return ReadSingle(0x488);
			}
			set
			{
				WriteSingle(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterLayout
		/// Type: StructProperty
		/// Offset: 0x48C
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout CharacterLayout => ReadStruct<FCharacterLayout>(0x48C);
		
	}


	/// <summary>
	/// ABaseBPWildlife_C:ABaseNPC_C
	/// Size: 0x1110
	/// Properties: 6
	/// </summary>
	public class ABaseBPWildlife_C:ABaseNPC_C
	{
		public override int ObjectSize => 4368;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x10E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x10E8);
		
		/// <summary>
		/// Name: DynamicMaterialParamController
		/// Type: ObjectProperty
		/// Offset: 0x10F0
		/// Size: 0x08
		/// </summary>
		public UDynamicMaterialParamController_C DynamicMaterialParamController => ReadUObject<UDynamicMaterialParamController_C>(0x10F0);
		
		/// <summary>
		/// Name: Scale
		/// Type: FloatProperty
		/// Offset: 0x10F8
		/// Size: 0x04
		/// </summary>
		public float Scale
		{
			get
			{
				return ReadSingle(0x10F8);
			}
			set
			{
				WriteSingle(0x10F8,value);
			}
		}
		
		/// <summary>
		/// Name: MinScale
		/// Type: FloatProperty
		/// Offset: 0x10FC
		/// Size: 0x04
		/// </summary>
		public float MinScale
		{
			get
			{
				return ReadSingle(0x10FC);
			}
			set
			{
				WriteSingle(0x10FC,value);
			}
		}
		
		/// <summary>
		/// Name: MaxScale
		/// Type: FloatProperty
		/// Offset: 0x1100
		/// Size: 0x04
		/// </summary>
		public float MaxScale
		{
			get
			{
				return ReadSingle(0x1100);
			}
			set
			{
				WriteSingle(0x1100,value);
			}
		}
		
		/// <summary>
		/// Name: HitLocationPhysicalOverride
		/// Type: ObjectProperty
		/// Offset: 0x1108
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial HitLocationPhysicalOverride => ReadUObject<UPhysicalMaterial>(0x1108);
		
	}


}

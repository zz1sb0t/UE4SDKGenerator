using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Tools.CommandPanel;
using ConanExilesGame.Game.Systems.AI.Navigation;
using ConanExilesGame.Game.Systems.Camps;
using ConanExilesGame.Game.Environment.Sandstorm;
using ConanExilesGame.Game.Systems.Spawning;
using ConanExilesGame.Game.UI.MainMenu;


namespace ConanExilesGame.Game.Systems
{
	/// <summary>
	/// ABP_ServerSettings_C:AServerSettings
	/// Size: 0x629
	/// Properties: 52
	/// </summary>
	public class ABP_ServerSettings_C:AServerSettings
	{
		public override int ObjectSize => 1577;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x568
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x568);
		
		/// <summary>
		/// Name: PlayerWaterMultiplier
		/// Type: FloatProperty
		/// Offset: 0x570
		/// Size: 0x04
		/// </summary>
		public float PlayerWaterMultiplier
		{
			get
			{
				return ReadSingle(0x570);
			}
			set
			{
				WriteSingle(0x570,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerIdleThirstMultiplier
		/// Type: FloatProperty
		/// Offset: 0x574
		/// Size: 0x04
		/// </summary>
		public float PlayerIdleThirstMultiplier
		{
			get
			{
				return ReadSingle(0x574);
			}
			set
			{
				WriteSingle(0x574,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerActiveThirstMultiplier
		/// Type: FloatProperty
		/// Offset: 0x578
		/// Size: 0x04
		/// </summary>
		public float PlayerActiveThirstMultiplier
		{
			get
			{
				return ReadSingle(0x578);
			}
			set
			{
				WriteSingle(0x578,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerOfflineThirstMultiplier
		/// Type: FloatProperty
		/// Offset: 0x57C
		/// Size: 0x04
		/// </summary>
		public float PlayerOfflineThirstMultiplier
		{
			get
			{
				return ReadSingle(0x57C);
			}
			set
			{
				WriteSingle(0x57C,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerIdleHungerMultiplier
		/// Type: FloatProperty
		/// Offset: 0x580
		/// Size: 0x04
		/// </summary>
		public float PlayerIdleHungerMultiplier
		{
			get
			{
				return ReadSingle(0x580);
			}
			set
			{
				WriteSingle(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerActiveHungerMultiplier
		/// Type: FloatProperty
		/// Offset: 0x584
		/// Size: 0x04
		/// </summary>
		public float PlayerActiveHungerMultiplier
		{
			get
			{
				return ReadSingle(0x584);
			}
			set
			{
				WriteSingle(0x584,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerOfflineHungerMultiplier
		/// Type: FloatProperty
		/// Offset: 0x588
		/// Size: 0x04
		/// </summary>
		public float PlayerOfflineHungerMultiplier
		{
			get
			{
				return ReadSingle(0x588);
			}
			set
			{
				WriteSingle(0x588,value);
			}
		}
		
		/// <summary>
		/// Name: ShieldDurabilityMultiplier
		/// Type: FloatProperty
		/// Offset: 0x58C
		/// Size: 0x04
		/// </summary>
		public float ShieldDurabilityMultiplier
		{
			get
			{
				return ReadSingle(0x58C);
			}
			set
			{
				WriteSingle(0x58C,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerKnockbackMultiplier
		/// Type: FloatProperty
		/// Offset: 0x590
		/// Size: 0x04
		/// </summary>
		public float PlayerKnockbackMultiplier
		{
			get
			{
				return ReadSingle(0x590);
			}
			set
			{
				WriteSingle(0x590,value);
			}
		}
		
		/// <summary>
		/// Name: NPCKnockbackMultiplier
		/// Type: FloatProperty
		/// Offset: 0x594
		/// Size: 0x04
		/// </summary>
		public float NPCKnockbackMultiplier
		{
			get
			{
				return ReadSingle(0x594);
			}
			set
			{
				WriteSingle(0x594,value);
			}
		}
		
		/// <summary>
		/// Name: StructureDamageMultiplier
		/// Type: FloatProperty
		/// Offset: 0x598
		/// Size: 0x04
		/// </summary>
		public float StructureDamageMultiplier
		{
			get
			{
				return ReadSingle(0x598);
			}
			set
			{
				WriteSingle(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: StructureDamageTakenMultiplier
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float StructureDamageTakenMultiplier
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: StructureHealthMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public float StructureHealthMultiplier
		{
			get
			{
				return ReadSingle(0x5A0);
			}
			set
			{
				WriteSingle(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: NPCRespawnMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public float NPCRespawnMultiplier
		{
			get
			{
				return ReadSingle(0x5A4);
			}
			set
			{
				WriteSingle(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: NPCHealthMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public float NPCHealthMultiplier
		{
			get
			{
				return ReadSingle(0x5A8);
			}
			set
			{
				WriteSingle(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: CraftingCostMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public float CraftingCostMultiplier
		{
			get
			{
				return ReadSingle(0x5AC);
			}
			set
			{
				WriteSingle(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerDamageMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5B0
		/// Size: 0x04
		/// </summary>
		public float PlayerDamageMultiplier
		{
			get
			{
				return ReadSingle(0x5B0);
			}
			set
			{
				WriteSingle(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerDamageTakenMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5B4
		/// Size: 0x04
		/// </summary>
		public float PlayerDamageTakenMultiplier
		{
			get
			{
				return ReadSingle(0x5B4);
			}
			set
			{
				WriteSingle(0x5B4,value);
			}
		}
		
		/// <summary>
		/// Name: MinionDamageMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5B8
		/// Size: 0x04
		/// </summary>
		public float MinionDamageMultiplier
		{
			get
			{
				return ReadSingle(0x5B8);
			}
			set
			{
				WriteSingle(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: MinionDamageTakenMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5BC
		/// Size: 0x04
		/// </summary>
		public float MinionDamageTakenMultiplier
		{
			get
			{
				return ReadSingle(0x5BC);
			}
			set
			{
				WriteSingle(0x5BC,value);
			}
		}
		
		/// <summary>
		/// Name: NPCDamageMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5C0
		/// Size: 0x04
		/// </summary>
		public float NPCDamageMultiplier
		{
			get
			{
				return ReadSingle(0x5C0);
			}
			set
			{
				WriteSingle(0x5C0,value);
			}
		}
		
		/// <summary>
		/// Name: NPCDamageTakenMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5C4
		/// Size: 0x04
		/// </summary>
		public float NPCDamageTakenMultiplier
		{
			get
			{
				return ReadSingle(0x5C4);
			}
			set
			{
				WriteSingle(0x5C4,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerEncumbranceMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5C8
		/// Size: 0x04
		/// </summary>
		public float PlayerEncumbranceMultiplier
		{
			get
			{
				return ReadSingle(0x5C8);
			}
			set
			{
				WriteSingle(0x5C8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerEncumbrancePenaltyMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5CC
		/// Size: 0x04
		/// </summary>
		public float PlayerEncumbrancePenaltyMultiplier
		{
			get
			{
				return ReadSingle(0x5CC);
			}
			set
			{
				WriteSingle(0x5CC,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerMovementSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x5D0
		/// Size: 0x04
		/// </summary>
		public float PlayerMovementSpeedScale
		{
			get
			{
				return ReadSingle(0x5D0);
			}
			set
			{
				WriteSingle(0x5D0,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerStaminaCostSprintMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5D4
		/// Size: 0x04
		/// </summary>
		public float PlayerStaminaCostSprintMultiplier
		{
			get
			{
				return ReadSingle(0x5D4);
			}
			set
			{
				WriteSingle(0x5D4,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerSprintSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x5D8
		/// Size: 0x04
		/// </summary>
		public float PlayerSprintSpeedScale
		{
			get
			{
				return ReadSingle(0x5D8);
			}
			set
			{
				WriteSingle(0x5D8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerStaminaCostMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5DC
		/// Size: 0x04
		/// </summary>
		public float PlayerStaminaCostMultiplier
		{
			get
			{
				return ReadSingle(0x5DC);
			}
			set
			{
				WriteSingle(0x5DC,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerHealthRegenSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x5E0
		/// Size: 0x04
		/// </summary>
		public float PlayerHealthRegenSpeedScale
		{
			get
			{
				return ReadSingle(0x5E0);
			}
			set
			{
				WriteSingle(0x5E0,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerStaminaRegenSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x5E4
		/// Size: 0x04
		/// </summary>
		public float PlayerStaminaRegenSpeedScale
		{
			get
			{
				return ReadSingle(0x5E4);
			}
			set
			{
				WriteSingle(0x5E4,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerXPRateMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5E8
		/// Size: 0x04
		/// </summary>
		public float PlayerXPRateMultiplier
		{
			get
			{
				return ReadSingle(0x5E8);
			}
			set
			{
				WriteSingle(0x5E8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerXPKillMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5EC
		/// Size: 0x04
		/// </summary>
		public float PlayerXPKillMultiplier
		{
			get
			{
				return ReadSingle(0x5EC);
			}
			set
			{
				WriteSingle(0x5EC,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerXPHarvestMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5F0
		/// Size: 0x04
		/// </summary>
		public float PlayerXPHarvestMultiplier
		{
			get
			{
				return ReadSingle(0x5F0);
			}
			set
			{
				WriteSingle(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerXPCraftMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5F4
		/// Size: 0x04
		/// </summary>
		public float PlayerXPCraftMultiplier
		{
			get
			{
				return ReadSingle(0x5F4);
			}
			set
			{
				WriteSingle(0x5F4,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerXPTimeMultiplier
		/// Type: FloatProperty
		/// Offset: 0x5F8
		/// Size: 0x04
		/// </summary>
		public float PlayerXPTimeMultiplier
		{
			get
			{
				return ReadSingle(0x5F8);
			}
			set
			{
				WriteSingle(0x5F8,value);
			}
		}
		
		/// <summary>
		/// Name: DogsOfTheDesertSpawnWithDogs
		/// Type: BoolProperty
		/// Offset: 0x5FC
		/// Size: 0x01
		/// </summary>
		public bool DogsOfTheDesertSpawnWithDogs
		{
			get
			{
				return ReadBool(0x5FC);
			}
			set
			{
				WriteBool(0x5FC,value);
			}
		}
		
		/// <summary>
		/// Name: CrossDesertOnce
		/// Type: BoolProperty
		/// Offset: 0x5FD
		/// Size: 0x01
		/// </summary>
		public bool CrossDesertOnce
		{
			get
			{
				return ReadBool(0x5FD);
			}
			set
			{
				WriteBool(0x5FD,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponEffectBoundsShorteningFraction
		/// Type: FloatProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public float WeaponEffectBoundsShorteningFraction
		{
			get
			{
				return ReadSingle(0x600);
			}
			set
			{
				WriteSingle(0x600,value);
			}
		}
		
		/// <summary>
		/// Name: EnforceRotationRateWhenRoaming
		/// Type: BoolProperty
		/// Offset: 0x604
		/// Size: 0x01
		/// </summary>
		public bool EnforceRotationRateWhenRoaming
		{
			get
			{
				return ReadBool(0x604);
			}
			set
			{
				WriteBool(0x604,value);
			}
		}
		
		/// <summary>
		/// Name: EnforceRotationRateInCombat
		/// Type: BoolProperty
		/// Offset: 0x605
		/// Size: 0x01
		/// </summary>
		public bool EnforceRotationRateInCombat
		{
			get
			{
				return ReadBool(0x605);
			}
			set
			{
				WriteBool(0x605,value);
			}
		}
		
		/// <summary>
		/// Name: ClipVelocityOnNavmeshBoundary
		/// Type: BoolProperty
		/// Offset: 0x606
		/// Size: 0x01
		/// </summary>
		public bool ClipVelocityOnNavmeshBoundary
		{
			get
			{
				return ReadBool(0x606);
			}
			set
			{
				WriteBool(0x606,value);
			}
		}
		
		/// <summary>
		/// Name: UnarmedNPCStepBackDistance
		/// Type: FloatProperty
		/// Offset: 0x608
		/// Size: 0x04
		/// </summary>
		public float UnarmedNPCStepBackDistance
		{
			get
			{
				return ReadSingle(0x608);
			}
			set
			{
				WriteSingle(0x608,value);
			}
		}
		
		/// <summary>
		/// Name: PathFollowingAvoidanceMode
		/// Type: ByteProperty
		/// Offset: 0x60C
		/// Size: 0x01
		/// </summary>
		public byte PathFollowingAvoidanceMode
		{
			get
			{
				return ReadByte(0x60C);
			}
			set
			{
				WriteByte(0x60C,value);
			}
		}
		
		/// <summary>
		/// Name: RotateToTargetSendsAngularVelocity
		/// Type: BoolProperty
		/// Offset: 0x60D
		/// Size: 0x01
		/// </summary>
		public bool RotateToTargetSendsAngularVelocity
		{
			get
			{
				return ReadBool(0x60D);
			}
			set
			{
				WriteBool(0x60D,value);
			}
		}
		
		/// <summary>
		/// Name: OldVersion
		/// Type: IntProperty
		/// Offset: 0x610
		/// Size: 0x04
		/// </summary>
		public int OldVersion
		{
			get
			{
				return ReadInt32(0x610);
			}
			set
			{
				WriteInt32(0x610,value);
			}
		}
		
		/// <summary>
		/// Name: NewVersion
		/// Type: IntProperty
		/// Offset: 0x614
		/// Size: 0x04
		/// </summary>
		public int NewVersion
		{
			get
			{
				return ReadInt32(0x614);
			}
			set
			{
				WriteInt32(0x614,value);
			}
		}
		
		/// <summary>
		/// Name: TargetPredictionMaxSeconds
		/// Type: FloatProperty
		/// Offset: 0x618
		/// Size: 0x04
		/// </summary>
		public float TargetPredictionMaxSeconds
		{
			get
			{
				return ReadSingle(0x618);
			}
			set
			{
				WriteSingle(0x618,value);
			}
		}
		
		/// <summary>
		/// Name: TargetPredictionAllowSecondsForAttack
		/// Type: FloatProperty
		/// Offset: 0x61C
		/// Size: 0x04
		/// </summary>
		public float TargetPredictionAllowSecondsForAttack
		{
			get
			{
				return ReadSingle(0x61C);
			}
			set
			{
				WriteSingle(0x61C,value);
			}
		}
		
		/// <summary>
		/// Name: ThrallExclusionRadius
		/// Type: FloatProperty
		/// Offset: 0x620
		/// Size: 0x04
		/// </summary>
		public float ThrallExclusionRadius
		{
			get
			{
				return ReadSingle(0x620);
			}
			set
			{
				WriteSingle(0x620,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAggroRange
		/// Type: FloatProperty
		/// Offset: 0x624
		/// Size: 0x04
		/// </summary>
		public float MaxAggroRange
		{
			get
			{
				return ReadSingle(0x624);
			}
			set
			{
				WriteSingle(0x624,value);
			}
		}
		
		/// <summary>
		/// Name: AllowNPCRotationDuringAttack
		/// Type: BoolProperty
		/// Offset: 0x628
		/// Size: 0x01
		/// </summary>
		public bool AllowNPCRotationDuringAttack
		{
			get
			{
				return ReadBool(0x628);
			}
			set
			{
				WriteBool(0x628,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_ConanGameInstance_C:UConanGameInstance
	/// Size: 0x2E4
	/// Properties: 3
	/// </summary>
	public class UBP_ConanGameInstance_C:UConanGameInstance
	{
		public override int ObjectSize => 740;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x2C0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x2C0);
		
		/// <summary>
		/// Name: LoadingProgress
		/// Type: StructProperty
		/// Offset: 0x2D8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle LoadingProgress => ReadStruct<FTimerHandle>(0x2D8);
		
		/// <summary>
		/// Name: Timeout
		/// Type: FloatProperty
		/// Offset: 0x2E0
		/// Size: 0x04
		/// </summary>
		public float Timeout
		{
			get
			{
				return ReadSingle(0x2E0);
			}
			set
			{
				WriteSingle(0x2E0,value);
			}
		}
		
	}


	/// <summary>
	/// ABaseGameState_C:AConanGameState
	/// Size: 0x538
	/// Properties: 5
	/// </summary>
	public class ABaseGameState_C:AConanGameState
	{
		public override int ObjectSize => 1336;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x500);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x508
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x508);
		
		/// <summary>
		/// Name: GlobalImpulseMultiplier
		/// Type: FloatProperty
		/// Offset: 0x510
		/// Size: 0x04
		/// </summary>
		public float GlobalImpulseMultiplier
		{
			get
			{
				return ReadSingle(0x510);
			}
			set
			{
				WriteSingle(0x510,value);
			}
		}
		
		/// <summary>
		/// Name: SummonedAvatarTypes
		/// Type: TArray<>
		/// Offset: 0x518
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SummonedAvatarSummoners
		/// Type: TArray<AConanCharacter>
		/// Offset: 0x528
		/// Size: 0x10
		/// SubElement Size: 0xA60
		/// </summary>
		public TArray<AConanCharacter> SummonedAvatarSummoners => new TArray<AConanCharacter>(BaseAddress+0x528);
		
	}


	/// <summary>
	/// UMiscFunctions_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMiscFunctions_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// FST_SubstateRule:
	/// Size: 0x40
	/// Properties: 4
	/// </summary>
	public class FST_SubstateRule:MemoryObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: OnEnter_ExitThese_12_5288A32B46753EADDF2B77AE98FD65B8
		/// Type: TArray<>
		/// Offset: 0x00
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OnEnter_EnterThese_13_63EC20354CD3E8EB760A8796FE7533C3
		/// Type: TArray<>
		/// Offset: 0x10
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OnExit_ExitThese_14_25AC9880486BD177DDD480A3889F059A
		/// Type: TArray<>
		/// Offset: 0x20
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OnExit_EnterThese_15_11C68EA2493BD7074E982B94D80D6F5F
		/// Type: TArray<>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// FST_SubstateRuleMaster:
	/// Size: 0x48
	/// Properties: 2
	/// </summary>
	public class FST_SubstateRuleMaster:MemoryObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: State_9_85F22FCC4BE81087FD6C1F8B0F129DCF
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte State_9_85F22FCC4BE81087FD6C1F8B0F129DCF
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
		/// Name: Rules_8_CE1C15A54400143BC37979A4FB59D9EE
		/// Type: StructProperty
		/// Offset: 0x08
		/// Size: 0x40
		/// </summary>
		public FST_SubstateRule Rules_8_CE1C15A54400143BC37979A4FB59D9EE => ReadStruct<FST_SubstateRule>(0x08);
		
	}


	/// <summary>
	/// AFunCombat_PlayerController_C:AConanPlayerController
	/// Size: 0xACC
	/// Properties: 71
	/// </summary>
	public class AFunCombat_PlayerController_C:AConanPlayerController
	{
		public override int ObjectSize => 2764;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x870
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x870);
		
		/// <summary>
		/// Name: CurrentPawn
		/// Type: ObjectProperty
		/// Offset: 0x878
		/// Size: 0x08
		/// </summary>
		public ABasePlayerChar_C CurrentPawn => ReadUObject<ABasePlayerChar_C>(0x878);
		
		/// <summary>
		/// Name: PlayerStart
		/// Type: StructProperty
		/// Offset: 0x880
		/// Size: 0x30
		/// </summary>
		public FTransform PlayerStart => ReadStruct<FTransform>(0x880);
		
		/// <summary>
		/// Name: Building_BasePlayerChar
		/// Type: ObjectProperty
		/// Offset: 0x8B0
		/// Size: 0x08
		/// </summary>
		public ABasePlayerChar_C Building_BasePlayerChar => ReadUObject<ABasePlayerChar_C>(0x8B0);
		
		/// <summary>
		/// Name: TimeSinceLastHighlightUpdate
		/// Type: FloatProperty
		/// Offset: 0x8B8
		/// Size: 0x04
		/// </summary>
		public float TimeSinceLastHighlightUpdate
		{
			get
			{
				return ReadSingle(0x8B8);
			}
			set
			{
				WriteSingle(0x8B8,value);
			}
		}
		
		/// <summary>
		/// Name: ResourceTemplateIDs
		/// Type: TArray<>
		/// Offset: 0x8C0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: isInventoryFillerOnCooldown
		/// Type: BoolProperty
		/// Offset: 0x8D0
		/// Size: 0x01
		/// </summary>
		public bool isInventoryFillerOnCooldown
		{
			get
			{
				return ReadBool(0x8D0);
			}
			set
			{
				WriteBool(0x8D0,value);
			}
		}
		
		/// <summary>
		/// Name: ShowNPCSpawnerUI
		/// Type: BoolProperty
		/// Offset: 0x8D1
		/// Size: 0x01
		/// </summary>
		public bool ShowNPCSpawnerUI
		{
			get
			{
				return ReadBool(0x8D1);
			}
			set
			{
				WriteBool(0x8D1,value);
			}
		}
		
		/// <summary>
		/// Name: AdjustableCamera
		/// Type: ObjectProperty
		/// Offset: 0x8D8
		/// Size: 0x08
		/// </summary>
		public UAdjustableCameraComponent AdjustableCamera => ReadUObject<UAdjustableCameraComponent>(0x8D8);
		
		/// <summary>
		/// Name: NPCTesterSelectedActor
		/// Type: ObjectProperty
		/// Offset: 0x8E0
		/// Size: 0x08
		/// </summary>
		public AActor NPCTesterSelectedActor => ReadUObject<AActor>(0x8E0);
		
		/// <summary>
		/// Name: ToggleSpawnedNPC
		/// Type: BoolProperty
		/// Offset: 0x8E8
		/// Size: 0x01
		/// </summary>
		public bool ToggleSpawnedNPC
		{
			get
			{
				return ReadBool(0x8E8);
			}
			set
			{
				WriteBool(0x8E8,value);
			}
		}
		
		/// <summary>
		/// Name: NPCTesterSkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x8F0
		/// Size: 0x08
		/// </summary>
		public USkeletalMesh NPCTesterSkeletalMesh => ReadUObject<USkeletalMesh>(0x8F0);
		
		/// <summary>
		/// Name: NPCTesterAnimInstanceClass
		/// Type: ClassProperty
		/// Offset: 0x8F8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0x900
		/// Size: 0x08
		/// </summary>
		public UEquipmentInventory EquipmentInventory => ReadUObject<UEquipmentInventory>(0x900);
		
		/// <summary>
		/// Name: NPCTesterAggression
		/// Type: ByteProperty
		/// Offset: 0x908
		/// Size: 0x01
		/// </summary>
		public byte NPCTesterAggression
		{
			get
			{
				return ReadByte(0x908);
			}
			set
			{
				WriteByte(0x908,value);
			}
		}
		
		/// <summary>
		/// Name: HomeLocation4
		/// Type: NameProperty
		/// Offset: 0x910
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: TerritoryRoamRadius
		/// Type: NameProperty
		/// Offset: 0x918
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ToggleNPCTesterHome
		/// Type: BoolProperty
		/// Offset: 0x920
		/// Size: 0x01
		/// </summary>
		public bool ToggleNPCTesterHome
		{
			get
			{
				return ReadBool(0x920);
			}
			set
			{
				WriteBool(0x920,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleSelfTarget
		/// Type: BoolProperty
		/// Offset: 0x921
		/// Size: 0x01
		/// </summary>
		public bool ToggleSelfTarget
		{
			get
			{
				return ReadBool(0x921);
			}
			set
			{
				WriteBool(0x921,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentTarget
		/// Type: NameProperty
		/// Offset: 0x928
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ToggleExternalTarget
		/// Type: BoolProperty
		/// Offset: 0x930
		/// Size: 0x01
		/// </summary>
		public bool ToggleExternalTarget
		{
			get
			{
				return ReadBool(0x930);
			}
			set
			{
				WriteBool(0x930,value);
			}
		}
		
		/// <summary>
		/// Name: SenseDetection_DEP
		/// Type: BoolProperty
		/// Offset: 0x931
		/// Size: 0x01
		/// </summary>
		public bool SenseDetection_DEP
		{
			get
			{
				return ReadBool(0x931);
			}
			set
			{
				WriteBool(0x931,value);
			}
		}
		
		/// <summary>
		/// Name: NPCSpawnedList
		/// Type: TArray<APawn>
		/// Offset: 0x938
		/// Size: 0x10
		/// SubElement Size: 0x430
		/// </summary>
		public TArray<APawn> NPCSpawnedList => new TArray<APawn>(BaseAddress+0x938);
		
		/// <summary>
		/// Name: HomeLocation
		/// Type: NameProperty
		/// Offset: 0x948
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: TerritorySpawnVolumeRadius
		/// Type: NameProperty
		/// Offset: 0x950
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Helmet
		/// Type: IntProperty
		/// Offset: 0x958
		/// Size: 0x04
		/// </summary>
		public int Helmet
		{
			get
			{
				return ReadInt32(0x958);
			}
			set
			{
				WriteInt32(0x958,value);
			}
		}
		
		/// <summary>
		/// Name: Head
		/// Type: IntProperty
		/// Offset: 0x95C
		/// Size: 0x04
		/// </summary>
		public int Head
		{
			get
			{
				return ReadInt32(0x95C);
			}
			set
			{
				WriteInt32(0x95C,value);
			}
		}
		
		/// <summary>
		/// Name: Hair
		/// Type: IntProperty
		/// Offset: 0x960
		/// Size: 0x04
		/// </summary>
		public int Hair
		{
			get
			{
				return ReadInt32(0x960);
			}
			set
			{
				WriteInt32(0x960,value);
			}
		}
		
		/// <summary>
		/// Name: Forearm
		/// Type: IntProperty
		/// Offset: 0x964
		/// Size: 0x04
		/// </summary>
		public int Forearm
		{
			get
			{
				return ReadInt32(0x964);
			}
			set
			{
				WriteInt32(0x964,value);
			}
		}
		
		/// <summary>
		/// Name: Hand
		/// Type: IntProperty
		/// Offset: 0x968
		/// Size: 0x04
		/// </summary>
		public int Hand
		{
			get
			{
				return ReadInt32(0x968);
			}
			set
			{
				WriteInt32(0x968,value);
			}
		}
		
		/// <summary>
		/// Name: UpperBody
		/// Type: IntProperty
		/// Offset: 0x96C
		/// Size: 0x04
		/// </summary>
		public int UpperBody
		{
			get
			{
				return ReadInt32(0x96C);
			}
			set
			{
				WriteInt32(0x96C,value);
			}
		}
		
		/// <summary>
		/// Name: lowerBody
		/// Type: IntProperty
		/// Offset: 0x970
		/// Size: 0x04
		/// </summary>
		public int lowerBody
		{
			get
			{
				return ReadInt32(0x970);
			}
			set
			{
				WriteInt32(0x970,value);
			}
		}
		
		/// <summary>
		/// Name: Legs
		/// Type: IntProperty
		/// Offset: 0x974
		/// Size: 0x04
		/// </summary>
		public int Legs
		{
			get
			{
				return ReadInt32(0x974);
			}
			set
			{
				WriteInt32(0x974,value);
			}
		}
		
		/// <summary>
		/// Name: Feet
		/// Type: IntProperty
		/// Offset: 0x978
		/// Size: 0x04
		/// </summary>
		public int Feet
		{
			get
			{
				return ReadInt32(0x978);
			}
			set
			{
				WriteInt32(0x978,value);
			}
		}
		
		/// <summary>
		/// Name: SkinColor
		/// Type: StructProperty
		/// Offset: 0x97C
		/// Size: 0x10
		/// </summary>
		public FLinearColor SkinColor => ReadStruct<FLinearColor>(0x97C);
		
		/// <summary>
		/// Name: MainHand
		/// Type: IntProperty
		/// Offset: 0x98C
		/// Size: 0x04
		/// </summary>
		public int MainHand
		{
			get
			{
				return ReadInt32(0x98C);
			}
			set
			{
				WriteInt32(0x98C,value);
			}
		}
		
		/// <summary>
		/// Name: OffHand
		/// Type: IntProperty
		/// Offset: 0x990
		/// Size: 0x04
		/// </summary>
		public int OffHand
		{
			get
			{
				return ReadInt32(0x990);
			}
			set
			{
				WriteInt32(0x990,value);
			}
		}
		
		/// <summary>
		/// Name: LoadingUUID
		/// Type: ObjectProperty
		/// Offset: 0x998
		/// Size: 0x08
		/// </summary>
		public UUniqueID LoadingUUID => ReadUObject<UUniqueID>(0x998);
		
		/// <summary>
		/// Name: InitialCharacterData
		/// Type: TArray<FDBResult>
		/// Offset: 0x9A0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FDBResult> InitialCharacterData => new TArray<FDBResult>(BaseAddress+0x9A0);
		
		/// <summary>
		/// Name: NPCCounter
		/// Type: TArray<FNPC_Counter_Structure>
		/// Offset: 0x9B0
		/// Size: 0x10
		/// SubElement Size: 0x14
		/// </summary>
		public TArray<FNPC_Counter_Structure> NPCCounter => new TArray<FNPC_Counter_Structure>(BaseAddress+0x9B0);
		
		/// <summary>
		/// Name: TotalNPCCount
		/// Type: IntProperty
		/// Offset: 0x9C0
		/// Size: 0x04
		/// </summary>
		public int TotalNPCCount
		{
			get
			{
				return ReadInt32(0x9C0);
			}
			set
			{
				WriteInt32(0x9C0,value);
			}
		}
		
		/// <summary>
		/// Name: HasCrossedDesert
		/// Type: BoolProperty
		/// Offset: 0x9C4
		/// Size: 0x01
		/// </summary>
		public bool HasCrossedDesert
		{
			get
			{
				return ReadBool(0x9C4);
			}
			set
			{
				WriteBool(0x9C4,value);
			}
		}
		
		/// <summary>
		/// Name: GameMode
		/// Type: ObjectProperty
		/// Offset: 0x9C8
		/// Size: 0x08
		/// </summary>
		public ABaseGameMode_C GameMode => ReadUObject<ABaseGameMode_C>(0x9C8);
		
		/// <summary>
		/// Name: ActiveNameplate
		/// Type: ObjectProperty
		/// Offset: 0x9D0
		/// Size: 0x08
		/// </summary>
		public UWidgetComponent ActiveNameplate => ReadUObject<UWidgetComponent>(0x9D0);
		
		/// <summary>
		/// Name: bInteractionCooldown
		/// Type: BoolProperty
		/// Offset: 0x9D8
		/// Size: 0x01
		/// </summary>
		public bool bInteractionCooldown
		{
			get
			{
				return ReadBool(0x9D8);
			}
			set
			{
				WriteBool(0x9D8,value);
			}
		}
		
		/// <summary>
		/// Name: FailsafePlayerStart
		/// Type: StructProperty
		/// Offset: 0x9E0
		/// Size: 0x30
		/// </summary>
		public FTransform FailsafePlayerStart => ReadStruct<FTransform>(0x9E0);
		
		/// <summary>
		/// Name: bHasProcessedInteraction
		/// Type: BoolProperty
		/// Offset: 0xA10
		/// Size: 0x01
		/// </summary>
		public bool bHasProcessedInteraction
		{
			get
			{
				return ReadBool(0xA10);
			}
			set
			{
				WriteBool(0xA10,value);
			}
		}
		
		/// <summary>
		/// Name: PickupAnimMontage
		/// Type: ObjectProperty
		/// Offset: 0xA18
		/// Size: 0x08
		/// </summary>
		public UAnimMontage PickupAnimMontage => ReadUObject<UAnimMontage>(0xA18);
		
		/// <summary>
		/// Name: RespawnTime
		/// Type: FloatProperty
		/// Offset: 0xA20
		/// Size: 0x04
		/// </summary>
		public float RespawnTime
		{
			get
			{
				return ReadSingle(0xA20);
			}
			set
			{
				WriteSingle(0xA20,value);
			}
		}
		
		/// <summary>
		/// Name: InteractionDistance
		/// Type: FloatProperty
		/// Offset: 0xA24
		/// Size: 0x04
		/// </summary>
		public float InteractionDistance
		{
			get
			{
				return ReadSingle(0xA24);
			}
			set
			{
				WriteSingle(0xA24,value);
			}
		}
		
		/// <summary>
		/// Name: HitActor
		/// Type: ObjectProperty
		/// Offset: 0xA28
		/// Size: 0x08
		/// </summary>
		public AActor HitActor => ReadUObject<AActor>(0xA28);
		
		/// <summary>
		/// Name: TraceSphereRadius
		/// Type: FloatProperty
		/// Offset: 0xA30
		/// Size: 0x04
		/// </summary>
		public float TraceSphereRadius
		{
			get
			{
				return ReadSingle(0xA30);
			}
			set
			{
				WriteSingle(0xA30,value);
			}
		}
		
		/// <summary>
		/// Name: InteractTimerHandle
		/// Type: StructProperty
		/// Offset: 0xA38
		/// Size: 0x08
		/// </summary>
		public FTimerHandle InteractTimerHandle => ReadStruct<FTimerHandle>(0xA38);
		
		/// <summary>
		/// Name: NearestActorDist
		/// Type: FloatProperty
		/// Offset: 0xA40
		/// Size: 0x04
		/// </summary>
		public float NearestActorDist
		{
			get
			{
				return ReadSingle(0xA40);
			}
			set
			{
				WriteSingle(0xA40,value);
			}
		}
		
		/// <summary>
		/// Name: NearestActor
		/// Type: ObjectProperty
		/// Offset: 0xA48
		/// Size: 0x08
		/// </summary>
		public AConanCharacter NearestActor => ReadUObject<AConanCharacter>(0xA48);
		
		/// <summary>
		/// Name: InteractRepeatTimerHandle
		/// Type: StructProperty
		/// Offset: 0xA50
		/// Size: 0x08
		/// </summary>
		public FTimerHandle InteractRepeatTimerHandle => ReadStruct<FTimerHandle>(0xA50);
		
		/// <summary>
		/// Name: PhysicsNudgeBlendWeight
		/// Type: FloatProperty
		/// Offset: 0xA58
		/// Size: 0x04
		/// </summary>
		public float PhysicsNudgeBlendWeight
		{
			get
			{
				return ReadSingle(0xA58);
			}
			set
			{
				WriteSingle(0xA58,value);
			}
		}
		
		/// <summary>
		/// Name: RadialMenuTimer
		/// Type: FloatProperty
		/// Offset: 0xA5C
		/// Size: 0x04
		/// </summary>
		public float RadialMenuTimer
		{
			get
			{
				return ReadSingle(0xA5C);
			}
			set
			{
				WriteSingle(0xA5C,value);
			}
		}
		
		/// <summary>
		/// Name: isInteractKeyPressed
		/// Type: BoolProperty
		/// Offset: 0xA60
		/// Size: 0x01
		/// </summary>
		public bool isInteractKeyPressed
		{
			get
			{
				return ReadBool(0xA60);
			}
			set
			{
				WriteBool(0xA60,value);
			}
		}
		
		/// <summary>
		/// Name: MsgConnectionProblem
		/// Type: ObjectProperty
		/// Offset: 0xA68
		/// Size: 0x08
		/// </summary>
		public UMessageBoxWidget MsgConnectionProblem => ReadUObject<UMessageBoxWidget>(0xA68);
		
		/// <summary>
		/// Name: PickupInteractionDistance
		/// Type: FloatProperty
		/// Offset: 0xA70
		/// Size: 0x04
		/// </summary>
		public float PickupInteractionDistance
		{
			get
			{
				return ReadSingle(0xA70);
			}
			set
			{
				WriteSingle(0xA70,value);
			}
		}
		
		/// <summary>
		/// Name: PickupTraceSphereRadius
		/// Type: FloatProperty
		/// Offset: 0xA74
		/// Size: 0x04
		/// </summary>
		public float PickupTraceSphereRadius
		{
			get
			{
				return ReadSingle(0xA74);
			}
			set
			{
				WriteSingle(0xA74,value);
			}
		}
		
		/// <summary>
		/// Name: LastUseHarvestToolMessageTime
		/// Type: FloatProperty
		/// Offset: 0xA78
		/// Size: 0x04
		/// </summary>
		public float LastUseHarvestToolMessageTime
		{
			get
			{
				return ReadSingle(0xA78);
			}
			set
			{
				WriteSingle(0xA78,value);
			}
		}
		
		/// <summary>
		/// Name: CanRecreateCharacter
		/// Type: BoolProperty
		/// Offset: 0xA7C
		/// Size: 0x01
		/// </summary>
		public bool CanRecreateCharacter
		{
			get
			{
				return ReadBool(0xA7C);
			}
			set
			{
				WriteBool(0xA7C,value);
			}
		}
		
		/// <summary>
		/// Name: LoadingRetryTimes
		/// Type: IntProperty
		/// Offset: 0xA80
		/// Size: 0x04
		/// </summary>
		public int LoadingRetryTimes
		{
			get
			{
				return ReadInt32(0xA80);
			}
			set
			{
				WriteInt32(0xA80,value);
			}
		}
		
		/// <summary>
		/// Name: RespawnCharacterData
		/// Type: TArray<FDBResult>
		/// Offset: 0xA88
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FDBResult> RespawnCharacterData => new TArray<FDBResult>(BaseAddress+0xA88);
		
		/// <summary>
		/// Name: RespawnCharInvData
		/// Type: TArray<FDBResult>
		/// Offset: 0xA98
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FDBResult> RespawnCharInvData => new TArray<FDBResult>(BaseAddress+0xA98);
		
		/// <summary>
		/// Name: RotateClockwise
		/// Type: BoolProperty
		/// Offset: 0xAC8
		/// Size: 0x01
		/// </summary>
		public bool RotateClockwise
		{
			get
			{
				return ReadBool(0xAC8);
			}
			set
			{
				WriteBool(0xAC8,value);
			}
		}
		
		/// <summary>
		/// Name: HeightModPressed
		/// Type: BoolProperty
		/// Offset: 0xAC9
		/// Size: 0x01
		/// </summary>
		public bool HeightModPressed
		{
			get
			{
				return ReadBool(0xAC9);
			}
			set
			{
				WriteBool(0xAC9,value);
			}
		}
		
		/// <summary>
		/// Name: TiltModPressed
		/// Type: BoolProperty
		/// Offset: 0xACA
		/// Size: 0x01
		/// </summary>
		public bool TiltModPressed
		{
			get
			{
				return ReadBool(0xACA);
			}
			set
			{
				WriteBool(0xACA,value);
			}
		}
		
		/// <summary>
		/// Name: PitchModPressed
		/// Type: BoolProperty
		/// Offset: 0xACB
		/// Size: 0x01
		/// </summary>
		public bool PitchModPressed
		{
			get
			{
				return ReadBool(0xACB);
			}
			set
			{
				WriteBool(0xACB,value);
			}
		}
		
	}


	/// <summary>
	/// ABP_PlayerCameraManager_C:AConanPlayerCameraManager
	/// Size: 0x1545
	/// Properties: 10
	/// </summary>
	public class ABP_PlayerCameraManager_C:AConanPlayerCameraManager
	{
		public override int ObjectSize => 5445;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1518
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1518);
		
		/// <summary>
		/// Name: CollisionRadius
		/// Type: FloatProperty
		/// Offset: 0x1520
		/// Size: 0x04
		/// </summary>
		public float CollisionRadius
		{
			get
			{
				return ReadSingle(0x1520);
			}
			set
			{
				WriteSingle(0x1520,value);
			}
		}
		
		/// <summary>
		/// Name: MaxCameraHeight
		/// Type: FloatProperty
		/// Offset: 0x1524
		/// Size: 0x04
		/// </summary>
		public float MaxCameraHeight
		{
			get
			{
				return ReadSingle(0x1524);
			}
			set
			{
				WriteSingle(0x1524,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDistanceFromOriginAdmin
		/// Type: FloatProperty
		/// Offset: 0x1528
		/// Size: 0x04
		/// </summary>
		public float MaxDistanceFromOriginAdmin
		{
			get
			{
				return ReadSingle(0x1528);
			}
			set
			{
				WriteSingle(0x1528,value);
			}
		}
		
		/// <summary>
		/// Name: HeadVisibleBeforeAnselSession
		/// Type: BoolProperty
		/// Offset: 0x152C
		/// Size: 0x01
		/// </summary>
		public bool HeadVisibleBeforeAnselSession
		{
			get
			{
				return ReadBool(0x152C);
			}
			set
			{
				WriteBool(0x152C,value);
			}
		}
		
		/// <summary>
		/// Name: BasePlayerChar
		/// Type: ObjectProperty
		/// Offset: 0x1530
		/// Size: 0x08
		/// </summary>
		public ABasePlayerChar_C BasePlayerChar => ReadUObject<ABasePlayerChar_C>(0x1530);
		
		/// <summary>
		/// Name: DistanceToShowHead
		/// Type: FloatProperty
		/// Offset: 0x1538
		/// Size: 0x04
		/// </summary>
		public float DistanceToShowHead
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
		/// Name: CurrentMaxDistanceFromOrigin
		/// Type: FloatProperty
		/// Offset: 0x153C
		/// Size: 0x04
		/// </summary>
		public float CurrentMaxDistanceFromOrigin
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
		/// Name: MaxDistanceFromOriginNormal
		/// Type: FloatProperty
		/// Offset: 0x1540
		/// Size: 0x04
		/// </summary>
		public float MaxDistanceFromOriginNormal
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
		/// Name: PreviousHeadVisible
		/// Type: BoolProperty
		/// Offset: 0x1544
		/// Size: 0x01
		/// </summary>
		public bool PreviousHeadVisible
		{
			get
			{
				return ReadBool(0x1544);
			}
			set
			{
				WriteBool(0x1544,value);
			}
		}
		
	}


	/// <summary>
	/// UBPEnergyReceiver_C:UEnergyReceiverComponent
	/// Size: 0x198
	/// Properties: 1
	/// </summary>
	public class UBPEnergyReceiver_C:UEnergyReceiverComponent
	{
		public override int ObjectSize => 408;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x190
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x190);
		
	}


	/// <summary>
	/// UInteractionManager_C:UActorComponent
	/// Size: 0x100
	/// Properties: 4
	/// </summary>
	public class UInteractionManager_C:UActorComponent
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: SelectedObject
		/// Type: InterfaceProperty
		/// Offset: 0xE0
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: SelectedObjectIndex
		/// Type: IntProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public int SelectedObjectIndex
		{
			get
			{
				return ReadInt32(0xF0);
			}
			set
			{
				WriteInt32(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: SelectedComponent
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent SelectedComponent => ReadUObject<UPrimitiveComponent>(0xF8);
		
	}


	/// <summary>
	/// ABaseGameMode_C:AConanGameMode
	/// Size: 0x744
	/// Properties: 18
	/// </summary>
	public class ABaseGameMode_C:AConanGameMode
	{
		public override int ObjectSize => 1860;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x6A8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x6A8);
		
		/// <summary>
		/// Name: DestructibleCache
		/// Type: ObjectProperty
		/// Offset: 0x6B0
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent DestructibleCache => ReadUObject<UDestructibleComponent>(0x6B0);
		
		/// <summary>
		/// Name: BP_StaticNavigationVisualizerComponent
		/// Type: ObjectProperty
		/// Offset: 0x6B8
		/// Size: 0x08
		/// </summary>
		public UBP_StaticNavigationVisualizerComponent_C BP_StaticNavigationVisualizerComponent => ReadUObject<UBP_StaticNavigationVisualizerComponent_C>(0x6B8);
		
		/// <summary>
		/// Name: BP_CampSystemComponent
		/// Type: ObjectProperty
		/// Offset: 0x6C0
		/// Size: 0x08
		/// </summary>
		public UBP_CampSystemComponent_C BP_CampSystemComponent => ReadUObject<UBP_CampSystemComponent_C>(0x6C0);
		
		/// <summary>
		/// Name: BP_AC_SandstormController
		/// Type: ObjectProperty
		/// Offset: 0x6C8
		/// Size: 0x08
		/// </summary>
		public UBP_AC_SandstormController_C BP_AC_SandstormController => ReadUObject<UBP_AC_SandstormController_C>(0x6C8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x6D0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x6D0);
		
		/// <summary>
		/// Name: SpawnVolume
		/// Type: ObjectProperty
		/// Offset: 0x6D8
		/// Size: 0x08
		/// </summary>
		public ANPCTerritorySpawner_C SpawnVolume => ReadUObject<ANPCTerritorySpawner_C>(0x6D8);
		
		/// <summary>
		/// Name: CurrentPlayerStartIndex
		/// Type: IntProperty
		/// Offset: 0x6E0
		/// Size: 0x04
		/// </summary>
		public int CurrentPlayerStartIndex
		{
			get
			{
				return ReadInt32(0x6E0);
			}
			set
			{
				WriteInt32(0x6E0,value);
			}
		}
		
		/// <summary>
		/// Name: ListOfPlayerStarts
		/// Type: TArray<APlayerStart>
		/// Offset: 0x6E8
		/// Size: 0x10
		/// SubElement Size: 0x400
		/// </summary>
		public TArray<APlayerStart> ListOfPlayerStarts => new TArray<APlayerStart>(BaseAddress+0x6E8);
		
		/// <summary>
		/// Name: ActiveNPCTerritorySpawners
		/// Type: TArray<>
		/// Offset: 0x6F8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: NPCHumanInitialSpawn
		/// Type: BoolProperty
		/// Offset: 0x708
		/// Size: 0x01
		/// </summary>
		public bool NPCHumanInitialSpawn
		{
			get
			{
				return ReadBool(0x708);
			}
			set
			{
				WriteBool(0x708,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnedNPCs
		/// Type: IntProperty
		/// Offset: 0x70C
		/// Size: 0x04
		/// </summary>
		public int SpawnedNPCs
		{
			get
			{
				return ReadInt32(0x70C);
			}
			set
			{
				WriteInt32(0x70C,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentTerritoryListIndex
		/// Type: IntProperty
		/// Offset: 0x710
		/// Size: 0x04
		/// </summary>
		public int CurrentTerritoryListIndex
		{
			get
			{
				return ReadInt32(0x710);
			}
			set
			{
				WriteInt32(0x710,value);
			}
		}
		
		/// <summary>
		/// Name: NPCCounter
		/// Type: TArray<FNPC_Counter_Structure>
		/// Offset: 0x718
		/// Size: 0x10
		/// SubElement Size: 0x14
		/// </summary>
		public TArray<FNPC_Counter_Structure> NPCCounter => new TArray<FNPC_Counter_Structure>(BaseAddress+0x718);
		
		/// <summary>
		/// Name: NPCCountTempIndex
		/// Type: IntProperty
		/// Offset: 0x728
		/// Size: 0x04
		/// </summary>
		public int NPCCountTempIndex
		{
			get
			{
				return ReadInt32(0x728);
			}
			set
			{
				WriteInt32(0x728,value);
			}
		}
		
		/// <summary>
		/// Name: NPCEntry
		/// Type: ByteProperty
		/// Offset: 0x72C
		/// Size: 0x01
		/// </summary>
		public byte NPCEntry
		{
			get
			{
				return ReadByte(0x72C);
			}
			set
			{
				WriteByte(0x72C,value);
			}
		}
		
		/// <summary>
		/// Name: SandstormAffectedCharacters
		/// Type: TArray<UBP_AC_AffectedBySandstorm_C>
		/// Offset: 0x730
		/// Size: 0x10
		/// SubElement Size: 0x100
		/// </summary>
		public TArray<UBP_AC_AffectedBySandstorm_C> SandstormAffectedCharacters => new TArray<UBP_AC_AffectedBySandstorm_C>(BaseAddress+0x730);
		
		/// <summary>
		/// Name: ServerSettingDurabilityModifier
		/// Type: FloatProperty
		/// Offset: 0x740
		/// Size: 0x04
		/// </summary>
		public float ServerSettingDurabilityModifier
		{
			get
			{
				return ReadSingle(0x740);
			}
			set
			{
				WriteSingle(0x740,value);
			}
		}
		
	}


	/// <summary>
	/// ABasePlayerState_C:AConanPlayerState
	/// Size: 0x4E0
	/// Properties: 15
	/// </summary>
	public class ABasePlayerState_C:AConanPlayerState
	{
		public override int ObjectSize => 1248;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x458);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x460);
		
		/// <summary>
		/// Name: MainMenu
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UW_MainMenu_MainMenu_C MainMenu => ReadUObject<UW_MainMenu_MainMenu_C>(0x478);
		
		/// <summary>
		/// Name: ServerList
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UW_ServerList_C ServerList => ReadUObject<UW_ServerList_C>(0x480);
		
		/// <summary>
		/// Name: PlayerIndex
		/// Type: IntProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public int PlayerIndex
		{
			get
			{
				return ReadInt32(0x488);
			}
			set
			{
				WriteInt32(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: ServerSettingDurabilityModifier
		/// Type: FloatProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public float ServerSettingDurabilityModifier
		{
			get
			{
				return ReadSingle(0x48C);
			}
			set
			{
				WriteSingle(0x48C,value);
			}
		}
		
		/// <summary>
		/// Name: SocialID
		/// Type: IntProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public int SocialID
		{
			get
			{
				return ReadInt32(0x490);
			}
			set
			{
				WriteInt32(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: guildId
		/// Type: IntProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public int guildId
		{
			get
			{
				return ReadInt32(0x494);
			}
			set
			{
				WriteInt32(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: SocialName
		/// Type: StrProperty
		/// Offset: 0x498
		/// Size: 0x10
		/// </summary>
		public FString SocialName => new FString(BaseAddress+0x498);
		
		/// <summary>
		/// Name: guildName
		/// Type: NameProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PartyID
		/// Type: IntProperty
		/// Offset: 0x4B0
		/// Size: 0x04
		/// </summary>
		public int PartyID
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
		/// Name: CurrentGeneralID
		/// Type: IntProperty
		/// Offset: 0x4B4
		/// Size: 0x04
		/// </summary>
		public int CurrentGeneralID
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
		
		/// <summary>
		/// Name: CurrentTradeID
		/// Type: IntProperty
		/// Offset: 0x4B8
		/// Size: 0x04
		/// </summary>
		public int CurrentTradeID
		{
			get
			{
				return ReadInt32(0x4B8);
			}
			set
			{
				WriteInt32(0x4B8,value);
			}
		}
		
		/// <summary>
		/// Name: PreparingWorld
		/// Type: TextProperty
		/// Offset: 0x4C0
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: CharacterCreationActor
		/// Type: ObjectProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public AActor CharacterCreationActor => ReadUObject<AActor>(0x4D8);
		
	}


	/// <summary>
	/// ABP_SafetyNetVolume_C:AActor
	/// Size: 0x400
	/// Properties: 5
	/// </summary>
	public class ABP_SafetyNetVolume_C:AActor
	{
		public override int ObjectSize => 1024;
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
		/// Name: AffectedActor
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public AActor AffectedActor => ReadUObject<AActor>(0x3F8);
		
	}


}

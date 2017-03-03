using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Systems.AI.AI_Controllers;
using ConanExilesGame.Game.Characters;


namespace ConanExilesGame.Game.Systems.AI
{
	/// <summary>
	/// UBP_CharacterAttackPointAllocatorComponent_C:UTargetAreaAllocatorComponent
	/// Size: 0xF0
	/// Properties: 0
	/// </summary>
	public class UBP_CharacterAttackPointAllocatorComponent_C:UTargetAreaAllocatorComponent
	{
		public override int ObjectSize => 240;
	}


	/// <summary>
	/// UBP_CharacterAttackPoint_C:UTargetAreaComponent
	/// Size: 0x5D1
	/// Properties: 1
	/// </summary>
	public class UBP_CharacterAttackPoint_C:UTargetAreaComponent
	{
		public override int ObjectSize => 1489;
		/// <summary>
		/// Name: TacticalGroup
		/// Type: ByteProperty
		/// Offset: 0x5D0
		/// Size: 0x01
		/// </summary>
		public byte TacticalGroup
		{
			get
			{
				return ReadByte(0x5D0);
			}
			set
			{
				WriteByte(0x5D0,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_AITargetingLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AITargetingLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AttackPointContestInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AttackPointContestInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_TargetAreaWithSourceAsObject_C:UObject
	/// Size: 0x50
	/// Properties: 1
	/// </summary>
	public class UBP_TargetAreaWithSourceAsObject_C:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: TargetAreaAndSource
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x28
		/// </summary>
		public FTargetAreaWithSource TargetAreaAndSource => ReadStruct<FTargetAreaWithSource>(0x28);
		
	}


	/// <summary>
	/// UBP_CryForHelpMessage_C:UObject
	/// Size: 0x31
	/// Properties: 2
	/// </summary>
	public class UBP_CryForHelpMessage_C:UObject
	{
		public override int ObjectSize => 49;
		/// <summary>
		/// Name: AttackTarget
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public AActor AttackTarget => ReadUObject<AActor>(0x28);
		
		/// <summary>
		/// Name: Context
		/// Type: ByteProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public byte Context
		{
			get
			{
				return ReadByte(0x30);
			}
			set
			{
				WriteByte(0x30,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_NPCTerritorySpawnerInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_NPCTerritorySpawnerInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_NPCBehaviorParameters_C:UObject
	/// Size: 0x34
	/// Properties: 3
	/// </summary>
	public class UBP_NPCBehaviorParameters_C:UObject
	{
		public override int ObjectSize => 52;
		/// <summary>
		/// Name: IsKitingAllowed
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool IsKitingAllowed
		{
			get
			{
				return ReadBool(0x28);
			}
			set
			{
				WriteBool(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: LeashRange
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float LeashRange
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: RoamRadius
		/// Type: FloatProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public float RoamRadius
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
		
	}


	/// <summary>
	/// UBP_DefaultNPCBehaviorParameters_C:UBP_NPCBehaviorParameters_C
	/// Size: 0x34
	/// Properties: 0
	/// </summary>
	public class UBP_DefaultNPCBehaviorParameters_C:UBP_NPCBehaviorParameters_C
	{
		public override int ObjectSize => 52;
	}


	/// <summary>
	/// UBP_TargetAttackStats_C:UObject
	/// Size: 0x59
	/// Properties: 8
	/// </summary>
	public class UBP_TargetAttackStats_C:UObject
	{
		public override int ObjectSize => 89;
		/// <summary>
		/// Name: Target
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public AActor Target => ReadUObject<AActor>(0x28);
		
		/// <summary>
		/// Name: LastSuccessfulAttackTime
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public FDateTime LastSuccessfulAttackTime => ReadStruct<FDateTime>(0x30);
		
		/// <summary>
		/// Name: LastSuccessfulDamageTime
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public FDateTime LastSuccessfulDamageTime => ReadStruct<FDateTime>(0x38);
		
		/// <summary>
		/// Name: PathingFailureStartTime
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public FDateTime PathingFailureStartTime => ReadStruct<FDateTime>(0x40);
		
		/// <summary>
		/// Name: RoundStartTime
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public FDateTime RoundStartTime => ReadStruct<FDateTime>(0x48);
		
		/// <summary>
		/// Name: active
		/// Type: BoolProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public bool active
		{
			get
			{
				return ReadBool(0x50);
			}
			set
			{
				WriteBool(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: TotalDamageDealt
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float TotalDamageDealt
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: IsFailingToPath
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool IsFailingToPath
		{
			get
			{
				return ReadBool(0x58);
			}
			set
			{
				WriteBool(0x58,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_AIDebugLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIDebugLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AIWeaponLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIWeaponLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AIMovementLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIMovementLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AISpawningLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AISpawningLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AIFloatingNames_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIFloatingNames_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_HasSpawnEntriesInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_HasSpawnEntriesInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_ControlPanelSpawnHelper_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_ControlPanelSpawnHelper_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBTTask_Roaming_C:UBTTask_BlueprintBase
	/// Size: 0x1A0
	/// Properties: 15
	/// </summary>
	public class UBTTask_Roaming_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 416;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: HomeLocation
		/// Type: StructProperty
		/// Offset: 0xA8
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector HomeLocation => ReadStruct<FBlackboardKeySelector>(0xA8);
		
		/// <summary>
		/// Name: TerritorySpawnVolumeRadius
		/// Type: StructProperty
		/// Offset: 0xD0
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector TerritorySpawnVolumeRadius => ReadStruct<FBlackboardKeySelector>(0xD0);
		
		/// <summary>
		/// Name: RoamingPathBBKey
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector RoamingPathBBKey => ReadStruct<FBlackboardKeySelector>(0xF8);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0x120);
		
		/// <summary>
		/// Name: CurrentPathPointIndex
		/// Type: IntProperty
		/// Offset: 0x128
		/// Size: 0x04
		/// </summary>
		public int CurrentPathPointIndex
		{
			get
			{
				return ReadInt32(0x128);
			}
			set
			{
				WriteInt32(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentPathPoints
		/// Type: TArray<FVector>
		/// Offset: 0x130
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> CurrentPathPoints => new TArray<FVector>(BaseAddress+0x130);
		
		/// <summary>
		/// Name: Path
		/// Type: ObjectProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public UPathPoints Path => ReadUObject<UPathPoints>(0x140);
		
		/// <summary>
		/// Name: StaticNavStatus
		/// Type: ByteProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public byte StaticNavStatus
		{
			get
			{
				return ReadByte(0x148);
			}
			set
			{
				WriteByte(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentRoamPoint
		/// Type: StructProperty
		/// Offset: 0x14C
		/// Size: 0x0C
		/// </summary>
		public FVector CurrentRoamPoint => ReadStruct<FVector>(0x14C);
		
		/// <summary>
		/// Name: FinalRoamPoint
		/// Type: StructProperty
		/// Offset: 0x158
		/// Size: 0x0C
		/// </summary>
		public FVector FinalRoamPoint => ReadStruct<FVector>(0x158);
		
		/// <summary>
		/// Name: Leashing
		/// Type: BoolProperty
		/// Offset: 0x164
		/// Size: 0x01
		/// </summary>
		public bool Leashing
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
		/// Name: LocationAggroPoint
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector LocationAggroPoint => ReadStruct<FBlackboardKeySelector>(0x168);
		
		/// <summary>
		/// Name: CurrentRoamPointIsFinalRoamPoint
		/// Type: BoolProperty
		/// Offset: 0x190
		/// Size: 0x01
		/// </summary>
		public bool CurrentRoamPointIsFinalRoamPoint
		{
			get
			{
				return ReadBool(0x190);
			}
			set
			{
				WriteBool(0x190,value);
			}
		}
		
		/// <summary>
		/// Name: BaseNPC
		/// Type: ObjectProperty
		/// Offset: 0x198
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C BaseNPC => ReadUObject<ABaseNPC_C>(0x198);
		
	}


	/// <summary>
	/// UBTDecorator_CanRotateDuringAttack_C:UBTDecorator_BlueprintBase
	/// Size: 0xA0
	/// Properties: 0
	/// </summary>
	public class UBTDecorator_CanRotateDuringAttack_C:UBTDecorator_BlueprintBase
	{
		public override int ObjectSize => 160;
	}


	/// <summary>
	/// UBTDecorator_ClassCheck_C:UBTDecorator_BlueprintBase
	/// Size: 0xA1
	/// Properties: 1
	/// </summary>
	public class UBTDecorator_ClassCheck_C:UBTDecorator_BlueprintBase
	{
		public override int ObjectSize => 161;
		/// <summary>
		/// Name: Filter
		/// Type: ByteProperty
		/// Offset: 0xA0
		/// Size: 0x01
		/// </summary>
		public byte Filter
		{
			get
			{
				return ReadByte(0xA0);
			}
			set
			{
				WriteByte(0xA0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_DistanceCheck_C:UBTDecorator_BlueprintBase
	/// Size: 0xA5
	/// Properties: 2
	/// </summary>
	public class UBTDecorator_DistanceCheck_C:UBTDecorator_BlueprintBase
	{
		public override int ObjectSize => 165;
		/// <summary>
		/// Name: Multiplier
		/// Type: FloatProperty
		/// Offset: 0xA0
		/// Size: 0x04
		/// </summary>
		public float Multiplier
		{
			get
			{
				return ReadSingle(0xA0);
			}
			set
			{
				WriteSingle(0xA0,value);
			}
		}
		
		/// <summary>
		/// Name: Base
		/// Type: ByteProperty
		/// Offset: 0xA4
		/// Size: 0x01
		/// </summary>
		public byte Base
		{
			get
			{
				return ReadByte(0xA4);
			}
			set
			{
				WriteByte(0xA4,value);
			}
		}
		
	}


	/// <summary>
	/// UBTService_DestroyStuckNPC_C:UBTService_BlueprintBase
	/// Size: 0xD8
	/// Properties: 3
	/// </summary>
	public class UBTService_DestroyStuckNPC_C:UBTService_BlueprintBase
	{
		public override int ObjectSize => 216;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x98);
		
		/// <summary>
		/// Name: LastLocation
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x0C
		/// </summary>
		public FVector LastLocation => ReadStruct<FVector>(0xA0);
		
		/// <summary>
		/// Name: CurrentTarget
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector CurrentTarget => ReadStruct<FBlackboardKeySelector>(0xB0);
		
	}


	/// <summary>
	/// UBTService_LeashRangeCheck_C:UBTService_BlueprintBase
	/// Size: 0xA0
	/// Properties: 1
	/// </summary>
	public class UBTService_LeashRangeCheck_C:UBTService_BlueprintBase
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x98);
		
	}


	/// <summary>
	/// UBTTask_AcquireAttackPoint_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_AcquireAttackPoint_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_Attack_C:UBTTask_BlueprintBase
	/// Size: 0xC4
	/// Properties: 5
	/// </summary>
	public class UBTTask_Attack_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 196;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: TauntReady
		/// Type: IntProperty
		/// Offset: 0xA8
		/// Size: 0x04
		/// </summary>
		public int TauntReady
		{
			get
			{
				return ReadInt32(0xA8);
			}
			set
			{
				WriteInt32(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: Attacker
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C Attacker => ReadUObject<ABaseNPC_C>(0xB0);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xB8);
		
		/// <summary>
		/// Name: AttackTimeoutTimeStamp
		/// Type: FloatProperty
		/// Offset: 0xC0
		/// Size: 0x04
		/// </summary>
		public float AttackTimeoutTimeStamp
		{
			get
			{
				return ReadSingle(0xC0);
			}
			set
			{
				WriteSingle(0xC0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_CheckGiveUpAttackTarget_C:UBTTask_BlueprintBase
	/// Size: 0xC0
	/// Properties: 4
	/// </summary>
	public class UBTTask_CheckGiveUpAttackTarget_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: UpdateCommand
		/// Type: ByteProperty
		/// Offset: 0xA8
		/// Size: 0x01
		/// </summary>
		public byte UpdateCommand
		{
			get
			{
				return ReadByte(0xA8);
			}
			set
			{
				WriteByte(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetAttackStats
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public UBP_TargetAttackStats_C TargetAttackStats => ReadUObject<UBP_TargetAttackStats_C>(0xB0);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xB8);
		
	}


	/// <summary>
	/// UBTTask_EmoteState_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_EmoteState_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_GiveUpCurrentTarget_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_GiveUpCurrentTarget_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_HumanCombatAction_C:UBTTask_BlueprintBase
	/// Size: 0xC6
	/// Properties: 7
	/// </summary>
	public class UBTTask_HumanCombatAction_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 198;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: TauntReady
		/// Type: IntProperty
		/// Offset: 0xA8
		/// Size: 0x04
		/// </summary>
		public int TauntReady
		{
			get
			{
				return ReadInt32(0xA8);
			}
			set
			{
				WriteInt32(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: BaseNPCRef
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C BaseNPCRef => ReadUObject<ABaseNPC_C>(0xB0);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xB8);
		
		/// <summary>
		/// Name: PowerAttackTimeout
		/// Type: FloatProperty
		/// Offset: 0xC0
		/// Size: 0x04
		/// </summary>
		public float PowerAttackTimeout
		{
			get
			{
				return ReadSingle(0xC0);
			}
			set
			{
				WriteSingle(0xC0,value);
			}
		}
		
		/// <summary>
		/// Name: CombatAction
		/// Type: ByteProperty
		/// Offset: 0xC4
		/// Size: 0x01
		/// </summary>
		public byte CombatAction
		{
			get
			{
				return ReadByte(0xC4);
			}
			set
			{
				WriteByte(0xC4,value);
			}
		}
		
		/// <summary>
		/// Name: HasReleasedPowerAttack
		/// Type: BoolProperty
		/// Offset: 0xC5
		/// Size: 0x01
		/// </summary>
		public bool HasReleasedPowerAttack
		{
			get
			{
				return ReadBool(0xC5);
			}
			set
			{
				WriteBool(0xC5,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_MeleeRangeMovement_C:UBTTask_BlueprintBase
	/// Size: 0xC0
	/// Properties: 3
	/// </summary>
	public class UBTTask_MeleeRangeMovement_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: SelfNPCActor
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C SelfNPCActor => ReadUObject<ABaseNPC_C>(0xA8);
		
		/// <summary>
		/// Name: Controller
		/// Type: InterfaceProperty
		/// Offset: 0xB0
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UBTTask_MoveDirectlyTowardsCurrentTarget_C:UBTTask_BlueprintBase
	/// Size: 0xE4
	/// Properties: 9
	/// </summary>
	public class UBTTask_MoveDirectlyTowardsCurrentTarget_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 228;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Attacker
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C Attacker => ReadUObject<ABaseNPC_C>(0xA8);
		
		/// <summary>
		/// Name: CurrentTargetReference
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ABaseBPCombat_C CurrentTargetReference => ReadUObject<ABaseBPCombat_C>(0xB0);
		
		/// <summary>
		/// Name: MoveFailReason
		/// Type: ByteProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public byte MoveFailReason
		{
			get
			{
				return ReadByte(0xB8);
			}
			set
			{
				WriteByte(0xB8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetPositionAtMoveStart
		/// Type: StructProperty
		/// Offset: 0xBC
		/// Size: 0x0C
		/// </summary>
		public FVector TargetPositionAtMoveStart => ReadStruct<FVector>(0xBC);
		
		/// <summary>
		/// Name: RepathDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0xC8
		/// Size: 0x04
		/// </summary>
		public float RepathDistanceThreshold
		{
			get
			{
				return ReadSingle(0xC8);
			}
			set
			{
				WriteSingle(0xC8,value);
			}
		}
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xD0
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xD0);
		
		/// <summary>
		/// Name: Path
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UPathPoints Path => ReadUObject<UPathPoints>(0xD8);
		
		/// <summary>
		/// Name: TimeSinceAttackPointUpdate
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float TimeSinceAttackPointUpdate
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_MoveTowardsCurrentTargetWithPathing_C:UBTTask_BlueprintBase
	/// Size: 0x120
	/// Properties: 13
	/// </summary>
	public class UBTTask_MoveTowardsCurrentTargetWithPathing_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 288;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Attacker
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C Attacker => ReadUObject<ABaseNPC_C>(0xA8);
		
		/// <summary>
		/// Name: MoveFailReason
		/// Type: ByteProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public byte MoveFailReason
		{
			get
			{
				return ReadByte(0xB0);
			}
			set
			{
				WriteByte(0xB0,value);
			}
		}
		
		/// <summary>
		/// Name: DestinationAtMoveStart
		/// Type: StructProperty
		/// Offset: 0xB4
		/// Size: 0x0C
		/// </summary>
		public FVector DestinationAtMoveStart => ReadStruct<FVector>(0xB4);
		
		/// <summary>
		/// Name: RepathDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0xC0
		/// Size: 0x04
		/// </summary>
		public float RepathDistanceThreshold
		{
			get
			{
				return ReadSingle(0xC0);
			}
			set
			{
				WriteSingle(0xC0,value);
			}
		}
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xC8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xC8);
		
		/// <summary>
		/// Name: Stopwhendirectmovementispossible
		/// Type: BoolProperty
		/// Offset: 0xD0
		/// Size: 0x01
		/// </summary>
		public bool Stopwhendirectmovementispossible
		{
			get
			{
				return ReadBool(0xD0);
			}
			set
			{
				WriteBool(0xD0,value);
			}
		}
		
		/// <summary>
		/// Name: Destination
		/// Type: StructProperty
		/// Offset: 0xD4
		/// Size: 0x0C
		/// </summary>
		public FVector Destination => ReadStruct<FVector>(0xD4);
		
		/// <summary>
		/// Name: AttackPoint
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x20
		/// </summary>
		public FTargetArea AttackPoint => ReadStruct<FTargetArea>(0xE0);
		
		/// <summary>
		/// Name: Moving
		/// Type: IntProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public int Moving
		{
			get
			{
				return ReadInt32(0x100);
			}
			set
			{
				WriteInt32(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: Success
		/// Type: BoolProperty
		/// Offset: 0x104
		/// Size: 0x01
		/// </summary>
		public bool Success
		{
			get
			{
				return ReadBool(0x104);
			}
			set
			{
				WriteBool(0x104,value);
			}
		}
		
		/// <summary>
		/// Name: TargetLocationAtMoveStart
		/// Type: StructProperty
		/// Offset: 0x108
		/// Size: 0x0C
		/// </summary>
		public FVector TargetLocationAtMoveStart => ReadStruct<FVector>(0x108);
		
		/// <summary>
		/// Name: NPCAttackStats
		/// Type: ObjectProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public UBP_TargetAttackStats_C NPCAttackStats => ReadUObject<UBP_TargetAttackStats_C>(0x118);
		
	}


	/// <summary>
	/// UBTTask_RandomiseSeed_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_RandomiseSeed_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_RandomizeAttackPointAngleBias_C:UBTTask_BlueprintBase
	/// Size: 0xC4
	/// Properties: 4
	/// </summary>
	public class UBTTask_RandomizeAttackPointAngleBias_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 196;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: mode
		/// Type: ByteProperty
		/// Offset: 0xA8
		/// Size: 0x01
		/// </summary>
		public byte mode
		{
			get
			{
				return ReadByte(0xA8);
			}
			set
			{
				WriteByte(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: Controller
		/// Type: InterfaceProperty
		/// Offset: 0xB0
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: NewBias
		/// Type: FloatProperty
		/// Offset: 0xC0
		/// Size: 0x04
		/// </summary>
		public float NewBias
		{
			get
			{
				return ReadSingle(0xC0);
			}
			set
			{
				WriteSingle(0xC0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_ReleaseAttackPoint_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_ReleaseAttackPoint_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_RotateToLookatTarget_C:UBTTask_BlueprintBase
	/// Size: 0xD0
	/// Properties: 7
	/// </summary>
	public class UBTTask_RotateToLookatTarget_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C Controller => ReadUObject<AAI_Controller_NPC_C>(0xA8);
		
		/// <summary>
		/// Name: Attacker
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C Attacker => ReadUObject<ABaseNPC_C>(0xB0);
		
		/// <summary>
		/// Name: IsRotating
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool IsRotating
		{
			get
			{
				return ReadBool(0xB8);
			}
			set
			{
				WriteBool(0xB8,value);
			}
		}
		
		/// <summary>
		/// Name: LookAtTarget
		/// Type: StructProperty
		/// Offset: 0xBC
		/// Size: 0x0C
		/// </summary>
		public FVector LookAtTarget => ReadStruct<FVector>(0xBC);
		
		/// <summary>
		/// Name: StopMovement
		/// Type: BoolProperty
		/// Offset: 0xC8
		/// Size: 0x01
		/// </summary>
		public bool StopMovement
		{
			get
			{
				return ReadBool(0xC8);
			}
			set
			{
				WriteBool(0xC8,value);
			}
		}
		
		/// <summary>
		/// Name: TimeSinceExecute
		/// Type: FloatProperty
		/// Offset: 0xCC
		/// Size: 0x04
		/// </summary>
		public float TimeSinceExecute
		{
			get
			{
				return ReadSingle(0xCC);
			}
			set
			{
				WriteSingle(0xCC,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_SpaceOut_C:UBTTask_BlueprintBase
	/// Size: 0xE4
	/// Properties: 7
	/// </summary>
	public class UBTTask_SpaceOut_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 228;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Controller
		/// Type: InterfaceProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Character
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public AConanCharacter Character => ReadUObject<AConanCharacter>(0xB8);
		
		/// <summary>
		/// Name: MovementComponent
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public UCharacterMovementComponent MovementComponent => ReadUObject<UCharacterMovementComponent>(0xC0);
		
		/// <summary>
		/// Name: TargetLocation
		/// Type: StructProperty
		/// Offset: 0xC8
		/// Size: 0x0C
		/// </summary>
		public FVector TargetLocation => ReadStruct<FVector>(0xC8);
		
		/// <summary>
		/// Name: NPCLocation
		/// Type: StructProperty
		/// Offset: 0xD4
		/// Size: 0x0C
		/// </summary>
		public FVector NPCLocation => ReadStruct<FVector>(0xD4);
		
		/// <summary>
		/// Name: Duration
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float Duration
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_SpeedSetRun_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_SpeedSetRun_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_SpeedSetWalk_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_SpeedSetWalk_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_StandGuard_C:UBTTask_BlueprintBase
	/// Size: 0xB1
	/// Properties: 3
	/// </summary>
	public class UBTTask_StandGuard_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 177;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: SelfPawn
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public APawn SelfPawn => ReadUObject<APawn>(0xA8);
		
		/// <summary>
		/// Name: SpawnEmoteState
		/// Type: ByteProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public byte SpawnEmoteState
		{
			get
			{
				return ReadByte(0xB0);
			}
			set
			{
				WriteByte(0xB0,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_StepBack_C:UBTTask_BlueprintBase
	/// Size: 0xB8
	/// Properties: 2
	/// </summary>
	public class UBTTask_StepBack_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 184;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Controller
		/// Type: InterfaceProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UBTTask_StopMovement_C:UBTTask_BlueprintBase
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UBTTask_StopMovement_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
	}


	/// <summary>
	/// UBTTask_StrafeToPosition_C:UBTTask_BlueprintBase
	/// Size: 0xB8
	/// Properties: 2
	/// </summary>
	public class UBTTask_StrafeToPosition_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 184;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: Controller
		/// Type: InterfaceProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UBTTask_Fleeing_C:UBTTask_BlueprintBase
	/// Size: 0xE0
	/// Properties: 8
	/// </summary>
	public class UBTTask_Fleeing_C:UBTTask_BlueprintBase
	{
		public override int ObjectSize => 224;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xA0);
		
		/// <summary>
		/// Name: ControllerReference
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C ControllerReference => ReadUObject<AAI_Controller_NPC_C>(0xA8);
		
		/// <summary>
		/// Name: CurrentTargetReference
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ABaseBPChar_C CurrentTargetReference => ReadUObject<ABaseBPChar_C>(0xB0);
		
		/// <summary>
		/// Name: Fleeer
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C Fleeer => ReadUObject<ABaseNPC_C>(0xB8);
		
		/// <summary>
		/// Name: Fleemindistanceincrement
		/// Type: FloatProperty
		/// Offset: 0xC0
		/// Size: 0x04
		/// </summary>
		public float Fleemindistanceincrement
		{
			get
			{
				return ReadSingle(0xC0);
			}
			set
			{
				WriteSingle(0xC0,value);
			}
		}
		
		/// <summary>
		/// Name: Fleemaxdistanceincrement
		/// Type: FloatProperty
		/// Offset: 0xC4
		/// Size: 0x04
		/// </summary>
		public float Fleemaxdistanceincrement
		{
			get
			{
				return ReadSingle(0xC4);
			}
			set
			{
				WriteSingle(0xC4,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentTargetDirection
		/// Type: StructProperty
		/// Offset: 0xC8
		/// Size: 0x0C
		/// </summary>
		public FVector CurrentTargetDirection => ReadStruct<FVector>(0xC8);
		
		/// <summary>
		/// Name: DebugFleeDestination
		/// Type: StructProperty
		/// Offset: 0xD4
		/// Size: 0x0C
		/// </summary>
		public FVector DebugFleeDestination => ReadStruct<FVector>(0xD4);
		
	}


}

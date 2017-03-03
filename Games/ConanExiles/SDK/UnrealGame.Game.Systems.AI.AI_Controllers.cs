using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Systems.AI.AI_Controllers;


namespace ConanExilesGame.Game.Systems.AI.AI_Controllers
{
	/// <summary>
	/// UBP_AIControllerCharacterInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIControllerCharacterInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AAI_Controller_NPC_C:AConanAIController
	/// Size: 0x688
	/// Properties: 20
	/// </summary>
	public class AAI_Controller_NPC_C:AConanAIController
	{
		public override int ObjectSize => 1672;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5A0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5A0);
		
		/// <summary>
		/// Name: ConanBehaviorTree
		/// Type: ObjectProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		public UConanBehaviorTreeComponent ConanBehaviorTree => ReadUObject<UConanBehaviorTreeComponent>(0x5A8);
		
		/// <summary>
		/// Name: AIPerception
		/// Type: ObjectProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionComponent AIPerception => ReadUObject<UAIPerceptionComponent>(0x5B0);
		
		/// <summary>
		/// Name: CurrentTarget
		/// Type: ObjectProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		public AActor CurrentTarget => ReadUObject<AActor>(0x5B8);
		
		/// <summary>
		/// Name: ControlledCharacter
		/// Type: ObjectProperty
		/// Offset: 0x5C0
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C ControlledCharacter => ReadUObject<ABaseNPC_C>(0x5C0);
		
		/// <summary>
		/// Name: CurrentAttackPoint
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0x28
		/// </summary>
		public FTargetAreaWithSource CurrentAttackPoint => ReadStruct<FTargetAreaWithSource>(0x5C8);
		
		/// <summary>
		/// Name: NextChargeAttackCheckTime
		/// Type: FloatProperty
		/// Offset: 0x5F0
		/// Size: 0x04
		/// </summary>
		public float NextChargeAttackCheckTime
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
		/// Name: CurrentAttackPointAcquisitionTime
		/// Type: FloatProperty
		/// Offset: 0x5F4
		/// Size: 0x04
		/// </summary>
		public float CurrentAttackPointAcquisitionTime
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
		/// Name: ControlledCharacterInterface
		/// Type: InterfaceProperty
		/// Offset: 0x5F8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: IsLeashing
		/// Type: BoolProperty
		/// Offset: 0x608
		/// Size: 0x01
		/// </summary>
		public bool IsLeashing
		{
			get
			{
				return ReadBool(0x608);
			}
			set
			{
				WriteBool(0x608,value);
			}
		}
		
		/// <summary>
		/// Name: BehaviorParameters
		/// Type: ObjectProperty
		/// Offset: 0x610
		/// Size: 0x08
		/// </summary>
		public UBP_NPCBehaviorParameters_C BehaviorParameters => ReadUObject<UBP_NPCBehaviorParameters_C>(0x610);
		
		/// <summary>
		/// Name: ChargeAttackWeapon
		/// Type: ObjectProperty
		/// Offset: 0x618
		/// Size: 0x08
		/// </summary>
		public UGameItem ChargeAttackWeapon => ReadUObject<UGameItem>(0x618);
		
		/// <summary>
		/// Name: TauntWeapon
		/// Type: ObjectProperty
		/// Offset: 0x620
		/// Size: 0x08
		/// </summary>
		public UGameItem TauntWeapon => ReadUObject<UGameItem>(0x620);
		
		/// <summary>
		/// Name: CurrentAttackPointIsAllocated
		/// Type: BoolProperty
		/// Offset: 0x628
		/// Size: 0x01
		/// </summary>
		public bool CurrentAttackPointIsAllocated
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
		
		/// <summary>
		/// Name: PrevMindReadingMode
		/// Type: ByteProperty
		/// Offset: 0x629
		/// Size: 0x01
		/// </summary>
		public byte PrevMindReadingMode
		{
			get
			{
				return ReadByte(0x629);
			}
			set
			{
				WriteByte(0x629,value);
			}
		}
		
		/// <summary>
		/// Name: PlannedCombatAction
		/// Type: ByteProperty
		/// Offset: 0x62A
		/// Size: 0x01
		/// </summary>
		public byte PlannedCombatAction
		{
			get
			{
				return ReadByte(0x62A);
			}
			set
			{
				WriteByte(0x62A,value);
			}
		}
		
		/// <summary>
		/// Name: CachedDistance
		/// Type: FloatProperty
		/// Offset: 0x62C
		/// Size: 0x04
		/// </summary>
		public float CachedDistance
		{
			get
			{
				return ReadSingle(0x62C);
			}
			set
			{
				WriteSingle(0x62C,value);
			}
		}
		
		/// <summary>
		/// Name: FailedDistGainDeltas
		/// Type: FloatProperty
		/// Offset: 0x630
		/// Size: 0x04
		/// </summary>
		public float FailedDistGainDeltas
		{
			get
			{
				return ReadSingle(0x630);
			}
			set
			{
				WriteSingle(0x630,value);
			}
		}
		
		/// <summary>
		/// Name: ComparisonTrans
		/// Type: StructProperty
		/// Offset: 0x640
		/// Size: 0x30
		/// </summary>
		public FTransform ComparisonTrans => ReadStruct<FTransform>(0x640);
		
		/// <summary>
		/// Name: TargetMotionHistory
		/// Type: StructProperty
		/// Offset: 0x670
		/// Size: 0x18
		/// </summary>
		public FMotionHistory TargetMotionHistory => ReadStruct<FMotionHistory>(0x670);
		
	}


	/// <summary>
	/// UBP_AIControllerInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_AIControllerInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AAI_Controller_NPC_Critter_C:AAI_Controller_NPC_C
	/// Size: 0x698
	/// Properties: 2
	/// </summary>
	public class AAI_Controller_NPC_Critter_C:AAI_Controller_NPC_C
	{
		public override int ObjectSize => 1688;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x688
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x688);
		
		/// <summary>
		/// Name: HomeLocation
		/// Type: NameProperty
		/// Offset: 0x690
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AAI_Controller_NPC_Kappa_C:AAI_Controller_NPC_C
	/// Size: 0x688
	/// Properties: 0
	/// </summary>
	public class AAI_Controller_NPC_Kappa_C:AAI_Controller_NPC_C
	{
		public override int ObjectSize => 1672;
	}


	/// <summary>
	/// AAI_Controller_NPC_Rhino_C:AAI_Controller_NPC_C
	/// Size: 0x688
	/// Properties: 0
	/// </summary>
	public class AAI_Controller_NPC_Rhino_C:AAI_Controller_NPC_C
	{
		public override int ObjectSize => 1672;
	}


	/// <summary>
	/// AAI_Controller_NPC_Elephant_C:AAI_Controller_NPC_C
	/// Size: 0x688
	/// Properties: 0
	/// </summary>
	public class AAI_Controller_NPC_Elephant_C:AAI_Controller_NPC_C
	{
		public override int ObjectSize => 1672;
	}


}

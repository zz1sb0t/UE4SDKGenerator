using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Systems.Buffs;
using ConanExilesGame.Game.Systems.Progression;


namespace ConanExilesGame.Game.Systems.Hunger
{
	/// <summary>
	/// UBP_HungerSystem_C:UHungerSystem
	/// Size: 0x1D0
	/// Properties: 40
	/// </summary>
	public class UBP_HungerSystem_C:UHungerSystem
	{
		public override int ObjectSize => 464;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x100);
		
		/// <summary>
		/// Name: FoodMax
		/// Type: FloatProperty
		/// Offset: 0x108
		/// Size: 0x04
		/// </summary>
		public float FoodMax
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
		
		/// <summary>
		/// Name: FoodCurrent
		/// Type: FloatProperty
		/// Offset: 0x10C
		/// Size: 0x04
		/// </summary>
		public float FoodCurrent
		{
			get
			{
				return ReadSingle(0x10C);
			}
			set
			{
				WriteSingle(0x10C,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeBase
		/// Type: FloatProperty
		/// Offset: 0x110
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeBase
		{
			get
			{
				return ReadSingle(0x110);
			}
			set
			{
				WriteSingle(0x110,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkMax
		/// Type: FloatProperty
		/// Offset: 0x114
		/// Size: 0x04
		/// </summary>
		public float DrinkMax
		{
			get
			{
				return ReadSingle(0x114);
			}
			set
			{
				WriteSingle(0x114,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkCurrent
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float DrinkCurrent
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkConsumeBase
		/// Type: FloatProperty
		/// Offset: 0x11C
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeBase
		{
			get
			{
				return ReadSingle(0x11C);
			}
			set
			{
				WriteSingle(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: isHyperthermia
		/// Type: BoolProperty
		/// Offset: 0x120
		/// Size: 0x01
		/// </summary>
		public bool isHyperthermia
		{
			get
			{
				return ReadBool(0x120);
			}
			set
			{
				WriteBool(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: isHypothermia
		/// Type: BoolProperty
		/// Offset: 0x121
		/// Size: 0x01
		/// </summary>
		public bool isHypothermia
		{
			get
			{
				return ReadBool(0x121);
			}
			set
			{
				WriteBool(0x121,value);
			}
		}
		
		/// <summary>
		/// Name: SystemTickRate
		/// Type: FloatProperty
		/// Offset: 0x124
		/// Size: 0x04
		/// </summary>
		public float SystemTickRate
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
		/// Name: isHydrated
		/// Type: BoolProperty
		/// Offset: 0x128
		/// Size: 0x01
		/// </summary>
		public bool isHydrated
		{
			get
			{
				return ReadBool(0x128);
			}
			set
			{
				WriteBool(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: isSated
		/// Type: BoolProperty
		/// Offset: 0x129
		/// Size: 0x01
		/// </summary>
		public bool isSated
		{
			get
			{
				return ReadBool(0x129);
			}
			set
			{
				WriteBool(0x129,value);
			}
		}
		
		/// <summary>
		/// Name: HydratedTimer
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public FTimerHandle HydratedTimer => ReadStruct<FTimerHandle>(0x130);
		
		/// <summary>
		/// Name: SatedTimer
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public FTimerHandle SatedTimer => ReadStruct<FTimerHandle>(0x138);
		
		/// <summary>
		/// Name: HydratedDuration
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float HydratedDuration
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: SatedDuration
		/// Type: FloatProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public float SatedDuration
		{
			get
			{
				return ReadSingle(0x144);
			}
			set
			{
				WriteSingle(0x144,value);
			}
		}
		
		/// <summary>
		/// Name: ConsumeFoodTimer
		/// Type: StructProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ConsumeFoodTimer => ReadStruct<FTimerHandle>(0x148);
		
		/// <summary>
		/// Name: ConsumeDrinkTimer
		/// Type: StructProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ConsumeDrinkTimer => ReadStruct<FTimerHandle>(0x150);
		
		/// <summary>
		/// Name: isDrinkDepleted
		/// Type: BoolProperty
		/// Offset: 0x158
		/// Size: 0x01
		/// </summary>
		public bool isDrinkDepleted
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
		/// Name: isFoodDepleted
		/// Type: BoolProperty
		/// Offset: 0x159
		/// Size: 0x01
		/// </summary>
		public bool isFoodDepleted
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
		/// Name: BuffHungry
		/// Type: ClassProperty
		/// Offset: 0x160
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BasePlayerChar
		/// Type: ObjectProperty
		/// Offset: 0x168
		/// Size: 0x08
		/// </summary>
		public ABaseBPChar_C BasePlayerChar => ReadUObject<ABaseBPChar_C>(0x168);
		
		/// <summary>
		/// Name: BuffSated
		/// Type: ClassProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DebugFoodTickEnabled
		/// Type: BoolProperty
		/// Offset: 0x178
		/// Size: 0x01
		/// </summary>
		public bool DebugFoodTickEnabled
		{
			get
			{
				return ReadBool(0x178);
			}
			set
			{
				WriteBool(0x178,value);
			}
		}
		
		/// <summary>
		/// Name: DebugDrinkTickEnabled
		/// Type: BoolProperty
		/// Offset: 0x179
		/// Size: 0x01
		/// </summary>
		public bool DebugDrinkTickEnabled
		{
			get
			{
				return ReadBool(0x179);
			}
			set
			{
				WriteBool(0x179,value);
			}
		}
		
		/// <summary>
		/// Name: BuffHydrated
		/// Type: ClassProperty
		/// Offset: 0x180
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BuffThirsty
		/// Type: ClassProperty
		/// Offset: 0x188
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BuffFoodPoisoning
		/// Type: ClassProperty
		/// Offset: 0x190
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: BuffSystem
		/// Type: ObjectProperty
		/// Offset: 0x198
		/// Size: 0x08
		/// </summary>
		public U00_BP_AC_BuffSystem_C BuffSystem => ReadUObject<U00_BP_AC_BuffSystem_C>(0x198);
		
		/// <summary>
		/// Name: ProgressionSystem
		/// Type: ObjectProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public UBP_ProgressionSystem_C ProgressionSystem => ReadUObject<UBP_ProgressionSystem_C>(0x1A0);
		
		/// <summary>
		/// Name: DrinkConsumeIdleMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1A8
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeIdleMultiplier
		{
			get
			{
				return ReadSingle(0x1A8);
			}
			set
			{
				WriteSingle(0x1A8,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkConsumeActiveMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1AC
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeActiveMultiplier
		{
			get
			{
				return ReadSingle(0x1AC);
			}
			set
			{
				WriteSingle(0x1AC,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkConsumeOfflineMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1B0
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeOfflineMultiplier
		{
			get
			{
				return ReadSingle(0x1B0);
			}
			set
			{
				WriteSingle(0x1B0,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeIdleMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1B4
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeIdleMultiplier
		{
			get
			{
				return ReadSingle(0x1B4);
			}
			set
			{
				WriteSingle(0x1B4,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeActiveMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1B8
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeActiveMultiplier
		{
			get
			{
				return ReadSingle(0x1B8);
			}
			set
			{
				WriteSingle(0x1B8,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeOfflineMultiplier
		/// Type: FloatProperty
		/// Offset: 0x1BC
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeOfflineMultiplier
		{
			get
			{
				return ReadSingle(0x1BC);
			}
			set
			{
				WriteSingle(0x1BC,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeMax
		/// Type: FloatProperty
		/// Offset: 0x1C0
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeMax
		{
			get
			{
				return ReadSingle(0x1C0);
			}
			set
			{
				WriteSingle(0x1C0,value);
			}
		}
		
		/// <summary>
		/// Name: FoodConsumeMin
		/// Type: FloatProperty
		/// Offset: 0x1C4
		/// Size: 0x04
		/// </summary>
		public float FoodConsumeMin
		{
			get
			{
				return ReadSingle(0x1C4);
			}
			set
			{
				WriteSingle(0x1C4,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkConsumeMax
		/// Type: FloatProperty
		/// Offset: 0x1C8
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeMax
		{
			get
			{
				return ReadSingle(0x1C8);
			}
			set
			{
				WriteSingle(0x1C8,value);
			}
		}
		
		/// <summary>
		/// Name: DrinkConsumeMin
		/// Type: FloatProperty
		/// Offset: 0x1CC
		/// Size: 0x04
		/// </summary>
		public float DrinkConsumeMin
		{
			get
			{
				return ReadSingle(0x1CC);
			}
			set
			{
				WriteSingle(0x1CC,value);
			}
		}
		
	}


	/// <summary>
	/// UBPI_HungerSystem_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBPI_HungerSystem_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

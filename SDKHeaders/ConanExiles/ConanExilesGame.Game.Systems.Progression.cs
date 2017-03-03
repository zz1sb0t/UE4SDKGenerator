using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Combat.EncumbranceSystem;


namespace ConanExilesGame.Game.Systems.Progression
{
	/// <summary>
	/// UDmgTypeHealth_BP_C:UDamageType
	/// Size: 0x41
	/// Properties: 1
	/// </summary>
	public class UDmgTypeHealth_BP_C:UDamageType
	{
		public override int ObjectSize => 65;
		/// <summary>
		/// Name: WasBlocked
		/// Type: BoolProperty
		/// Offset: 0x40
		/// Size: 0x01
		/// </summary>
		public bool WasBlocked
		{
			get
			{
				return ReadBool(0x40);
			}
			set
			{
				WriteBool(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// UDmgTypeHarvest_BP_C:UDamageType
	/// Size: 0x40
	/// Properties: 0
	/// </summary>
	public class UDmgTypeHarvest_BP_C:UDamageType
	{
		public override int ObjectSize => 64;
	}


	/// <summary>
	/// UBP_XPHolder_C:UActorComponent
	/// Size: 0xF4
	/// Properties: 2
	/// </summary>
	public class UBP_XPHolder_C:UActorComponent
	{
		public override int ObjectSize => 244;
		/// <summary>
		/// Name: MonsterType
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x18
		/// </summary>
		public FDataTableCategoryHandle MonsterType => ReadStruct<FDataTableCategoryHandle>(0xD8);
		
		/// <summary>
		/// Name: XPToGive
		/// Type: IntProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public int XPToGive
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
		
	}


	/// <summary>
	/// UDmgTypeConcusive_BP_C:UDamageType
	/// Size: 0x40
	/// Properties: 0
	/// </summary>
	public class UDmgTypeConcusive_BP_C:UDamageType
	{
		public override int ObjectSize => 64;
	}


	/// <summary>
	/// UDmgTypeStamina_BP_C:UDamageType
	/// Size: 0x40
	/// Properties: 0
	/// </summary>
	public class UDmgTypeStamina_BP_C:UDamageType
	{
		public override int ObjectSize => 64;
	}


	/// <summary>
	/// UBP_ProgressionSystem_C:UProgressionSystem
	/// Size: 0x270
	/// Properties: 51
	/// </summary>
	public class UBP_ProgressionSystem_C:UProgressionSystem
	{
		public override int ObjectSize => 624;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x198
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x198);
		
		/// <summary>
		/// Name: ExperiencePoints
		/// Type: FloatProperty
		/// Offset: 0x1A0
		/// Size: 0x04
		/// </summary>
		public float ExperiencePoints
		{
			get
			{
				return ReadSingle(0x1A0);
			}
			set
			{
				WriteSingle(0x1A0,value);
			}
		}
		
		/// <summary>
		/// Name: LevelMax
		/// Type: IntProperty
		/// Offset: 0x1A4
		/// Size: 0x04
		/// </summary>
		public int LevelMax
		{
			get
			{
				return ReadInt32(0x1A4);
			}
			set
			{
				WriteInt32(0x1A4,value);
			}
		}
		
		/// <summary>
		/// Name: LevelMaxLevelStartXP
		/// Type: IntProperty
		/// Offset: 0x1A8
		/// Size: 0x04
		/// </summary>
		public int LevelMaxLevelStartXP
		{
			get
			{
				return ReadInt32(0x1A8);
			}
			set
			{
				WriteInt32(0x1A8,value);
			}
		}
		
		/// <summary>
		/// Name: AttributePointsTotal
		/// Type: IntProperty
		/// Offset: 0x1AC
		/// Size: 0x04
		/// </summary>
		public int AttributePointsTotal
		{
			get
			{
				return ReadInt32(0x1AC);
			}
			set
			{
				WriteInt32(0x1AC,value);
			}
		}
		
		/// <summary>
		/// Name: AttributePointsDistributed
		/// Type: IntProperty
		/// Offset: 0x1B0
		/// Size: 0x04
		/// </summary>
		public int AttributePointsDistributed
		{
			get
			{
				return ReadInt32(0x1B0);
			}
			set
			{
				WriteInt32(0x1B0,value);
			}
		}
		
		/// <summary>
		/// Name: AttributePointsUndistributed
		/// Type: IntProperty
		/// Offset: 0x1B4
		/// Size: 0x04
		/// </summary>
		public int AttributePointsUndistributed
		{
			get
			{
				return ReadInt32(0x1B4);
			}
			set
			{
				WriteInt32(0x1B4,value);
			}
		}
		
		/// <summary>
		/// Name: CraftActionXP
		/// Type: FloatProperty
		/// Offset: 0x1B8
		/// Size: 0x04
		/// </summary>
		public float CraftActionXP
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
		/// Name: PickupHarvestActionXP
		/// Type: FloatProperty
		/// Offset: 0x1BC
		/// Size: 0x04
		/// </summary>
		public float PickupHarvestActionXP
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
		/// Name: HarvestActionXP
		/// Type: FloatProperty
		/// Offset: 0x1C0
		/// Size: 0x04
		/// </summary>
		public float HarvestActionXP
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
		/// Name: TimeActionXP
		/// Type: FloatProperty
		/// Offset: 0x1C4
		/// Size: 0x04
		/// </summary>
		public float TimeActionXP
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
		/// Name: LevelEnd
		/// Type: IntProperty
		/// Offset: 0x1C8
		/// Size: 0x04
		/// </summary>
		public int LevelEnd
		{
			get
			{
				return ReadInt32(0x1C8);
			}
			set
			{
				WriteInt32(0x1C8,value);
			}
		}
		
		/// <summary>
		/// Name: LevelStart
		/// Type: IntProperty
		/// Offset: 0x1CC
		/// Size: 0x04
		/// </summary>
		public int LevelStart
		{
			get
			{
				return ReadInt32(0x1CC);
			}
			set
			{
				WriteInt32(0x1CC,value);
			}
		}
		
		/// <summary>
		/// Name: KillActionXPMod
		/// Type: FloatProperty
		/// Offset: 0x1D0
		/// Size: 0x04
		/// </summary>
		public float KillActionXPMod
		{
			get
			{
				return ReadSingle(0x1D0);
			}
			set
			{
				WriteSingle(0x1D0,value);
			}
		}
		
		/// <summary>
		/// Name: CraftActionXPMod
		/// Type: FloatProperty
		/// Offset: 0x1D4
		/// Size: 0x04
		/// </summary>
		public float CraftActionXPMod
		{
			get
			{
				return ReadSingle(0x1D4);
			}
			set
			{
				WriteSingle(0x1D4,value);
			}
		}
		
		/// <summary>
		/// Name: HarvestActionXPMod
		/// Type: FloatProperty
		/// Offset: 0x1D8
		/// Size: 0x04
		/// </summary>
		public float HarvestActionXPMod
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
		/// Name: TimeActionXPMod
		/// Type: FloatProperty
		/// Offset: 0x1DC
		/// Size: 0x04
		/// </summary>
		public float TimeActionXPMod
		{
			get
			{
				return ReadSingle(0x1DC);
			}
			set
			{
				WriteSingle(0x1DC,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeHealth
		/// Type: IntProperty
		/// Offset: 0x1E0
		/// Size: 0x04
		/// </summary>
		public int AttributeHealth
		{
			get
			{
				return ReadInt32(0x1E0);
			}
			set
			{
				WriteInt32(0x1E0,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeStamina
		/// Type: IntProperty
		/// Offset: 0x1E4
		/// Size: 0x04
		/// </summary>
		public int AttributeStamina
		{
			get
			{
				return ReadInt32(0x1E4);
			}
			set
			{
				WriteInt32(0x1E4,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeEncumbrance
		/// Type: IntProperty
		/// Offset: 0x1E8
		/// Size: 0x04
		/// </summary>
		public int AttributeEncumbrance
		{
			get
			{
				return ReadInt32(0x1E8);
			}
			set
			{
				WriteInt32(0x1E8,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeMight
		/// Type: IntProperty
		/// Offset: 0x1EC
		/// Size: 0x04
		/// </summary>
		public int AttributeMight
		{
			get
			{
				return ReadInt32(0x1EC);
			}
			set
			{
				WriteInt32(0x1EC,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeAccuracy
		/// Type: IntProperty
		/// Offset: 0x1F0
		/// Size: 0x04
		/// </summary>
		public int AttributeAccuracy
		{
			get
			{
				return ReadInt32(0x1F0);
			}
			set
			{
				WriteInt32(0x1F0,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeAthleticism
		/// Type: IntProperty
		/// Offset: 0x1F4
		/// Size: 0x04
		/// </summary>
		public int AttributeAthleticism
		{
			get
			{
				return ReadInt32(0x1F4);
			}
			set
			{
				WriteInt32(0x1F4,value);
			}
		}
		
		/// <summary>
		/// Name: AttributeMetabolism
		/// Type: IntProperty
		/// Offset: 0x1F8
		/// Size: 0x04
		/// </summary>
		public int AttributeMetabolism
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
		/// Name: AttributeResilience
		/// Type: IntProperty
		/// Offset: 0x1FC
		/// Size: 0x04
		/// </summary>
		public int AttributeResilience
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
		/// Name: BonusEncumbrance
		/// Type: FloatProperty
		/// Offset: 0x200
		/// Size: 0x04
		/// </summary>
		public float BonusEncumbrance
		{
			get
			{
				return ReadSingle(0x200);
			}
			set
			{
				WriteSingle(0x200,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDamageMelee
		/// Type: FloatProperty
		/// Offset: 0x204
		/// Size: 0x04
		/// </summary>
		public float BonusDamageMelee
		{
			get
			{
				return ReadSingle(0x204);
			}
			set
			{
				WriteSingle(0x204,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDamageRange
		/// Type: FloatProperty
		/// Offset: 0x208
		/// Size: 0x04
		/// </summary>
		public float BonusDamageRange
		{
			get
			{
				return ReadSingle(0x208);
			}
			set
			{
				WriteSingle(0x208,value);
			}
		}
		
		/// <summary>
		/// Name: BonusArmor
		/// Type: FloatProperty
		/// Offset: 0x20C
		/// Size: 0x04
		/// </summary>
		public float BonusArmor
		{
			get
			{
				return ReadSingle(0x20C);
			}
			set
			{
				WriteSingle(0x20C,value);
			}
		}
		
		/// <summary>
		/// Name: BonusHealthPerAttribute
		/// Type: IntProperty
		/// Offset: 0x210
		/// Size: 0x04
		/// </summary>
		public int BonusHealthPerAttribute
		{
			get
			{
				return ReadInt32(0x210);
			}
			set
			{
				WriteInt32(0x210,value);
			}
		}
		
		/// <summary>
		/// Name: BonusStaminaPerAttribute
		/// Type: IntProperty
		/// Offset: 0x214
		/// Size: 0x04
		/// </summary>
		public int BonusStaminaPerAttribute
		{
			get
			{
				return ReadInt32(0x214);
			}
			set
			{
				WriteInt32(0x214,value);
			}
		}
		
		/// <summary>
		/// Name: BonusEncumbrancePerAttribute
		/// Type: FloatProperty
		/// Offset: 0x218
		/// Size: 0x04
		/// </summary>
		public float BonusEncumbrancePerAttribute
		{
			get
			{
				return ReadSingle(0x218);
			}
			set
			{
				WriteSingle(0x218,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDamageMeleePerAttribute
		/// Type: FloatProperty
		/// Offset: 0x21C
		/// Size: 0x04
		/// </summary>
		public float BonusDamageMeleePerAttribute
		{
			get
			{
				return ReadSingle(0x21C);
			}
			set
			{
				WriteSingle(0x21C,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDamageRangePerAttribute
		/// Type: FloatProperty
		/// Offset: 0x220
		/// Size: 0x04
		/// </summary>
		public float BonusDamageRangePerAttribute
		{
			get
			{
				return ReadSingle(0x220);
			}
			set
			{
				WriteSingle(0x220,value);
			}
		}
		
		/// <summary>
		/// Name: BonusArmorPerAttribute
		/// Type: FloatProperty
		/// Offset: 0x224
		/// Size: 0x04
		/// </summary>
		public float BonusArmorPerAttribute
		{
			get
			{
				return ReadSingle(0x224);
			}
			set
			{
				WriteSingle(0x224,value);
			}
		}
		
		/// <summary>
		/// Name: BonusFallDamageReduction
		/// Type: FloatProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public float BonusFallDamageReduction
		{
			get
			{
				return ReadSingle(0x228);
			}
			set
			{
				WriteSingle(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: BonusFallDamageReductionPerAttribute
		/// Type: FloatProperty
		/// Offset: 0x22C
		/// Size: 0x04
		/// </summary>
		public float BonusFallDamageReductionPerAttribute
		{
			get
			{
				return ReadSingle(0x22C);
			}
			set
			{
				WriteSingle(0x22C,value);
			}
		}
		
		/// <summary>
		/// Name: EncumbranceSystem
		/// Type: ObjectProperty
		/// Offset: 0x230
		/// Size: 0x08
		/// </summary>
		public UBP_EncumbranceSystem_C EncumbranceSystem => ReadUObject<UBP_EncumbranceSystem_C>(0x230);
		
		/// <summary>
		/// Name: RecipeManager
		/// Type: ObjectProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public URecipeManager RecipeManager => ReadUObject<URecipeManager>(0x238);
		
		/// <summary>
		/// Name: BonusFoodConsumptionModifier
		/// Type: FloatProperty
		/// Offset: 0x240
		/// Size: 0x04
		/// </summary>
		public float BonusFoodConsumptionModifier
		{
			get
			{
				return ReadSingle(0x240);
			}
			set
			{
				WriteSingle(0x240,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDrinkConsumptionModifier
		/// Type: FloatProperty
		/// Offset: 0x244
		/// Size: 0x04
		/// </summary>
		public float BonusDrinkConsumptionModifier
		{
			get
			{
				return ReadSingle(0x244);
			}
			set
			{
				WriteSingle(0x244,value);
			}
		}
		
		/// <summary>
		/// Name: BonusHungerBuffDurationModifier
		/// Type: FloatProperty
		/// Offset: 0x248
		/// Size: 0x04
		/// </summary>
		public float BonusHungerBuffDurationModifier
		{
			get
			{
				return ReadSingle(0x248);
			}
			set
			{
				WriteSingle(0x248,value);
			}
		}
		
		/// <summary>
		/// Name: BonusFoodConsumptionModifierPerPoint
		/// Type: FloatProperty
		/// Offset: 0x24C
		/// Size: 0x04
		/// </summary>
		public float BonusFoodConsumptionModifierPerPoint
		{
			get
			{
				return ReadSingle(0x24C);
			}
			set
			{
				WriteSingle(0x24C,value);
			}
		}
		
		/// <summary>
		/// Name: BonusDrinkConsumptionModifierPerPoint
		/// Type: FloatProperty
		/// Offset: 0x250
		/// Size: 0x04
		/// </summary>
		public float BonusDrinkConsumptionModifierPerPoint
		{
			get
			{
				return ReadSingle(0x250);
			}
			set
			{
				WriteSingle(0x250,value);
			}
		}
		
		/// <summary>
		/// Name: BonusHungerBuffDurationModifierPerPoint
		/// Type: FloatProperty
		/// Offset: 0x254
		/// Size: 0x04
		/// </summary>
		public float BonusHungerBuffDurationModifierPerPoint
		{
			get
			{
				return ReadSingle(0x254);
			}
			set
			{
				WriteSingle(0x254,value);
			}
		}
		
		/// <summary>
		/// Name: BuildActionXP
		/// Type: FloatProperty
		/// Offset: 0x258
		/// Size: 0x04
		/// </summary>
		public float BuildActionXP
		{
			get
			{
				return ReadSingle(0x258);
			}
			set
			{
				WriteSingle(0x258,value);
			}
		}
		
		/// <summary>
		/// Name: BuildActionXPMod
		/// Type: FloatProperty
		/// Offset: 0x25C
		/// Size: 0x04
		/// </summary>
		public float BuildActionXPMod
		{
			get
			{
				return ReadSingle(0x25C);
			}
			set
			{
				WriteSingle(0x25C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAttributePointsSpent
		/// Type: IntProperty
		/// Offset: 0x260
		/// Size: 0x04
		/// </summary>
		public int MaxAttributePointsSpent
		{
			get
			{
				return ReadInt32(0x260);
			}
			set
			{
				WriteInt32(0x260,value);
			}
		}
		
		/// <summary>
		/// Name: PrintXPActivated
		/// Type: BoolProperty
		/// Offset: 0x264
		/// Size: 0x01
		/// </summary>
		public bool PrintXPActivated
		{
			get
			{
				return ReadBool(0x264);
			}
			set
			{
				WriteBool(0x264,value);
			}
		}
		
		/// <summary>
		/// Name: CraftActionXPTweakMod
		/// Type: FloatProperty
		/// Offset: 0x268
		/// Size: 0x04
		/// </summary>
		public float CraftActionXPTweakMod
		{
			get
			{
				return ReadSingle(0x268);
			}
			set
			{
				WriteSingle(0x268,value);
			}
		}
		
		/// <summary>
		/// Name: KillActionXPTweakMod
		/// Type: FloatProperty
		/// Offset: 0x26C
		/// Size: 0x04
		/// </summary>
		public float KillActionXPTweakMod
		{
			get
			{
				return ReadSingle(0x26C);
			}
			set
			{
				WriteSingle(0x26C,value);
			}
		}
		
	}


	/// <summary>
	/// FSTR_FeatsPerLevel:
	/// Size: 0x04
	/// Properties: 1
	/// </summary>
	public class FSTR_FeatsPerLevel:MemoryObject
	{
		public override int ObjectSize => 4;
		/// <summary>
		/// Name: FeatPoints_2_00E1EFDF4DE98FF8599AE8BBD4E7E803
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int FeatPoints_2_00E1EFDF4DE98FF8599AE8BBD4E7E803
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


	/// <summary>
	/// FSTR_AttributeSystem:
	/// Size: 0x08
	/// Properties: 2
	/// </summary>
	public class FSTR_AttributeSystem:MemoryObject
	{
		public override int ObjectSize => 8;
		/// <summary>
		/// Name: CostPerPoint_2_19121D85471D863F5D89E185442B259F
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int CostPerPoint_2_19121D85471D863F5D89E185442B259F
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
		/// Name: RewardPerLevel_5_B3143ACB49D5D4BEBB07AB82D6420E85
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int RewardPerLevel_5_B3143ACB49D5D4BEBB07AB82D6420E85
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
		
	}


	/// <summary>
	/// FSTR_ExperienceSystemLevel:
	/// Size: 0x08
	/// Properties: 2
	/// </summary>
	public class FSTR_ExperienceSystemLevel:MemoryObject
	{
		public override int ObjectSize => 8;
		/// <summary>
		/// Name: LevelStart_3_AA3E06CB4FFAD3E976865EA2C0357977
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int LevelStart_3_AA3E06CB4FFAD3E976865EA2C0357977
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
		/// Name: LevelEnd_6_6DE74A5048197309D14E318BF1A70E8E
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int LevelEnd_6_6DE74A5048197309D14E318BF1A70E8E
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
		
	}


	/// <summary>
	/// FSTR_MonsterXP:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FSTR_MonsterXP:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: Type_12_6D8679C94ABDBEA9290FBE8D7530396A
		/// Type: StrProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FString Type_12_6D8679C94ABDBEA9290FBE8D7530396A => new FString(BaseAddress+0x00);
		
		/// <summary>
		/// Name: Difficulty_15_9790DCAE44024514CF79AAA9E8A914DE
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int Difficulty_15_9790DCAE44024514CF79AAA9E8A914DE
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
		/// Name: XP_5_FAB0CAEB4DD5FF16E8EAEDA0EC477EB8
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int XP_5_FAB0CAEB4DD5FF16E8EAEDA0EC477EB8
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
		
	}


}

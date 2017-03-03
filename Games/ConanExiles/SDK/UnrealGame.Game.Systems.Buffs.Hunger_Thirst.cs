using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Systems.Buffs.Damage_Percent;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Buffs;


namespace ConanExilesGame.Game.Systems.Buffs.Hunger_Thirst
{
	/// <summary>
	/// UBP_AC_Buff_FoodPoisoning_C:U00_BP_AC_Buff_PercentDamageMaster_C
	/// Size: 0x614
	/// Properties: 2
	/// </summary>
	public class UBP_AC_Buff_FoodPoisoning_C:U00_BP_AC_Buff_PercentDamageMaster_C
	{
		public override int ObjectSize => 1556;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x608
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x608);
		
		/// <summary>
		/// Name: BuffStaminaRegen
		/// Type: FloatProperty
		/// Offset: 0x610
		/// Size: 0x04
		/// </summary>
		public float BuffStaminaRegen
		{
			get
			{
				return ReadSingle(0x610);
			}
			set
			{
				WriteSingle(0x610,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_AC_Buff_HydratedStaminaRegen_C:U01_BP_AC_Buff_Master_C
	/// Size: 0x604
	/// Properties: 2
	/// </summary>
	public class UBP_AC_Buff_HydratedStaminaRegen_C:U01_BP_AC_Buff_Master_C
	{
		public override int ObjectSize => 1540;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5F8);
		
		/// <summary>
		/// Name: BuffStaminaRegen
		/// Type: FloatProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public float BuffStaminaRegen
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
		
	}


	/// <summary>
	/// UBP_AC_Buff_Thirsty_C:U00_BP_AC_Buff_PercentDamageMaster_C
	/// Size: 0x610
	/// Properties: 1
	/// </summary>
	public class UBP_AC_Buff_Thirsty_C:U00_BP_AC_Buff_PercentDamageMaster_C
	{
		public override int ObjectSize => 1552;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x608
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x608);
		
	}


}

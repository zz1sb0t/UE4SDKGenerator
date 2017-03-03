using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Systems.Buffs;
using UnrealGame.Script;
using UnrealGame.Game.Systems.Buffs.Damage_Percent;


namespace UnrealGame.Game.Systems.Buffs.Damage_Percent
{
	/// <summary>
	/// U00_BP_AC_Buff_PercentDamageMaster_C:U01_BP_AC_Buff_Master_C
	/// Size: 0x604
	/// Properties: 2
	/// </summary>
	public class U00_BP_AC_Buff_PercentDamageMaster_C:U01_BP_AC_Buff_Master_C
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
		/// Name: PercentDamage
		/// Type: FloatProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public float PercentDamage
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
	/// UBP_AC_Buff_Starving_C:U00_BP_AC_Buff_PercentDamageMaster_C
	/// Size: 0x610
	/// Properties: 1
	/// </summary>
	public class UBP_AC_Buff_Starving_C:U00_BP_AC_Buff_PercentDamageMaster_C
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

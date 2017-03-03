using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Game.Items.Weapons.AnimPackage;
using ConanExiles.Game.Items.Weapons;
using ConanExiles.Script;


namespace ConanExiles.Game.Characters.NPCs.Imp
{
	/// <summary>
	/// UBP_AnimPackage_Imp_Attack_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_AnimPackage_Imp_Attack_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// ANPC_Weapon_Imp_bc_1_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ANPC_Weapon_Imp_bc_1_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
	}


	/// <summary>
	/// ANPC_Weapon_Imp_bc_2_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ANPC_Weapon_Imp_bc_2_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
	}


	/// <summary>
	/// ANPC_Weapon_Imp_bc_3_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ANPC_Weapon_Imp_bc_3_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
	}


	/// <summary>
	/// ANPC_Weapon_Imp_bc_4_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ANPC_Weapon_Imp_bc_4_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
	}


	/// <summary>
	/// ANPC_Weapon_Imp_t_1_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ANPC_Weapon_Imp_t_1_C:ABaseWeapon_C
	{
		public override int ObjectSize => 1264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x4E8);
		
	}


}

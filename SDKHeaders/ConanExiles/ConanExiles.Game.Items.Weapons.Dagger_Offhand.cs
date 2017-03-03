using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Game.Items.Weapons;
using ConanExiles.Script;


namespace ConanExiles.Game.Items.Weapons.Dagger_Offhand
{
	/// <summary>
	/// ABP_dagger_oh_C:ABaseWeapon_C
	/// Size: 0x4F0
	/// Properties: 1
	/// </summary>
	public class ABP_dagger_oh_C:ABaseWeapon_C
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
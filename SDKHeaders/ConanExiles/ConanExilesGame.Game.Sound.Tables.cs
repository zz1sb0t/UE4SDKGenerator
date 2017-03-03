using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Sound.Tables
{
	/// <summary>
	/// FSTR_WeaponBreakSound:
	/// Size: 0x20
	/// Properties: 0
	/// </summary>
	public class FSTR_WeaponBreakSound:MemoryObject
	{
		public override int ObjectSize => 32;
	}


	/// <summary>
	/// FWeaponMaterialTableStructure:
	/// Size: 0x30
	/// Properties: 2
	/// </summary>
	public class FWeaponMaterialTableStructure:MemoryObject
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: DecalToShow_14_4DB9A4224E95B99D1167B1B68FB3719F
		/// Type: ObjectProperty
		/// Offset: 0x20
		/// Size: 0x08
		/// </summary>
		public UMaterial DecalToShow_14_4DB9A4224E95B99D1167B1B68FB3719F => ReadUObject<UMaterial>(0x20);
		
		/// <summary>
		/// Name: ParticleToShow_13_65F19BB64CD2C58A8094F1B42BD9E006
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UParticleSystem ParticleToShow_13_65F19BB64CD2C58A8094F1B42BD9E006 => ReadUObject<UParticleSystem>(0x28);
		
	}


	/// <summary>
	/// FFootstepDataTableStructure:
	/// Size: 0x20
	/// Properties: 0
	/// </summary>
	public class FFootstepDataTableStructure:MemoryObject
	{
		public override int ObjectSize => 32;
	}


	/// <summary>
	/// FWalkFoleyDataTableStructure:
	/// Size: 0x20
	/// Properties: 0
	/// </summary>
	public class FWalkFoleyDataTableStructure:MemoryObject
	{
		public override int ObjectSize => 32;
	}


	/// <summary>
	/// USoundFunctionLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USoundFunctionLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


}

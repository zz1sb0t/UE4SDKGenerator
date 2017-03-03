using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Religion
{
	/// <summary>
	/// UReligionData_C:UActorComponent
	/// Size: 0xE8
	/// Properties: 1
	/// </summary>
	public class UReligionData_C:UActorComponent
	{
		public override int ObjectSize => 232;
		/// <summary>
		/// Name: Favors
		/// Type: TArray<>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UBP_ReligionSystem_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_ReligionSystem_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// FFavorFromRecipeRow:
	/// Size: 0x10
	/// Properties: 1
	/// </summary>
	public class FFavorFromRecipeRow:MemoryObject
	{
		public override int ObjectSize => 16;
		/// <summary>
		/// Name: FavorGranted_7_C2654026444D60D4142EFE8360CE97C4
		/// Type: TArray<>
		/// Offset: 0x00
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UBPAltarInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBPAltarInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


}

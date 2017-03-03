using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;


namespace ConanExilesGame.Game.Maps.ConanSandbox.Cinematics
{
	/// <summary>
	/// ACinematic_level_C:ALevelScriptActor
	/// Size: 0x3E8
	/// Properties: 2
	/// </summary>
	public class ACinematic_level_C:ALevelScriptActor
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D8);
		
		/// <summary>
		/// Name: CinematicCharacter_2_ExecuteUbergraph_Cinematic_level_RefProperty
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public ACinematicCharacter_C CinematicCharacter_2_ExecuteUbergraph_Cinematic_level_RefProperty => ReadUObject<ACinematicCharacter_C>(0x3E0);
		
	}


}

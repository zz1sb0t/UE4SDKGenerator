using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;
using UnrealGame.Game.Characters;


namespace UnrealGame.Game.Maps.ConanSandbox.Cinematics
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

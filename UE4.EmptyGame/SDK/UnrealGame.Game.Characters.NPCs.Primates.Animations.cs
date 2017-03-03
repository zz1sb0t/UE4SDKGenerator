using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Master_AnimBP;
using UnrealGame.Script;


namespace UnrealGame.Game.Characters.NPCs.Primates.Animations
{
	/// <summary>
	/// UAB_Kappa_C:UAB_Master_Quadropeds_C
	/// Size: 0x14E0
	/// Properties: 1
	/// </summary>
	public class UAB_Kappa_C:UAB_Master_Quadropeds_C
	{
		public override int ObjectSize => 5344;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x14D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x14D8);
		
	}


	/// <summary>
	/// UAB_Kappa_Baby_C:UAB_Master_Quadropeds_C
	/// Size: 0x14E0
	/// Properties: 1
	/// </summary>
	public class UAB_Kappa_Baby_C:UAB_Master_Quadropeds_C
	{
		public override int ObjectSize => 5344;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x14D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x14D8);
		
	}


}

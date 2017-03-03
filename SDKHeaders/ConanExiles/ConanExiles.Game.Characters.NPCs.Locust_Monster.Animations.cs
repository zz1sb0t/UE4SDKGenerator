using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Game.Master_AnimBP;
using ConanExiles.Script;


namespace ConanExiles.Game.Characters.NPCs.Locust_Monster.Animations
{
	/// <summary>
	/// UAB_Locust_Monster_melee_C:UAB_Master_Quadropeds_C
	/// Size: 0x14E0
	/// Properties: 1
	/// </summary>
	public class UAB_Locust_Monster_melee_C:UAB_Master_Quadropeds_C
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
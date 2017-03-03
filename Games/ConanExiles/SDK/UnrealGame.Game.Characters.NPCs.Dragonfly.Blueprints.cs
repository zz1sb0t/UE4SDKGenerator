using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.NPCs.Dragonfly.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Dragonfly_C:ABaseBPWildlife_C
	/// Size: 0x1124
	/// Properties: 3
	/// </summary>
	public class ABP_NPC_Wildlife_Dragonfly_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4388;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: NewVar
		/// Type: FloatProperty
		/// Offset: 0x1120
		/// Size: 0x04
		/// </summary>
		public float NewVar
		{
			get
			{
				return ReadSingle(0x1120);
			}
			set
			{
				WriteSingle(0x1120,value);
			}
		}
		
	}


}

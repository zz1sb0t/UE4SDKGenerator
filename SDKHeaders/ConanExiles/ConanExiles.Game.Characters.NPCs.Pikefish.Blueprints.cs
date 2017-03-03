using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Game.Characters;
using ConanExiles.Game.Characters.NPCs.Pikefish.Blueprints;


namespace ConanExiles.Game.Characters.NPCs.Pikefish.Blueprints
{
	/// <summary>
	/// ABP_Wildlife_Pikefish_C:ABaseNPC_C
	/// Size: 0x10E4
	/// Properties: 0
	/// </summary>
	public class ABP_Wildlife_Pikefish_C:ABaseNPC_C
	{
		public override int ObjectSize => 4324;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Pikefish_C:ABP_Wildlife_Pikefish_C
	/// Size: 0x10E4
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Pikefish_C:ABP_Wildlife_Pikefish_C
	{
		public override int ObjectSize => 4324;
	}


}

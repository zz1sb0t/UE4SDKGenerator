using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Piranha.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Piranha.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Piranha_C:ABaseNPC_C
	/// Size: 0x1100
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Piranha_C:ABaseNPC_C
	{
		public override int ObjectSize => 4352;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x10E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x10E8);
		
		/// <summary>
		/// Name: TempMaterialList
		/// Type: TArray<UMaterialInstance>
		/// Offset: 0x10F0
		/// Size: 0x10
		/// SubElement Size: 0x1C8
		/// </summary>
		public TArray<UMaterialInstance> TempMaterialList => new TArray<UMaterialInstance>(BaseAddress+0x10F0);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Piranha_Blue_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1118
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Piranha_Blue_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4376;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1100
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1100);
		
		/// <summary>
		/// Name: TempMaterialList
		/// Type: TArray<UMaterialInstance>
		/// Offset: 0x1108
		/// Size: 0x10
		/// SubElement Size: 0x1C8
		/// </summary>
		public TArray<UMaterialInstance> TempMaterialList => new TArray<UMaterialInstance>(BaseAddress+0x1108);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Oscarfish_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Oscarfish_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Piranha_Blue_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Piranha_Blue_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Piranha_Red_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Piranha_Red_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Piranha_Red_C:ABP_NPC_Wildlife_Piranha_Red_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Piranha_Red_C:ABP_NPC_Wildlife_Piranha_Red_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Piranha_Yellow_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Piranha_Yellow_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Piranha_Yellow_C:ABP_NPC_Wildlife_Piranha_Yellow_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Piranha_Yellow_C:ABP_NPC_Wildlife_Piranha_Yellow_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Oscarfish_Black_C:ABP_NPC_Wildlife_Oscarfish_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Oscarfish_Black_C:ABP_NPC_Wildlife_Oscarfish_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Oscarfish_Gold_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Oscarfish_Gold_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Oscarfish_Gold_C:ABP_NPC_Wildlife_Oscarfish_Gold_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Oscarfish_Gold_C:ABP_NPC_Wildlife_Oscarfish_Gold_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Oscarfish_Green_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Oscarfish_Green_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Oscarfish_Green_C:ABP_NPC_Wildlife_Oscarfish_Green_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Oscarfish_Green_C:ABP_NPC_Wildlife_Oscarfish_Green_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Oscarfish_Tiger_C:ABP_NPC_Wildlife_Piranha_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Oscarfish_Tiger_C:ABP_NPC_Wildlife_Piranha_C
	{
		public override int ObjectSize => 4352;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Oscarfish_Tiger_C:ABP_NPC_Wildlife_Oscarfish_Tiger_C
	/// Size: 0x1100
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Oscarfish_Tiger_C:ABP_NPC_Wildlife_Oscarfish_Tiger_C
	{
		public override int ObjectSize => 4352;
	}


}

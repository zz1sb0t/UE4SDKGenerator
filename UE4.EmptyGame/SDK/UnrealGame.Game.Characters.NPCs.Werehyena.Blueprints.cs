using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Characters;
using UnrealGame.Script;
using UnrealGame.Game.Characters.NPCs.Werehyena.Blueprints;


namespace UnrealGame.Game.Characters.NPCs.Werehyena.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Werehyena_C:ABaseBPWildlife_C
	/// Size: 0x1148
	/// Properties: 7
	/// </summary>
	public class ABP_NPC_Wildlife_Werehyena_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4424;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: Hitloc_Leftleg
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftleg => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: Hitloc_Rightleg
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightleg => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: Hitloc_Leftarm
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftarm => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: Hitloc_Rightarm
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightarm => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1140);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Werehyena_Spotted_C:ABP_NPC_Wildlife_Werehyena_C
	/// Size: 0x1148
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Werehyena_Spotted_C:ABP_NPC_Wildlife_Werehyena_C
	{
		public override int ObjectSize => 4424;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Werehyena_Striped_C:ABP_NPC_Wildlife_Werehyena_C
	/// Size: 0x1148
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Werehyena_Striped_C:ABP_NPC_Wildlife_Werehyena_C
	{
		public override int ObjectSize => 4424;
	}


}

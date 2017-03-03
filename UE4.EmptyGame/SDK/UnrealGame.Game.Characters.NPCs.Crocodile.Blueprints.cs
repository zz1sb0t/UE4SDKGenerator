using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Game.Characters;
using UnrealGame.Script;
using UnrealGame.Game.Characters.NPCs.Crocodile.Blueprints;


namespace UnrealGame.Game.Characters.NPCs.Crocodile.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Crocodile_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Crocodile_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Komodo_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Komodo_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Komodo_Albino_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Komodo_Albino_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Crocodile_Giant_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Crocodile_Giant_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_Body
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Body => ReadUObject<UCapsuleComponent>(0x1118);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Crocodile_C:ABP_NPC_Wildlife_Crocodile_C
	/// Size: 0x1120
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Crocodile_C:ABP_NPC_Wildlife_Crocodile_C
	{
		public override int ObjectSize => 4384;
	}


}

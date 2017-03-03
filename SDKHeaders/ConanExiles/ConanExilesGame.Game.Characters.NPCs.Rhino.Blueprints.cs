using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;
using ConanExilesGame.Game.Characters.NPCs.Rhino.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Rhino.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Rhino_C:ABaseBPWildlife_C
	/// Size: 0x1170
	/// Properties: 12
	/// </summary>
	public class ABP_NPC_Wildlife_Rhino_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4464;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: Collision
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Collision => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_RightSide
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_RightSide => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: AttackPoint_LeftSide
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_LeftSide => ReadUObject<UBP_CharacterAttackPoint_C>(0x1130);
		
		/// <summary>
		/// Name: AttackPoint_Head
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Head => ReadUObject<UBP_CharacterAttackPoint_C>(0x1138);
		
		/// <summary>
		/// Name: Hitloc_Leftleg
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftleg => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: Hitloc_Rightleg
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightleg => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: Hitloc_Leftarm
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftarm => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: Hitloc_Rightarm
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightarm => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1168);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RhinoGray_C:ABP_NPC_Wildlife_Rhino_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_RhinoGray_C:ABP_NPC_Wildlife_Rhino_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RhinoWhite_C:ABP_NPC_Wildlife_Rhino_C
	/// Size: 0x1178
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_RhinoWhite_C:ABP_NPC_Wildlife_Rhino_C
	{
		public override int ObjectSize => 4472;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1170);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RhinoBlack_C:ABP_NPC_Wildlife_Rhino_C
	/// Size: 0x1178
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_RhinoBlack_C:ABP_NPC_Wildlife_Rhino_C
	{
		public override int ObjectSize => 4472;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1170);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_RhinoKing_C:ABP_NPC_Wildlife_Rhino_C
	/// Size: 0x1178
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_RhinoKing_C:ABP_NPC_Wildlife_Rhino_C
	{
		public override int ObjectSize => 4472;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1170);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Rhino_C:ABP_NPC_Wildlife_Rhino_C
	/// Size: 0x1170
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Rhino_C:ABP_NPC_Wildlife_Rhino_C
	{
		public override int ObjectSize => 4464;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RhinoWhite_C:ABP_NPC_Wildlife_RhinoWhite_C
	/// Size: 0x1178
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RhinoWhite_C:ABP_NPC_Wildlife_RhinoWhite_C
	{
		public override int ObjectSize => 4472;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RhinoBlack_C:ABP_NPC_Wildlife_RhinoBlack_C
	/// Size: 0x1178
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RhinoBlack_C:ABP_NPC_Wildlife_RhinoBlack_C
	{
		public override int ObjectSize => 4472;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_RhinoKing_C:ABP_NPC_Wildlife_RhinoKing_C
	/// Size: 0x1178
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_RhinoKing_C:ABP_NPC_Wildlife_RhinoKing_C
	{
		public override int ObjectSize => 4472;
	}


}

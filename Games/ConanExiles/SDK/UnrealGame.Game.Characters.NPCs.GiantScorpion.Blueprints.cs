using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Survival.Gathering.Gathering_v2;
using ConanExilesGame.Game.Characters.NPCs.GiantScorpion.Blueprints;
using ConanExilesGame.Game.Systems.AI;


namespace ConanExilesGame.Game.Characters.NPCs.GiantScorpion.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_PickupableBase_C:ABaseBPWildlife_C
	/// Size: 0x1178
	/// Properties: 13
	/// </summary>
	public class ABP_NPC_Wildlife_PickupableBase_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4472;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: HarvestableComponent_v2
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UHarvestableComponent_v2_C HarvestableComponent_v2 => ReadUObject<UHarvestableComponent_v2_C>(0x1118);
		
		/// <summary>
		/// Name: Hitloc_Leftlegs
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftlegs => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: Hitloc_Righlegs
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Righlegs => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: Hitloc_Leftclaw
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftclaw => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: Hitloc_Rightclaw
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightclaw => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: Hitloc_Rightarm
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightarm => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: Hitloc_Leftarm
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftarm => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: Hitloc_Stinger
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Stinger => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: Hitloc_Tail3
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail3 => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: Hitloc_Tail2
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail2 => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: Hitloc_Tail1
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail1 => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1170);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_SmallScorpion_C:ABP_NPC_Wildlife_PickupableBase_C
	/// Size: 0x11D8
	/// Properties: 12
	/// </summary>
	public class ABP_NPC_Wildlife_SmallScorpion_C:ABP_NPC_Wildlife_PickupableBase_C
	{
		public override int ObjectSize => 4568;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1178);
		
		/// <summary>
		/// Name: Hitloc_Leftlegs
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftlegs => ReadUObject<UCapsuleComponent>(0x1180);
		
		/// <summary>
		/// Name: Hitloc_Righlegs
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Righlegs => ReadUObject<UCapsuleComponent>(0x1188);
		
		/// <summary>
		/// Name: Hitloc_Leftclaw
		/// Type: ObjectProperty
		/// Offset: 0x1190
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftclaw => ReadUObject<UCapsuleComponent>(0x1190);
		
		/// <summary>
		/// Name: Hitloc_Rightclaw
		/// Type: ObjectProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightclaw => ReadUObject<UCapsuleComponent>(0x1198);
		
		/// <summary>
		/// Name: Hitloc_Rightarm
		/// Type: ObjectProperty
		/// Offset: 0x11A0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Rightarm => ReadUObject<UCapsuleComponent>(0x11A0);
		
		/// <summary>
		/// Name: Hitloc_Leftarm
		/// Type: ObjectProperty
		/// Offset: 0x11A8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Leftarm => ReadUObject<UCapsuleComponent>(0x11A8);
		
		/// <summary>
		/// Name: Hitloc_Stinger
		/// Type: ObjectProperty
		/// Offset: 0x11B0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Stinger => ReadUObject<UCapsuleComponent>(0x11B0);
		
		/// <summary>
		/// Name: Hitloc_Tail3
		/// Type: ObjectProperty
		/// Offset: 0x11B8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail3 => ReadUObject<UCapsuleComponent>(0x11B8);
		
		/// <summary>
		/// Name: Hitloc_Tail2
		/// Type: ObjectProperty
		/// Offset: 0x11C0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail2 => ReadUObject<UCapsuleComponent>(0x11C0);
		
		/// <summary>
		/// Name: Hitloc_Tail1
		/// Type: ObjectProperty
		/// Offset: 0x11C8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail1 => ReadUObject<UCapsuleComponent>(0x11C8);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x11D0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x11D0);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Scorpion_C:ABaseBPWildlife_C
	/// Size: 0x1150
	/// Properties: 8
	/// </summary>
	public class ABP_NPC_Wildlife_Scorpion_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4432;
		/// <summary>
		/// Name: Hitloc_Tail3
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail3 => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: Hitloc_Tail2
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail2 => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: Hitloc_Tail1
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Hitloc_Tail1 => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: AttackPoint_Right
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Right => ReadUObject<UBP_CharacterAttackPoint_C>(0x1128);
		
		/// <summary>
		/// Name: AttackPointLeft
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPointLeft => ReadUObject<UBP_CharacterAttackPoint_C>(0x1130);
		
		/// <summary>
		/// Name: AttackPoint_Back
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Back => ReadUObject<UBP_CharacterAttackPoint_C>(0x1138);
		
		/// <summary>
		/// Name: AttackPoint_Front
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UBP_CharacterAttackPoint_C AttackPoint_Front => ReadUObject<UBP_CharacterAttackPoint_C>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x1148);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_MediumScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_MediumScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_GreatScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_GreatScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_GiantScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_GiantScorpion_C:ABP_NPC_Wildlife_Scorpion_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_SmallScorpion_C:ABP_NPC_Wildlife_SmallScorpion_C
	/// Size: 0x11D8
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_SmallScorpion_C:ABP_NPC_Wildlife_SmallScorpion_C
	{
		public override int ObjectSize => 4568;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Scorpion_C:ABP_NPC_Wildlife_Scorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Scorpion_C:ABP_NPC_Wildlife_Scorpion_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_GreatScorpion_C:ABP_NPC_Wildlife_GreatScorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_GreatScorpion_C:ABP_NPC_Wildlife_GreatScorpion_C
	{
		public override int ObjectSize => 4432;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_GiantScorpion_C:ABP_NPC_Wildlife_GiantScorpion_C
	/// Size: 0x1150
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_GiantScorpion_C:ABP_NPC_Wildlife_GiantScorpion_C
	{
		public override int ObjectSize => 4432;
	}


}

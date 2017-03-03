using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters.NPCs.Spider.Blueprints;


namespace ConanExilesGame.Game.Characters.NPCs.Spider.Blueprints
{
	/// <summary>
	/// ABP_NPC_Wildlife_Spider_C:ABaseBPWildlife_C
	/// Size: 0x11E8
	/// Properties: 27
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4584;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x1110);
		
		/// <summary>
		/// Name: HitLoc_LegFoot8
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot8 => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: HitLoc_LegLower8
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower8 => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: HitLoc_LegUpper8
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper8 => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: HitLoc_LegFoot7
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot7 => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: HitLoc_LegLower7
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower7 => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: HitLoc_LegUpper7
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper7 => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: HitLoc_LegFoot6
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot6 => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: HitLoc_LegLower6
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower6 => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: HitLoc_LegUpper6
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper6 => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: HitLoc_LegFoot5
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot5 => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: HitLoc_LegLower5
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower5 => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: HitLoc_LegUpper5
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper5 => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: HitLoc_LegFoot4
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot4 => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: HitLoc_LegLower4
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower4 => ReadUObject<UCapsuleComponent>(0x1180);
		
		/// <summary>
		/// Name: HitLoc_LegUpper4
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper4 => ReadUObject<UCapsuleComponent>(0x1188);
		
		/// <summary>
		/// Name: HitLoc_LegFoot3
		/// Type: ObjectProperty
		/// Offset: 0x1190
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot3 => ReadUObject<UCapsuleComponent>(0x1190);
		
		/// <summary>
		/// Name: HitLoc_LegLower3
		/// Type: ObjectProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower3 => ReadUObject<UCapsuleComponent>(0x1198);
		
		/// <summary>
		/// Name: HitLoc_LegUpper3
		/// Type: ObjectProperty
		/// Offset: 0x11A0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper3 => ReadUObject<UCapsuleComponent>(0x11A0);
		
		/// <summary>
		/// Name: HitLoc_LegFoot2
		/// Type: ObjectProperty
		/// Offset: 0x11A8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot2 => ReadUObject<UCapsuleComponent>(0x11A8);
		
		/// <summary>
		/// Name: HitLoc_LegLower2
		/// Type: ObjectProperty
		/// Offset: 0x11B0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower2 => ReadUObject<UCapsuleComponent>(0x11B0);
		
		/// <summary>
		/// Name: HitLoc_LegUpper2
		/// Type: ObjectProperty
		/// Offset: 0x11B8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper2 => ReadUObject<UCapsuleComponent>(0x11B8);
		
		/// <summary>
		/// Name: HitLoc_LegFoot1
		/// Type: ObjectProperty
		/// Offset: 0x11C0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegFoot1 => ReadUObject<UCapsuleComponent>(0x11C0);
		
		/// <summary>
		/// Name: HitLoc_LegLower1
		/// Type: ObjectProperty
		/// Offset: 0x11C8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegLower1 => ReadUObject<UCapsuleComponent>(0x11C8);
		
		/// <summary>
		/// Name: HitLoc_LegUpper1
		/// Type: ObjectProperty
		/// Offset: 0x11D0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_LegUpper1 => ReadUObject<UCapsuleComponent>(0x11D0);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0x11D8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0x11D8);
		
		/// <summary>
		/// Name: HitLoc_Torso
		/// Type: ObjectProperty
		/// Offset: 0x11E0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Torso => ReadUObject<UCapsuleComponent>(0x11E0);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Grey_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Grey_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_RedMouth_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_RedMouth_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Brown_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Brown_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Green_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Green_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Widow_Black_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Widow_Black_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Widow_Yellow_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Widow_Yellow_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Widow_Red_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Widow_Red_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Widow_Green_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Widow_Green_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Widow_Blue_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Widow_Blue_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_Giant_C:ABP_NPC_Wildlife_Spider_C
	/// Size: 0x11F0
	/// Properties: 1
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_Giant_C:ABP_NPC_Wildlife_Spider_C
	{
		public override int ObjectSize => 4592;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x11E8);
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Spider_GreySmall_C:ABaseBPWildlife_C
	/// Size: 0x1120
	/// Properties: 2
	/// </summary>
	public class ABP_NPC_Wildlife_Spider_GreySmall_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4384;
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
		
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_GreySmall_C:ABP_NPC_Wildlife_Spider_GreySmall_C
	/// Size: 0x1120
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_GreySmall_C:ABP_NPC_Wildlife_Spider_GreySmall_C
	{
		public override int ObjectSize => 4384;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Widow_Black_C:ABP_NPC_Wildlife_Spider_Widow_Black_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Widow_Black_C:ABP_NPC_Wildlife_Spider_Widow_Black_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Widow_Blue_C:ABP_NPC_Wildlife_Spider_Widow_Blue_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Widow_Blue_C:ABP_NPC_Wildlife_Spider_Widow_Blue_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Widow_Green_C:ABP_NPC_Wildlife_Spider_Widow_Green_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Widow_Green_C:ABP_NPC_Wildlife_Spider_Widow_Green_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Widow_Yellow_C:ABP_NPC_Wildlife_Spider_Widow_Yellow_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Widow_Yellow_C:ABP_NPC_Wildlife_Spider_Widow_Yellow_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Widow_Red_C:ABP_NPC_Wildlife_Spider_Widow_Red_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Widow_Red_C:ABP_NPC_Wildlife_Spider_Widow_Red_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Grey_C:ABP_NPC_Wildlife_Spider_Grey_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Grey_C:ABP_NPC_Wildlife_Spider_Grey_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_RedMouth_C:ABP_NPC_Wildlife_Spider_RedMouth_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_RedMouth_C:ABP_NPC_Wildlife_Spider_RedMouth_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Green_C:ABP_NPC_Wildlife_Spider_Green_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Green_C:ABP_NPC_Wildlife_Spider_Green_C
	{
		public override int ObjectSize => 4592;
	}


	/// <summary>
	/// ABP_NPC_Wildlife_Zoo_Spider_Brown_C:ABP_NPC_Wildlife_Spider_Brown_C
	/// Size: 0x11F0
	/// Properties: 0
	/// </summary>
	public class ABP_NPC_Wildlife_Zoo_Spider_Brown_C:ABP_NPC_Wildlife_Spider_Brown_C
	{
		public override int ObjectSize => 4592;
	}


}

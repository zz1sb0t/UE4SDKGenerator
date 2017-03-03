using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.humans.blueprints
{
	/// <summary>
	/// ABP_Cinematic_Ghost_Female_C:ASkeletalMeshActor
	/// Size: 0x4A0
	/// Properties: 9
	/// </summary>
	public class ABP_Cinematic_Ghost_Female_C:ASkeletalMeshActor
	{
		public override int ObjectSize => 1184;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x458);
		
		/// <summary>
		/// Name: SK_human_female_feet
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_feet => ReadUObject<USkeletalMeshComponent>(0x460);
		
		/// <summary>
		/// Name: SK_human_female_hair
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_hair => ReadUObject<USkeletalMeshComponent>(0x468);
		
		/// <summary>
		/// Name: SK_human_female_head_01
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_head_01 => ReadUObject<USkeletalMeshComponent>(0x470);
		
		/// <summary>
		/// Name: SK_human_female_hands
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_hands => ReadUObject<USkeletalMeshComponent>(0x478);
		
		/// <summary>
		/// Name: SK_human_female_forearms
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_forearms => ReadUObject<USkeletalMeshComponent>(0x480);
		
		/// <summary>
		/// Name: SK_human_female_underwear_upperbody
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_underwear_upperbody => ReadUObject<USkeletalMeshComponent>(0x488);
		
		/// <summary>
		/// Name: SK_human_female_underwear
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_underwear => ReadUObject<USkeletalMeshComponent>(0x490);
		
		/// <summary>
		/// Name: SK_human_female_legs
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_female_legs => ReadUObject<USkeletalMeshComponent>(0x498);
		
	}


	/// <summary>
	/// ABP_Cinematic_Ghost_Male_C:ASkeletalMeshActor
	/// Size: 0x4A0
	/// Properties: 9
	/// </summary>
	public class ABP_Cinematic_Ghost_Male_C:ASkeletalMeshActor
	{
		public override int ObjectSize => 1184;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x458);
		
		/// <summary>
		/// Name: SK_human_male_hair_04
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_hair_04 => ReadUObject<USkeletalMeshComponent>(0x460);
		
		/// <summary>
		/// Name: SK_human_male_head
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_head => ReadUObject<USkeletalMeshComponent>(0x468);
		
		/// <summary>
		/// Name: SK_human_male_hands
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_hands => ReadUObject<USkeletalMeshComponent>(0x470);
		
		/// <summary>
		/// Name: SK_human_male_forearms
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_forearms => ReadUObject<USkeletalMeshComponent>(0x478);
		
		/// <summary>
		/// Name: SK_human_male_upperbody
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_upperbody => ReadUObject<USkeletalMeshComponent>(0x480);
		
		/// <summary>
		/// Name: SK_human_male_underwear
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_underwear => ReadUObject<USkeletalMeshComponent>(0x488);
		
		/// <summary>
		/// Name: SK_human_male_legs
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_legs => ReadUObject<USkeletalMeshComponent>(0x490);
		
		/// <summary>
		/// Name: SK_human_male_feet
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SK_human_male_feet => ReadUObject<USkeletalMeshComponent>(0x498);
		
	}


}

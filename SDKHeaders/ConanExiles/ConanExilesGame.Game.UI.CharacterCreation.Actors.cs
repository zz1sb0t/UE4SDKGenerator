using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.CharacterCreation.Actors
{
	/// <summary>
	/// UAB_CharacterCreation_C:UAnimInstance
	/// Size: 0x322E
	/// Properties: 93
	/// </summary>
	public class UAB_CharacterCreation_C:UAnimInstance
	{
		public override int ObjectSize => 12846;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_296B6A3240CC22B82BE302A85B155509
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_296B6A3240CC22B82BE302A85B155509 => ReadStruct<FAnimNode_Root>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_FA93AE894E237B32F650CDB8D48B78B7
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_FA93AE894E237B32F650CDB8D48B78B7 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x4D0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_55D8DB37405F6908296F2F92FC227958
		/// Type: StructProperty
		/// Offset: 0x518
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_55D8DB37405F6908296F2F92FC227958 => ReadStruct<FAnimNode_ModifyBone>(0x518);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_DC21D21A4834AFA90ACDEF8D0D4599F8
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_DC21D21A4834AFA90ACDEF8D0D4599F8 => ReadStruct<FAnimNode_ModifyBone>(0x5C8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_5CCA952D4A405D1058B835B3A071BBA0
		/// Type: StructProperty
		/// Offset: 0x678
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_5CCA952D4A405D1058B835B3A071BBA0 => ReadStruct<FAnimNode_ModifyBone>(0x678);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_6C692B7D4073387D02890E8C0E8C7329
		/// Type: StructProperty
		/// Offset: 0x728
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_6C692B7D4073387D02890E8C0E8C7329 => ReadStruct<FAnimNode_ModifyBone>(0x728);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_95880FF247FD87D3A24F6D941229A0AF
		/// Type: StructProperty
		/// Offset: 0x7D8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_95880FF247FD87D3A24F6D941229A0AF => ReadStruct<FAnimNode_ModifyBone>(0x7D8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_536A295C41AF2243008BFAB5205EA1E6
		/// Type: StructProperty
		/// Offset: 0x888
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_536A295C41AF2243008BFAB5205EA1E6 => ReadStruct<FAnimNode_ModifyBone>(0x888);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_461DDFFF43F1AF0C58005091D5A7DE53
		/// Type: StructProperty
		/// Offset: 0x938
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_461DDFFF43F1AF0C58005091D5A7DE53 => ReadStruct<FAnimNode_ModifyBone>(0x938);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_477F9184467F1D02286E8D8456EECA37
		/// Type: StructProperty
		/// Offset: 0x9E8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_477F9184467F1D02286E8D8456EECA37 => ReadStruct<FAnimNode_ModifyBone>(0x9E8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E34167354B38DA3F5A23E0B5335651FF
		/// Type: StructProperty
		/// Offset: 0xA98
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E34167354B38DA3F5A23E0B5335651FF => ReadStruct<FAnimNode_ModifyBone>(0xA98);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_520F40534979C102A545FB889B495329
		/// Type: StructProperty
		/// Offset: 0xB48
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_520F40534979C102A545FB889B495329 => ReadStruct<FAnimNode_ModifyBone>(0xB48);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_FC0CCB774C62348139759DBF5373A142
		/// Type: StructProperty
		/// Offset: 0xBF8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_FC0CCB774C62348139759DBF5373A142 => ReadStruct<FAnimNode_ModifyBone>(0xBF8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_17D7378D4C1BA5969FB98AB4922138E9
		/// Type: StructProperty
		/// Offset: 0xCA8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_17D7378D4C1BA5969FB98AB4922138E9 => ReadStruct<FAnimNode_ModifyBone>(0xCA8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E002991646C3D7ABCD9FB4AFCC3514A8
		/// Type: StructProperty
		/// Offset: 0xD58
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E002991646C3D7ABCD9FB4AFCC3514A8 => ReadStruct<FAnimNode_ModifyBone>(0xD58);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_791629DC46290124F12F7581212E5F8B
		/// Type: StructProperty
		/// Offset: 0xE08
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_791629DC46290124F12F7581212E5F8B => ReadStruct<FAnimNode_RotationMultiplier>(0xE08);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_DFAFC84F493FA07B9E707BBA7385F7EB
		/// Type: StructProperty
		/// Offset: 0xEA0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_DFAFC84F493FA07B9E707BBA7385F7EB => ReadStruct<FAnimNode_RotationMultiplier>(0xEA0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_C7B7C9854B0B20A71E4302BDB6303915
		/// Type: StructProperty
		/// Offset: 0xF38
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_C7B7C9854B0B20A71E4302BDB6303915 => ReadStruct<FAnimNode_RotationMultiplier>(0xF38);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_27C431E44092FB0F307EAD96DF34FC8C
		/// Type: StructProperty
		/// Offset: 0xFD0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_27C431E44092FB0F307EAD96DF34FC8C => ReadStruct<FAnimNode_RotationMultiplier>(0xFD0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_CF65A7C840B3ADA551D83D9419E46ABA
		/// Type: StructProperty
		/// Offset: 0x1068
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_CF65A7C840B3ADA551D83D9419E46ABA => ReadStruct<FAnimNode_RotationMultiplier>(0x1068);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_97BE92A2408B35C1D68106980199ED64
		/// Type: StructProperty
		/// Offset: 0x1100
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_97BE92A2408B35C1D68106980199ED64 => ReadStruct<FAnimNode_RotationMultiplier>(0x1100);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_B618F0DC49ABD2384356AF990FC248A2
		/// Type: StructProperty
		/// Offset: 0x1198
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_B618F0DC49ABD2384356AF990FC248A2 => ReadStruct<FAnimNode_RotationMultiplier>(0x1198);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_43E3106244E6237819C9EE95AA0AE4E8
		/// Type: StructProperty
		/// Offset: 0x1230
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_43E3106244E6237819C9EE95AA0AE4E8 => ReadStruct<FAnimNode_RotationMultiplier>(0x1230);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_6ACBE13941A170FD3034F58AFD70F9F5
		/// Type: StructProperty
		/// Offset: 0x12C8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_6ACBE13941A170FD3034F58AFD70F9F5 => ReadStruct<FAnimNode_RotationMultiplier>(0x12C8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_2C0477D64A203465F862DDBBC0F0894F
		/// Type: StructProperty
		/// Offset: 0x1360
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_2C0477D64A203465F862DDBBC0F0894F => ReadStruct<FAnimNode_RotationMultiplier>(0x1360);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_6F85FA494F059E0D76D91CA6B76253D8
		/// Type: StructProperty
		/// Offset: 0x13F8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_6F85FA494F059E0D76D91CA6B76253D8 => ReadStruct<FAnimNode_RotationMultiplier>(0x13F8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_E2576D904360444D8457659F87F4494D
		/// Type: StructProperty
		/// Offset: 0x1490
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_E2576D904360444D8457659F87F4494D => ReadStruct<FAnimNode_RotationMultiplier>(0x1490);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_6F13A5324361CD4E81AF2694C1D65BB4
		/// Type: StructProperty
		/// Offset: 0x1528
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_6F13A5324361CD4E81AF2694C1D65BB4 => ReadStruct<FAnimNode_RotationMultiplier>(0x1528);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_098B65574380D238C6AF96A88C783D5C
		/// Type: StructProperty
		/// Offset: 0x15C0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_098B65574380D238C6AF96A88C783D5C => ReadStruct<FAnimNode_RotationMultiplier>(0x15C0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_C3CA4E3C475BC60310ED419DBEB35A2C
		/// Type: StructProperty
		/// Offset: 0x1658
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_C3CA4E3C475BC60310ED419DBEB35A2C => ReadStruct<FAnimNode_RotationMultiplier>(0x1658);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_F8D4EC02458BD62DC41E4FB818793619
		/// Type: StructProperty
		/// Offset: 0x16F0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_F8D4EC02458BD62DC41E4FB818793619 => ReadStruct<FAnimNode_RotationMultiplier>(0x16F0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_3C2EBAF949E08D92A9BA8DBFD4505766
		/// Type: StructProperty
		/// Offset: 0x1788
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_3C2EBAF949E08D92A9BA8DBFD4505766 => ReadStruct<FAnimNode_RotationMultiplier>(0x1788);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_3DD12C2E40B49A3E1946D296821F2AB3
		/// Type: StructProperty
		/// Offset: 0x1820
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_3DD12C2E40B49A3E1946D296821F2AB3 => ReadStruct<FAnimNode_RotationMultiplier>(0x1820);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_F98E84254996429BC913148B69114DA5
		/// Type: StructProperty
		/// Offset: 0x18B8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_F98E84254996429BC913148B69114DA5 => ReadStruct<FAnimNode_RotationMultiplier>(0x18B8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_5C3352B649F4BA3F01C389BFC610571C
		/// Type: StructProperty
		/// Offset: 0x1950
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_5C3352B649F4BA3F01C389BFC610571C => ReadStruct<FAnimNode_RotationMultiplier>(0x1950);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_7F8332C14F28781F41F4BF84020BEF75
		/// Type: StructProperty
		/// Offset: 0x19E8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_7F8332C14F28781F41F4BF84020BEF75 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x19E8);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_22785B5344A8F4E6A43855AB790F74B6
		/// Type: StructProperty
		/// Offset: 0x1A30
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_22785B5344A8F4E6A43855AB790F74B6 => ReadStruct<FAnimNode_AnimDynamics>(0x1A30);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_18D3D8B445C844E461F43D9FC9B8C3C0
		/// Type: StructProperty
		/// Offset: 0x1C50
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_18D3D8B445C844E461F43D9FC9B8C3C0 => ReadStruct<FAnimNode_AnimDynamics>(0x1C50);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_E19B39954C784E342C2CC7817D895D65
		/// Type: StructProperty
		/// Offset: 0x1E70
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_E19B39954C784E342C2CC7817D895D65 => ReadStruct<FAnimNode_AnimDynamics>(0x1E70);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_36D9E56A48B1F1ECE81423B5F91358C8
		/// Type: StructProperty
		/// Offset: 0x2090
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_36D9E56A48B1F1ECE81423B5F91358C8 => ReadStruct<FAnimNode_AnimDynamics>(0x2090);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_441EC8C94ECC6D15604DD7A33DC3E67F
		/// Type: StructProperty
		/// Offset: 0x22B0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_441EC8C94ECC6D15604DD7A33DC3E67F => ReadStruct<FAnimNode_ModifyBone>(0x22B0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_F51F1E854F19D9ADE61B8ABA519A23CC
		/// Type: StructProperty
		/// Offset: 0x2360
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_F51F1E854F19D9ADE61B8ABA519A23CC => ReadStruct<FAnimNode_ModifyBone>(0x2360);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E9CA7E4148F3E1B6BA5472AA69DDCC57
		/// Type: StructProperty
		/// Offset: 0x2410
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E9CA7E4148F3E1B6BA5472AA69DDCC57 => ReadStruct<FAnimNode_ModifyBone>(0x2410);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_79DD505548629B25326B4FBBFE8538E2
		/// Type: StructProperty
		/// Offset: 0x24C0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_79DD505548629B25326B4FBBFE8538E2 => ReadStruct<FAnimNode_ModifyBone>(0x24C0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByInt_262031534E6BEDED24C980AEAF966009
		/// Type: StructProperty
		/// Offset: 0x2570
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByInt AnimGraphNode_BlendListByInt_262031534E6BEDED24C980AEAF966009 => ReadStruct<FAnimNode_BlendListByInt>(0x2570);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_D4A551F3425D4FE1A2A14E92FDAFBFF5
		/// Type: StructProperty
		/// Offset: 0x2640
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_D4A551F3425D4FE1A2A14E92FDAFBFF5 => ReadStruct<FAnimNode_SequencePlayer>(0x2640);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_EEF7E1C74C94C8CC79AFD5A2006E4F51
		/// Type: StructProperty
		/// Offset: 0x26B0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_EEF7E1C74C94C8CC79AFD5A2006E4F51 => ReadStruct<FAnimNode_ModifyBone>(0x26B0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_2B3E21D84506E15AAA1831A614AB7C36
		/// Type: StructProperty
		/// Offset: 0x2760
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_2B3E21D84506E15AAA1831A614AB7C36 => ReadStruct<FAnimNode_ModifyBone>(0x2760);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_B3E607CB4E2D2CCBFDC8999326AA0383
		/// Type: StructProperty
		/// Offset: 0x2810
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_B3E607CB4E2D2CCBFDC8999326AA0383 => ReadStruct<FAnimNode_ModifyBone>(0x2810);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_CF4366AD48A13F4CFAB597B78CBCE41E
		/// Type: StructProperty
		/// Offset: 0x28C0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_CF4366AD48A13F4CFAB597B78CBCE41E => ReadStruct<FAnimNode_SequencePlayer>(0x28C0);
		
		/// <summary>
		/// Name: AnimGraphNode_IdentityPose_0ADE41CD45280BA9D703BAB42192932E
		/// Type: StructProperty
		/// Offset: 0x2930
		/// Size: 0x38
		/// </summary>
		public FAnimNode_RefPose AnimGraphNode_IdentityPose_0ADE41CD45280BA9D703BAB42192932E => ReadStruct<FAnimNode_RefPose>(0x2930);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_A809D26740368FBB9CB22D8AB541E68C
		/// Type: StructProperty
		/// Offset: 0x2968
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_A809D26740368FBB9CB22D8AB541E68C => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x2968);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_3C00E6264BED807FDF1015B0A8A487BD
		/// Type: StructProperty
		/// Offset: 0x29B0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_3C00E6264BED807FDF1015B0A8A487BD => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x29B0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_B961E8794F5C01CF9DEC73B5BB3E9742
		/// Type: StructProperty
		/// Offset: 0x29F8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_B961E8794F5C01CF9DEC73B5BB3E9742 => ReadStruct<FAnimNode_BlendListByBool>(0x29F8);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_F303B74A447919DD33C79CA2F5D9E938
		/// Type: StructProperty
		/// Offset: 0x2AC8
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_F303B74A447919DD33C79CA2F5D9E938 => ReadStruct<FAnimNode_SaveCachedPose>(0x2AC8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_AA743BBD45350FBF91ADF0A0123E1363
		/// Type: StructProperty
		/// Offset: 0x2B58
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_AA743BBD45350FBF91ADF0A0123E1363 => ReadStruct<FAnimNode_UseCachedPose>(0x2B58);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_3969644644EED4FED427149BA4537BB2
		/// Type: StructProperty
		/// Offset: 0x2BA0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_3969644644EED4FED427149BA4537BB2 => ReadStruct<FAnimNode_UseCachedPose>(0x2BA0);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_6027672D4D47BE1D10155F9CF3066620
		/// Type: StructProperty
		/// Offset: 0x2BE8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_6027672D4D47BE1D10155F9CF3066620 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x2BE8);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyAdditive_D43D72C34ADC9F30973DC7A751C49951
		/// Type: StructProperty
		/// Offset: 0x2C30
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyAdditive AnimGraphNode_ApplyAdditive_D43D72C34ADC9F30973DC7A751C49951 => ReadStruct<FAnimNode_ApplyAdditive>(0x2C30);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_3D3DBF6E49E461BF208AD48B1827F60F
		/// Type: StructProperty
		/// Offset: 0x2CA8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_3D3DBF6E49E461BF208AD48B1827F60F => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x2CA8);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_69C0518B47EBAA69008DD29A04BB387A
		/// Type: StructProperty
		/// Offset: 0x2CF0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_69C0518B47EBAA69008DD29A04BB387A => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x2CF0);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_EB62E476449AFF3894AA8C9F3A4B591E
		/// Type: StructProperty
		/// Offset: 0x2D38
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_EB62E476449AFF3894AA8C9F3A4B591E => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x2D38);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_12CD84884113360B7F2F06B519455FB2
		/// Type: StructProperty
		/// Offset: 0x2D80
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_12CD84884113360B7F2F06B519455FB2 => ReadStruct<FAnimNode_SequencePlayer>(0x2D80);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_1088809F48DBA9F29041FA81F855E963
		/// Type: StructProperty
		/// Offset: 0x2DF0
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_1088809F48DBA9F29041FA81F855E963 => ReadStruct<FAnimNode_BlendListByBool>(0x2DF0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_BACA0DF04ED193B64E0E1CA276C4AB40
		/// Type: StructProperty
		/// Offset: 0x2EC0
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_BACA0DF04ED193B64E0E1CA276C4AB40 => ReadStruct<FAnimNode_BlendListByBool>(0x2EC0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_39AABE2A4258FBD9186D3282A7CCB2BB
		/// Type: StructProperty
		/// Offset: 0x2F90
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_39AABE2A4258FBD9186D3282A7CCB2BB => ReadStruct<FAnimNode_SequencePlayer>(0x2F90);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_886F296B4B115D2CF1ED329B51DD8B8D
		/// Type: StructProperty
		/// Offset: 0x3000
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_886F296B4B115D2CF1ED329B51DD8B8D => ReadStruct<FAnimNode_SequencePlayer>(0x3000);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E7DC56EE437FA36390A6EE9ADB27B97E
		/// Type: StructProperty
		/// Offset: 0x3070
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E7DC56EE437FA36390A6EE9ADB27B97E => ReadStruct<FAnimNode_ModifyBone>(0x3070);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_11C140D34F8DC0636995A6BF706A2113
		/// Type: StructProperty
		/// Offset: 0x3120
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_11C140D34F8DC0636995A6BF706A2113 => ReadStruct<FAnimNode_ModifyBone>(0x3120);
		
		/// <summary>
		/// Name: Height
		/// Type: FloatProperty
		/// Offset: 0x31D0
		/// Size: 0x04
		/// </summary>
		public float Height
		{
			get
			{
				return ReadSingle(0x31D0);
			}
			set
			{
				WriteSingle(0x31D0,value);
			}
		}
		
		/// <summary>
		/// Name: eye_horizontalpos
		/// Type: FloatProperty
		/// Offset: 0x31D4
		/// Size: 0x04
		/// </summary>
		public float eye_horizontalpos
		{
			get
			{
				return ReadSingle(0x31D4);
			}
			set
			{
				WriteSingle(0x31D4,value);
			}
		}
		
		/// <summary>
		/// Name: eye_size
		/// Type: FloatProperty
		/// Offset: 0x31D8
		/// Size: 0x04
		/// </summary>
		public float eye_size
		{
			get
			{
				return ReadSingle(0x31D8);
			}
			set
			{
				WriteSingle(0x31D8,value);
			}
		}
		
		/// <summary>
		/// Name: eye_angle
		/// Type: FloatProperty
		/// Offset: 0x31DC
		/// Size: 0x04
		/// </summary>
		public float eye_angle
		{
			get
			{
				return ReadSingle(0x31DC);
			}
			set
			{
				WriteSingle(0x31DC,value);
			}
		}
		
		/// <summary>
		/// Name: nose_width
		/// Type: FloatProperty
		/// Offset: 0x31E0
		/// Size: 0x04
		/// </summary>
		public float nose_width
		{
			get
			{
				return ReadSingle(0x31E0);
			}
			set
			{
				WriteSingle(0x31E0,value);
			}
		}
		
		/// <summary>
		/// Name: jaw_width
		/// Type: FloatProperty
		/// Offset: 0x31E4
		/// Size: 0x04
		/// </summary>
		public float jaw_width
		{
			get
			{
				return ReadSingle(0x31E4);
			}
			set
			{
				WriteSingle(0x31E4,value);
			}
		}
		
		/// <summary>
		/// Name: nosetip_curve
		/// Type: FloatProperty
		/// Offset: 0x31E8
		/// Size: 0x04
		/// </summary>
		public float nosetip_curve
		{
			get
			{
				return ReadSingle(0x31E8);
			}
			set
			{
				WriteSingle(0x31E8,value);
			}
		}
		
		/// <summary>
		/// Name: nosetip_size
		/// Type: FloatProperty
		/// Offset: 0x31EC
		/// Size: 0x04
		/// </summary>
		public float nosetip_size
		{
			get
			{
				return ReadSingle(0x31EC);
			}
			set
			{
				WriteSingle(0x31EC,value);
			}
		}
		
		/// <summary>
		/// Name: chin_width
		/// Type: FloatProperty
		/// Offset: 0x31F0
		/// Size: 0x04
		/// </summary>
		public float chin_width
		{
			get
			{
				return ReadSingle(0x31F0);
			}
			set
			{
				WriteSingle(0x31F0,value);
			}
		}
		
		/// <summary>
		/// Name: cheek_height
		/// Type: FloatProperty
		/// Offset: 0x31F4
		/// Size: 0x04
		/// </summary>
		public float cheek_height
		{
			get
			{
				return ReadSingle(0x31F4);
			}
			set
			{
				WriteSingle(0x31F4,value);
			}
		}
		
		/// <summary>
		/// Name: cheek_width
		/// Type: FloatProperty
		/// Offset: 0x31F8
		/// Size: 0x04
		/// </summary>
		public float cheek_width
		{
			get
			{
				return ReadSingle(0x31F8);
			}
			set
			{
				WriteSingle(0x31F8,value);
			}
		}
		
		/// <summary>
		/// Name: ear_angle
		/// Type: FloatProperty
		/// Offset: 0x31FC
		/// Size: 0x04
		/// </summary>
		public float ear_angle
		{
			get
			{
				return ReadSingle(0x31FC);
			}
			set
			{
				WriteSingle(0x31FC,value);
			}
		}
		
		/// <summary>
		/// Name: ear_size
		/// Type: FloatProperty
		/// Offset: 0x3200
		/// Size: 0x04
		/// </summary>
		public float ear_size
		{
			get
			{
				return ReadSingle(0x3200);
			}
			set
			{
				WriteSingle(0x3200,value);
			}
		}
		
		/// <summary>
		/// Name: realign_jaw
		/// Type: FloatProperty
		/// Offset: 0x3204
		/// Size: 0x04
		/// </summary>
		public float realign_jaw
		{
			get
			{
				return ReadSingle(0x3204);
			}
			set
			{
				WriteSingle(0x3204,value);
			}
		}
		
		/// <summary>
		/// Name: penis_scale
		/// Type: FloatProperty
		/// Offset: 0x3208
		/// Size: 0x04
		/// </summary>
		public float penis_scale
		{
			get
			{
				return ReadSingle(0x3208);
			}
			set
			{
				WriteSingle(0x3208,value);
			}
		}
		
		/// <summary>
		/// Name: boob_scale
		/// Type: FloatProperty
		/// Offset: 0x320C
		/// Size: 0x04
		/// </summary>
		public float boob_scale
		{
			get
			{
				return ReadSingle(0x320C);
			}
			set
			{
				WriteSingle(0x320C,value);
			}
		}
		
		/// <summary>
		/// Name: boob_physics_alpha
		/// Type: FloatProperty
		/// Offset: 0x3210
		/// Size: 0x04
		/// </summary>
		public float boob_physics_alpha
		{
			get
			{
				return ReadSingle(0x3210);
			}
			set
			{
				WriteSingle(0x3210,value);
			}
		}
		
		/// <summary>
		/// Name: UpdateCustomization
		/// Type: BoolProperty
		/// Offset: 0x3214
		/// Size: 0x01
		/// </summary>
		public bool UpdateCustomization
		{
			get
			{
				return ReadBool(0x3214);
			}
			set
			{
				WriteBool(0x3214,value);
			}
		}
		
		/// <summary>
		/// Name: HeadRotation
		/// Type: StructProperty
		/// Offset: 0x3218
		/// Size: 0x0C
		/// </summary>
		public FRotator HeadRotation => ReadStruct<FRotator>(0x3218);
		
		/// <summary>
		/// Name: Animation
		/// Type: IntProperty
		/// Offset: 0x3224
		/// Size: 0x04
		/// </summary>
		public int Animation
		{
			get
			{
				return ReadInt32(0x3224);
			}
			set
			{
				WriteInt32(0x3224,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterLayoutHash
		/// Type: IntProperty
		/// Offset: 0x3228
		/// Size: 0x04
		/// </summary>
		public int CharacterLayoutHash
		{
			get
			{
				return ReadInt32(0x3228);
			}
			set
			{
				WriteInt32(0x3228,value);
			}
		}
		
		/// <summary>
		/// Name: IsFemale
		/// Type: BoolProperty
		/// Offset: 0x322C
		/// Size: 0x01
		/// </summary>
		public bool IsFemale
		{
			get
			{
				return ReadBool(0x322C);
			}
			set
			{
				WriteBool(0x322C,value);
			}
		}
		
		/// <summary>
		/// Name: InCharacterCreation
		/// Type: BoolProperty
		/// Offset: 0x322D
		/// Size: 0x01
		/// </summary>
		public bool InCharacterCreation
		{
			get
			{
				return ReadBool(0x322D);
			}
			set
			{
				WriteBool(0x322D,value);
			}
		}
		
	}


}

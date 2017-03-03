using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Game.Items.Weapons;
using ConanExilesGame.Game.Items;
using ConanExilesGame.Game.Systems.Building;
using ConanExilesGame.Game.Master_AnimBP;


namespace ConanExilesGame.Game.Master_AnimBP
{
	/// <summary>
	/// Uab_human_male_interface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class Uab_human_male_interface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_HasBinaryStatesInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_HasBinaryStatesInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAB_basic_container_C:UAnimInstance
	/// Size: 0x745
	/// Properties: 10
	/// </summary>
	public class UAB_basic_container_C:UAnimInstance
	{
		public override int ObjectSize => 1861;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_2BD495984379C1D998E8388CDFD5A01F
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_2BD495984379C1D998E8388CDFD5A01F => ReadStruct<FAnimNode_Root>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_0017575E401117948684A297FC561A0B
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_0017575E401117948684A297FC561A0B => ReadStruct<FAnimNode_BlendListByBool>(0x4D0);
		
		/// <summary>
		/// Name: AnimGraphNode_MeshRefPose_C6FB06E34A72C145EDFF47A3ABB237A2
		/// Type: StructProperty
		/// Offset: 0x5A0
		/// Size: 0x30
		/// </summary>
		public FAnimNode_MeshSpaceRefPose AnimGraphNode_MeshRefPose_C6FB06E34A72C145EDFF47A3ABB237A2 => ReadStruct<FAnimNode_MeshSpaceRefPose>(0x5A0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_43ECE2264D0642F68534E9B8E9BBA3D2
		/// Type: StructProperty
		/// Offset: 0x5D0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_43ECE2264D0642F68534E9B8E9BBA3D2 => ReadStruct<FAnimNode_ModifyBone>(0x5D0);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_C1B29EAA4EA4B6D0C1E793AD425FAABE
		/// Type: StructProperty
		/// Offset: 0x680
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_C1B29EAA4EA4B6D0C1E793AD425FAABE => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x680);
		
		/// <summary>
		/// Name: AnimGraphNode_MeshRefPose_3499660A41FA69C4CC375486E16A7E96
		/// Type: StructProperty
		/// Offset: 0x6C8
		/// Size: 0x30
		/// </summary>
		public FAnimNode_MeshSpaceRefPose AnimGraphNode_MeshRefPose_3499660A41FA69C4CC375486E16A7E96 => ReadStruct<FAnimNode_MeshSpaceRefPose>(0x6C8);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_615EDE184DDA7DB86F4EE5AD7927B123
		/// Type: StructProperty
		/// Offset: 0x6F8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_615EDE184DDA7DB86F4EE5AD7927B123 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x6F8);
		
		/// <summary>
		/// Name: opening
		/// Type: FloatProperty
		/// Offset: 0x740
		/// Size: 0x04
		/// </summary>
		public float opening
		{
			get
			{
				return ReadSingle(0x740);
			}
			set
			{
				WriteSingle(0x740,value);
			}
		}
		
		/// <summary>
		/// Name: OpenState
		/// Type: BoolProperty
		/// Offset: 0x744
		/// Size: 0x01
		/// </summary>
		public bool OpenState
		{
			get
			{
				return ReadBool(0x744);
			}
			set
			{
				WriteBool(0x744,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_HasLookAtTargetInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_HasLookAtTargetInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAB_human_male_C:UAnimInstance
	/// Size: 0xAFC0
	/// Properties: 433
	/// </summary>
	public class UAB_human_male_C:UAnimInstance
	{
		public override int ObjectSize => 44992;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_92AFA66448BE7764A57BEC8C9E0F90E9
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_92AFA66448BE7764A57BEC8C9E0F90E9 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_3B17CF4E41B80230DDD4C986DD73F89B
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_3B17CF4E41B80230DDD4C986DD73F89B => ReadStruct<FAnimNode_ModifyBone>(0x4D0);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_B655C83541EF7A18CF298DB2847F6F26
		/// Type: StructProperty
		/// Offset: 0x580
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_B655C83541EF7A18CF298DB2847F6F26 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x580);
		
		/// <summary>
		/// Name: AnimGraphNode_IdentityPose_77943DC4486F8D5C6ECCA8825CE183E3
		/// Type: StructProperty
		/// Offset: 0x5C8
		/// Size: 0x38
		/// </summary>
		public FAnimNode_RefPose AnimGraphNode_IdentityPose_77943DC4486F8D5C6ECCA8825CE183E3 => ReadStruct<FAnimNode_RefPose>(0x5C8);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_CD941A584A2CFF1DC49015971DE8F453
		/// Type: StructProperty
		/// Offset: 0x600
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_CD941A584A2CFF1DC49015971DE8F453 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x600);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_13C9B9694EDA65CEA60B9C9B03159236
		/// Type: StructProperty
		/// Offset: 0x648
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_13C9B9694EDA65CEA60B9C9B03159236 => ReadStruct<FAnimNode_ModifyBone>(0x648);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_8F39FCB34F7799A079CDF78328BD20F2
		/// Type: StructProperty
		/// Offset: 0x6F8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_8F39FCB34F7799A079CDF78328BD20F2 => ReadStruct<FAnimNode_ModifyBone>(0x6F8);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_E18CFE8C43F55ADF6EB466980F7D37E2
		/// Type: StructProperty
		/// Offset: 0x7A8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_E18CFE8C43F55ADF6EB466980F7D37E2 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x7A8);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_DFB3240A424AB5E6C68ECC810612580F
		/// Type: StructProperty
		/// Offset: 0x7F0
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_DFB3240A424AB5E6C68ECC810612580F => ReadStruct<FAnimNode_SaveCachedPose>(0x7F0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_758C5D9C4FF9E18A762B4495530709BA
		/// Type: StructProperty
		/// Offset: 0x880
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_758C5D9C4FF9E18A762B4495530709BA => ReadStruct<FAnimNode_BlendListByBool>(0x880);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_ADCD79EE4F2B3DACFEF9949443304B11
		/// Type: StructProperty
		/// Offset: 0x950
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_ADCD79EE4F2B3DACFEF9949443304B11 => ReadStruct<FAnimNode_RotationMultiplier>(0x950);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_FFFCB0054FEE58158B2B7EA4FCA1C744
		/// Type: StructProperty
		/// Offset: 0x9E8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_FFFCB0054FEE58158B2B7EA4FCA1C744 => ReadStruct<FAnimNode_RotationMultiplier>(0x9E8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_F9EA57BB4AED10A5BA15A3AF575DEF48
		/// Type: StructProperty
		/// Offset: 0xA80
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_F9EA57BB4AED10A5BA15A3AF575DEF48 => ReadStruct<FAnimNode_RotationMultiplier>(0xA80);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_DAFE60CB450670A5EE3C5A952AFA1C56
		/// Type: StructProperty
		/// Offset: 0xB18
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_DAFE60CB450670A5EE3C5A952AFA1C56 => ReadStruct<FAnimNode_RotationMultiplier>(0xB18);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_FBFD531D45B3C4DAEC8A6983E2ACEE97
		/// Type: StructProperty
		/// Offset: 0xBB0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_FBFD531D45B3C4DAEC8A6983E2ACEE97 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0xBB0);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_5D85428941B50C6DB0317EBBA3A48355
		/// Type: StructProperty
		/// Offset: 0xBF8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_5D85428941B50C6DB0317EBBA3A48355 => ReadStruct<FAnimNode_LayeredBoneBlend>(0xBF8);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_EB37239E47372E14B6DD1CAA85AECE99
		/// Type: StructProperty
		/// Offset: 0xC98
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_EB37239E47372E14B6DD1CAA85AECE99 => ReadStruct<FAnimNode_SaveCachedPose>(0xC98);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_4977918D427D06ED01ECDC9837BE6FDF
		/// Type: StructProperty
		/// Offset: 0xD28
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_4977918D427D06ED01ECDC9837BE6FDF => ReadStruct<FAnimNode_UseCachedPose>(0xD28);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_7B0954D6443104F090D32A8C5EEE92B1
		/// Type: StructProperty
		/// Offset: 0xD70
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_7B0954D6443104F090D32A8C5EEE92B1 => ReadStruct<FAnimNode_UseCachedPose>(0xD70);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_8303AC2D4962B7AD33B4CB8ECA0E10F0
		/// Type: StructProperty
		/// Offset: 0xDB8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_8303AC2D4962B7AD33B4CB8ECA0E10F0 => ReadStruct<FAnimNode_UseCachedPose>(0xDB8);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_8869B57D42E18AF42C6151B06658D7A6
		/// Type: StructProperty
		/// Offset: 0xE00
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_8869B57D42E18AF42C6151B06658D7A6 => ReadStruct<FAnimNode_Slot>(0xE00);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_5106DA6A46A8F77EE6C366AC3030D1B2
		/// Type: StructProperty
		/// Offset: 0xE60
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_5106DA6A46A8F77EE6C366AC3030D1B2 => ReadStruct<FAnimNode_Slot>(0xE60);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_BB7BCCE349CECB93368E0AB67D1E4061
		/// Type: StructProperty
		/// Offset: 0xEC0
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_BB7BCCE349CECB93368E0AB67D1E4061 => ReadStruct<FAnimNode_SaveCachedPose>(0xEC0);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_1625832F4AFF4C54C3403EA9E829B6FD
		/// Type: StructProperty
		/// Offset: 0xF50
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_1625832F4AFF4C54C3403EA9E829B6FD => ReadStruct<FAnimNode_UseCachedPose>(0xF50);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_623BFBD44ACE661FEA04EABD7A171556
		/// Type: StructProperty
		/// Offset: 0xF98
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_623BFBD44ACE661FEA04EABD7A171556 => ReadStruct<FAnimNode_UseCachedPose>(0xF98);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_D95946DF4F99B80897AA65849F5DA5B0
		/// Type: StructProperty
		/// Offset: 0xFE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_D95946DF4F99B80897AA65849F5DA5B0 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0xFE0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_3ADC63984D2B71495B1C1FA59F42748D
		/// Type: StructProperty
		/// Offset: 0x1028
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_3ADC63984D2B71495B1C1FA59F42748D => ReadStruct<FAnimNode_ModifyBone>(0x1028);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_F5C3E5FF430A0F8CCF5E4F806534B9D8
		/// Type: StructProperty
		/// Offset: 0x10D8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_F5C3E5FF430A0F8CCF5E4F806534B9D8 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x10D8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_F47E363F4C22B53739552D958663A082
		/// Type: StructProperty
		/// Offset: 0x1120
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_F47E363F4C22B53739552D958663A082 => ReadStruct<FAnimNode_ModifyBone>(0x1120);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_9C307E3D44C440B233D0D19209C768E3
		/// Type: StructProperty
		/// Offset: 0x11D0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_9C307E3D44C440B233D0D19209C768E3 => ReadStruct<FAnimNode_ModifyBone>(0x11D0);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_A6CA16F34B1344FF7C38A1A9D09684C1
		/// Type: StructProperty
		/// Offset: 0x1280
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_A6CA16F34B1344FF7C38A1A9D09684C1 => ReadStruct<FAnimNode_UseCachedPose>(0x1280);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_FF8AB34E497F4377DA33CA8E8181F634
		/// Type: StructProperty
		/// Offset: 0x12C8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_FF8AB34E497F4377DA33CA8E8181F634 => ReadStruct<FAnimNode_BlendListByBool>(0x12C8);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_359D3317462046DEF6D5A099396D4D5D
		/// Type: StructProperty
		/// Offset: 0x1398
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_359D3317462046DEF6D5A099396D4D5D => ReadStruct<FAnimNode_LayeredBoneBlend>(0x1398);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_4151FE8847E52C5302DAED85EDEFD30C
		/// Type: StructProperty
		/// Offset: 0x1438
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_4151FE8847E52C5302DAED85EDEFD30C => ReadStruct<FAnimNode_SaveCachedPose>(0x1438);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_9E4E751348CE723E12A28FAE9590CE3B
		/// Type: StructProperty
		/// Offset: 0x14C8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_9E4E751348CE723E12A28FAE9590CE3B => ReadStruct<FAnimNode_BlendListByBool>(0x14C8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_A87F776242D9440E60707FB6D3AC46B5
		/// Type: StructProperty
		/// Offset: 0x1598
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_A87F776242D9440E60707FB6D3AC46B5 => ReadStruct<FAnimNode_BlendListByBool>(0x1598);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_D4A12E9040D88C80517B889451722F45
		/// Type: StructProperty
		/// Offset: 0x1668
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_D4A12E9040D88C80517B889451722F45 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x1668);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_597C0C064B4CCF6374BFF8A285F39D5A
		/// Type: StructProperty
		/// Offset: 0x1708
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_597C0C064B4CCF6374BFF8A285F39D5A => ReadStruct<FAnimNode_BlendSpacePlayer>(0x1708);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_560B1E7D40B7E657034E5C8F1F173F20
		/// Type: StructProperty
		/// Offset: 0x1838
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_560B1E7D40B7E657034E5C8F1F173F20 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x1838);
		
		/// <summary>
		/// Name: AnimGraphNode_BoneDrivenController_AFBE0DD443EBDC7610D02097C44CCDFD
		/// Type: StructProperty
		/// Offset: 0x1880
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_BoneDrivenController AnimGraphNode_BoneDrivenController_AFBE0DD443EBDC7610D02097C44CCDFD => ReadStruct<FAnimNode_BoneDrivenController>(0x1880);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_E642186B42518F512138DD86ADF82D5B
		/// Type: StructProperty
		/// Offset: 0x1958
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_E642186B42518F512138DD86ADF82D5B => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x1958);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_56A4622D42514538297CC0B928E5D70D
		/// Type: StructProperty
		/// Offset: 0x19A0
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_56A4622D42514538297CC0B928E5D70D => ReadStruct<FAnimNode_LayeredBoneBlend>(0x19A0);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_36C731BA4FB18E6BB8D663BC0E5F43E7
		/// Type: StructProperty
		/// Offset: 0x1A40
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_36C731BA4FB18E6BB8D663BC0E5F43E7 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x1A40);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_65702775488E15ADC564A28481F77BA8
		/// Type: StructProperty
		/// Offset: 0x1AE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_65702775488E15ADC564A28481F77BA8 => ReadStruct<FAnimNode_UseCachedPose>(0x1AE0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_5B06E1364B689EE21643A0A2D37A28EC
		/// Type: StructProperty
		/// Offset: 0x1B28
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_5B06E1364B689EE21643A0A2D37A28EC => ReadStruct<FAnimNode_Slot>(0x1B28);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_EEBB7215493E8E664B758F83A277296F
		/// Type: StructProperty
		/// Offset: 0x1B88
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_EEBB7215493E8E664B758F83A277296F => ReadStruct<FAnimNode_SaveCachedPose>(0x1B88);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_D39DFFEC459DC18D3D5C4BBC200621FD
		/// Type: StructProperty
		/// Offset: 0x1C18
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_D39DFFEC459DC18D3D5C4BBC200621FD => ReadStruct<FAnimNode_UseCachedPose>(0x1C18);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_BE8E33AF456D06D06C39A198CB0603E0
		/// Type: StructProperty
		/// Offset: 0x1C60
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_BE8E33AF456D06D06C39A198CB0603E0 => ReadStruct<FAnimNode_UseCachedPose>(0x1C60);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_145BC32A42AD9F1B639536898F35256B
		/// Type: StructProperty
		/// Offset: 0x1CA8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_145BC32A42AD9F1B639536898F35256B => ReadStruct<FAnimNode_UseCachedPose>(0x1CA8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_8FF6B4FB4121DD612A027E8DBC62CCD4
		/// Type: StructProperty
		/// Offset: 0x1CF0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_8FF6B4FB4121DD612A027E8DBC62CCD4 => ReadStruct<FAnimNode_UseCachedPose>(0x1CF0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_58AED82B48EF7F82E35F5B96B01F3825
		/// Type: StructProperty
		/// Offset: 0x1D38
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_58AED82B48EF7F82E35F5B96B01F3825 => ReadStruct<FAnimNode_ModifyBone>(0x1D38);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_4E975D9F4BD6BB00D0C9858FBFB853EC
		/// Type: StructProperty
		/// Offset: 0x1DE8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_4E975D9F4BD6BB00D0C9858FBFB853EC => ReadStruct<FAnimNode_ModifyBone>(0x1DE8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_8B702738479BC128BBE0F69D371ECA9D
		/// Type: StructProperty
		/// Offset: 0x1E98
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_8B702738479BC128BBE0F69D371ECA9D => ReadStruct<FAnimNode_UseCachedPose>(0x1E98);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_72006BA94A826B2D2F53ACBA8B7C0C09
		/// Type: StructProperty
		/// Offset: 0x1EE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_72006BA94A826B2D2F53ACBA8B7C0C09 => ReadStruct<FAnimNode_UseCachedPose>(0x1EE0);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_F22796974692C165CA6522A94B05871C
		/// Type: StructProperty
		/// Offset: 0x1F28
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_F22796974692C165CA6522A94B05871C => ReadStruct<FAnimNode_UseCachedPose>(0x1F28);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_D0CC5A5641EFBC032651F4A40D1D0397
		/// Type: StructProperty
		/// Offset: 0x1F70
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_D0CC5A5641EFBC032651F4A40D1D0397 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x1F70);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_AB143AE0420F1691C90ECEBF10CA67B8
		/// Type: StructProperty
		/// Offset: 0x1FB8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_AB143AE0420F1691C90ECEBF10CA67B8 => ReadStruct<FAnimNode_ModifyBone>(0x1FB8);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_E51C62AE4C176BB86C48F2B285DF51F5
		/// Type: StructProperty
		/// Offset: 0x2068
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_E51C62AE4C176BB86C48F2B285DF51F5 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x2068);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_41CF737643A38B6BA9A31390A598CF6E
		/// Type: StructProperty
		/// Offset: 0x20B0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_41CF737643A38B6BA9A31390A598CF6E => ReadStruct<FAnimNode_ModifyBone>(0x20B0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_E708D5A04F24B71054E962BD82EAE760
		/// Type: StructProperty
		/// Offset: 0x2160
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_E708D5A04F24B71054E962BD82EAE760 => ReadStruct<FAnimNode_BlendListByBool>(0x2160);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_24EC5B2345845752FAA8C2970DA2CE8C
		/// Type: StructProperty
		/// Offset: 0x2230
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_24EC5B2345845752FAA8C2970DA2CE8C => ReadStruct<FAnimNode_ModifyBone>(0x2230);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_E2AD50B54E2217FFAEAAFAA911B2E8A2
		/// Type: StructProperty
		/// Offset: 0x22E0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_E2AD50B54E2217FFAEAAFAA911B2E8A2 => ReadStruct<FAnimNode_ModifyBone>(0x22E0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_20A503884EBBC6EAA7B9BC9C856A6755
		/// Type: StructProperty
		/// Offset: 0x2390
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_20A503884EBBC6EAA7B9BC9C856A6755 => ReadStruct<FAnimNode_ModifyBone>(0x2390);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_8CB232E7420B9154A8C6D4AAAE142543
		/// Type: StructProperty
		/// Offset: 0x2440
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_8CB232E7420B9154A8C6D4AAAE142543 => ReadStruct<FAnimNode_UseCachedPose>(0x2440);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_F850637748B835B5CE3D0B926FB7875D
		/// Type: StructProperty
		/// Offset: 0x2488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_F850637748B835B5CE3D0B926FB7875D => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x2488);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_27AF233D44F888B18F6469A96518AC97
		/// Type: StructProperty
		/// Offset: 0x24D0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_27AF233D44F888B18F6469A96518AC97 => ReadStruct<FAnimNode_ModifyBone>(0x24D0);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_EF7829F446B3A79496E2738839F5EA3E
		/// Type: StructProperty
		/// Offset: 0x2580
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_EF7829F446B3A79496E2738839F5EA3E => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x2580);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_1AF2490D48FC706D9FD3F0B475A54580
		/// Type: StructProperty
		/// Offset: 0x25C8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_1AF2490D48FC706D9FD3F0B475A54580 => ReadStruct<FAnimNode_ModifyBone>(0x25C8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_5B9A39544DB082854A1673ABB6472AC2
		/// Type: StructProperty
		/// Offset: 0x2678
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_5B9A39544DB082854A1673ABB6472AC2 => ReadStruct<FAnimNode_ModifyBone>(0x2678);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_3C9D74C44238133B225BD2ADF9B1DC3B
		/// Type: StructProperty
		/// Offset: 0x2728
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_3C9D74C44238133B225BD2ADF9B1DC3B => ReadStruct<FAnimNode_BlendListByBool>(0x2728);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_A3FAFF4D4A27D687644DF99C06B0C42E
		/// Type: StructProperty
		/// Offset: 0x27F8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_A3FAFF4D4A27D687644DF99C06B0C42E => ReadStruct<FAnimNode_ModifyBone>(0x27F8);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_5C70237F4103865A479288A757EAF5C2
		/// Type: StructProperty
		/// Offset: 0x28A8
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_5C70237F4103865A479288A757EAF5C2 => ReadStruct<FAnimNode_AnimDynamics>(0x28A8);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_185E4CE44C10F0462668F8BF41318A69
		/// Type: StructProperty
		/// Offset: 0x2AC8
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_185E4CE44C10F0462668F8BF41318A69 => ReadStruct<FAnimNode_AnimDynamics>(0x2AC8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_D6B4C1AB44030186DCB1BF947BE036BD
		/// Type: StructProperty
		/// Offset: 0x2CE8
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_D6B4C1AB44030186DCB1BF947BE036BD => ReadStruct<FAnimNode_ModifyBone>(0x2CE8);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_21B4E121448DFDF766AE33994B43FBD2
		/// Type: StructProperty
		/// Offset: 0x2D98
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_21B4E121448DFDF766AE33994B43FBD2 => ReadStruct<FAnimNode_AnimDynamics>(0x2D98);
		
		/// <summary>
		/// Name: AnimGraphNode_AnimDynamics_D3D7AA0442D8BB0D701971B05715A6C3
		/// Type: StructProperty
		/// Offset: 0x2FB8
		/// Size: 0x220
		/// </summary>
		public FAnimNode_AnimDynamics AnimGraphNode_AnimDynamics_D3D7AA0442D8BB0D701971B05715A6C3 => ReadStruct<FAnimNode_AnimDynamics>(0x2FB8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_311C989F4BE00DA254742095ADE1FBFD
		/// Type: StructProperty
		/// Offset: 0x31D8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_311C989F4BE00DA254742095ADE1FBFD => ReadStruct<FAnimNode_UseCachedPose>(0x31D8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_4C925E5242D79FA6F95E84AE4CA88546
		/// Type: StructProperty
		/// Offset: 0x3220
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_4C925E5242D79FA6F95E84AE4CA88546 => ReadStruct<FAnimNode_ModifyBone>(0x3220);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_738314734C0A7FB836CDD0A4E845D595
		/// Type: StructProperty
		/// Offset: 0x32D0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_738314734C0A7FB836CDD0A4E845D595 => ReadStruct<FAnimNode_ModifyBone>(0x32D0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_15F5C2304E61980BA98EBD89A1762BF9
		/// Type: StructProperty
		/// Offset: 0x3380
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_15F5C2304E61980BA98EBD89A1762BF9 => ReadStruct<FAnimNode_ModifyBone>(0x3380);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_F24933C04F8F3781B7EA60BA79F7F3DD
		/// Type: StructProperty
		/// Offset: 0x3430
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_F24933C04F8F3781B7EA60BA79F7F3DD => ReadStruct<FAnimNode_ModifyBone>(0x3430);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_5D157C6041FA2B589809138B7FA44C4D
		/// Type: StructProperty
		/// Offset: 0x34E0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_5D157C6041FA2B589809138B7FA44C4D => ReadStruct<FAnimNode_ModifyBone>(0x34E0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_00A25DD44FEF1839176B10A4DF2B8F96
		/// Type: StructProperty
		/// Offset: 0x3590
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_00A25DD44FEF1839176B10A4DF2B8F96 => ReadStruct<FAnimNode_ModifyBone>(0x3590);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_7478B2CB4E036960DC1559B8162A4148
		/// Type: StructProperty
		/// Offset: 0x3640
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_7478B2CB4E036960DC1559B8162A4148 => ReadStruct<FAnimNode_ModifyBone>(0x3640);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_F7BD2DAF426435996D68FD8207A775AF
		/// Type: StructProperty
		/// Offset: 0x36F0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_F7BD2DAF426435996D68FD8207A775AF => ReadStruct<FAnimNode_ModifyBone>(0x36F0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_6C0303D14E6D9172F97F9C852AC656B4
		/// Type: StructProperty
		/// Offset: 0x37A0
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_6C0303D14E6D9172F97F9C852AC656B4 => ReadStruct<FAnimNode_Slot>(0x37A0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_ED7B41644FA48C2FD9166EB759A0E5C0
		/// Type: StructProperty
		/// Offset: 0x3800
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_ED7B41644FA48C2FD9166EB759A0E5C0 => ReadStruct<FAnimNode_Slot>(0x3800);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_6B0341DA4E982E697CAEC7A589D87763
		/// Type: StructProperty
		/// Offset: 0x3860
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_6B0341DA4E982E697CAEC7A589D87763 => ReadStruct<FAnimNode_ModifyBone>(0x3860);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_EC6B90F8422290E57FF3A1BDC55207F8
		/// Type: StructProperty
		/// Offset: 0x3910
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_EC6B90F8422290E57FF3A1BDC55207F8 => ReadStruct<FAnimNode_ModifyBone>(0x3910);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_7D435F2A4A0FDA1BD160E69275F71AD2
		/// Type: StructProperty
		/// Offset: 0x39C0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_7D435F2A4A0FDA1BD160E69275F71AD2 => ReadStruct<FAnimNode_ModifyBone>(0x39C0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_B81075364B77EB564AC509B2CCCB22FA
		/// Type: StructProperty
		/// Offset: 0x3A70
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_B81075364B77EB564AC509B2CCCB22FA => ReadStruct<FAnimNode_ModifyBone>(0x3A70);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_568507134412F178529803A0B6563542
		/// Type: StructProperty
		/// Offset: 0x3B20
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_568507134412F178529803A0B6563542 => ReadStruct<FAnimNode_SaveCachedPose>(0x3B20);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_8AD465AB44FB0564260D5D8F9E665BDA
		/// Type: StructProperty
		/// Offset: 0x3BB0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_8AD465AB44FB0564260D5D8F9E665BDA => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x3BB0);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyAdditive_E7DA3D7F4A3AADC914DE66841AFAE541
		/// Type: StructProperty
		/// Offset: 0x3BF8
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyAdditive AnimGraphNode_ApplyAdditive_E7DA3D7F4A3AADC914DE66841AFAE541 => ReadStruct<FAnimNode_ApplyAdditive>(0x3BF8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_DD69B34443CDFDBF968743B69C28BCCD
		/// Type: StructProperty
		/// Offset: 0x3C70
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_DD69B34443CDFDBF968743B69C28BCCD => ReadStruct<FAnimNode_UseCachedPose>(0x3C70);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_4BC659A8491C2CDECEE452B78AA42E69
		/// Type: StructProperty
		/// Offset: 0x3CB8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_4BC659A8491C2CDECEE452B78AA42E69 => ReadStruct<FAnimNode_BlendListByBool>(0x3CB8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_BC8F7FDD4954864530FFEBB22E92D1D0
		/// Type: StructProperty
		/// Offset: 0x3D88
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_BC8F7FDD4954864530FFEBB22E92D1D0 => ReadStruct<FAnimNode_RotationMultiplier>(0x3D88);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_E84248A446C19A626CFEAB9966F56717
		/// Type: StructProperty
		/// Offset: 0x3E20
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_E84248A446C19A626CFEAB9966F56717 => ReadStruct<FAnimNode_BlendListByBool>(0x3E20);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_7918483C4F795992F87E03AAB29E9BA0
		/// Type: StructProperty
		/// Offset: 0x3EF0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_7918483C4F795992F87E03AAB29E9BA0 => ReadStruct<FAnimNode_RotationMultiplier>(0x3EF0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_D44B0BCD4674EC78A7A5A985DD97A7C5
		/// Type: StructProperty
		/// Offset: 0x3F88
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_D44B0BCD4674EC78A7A5A985DD97A7C5 => ReadStruct<FAnimNode_RotationMultiplier>(0x3F88);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_E332A4AD451B10B4EBE17387EFAFA164
		/// Type: StructProperty
		/// Offset: 0x4020
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_E332A4AD451B10B4EBE17387EFAFA164 => ReadStruct<FAnimNode_UseCachedPose>(0x4020);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_B59505F94EF3DF621A1941AD36FB6270
		/// Type: StructProperty
		/// Offset: 0x4068
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_B59505F94EF3DF621A1941AD36FB6270 => ReadStruct<FAnimNode_RotationMultiplier>(0x4068);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_E673518542F02E8ED556D0A193AC092E
		/// Type: StructProperty
		/// Offset: 0x4100
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_E673518542F02E8ED556D0A193AC092E => ReadStruct<FAnimNode_RotationMultiplier>(0x4100);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_61799FD14712E1973F1C3B8DC3AE30C7
		/// Type: StructProperty
		/// Offset: 0x4198
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_61799FD14712E1973F1C3B8DC3AE30C7 => ReadStruct<FAnimNode_RotationMultiplier>(0x4198);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_1965B5824AD214A69B7654815EF1EB1B
		/// Type: StructProperty
		/// Offset: 0x4230
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_1965B5824AD214A69B7654815EF1EB1B => ReadStruct<FAnimNode_RotationMultiplier>(0x4230);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_535BBC8D4C9F6F604B0AB2B923481A67
		/// Type: StructProperty
		/// Offset: 0x42C8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_535BBC8D4C9F6F604B0AB2B923481A67 => ReadStruct<FAnimNode_RotationMultiplier>(0x42C8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_12A6684F4EBE20663D25988E78BEAF8D
		/// Type: StructProperty
		/// Offset: 0x4360
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_12A6684F4EBE20663D25988E78BEAF8D => ReadStruct<FAnimNode_RotationMultiplier>(0x4360);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_FB5D510D461868BAEAEFA9844BB8D7D6
		/// Type: StructProperty
		/// Offset: 0x43F8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_FB5D510D461868BAEAEFA9844BB8D7D6 => ReadStruct<FAnimNode_RotationMultiplier>(0x43F8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_D5F7292545EB07556B17828BE6429852
		/// Type: StructProperty
		/// Offset: 0x4490
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_D5F7292545EB07556B17828BE6429852 => ReadStruct<FAnimNode_RotationMultiplier>(0x4490);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_462D8EF948AEA8E81C5CAAB51E0BBDE8
		/// Type: StructProperty
		/// Offset: 0x4528
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_462D8EF948AEA8E81C5CAAB51E0BBDE8 => ReadStruct<FAnimNode_ModifyBone>(0x4528);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_9FC1F17C43737EC4139770A02D0646A7
		/// Type: StructProperty
		/// Offset: 0x45D8
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_9FC1F17C43737EC4139770A02D0646A7 => ReadStruct<FAnimNode_RotationMultiplier>(0x45D8);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_CE872B534D45A10EAD5F7B836C76192D
		/// Type: StructProperty
		/// Offset: 0x4670
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_CE872B534D45A10EAD5F7B836C76192D => ReadStruct<FAnimNode_RotationMultiplier>(0x4670);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_2B3A776F4566644F9172CA9159DD84F4
		/// Type: StructProperty
		/// Offset: 0x4708
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_2B3A776F4566644F9172CA9159DD84F4 => ReadStruct<FAnimNode_RotationMultiplier>(0x4708);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_B86DF42B4FBCFB30C633CB8016A14097
		/// Type: StructProperty
		/// Offset: 0x47A0
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_B86DF42B4FBCFB30C633CB8016A14097 => ReadStruct<FAnimNode_RotationMultiplier>(0x47A0);
		
		/// <summary>
		/// Name: AnimGraphNode_RotationMultiplier_B33203224A06E6114804EDAEF0C0886C
		/// Type: StructProperty
		/// Offset: 0x4838
		/// Size: 0x98
		/// </summary>
		public FAnimNode_RotationMultiplier AnimGraphNode_RotationMultiplier_B33203224A06E6114804EDAEF0C0886C => ReadStruct<FAnimNode_RotationMultiplier>(0x4838);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_BB0A893E438EF5AED0654F9DAAA4B5DE
		/// Type: StructProperty
		/// Offset: 0x48D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_BB0A893E438EF5AED0654F9DAAA4B5DE => ReadStruct<FAnimNode_TransitionResult>(0x48D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_A37D5AFA46417AA9B7436697B1017735
		/// Type: StructProperty
		/// Offset: 0x4950
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_A37D5AFA46417AA9B7436697B1017735 => ReadStruct<FAnimNode_TransitionResult>(0x4950);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_0E4E79274AAECEC0AB17AC99517B5CD8
		/// Type: StructProperty
		/// Offset: 0x49D0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_0E4E79274AAECEC0AB17AC99517B5CD8 => ReadStruct<FAnimNode_SequencePlayer>(0x49D0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_8828DFF5434FE47931CDCAA0E6A372C9
		/// Type: StructProperty
		/// Offset: 0x4A40
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_8828DFF5434FE47931CDCAA0E6A372C9 => ReadStruct<FAnimNode_Root>(0x4A40);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6134B0084792B812D0278EA1CAC2342C
		/// Type: StructProperty
		/// Offset: 0x4A90
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6134B0084792B812D0278EA1CAC2342C => ReadStruct<FAnimNode_TransitionResult>(0x4A90);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_17A42F6F48A15031615841BCC9A9BEF8
		/// Type: StructProperty
		/// Offset: 0x4B10
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_17A42F6F48A15031615841BCC9A9BEF8 => ReadStruct<FAnimNode_TransitionResult>(0x4B10);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_3B4FAB5F416EEF8387279C925DC0156C
		/// Type: StructProperty
		/// Offset: 0x4B90
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_3B4FAB5F416EEF8387279C925DC0156C => ReadStruct<FAnimNode_TransitionResult>(0x4B90);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_CDA87B1D45CA330A0EA84CBE207D6D99
		/// Type: StructProperty
		/// Offset: 0x4C10
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_CDA87B1D45CA330A0EA84CBE207D6D99 => ReadStruct<FAnimNode_TransitionResult>(0x4C10);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_E1A255CC48E667702097AEBC78008511
		/// Type: StructProperty
		/// Offset: 0x4C90
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_E1A255CC48E667702097AEBC78008511 => ReadStruct<FAnimNode_TransitionResult>(0x4C90);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_544DA0164B6674956861A082459EF1D8
		/// Type: StructProperty
		/// Offset: 0x4D10
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_544DA0164B6674956861A082459EF1D8 => ReadStruct<FAnimNode_TransitionResult>(0x4D10);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_3B1AB5164070D6E70D52258CE86EFC8A
		/// Type: StructProperty
		/// Offset: 0x4D90
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_3B1AB5164070D6E70D52258CE86EFC8A => ReadStruct<FAnimNode_TransitionResult>(0x4D90);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_A8355D5B47BC823A45054EB30CF5A254
		/// Type: StructProperty
		/// Offset: 0x4E10
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_A8355D5B47BC823A45054EB30CF5A254 => ReadStruct<FAnimNode_TransitionResult>(0x4E10);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_D2B0C9084D35EF360AD2A08164F95C6B
		/// Type: StructProperty
		/// Offset: 0x4E90
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_D2B0C9084D35EF360AD2A08164F95C6B => ReadStruct<FAnimNode_TransitionResult>(0x4E90);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_8EED220449DF7457BD562B877064CD5C
		/// Type: StructProperty
		/// Offset: 0x4F10
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_8EED220449DF7457BD562B877064CD5C => ReadStruct<FAnimNode_SequencePlayer>(0x4F10);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByEnum_24E2A8674315ED53FB44E2ACC7A98F60
		/// Type: StructProperty
		/// Offset: 0x4F80
		/// Size: 0xE0
		/// </summary>
		public FAnimNode_BlendListByEnum AnimGraphNode_BlendListByEnum_24E2A8674315ED53FB44E2ACC7A98F60 => ReadStruct<FAnimNode_BlendListByEnum>(0x4F80);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_7BB6CF9C4EF52192CC8600BAF22ACF63
		/// Type: StructProperty
		/// Offset: 0x5060
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_7BB6CF9C4EF52192CC8600BAF22ACF63 => ReadStruct<FAnimNode_SequencePlayer>(0x5060);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_925F67524C56B0269C8B4DA25CC6D56F
		/// Type: StructProperty
		/// Offset: 0x50D0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_925F67524C56B0269C8B4DA25CC6D56F => ReadStruct<FAnimNode_SequencePlayer>(0x50D0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_1889054348B1E26E6AEA2A96465DA016
		/// Type: StructProperty
		/// Offset: 0x5140
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_1889054348B1E26E6AEA2A96465DA016 => ReadStruct<FAnimNode_SequencePlayer>(0x5140);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_C150AA134D1BD8A1024E1A8478325441
		/// Type: StructProperty
		/// Offset: 0x51B0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_C150AA134D1BD8A1024E1A8478325441 => ReadStruct<FAnimNode_Root>(0x51B0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_BF154DD94B1BA9D11D9D2BAE051C0E91
		/// Type: StructProperty
		/// Offset: 0x5200
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_BF154DD94B1BA9D11D9D2BAE051C0E91 => ReadStruct<FAnimNode_TransitionResult>(0x5200);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_070A2AAE4AC6FF4D713F00A6DF60A0C0
		/// Type: StructProperty
		/// Offset: 0x5280
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_070A2AAE4AC6FF4D713F00A6DF60A0C0 => ReadStruct<FAnimNode_TransitionResult>(0x5280);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_9144555C429A8CB170E2AEAA6515E4DF
		/// Type: StructProperty
		/// Offset: 0x5300
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_9144555C429A8CB170E2AEAA6515E4DF => ReadStruct<FAnimNode_TransitionResult>(0x5300);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_8F71756F4147B612EEFF04B0B1B4C249
		/// Type: StructProperty
		/// Offset: 0x5380
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_8F71756F4147B612EEFF04B0B1B4C249 => ReadStruct<FAnimNode_TransitionResult>(0x5380);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6E7039414EC12623E2557CBD985D52E3
		/// Type: StructProperty
		/// Offset: 0x5400
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6E7039414EC12623E2557CBD985D52E3 => ReadStruct<FAnimNode_TransitionResult>(0x5400);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_4A5387B3430E0713CF622586720AD146
		/// Type: StructProperty
		/// Offset: 0x5480
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_4A5387B3430E0713CF622586720AD146 => ReadStruct<FAnimNode_TransitionResult>(0x5480);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_C6F425904A3295042F75AEAD9EA4EC01
		/// Type: StructProperty
		/// Offset: 0x5500
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_C6F425904A3295042F75AEAD9EA4EC01 => ReadStruct<FAnimNode_TransitionResult>(0x5500);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_B94AF18C4EA8154B0330B8A4B5734E20
		/// Type: StructProperty
		/// Offset: 0x5580
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_B94AF18C4EA8154B0330B8A4B5734E20 => ReadStruct<FAnimNode_TransitionResult>(0x5580);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_A9ACDC9B4C338E790DF0CE8C46FA58892
		/// Type: StructProperty
		/// Offset: 0x5600
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_A9ACDC9B4C338E790DF0CE8C46FA58892 => ReadStruct<FAnimNode_TransitionResult>(0x5600);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6693A2034CF4AA71CBF267AAA44780B32
		/// Type: StructProperty
		/// Offset: 0x5680
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6693A2034CF4AA71CBF267AAA44780B32 => ReadStruct<FAnimNode_TransitionResult>(0x5680);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_0D50F3D0496125C88EBA33A3BDC4B1B2
		/// Type: StructProperty
		/// Offset: 0x5700
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_0D50F3D0496125C88EBA33A3BDC4B1B2 => ReadStruct<FAnimNode_TransitionResult>(0x5700);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_E431C62441E1AD0D6D3B13ACDAADA025
		/// Type: StructProperty
		/// Offset: 0x5780
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_E431C62441E1AD0D6D3B13ACDAADA025 => ReadStruct<FAnimNode_TransitionResult>(0x5780);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_47026E40432A8DCBC7F3BA98F957766D
		/// Type: StructProperty
		/// Offset: 0x5800
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_47026E40432A8DCBC7F3BA98F957766D => ReadStruct<FAnimNode_TransitionResult>(0x5800);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_B1F13B0541705572543D5A899D8DEB3F
		/// Type: StructProperty
		/// Offset: 0x5880
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_B1F13B0541705572543D5A899D8DEB3F => ReadStruct<FAnimNode_TransitionResult>(0x5880);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_5DD525CA49416C7DA9A007A407B93CC1
		/// Type: StructProperty
		/// Offset: 0x5900
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_5DD525CA49416C7DA9A007A407B93CC1 => ReadStruct<FAnimNode_TransitionResult>(0x5900);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_55D37CB4490EADA48038A68880004C0B
		/// Type: StructProperty
		/// Offset: 0x5980
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_55D37CB4490EADA48038A68880004C0B => ReadStruct<FAnimNode_TransitionResult>(0x5980);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_43BF00294E6AE2A0CB5135BF19ADC44C
		/// Type: StructProperty
		/// Offset: 0x5A00
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_43BF00294E6AE2A0CB5135BF19ADC44C => ReadStruct<FAnimNode_Root>(0x5A00);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_5983E1234E0AC47F133E2A96F774B418
		/// Type: StructProperty
		/// Offset: 0x5A48
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_5983E1234E0AC47F133E2A96F774B418 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x5A48);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_F15587E142939AE17AA54C8F6A97548B
		/// Type: StructProperty
		/// Offset: 0x5B78
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_F15587E142939AE17AA54C8F6A97548B => ReadStruct<FAnimNode_BlendListByBool>(0x5B78);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_809BC9AD47AB8DF55AD3F7A7E0D0FBA4
		/// Type: StructProperty
		/// Offset: 0x5C48
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_809BC9AD47AB8DF55AD3F7A7E0D0FBA4 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x5C48);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_01F9BE41441B23E8BC2077A4EBF75AAB
		/// Type: StructProperty
		/// Offset: 0x5D78
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_01F9BE41441B23E8BC2077A4EBF75AAB => ReadStruct<FAnimNode_Root>(0x5D78);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_B5F6B30E4F454021BF30B1ADE3DF24AC
		/// Type: StructProperty
		/// Offset: 0x5DC0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_B5F6B30E4F454021BF30B1ADE3DF24AC => ReadStruct<FAnimNode_SequencePlayer>(0x5DC0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_3FE8BC43454A2488E0D2318B364A112B
		/// Type: StructProperty
		/// Offset: 0x5E30
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_3FE8BC43454A2488E0D2318B364A112B => ReadStruct<FAnimNode_SequencePlayer>(0x5E30);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_29C00D1F49211643F899159A66DC0507
		/// Type: StructProperty
		/// Offset: 0x5EA0
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_29C00D1F49211643F899159A66DC0507 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x5EA0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_7187117940CD220E4394D6906D0B1B75
		/// Type: StructProperty
		/// Offset: 0x5F40
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_7187117940CD220E4394D6906D0B1B75 => ReadStruct<FAnimNode_SequencePlayer>(0x5F40);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_9302DD584B2BBC7C7BB63BB1E32F2BCB2
		/// Type: StructProperty
		/// Offset: 0x5FB0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_9302DD584B2BBC7C7BB63BB1E32F2BCB2 => ReadStruct<FAnimNode_Root>(0x5FB0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_DEC17B554ACDAD3B8686F4807B3C4838
		/// Type: StructProperty
		/// Offset: 0x5FF8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_DEC17B554ACDAD3B8686F4807B3C4838 => ReadStruct<FAnimNode_SequencePlayer>(0x5FF8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_D93D588D4CDFE2BE03E70C90E29D2AB8
		/// Type: StructProperty
		/// Offset: 0x6068
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_D93D588D4CDFE2BE03E70C90E29D2AB8 => ReadStruct<FAnimNode_SequencePlayer>(0x6068);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_1DE5C5E949962FD3783858A472E73F92
		/// Type: StructProperty
		/// Offset: 0x60D8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_1DE5C5E949962FD3783858A472E73F92 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x60D8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_680CCFCA422064020D81A795DA86BDCD
		/// Type: StructProperty
		/// Offset: 0x6178
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_680CCFCA422064020D81A795DA86BDCD => ReadStruct<FAnimNode_SequencePlayer>(0x6178);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_554C2D19443477853F110EAB37B581622
		/// Type: StructProperty
		/// Offset: 0x61E8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_554C2D19443477853F110EAB37B581622 => ReadStruct<FAnimNode_Root>(0x61E8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_652B78884BE070F2B04681B7E8777B78
		/// Type: StructProperty
		/// Offset: 0x6230
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_652B78884BE070F2B04681B7E8777B78 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x6230);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_D480C87C4497F9AEE98833899E9EF57C
		/// Type: StructProperty
		/// Offset: 0x6360
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_D480C87C4497F9AEE98833899E9EF57C => ReadStruct<FAnimNode_Root>(0x6360);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_F4FE9B754EDF2B61EBDB8B8814380500
		/// Type: StructProperty
		/// Offset: 0x63A8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_F4FE9B754EDF2B61EBDB8B8814380500 => ReadStruct<FAnimNode_SequencePlayer>(0x63A8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_EA3632194C6558823D4271944A4A3E8C
		/// Type: StructProperty
		/// Offset: 0x6418
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_EA3632194C6558823D4271944A4A3E8C => ReadStruct<FAnimNode_BlendListByBool>(0x6418);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_1036605141787A1F1DD2CA93A113C0BB
		/// Type: StructProperty
		/// Offset: 0x64E8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_1036605141787A1F1DD2CA93A113C0BB => ReadStruct<FAnimNode_SequencePlayer>(0x64E8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_CFF2E2D44B2D34B04ADC1387EA7592312
		/// Type: StructProperty
		/// Offset: 0x6558
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_CFF2E2D44B2D34B04ADC1387EA7592312 => ReadStruct<FAnimNode_Root>(0x6558);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_4BEC125B47CBFD6E32BD479F62D6B207
		/// Type: StructProperty
		/// Offset: 0x65A0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_4BEC125B47CBFD6E32BD479F62D6B207 => ReadStruct<FAnimNode_SequencePlayer>(0x65A0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_D09D15174769E483BF2F39A5FE9225CB
		/// Type: StructProperty
		/// Offset: 0x6610
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_D09D15174769E483BF2F39A5FE9225CB => ReadStruct<FAnimNode_BlendListByBool>(0x6610);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_B9C7E8EB493F446ED1BDF88FB76D4693
		/// Type: StructProperty
		/// Offset: 0x66E0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_B9C7E8EB493F446ED1BDF88FB76D4693 => ReadStruct<FAnimNode_SequencePlayer>(0x66E0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_04B175504A102D5938555AB9EEDCC2272
		/// Type: StructProperty
		/// Offset: 0x6750
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_04B175504A102D5938555AB9EEDCC2272 => ReadStruct<FAnimNode_Root>(0x6750);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_BCE476B647DA1BB470337990E4DC57F2
		/// Type: StructProperty
		/// Offset: 0x6798
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_BCE476B647DA1BB470337990E4DC57F2 => ReadStruct<FAnimNode_SequencePlayer>(0x6798);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_66E5857940DC54FC545C3CACD346A1D6
		/// Type: StructProperty
		/// Offset: 0x6808
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_66E5857940DC54FC545C3CACD346A1D6 => ReadStruct<FAnimNode_BlendListByBool>(0x6808);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_E1ADF8884B0C796044A7BFA4D83E27E8
		/// Type: StructProperty
		/// Offset: 0x68D8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_E1ADF8884B0C796044A7BFA4D83E27E8 => ReadStruct<FAnimNode_SequencePlayer>(0x68D8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_43BED7E24E33EC72061A7FBCBF889C8C2
		/// Type: StructProperty
		/// Offset: 0x6948
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_43BED7E24E33EC72061A7FBCBF889C8C2 => ReadStruct<FAnimNode_Root>(0x6948);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_A5F59BB443D74CD55B6F57B72EDD8111
		/// Type: StructProperty
		/// Offset: 0x6990
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_A5F59BB443D74CD55B6F57B72EDD8111 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x6990);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_15A2A5884C2B2DAE1C4576AE1CE609512
		/// Type: StructProperty
		/// Offset: 0x6AC0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_15A2A5884C2B2DAE1C4576AE1CE609512 => ReadStruct<FAnimNode_Root>(0x6AC0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_0FE0656A45FAA0BF5D2D5E872242A62C
		/// Type: StructProperty
		/// Offset: 0x6B08
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_0FE0656A45FAA0BF5D2D5E872242A62C => ReadStruct<FAnimNode_StateMachine>(0x6B08);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_A912AB9049A2F31FC9168BBD6EED0413
		/// Type: StructProperty
		/// Offset: 0x6BE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_A912AB9049A2F31FC9168BBD6EED0413 => ReadStruct<FAnimNode_Root>(0x6BE0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_68C10643406468D6C5AFA69004E36F6E
		/// Type: StructProperty
		/// Offset: 0x6C28
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_68C10643406468D6C5AFA69004E36F6E => ReadStruct<FAnimNode_Slot>(0x6C28);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_E49626364E1864A147D98FB3675C24A9
		/// Type: StructProperty
		/// Offset: 0x6C88
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_E49626364E1864A147D98FB3675C24A9 => ReadStruct<FAnimNode_Root>(0x6C88);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_F32E026843E62D499F5A93A5B459CE47
		/// Type: StructProperty
		/// Offset: 0x6CD0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_F32E026843E62D499F5A93A5B459CE47 => ReadStruct<FAnimNode_TransitionResult>(0x6CD0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6138606D472F19EF3D894A9AD4B9BB68
		/// Type: StructProperty
		/// Offset: 0x6D50
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6138606D472F19EF3D894A9AD4B9BB68 => ReadStruct<FAnimNode_TransitionResult>(0x6D50);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_CE36128D4AB1593183F32D9BAF5278F0
		/// Type: StructProperty
		/// Offset: 0x6DD0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_CE36128D4AB1593183F32D9BAF5278F0 => ReadStruct<FAnimNode_TransitionResult>(0x6DD0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_ADF711E94B98043030EAC08FD05ED4D4
		/// Type: StructProperty
		/// Offset: 0x6E50
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_ADF711E94B98043030EAC08FD05ED4D4 => ReadStruct<FAnimNode_TransitionResult>(0x6E50);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_DBEC174748A447EA1C97929260C37DB0
		/// Type: StructProperty
		/// Offset: 0x6ED0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_DBEC174748A447EA1C97929260C37DB0 => ReadStruct<FAnimNode_TransitionResult>(0x6ED0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_A9ACDC9B4C338E790DF0CE8C46FA5889
		/// Type: StructProperty
		/// Offset: 0x6F50
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_A9ACDC9B4C338E790DF0CE8C46FA5889 => ReadStruct<FAnimNode_TransitionResult>(0x6F50);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6693A2034CF4AA71CBF267AAA44780B3
		/// Type: StructProperty
		/// Offset: 0x6FD0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6693A2034CF4AA71CBF267AAA44780B3 => ReadStruct<FAnimNode_TransitionResult>(0x6FD0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_515B63FC442A4238F16F4FB0CF81F4BC
		/// Type: StructProperty
		/// Offset: 0x7050
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_515B63FC442A4238F16F4FB0CF81F4BC => ReadStruct<FAnimNode_TransitionResult>(0x7050);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_1BC5C1AF4B36307F75692BA40B1CD1CD
		/// Type: StructProperty
		/// Offset: 0x70D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_1BC5C1AF4B36307F75692BA40B1CD1CD => ReadStruct<FAnimNode_TransitionResult>(0x70D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_143378054CA4521754D8D48C1E7058F6
		/// Type: StructProperty
		/// Offset: 0x7150
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_143378054CA4521754D8D48C1E7058F6 => ReadStruct<FAnimNode_TransitionResult>(0x7150);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_FCB87A0F4AB877BDA8D44FA129436FE6
		/// Type: StructProperty
		/// Offset: 0x71D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_FCB87A0F4AB877BDA8D44FA129436FE6 => ReadStruct<FAnimNode_TransitionResult>(0x71D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_39918C6C47A9CEF64F1ECE957D3CCEE6
		/// Type: StructProperty
		/// Offset: 0x7250
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_39918C6C47A9CEF64F1ECE957D3CCEE6 => ReadStruct<FAnimNode_TransitionResult>(0x7250);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_FAB568244A242DD554A125AA15FF1F46
		/// Type: StructProperty
		/// Offset: 0x72D0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_FAB568244A242DD554A125AA15FF1F46 => ReadStruct<FAnimNode_Root>(0x72D0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_237B8E0D466D6BB1239A22976FC04235
		/// Type: StructProperty
		/// Offset: 0x7318
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_237B8E0D466D6BB1239A22976FC04235 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x7318);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_CAF49AC04FBE09DDC36B2C90E2BD737C
		/// Type: StructProperty
		/// Offset: 0x7448
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_CAF49AC04FBE09DDC36B2C90E2BD737C => ReadStruct<FAnimNode_BlendListByBool>(0x7448);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_67500D3B44FD7B883F2F07861E3F3E17
		/// Type: StructProperty
		/// Offset: 0x7518
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_67500D3B44FD7B883F2F07861E3F3E17 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x7518);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_AFAF5628422FAF9BF08885A866BCD614
		/// Type: StructProperty
		/// Offset: 0x7648
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_AFAF5628422FAF9BF08885A866BCD614 => ReadStruct<FAnimNode_Root>(0x7648);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_EE2A439A46C3446338A0828C6A98A28F
		/// Type: StructProperty
		/// Offset: 0x7690
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_EE2A439A46C3446338A0828C6A98A28F => ReadStruct<FAnimNode_SequencePlayer>(0x7690);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_C675E51E40C87325120135BE7C76CE0F
		/// Type: StructProperty
		/// Offset: 0x7700
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_C675E51E40C87325120135BE7C76CE0F => ReadStruct<FAnimNode_UseCachedPose>(0x7700);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_CE6B28124699F15978E34AA40142C3C0
		/// Type: StructProperty
		/// Offset: 0x7748
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_CE6B28124699F15978E34AA40142C3C0 => ReadStruct<FAnimNode_UseCachedPose>(0x7748);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_BF05999D48E600F742AE06B869E75532
		/// Type: StructProperty
		/// Offset: 0x7790
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_BF05999D48E600F742AE06B869E75532 => ReadStruct<FAnimNode_UseCachedPose>(0x7790);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_523658B34D65930F167253B04BA9C2CC
		/// Type: StructProperty
		/// Offset: 0x77D8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_523658B34D65930F167253B04BA9C2CC => ReadStruct<FAnimNode_SequencePlayer>(0x77D8);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_6C4AB6104316B08F8AE18E8184486738
		/// Type: StructProperty
		/// Offset: 0x7848
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_6C4AB6104316B08F8AE18E8184486738 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x7848);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_65810EC04213FBEA5307BFABEC80572C
		/// Type: StructProperty
		/// Offset: 0x78E8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_65810EC04213FBEA5307BFABEC80572C => ReadStruct<FAnimNode_SequencePlayer>(0x78E8);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_FCE43D744D217F22F5BF92B83BFBD837
		/// Type: StructProperty
		/// Offset: 0x7958
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_FCE43D744D217F22F5BF92B83BFBD837 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x7958);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_38155E44491B1D449171758EFD3C7DF5
		/// Type: StructProperty
		/// Offset: 0x79F8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_38155E44491B1D449171758EFD3C7DF5 => ReadStruct<FAnimNode_BlendListByBool>(0x79F8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_9302DD584B2BBC7C7BB63BB1E32F2BCB
		/// Type: StructProperty
		/// Offset: 0x7AC8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_9302DD584B2BBC7C7BB63BB1E32F2BCB => ReadStruct<FAnimNode_Root>(0x7AC8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_8B571F2D4AFCD663D66B40B015E11CD3
		/// Type: StructProperty
		/// Offset: 0x7B10
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_8B571F2D4AFCD663D66B40B015E11CD3 => ReadStruct<FAnimNode_SequencePlayer>(0x7B10);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_14F32F624F25DAD1A8126182D1C26B11
		/// Type: StructProperty
		/// Offset: 0x7B80
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_14F32F624F25DAD1A8126182D1C26B11 => ReadStruct<FAnimNode_UseCachedPose>(0x7B80);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_255C2F51486730847CAA2691B74D47A4
		/// Type: StructProperty
		/// Offset: 0x7BC8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_255C2F51486730847CAA2691B74D47A4 => ReadStruct<FAnimNode_UseCachedPose>(0x7BC8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_754AA66840B3A2F3CCF7A38D97EFFDAA
		/// Type: StructProperty
		/// Offset: 0x7C10
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_754AA66840B3A2F3CCF7A38D97EFFDAA => ReadStruct<FAnimNode_UseCachedPose>(0x7C10);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_D1E6A14240508AC3EB89589184F135BE
		/// Type: StructProperty
		/// Offset: 0x7C58
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_D1E6A14240508AC3EB89589184F135BE => ReadStruct<FAnimNode_SequencePlayer>(0x7C58);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_76B79F624B30F7A8278814B44443459D
		/// Type: StructProperty
		/// Offset: 0x7CC8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_76B79F624B30F7A8278814B44443459D => ReadStruct<FAnimNode_LayeredBoneBlend>(0x7CC8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_9FCF6D0F4E396589620486A64A9BE509
		/// Type: StructProperty
		/// Offset: 0x7D68
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_9FCF6D0F4E396589620486A64A9BE509 => ReadStruct<FAnimNode_SequencePlayer>(0x7D68);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_2519D1E947E647F7D28EE498D3FBE4AF
		/// Type: StructProperty
		/// Offset: 0x7DD8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_2519D1E947E647F7D28EE498D3FBE4AF => ReadStruct<FAnimNode_LayeredBoneBlend>(0x7DD8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_DE7D17B64B03466832CC73A04C305EFC
		/// Type: StructProperty
		/// Offset: 0x7E78
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_DE7D17B64B03466832CC73A04C305EFC => ReadStruct<FAnimNode_BlendListByBool>(0x7E78);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_554C2D19443477853F110EAB37B58162
		/// Type: StructProperty
		/// Offset: 0x7F48
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_554C2D19443477853F110EAB37B58162 => ReadStruct<FAnimNode_Root>(0x7F48);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_6E056B854E4EED2919B524ACEE559273
		/// Type: StructProperty
		/// Offset: 0x7F90
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_6E056B854E4EED2919B524ACEE559273 => ReadStruct<FAnimNode_SequencePlayer>(0x7F90);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_52C5DA2C4B5842A7BD9104A432256726
		/// Type: StructProperty
		/// Offset: 0x8000
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_52C5DA2C4B5842A7BD9104A432256726 => ReadStruct<FAnimNode_BlendListByBool>(0x8000);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_C9934FF140F61782A777FCA5991F3D34
		/// Type: StructProperty
		/// Offset: 0x80D0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_C9934FF140F61782A777FCA5991F3D34 => ReadStruct<FAnimNode_SequencePlayer>(0x80D0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_CFF2E2D44B2D34B04ADC1387EA759231
		/// Type: StructProperty
		/// Offset: 0x8140
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_CFF2E2D44B2D34B04ADC1387EA759231 => ReadStruct<FAnimNode_Root>(0x8140);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_C1D2E57649DF2A70CC9D1D813B1A9681
		/// Type: StructProperty
		/// Offset: 0x8188
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_C1D2E57649DF2A70CC9D1D813B1A9681 => ReadStruct<FAnimNode_SequencePlayer>(0x8188);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_5F592E3646DD8150A67736B4DD32A1A6
		/// Type: StructProperty
		/// Offset: 0x81F8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_5F592E3646DD8150A67736B4DD32A1A6 => ReadStruct<FAnimNode_BlendListByBool>(0x81F8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_5CC530104D5B9258CC1FA89DEB8B6638
		/// Type: StructProperty
		/// Offset: 0x82C8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_5CC530104D5B9258CC1FA89DEB8B6638 => ReadStruct<FAnimNode_SequencePlayer>(0x82C8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_04B175504A102D5938555AB9EEDCC227
		/// Type: StructProperty
		/// Offset: 0x8338
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_04B175504A102D5938555AB9EEDCC227 => ReadStruct<FAnimNode_Root>(0x8338);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_ADB150A2472C943ED2A89B987BAAC204
		/// Type: StructProperty
		/// Offset: 0x8380
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_ADB150A2472C943ED2A89B987BAAC204 => ReadStruct<FAnimNode_SequencePlayer>(0x8380);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_3CC6041E4CCC08D43B80C1A658F2CF8D
		/// Type: StructProperty
		/// Offset: 0x83F0
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_3CC6041E4CCC08D43B80C1A658F2CF8D => ReadStruct<FAnimNode_BlendListByBool>(0x83F0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_4C1951CB4E0D65C84782BAAE5DA19775
		/// Type: StructProperty
		/// Offset: 0x84C0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_4C1951CB4E0D65C84782BAAE5DA19775 => ReadStruct<FAnimNode_SequencePlayer>(0x84C0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_43BED7E24E33EC72061A7FBCBF889C8C
		/// Type: StructProperty
		/// Offset: 0x8530
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_43BED7E24E33EC72061A7FBCBF889C8C => ReadStruct<FAnimNode_Root>(0x8530);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_A8C382E443E3CE6CE8002C843A29026A
		/// Type: StructProperty
		/// Offset: 0x8578
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_A8C382E443E3CE6CE8002C843A29026A => ReadStruct<FAnimNode_SequencePlayer>(0x8578);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_132DDBE540178C22828CBFA6751AE5B3
		/// Type: StructProperty
		/// Offset: 0x85E8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_132DDBE540178C22828CBFA6751AE5B3 => ReadStruct<FAnimNode_BlendListByBool>(0x85E8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_04CA177344AC88FB769B579B69DD579B
		/// Type: StructProperty
		/// Offset: 0x86B8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_04CA177344AC88FB769B579B69DD579B => ReadStruct<FAnimNode_BlendListByBool>(0x86B8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_2519F885421514D771CEF7926F03C178
		/// Type: StructProperty
		/// Offset: 0x8788
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_2519F885421514D771CEF7926F03C178 => ReadStruct<FAnimNode_BlendListByBool>(0x8788);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_230694F8468B2A7502AB2EA363850988
		/// Type: StructProperty
		/// Offset: 0x8858
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_230694F8468B2A7502AB2EA363850988 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x8858);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_74FEDEDF469EA09AE1A2DBBAB2B7D4BF
		/// Type: StructProperty
		/// Offset: 0x8988
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_74FEDEDF469EA09AE1A2DBBAB2B7D4BF => ReadStruct<FAnimNode_BlendListByBool>(0x8988);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_AFF7013F4746DE8F762E45B2BFC2549C
		/// Type: StructProperty
		/// Offset: 0x8A58
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_AFF7013F4746DE8F762E45B2BFC2549C => ReadStruct<FAnimNode_SequencePlayer>(0x8A58);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_F6D8A6DA4BFB353D387B20B2F279FC20
		/// Type: StructProperty
		/// Offset: 0x8AC8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_F6D8A6DA4BFB353D387B20B2F279FC20 => ReadStruct<FAnimNode_SequencePlayer>(0x8AC8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_E999948E4EC05F86CB06CE968ABDB673
		/// Type: StructProperty
		/// Offset: 0x8B38
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_E999948E4EC05F86CB06CE968ABDB673 => ReadStruct<FAnimNode_BlendListByBool>(0x8B38);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_07D0E22B4E5B633ADAE5EE8096A6CC48
		/// Type: StructProperty
		/// Offset: 0x8C08
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_07D0E22B4E5B633ADAE5EE8096A6CC48 => ReadStruct<FAnimNode_SequencePlayer>(0x8C08);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_FB2C64EE499F6632FB2CF28F71886A19
		/// Type: StructProperty
		/// Offset: 0x8C78
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_FB2C64EE499F6632FB2CF28F71886A19 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x8C78);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_4E3FB86047CBA1A094A9A1957D81608A
		/// Type: StructProperty
		/// Offset: 0x8DA8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_4E3FB86047CBA1A094A9A1957D81608A => ReadStruct<FAnimNode_BlendListByBool>(0x8DA8);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_398EEE6C4C6D4502D06442ABF35D6845
		/// Type: StructProperty
		/// Offset: 0x8E78
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_398EEE6C4C6D4502D06442ABF35D6845 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x8E78);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_4EF2463E4115FE50C59C8CB163452AAB
		/// Type: StructProperty
		/// Offset: 0x8F18
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_4EF2463E4115FE50C59C8CB163452AAB => ReadStruct<FAnimNode_SequencePlayer>(0x8F18);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_FAFF4FB545D9B908BFDC8C81742C077C
		/// Type: StructProperty
		/// Offset: 0x8F88
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_FAFF4FB545D9B908BFDC8C81742C077C => ReadStruct<FAnimNode_BlendListByBool>(0x8F88);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_608967D341396C375859EA9504AA37BF
		/// Type: StructProperty
		/// Offset: 0x9058
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_608967D341396C375859EA9504AA37BF => ReadStruct<FAnimNode_SequencePlayer>(0x9058);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_7A83D97A4AF225AD21132DA481581972
		/// Type: StructProperty
		/// Offset: 0x90C8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_7A83D97A4AF225AD21132DA481581972 => ReadStruct<FAnimNode_SequencePlayer>(0x90C8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_D82C96EE4AA8990E1C74AB9F7B85A6B0
		/// Type: StructProperty
		/// Offset: 0x9138
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_D82C96EE4AA8990E1C74AB9F7B85A6B0 => ReadStruct<FAnimNode_BlendListByBool>(0x9138);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_D57BD37247DE2BC025685489C8525B4C
		/// Type: StructProperty
		/// Offset: 0x9208
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_D57BD37247DE2BC025685489C8525B4C => ReadStruct<FAnimNode_BlendListByBool>(0x9208);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_3D0AF0FD4B688F5828730F97745BF76A
		/// Type: StructProperty
		/// Offset: 0x92D8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_3D0AF0FD4B688F5828730F97745BF76A => ReadStruct<FAnimNode_SequencePlayer>(0x92D8);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_6DE8E23F4FEF8ED5406DF4AB6DED676F
		/// Type: StructProperty
		/// Offset: 0x9348
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_6DE8E23F4FEF8ED5406DF4AB6DED676F => ReadStruct<FAnimNode_LayeredBoneBlend>(0x9348);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_BCFC9E334CA3BB094658168A12791961
		/// Type: StructProperty
		/// Offset: 0x93E8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_BCFC9E334CA3BB094658168A12791961 => ReadStruct<FAnimNode_SequencePlayer>(0x93E8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_F77A59844DCF0807B1027A8A6B163841
		/// Type: StructProperty
		/// Offset: 0x9458
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_F77A59844DCF0807B1027A8A6B163841 => ReadStruct<FAnimNode_SequencePlayer>(0x9458);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_45DD955646C993F05F1A98AADB2CDE59
		/// Type: StructProperty
		/// Offset: 0x94C8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_45DD955646C993F05F1A98AADB2CDE59 => ReadStruct<FAnimNode_BlendListByBool>(0x94C8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_CEA13F8F4441A3876AF5A4ADCD9AA17C
		/// Type: StructProperty
		/// Offset: 0x9598
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_CEA13F8F4441A3876AF5A4ADCD9AA17C => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9598);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_F52DEEB44FDE83498ED68C86C52BA445
		/// Type: StructProperty
		/// Offset: 0x96C8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_F52DEEB44FDE83498ED68C86C52BA445 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x96C8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_5BD5F0934C98BA36F1BE55B0BE4C900B
		/// Type: StructProperty
		/// Offset: 0x9768
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_5BD5F0934C98BA36F1BE55B0BE4C900B => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9768);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_F6BA0A5740A2DC93271A0785D6322CEF
		/// Type: StructProperty
		/// Offset: 0x9898
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_F6BA0A5740A2DC93271A0785D6322CEF => ReadStruct<FAnimNode_BlendListByBool>(0x9898);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_F1E3D565484C82C299E8C6A77F375AE0
		/// Type: StructProperty
		/// Offset: 0x9968
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_F1E3D565484C82C299E8C6A77F375AE0 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9968);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_0F0DE00D41E484C1795E42B8256C050C
		/// Type: StructProperty
		/// Offset: 0x9A98
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_0F0DE00D41E484C1795E42B8256C050C => ReadStruct<FAnimNode_BlendListByBool>(0x9A98);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_4D8338E74D6E3D12C5EA78A398F075BE
		/// Type: StructProperty
		/// Offset: 0x9B68
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_4D8338E74D6E3D12C5EA78A398F075BE => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9B68);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_E7DCAFDF4ABE6D5FFCDF7D859D4C975C
		/// Type: StructProperty
		/// Offset: 0x9C98
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_E7DCAFDF4ABE6D5FFCDF7D859D4C975C => ReadStruct<FAnimNode_LayeredBoneBlend>(0x9C98);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_C05D5BB840F59BD8CEC5998DF50A8346
		/// Type: StructProperty
		/// Offset: 0x9D38
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_C05D5BB840F59BD8CEC5998DF50A8346 => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9D38);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_3CA957D1482A4DA0AA7DFA829C611A59
		/// Type: StructProperty
		/// Offset: 0x9E68
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_3CA957D1482A4DA0AA7DFA829C611A59 => ReadStruct<FAnimNode_BlendListByBool>(0x9E68);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_EEAF5E4348CC2AC417BA09A0E510B68B
		/// Type: StructProperty
		/// Offset: 0x9F38
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_EEAF5E4348CC2AC417BA09A0E510B68B => ReadStruct<FAnimNode_BlendSpacePlayer>(0x9F38);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_AE8B328A4CD9D0C3AFA5F6BF9DA69F50
		/// Type: StructProperty
		/// Offset: 0xA068
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_AE8B328A4CD9D0C3AFA5F6BF9DA69F50 => ReadStruct<FAnimNode_BlendListByBool>(0xA068);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_04A71405473AA59DB9624CAF8CD152C8
		/// Type: StructProperty
		/// Offset: 0xA138
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_04A71405473AA59DB9624CAF8CD152C8 => ReadStruct<FAnimNode_BlendSpacePlayer>(0xA138);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_1ED6F60F44C94C1C689A948AEF81D66B
		/// Type: StructProperty
		/// Offset: 0xA268
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_1ED6F60F44C94C1C689A948AEF81D66B => ReadStruct<FAnimNode_BlendListByBool>(0xA268);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_FAC6B1694CCD6F67806F13841E0BDF06
		/// Type: StructProperty
		/// Offset: 0xA338
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_FAC6B1694CCD6F67806F13841E0BDF06 => ReadStruct<FAnimNode_BlendSpacePlayer>(0xA338);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_010CDBE54F6B69B4F9278FB7FBD3A4AB
		/// Type: StructProperty
		/// Offset: 0xA468
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_010CDBE54F6B69B4F9278FB7FBD3A4AB => ReadStruct<FAnimNode_SequencePlayer>(0xA468);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_F6D3E9ED4D3E8F41EA26459287B10E16
		/// Type: StructProperty
		/// Offset: 0xA4D8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_F6D3E9ED4D3E8F41EA26459287B10E16 => ReadStruct<FAnimNode_LayeredBoneBlend>(0xA4D8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_15A2A5884C2B2DAE1C4576AE1CE60951
		/// Type: StructProperty
		/// Offset: 0xA578
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_15A2A5884C2B2DAE1C4576AE1CE60951 => ReadStruct<FAnimNode_Root>(0xA578);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_7395CE344B2A880019C2C1839BA41CB1
		/// Type: StructProperty
		/// Offset: 0xA5C0
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_7395CE344B2A880019C2C1839BA41CB1 => ReadStruct<FAnimNode_StateMachine>(0xA5C0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_CB9EEC4341CBBB1BA32A35A39BBD3AFD
		/// Type: StructProperty
		/// Offset: 0xA698
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_CB9EEC4341CBBB1BA32A35A39BBD3AFD => ReadStruct<FAnimNode_Root>(0xA698);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_2ACE1C1D467DF9206ACE3CB294EE5780
		/// Type: StructProperty
		/// Offset: 0xA6E0
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_2ACE1C1D467DF9206ACE3CB294EE5780 => ReadStruct<FAnimNode_StateMachine>(0xA6E0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_0EB244D049CF356863E91190FB491E77
		/// Type: StructProperty
		/// Offset: 0xA7B8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_0EB244D049CF356863E91190FB491E77 => ReadStruct<FAnimNode_Root>(0xA7B8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_3097B909478B5DA5E3279C83C741EC10
		/// Type: StructProperty
		/// Offset: 0xA800
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_3097B909478B5DA5E3279C83C741EC10 => ReadStruct<FAnimNode_StateMachine>(0xA800);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_79FAFC5A494CACA7F882AEAEC0431A32
		/// Type: StructProperty
		/// Offset: 0xA8D8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_79FAFC5A494CACA7F882AEAEC0431A32 => ReadStruct<FAnimNode_Root>(0xA8D8);
		
		/// <summary>
		/// Name: AnimGraphNode_BoneDrivenController_4A7AC53B4FE5022007E7BC8B16A36096
		/// Type: StructProperty
		/// Offset: 0xA920
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_BoneDrivenController AnimGraphNode_BoneDrivenController_4A7AC53B4FE5022007E7BC8B16A36096 => ReadStruct<FAnimNode_BoneDrivenController>(0xA920);
		
		/// <summary>
		/// Name: AnimGraphNode_BoneDrivenController_FF4934F64B5D4C319C6FE690BAB467EE
		/// Type: StructProperty
		/// Offset: 0xA9F8
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_BoneDrivenController AnimGraphNode_BoneDrivenController_FF4934F64B5D4C319C6FE690BAB467EE => ReadStruct<FAnimNode_BoneDrivenController>(0xA9F8);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_E9561F4A4DE67BFF3FF27BBE2571A1DE
		/// Type: StructProperty
		/// Offset: 0xAAD0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_E9561F4A4DE67BFF3FF27BBE2571A1DE => ReadStruct<FAnimNode_UseCachedPose>(0xAAD0);
		
		/// <summary>
		/// Name: CombatBP
		/// Type: ObjectProperty
		/// Offset: 0xAB18
		/// Size: 0x08
		/// </summary>
		public ABaseBPCombat_C CombatBP => ReadUObject<ABaseBPCombat_C>(0xAB18);
		
		/// <summary>
		/// Name: Speed
		/// Type: FloatProperty
		/// Offset: 0xAB20
		/// Size: 0x04
		/// </summary>
		public float Speed
		{
			get
			{
				return ReadSingle(0xAB20);
			}
			set
			{
				WriteSingle(0xAB20,value);
			}
		}
		
		/// <summary>
		/// Name: EnableAttack
		/// Type: BoolProperty
		/// Offset: 0xAB24
		/// Size: 0x01
		/// </summary>
		public bool EnableAttack
		{
			get
			{
				return ReadBool(0xAB24);
			}
			set
			{
				WriteBool(0xAB24,value);
			}
		}
		
		/// <summary>
		/// Name: Defend
		/// Type: BoolProperty
		/// Offset: 0xAB25
		/// Size: 0x01
		/// </summary>
		public bool Defend
		{
			get
			{
				return ReadBool(0xAB25);
			}
			set
			{
				WriteBool(0xAB25,value);
			}
		}
		
		/// <summary>
		/// Name: bLocked
		/// Type: BoolProperty
		/// Offset: 0xAB26
		/// Size: 0x01
		/// </summary>
		public bool bLocked
		{
			get
			{
				return ReadBool(0xAB26);
			}
			set
			{
				WriteBool(0xAB26,value);
			}
		}
		
		/// <summary>
		/// Name: GuardBreaking
		/// Type: BoolProperty
		/// Offset: 0xAB27
		/// Size: 0x01
		/// </summary>
		public bool GuardBreaking
		{
			get
			{
				return ReadBool(0xAB27);
			}
			set
			{
				WriteBool(0xAB27,value);
			}
		}
		
		/// <summary>
		/// Name: GlobalAnimEndFraction
		/// Type: FloatProperty
		/// Offset: 0xAB28
		/// Size: 0x04
		/// </summary>
		public float GlobalAnimEndFraction
		{
			get
			{
				return ReadSingle(0xAB28);
			}
			set
			{
				WriteSingle(0xAB28,value);
			}
		}
		
		/// <summary>
		/// Name: Direction
		/// Type: FloatProperty
		/// Offset: 0xAB2C
		/// Size: 0x04
		/// </summary>
		public float Direction
		{
			get
			{
				return ReadSingle(0xAB2C);
			}
			set
			{
				WriteSingle(0xAB2C,value);
			}
		}
		
		/// <summary>
		/// Name: Yaw
		/// Type: FloatProperty
		/// Offset: 0xAB30
		/// Size: 0x04
		/// </summary>
		public float Yaw
		{
			get
			{
				return ReadSingle(0xAB30);
			}
			set
			{
				WriteSingle(0xAB30,value);
			}
		}
		
		/// <summary>
		/// Name: Pitch
		/// Type: FloatProperty
		/// Offset: 0xAB34
		/// Size: 0x04
		/// </summary>
		public float Pitch
		{
			get
			{
				return ReadSingle(0xAB34);
			}
			set
			{
				WriteSingle(0xAB34,value);
			}
		}
		
		/// <summary>
		/// Name: ControlRotation
		/// Type: StructProperty
		/// Offset: 0xAB38
		/// Size: 0x0C
		/// </summary>
		public FRotator ControlRotation => ReadStruct<FRotator>(0xAB38);
		
		/// <summary>
		/// Name: SpeedXY
		/// Type: FloatProperty
		/// Offset: 0xAB44
		/// Size: 0x04
		/// </summary>
		public float SpeedXY
		{
			get
			{
				return ReadSingle(0xAB44);
			}
			set
			{
				WriteSingle(0xAB44,value);
			}
		}
		
		/// <summary>
		/// Name: DoneWithKnockback
		/// Type: BoolProperty
		/// Offset: 0xAB48
		/// Size: 0x01
		/// </summary>
		public bool DoneWithKnockback
		{
			get
			{
				return ReadBool(0xAB48);
			}
			set
			{
				WriteBool(0xAB48,value);
			}
		}
		
		/// <summary>
		/// Name: ReceivedEnableQueueEvent
		/// Type: BoolProperty
		/// Offset: 0xAB49
		/// Size: 0x01
		/// </summary>
		public bool ReceivedEnableQueueEvent
		{
			get
			{
				return ReadBool(0xAB49);
			}
			set
			{
				WriteBool(0xAB49,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponPrimary
		/// Type: ObjectProperty
		/// Offset: 0xAB50
		/// Size: 0x08
		/// </summary>
		public UBlendSpace WeaponPrimary => ReadUObject<UBlendSpace>(0xAB50);
		
		/// <summary>
		/// Name: WeaponSecondary
		/// Type: ObjectProperty
		/// Offset: 0xAB58
		/// Size: 0x08
		/// </summary>
		public UBlendSpace WeaponSecondary => ReadUObject<UBlendSpace>(0xAB58);
		
		/// <summary>
		/// Name: IsFalling
		/// Type: BoolProperty
		/// Offset: 0xAB60
		/// Size: 0x01
		/// </summary>
		public bool IsFalling
		{
			get
			{
				return ReadBool(0xAB60);
			}
			set
			{
				WriteBool(0xAB60,value);
			}
		}
		
		/// <summary>
		/// Name: CachedBust
		/// Type: FloatProperty
		/// Offset: 0xAB64
		/// Size: 0x04
		/// </summary>
		public float CachedBust
		{
			get
			{
				return ReadSingle(0xAB64);
			}
			set
			{
				WriteSingle(0xAB64,value);
			}
		}
		
		/// <summary>
		/// Name: UpdateCharacterCustomization
		/// Type: BoolProperty
		/// Offset: 0xAB68
		/// Size: 0x01
		/// </summary>
		public bool UpdateCharacterCustomization
		{
			get
			{
				return ReadBool(0xAB68);
			}
			set
			{
				WriteBool(0xAB68,value);
			}
		}
		
		/// <summary>
		/// Name: headrotator
		/// Type: StructProperty
		/// Offset: 0xAB6C
		/// Size: 0x0C
		/// </summary>
		public FRotator headrotator => ReadStruct<FRotator>(0xAB6C);
		
		/// <summary>
		/// Name: bTurnRight
		/// Type: BoolProperty
		/// Offset: 0xAB78
		/// Size: 0x01
		/// </summary>
		public bool bTurnRight
		{
			get
			{
				return ReadBool(0xAB78);
			}
			set
			{
				WriteBool(0xAB78,value);
			}
		}
		
		/// <summary>
		/// Name: bTurnLeft
		/// Type: BoolProperty
		/// Offset: 0xAB79
		/// Size: 0x01
		/// </summary>
		public bool bTurnLeft
		{
			get
			{
				return ReadBool(0xAB79);
			}
			set
			{
				WriteBool(0xAB79,value);
			}
		}
		
		/// <summary>
		/// Name: EquipedGameItemPrimary
		/// Type: ObjectProperty
		/// Offset: 0xAB80
		/// Size: 0x08
		/// </summary>
		public UGameItem EquipedGameItemPrimary => ReadUObject<UGameItem>(0xAB80);
		
		/// <summary>
		/// Name: EquipedGameItemSecondary
		/// Type: ObjectProperty
		/// Offset: 0xAB88
		/// Size: 0x08
		/// </summary>
		public UGameItem EquipedGameItemSecondary => ReadUObject<UGameItem>(0xAB88);
		
		/// <summary>
		/// Name: EquipedGameItemGreat
		/// Type: ObjectProperty
		/// Offset: 0xAB90
		/// Size: 0x08
		/// </summary>
		public UGameItem EquipedGameItemGreat => ReadUObject<UGameItem>(0xAB90);
		
		/// <summary>
		/// Name: ItemSwapTimerPrimary
		/// Type: StructProperty
		/// Offset: 0xAB98
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ItemSwapTimerPrimary => ReadStruct<FTimerHandle>(0xAB98);
		
		/// <summary>
		/// Name: ItemSwapTimerSecondary
		/// Type: StructProperty
		/// Offset: 0xABA0
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ItemSwapTimerSecondary => ReadStruct<FTimerHandle>(0xABA0);
		
		/// <summary>
		/// Name: ItemSwapTimerGreat
		/// Type: StructProperty
		/// Offset: 0xABA8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ItemSwapTimerGreat => ReadStruct<FTimerHandle>(0xABA8);
		
		/// <summary>
		/// Name: ItemStateDecrement
		/// Type: IntProperty
		/// Offset: 0xABB0
		/// Size: 0x04
		/// </summary>
		public int ItemStateDecrement
		{
			get
			{
				return ReadInt32(0xABB0);
			}
			set
			{
				WriteInt32(0xABB0,value);
			}
		}
		
		/// <summary>
		/// Name: ItemStateCharacterReloadProjectile
		/// Type: ObjectProperty
		/// Offset: 0xABC8
		/// Size: 0x08
		/// </summary>
		public AStaticMeshActor ItemStateCharacterReloadProjectile => ReadUObject<AStaticMeshActor>(0xABC8);
		
		/// <summary>
		/// Name: ItemStateWeaponReloadProjectile
		/// Type: ObjectProperty
		/// Offset: 0xABD0
		/// Size: 0x08
		/// </summary>
		public ABP_BaseProjectile_C ItemStateWeaponReloadProjectile => ReadUObject<ABP_BaseProjectile_C>(0xABD0);
		
		/// <summary>
		/// Name: ItemStateGreat
		/// Type: ObjectProperty
		/// Offset: 0xABD8
		/// Size: 0x08
		/// </summary>
		public UGameItem ItemStateGreat => ReadUObject<UGameItem>(0xABD8);
		
		/// <summary>
		/// Name: ItemStateSecondary
		/// Type: ObjectProperty
		/// Offset: 0xABE0
		/// Size: 0x08
		/// </summary>
		public UGameItem ItemStateSecondary => ReadUObject<UGameItem>(0xABE0);
		
		/// <summary>
		/// Name: ItemStatePrimary
		/// Type: ObjectProperty
		/// Offset: 0xABE8
		/// Size: 0x08
		/// </summary>
		public UGameItem ItemStatePrimary => ReadUObject<UGameItem>(0xABE8);
		
		/// <summary>
		/// Name: WeaponItemPrimary_cached
		/// Type: ObjectProperty
		/// Offset: 0xABF0
		/// Size: 0x08
		/// </summary>
		public UBPGameItemWeapon_C WeaponItemPrimary_cached => ReadUObject<UBPGameItemWeapon_C>(0xABF0);
		
		/// <summary>
		/// Name: IsGreatWeaponEquipped_cached
		/// Type: BoolProperty
		/// Offset: 0xABF8
		/// Size: 0x01
		/// </summary>
		public bool IsGreatWeaponEquipped_cached
		{
			get
			{
				return ReadBool(0xABF8);
			}
			set
			{
				WriteBool(0xABF8,value);
			}
		}
		
		/// <summary>
		/// Name: rightKnee
		/// Type: StructProperty
		/// Offset: 0xABFC
		/// Size: 0x0C
		/// </summary>
		public FVector rightKnee => ReadStruct<FVector>(0xABFC);
		
		/// <summary>
		/// Name: LeftKnee
		/// Type: StructProperty
		/// Offset: 0xAC08
		/// Size: 0x0C
		/// </summary>
		public FVector LeftKnee => ReadStruct<FVector>(0xAC08);
		
		/// <summary>
		/// Name: OldHipOffset
		/// Type: FloatProperty
		/// Offset: 0xAC14
		/// Size: 0x04
		/// </summary>
		public float OldHipOffset
		{
			get
			{
				return ReadSingle(0xAC14);
			}
			set
			{
				WriteSingle(0xAC14,value);
			}
		}
		
		/// <summary>
		/// Name: HipTarget
		/// Type: StructProperty
		/// Offset: 0xAC18
		/// Size: 0x0C
		/// </summary>
		public FVector HipTarget => ReadStruct<FVector>(0xAC18);
		
		/// <summary>
		/// Name: isSecondaryAllowedToAnimate
		/// Type: BoolProperty
		/// Offset: 0xAC24
		/// Size: 0x01
		/// </summary>
		public bool isSecondaryAllowedToAnimate
		{
			get
			{
				return ReadBool(0xAC24);
			}
			set
			{
				WriteBool(0xAC24,value);
			}
		}
		
		/// <summary>
		/// Name: isMoving
		/// Type: BoolProperty
		/// Offset: 0xAC25
		/// Size: 0x01
		/// </summary>
		public bool isMoving
		{
			get
			{
				return ReadBool(0xAC25);
			}
			set
			{
				WriteBool(0xAC25,value);
			}
		}
		
		/// <summary>
		/// Name: isCombat
		/// Type: BoolProperty
		/// Offset: 0xAC26
		/// Size: 0x01
		/// </summary>
		public bool isCombat
		{
			get
			{
				return ReadBool(0xAC26);
			}
			set
			{
				WriteBool(0xAC26,value);
			}
		}
		
		/// <summary>
		/// Name: CombatMovement
		/// Type: ObjectProperty
		/// Offset: 0xAC28
		/// Size: 0x08
		/// </summary>
		public UBlendSpace CombatMovement => ReadUObject<UBlendSpace>(0xAC28);
		
		/// <summary>
		/// Name: boob_physics_alpha
		/// Type: FloatProperty
		/// Offset: 0xAD20
		/// Size: 0x04
		/// </summary>
		public float boob_physics_alpha
		{
			get
			{
				return ReadSingle(0xAD20);
			}
			set
			{
				WriteSingle(0xAD20,value);
			}
		}
		
		/// <summary>
		/// Name: chin_width
		/// Type: FloatProperty
		/// Offset: 0xAD24
		/// Size: 0x04
		/// </summary>
		public float chin_width
		{
			get
			{
				return ReadSingle(0xAD24);
			}
			set
			{
				WriteSingle(0xAD24,value);
			}
		}
		
		/// <summary>
		/// Name: eye_size
		/// Type: FloatProperty
		/// Offset: 0xAD28
		/// Size: 0x04
		/// </summary>
		public float eye_size
		{
			get
			{
				return ReadSingle(0xAD28);
			}
			set
			{
				WriteSingle(0xAD28,value);
			}
		}
		
		/// <summary>
		/// Name: cheek_width
		/// Type: FloatProperty
		/// Offset: 0xAD2C
		/// Size: 0x04
		/// </summary>
		public float cheek_width
		{
			get
			{
				return ReadSingle(0xAD2C);
			}
			set
			{
				WriteSingle(0xAD2C,value);
			}
		}
		
		/// <summary>
		/// Name: jaw_width
		/// Type: FloatProperty
		/// Offset: 0xAD30
		/// Size: 0x04
		/// </summary>
		public float jaw_width
		{
			get
			{
				return ReadSingle(0xAD30);
			}
			set
			{
				WriteSingle(0xAD30,value);
			}
		}
		
		/// <summary>
		/// Name: nose_width
		/// Type: FloatProperty
		/// Offset: 0xAD34
		/// Size: 0x04
		/// </summary>
		public float nose_width
		{
			get
			{
				return ReadSingle(0xAD34);
			}
			set
			{
				WriteSingle(0xAD34,value);
			}
		}
		
		/// <summary>
		/// Name: nosetip_size
		/// Type: FloatProperty
		/// Offset: 0xAD38
		/// Size: 0x04
		/// </summary>
		public float nosetip_size
		{
			get
			{
				return ReadSingle(0xAD38);
			}
			set
			{
				WriteSingle(0xAD38,value);
			}
		}
		
		/// <summary>
		/// Name: nosetip_curve
		/// Type: FloatProperty
		/// Offset: 0xAD3C
		/// Size: 0x04
		/// </summary>
		public float nosetip_curve
		{
			get
			{
				return ReadSingle(0xAD3C);
			}
			set
			{
				WriteSingle(0xAD3C,value);
			}
		}
		
		/// <summary>
		/// Name: eye_angle
		/// Type: FloatProperty
		/// Offset: 0xAD40
		/// Size: 0x04
		/// </summary>
		public float eye_angle
		{
			get
			{
				return ReadSingle(0xAD40);
			}
			set
			{
				WriteSingle(0xAD40,value);
			}
		}
		
		/// <summary>
		/// Name: ear_size
		/// Type: FloatProperty
		/// Offset: 0xAD44
		/// Size: 0x04
		/// </summary>
		public float ear_size
		{
			get
			{
				return ReadSingle(0xAD44);
			}
			set
			{
				WriteSingle(0xAD44,value);
			}
		}
		
		/// <summary>
		/// Name: ear_angle
		/// Type: FloatProperty
		/// Offset: 0xAD48
		/// Size: 0x04
		/// </summary>
		public float ear_angle
		{
			get
			{
				return ReadSingle(0xAD48);
			}
			set
			{
				WriteSingle(0xAD48,value);
			}
		}
		
		/// <summary>
		/// Name: realign_jaw
		/// Type: FloatProperty
		/// Offset: 0xAD4C
		/// Size: 0x04
		/// </summary>
		public float realign_jaw
		{
			get
			{
				return ReadSingle(0xAD4C);
			}
			set
			{
				WriteSingle(0xAD4C,value);
			}
		}
		
		/// <summary>
		/// Name: eye_horizontalpos
		/// Type: FloatProperty
		/// Offset: 0xAD50
		/// Size: 0x04
		/// </summary>
		public float eye_horizontalpos
		{
			get
			{
				return ReadSingle(0xAD50);
			}
			set
			{
				WriteSingle(0xAD50,value);
			}
		}
		
		/// <summary>
		/// Name: cheek_height
		/// Type: FloatProperty
		/// Offset: 0xAD54
		/// Size: 0x04
		/// </summary>
		public float cheek_height
		{
			get
			{
				return ReadSingle(0xAD54);
			}
			set
			{
				WriteSingle(0xAD54,value);
			}
		}
		
		/// <summary>
		/// Name: penis_scale
		/// Type: FloatProperty
		/// Offset: 0xAD58
		/// Size: 0x04
		/// </summary>
		public float penis_scale
		{
			get
			{
				return ReadSingle(0xAD58);
			}
			set
			{
				WriteSingle(0xAD58,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentPlayingEmoteMontage
		/// Type: ObjectProperty
		/// Offset: 0xAD60
		/// Size: 0x08
		/// </summary>
		public UAnimMontage CurrentPlayingEmoteMontage => ReadUObject<UAnimMontage>(0xAD60);
		
		/// <summary>
		/// Name: AttackMontageActive
		/// Type: ObjectProperty
		/// Offset: 0xAD68
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontageActive => ReadUObject<UAnimMontage>(0xAD68);
		
		/// <summary>
		/// Name: AttackMontagePrevious
		/// Type: ObjectProperty
		/// Offset: 0xAD70
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontagePrevious => ReadUObject<UAnimMontage>(0xAD70);
		
		/// <summary>
		/// Name: ChainAttackTimer
		/// Type: StructProperty
		/// Offset: 0xAD78
		/// Size: 0x08
		/// </summary>
		public FTimerHandle ChainAttackTimer => ReadStruct<FTimerHandle>(0xAD78);
		
		/// <summary>
		/// Name: AttackMontageQueued
		/// Type: ObjectProperty
		/// Offset: 0xAD80
		/// Size: 0x08
		/// </summary>
		public UAnimMontage AttackMontageQueued => ReadUObject<UAnimMontage>(0xAD80);
		
		/// <summary>
		/// Name: CharacterLayoutHash
		/// Type: IntProperty
		/// Offset: 0xAD88
		/// Size: 0x04
		/// </summary>
		public int CharacterLayoutHash
		{
			get
			{
				return ReadInt32(0xAD88);
			}
			set
			{
				WriteInt32(0xAD88,value);
			}
		}
		
		/// <summary>
		/// Name: CharCustomization
		/// Type: ObjectProperty
		/// Offset: 0xAD90
		/// Size: 0x08
		/// </summary>
		public UCharacterCustomizationComponent CharCustomization => ReadUObject<UCharacterCustomizationComponent>(0xAD90);
		
		/// <summary>
		/// Name: BuildSystem
		/// Type: ObjectProperty
		/// Offset: 0xAD98
		/// Size: 0x08
		/// </summary>
		public UBP_BuildSystem_v2_C BuildSystem => ReadUObject<UBP_BuildSystem_v2_C>(0xAD98);
		
		/// <summary>
		/// Name: isPickup
		/// Type: BoolProperty
		/// Offset: 0xADA0
		/// Size: 0x01
		/// </summary>
		public bool isPickup
		{
			get
			{
				return ReadBool(0xADA0);
			}
			set
			{
				WriteBool(0xADA0,value);
			}
		}
		
		/// <summary>
		/// Name: EquipMontageCurrentlyPlaying
		/// Type: ObjectProperty
		/// Offset: 0xADA8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage EquipMontageCurrentlyPlaying => ReadUObject<UAnimMontage>(0xADA8);
		
		/// <summary>
		/// Name: DodgeLeft_1st
		/// Type: ObjectProperty
		/// Offset: 0xADB0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeLeft_1st => ReadUObject<UAnimMontage>(0xADB0);
		
		/// <summary>
		/// Name: DodgeRight_1st
		/// Type: ObjectProperty
		/// Offset: 0xADB8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeRight_1st => ReadUObject<UAnimMontage>(0xADB8);
		
		/// <summary>
		/// Name: DodgeBack_1st
		/// Type: ObjectProperty
		/// Offset: 0xADC0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeBack_1st => ReadUObject<UAnimMontage>(0xADC0);
		
		/// <summary>
		/// Name: DodgeLeft_3rd
		/// Type: ObjectProperty
		/// Offset: 0xADC8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeLeft_3rd => ReadUObject<UAnimMontage>(0xADC8);
		
		/// <summary>
		/// Name: DodgeRight_3rd
		/// Type: ObjectProperty
		/// Offset: 0xADD0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeRight_3rd => ReadUObject<UAnimMontage>(0xADD0);
		
		/// <summary>
		/// Name: DodgeBack_3rd
		/// Type: ObjectProperty
		/// Offset: 0xADD8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeBack_3rd => ReadUObject<UAnimMontage>(0xADD8);
		
		/// <summary>
		/// Name: DodgeCurrent
		/// Type: ObjectProperty
		/// Offset: 0xADE0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage DodgeCurrent => ReadUObject<UAnimMontage>(0xADE0);
		
		/// <summary>
		/// Name: DodgeTimer
		/// Type: StructProperty
		/// Offset: 0xADE8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle DodgeTimer => ReadStruct<FTimerHandle>(0xADE8);
		
		/// <summary>
		/// Name: RightFootIKTarget
		/// Type: StructProperty
		/// Offset: 0xADF0
		/// Size: 0x0C
		/// </summary>
		public FVector RightFootIKTarget => ReadStruct<FVector>(0xADF0);
		
		/// <summary>
		/// Name: LeftFootIKTarget
		/// Type: StructProperty
		/// Offset: 0xADFC
		/// Size: 0x0C
		/// </summary>
		public FVector LeftFootIKTarget => ReadStruct<FVector>(0xADFC);
		
		/// <summary>
		/// Name: RightFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE08
		/// Size: 0x04
		/// </summary>
		public float RightFootIKAlpha
		{
			get
			{
				return ReadSingle(0xAE08);
			}
			set
			{
				WriteSingle(0xAE08,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE0C
		/// Size: 0x04
		/// </summary>
		public float LeftFootIKAlpha
		{
			get
			{
				return ReadSingle(0xAE0C);
			}
			set
			{
				WriteSingle(0xAE0C,value);
			}
		}
		
		/// <summary>
		/// Name: RightFootIKOffset
		/// Type: FloatProperty
		/// Offset: 0xAE10
		/// Size: 0x04
		/// </summary>
		public float RightFootIKOffset
		{
			get
			{
				return ReadSingle(0xAE10);
			}
			set
			{
				WriteSingle(0xAE10,value);
			}
		}
		
		/// <summary>
		/// Name: LeftFootIKOffset
		/// Type: FloatProperty
		/// Offset: 0xAE14
		/// Size: 0x04
		/// </summary>
		public float LeftFootIKOffset
		{
			get
			{
				return ReadSingle(0xAE14);
			}
			set
			{
				WriteSingle(0xAE14,value);
			}
		}
		
		/// <summary>
		/// Name: HipsOffset
		/// Type: StructProperty
		/// Offset: 0xAE18
		/// Size: 0x0C
		/// </summary>
		public FVector HipsOffset => ReadStruct<FVector>(0xAE18);
		
		/// <summary>
		/// Name: HipsAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE24
		/// Size: 0x04
		/// </summary>
		public float HipsAlpha
		{
			get
			{
				return ReadSingle(0xAE24);
			}
			set
			{
				WriteSingle(0xAE24,value);
			}
		}
		
		/// <summary>
		/// Name: OldHipsTarget
		/// Type: StructProperty
		/// Offset: 0xAE28
		/// Size: 0x0C
		/// </summary>
		public FVector OldHipsTarget => ReadStruct<FVector>(0xAE28);
		
		/// <summary>
		/// Name: HipsOffsetDistance
		/// Type: FloatProperty
		/// Offset: 0xAE34
		/// Size: 0x04
		/// </summary>
		public float HipsOffsetDistance
		{
			get
			{
				return ReadSingle(0xAE34);
			}
			set
			{
				WriteSingle(0xAE34,value);
			}
		}
		
		/// <summary>
		/// Name: ShouldRunIK
		/// Type: BoolProperty
		/// Offset: 0xAE38
		/// Size: 0x01
		/// </summary>
		public bool ShouldRunIK
		{
			get
			{
				return ReadBool(0xAE38);
			}
			set
			{
				WriteBool(0xAE38,value);
			}
		}
		
		/// <summary>
		/// Name: OldRightFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE3C
		/// Size: 0x04
		/// </summary>
		public float OldRightFootIKAlpha
		{
			get
			{
				return ReadSingle(0xAE3C);
			}
			set
			{
				WriteSingle(0xAE3C,value);
			}
		}
		
		/// <summary>
		/// Name: OldLeftFootIKAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE40
		/// Size: 0x04
		/// </summary>
		public float OldLeftFootIKAlpha
		{
			get
			{
				return ReadSingle(0xAE40);
			}
			set
			{
				WriteSingle(0xAE40,value);
			}
		}
		
		/// <summary>
		/// Name: IsNPC
		/// Type: BoolProperty
		/// Offset: 0xAE44
		/// Size: 0x01
		/// </summary>
		public bool IsNPC
		{
			get
			{
				return ReadBool(0xAE44);
			}
			set
			{
				WriteBool(0xAE44,value);
			}
		}
		
		/// <summary>
		/// Name: AttackActionType
		/// Type: ByteProperty
		/// Offset: 0xAE45
		/// Size: 0x01
		/// </summary>
		public byte AttackActionType
		{
			get
			{
				return ReadByte(0xAE45);
			}
			set
			{
				WriteByte(0xAE45,value);
			}
		}
		
		/// <summary>
		/// Name: isPassive
		/// Type: BoolProperty
		/// Offset: 0xAE46
		/// Size: 0x01
		/// </summary>
		public bool isPassive
		{
			get
			{
				return ReadBool(0xAE46);
			}
			set
			{
				WriteBool(0xAE46,value);
			}
		}
		
		/// <summary>
		/// Name: isAggressive
		/// Type: BoolProperty
		/// Offset: 0xAE47
		/// Size: 0x01
		/// </summary>
		public bool isAggressive
		{
			get
			{
				return ReadBool(0xAE47);
			}
			set
			{
				WriteBool(0xAE47,value);
			}
		}
		
		/// <summary>
		/// Name: IsThirdPerson
		/// Type: BoolProperty
		/// Offset: 0xAE48
		/// Size: 0x01
		/// </summary>
		public bool IsThirdPerson
		{
			get
			{
				return ReadBool(0xAE48);
			}
			set
			{
				WriteBool(0xAE48,value);
			}
		}
		
		/// <summary>
		/// Name: IsSwimming
		/// Type: BoolProperty
		/// Offset: 0xAE49
		/// Size: 0x01
		/// </summary>
		public bool IsSwimming
		{
			get
			{
				return ReadBool(0xAE49);
			}
			set
			{
				WriteBool(0xAE49,value);
			}
		}
		
		/// <summary>
		/// Name: IsFlying
		/// Type: BoolProperty
		/// Offset: 0xAE4A
		/// Size: 0x01
		/// </summary>
		public bool IsFlying
		{
			get
			{
				return ReadBool(0xAE4A);
			}
			set
			{
				WriteBool(0xAE4A,value);
			}
		}
		
		/// <summary>
		/// Name: IsCrouching
		/// Type: BoolProperty
		/// Offset: 0xAE4B
		/// Size: 0x01
		/// </summary>
		public bool IsCrouching
		{
			get
			{
				return ReadBool(0xAE4B);
			}
			set
			{
				WriteBool(0xAE4B,value);
			}
		}
		
		/// <summary>
		/// Name: isEquipping
		/// Type: BoolProperty
		/// Offset: 0xAE4C
		/// Size: 0x01
		/// </summary>
		public bool isEquipping
		{
			get
			{
				return ReadBool(0xAE4C);
			}
			set
			{
				WriteBool(0xAE4C,value);
			}
		}
		
		/// <summary>
		/// Name: isDead
		/// Type: BoolProperty
		/// Offset: 0xAE4D
		/// Size: 0x01
		/// </summary>
		public bool isDead
		{
			get
			{
				return ReadBool(0xAE4D);
			}
			set
			{
				WriteBool(0xAE4D,value);
			}
		}
		
		/// <summary>
		/// Name: IsUnconscious
		/// Type: BoolProperty
		/// Offset: 0xAE4E
		/// Size: 0x01
		/// </summary>
		public bool IsUnconscious
		{
			get
			{
				return ReadBool(0xAE4E);
			}
			set
			{
				WriteBool(0xAE4E,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponPrimaryUNSAFE
		/// Type: ObjectProperty
		/// Offset: 0xAE50
		/// Size: 0x08
		/// </summary>
		public UBlendSpace WeaponPrimaryUNSAFE => ReadUObject<UBlendSpace>(0xAE50);
		
		/// <summary>
		/// Name: WeaponSecondaryUNSAFE
		/// Type: ObjectProperty
		/// Offset: 0xAE58
		/// Size: 0x08
		/// </summary>
		public UBlendSpace WeaponSecondaryUNSAFE => ReadUObject<UBlendSpace>(0xAE58);
		
		/// <summary>
		/// Name: FirstPersonPelvisHeight
		/// Type: StructProperty
		/// Offset: 0xAE60
		/// Size: 0x0C
		/// </summary>
		public FVector FirstPersonPelvisHeight => ReadStruct<FVector>(0xAE60);
		
		/// <summary>
		/// Name: CrouchingOrMoving
		/// Type: BoolProperty
		/// Offset: 0xAE6C
		/// Size: 0x01
		/// </summary>
		public bool CrouchingOrMoving
		{
			get
			{
				return ReadBool(0xAE6C);
			}
			set
			{
				WriteBool(0xAE6C,value);
			}
		}
		
		/// <summary>
		/// Name: IsCurrentlySitting
		/// Type: BoolProperty
		/// Offset: 0xAE6D
		/// Size: 0x01
		/// </summary>
		public bool IsCurrentlySitting
		{
			get
			{
				return ReadBool(0xAE6D);
			}
			set
			{
				WriteBool(0xAE6D,value);
			}
		}
		
		/// <summary>
		/// Name: SittingPose
		/// Type: ByteProperty
		/// Offset: 0xAE6E
		/// Size: 0x01
		/// </summary>
		public byte SittingPose
		{
			get
			{
				return ReadByte(0xAE6E);
			}
			set
			{
				WriteByte(0xAE6E,value);
			}
		}
		
		/// <summary>
		/// Name: CharacterState
		/// Type: ByteProperty
		/// Offset: 0xAE6F
		/// Size: 0x01
		/// </summary>
		public byte CharacterState
		{
			get
			{
				return ReadByte(0xAE6F);
			}
			set
			{
				WriteByte(0xAE6F,value);
			}
		}
		
		/// <summary>
		/// Name: HeadFOVAdjustments
		/// Type: StructProperty
		/// Offset: 0xAE70
		/// Size: 0x0C
		/// </summary>
		public FVector HeadFOVAdjustments => ReadStruct<FVector>(0xAE70);
		
		/// <summary>
		/// Name: IsWalking
		/// Type: BoolProperty
		/// Offset: 0xAE7C
		/// Size: 0x01
		/// </summary>
		public bool IsWalking
		{
			get
			{
				return ReadBool(0xAE7C);
			}
			set
			{
				WriteBool(0xAE7C,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponPrimaryIdle
		/// Type: ObjectProperty
		/// Offset: 0xAE80
		/// Size: 0x08
		/// </summary>
		public UAnimSequenceBase WeaponPrimaryIdle => ReadUObject<UAnimSequenceBase>(0xAE80);
		
		/// <summary>
		/// Name: WeaponSecondaryIdle
		/// Type: ObjectProperty
		/// Offset: 0xAE88
		/// Size: 0x08
		/// </summary>
		public UAnimSequenceBase WeaponSecondaryIdle => ReadUObject<UAnimSequenceBase>(0xAE88);
		
		/// <summary>
		/// Name: FirstPersonShoulderBobAlpha
		/// Type: FloatProperty
		/// Offset: 0xAE90
		/// Size: 0x04
		/// </summary>
		public float FirstPersonShoulderBobAlpha
		{
			get
			{
				return ReadSingle(0xAE90);
			}
			set
			{
				WriteSingle(0xAE90,value);
			}
		}
		
		/// <summary>
		/// Name: AdjustForLookingUpAndDownFirstPersonAgressive
		/// Type: StructProperty
		/// Offset: 0xAE94
		/// Size: 0x0C
		/// </summary>
		public FRotator AdjustForLookingUpAndDownFirstPersonAgressive => ReadStruct<FRotator>(0xAE94);
		
		/// <summary>
		/// Name: AdjustForLookingUpAndDownThirdPerson
		/// Type: StructProperty
		/// Offset: 0xAEA0
		/// Size: 0x0C
		/// </summary>
		public FRotator AdjustForLookingUpAndDownThirdPerson => ReadStruct<FRotator>(0xAEA0);
		
		/// <summary>
		/// Name: AdjustForLookingUpAndDownFirstPersonPassive
		/// Type: StructProperty
		/// Offset: 0xAEAC
		/// Size: 0x0C
		/// </summary>
		public FRotator AdjustForLookingUpAndDownFirstPersonPassive => ReadStruct<FRotator>(0xAEAC);
		
		/// <summary>
		/// Name: AreLocomotionBlendsNeeded
		/// Type: BoolProperty
		/// Offset: 0xAEB8
		/// Size: 0x01
		/// </summary>
		public bool AreLocomotionBlendsNeeded
		{
			get
			{
				return ReadBool(0xAEB8);
			}
			set
			{
				WriteBool(0xAEB8,value);
			}
		}
		
		/// <summary>
		/// Name: IsWeaponPrimaryIdleAnimValid
		/// Type: BoolProperty
		/// Offset: 0xAEB9
		/// Size: 0x01
		/// </summary>
		public bool IsWeaponPrimaryIdleAnimValid
		{
			get
			{
				return ReadBool(0xAEB9);
			}
			set
			{
				WriteBool(0xAEB9,value);
			}
		}
		
		/// <summary>
		/// Name: IsWeaponSecondaryIdleAnimValid
		/// Type: BoolProperty
		/// Offset: 0xAEBA
		/// Size: 0x01
		/// </summary>
		public bool IsWeaponSecondaryIdleAnimValid
		{
			get
			{
				return ReadBool(0xAEBA);
			}
			set
			{
				WriteBool(0xAEBA,value);
			}
		}
		
		/// <summary>
		/// Name: IsRunning
		/// Type: BoolProperty
		/// Offset: 0xAEBB
		/// Size: 0x01
		/// </summary>
		public bool IsRunning
		{
			get
			{
				return ReadBool(0xAEBB);
			}
			set
			{
				WriteBool(0xAEBB,value);
			}
		}
		
		/// <summary>
		/// Name: IsItemAllowedToAnimate
		/// Type: BoolProperty
		/// Offset: 0xAEBC
		/// Size: 0x01
		/// </summary>
		public bool IsItemAllowedToAnimate
		{
			get
			{
				return ReadBool(0xAEBC);
			}
			set
			{
				WriteBool(0xAEBC,value);
			}
		}
		
		/// <summary>
		/// Name: ForcedBlendspaces
		/// Type: BoolProperty
		/// Offset: 0xAEBD
		/// Size: 0x01
		/// </summary>
		public bool ForcedBlendspaces
		{
			get
			{
				return ReadBool(0xAEBD);
			}
			set
			{
				WriteBool(0xAEBD,value);
			}
		}
		
		/// <summary>
		/// Name: IsNotPassiveOrIsNotWalking
		/// Type: BoolProperty
		/// Offset: 0xAEBE
		/// Size: 0x01
		/// </summary>
		public bool IsNotPassiveOrIsNotWalking
		{
			get
			{
				return ReadBool(0xAEBE);
			}
			set
			{
				WriteBool(0xAEBE,value);
			}
		}
		
		/// <summary>
		/// Name: IsPassiveOrIsWalking
		/// Type: BoolProperty
		/// Offset: 0xAEBF
		/// Size: 0x01
		/// </summary>
		public bool IsPassiveOrIsWalking
		{
			get
			{
				return ReadBool(0xAEBF);
			}
			set
			{
				WriteBool(0xAEBF,value);
			}
		}
		
		/// <summary>
		/// Name: IsAggressiveOrIsEquipping
		/// Type: BoolProperty
		/// Offset: 0xAEC0
		/// Size: 0x01
		/// </summary>
		public bool IsAggressiveOrIsEquipping
		{
			get
			{
				return ReadBool(0xAEC0);
			}
			set
			{
				WriteBool(0xAEC0,value);
			}
		}
		
		/// <summary>
		/// Name: IsLeftFistAndRightWeapon
		/// Type: BoolProperty
		/// Offset: 0xAEC1
		/// Size: 0x01
		/// </summary>
		public bool IsLeftFistAndRightWeapon
		{
			get
			{
				return ReadBool(0xAEC1);
			}
			set
			{
				WriteBool(0xAEC1,value);
			}
		}
		
		/// <summary>
		/// Name: CachedBustScale
		/// Type: StructProperty
		/// Offset: 0xAEC4
		/// Size: 0x0C
		/// </summary>
		public FVector CachedBustScale => ReadStruct<FVector>(0xAEC4);
		
		/// <summary>
		/// Name: EyeSizeScale
		/// Type: StructProperty
		/// Offset: 0xAED0
		/// Size: 0x0C
		/// </summary>
		public FVector EyeSizeScale => ReadStruct<FVector>(0xAED0);
		
		/// <summary>
		/// Name: EyeAngleRotatorRight
		/// Type: StructProperty
		/// Offset: 0xAEDC
		/// Size: 0x0C
		/// </summary>
		public FRotator EyeAngleRotatorRight => ReadStruct<FRotator>(0xAEDC);
		
		/// <summary>
		/// Name: EyeAngleRotatorLeft
		/// Type: StructProperty
		/// Offset: 0xAEE8
		/// Size: 0x0C
		/// </summary>
		public FRotator EyeAngleRotatorLeft => ReadStruct<FRotator>(0xAEE8);
		
		/// <summary>
		/// Name: EyeHorizontalPosRight
		/// Type: StructProperty
		/// Offset: 0xAEF4
		/// Size: 0x0C
		/// </summary>
		public FVector EyeHorizontalPosRight => ReadStruct<FVector>(0xAEF4);
		
		/// <summary>
		/// Name: EyeHorizontalPosLeft
		/// Type: StructProperty
		/// Offset: 0xAF00
		/// Size: 0x0C
		/// </summary>
		public FVector EyeHorizontalPosLeft => ReadStruct<FVector>(0xAF00);
		
		/// <summary>
		/// Name: NoseWidthTranslationRight
		/// Type: StructProperty
		/// Offset: 0xAF0C
		/// Size: 0x0C
		/// </summary>
		public FVector NoseWidthTranslationRight => ReadStruct<FVector>(0xAF0C);
		
		/// <summary>
		/// Name: NoseWidthTranslationLeft
		/// Type: StructProperty
		/// Offset: 0xAF18
		/// Size: 0x0C
		/// </summary>
		public FVector NoseWidthTranslationLeft => ReadStruct<FVector>(0xAF18);
		
		/// <summary>
		/// Name: NoseTipRotator
		/// Type: StructProperty
		/// Offset: 0xAF24
		/// Size: 0x0C
		/// </summary>
		public FRotator NoseTipRotator => ReadStruct<FRotator>(0xAF24);
		
		/// <summary>
		/// Name: NoseTipScale
		/// Type: StructProperty
		/// Offset: 0xAF30
		/// Size: 0x0C
		/// </summary>
		public FVector NoseTipScale => ReadStruct<FVector>(0xAF30);
		
		/// <summary>
		/// Name: JawWidthTranslationRight
		/// Type: StructProperty
		/// Offset: 0xAF3C
		/// Size: 0x0C
		/// </summary>
		public FVector JawWidthTranslationRight => ReadStruct<FVector>(0xAF3C);
		
		/// <summary>
		/// Name: JawWidthTranslationLeft
		/// Type: StructProperty
		/// Offset: 0xAF48
		/// Size: 0x0C
		/// </summary>
		public FVector JawWidthTranslationLeft => ReadStruct<FVector>(0xAF48);
		
		/// <summary>
		/// Name: ChinWidthRotatorRight
		/// Type: StructProperty
		/// Offset: 0xAF54
		/// Size: 0x0C
		/// </summary>
		public FRotator ChinWidthRotatorRight => ReadStruct<FRotator>(0xAF54);
		
		/// <summary>
		/// Name: ChinWidthRotatorLeft
		/// Type: StructProperty
		/// Offset: 0xAF60
		/// Size: 0x0C
		/// </summary>
		public FRotator ChinWidthRotatorLeft => ReadStruct<FRotator>(0xAF60);
		
		/// <summary>
		/// Name: CheekWidthTranslationRight
		/// Type: StructProperty
		/// Offset: 0xAF6C
		/// Size: 0x0C
		/// </summary>
		public FVector CheekWidthTranslationRight => ReadStruct<FVector>(0xAF6C);
		
		/// <summary>
		/// Name: CheekWidthTranslationLeft
		/// Type: StructProperty
		/// Offset: 0xAF78
		/// Size: 0x0C
		/// </summary>
		public FVector CheekWidthTranslationLeft => ReadStruct<FVector>(0xAF78);
		
		/// <summary>
		/// Name: EarSizeScale
		/// Type: StructProperty
		/// Offset: 0xAF84
		/// Size: 0x0C
		/// </summary>
		public FVector EarSizeScale => ReadStruct<FVector>(0xAF84);
		
		/// <summary>
		/// Name: EarAngleRotatorRight
		/// Type: StructProperty
		/// Offset: 0xAF90
		/// Size: 0x0C
		/// </summary>
		public FRotator EarAngleRotatorRight => ReadStruct<FRotator>(0xAF90);
		
		/// <summary>
		/// Name: EarAngleRotatorLeft
		/// Type: StructProperty
		/// Offset: 0xAF9C
		/// Size: 0x0C
		/// </summary>
		public FRotator EarAngleRotatorLeft => ReadStruct<FRotator>(0xAF9C);
		
		/// <summary>
		/// Name: RealignJawRotator
		/// Type: StructProperty
		/// Offset: 0xAFA8
		/// Size: 0x0C
		/// </summary>
		public FRotator RealignJawRotator => ReadStruct<FRotator>(0xAFA8);
		
		/// <summary>
		/// Name: PenisScaleVector
		/// Type: StructProperty
		/// Offset: 0xAFB4
		/// Size: 0x0C
		/// </summary>
		public FVector PenisScaleVector => ReadStruct<FVector>(0xAFB4);
		
	}


	/// <summary>
	/// UAnimationFunctionLibrary_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAnimationFunctionLibrary_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAB_human_female_C:UAB_human_male_C
	/// Size: 0xAFC0
	/// Properties: 0
	/// </summary>
	public class UAB_human_female_C:UAB_human_male_C
	{
		public override int ObjectSize => 44992;
	}


	/// <summary>
	/// UAB_Master_Quadropeds_C:UAnimInstance
	/// Size: 0x14D1
	/// Properties: 73
	/// </summary>
	public class UAB_Master_Quadropeds_C:UAnimInstance
	{
		public override int ObjectSize => 5329;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_E8AFA01A41F2FE5DB37BC5957AD03251
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_E8AFA01A41F2FE5DB37BC5957AD03251 => ReadStruct<FAnimNode_Root>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_4493937B423C88CE5CD990B57109B52A
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_4493937B423C88CE5CD990B57109B52A => ReadStruct<FAnimNode_TransitionResult>(0x4D0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_598BBFF4409936B9217662B997E08F13
		/// Type: StructProperty
		/// Offset: 0x550
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_598BBFF4409936B9217662B997E08F13 => ReadStruct<FAnimNode_SequencePlayer>(0x550);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_ECB4A726493CDB6357E0279F555EACEA
		/// Type: StructProperty
		/// Offset: 0x5C0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_ECB4A726493CDB6357E0279F555EACEA => ReadStruct<FAnimNode_Root>(0x5C0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_D0222876447A922A1F6BE58D14A4DD5D
		/// Type: StructProperty
		/// Offset: 0x608
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_D0222876447A922A1F6BE58D14A4DD5D => ReadStruct<FAnimNode_StateMachine>(0x608);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_1F2B88274A56B0AA498C1A93849A8400
		/// Type: StructProperty
		/// Offset: 0x6E0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_1F2B88274A56B0AA498C1A93849A8400 => ReadStruct<FAnimNode_Root>(0x6E0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_6C573E1C47DAC70FD70B45BD27A63DC9
		/// Type: StructProperty
		/// Offset: 0x728
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_6C573E1C47DAC70FD70B45BD27A63DC9 => ReadStruct<FAnimNode_Slot>(0x728);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_38D159EF494AAC3193801E845404F70E
		/// Type: StructProperty
		/// Offset: 0x788
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_38D159EF494AAC3193801E845404F70E => ReadStruct<FAnimNode_Slot>(0x788);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_C785EC1547ADC8D7B2EB8A9F8E710548
		/// Type: StructProperty
		/// Offset: 0x7F0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_C785EC1547ADC8D7B2EB8A9F8E710548 => ReadStruct<FAnimNode_TransitionResult>(0x7F0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_21084DE44202C255B8EED286F928E71E
		/// Type: StructProperty
		/// Offset: 0x870
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_21084DE44202C255B8EED286F928E71E => ReadStruct<FAnimNode_TransitionResult>(0x870);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_C26BF54643C6E42195A989B7A76A3DB9
		/// Type: StructProperty
		/// Offset: 0x8F0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_C26BF54643C6E42195A989B7A76A3DB9 => ReadStruct<FAnimNode_TransitionResult>(0x8F0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_98906E83476BFE8FD62415A95F0DCA5E
		/// Type: StructProperty
		/// Offset: 0x970
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_98906E83476BFE8FD62415A95F0DCA5E => ReadStruct<FAnimNode_TransitionResult>(0x970);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_6963AE4F4FCD3A6FC0FBACA89942C6E6
		/// Type: StructProperty
		/// Offset: 0x9F0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_6963AE4F4FCD3A6FC0FBACA89942C6E6 => ReadStruct<FAnimNode_SequencePlayer>(0x9F0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_F6F7250D4ACA170595A41AAB79705F06
		/// Type: StructProperty
		/// Offset: 0xA60
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_F6F7250D4ACA170595A41AAB79705F06 => ReadStruct<FAnimNode_Root>(0xA60);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_FA21371147461416223788BD37256FE4
		/// Type: StructProperty
		/// Offset: 0xAA8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_FA21371147461416223788BD37256FE4 => ReadStruct<FAnimNode_SequencePlayer>(0xAA8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_611056994DC3633ED80B349C88B1729F
		/// Type: StructProperty
		/// Offset: 0xB18
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_611056994DC3633ED80B349C88B1729F => ReadStruct<FAnimNode_Root>(0xB18);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_526AC3694E37FEF8D101DDA31BE0335A
		/// Type: StructProperty
		/// Offset: 0xB60
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_526AC3694E37FEF8D101DDA31BE0335A => ReadStruct<FAnimNode_BlendListByBool>(0xB60);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_AD2D03FF4CE5B8F08C3A2AA486F15110
		/// Type: StructProperty
		/// Offset: 0xC30
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_AD2D03FF4CE5B8F08C3A2AA486F15110 => ReadStruct<FAnimNode_SequencePlayer>(0xC30);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_3DAF7410482604618BEFA48F7A0E7EFA
		/// Type: StructProperty
		/// Offset: 0xCA0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_3DAF7410482604618BEFA48F7A0E7EFA => ReadStruct<FAnimNode_SequencePlayer>(0xCA0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_2E03D5164AB16BA138EF678D78213CCF
		/// Type: StructProperty
		/// Offset: 0xD10
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_2E03D5164AB16BA138EF678D78213CCF => ReadStruct<FAnimNode_SequencePlayer>(0xD10);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByInt_C0D5D3D349B6B0521D9EF3B4969CEE3B
		/// Type: StructProperty
		/// Offset: 0xD80
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByInt AnimGraphNode_BlendListByInt_C0D5D3D349B6B0521D9EF3B4969CEE3B => ReadStruct<FAnimNode_BlendListByInt>(0xD80);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_960F891F428ABDBD86ED40B2298AC8B3
		/// Type: StructProperty
		/// Offset: 0xE50
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_960F891F428ABDBD86ED40B2298AC8B3 => ReadStruct<FAnimNode_SequencePlayer>(0xE50);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_CA124F9A410946506AF71995B1E823CF
		/// Type: StructProperty
		/// Offset: 0xEC0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_CA124F9A410946506AF71995B1E823CF => ReadStruct<FAnimNode_SequencePlayer>(0xEC0);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_AC9E1A16486966CE462537B4498E9F60
		/// Type: StructProperty
		/// Offset: 0xF30
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_AC9E1A16486966CE462537B4498E9F60 => ReadStruct<FAnimNode_BlendListByBool>(0xF30);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendSpacePlayer_0E8CD37B45403A74628AA0A29549EE9C
		/// Type: StructProperty
		/// Offset: 0x1000
		/// Size: 0x130
		/// </summary>
		public FAnimNode_BlendSpacePlayer AnimGraphNode_BlendSpacePlayer_0E8CD37B45403A74628AA0A29549EE9C => ReadStruct<FAnimNode_BlendSpacePlayer>(0x1000);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_7F151C404BC142E9DE272C948063AE68
		/// Type: StructProperty
		/// Offset: 0x1130
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_7F151C404BC142E9DE272C948063AE68 => ReadStruct<FAnimNode_Root>(0x1130);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_E84F48AC47338CB33FA1A799298DA4D8
		/// Type: StructProperty
		/// Offset: 0x1178
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_E84F48AC47338CB33FA1A799298DA4D8 => ReadStruct<FAnimNode_StateMachine>(0x1178);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_A0FA9502418D967485950CA91FBCFE59
		/// Type: StructProperty
		/// Offset: 0x1250
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_A0FA9502418D967485950CA91FBCFE59 => ReadStruct<FAnimNode_Root>(0x1250);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_E5120AC94056282258391AB8741E85E8
		/// Type: StructProperty
		/// Offset: 0x1298
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_E5120AC94056282258391AB8741E85E8 => ReadStruct<FAnimNode_StateMachine>(0x1298);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_432A34E245B4A3554031278BA94B23FF
		/// Type: StructProperty
		/// Offset: 0x1370
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_432A34E245B4A3554031278BA94B23FF => ReadStruct<FAnimNode_Slot>(0x1370);
		
		/// <summary>
		/// Name: Speed
		/// Type: FloatProperty
		/// Offset: 0x13D0
		/// Size: 0x04
		/// </summary>
		public float Speed
		{
			get
			{
				return ReadSingle(0x13D0);
			}
			set
			{
				WriteSingle(0x13D0,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentState
		/// Type: ByteProperty
		/// Offset: 0x13D4
		/// Size: 0x01
		/// </summary>
		public byte CurrentState
		{
			get
			{
				return ReadByte(0x13D4);
			}
			set
			{
				WriteByte(0x13D4,value);
			}
		}
		
		/// <summary>
		/// Name: DoneWithKnockback
		/// Type: BoolProperty
		/// Offset: 0x13D5
		/// Size: 0x01
		/// </summary>
		public bool DoneWithKnockback
		{
			get
			{
				return ReadBool(0x13D5);
			}
			set
			{
				WriteBool(0x13D5,value);
			}
		}
		
		/// <summary>
		/// Name: GlobalAnimEndFraction
		/// Type: FloatProperty
		/// Offset: 0x13D8
		/// Size: 0x04
		/// </summary>
		public float GlobalAnimEndFraction
		{
			get
			{
				return ReadSingle(0x13D8);
			}
			set
			{
				WriteSingle(0x13D8,value);
			}
		}
		
		/// <summary>
		/// Name: EnableAttack
		/// Type: BoolProperty
		/// Offset: 0x13DC
		/// Size: 0x01
		/// </summary>
		public bool EnableAttack
		{
			get
			{
				return ReadBool(0x13DC);
			}
			set
			{
				WriteBool(0x13DC,value);
			}
		}
		
		/// <summary>
		/// Name: animdeltaX
		/// Type: FloatProperty
		/// Offset: 0x13E0
		/// Size: 0x04
		/// </summary>
		public float animdeltaX
		{
			get
			{
				return ReadSingle(0x13E0);
			}
			set
			{
				WriteSingle(0x13E0,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackForwardAmount
		/// Type: FloatProperty
		/// Offset: 0x13E4
		/// Size: 0x04
		/// </summary>
		public float KnockbackForwardAmount
		{
			get
			{
				return ReadSingle(0x13E4);
			}
			set
			{
				WriteSingle(0x13E4,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackRightAmount
		/// Type: FloatProperty
		/// Offset: 0x13E8
		/// Size: 0x04
		/// </summary>
		public float KnockbackRightAmount
		{
			get
			{
				return ReadSingle(0x13E8);
			}
			set
			{
				WriteSingle(0x13E8,value);
			}
		}
		
		/// <summary>
		/// Name: Defend
		/// Type: BoolProperty
		/// Offset: 0x13EC
		/// Size: 0x01
		/// </summary>
		public bool Defend
		{
			get
			{
				return ReadBool(0x13EC);
			}
			set
			{
				WriteBool(0x13EC,value);
			}
		}
		
		/// <summary>
		/// Name: bLocked
		/// Type: BoolProperty
		/// Offset: 0x13ED
		/// Size: 0x01
		/// </summary>
		public bool bLocked
		{
			get
			{
				return ReadBool(0x13ED);
			}
			set
			{
				WriteBool(0x13ED,value);
			}
		}
		
		/// <summary>
		/// Name: GuardBreaking
		/// Type: BoolProperty
		/// Offset: 0x13EE
		/// Size: 0x01
		/// </summary>
		public bool GuardBreaking
		{
			get
			{
				return ReadBool(0x13EE);
			}
			set
			{
				WriteBool(0x13EE,value);
			}
		}
		
		/// <summary>
		/// Name: StartJump
		/// Type: BoolProperty
		/// Offset: 0x13EF
		/// Size: 0x01
		/// </summary>
		public bool StartJump
		{
			get
			{
				return ReadBool(0x13EF);
			}
			set
			{
				WriteBool(0x13EF,value);
			}
		}
		
		/// <summary>
		/// Name: JumpStarted
		/// Type: BoolProperty
		/// Offset: 0x13F0
		/// Size: 0x01
		/// </summary>
		public bool JumpStarted
		{
			get
			{
				return ReadBool(0x13F0);
			}
			set
			{
				WriteBool(0x13F0,value);
			}
		}
		
		/// <summary>
		/// Name: CombatBP
		/// Type: ObjectProperty
		/// Offset: 0x13F8
		/// Size: 0x08
		/// </summary>
		public ABaseBPCombat_C CombatBP => ReadUObject<ABaseBPCombat_C>(0x13F8);
		
		/// <summary>
		/// Name: ReceivedEnableQueueEvent
		/// Type: BoolProperty
		/// Offset: 0x1400
		/// Size: 0x01
		/// </summary>
		public bool ReceivedEnableQueueEvent
		{
			get
			{
				return ReadBool(0x1400);
			}
			set
			{
				WriteBool(0x1400,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackNN
		/// Type: ObjectProperty
		/// Offset: 0x1408
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackNN => ReadUObject<UAnimMontage>(0x1408);
		
		/// <summary>
		/// Name: KnockbackNE
		/// Type: ObjectProperty
		/// Offset: 0x1410
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackNE => ReadUObject<UAnimMontage>(0x1410);
		
		/// <summary>
		/// Name: KnockbackEE
		/// Type: ObjectProperty
		/// Offset: 0x1418
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackEE => ReadUObject<UAnimMontage>(0x1418);
		
		/// <summary>
		/// Name: KnockbackSE
		/// Type: ObjectProperty
		/// Offset: 0x1420
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackSE => ReadUObject<UAnimMontage>(0x1420);
		
		/// <summary>
		/// Name: KnockbackSS
		/// Type: ObjectProperty
		/// Offset: 0x1428
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackSS => ReadUObject<UAnimMontage>(0x1428);
		
		/// <summary>
		/// Name: KnockbackSW
		/// Type: ObjectProperty
		/// Offset: 0x1430
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackSW => ReadUObject<UAnimMontage>(0x1430);
		
		/// <summary>
		/// Name: KnockbackWW
		/// Type: ObjectProperty
		/// Offset: 0x1438
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackWW => ReadUObject<UAnimMontage>(0x1438);
		
		/// <summary>
		/// Name: KnockbackNW
		/// Type: ObjectProperty
		/// Offset: 0x1440
		/// Size: 0x08
		/// </summary>
		public UAnimMontage KnockbackNW => ReadUObject<UAnimMontage>(0x1440);
		
		/// <summary>
		/// Name: ChargeAttack
		/// Type: NameProperty
		/// Offset: 0x1448
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bTurnRight
		/// Type: BoolProperty
		/// Offset: 0x1450
		/// Size: 0x01
		/// </summary>
		public bool bTurnRight
		{
			get
			{
				return ReadBool(0x1450);
			}
			set
			{
				WriteBool(0x1450,value);
			}
		}
		
		/// <summary>
		/// Name: bTurnLeft
		/// Type: BoolProperty
		/// Offset: 0x1451
		/// Size: 0x01
		/// </summary>
		public bool bTurnLeft
		{
			get
			{
				return ReadBool(0x1451);
			}
			set
			{
				WriteBool(0x1451,value);
			}
		}
		
		/// <summary>
		/// Name: noblendspace
		/// Type: TArray<>
		/// Offset: 0x1458
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: speedpoints
		/// Type: TArray<>
		/// Offset: 0x1468
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: movement_anim_array
		/// Type: TArray<UAnimSequence>
		/// Offset: 0x1478
		/// Size: 0x10
		/// SubElement Size: 0x188
		/// </summary>
		public TArray<UAnimSequence> movement_anim_array => new TArray<UAnimSequence>(BaseAddress+0x1478);
		
		/// <summary>
		/// Name: blendspace_index
		/// Type: IntProperty
		/// Offset: 0x1488
		/// Size: 0x04
		/// </summary>
		public int blendspace_index
		{
			get
			{
				return ReadInt32(0x1488);
			}
			set
			{
				WriteInt32(0x1488,value);
			}
		}
		
		/// <summary>
		/// Name: monsterscale
		/// Type: FloatProperty
		/// Offset: 0x148C
		/// Size: 0x04
		/// </summary>
		public float monsterscale
		{
			get
			{
				return ReadSingle(0x148C);
			}
			set
			{
				WriteSingle(0x148C,value);
			}
		}
		
		/// <summary>
		/// Name: animselectbyscale
		/// Type: BoolProperty
		/// Offset: 0x1490
		/// Size: 0x01
		/// </summary>
		public bool animselectbyscale
		{
			get
			{
				return ReadBool(0x1490);
			}
			set
			{
				WriteBool(0x1490,value);
			}
		}
		
		/// <summary>
		/// Name: KnockbackTimerHandle
		/// Type: StructProperty
		/// Offset: 0x1498
		/// Size: 0x08
		/// </summary>
		public FTimerHandle KnockbackTimerHandle => ReadStruct<FTimerHandle>(0x1498);
		
		/// <summary>
		/// Name: CurrentKnockbackSection
		/// Type: NameProperty
		/// Offset: 0x14A0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CurrentKnockbackMontage
		/// Type: ObjectProperty
		/// Offset: 0x14A8
		/// Size: 0x08
		/// </summary>
		public UAnimMontage CurrentKnockbackMontage => ReadUObject<UAnimMontage>(0x14A8);
		
		/// <summary>
		/// Name: CurrentPlayingEmoteMontage
		/// Type: ObjectProperty
		/// Offset: 0x14B0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage CurrentPlayingEmoteMontage => ReadUObject<UAnimMontage>(0x14B0);
		
		/// <summary>
		/// Name: NoBlendspaceResult
		/// Type: BoolProperty
		/// Offset: 0x14B8
		/// Size: 0x01
		/// </summary>
		public bool NoBlendspaceResult
		{
			get
			{
				return ReadBool(0x14B8);
			}
			set
			{
				WriteBool(0x14B8,value);
			}
		}
		
		/// <summary>
		/// Name: IsIdle
		/// Type: BoolProperty
		/// Offset: 0x14B9
		/// Size: 0x01
		/// </summary>
		public bool IsIdle
		{
			get
			{
				return ReadBool(0x14B9);
			}
			set
			{
				WriteBool(0x14B9,value);
			}
		}
		
		/// <summary>
		/// Name: AnimSequence
		/// Type: ObjectProperty
		/// Offset: 0x14C0
		/// Size: 0x08
		/// </summary>
		public UAnimSequenceBase AnimSequence => ReadUObject<UAnimSequenceBase>(0x14C0);
		
		/// <summary>
		/// Name: PlayRateBlendspace
		/// Type: FloatProperty
		/// Offset: 0x14C8
		/// Size: 0x04
		/// </summary>
		public float PlayRateBlendspace
		{
			get
			{
				return ReadSingle(0x14C8);
			}
			set
			{
				WriteSingle(0x14C8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayRateJog
		/// Type: FloatProperty
		/// Offset: 0x14CC
		/// Size: 0x04
		/// </summary>
		public float PlayRateJog
		{
			get
			{
				return ReadSingle(0x14CC);
			}
			set
			{
				WriteSingle(0x14CC,value);
			}
		}
		
		/// <summary>
		/// Name: isDead
		/// Type: BoolProperty
		/// Offset: 0x14D0
		/// Size: 0x01
		/// </summary>
		public bool isDead
		{
			get
			{
				return ReadBool(0x14D0);
			}
			set
			{
				WriteBool(0x14D0,value);
			}
		}
		
	}


}

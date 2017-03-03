using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;


namespace ConanExilesGame.Game.Characters.NPCs.Set_snake.animations
{
	/// <summary>
	/// UAB_avatar_setsnake_C:UAnimInstance
	/// Size: 0x1C44
	/// Properties: 69
	/// </summary>
	public class UAB_avatar_setsnake_C:UAnimInstance
	{
		public override int ObjectSize => 7236;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_CAEDDCC8433A1C6C276D0C896AC54468
		/// Type: StructProperty
		/// Offset: 0x488
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_CAEDDCC8433A1C6C276D0C896AC54468 => ReadStruct<FAnimNode_Root>(0x488);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_71996F614A146210D2507E915F2DBA93
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_71996F614A146210D2507E915F2DBA93 => ReadStruct<FAnimNode_TransitionResult>(0x4D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_01CD7D084C880498DE0A88919C29C0AB
		/// Type: StructProperty
		/// Offset: 0x550
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_01CD7D084C880498DE0A88919C29C0AB => ReadStruct<FAnimNode_TransitionResult>(0x550);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_8836E1E74F70E6C49F13BDA562A77924
		/// Type: StructProperty
		/// Offset: 0x5D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_8836E1E74F70E6C49F13BDA562A77924 => ReadStruct<FAnimNode_TransitionResult>(0x5D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_29B3454C480FBC8DC11090B2EBA8ACC1
		/// Type: StructProperty
		/// Offset: 0x650
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_29B3454C480FBC8DC11090B2EBA8ACC1 => ReadStruct<FAnimNode_TransitionResult>(0x650);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_764599654D3CF6C70DB26E854C7F1482
		/// Type: StructProperty
		/// Offset: 0x6D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_764599654D3CF6C70DB26E854C7F1482 => ReadStruct<FAnimNode_TransitionResult>(0x6D0);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_86E5726B4A0A502BDD3B8D87A5216CA2
		/// Type: StructProperty
		/// Offset: 0x750
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_86E5726B4A0A502BDD3B8D87A5216CA2 => ReadStruct<FAnimNode_TransitionResult>(0x750);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_8E4C62DE4C6BE5D27761FDAA5CF55D77
		/// Type: StructProperty
		/// Offset: 0x7D0
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_8E4C62DE4C6BE5D27761FDAA5CF55D77 => ReadStruct<FAnimNode_TransitionResult>(0x7D0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_89B8475A48476444EC7F7C9D0C6209F6
		/// Type: StructProperty
		/// Offset: 0x850
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_89B8475A48476444EC7F7C9D0C6209F6 => ReadStruct<FAnimNode_SequencePlayer>(0x850);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_7D44F4304D614BE0DF90AF88C15CAF90
		/// Type: StructProperty
		/// Offset: 0x8C0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_7D44F4304D614BE0DF90AF88C15CAF90 => ReadStruct<FAnimNode_Root>(0x8C0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_76C4CE4C42BFE94176B1A39FC563A0EE
		/// Type: StructProperty
		/// Offset: 0x908
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_76C4CE4C42BFE94176B1A39FC563A0EE => ReadStruct<FAnimNode_SequencePlayer>(0x908);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_8629369A42911316EA5311B716F5ED6B
		/// Type: StructProperty
		/// Offset: 0x978
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_8629369A42911316EA5311B716F5ED6B => ReadStruct<FAnimNode_Root>(0x978);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_04D605814ABF780E4DF5739123AE1BAA
		/// Type: StructProperty
		/// Offset: 0x9C0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_04D605814ABF780E4DF5739123AE1BAA => ReadStruct<FAnimNode_SequencePlayer>(0x9C0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_4601E5D34F3C615075DFAD805E9FF975
		/// Type: StructProperty
		/// Offset: 0xA30
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_4601E5D34F3C615075DFAD805E9FF975 => ReadStruct<FAnimNode_Root>(0xA30);
		
		/// <summary>
		/// Name: AnimGraphNode_SequenceEvaluator_C714436849309E68F3A38097E916FB35
		/// Type: StructProperty
		/// Offset: 0xA78
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequenceEvaluator AnimGraphNode_SequenceEvaluator_C714436849309E68F3A38097E916FB35 => ReadStruct<FAnimNode_SequenceEvaluator>(0xA78);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_25E6164747AEE5EEAB3386A1E45027A5
		/// Type: StructProperty
		/// Offset: 0xAE8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_25E6164747AEE5EEAB3386A1E45027A5 => ReadStruct<FAnimNode_Root>(0xAE8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_37E8BF0C4514D4BCA08AA4B7A0D01220
		/// Type: StructProperty
		/// Offset: 0xB30
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_37E8BF0C4514D4BCA08AA4B7A0D01220 => ReadStruct<FAnimNode_SequencePlayer>(0xB30);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_E491A15D45AEDF35CFA9F5A9BAA4FFF1
		/// Type: StructProperty
		/// Offset: 0xBA0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_E491A15D45AEDF35CFA9F5A9BAA4FFF1 => ReadStruct<FAnimNode_Root>(0xBA0);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_D458C1BD47A74D3C47BFABAF78505CCC
		/// Type: StructProperty
		/// Offset: 0xBE8
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_D458C1BD47A74D3C47BFABAF78505CCC => ReadStruct<FAnimNode_StateMachine>(0xBE8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_A87888DF440F3A55641D51BD77DC2BFA
		/// Type: StructProperty
		/// Offset: 0xCC0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_A87888DF440F3A55641D51BD77DC2BFA => ReadStruct<FAnimNode_ModifyBone>(0xCC0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_1A4A760E485CF4B1433D6BBC73B745A1
		/// Type: StructProperty
		/// Offset: 0xD70
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_1A4A760E485CF4B1433D6BBC73B745A1 => ReadStruct<FAnimNode_ModifyBone>(0xD70);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_F3A683C548A0EC08D4129C813418F813
		/// Type: StructProperty
		/// Offset: 0xE20
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_F3A683C548A0EC08D4129C813418F813 => ReadStruct<FAnimNode_ModifyBone>(0xE20);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_85170775414F9E1BDB4CAC8E9B9BBB8D
		/// Type: StructProperty
		/// Offset: 0xED0
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_85170775414F9E1BDB4CAC8E9B9BBB8D => ReadStruct<FAnimNode_ModifyBone>(0xED0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_1C0691DB45AD36339129B989CBFDAD0B
		/// Type: StructProperty
		/// Offset: 0xF80
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_1C0691DB45AD36339129B989CBFDAD0B => ReadStruct<FAnimNode_ModifyBone>(0xF80);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_2D04F74340722A2EDD7D15A6A5E13BAE
		/// Type: StructProperty
		/// Offset: 0x1030
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_2D04F74340722A2EDD7D15A6A5E13BAE => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x1030);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_1663E48443FAB971D1BA07BADDB70B26
		/// Type: StructProperty
		/// Offset: 0x1078
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_1663E48443FAB971D1BA07BADDB70B26 => ReadStruct<FAnimNode_SaveCachedPose>(0x1078);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_0F9341184DD709736B487A82D9D94FD7
		/// Type: StructProperty
		/// Offset: 0x1108
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_0F9341184DD709736B487A82D9D94FD7 => ReadStruct<FAnimNode_UseCachedPose>(0x1108);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_34389E1844B9A8646E9CE5A4414195C4
		/// Type: StructProperty
		/// Offset: 0x1150
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_34389E1844B9A8646E9CE5A4414195C4 => ReadStruct<FAnimNode_SequencePlayer>(0x1150);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_8FC1D9904A72F31694049DBCEAE17BBD
		/// Type: StructProperty
		/// Offset: 0x11C0
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_8FC1D9904A72F31694049DBCEAE17BBD => ReadStruct<FAnimNode_BlendListByBool>(0x11C0);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyMeshSpaceAdditive_98913C3F457A43A53E77AF985DFD8D82
		/// Type: StructProperty
		/// Offset: 0x1290
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyMeshSpaceAdditive AnimGraphNode_ApplyMeshSpaceAdditive_98913C3F457A43A53E77AF985DFD8D82 => ReadStruct<FAnimNode_ApplyMeshSpaceAdditive>(0x1290);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_EC87BBA9407B51B55C75A9BC97572C9A
		/// Type: StructProperty
		/// Offset: 0x1308
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_EC87BBA9407B51B55C75A9BC97572C9A => ReadStruct<FAnimNode_UseCachedPose>(0x1308);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_B39B088F47FB6C52C2F4A48019428F24
		/// Type: StructProperty
		/// Offset: 0x1350
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_B39B088F47FB6C52C2F4A48019428F24 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x1350);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_A724F1F94481E97F51DDF797BA924766
		/// Type: StructProperty
		/// Offset: 0x13F0
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_A724F1F94481E97F51DDF797BA924766 => ReadStruct<FAnimNode_SequencePlayer>(0x13F0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_1BD1E8AB473ED727A84F3B86DF1DA369
		/// Type: StructProperty
		/// Offset: 0x1460
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_1BD1E8AB473ED727A84F3B86DF1DA369 => ReadStruct<FAnimNode_SequencePlayer>(0x1460);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyAdditive_C79601AC45AE6EB9230A83BF25380254
		/// Type: StructProperty
		/// Offset: 0x14D0
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyAdditive AnimGraphNode_ApplyAdditive_C79601AC45AE6EB9230A83BF25380254 => ReadStruct<FAnimNode_ApplyAdditive>(0x14D0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_09E729B2440F303FD0903AB1FFD8D94D
		/// Type: StructProperty
		/// Offset: 0x1548
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_09E729B2440F303FD0903AB1FFD8D94D => ReadStruct<FAnimNode_Slot>(0x1548);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_22C4B93749580748DCCBA7A1F4E7C8CF
		/// Type: StructProperty
		/// Offset: 0x15A8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_22C4B93749580748DCCBA7A1F4E7C8CF => ReadStruct<FAnimNode_LayeredBoneBlend>(0x15A8);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_E3C8A759489470C52292A69BBD7F17B2
		/// Type: StructProperty
		/// Offset: 0x1648
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_E3C8A759489470C52292A69BBD7F17B2 => ReadStruct<FAnimNode_SaveCachedPose>(0x1648);
		
		/// <summary>
		/// Name: AnimGraphNode_Fabrik_44CF93AF4B14A223F4A432A1AA062987
		/// Type: StructProperty
		/// Offset: 0x16E0
		/// Size: 0xF0
		/// </summary>
		public FAnimNode_Fabrik AnimGraphNode_Fabrik_44CF93AF4B14A223F4A432A1AA062987 => ReadStruct<FAnimNode_Fabrik>(0x16E0);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_E0408BD2451FB7FF46C001B7D7FA0DA0
		/// Type: StructProperty
		/// Offset: 0x17D0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_E0408BD2451FB7FF46C001B7D7FA0DA0 => ReadStruct<FAnimNode_UseCachedPose>(0x17D0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_BA3EFEE547FA56F2D5DA66850B1D989C
		/// Type: StructProperty
		/// Offset: 0x1818
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_BA3EFEE547FA56F2D5DA66850B1D989C => ReadStruct<FAnimNode_Slot>(0x1818);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_819483804F0BB33A617331822A489CED
		/// Type: StructProperty
		/// Offset: 0x1878
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_819483804F0BB33A617331822A489CED => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x1878);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_450894E247CAA7AC6288F09707AD07F7
		/// Type: StructProperty
		/// Offset: 0x18C0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_450894E247CAA7AC6288F09707AD07F7 => ReadStruct<FAnimNode_UseCachedPose>(0x18C0);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_2D02B712441A6BD9EA2EDB9C6ECD46F3
		/// Type: StructProperty
		/// Offset: 0x1908
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_2D02B712441A6BD9EA2EDB9C6ECD46F3 => ReadStruct<FAnimNode_ModifyBone>(0x1908);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_E39FB0214645E546F46DC99B6FFC3B10
		/// Type: StructProperty
		/// Offset: 0x19B8
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_E39FB0214645E546F46DC99B6FFC3B10 => ReadStruct<FAnimNode_BlendListByBool>(0x19B8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_78C1A15A41A5E98315F4E7A42748B908
		/// Type: StructProperty
		/// Offset: 0x1A88
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_78C1A15A41A5E98315F4E7A42748B908 => ReadStruct<FAnimNode_SequencePlayer>(0x1A88);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_E6B3FACD4A3FE4CC509C3EA211BB6C03
		/// Type: StructProperty
		/// Offset: 0x1AF8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_E6B3FACD4A3FE4CC509C3EA211BB6C03 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x1AF8);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_8DDBAF8648D038315ACEA996A12D381D
		/// Type: StructProperty
		/// Offset: 0x1B40
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_8DDBAF8648D038315ACEA996A12D381D => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x1B40);
		
		/// <summary>
		/// Name: Speed
		/// Type: FloatProperty
		/// Offset: 0x1B88
		/// Size: 0x04
		/// </summary>
		public float Speed
		{
			get
			{
				return ReadSingle(0x1B88);
			}
			set
			{
				WriteSingle(0x1B88,value);
			}
		}
		
		/// <summary>
		/// Name: animdeltaX
		/// Type: FloatProperty
		/// Offset: 0x1B8C
		/// Size: 0x04
		/// </summary>
		public float animdeltaX
		{
			get
			{
				return ReadSingle(0x1B8C);
			}
			set
			{
				WriteSingle(0x1B8C,value);
			}
		}
		
		/// <summary>
		/// Name: CombatBP
		/// Type: ObjectProperty
		/// Offset: 0x1B90
		/// Size: 0x08
		/// </summary>
		public AConanCharacter CombatBP => ReadUObject<AConanCharacter>(0x1B90);
		
		/// <summary>
		/// Name: is_attacking
		/// Type: BoolProperty
		/// Offset: 0x1B98
		/// Size: 0x01
		/// </summary>
		public bool is_attacking
		{
			get
			{
				return ReadBool(0x1B98);
			}
			set
			{
				WriteBool(0x1B98,value);
			}
		}
		
		/// <summary>
		/// Name: attackblend
		/// Type: FloatProperty
		/// Offset: 0x1B9C
		/// Size: 0x04
		/// </summary>
		public float attackblend
		{
			get
			{
				return ReadSingle(0x1B9C);
			}
			set
			{
				WriteSingle(0x1B9C,value);
			}
		}
		
		/// <summary>
		/// Name: monsterscale
		/// Type: FloatProperty
		/// Offset: 0x1BA0
		/// Size: 0x04
		/// </summary>
		public float monsterscale
		{
			get
			{
				return ReadSingle(0x1BA0);
			}
			set
			{
				WriteSingle(0x1BA0,value);
			}
		}
		
		/// <summary>
		/// Name: coil
		/// Type: BoolProperty
		/// Offset: 0x1BA4
		/// Size: 0x01
		/// </summary>
		public bool coil
		{
			get
			{
				return ReadBool(0x1BA4);
			}
			set
			{
				WriteBool(0x1BA4,value);
			}
		}
		
		/// <summary>
		/// Name: digesting
		/// Type: FloatProperty
		/// Offset: 0x1BA8
		/// Size: 0x04
		/// </summary>
		public float digesting
		{
			get
			{
				return ReadSingle(0x1BA8);
			}
			set
			{
				WriteSingle(0x1BA8,value);
			}
		}
		
		/// <summary>
		/// Name: crawl_ratio
		/// Type: FloatProperty
		/// Offset: 0x1BAC
		/// Size: 0x04
		/// </summary>
		public float crawl_ratio
		{
			get
			{
				return ReadSingle(0x1BAC);
			}
			set
			{
				WriteSingle(0x1BAC,value);
			}
		}
		
		/// <summary>
		/// Name: CanQueueNextAttack
		/// Type: BoolProperty
		/// Offset: 0x1BB0
		/// Size: 0x01
		/// </summary>
		public bool CanQueueNextAttack
		{
			get
			{
				return ReadBool(0x1BB0);
			}
			set
			{
				WriteBool(0x1BB0,value);
			}
		}
		
		/// <summary>
		/// Name: IK_target
		/// Type: StructProperty
		/// Offset: 0x1BC0
		/// Size: 0x30
		/// </summary>
		public FTransform IK_target => ReadStruct<FTransform>(0x1BC0);
		
		/// <summary>
		/// Name: spray_attack
		/// Type: BoolProperty
		/// Offset: 0x1BF0
		/// Size: 0x01
		/// </summary>
		public bool spray_attack
		{
			get
			{
				return ReadBool(0x1BF0);
			}
			set
			{
				WriteBool(0x1BF0,value);
			}
		}
		
		/// <summary>
		/// Name: targetloc
		/// Type: StructProperty
		/// Offset: 0x1BF4
		/// Size: 0x0C
		/// </summary>
		public FVector targetloc => ReadStruct<FVector>(0x1BF4);
		
		/// <summary>
		/// Name: HasTarget
		/// Type: BoolProperty
		/// Offset: 0x1C00
		/// Size: 0x01
		/// </summary>
		public bool HasTarget
		{
			get
			{
				return ReadBool(0x1C00);
			}
			set
			{
				WriteBool(0x1C00,value);
			}
		}
		
		/// <summary>
		/// Name: current_root_bone_rotation
		/// Type: StructProperty
		/// Offset: 0x1C04
		/// Size: 0x0C
		/// </summary>
		public FRotator current_root_bone_rotation => ReadStruct<FRotator>(0x1C04);
		
		/// <summary>
		/// Name: interpolated_root_bone_rotation
		/// Type: StructProperty
		/// Offset: 0x1C10
		/// Size: 0x0C
		/// </summary>
		public FRotator interpolated_root_bone_rotation => ReadStruct<FRotator>(0x1C10);
		
		/// <summary>
		/// Name: GroundNormal
		/// Type: StructProperty
		/// Offset: 0x1C1C
		/// Size: 0x0C
		/// </summary>
		public FVector GroundNormal => ReadStruct<FVector>(0x1C1C);
		
		/// <summary>
		/// Name: IsSpawning
		/// Type: BoolProperty
		/// Offset: 0x1C28
		/// Size: 0x01
		/// </summary>
		public bool IsSpawning
		{
			get
			{
				return ReadBool(0x1C28);
			}
			set
			{
				WriteBool(0x1C28,value);
			}
		}
		
		/// <summary>
		/// Name: Velocity
		/// Type: StructProperty
		/// Offset: 0x1C2C
		/// Size: 0x0C
		/// </summary>
		public FVector Velocity => ReadStruct<FVector>(0x1C2C);
		
		/// <summary>
		/// Name: Forward
		/// Type: StructProperty
		/// Offset: 0x1C38
		/// Size: 0x0C
		/// </summary>
		public FVector Forward => ReadStruct<FVector>(0x1C38);
		
	}


	/// <summary>
	/// UAB_set_snake_C:UAnimInstance
	/// Size: 0x1E00
	/// Properties: 68
	/// </summary>
	public class UAB_set_snake_C:UAnimInstance
	{
		public override int ObjectSize => 7680;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x480);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_2D10F2F74243A0488E0CFAB9EB5EEF8F
		/// Type: StructProperty
		/// Offset: 0x490
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_2D10F2F74243A0488E0CFAB9EB5EEF8F => ReadStruct<FAnimNode_TransitionResult>(0x490);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_C2B5E3D145E8F676F859538B1B856ACE
		/// Type: StructProperty
		/// Offset: 0x510
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_C2B5E3D145E8F676F859538B1B856ACE => ReadStruct<FAnimNode_TransitionResult>(0x510);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_1399E990484F9110396E538F5E91EF62
		/// Type: StructProperty
		/// Offset: 0x590
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_1399E990484F9110396E538F5E91EF62 => ReadStruct<FAnimNode_TransitionResult>(0x590);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_E2FC040B43C18752C77A4FBDC20ABE07
		/// Type: StructProperty
		/// Offset: 0x610
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_E2FC040B43C18752C77A4FBDC20ABE07 => ReadStruct<FAnimNode_TransitionResult>(0x610);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_7B00469C41B5137870A2C287654C7FF8
		/// Type: StructProperty
		/// Offset: 0x690
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_7B00469C41B5137870A2C287654C7FF8 => ReadStruct<FAnimNode_TransitionResult>(0x690);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_40D095B94513E4D3BC801CB75C6984AC
		/// Type: StructProperty
		/// Offset: 0x710
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_40D095B94513E4D3BC801CB75C6984AC => ReadStruct<FAnimNode_TransitionResult>(0x710);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_6226A24640E4F3B85A16DBAD0ED3FC41
		/// Type: StructProperty
		/// Offset: 0x790
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_6226A24640E4F3B85A16DBAD0ED3FC41 => ReadStruct<FAnimNode_TransitionResult>(0x790);
		
		/// <summary>
		/// Name: AnimGraphNode_TransitionResult_746E077340009610D14FF3B1178B3575
		/// Type: StructProperty
		/// Offset: 0x810
		/// Size: 0x80
		/// </summary>
		public FAnimNode_TransitionResult AnimGraphNode_TransitionResult_746E077340009610D14FF3B1178B3575 => ReadStruct<FAnimNode_TransitionResult>(0x810);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_3772701F4FEB988184D47C9ECC729342
		/// Type: StructProperty
		/// Offset: 0x890
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_3772701F4FEB988184D47C9ECC729342 => ReadStruct<FAnimNode_SequencePlayer>(0x890);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_B3F593604BCBB30D9A6C298A9EEA08C5
		/// Type: StructProperty
		/// Offset: 0x900
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_B3F593604BCBB30D9A6C298A9EEA08C5 => ReadStruct<FAnimNode_Root>(0x900);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_BE0BC6A6425D9EE30603318138456D23
		/// Type: StructProperty
		/// Offset: 0x948
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_BE0BC6A6425D9EE30603318138456D23 => ReadStruct<FAnimNode_SequencePlayer>(0x948);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_B37B690D46A532996732898FD54FB017
		/// Type: StructProperty
		/// Offset: 0x9B8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_B37B690D46A532996732898FD54FB017 => ReadStruct<FAnimNode_Root>(0x9B8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_CB70A6364DF663CCF4420D99BBE9FCEC
		/// Type: StructProperty
		/// Offset: 0xA00
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_CB70A6364DF663CCF4420D99BBE9FCEC => ReadStruct<FAnimNode_SequencePlayer>(0xA00);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_9DCBE6404273AFEF998D439D411803C4
		/// Type: StructProperty
		/// Offset: 0xA70
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_9DCBE6404273AFEF998D439D411803C4 => ReadStruct<FAnimNode_Root>(0xA70);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_39E44929403D1607D204E99D04D2A80D
		/// Type: StructProperty
		/// Offset: 0xAB8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_39E44929403D1607D204E99D04D2A80D => ReadStruct<FAnimNode_SequencePlayer>(0xAB8);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_C27338B84AC9820754090B81D9F8C4D8
		/// Type: StructProperty
		/// Offset: 0xB28
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_C27338B84AC9820754090B81D9F8C4D8 => ReadStruct<FAnimNode_Root>(0xB28);
		
		/// <summary>
		/// Name: AnimGraphNode_SequenceEvaluator_A1C3EF0641BED6CB813A8DB499333144
		/// Type: StructProperty
		/// Offset: 0xB70
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequenceEvaluator AnimGraphNode_SequenceEvaluator_A1C3EF0641BED6CB813A8DB499333144 => ReadStruct<FAnimNode_SequenceEvaluator>(0xB70);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_B618D45946E7414EB510FCA79C1F961C
		/// Type: StructProperty
		/// Offset: 0xBE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_B618D45946E7414EB510FCA79C1F961C => ReadStruct<FAnimNode_Root>(0xBE0);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_93690959455AD5CF5D40DEB209F4BBD9
		/// Type: StructProperty
		/// Offset: 0xC28
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_93690959455AD5CF5D40DEB209F4BBD9 => ReadStruct<FAnimNode_SequencePlayer>(0xC28);
		
		/// <summary>
		/// Name: AnimGraphNode_StateResult_A04390C146C32C74FEDE81A6AE48BC1F
		/// Type: StructProperty
		/// Offset: 0xC98
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_StateResult_A04390C146C32C74FEDE81A6AE48BC1F => ReadStruct<FAnimNode_Root>(0xC98);
		
		/// <summary>
		/// Name: AnimGraphNode_StateMachine_ACF7C87E48BA1E1CA0CF87A245008A12
		/// Type: StructProperty
		/// Offset: 0xCE0
		/// Size: 0xD8
		/// </summary>
		public FAnimNode_StateMachine AnimGraphNode_StateMachine_ACF7C87E48BA1E1CA0CF87A245008A12 => ReadStruct<FAnimNode_StateMachine>(0xCE0);
		
		/// <summary>
		/// Name: AnimGraphNode_Root_F5997626435C798F92A2FF8182CDF0D3
		/// Type: StructProperty
		/// Offset: 0xDB8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_Root AnimGraphNode_Root_F5997626435C798F92A2FF8182CDF0D3 => ReadStruct<FAnimNode_Root>(0xDB8);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_6A21E3F148D33380A3F1C7BF33B47951
		/// Type: StructProperty
		/// Offset: 0xE00
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_6A21E3F148D33380A3F1C7BF33B47951 => ReadStruct<FAnimNode_SaveCachedPose>(0xE00);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_47CDDC8547B601A0914868837B948B49
		/// Type: StructProperty
		/// Offset: 0xE90
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_47CDDC8547B601A0914868837B948B49 => ReadStruct<FAnimNode_UseCachedPose>(0xE90);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_D8DE08B143DC5B2F828675AA14EB264B
		/// Type: StructProperty
		/// Offset: 0xED8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_D8DE08B143DC5B2F828675AA14EB264B => ReadStruct<FAnimNode_SequencePlayer>(0xED8);
		
		/// <summary>
		/// Name: AnimGraphNode_BlendListByBool_8AB6AFE840FF6082AC5151A226063E1C
		/// Type: StructProperty
		/// Offset: 0xF48
		/// Size: 0xD0
		/// </summary>
		public FAnimNode_BlendListByBool AnimGraphNode_BlendListByBool_8AB6AFE840FF6082AC5151A226063E1C => ReadStruct<FAnimNode_BlendListByBool>(0xF48);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyMeshSpaceAdditive_51957B9440A01CFF4A1CF49F659406E0
		/// Type: StructProperty
		/// Offset: 0x1018
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyMeshSpaceAdditive AnimGraphNode_ApplyMeshSpaceAdditive_51957B9440A01CFF4A1CF49F659406E0 => ReadStruct<FAnimNode_ApplyMeshSpaceAdditive>(0x1018);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_E14DE83847310C3427DF0BBCECB7AD28
		/// Type: StructProperty
		/// Offset: 0x1090
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_E14DE83847310C3427DF0BBCECB7AD28 => ReadStruct<FAnimNode_UseCachedPose>(0x1090);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_7F4DECF8486CCBCBFD83D4908D686954
		/// Type: StructProperty
		/// Offset: 0x10D8
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_7F4DECF8486CCBCBFD83D4908D686954 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x10D8);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_BF9A9F0B450D7CDA0D4A4C98C399C004
		/// Type: StructProperty
		/// Offset: 0x1178
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_BF9A9F0B450D7CDA0D4A4C98C399C004 => ReadStruct<FAnimNode_SequencePlayer>(0x1178);
		
		/// <summary>
		/// Name: AnimGraphNode_SequencePlayer_860AA34840CD306F74D06BABF4E9C02F
		/// Type: StructProperty
		/// Offset: 0x11E8
		/// Size: 0x70
		/// </summary>
		public FAnimNode_SequencePlayer AnimGraphNode_SequencePlayer_860AA34840CD306F74D06BABF4E9C02F => ReadStruct<FAnimNode_SequencePlayer>(0x11E8);
		
		/// <summary>
		/// Name: AnimGraphNode_ApplyAdditive_7FA2814D4EE17D8523AE689C489045D1
		/// Type: StructProperty
		/// Offset: 0x1258
		/// Size: 0x78
		/// </summary>
		public FAnimNode_ApplyAdditive AnimGraphNode_ApplyAdditive_7FA2814D4EE17D8523AE689C489045D1 => ReadStruct<FAnimNode_ApplyAdditive>(0x1258);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_BEE9DD6042D61622976C71B7E39FECAB
		/// Type: StructProperty
		/// Offset: 0x12D0
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_BEE9DD6042D61622976C71B7E39FECAB => ReadStruct<FAnimNode_Slot>(0x12D0);
		
		/// <summary>
		/// Name: AnimGraphNode_LayeredBoneBlend_49C8EA1E46B032DFC16D1E87E499A711
		/// Type: StructProperty
		/// Offset: 0x1330
		/// Size: 0xA0
		/// </summary>
		public FAnimNode_LayeredBoneBlend AnimGraphNode_LayeredBoneBlend_49C8EA1E46B032DFC16D1E87E499A711 => ReadStruct<FAnimNode_LayeredBoneBlend>(0x1330);
		
		/// <summary>
		/// Name: AnimGraphNode_SaveCachedPose_12D196184CACE6C4B0EE3DACDF335054
		/// Type: StructProperty
		/// Offset: 0x13D0
		/// Size: 0x90
		/// </summary>
		public FAnimNode_SaveCachedPose AnimGraphNode_SaveCachedPose_12D196184CACE6C4B0EE3DACDF335054 => ReadStruct<FAnimNode_SaveCachedPose>(0x13D0);
		
		/// <summary>
		/// Name: AnimGraphNode_Fabrik_44DE2C7D4557FF3DDF2971B4F65F39FA
		/// Type: StructProperty
		/// Offset: 0x1460
		/// Size: 0xF0
		/// </summary>
		public FAnimNode_Fabrik AnimGraphNode_Fabrik_44DE2C7D4557FF3DDF2971B4F65F39FA => ReadStruct<FAnimNode_Fabrik>(0x1460);
		
		/// <summary>
		/// Name: AnimGraphNode_LookAt_3005C0B6489DA3A84BF2B2AD3D4610E4
		/// Type: StructProperty
		/// Offset: 0x1550
		/// Size: 0x120
		/// </summary>
		public FAnimNode_LookAt AnimGraphNode_LookAt_3005C0B6489DA3A84BF2B2AD3D4610E4 => ReadStruct<FAnimNode_LookAt>(0x1550);
		
		/// <summary>
		/// Name: AnimGraphNode_LookAt_796516C44DE5BE9F5276D5B22691A3C3
		/// Type: StructProperty
		/// Offset: 0x1670
		/// Size: 0x120
		/// </summary>
		public FAnimNode_LookAt AnimGraphNode_LookAt_796516C44DE5BE9F5276D5B22691A3C3 => ReadStruct<FAnimNode_LookAt>(0x1670);
		
		/// <summary>
		/// Name: AnimGraphNode_LookAt_5622B9834234381D18FFC1AAC59BC7A1
		/// Type: StructProperty
		/// Offset: 0x1790
		/// Size: 0x120
		/// </summary>
		public FAnimNode_LookAt AnimGraphNode_LookAt_5622B9834234381D18FFC1AAC59BC7A1 => ReadStruct<FAnimNode_LookAt>(0x1790);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_FB4C07294AE911E8531C7F9EB7906FA5
		/// Type: StructProperty
		/// Offset: 0x18B0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_FB4C07294AE911E8531C7F9EB7906FA5 => ReadStruct<FAnimNode_UseCachedPose>(0x18B0);
		
		/// <summary>
		/// Name: AnimGraphNode_Slot_6F4C017F495ED0922C78D7BF07BF7C27
		/// Type: StructProperty
		/// Offset: 0x18F8
		/// Size: 0x60
		/// </summary>
		public FAnimNode_Slot AnimGraphNode_Slot_6F4C017F495ED0922C78D7BF07BF7C27 => ReadStruct<FAnimNode_Slot>(0x18F8);
		
		/// <summary>
		/// Name: AnimGraphNode_LookAt_571455CD415E6B52ED108592D1600AAC
		/// Type: StructProperty
		/// Offset: 0x1960
		/// Size: 0x120
		/// </summary>
		public FAnimNode_LookAt AnimGraphNode_LookAt_571455CD415E6B52ED108592D1600AAC => ReadStruct<FAnimNode_LookAt>(0x1960);
		
		/// <summary>
		/// Name: AnimGraphNode_LookAt_7457BAE34B85830F044386A67BDB3423
		/// Type: StructProperty
		/// Offset: 0x1A80
		/// Size: 0x120
		/// </summary>
		public FAnimNode_LookAt AnimGraphNode_LookAt_7457BAE34B85830F044386A67BDB3423 => ReadStruct<FAnimNode_LookAt>(0x1A80);
		
		/// <summary>
		/// Name: AnimGraphNode_LocalToComponentSpace_3DE8E342400E33FC1902EDBB446F3686
		/// Type: StructProperty
		/// Offset: 0x1BA0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertLocalToComponentSpace AnimGraphNode_LocalToComponentSpace_3DE8E342400E33FC1902EDBB446F3686 => ReadStruct<FAnimNode_ConvertLocalToComponentSpace>(0x1BA0);
		
		/// <summary>
		/// Name: AnimGraphNode_UseCachedPose_8EAEB45E403EFD2EF1DF2F8D7C8CE6A2
		/// Type: StructProperty
		/// Offset: 0x1BE8
		/// Size: 0x48
		/// </summary>
		public FAnimNode_UseCachedPose AnimGraphNode_UseCachedPose_8EAEB45E403EFD2EF1DF2F8D7C8CE6A2 => ReadStruct<FAnimNode_UseCachedPose>(0x1BE8);
		
		/// <summary>
		/// Name: AnimGraphNode_ModifyBone_421DB1D14005889AAC39319D0693176E
		/// Type: StructProperty
		/// Offset: 0x1C30
		/// Size: 0xB0
		/// </summary>
		public FAnimNode_ModifyBone AnimGraphNode_ModifyBone_421DB1D14005889AAC39319D0693176E => ReadStruct<FAnimNode_ModifyBone>(0x1C30);
		
		/// <summary>
		/// Name: AnimGraphNode_ComponentToLocalSpace_468DC168495E8016232F039901662FF5
		/// Type: StructProperty
		/// Offset: 0x1CE0
		/// Size: 0x48
		/// </summary>
		public FAnimNode_ConvertComponentToLocalSpace AnimGraphNode_ComponentToLocalSpace_468DC168495E8016232F039901662FF5 => ReadStruct<FAnimNode_ConvertComponentToLocalSpace>(0x1CE0);
		
		/// <summary>
		/// Name: Speed
		/// Type: FloatProperty
		/// Offset: 0x1D28
		/// Size: 0x04
		/// </summary>
		public float Speed
		{
			get
			{
				return ReadSingle(0x1D28);
			}
			set
			{
				WriteSingle(0x1D28,value);
			}
		}
		
		/// <summary>
		/// Name: animdeltaX
		/// Type: FloatProperty
		/// Offset: 0x1D2C
		/// Size: 0x04
		/// </summary>
		public float animdeltaX
		{
			get
			{
				return ReadSingle(0x1D2C);
			}
			set
			{
				WriteSingle(0x1D2C,value);
			}
		}
		
		/// <summary>
		/// Name: BaseNPC
		/// Type: ObjectProperty
		/// Offset: 0x1D30
		/// Size: 0x08
		/// </summary>
		public ABaseNPC_C BaseNPC => ReadUObject<ABaseNPC_C>(0x1D30);
		
		/// <summary>
		/// Name: is_attacking
		/// Type: BoolProperty
		/// Offset: 0x1D38
		/// Size: 0x01
		/// </summary>
		public bool is_attacking
		{
			get
			{
				return ReadBool(0x1D38);
			}
			set
			{
				WriteBool(0x1D38,value);
			}
		}
		
		/// <summary>
		/// Name: attackblend
		/// Type: FloatProperty
		/// Offset: 0x1D3C
		/// Size: 0x04
		/// </summary>
		public float attackblend
		{
			get
			{
				return ReadSingle(0x1D3C);
			}
			set
			{
				WriteSingle(0x1D3C,value);
			}
		}
		
		/// <summary>
		/// Name: monsterscale
		/// Type: FloatProperty
		/// Offset: 0x1D40
		/// Size: 0x04
		/// </summary>
		public float monsterscale
		{
			get
			{
				return ReadSingle(0x1D40);
			}
			set
			{
				WriteSingle(0x1D40,value);
			}
		}
		
		/// <summary>
		/// Name: coil
		/// Type: BoolProperty
		/// Offset: 0x1D44
		/// Size: 0x01
		/// </summary>
		public bool coil
		{
			get
			{
				return ReadBool(0x1D44);
			}
			set
			{
				WriteBool(0x1D44,value);
			}
		}
		
		/// <summary>
		/// Name: digesting
		/// Type: FloatProperty
		/// Offset: 0x1D48
		/// Size: 0x04
		/// </summary>
		public float digesting
		{
			get
			{
				return ReadSingle(0x1D48);
			}
			set
			{
				WriteSingle(0x1D48,value);
			}
		}
		
		/// <summary>
		/// Name: crawl_ratio
		/// Type: FloatProperty
		/// Offset: 0x1D4C
		/// Size: 0x04
		/// </summary>
		public float crawl_ratio
		{
			get
			{
				return ReadSingle(0x1D4C);
			}
			set
			{
				WriteSingle(0x1D4C,value);
			}
		}
		
		/// <summary>
		/// Name: CanQueueNextAttack
		/// Type: BoolProperty
		/// Offset: 0x1D50
		/// Size: 0x01
		/// </summary>
		public bool CanQueueNextAttack
		{
			get
			{
				return ReadBool(0x1D50);
			}
			set
			{
				WriteBool(0x1D50,value);
			}
		}
		
		/// <summary>
		/// Name: IK_target
		/// Type: StructProperty
		/// Offset: 0x1D60
		/// Size: 0x30
		/// </summary>
		public FTransform IK_target => ReadStruct<FTransform>(0x1D60);
		
		/// <summary>
		/// Name: spray_attack
		/// Type: BoolProperty
		/// Offset: 0x1D90
		/// Size: 0x01
		/// </summary>
		public bool spray_attack
		{
			get
			{
				return ReadBool(0x1D90);
			}
			set
			{
				WriteBool(0x1D90,value);
			}
		}
		
		/// <summary>
		/// Name: targetloc
		/// Type: StructProperty
		/// Offset: 0x1D94
		/// Size: 0x0C
		/// </summary>
		public FVector targetloc => ReadStruct<FVector>(0x1D94);
		
		/// <summary>
		/// Name: HasTarget
		/// Type: BoolProperty
		/// Offset: 0x1DA0
		/// Size: 0x01
		/// </summary>
		public bool HasTarget
		{
			get
			{
				return ReadBool(0x1DA0);
			}
			set
			{
				WriteBool(0x1DA0,value);
			}
		}
		
		/// <summary>
		/// Name: target_root_bone_rotation
		/// Type: StructProperty
		/// Offset: 0x1DA4
		/// Size: 0x0C
		/// </summary>
		public FRotator target_root_bone_rotation => ReadStruct<FRotator>(0x1DA4);
		
		/// <summary>
		/// Name: Counter
		/// Type: FloatProperty
		/// Offset: 0x1DB0
		/// Size: 0x04
		/// </summary>
		public float Counter
		{
			get
			{
				return ReadSingle(0x1DB0);
			}
			set
			{
				WriteSingle(0x1DB0,value);
			}
		}
		
		/// <summary>
		/// Name: current_root_bone_rotation
		/// Type: StructProperty
		/// Offset: 0x1DB4
		/// Size: 0x0C
		/// </summary>
		public FRotator current_root_bone_rotation => ReadStruct<FRotator>(0x1DB4);
		
		/// <summary>
		/// Name: interpolated_root_bone_rotation
		/// Type: StructProperty
		/// Offset: 0x1DC0
		/// Size: 0x0C
		/// </summary>
		public FRotator interpolated_root_bone_rotation => ReadStruct<FRotator>(0x1DC0);
		
		/// <summary>
		/// Name: EnableAttack
		/// Type: BoolProperty
		/// Offset: 0x1DCC
		/// Size: 0x01
		/// </summary>
		public bool EnableAttack
		{
			get
			{
				return ReadBool(0x1DCC);
			}
			set
			{
				WriteBool(0x1DCC,value);
			}
		}
		
		/// <summary>
		/// Name: ActorLocation
		/// Type: StructProperty
		/// Offset: 0x1DD0
		/// Size: 0x30
		/// </summary>
		public FTransform ActorLocation => ReadStruct<FTransform>(0x1DD0);
		
	}


}

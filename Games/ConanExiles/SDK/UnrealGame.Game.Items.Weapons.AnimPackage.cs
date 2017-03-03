using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Items.Weapons.AnimPackage;


namespace ConanExilesGame.Game.Items.Weapons.AnimPackage
{
	/// <summary>
	/// UBP_AnimPackage_Base_C:UObject
	/// Size: 0xA8
	/// Properties: 26
	/// </summary>
	public class UBP_AnimPackage_Base_C:UObject
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: AttackPrimary
		/// Type: TArray<UAnimMontage>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x198
		/// </summary>
		public TArray<UAnimMontage> AttackPrimary => new TArray<UAnimMontage>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: AttackSecondary
		/// Type: TArray<UAnimMontage>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x198
		/// </summary>
		public TArray<UAnimMontage> AttackSecondary => new TArray<UAnimMontage>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: AttackDual
		/// Type: TArray<UAnimMontage>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x198
		/// </summary>
		public TArray<UAnimMontage> AttackDual => new TArray<UAnimMontage>(BaseAddress+0x48);
		
		/// <summary>
		/// Name: AttackPrimaryAllowedBasicExecute
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool AttackPrimaryAllowedBasicExecute
		{
			get
			{
				return ReadBool(0x58);
			}
			set
			{
				WriteBool(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x59
		/// Size: 0x01
		/// </summary>
		public bool AttackPrimaryAllowedSpecialCharge
		{
			get
			{
				return ReadBool(0x59);
			}
			set
			{
				WriteBool(0x59,value);
			}
		}
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x5A
		/// Size: 0x01
		/// </summary>
		public bool AttackPrimaryAllowedSpecialLoop
		{
			get
			{
				return ReadBool(0x5A);
			}
			set
			{
				WriteBool(0x5A,value);
			}
		}
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x5B
		/// Size: 0x01
		/// </summary>
		public bool AttackPrimaryAllowedSpecialExecute
		{
			get
			{
				return ReadBool(0x5B);
			}
			set
			{
				WriteBool(0x5B,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedBasicExecute
		/// Type: BoolProperty
		/// Offset: 0x5C
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedBasicExecute
		{
			get
			{
				return ReadBool(0x5C);
			}
			set
			{
				WriteBool(0x5C,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x5D
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialCharge
		{
			get
			{
				return ReadBool(0x5D);
			}
			set
			{
				WriteBool(0x5D,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x5E
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialLoop
		{
			get
			{
				return ReadBool(0x5E);
			}
			set
			{
				WriteBool(0x5E,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x5F
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialExecute
		{
			get
			{
				return ReadBool(0x5F);
			}
			set
			{
				WriteBool(0x5F,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoopExecuteOnPrimaryInput
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialLoopExecuteOnPrimaryInput
		{
			get
			{
				return ReadBool(0x60);
			}
			set
			{
				WriteBool(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialZoom
		/// Type: BoolProperty
		/// Offset: 0x61
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialZoom
		{
			get
			{
				return ReadBool(0x61);
			}
			set
			{
				WriteBool(0x61,value);
			}
		}
		
		/// <summary>
		/// Name: AttackDualAllowedBasicExecute
		/// Type: BoolProperty
		/// Offset: 0x62
		/// Size: 0x01
		/// </summary>
		public bool AttackDualAllowedBasicExecute
		{
			get
			{
				return ReadBool(0x62);
			}
			set
			{
				WriteBool(0x62,value);
			}
		}
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x63
		/// Size: 0x01
		/// </summary>
		public bool AttackDualAllowedSpecialCharge
		{
			get
			{
				return ReadBool(0x63);
			}
			set
			{
				WriteBool(0x63,value);
			}
		}
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x64
		/// Size: 0x01
		/// </summary>
		public bool AttackDualAllowedSpecialLoop
		{
			get
			{
				return ReadBool(0x64);
			}
			set
			{
				WriteBool(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x65
		/// Size: 0x01
		/// </summary>
		public bool AttackDualAllowedSpecialExecute
		{
			get
			{
				return ReadBool(0x65);
			}
			set
			{
				WriteBool(0x65,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponBlendSpace
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public UBlendSpace WeaponBlendSpace => ReadUObject<UBlendSpace>(0x68);
		
		/// <summary>
		/// Name: ItemSwap
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UAnimMontage ItemSwap => ReadUObject<UAnimMontage>(0x70);
		
		/// <summary>
		/// Name: ItemInitialize
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UAnimMontage ItemInitialize => ReadUObject<UAnimMontage>(0x78);
		
		/// <summary>
		/// Name: bLock
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UAnimMontage bLock => ReadUObject<UAnimMontage>(0x80);
		
		/// <summary>
		/// Name: isSecondaryAllowedToAnimate
		/// Type: BoolProperty
		/// Offset: 0x88
		/// Size: 0x01
		/// </summary>
		public bool isSecondaryAllowedToAnimate
		{
			get
			{
				return ReadBool(0x88);
			}
			set
			{
				WriteBool(0x88,value);
			}
		}
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoopToSettleOnSpecialLoopEnd
		/// Type: BoolProperty
		/// Offset: 0x89
		/// Size: 0x01
		/// </summary>
		public bool AttackSecondaryAllowedSpecialLoopToSettleOnSpecialLoopEnd
		{
			get
			{
				return ReadBool(0x89);
			}
			set
			{
				WriteBool(0x89,value);
			}
		}
		
		/// <summary>
		/// Name: ItemDiscard
		/// Type: ObjectProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		public UAnimMontage ItemDiscard => ReadUObject<UAnimMontage>(0x90);
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialLoopExecuteOnSecondaryInput
		/// Type: BoolProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public bool AttackPrimaryAllowedSpecialLoopExecuteOnSecondaryInput
		{
			get
			{
				return ReadBool(0x98);
			}
			set
			{
				WriteBool(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponAnimIdle
		/// Type: ObjectProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public UAnimSequenceBase WeaponAnimIdle => ReadUObject<UAnimSequenceBase>(0xA0);
		
	}


	/// <summary>
	/// UBP_waterskin_1st_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_waterskin_1st_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UBP_waterskin_3rd_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_waterskin_3rd_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UBP_dagger_oh_1st_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_dagger_oh_1st_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UBP_Club1h_3rd_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_Club1h_3rd_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UBP_dagger_oh_3rd_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_dagger_oh_3rd_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UBP_Club1h_1st_C:UBP_AnimPackage_Base_C
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UBP_Club1h_1st_C:UBP_AnimPackage_Base_C
	{
		public override int ObjectSize => 168;
	}


}

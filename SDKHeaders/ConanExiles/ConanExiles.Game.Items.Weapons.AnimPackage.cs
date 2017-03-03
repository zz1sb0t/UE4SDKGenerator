using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Script;
using ConanExiles.Game.Items.Weapons.AnimPackage;


namespace ConanExiles.Game.Items.Weapons.AnimPackage
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
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x59
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x5A
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackPrimaryAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x5B
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedBasicExecute
		/// Type: BoolProperty
		/// Offset: 0x5C
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x5D
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x5E
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x5F
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoopExecuteOnPrimaryInput
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialZoom
		/// Type: BoolProperty
		/// Offset: 0x61
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackDualAllowedBasicExecute
		/// Type: BoolProperty
		/// Offset: 0x62
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialCharge
		/// Type: BoolProperty
		/// Offset: 0x63
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialLoop
		/// Type: BoolProperty
		/// Offset: 0x64
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: AttackDualAllowedSpecialExecute
		/// Type: BoolProperty
		/// Offset: 0x65
		/// Size: 0x01
		/// </summary>
		
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
		
		/// <summary>
		/// Name: AttackSecondaryAllowedSpecialLoopToSettleOnSpecialLoopEnd
		/// Type: BoolProperty
		/// Offset: 0x89
		/// Size: 0x01
		/// </summary>
		
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

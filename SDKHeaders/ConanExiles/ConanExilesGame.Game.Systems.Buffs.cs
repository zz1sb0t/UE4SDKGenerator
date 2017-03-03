using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.HUD;
using ConanExilesGame.Game.UI.HUD.Notifications;
using ConanExilesGame.Game.Systems.Buffs;


namespace ConanExilesGame.Game.Systems.Buffs
{
	/// <summary>
	/// U01_BP_AC_Buff_Master_C:UActorComponent
	/// Size: 0x5F8
	/// Properties: 28
	/// </summary>
	public class U01_BP_AC_Buff_Master_C:UActorComponent
	{
		public override int ObjectSize => 1528;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: BuffTicks
		/// Type: IntProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public int BuffTicks
		{
			get
			{
				return ReadInt32(0xE0);
			}
			set
			{
				WriteInt32(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: DoesNotExpire
		/// Type: BoolProperty
		/// Offset: 0xE4
		/// Size: 0x01
		/// </summary>
		public bool DoesNotExpire
		{
			get
			{
				return ReadBool(0xE4);
			}
			set
			{
				WriteBool(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: BuffTickDuration
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float BuffTickDuration
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: BuffTicks_Remaining
		/// Type: IntProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public int BuffTicks_Remaining
		{
			get
			{
				return ReadInt32(0xEC);
			}
			set
			{
				WriteInt32(0xEC,value);
			}
		}
		
		/// <summary>
		/// Name: Instigator
		/// Type: ObjectProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public AActor Instigator => ReadUObject<AActor>(0xF0);
		
		/// <summary>
		/// Name: AllowMultipleBuffInstances
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool AllowMultipleBuffInstances
		{
			get
			{
				return ReadBool(0xF8);
			}
			set
			{
				WriteBool(0xF8,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeReplaced
		/// Type: BoolProperty
		/// Offset: 0xF9
		/// Size: 0x01
		/// </summary>
		public bool CanBeReplaced
		{
			get
			{
				return ReadBool(0xF9);
			}
			set
			{
				WriteBool(0xF9,value);
			}
		}
		
		/// <summary>
		/// Name: ShouldStack
		/// Type: BoolProperty
		/// Offset: 0xFA
		/// Size: 0x01
		/// </summary>
		public bool ShouldStack
		{
			get
			{
				return ReadBool(0xFA);
			}
			set
			{
				WriteBool(0xFA,value);
			}
		}
		
		/// <summary>
		/// Name: RefreshTotalTicksOnStackIncrease
		/// Type: BoolProperty
		/// Offset: 0xFB
		/// Size: 0x01
		/// </summary>
		public bool RefreshTotalTicksOnStackIncrease
		{
			get
			{
				return ReadBool(0xFB);
			}
			set
			{
				WriteBool(0xFB,value);
			}
		}
		
		/// <summary>
		/// Name: stackSize
		/// Type: IntProperty
		/// Offset: 0xFC
		/// Size: 0x04
		/// </summary>
		public int stackSize
		{
			get
			{
				return ReadInt32(0xFC);
			}
			set
			{
				WriteInt32(0xFC,value);
			}
		}
		
		/// <summary>
		/// Name: StackSizeMax
		/// Type: IntProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public int StackSizeMax
		{
			get
			{
				return ReadInt32(0x100);
			}
			set
			{
				WriteInt32(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: PostprocessingEffect
		/// Type: StructProperty
		/// Offset: 0x108
		/// Size: 0x3A0
		/// </summary>
		public FPostProcessSettings PostprocessingEffect => ReadStruct<FPostProcessSettings>(0x108);
		
		/// <summary>
		/// Name: PostProcessingComponent
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UActorComponent PostProcessingComponent => ReadUObject<UActorComponent>(0x4A8);
		
		/// <summary>
		/// Name: FullScreenWidget
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UW_FullScreenBuffEffect_C FullScreenWidget => ReadUObject<UW_FullScreenBuffEffect_C>(0x4B0);
		
		/// <summary>
		/// Name: BuffWidget
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UW_HUD_BuffEntry_C BuffWidget => ReadUObject<UW_HUD_BuffEntry_C>(0x4B8);
		
		/// <summary>
		/// Name: Name
		/// Type: TextProperty
		/// Offset: 0x4C0
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public UTexture2D Icon => ReadUObject<UTexture2D>(0x4D8);
		
		/// <summary>
		/// Name: EffectBrush
		/// Type: StructProperty
		/// Offset: 0x4E0
		/// Size: 0x90
		/// </summary>
		public FSlateBrush EffectBrush => ReadStruct<FSlateBrush>(0x4E0);
		
		/// <summary>
		/// Name: Color
		/// Type: StructProperty
		/// Offset: 0x570
		/// Size: 0x10
		/// </summary>
		public FLinearColor Color => ReadStruct<FLinearColor>(0x570);
		
		/// <summary>
		/// Name: BuffPriority
		/// Type: IntProperty
		/// Offset: 0x580
		/// Size: 0x04
		/// </summary>
		public int BuffPriority
		{
			get
			{
				return ReadInt32(0x580);
			}
			set
			{
				WriteInt32(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: BuffSound
		/// Type: ObjectProperty
		/// Offset: 0x588
		/// Size: 0x08
		/// </summary>
		public USoundCue BuffSound => ReadUObject<USoundCue>(0x588);
		
		/// <summary>
		/// Name: AudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x590
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent AudioComponent => ReadUObject<UConanAudioComponent>(0x590);
		
		/// <summary>
		/// Name: DebuffType
		/// Type: ByteProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public byte DebuffType
		{
			get
			{
				return ReadByte(0x5D8);
			}
			set
			{
				WriteByte(0x5D8,value);
			}
		}
		
		/// <summary>
		/// Name: ShowInUI
		/// Type: BoolProperty
		/// Offset: 0x5D9
		/// Size: 0x01
		/// </summary>
		public bool ShowInUI
		{
			get
			{
				return ReadBool(0x5D9);
			}
			set
			{
				WriteBool(0x5D9,value);
			}
		}
		
		/// <summary>
		/// Name: DamageEffect
		/// Type: ObjectProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public UMaterial DamageEffect => ReadUObject<UMaterial>(0x5E0);
		
		/// <summary>
		/// Name: BuffPotency
		/// Type: IntProperty
		/// Offset: 0x5E8
		/// Size: 0x04
		/// </summary>
		public int BuffPotency
		{
			get
			{
				return ReadInt32(0x5E8);
			}
			set
			{
				WriteInt32(0x5E8,value);
			}
		}
		
		/// <summary>
		/// Name: OwningCharacter
		/// Type: ObjectProperty
		/// Offset: 0x5F0
		/// Size: 0x08
		/// </summary>
		public AConanCharacter OwningCharacter => ReadUObject<AConanCharacter>(0x5F0);
		
	}


	/// <summary>
	/// U00_BP_AC_BuffSystem_C:UActorComponent
	/// Size: 0x108
	/// Properties: 6
	/// </summary>
	public class U00_BP_AC_BuffSystem_C:UActorComponent
	{
		public override int ObjectSize => 264;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: BuffBeingAdjusted
		/// Type: ClassProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ExistingBuffComponent
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UActorComponent ExistingBuffComponent => ReadUObject<UActorComponent>(0xE8);
		
		/// <summary>
		/// Name: Instigator
		/// Type: ObjectProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public AActor Instigator => ReadUObject<AActor>(0xF0);
		
		/// <summary>
		/// Name: LocalPotency
		/// Type: IntProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public int LocalPotency
		{
			get
			{
				return ReadInt32(0xF8);
			}
			set
			{
				WriteInt32(0xF8,value);
			}
		}
		
		/// <summary>
		/// Name: Owning_Character
		/// Type: ObjectProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public AConanCharacter Owning_Character => ReadUObject<AConanCharacter>(0x100);
		
	}


	/// <summary>
	/// U00_BP_AC_Buff_StackingPotencyBuff_C:U01_BP_AC_Buff_Master_C
	/// Size: 0x604
	/// Properties: 2
	/// </summary>
	public class U00_BP_AC_Buff_StackingPotencyBuff_C:U01_BP_AC_Buff_Master_C
	{
		public override int ObjectSize => 1540;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5F8);
		
		/// <summary>
		/// Name: Potency
		/// Type: FloatProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public float Potency
		{
			get
			{
				return ReadSingle(0x600);
			}
			set
			{
				WriteSingle(0x600,value);
			}
		}
		
	}


}

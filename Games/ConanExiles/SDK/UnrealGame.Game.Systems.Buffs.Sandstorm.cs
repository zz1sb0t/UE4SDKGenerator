using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Systems.Buffs;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Buffs.Sandstorm
{
	/// <summary>
	/// UBP_AC_SandStorm_Damage_C:U01_BP_AC_Buff_Master_C
	/// Size: 0x651
	/// Properties: 11
	/// </summary>
	public class UBP_AC_SandStorm_Damage_C:U01_BP_AC_Buff_Master_C
	{
		public override int ObjectSize => 1617;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5F8);
		
		/// <summary>
		/// Name: DamagePerBuffTick
		/// Type: FloatProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public float DamagePerBuffTick
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
		
		/// <summary>
		/// Name: MonsterArray
		/// Type: TArray<APawn>
		/// Offset: 0x608
		/// Size: 0x10
		/// SubElement Size: 0x430
		/// </summary>
		public TArray<APawn> MonsterArray => new TArray<APawn>(BaseAddress+0x608);
		
		/// <summary>
		/// Name: LineTraceAttempts
		/// Type: IntProperty
		/// Offset: 0x618
		/// Size: 0x04
		/// </summary>
		public int LineTraceAttempts
		{
			get
			{
				return ReadInt32(0x618);
			}
			set
			{
				WriteInt32(0x618,value);
			}
		}
		
		/// <summary>
		/// Name: MonsterSpawnParticle
		/// Type: ObjectProperty
		/// Offset: 0x620
		/// Size: 0x08
		/// </summary>
		public UParticleSystem MonsterSpawnParticle => ReadUObject<UParticleSystem>(0x620);
		
		/// <summary>
		/// Name: SandstormParticleSpawned
		/// Type: BoolProperty
		/// Offset: 0x628
		/// Size: 0x01
		/// </summary>
		public bool SandstormParticleSpawned
		{
			get
			{
				return ReadBool(0x628);
			}
			set
			{
				WriteBool(0x628,value);
			}
		}
		
		/// <summary>
		/// Name: Wind
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public AWindDirectionalSource Wind => ReadUObject<AWindDirectionalSource>(0x630);
		
		/// <summary>
		/// Name: DebrisSpawned
		/// Type: BoolProperty
		/// Offset: 0x638
		/// Size: 0x01
		/// </summary>
		public bool DebrisSpawned
		{
			get
			{
				return ReadBool(0x638);
			}
			set
			{
				WriteBool(0x638,value);
			}
		}
		
		/// <summary>
		/// Name: ParticlesComponent
		/// Type: ObjectProperty
		/// Offset: 0x640
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticlesComponent => ReadUObject<UParticleSystemComponent>(0x640);
		
		/// <summary>
		/// Name: DebrisComponent
		/// Type: ObjectProperty
		/// Offset: 0x648
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent DebrisComponent => ReadUObject<UParticleSystemComponent>(0x648);
		
		/// <summary>
		/// Name: DEBUG_DisableMonsterSpawns
		/// Type: BoolProperty
		/// Offset: 0x650
		/// Size: 0x01
		/// </summary>
		public bool DEBUG_DisableMonsterSpawns
		{
			get
			{
				return ReadBool(0x650);
			}
			set
			{
				WriteBool(0x650,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_AC_Sandstorm_Gear_C:U01_BP_AC_Buff_Master_C
	/// Size: 0x600
	/// Properties: 1
	/// </summary>
	public class UBP_AC_Sandstorm_Gear_C:U01_BP_AC_Buff_Master_C
	{
		public override int ObjectSize => 1536;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x5F8);
		
	}


}

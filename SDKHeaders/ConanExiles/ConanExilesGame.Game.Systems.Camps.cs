using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Camps;


namespace ConanExilesGame.Game.Systems.Camps
{
	/// <summary>
	/// ABP_MasterCampPlaceable_C:ASuspendableActor
	/// Size: 0x3F5
	/// Properties: 5
	/// </summary>
	public class ABP_MasterCampPlaceable_C:ASuspendableActor
	{
		public override int ObjectSize => 1013;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D8);
		
		/// <summary>
		/// Name: AILOD
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UAILODComponent AILOD => ReadUObject<UAILODComponent>(0x3E0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: Health
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float Health
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: IsCampEssential
		/// Type: BoolProperty
		/// Offset: 0x3F4
		/// Size: 0x01
		/// </summary>
		public bool IsCampEssential
		{
			get
			{
				return ReadBool(0x3F4);
			}
			set
			{
				WriteBool(0x3F4,value);
			}
		}
		
	}


	/// <summary>
	/// UI_CampActorInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_CampActorInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_CampSystemComponent_C:UActorComponent
	/// Size: 0x108
	/// Properties: 8
	/// </summary>
	public class UBP_CampSystemComponent_C:UActorComponent
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
		/// Name: RegisteredCamps
		/// Type: TArray<UBP_CampComponent_C>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x1C0
		/// </summary>
		public TArray<UBP_CampComponent_C> RegisteredCamps => new TArray<UBP_CampComponent_C>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: HasBegunPlay
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool HasBegunPlay
		{
			get
			{
				return ReadBool(0xF0);
			}
			set
			{
				WriteBool(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentCampLayer
		/// Type: IntProperty
		/// Offset: 0xF4
		/// Size: 0x04
		/// </summary>
		public int CurrentCampLayer
		{
			get
			{
				return ReadInt32(0xF4);
			}
			set
			{
				WriteInt32(0xF4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxCampLayer
		/// Type: IntProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public int MaxCampLayer
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
		/// Name: CampRespawnTime
		/// Type: FloatProperty
		/// Offset: 0xFC
		/// Size: 0x04
		/// </summary>
		public float CampRespawnTime
		{
			get
			{
				return ReadSingle(0xFC);
			}
			set
			{
				WriteSingle(0xFC,value);
			}
		}
		
		/// <summary>
		/// Name: LoadingIsDone
		/// Type: BoolProperty
		/// Offset: 0x100
		/// Size: 0x01
		/// </summary>
		public bool LoadingIsDone
		{
			get
			{
				return ReadBool(0x100);
			}
			set
			{
				WriteBool(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: CampRespawnExclusionRadius
		/// Type: FloatProperty
		/// Offset: 0x104
		/// Size: 0x04
		/// </summary>
		public float CampRespawnExclusionRadius
		{
			get
			{
				return ReadSingle(0x104);
			}
			set
			{
				WriteSingle(0x104,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_CampComponent_C:UActorComponent
	/// Size: 0x1C0
	/// Properties: 22
	/// </summary>
	public class UBP_CampComponent_C:UActorComponent
	{
		public override int ObjectSize => 448;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: CampSystem
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UBP_CampSystemComponent_C CampSystem => ReadUObject<UBP_CampSystemComponent_C>(0xE0);
		
		/// <summary>
		/// Name: CampActors
		/// Type: TArray<AActor>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> CampActors => new TArray<AActor>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: CampLayer
		/// Type: TArray<>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CachedWaypoints
		/// Type: TArray<AStaticWaypoint>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x3E0
		/// </summary>
		public TArray<AStaticWaypoint> CachedWaypoints => new TArray<AStaticWaypoint>(BaseAddress+0x108);
		
		/// <summary>
		/// Name: CachedSpawnPoints
		/// Type: TArray<AStaticSpawnPoint>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x3D8
		/// </summary>
		public TArray<AStaticSpawnPoint> CachedSpawnPoints => new TArray<AStaticSpawnPoint>(BaseAddress+0x118);
		
		/// <summary>
		/// Name: IsSpawnPointAndWaypointCacheValid
		/// Type: BoolProperty
		/// Offset: 0x128
		/// Size: 0x01
		/// </summary>
		public bool IsSpawnPointAndWaypointCacheValid
		{
			get
			{
				return ReadBool(0x128);
			}
			set
			{
				WriteBool(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: CampActorData
		/// Type: TArray<FST_CampActor>
		/// Offset: 0x130
		/// Size: 0x10
		/// SubElement Size: 0x44
		/// </summary>
		public TArray<FST_CampActor> CampActorData => new TArray<FST_CampActor>(BaseAddress+0x130);
		
		/// <summary>
		/// Name: IsCampActive
		/// Type: BoolProperty
		/// Offset: 0x140
		/// Size: 0x01
		/// </summary>
		public bool IsCampActive
		{
			get
			{
				return ReadBool(0x140);
			}
			set
			{
				WriteBool(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: RespawningActors
		/// Type: TArray<FST_CampActor>
		/// Offset: 0x148
		/// Size: 0x10
		/// SubElement Size: 0x44
		/// </summary>
		public TArray<FST_CampActor> RespawningActors => new TArray<FST_CampActor>(BaseAddress+0x148);
		
		/// <summary>
		/// Name: DestroyedActors
		/// Type: TArray<FST_CampActor>
		/// Offset: 0x158
		/// Size: 0x10
		/// SubElement Size: 0x44
		/// </summary>
		public TArray<FST_CampActor> DestroyedActors => new TArray<FST_CampActor>(BaseAddress+0x158);
		
		/// <summary>
		/// Name: CurrentRespawnTargetTime
		/// Type: FloatProperty
		/// Offset: 0x168
		/// Size: 0x04
		/// </summary>
		public float CurrentRespawnTargetTime
		{
			get
			{
				return ReadSingle(0x168);
			}
			set
			{
				WriteSingle(0x168,value);
			}
		}
		
		/// <summary>
		/// Name: CampEssentials
		/// Type: TArray<AActor>
		/// Offset: 0x170
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> CampEssentials => new TArray<AActor>(BaseAddress+0x170);
		
		/// <summary>
		/// Name: HasCampEssentials
		/// Type: BoolProperty
		/// Offset: 0x180
		/// Size: 0x01
		/// </summary>
		public bool HasCampEssentials
		{
			get
			{
				return ReadBool(0x180);
			}
			set
			{
				WriteBool(0x180,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerPawnRegistry
		/// Type: ObjectProperty
		/// Offset: 0x188
		/// Size: 0x08
		/// </summary>
		public APlayerPawnRegistry PlayerPawnRegistry => ReadUObject<APlayerPawnRegistry>(0x188);
		
		/// <summary>
		/// Name: ForceCampActive
		/// Type: BoolProperty
		/// Offset: 0x190
		/// Size: 0x01
		/// </summary>
		public bool ForceCampActive
		{
			get
			{
				return ReadBool(0x190);
			}
			set
			{
				WriteBool(0x190,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerBuilt_Claim_Radius
		/// Type: FloatProperty
		/// Offset: 0x194
		/// Size: 0x04
		/// </summary>
		public float PlayerBuilt_Claim_Radius
		{
			get
			{
				return ReadSingle(0x194);
			}
			set
			{
				WriteSingle(0x194,value);
			}
		}
		
		/// <summary>
		/// Name: LandClaimChecker
		/// Type: StructProperty
		/// Offset: 0x198
		/// Size: 0x08
		/// </summary>
		public FTimerHandle LandClaimChecker => ReadStruct<FTimerHandle>(0x198);
		
		/// <summary>
		/// Name: RetryRegistrationCounter
		/// Type: IntProperty
		/// Offset: 0x1A0
		/// Size: 0x04
		/// </summary>
		public int RetryRegistrationCounter
		{
			get
			{
				return ReadInt32(0x1A0);
			}
			set
			{
				WriteInt32(0x1A0,value);
			}
		}
		
		/// <summary>
		/// Name: DebugState
		/// Type: ByteProperty
		/// Offset: 0x1A4
		/// Size: 0x01
		/// </summary>
		public byte DebugState
		{
			get
			{
				return ReadByte(0x1A4);
			}
			set
			{
				WriteByte(0x1A4,value);
			}
		}
		
		/// <summary>
		/// Name: TerritorySpawners
		/// Type: TArray<AActor>
		/// Offset: 0x1A8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> TerritorySpawners => new TArray<AActor>(BaseAddress+0x1A8);
		
		/// <summary>
		/// Name: DeactivatedLandClaimTimer
		/// Type: StructProperty
		/// Offset: 0x1B8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle DeactivatedLandClaimTimer => ReadStruct<FTimerHandle>(0x1B8);
		
	}


	/// <summary>
	/// FST_CampActor:
	/// Size: 0x44
	/// Properties: 3
	/// </summary>
	public class FST_CampActor:MemoryObject
	{
		public override int ObjectSize => 68;
		/// <summary>
		/// Name: Class_2_8E6885B74BE97225CB278EA14C5AADE0
		/// Type: ClassProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Transform_5_FD192A7042FB735C13E1A3AC6CDFBA45
		/// Type: StructProperty
		/// Offset: 0x10
		/// Size: 0x30
		/// </summary>
		public FTransform Transform_5_FD192A7042FB735C13E1A3AC6CDFBA45 => ReadStruct<FTransform>(0x10);
		
		/// <summary>
		/// Name: RespawnTime_8_0E1A69EA4F295743E8A92090C6002850
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float RespawnTime_8_0E1A69EA4F295743E8A92090C6002850
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// UI_CampComponentInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UI_CampComponentInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ABP_CampOwner_C:AActor
	/// Size: 0x3F0
	/// Properties: 4
	/// </summary>
	public class ABP_CampOwner_C:AActor
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: BP_CampComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UBP_CampComponent_C BP_CampComponent => ReadUObject<UBP_CampComponent_C>(0x3D8);
		
		/// <summary>
		/// Name: Billboard
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent Billboard => ReadUObject<UBillboardComponent>(0x3E0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
	}


}

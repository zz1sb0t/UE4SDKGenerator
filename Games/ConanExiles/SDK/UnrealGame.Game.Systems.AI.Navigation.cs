using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Spawning.SpawnInputs;


namespace ConanExilesGame.Game.Systems.AI.Navigation
{
	/// <summary>
	/// UNavQueryFilter_Default_C:UNavigationQueryFilter
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UNavQueryFilter_Default_C:UNavigationQueryFilter
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UNavArea_Water_C:UNavArea
	/// Size: 0x40
	/// Properties: 0
	/// </summary>
	public class UNavArea_Water_C:UNavArea
	{
		public override int ObjectSize => 64;
	}


	/// <summary>
	/// ABP_ManualSpawnPoint_C:AStaticSpawnPoint
	/// Size: 0x418
	/// Properties: 10
	/// </summary>
	public class ABP_ManualSpawnPoint_C:AStaticSpawnPoint
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D8);
		
		/// <summary>
		/// Name: WildlifeOptions
		/// Type: TArray<FNPCSpawnEntry>
		/// Offset: 0x3E0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FNPCSpawnEntry> WildlifeOptions => new TArray<FNPCSpawnEntry>(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: HumanOptions
		/// Type: TArray<FNPCHumanSpawnEntry>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FNPCHumanSpawnEntry> HumanOptions => new TArray<FNPCHumanSpawnEntry>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: HasSpawned
		/// Type: BoolProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public bool HasSpawned
		{
			get
			{
				return ReadBool(0x400);
			}
			set
			{
				WriteBool(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: AllowRespawn
		/// Type: BoolProperty
		/// Offset: 0x401
		/// Size: 0x01
		/// </summary>
		public bool AllowRespawn
		{
			get
			{
				return ReadBool(0x401);
			}
			set
			{
				WriteBool(0x401,value);
			}
		}
		
		/// <summary>
		/// Name: IsGuardSpot
		/// Type: BoolProperty
		/// Offset: 0x402
		/// Size: 0x01
		/// </summary>
		public bool IsGuardSpot
		{
			get
			{
				return ReadBool(0x402);
			}
			set
			{
				WriteBool(0x402,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteState
		/// Type: ByteProperty
		/// Offset: 0x403
		/// Size: 0x01
		/// </summary>
		public byte EmoteState
		{
			get
			{
				return ReadByte(0x403);
			}
			set
			{
				WriteByte(0x403,value);
			}
		}
		
		/// <summary>
		/// Name: RespawnTimer
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RespawnTimer
		{
			get
			{
				return ReadSingle(0x404);
			}
			set
			{
				WriteSingle(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: WaitingForRespawn
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool WaitingForRespawn
		{
			get
			{
				return ReadBool(0x408);
			}
			set
			{
				WriteBool(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: RespawnTimerHandle
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public FTimerHandle RespawnTimerHandle => ReadStruct<FTimerHandle>(0x410);
		
	}


	/// <summary>
	/// UStaticNavigationGenerator_C:UActorComponent
	/// Size: 0x110
	/// Properties: 10
	/// </summary>
	public class UStaticNavigationGenerator_C:UActorComponent
	{
		public override int ObjectSize => 272;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: JustGeneratedSpawnPoints
		/// Type: TArray<FVector>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> JustGeneratedSpawnPoints => new TArray<FVector>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: RoamingPathSegmentMinLength
		/// Type: FloatProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public float RoamingPathSegmentMinLength
		{
			get
			{
				return ReadSingle(0xF0);
			}
			set
			{
				WriteSingle(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathSegmentMaxLength
		/// Type: FloatProperty
		/// Offset: 0xF4
		/// Size: 0x04
		/// </summary>
		public float RoamingPathSegmentMaxLength
		{
			get
			{
				return ReadSingle(0xF4);
			}
			set
			{
				WriteSingle(0xF4,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathMaxTurnAngle
		/// Type: FloatProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public float RoamingPathMaxTurnAngle
		{
			get
			{
				return ReadSingle(0xF8);
			}
			set
			{
				WriteSingle(0xF8,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathMaxPointCount
		/// Type: IntProperty
		/// Offset: 0xFC
		/// Size: 0x04
		/// </summary>
		public int RoamingPathMaxPointCount
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
		/// Name: MaxFailCountperpoint
		/// Type: IntProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public int MaxFailCountperpoint
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
		/// Name: RoamingPathMaxLoopCount
		/// Type: IntProperty
		/// Offset: 0x104
		/// Size: 0x04
		/// </summary>
		public int RoamingPathMaxLoopCount
		{
			get
			{
				return ReadInt32(0x104);
			}
			set
			{
				WriteInt32(0x104,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathMaxLength
		/// Type: FloatProperty
		/// Offset: 0x108
		/// Size: 0x04
		/// </summary>
		public float RoamingPathMaxLength
		{
			get
			{
				return ReadSingle(0x108);
			}
			set
			{
				WriteSingle(0x108,value);
			}
		}
		
		/// <summary>
		/// Name: RoamingPathMinRadius
		/// Type: FloatProperty
		/// Offset: 0x10C
		/// Size: 0x04
		/// </summary>
		public float RoamingPathMinRadius
		{
			get
			{
				return ReadSingle(0x10C);
			}
			set
			{
				WriteSingle(0x10C,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_StaticNavigationVisualizerComponent_C:UActorComponent
	/// Size: 0x110
	/// Properties: 10
	/// </summary>
	public class UBP_StaticNavigationVisualizerComponent_C:UActorComponent
	{
		public override int ObjectSize => 272;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: StaticNavigation
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UStaticNavigation StaticNavigation => ReadUObject<UStaticNavigation>(0xE0);
		
		/// <summary>
		/// Name: DrawRadius
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float DrawRadius
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
		/// Name: SpawnPointEndIndex
		/// Type: IntProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public int SpawnPointEndIndex
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
		/// Name: RoamingPathEndIndex
		/// Type: IntProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public int RoamingPathEndIndex
		{
			get
			{
				return ReadInt32(0xF0);
			}
			set
			{
				WriteInt32(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnPointStartIndex
		/// Type: IntProperty
		/// Offset: 0xF4
		/// Size: 0x04
		/// </summary>
		public int SpawnPointStartIndex
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
		/// Name: RoamingPathStartIndex
		/// Type: IntProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public int RoamingPathStartIndex
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
		/// Name: Index
		/// Type: IntProperty
		/// Offset: 0xFC
		/// Size: 0x04
		/// </summary>
		public int Index
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
		/// Name: PlayerLocation
		/// Type: StructProperty
		/// Offset: 0x100
		/// Size: 0x0C
		/// </summary>
		public FVector PlayerLocation => ReadStruct<FVector>(0x100);
		
		/// <summary>
		/// Name: DrawDuration
		/// Type: FloatProperty
		/// Offset: 0x10C
		/// Size: 0x04
		/// </summary>
		public float DrawDuration
		{
			get
			{
				return ReadSingle(0x10C);
			}
			set
			{
				WriteSingle(0x10C,value);
			}
		}
		
	}


	/// <summary>
	/// UNavQueryFilter_LandAndWater_C:UNavigationQueryFilter
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UNavQueryFilter_LandAndWater_C:UNavigationQueryFilter
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UNavQueryFilter_WaterOnly_C:UNavigationQueryFilter
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UNavQueryFilter_WaterOnly_C:UNavigationQueryFilter
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// ABP_ManualWaypoint_C:AStaticWaypoint
	/// Size: 0x3E8
	/// Properties: 1
	/// </summary>
	public class ABP_ManualWaypoint_C:AStaticWaypoint
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: Arrow
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UArrowComponent Arrow => ReadUObject<UArrowComponent>(0x3E0);
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Dev.DebugHelpers
{
	/// <summary>
	/// AFakePlayer_C:ABasePlayerChar_C
	/// Size: 0x1638
	/// Properties: 14
	/// </summary>
	public class AFakePlayer_C:ABasePlayerChar_C
	{
		public override int ObjectSize => 5688;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x15E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x15E0);
		
		/// <summary>
		/// Name: PlayerMarker
		/// Type: ObjectProperty
		/// Offset: 0x15E8
		/// Size: 0x08
		/// </summary>
		public UPlayerMarkerComponent PlayerMarker => ReadUObject<UPlayerMarkerComponent>(0x15E8);
		
		/// <summary>
		/// Name: StartTime
		/// Type: StructProperty
		/// Offset: 0x15F0
		/// Size: 0x08
		/// </summary>
		public FDateTime StartTime => ReadStruct<FDateTime>(0x15F0);
		
		/// <summary>
		/// Name: EndTime
		/// Type: StructProperty
		/// Offset: 0x15F8
		/// Size: 0x08
		/// </summary>
		public FDateTime EndTime => ReadStruct<FDateTime>(0x15F8);
		
		/// <summary>
		/// Name: DebugDrawExtentDuration
		/// Type: FloatProperty
		/// Offset: 0x1600
		/// Size: 0x04
		/// </summary>
		public float DebugDrawExtentDuration
		{
			get
			{
				return ReadSingle(0x1600);
			}
			set
			{
				WriteSingle(0x1600,value);
			}
		}
		
		/// <summary>
		/// Name: Bounce
		/// Type: BoolProperty
		/// Offset: 0x1604
		/// Size: 0x01
		/// </summary>
		public bool Bounce
		{
			get
			{
				return ReadBool(0x1604);
			}
			set
			{
				WriteBool(0x1604,value);
			}
		}
		
		/// <summary>
		/// Name: BounceDirection
		/// Type: StructProperty
		/// Offset: 0x1608
		/// Size: 0x0C
		/// </summary>
		public FVector BounceDirection => ReadStruct<FVector>(0x1608);
		
		/// <summary>
		/// Name: BounceInitialized
		/// Type: BoolProperty
		/// Offset: 0x1614
		/// Size: 0x01
		/// </summary>
		public bool BounceInitialized
		{
			get
			{
				return ReadBool(0x1614);
			}
			set
			{
				WriteBool(0x1614,value);
			}
		}
		
		/// <summary>
		/// Name: NextDirectionChangeTime
		/// Type: FloatProperty
		/// Offset: 0x1618
		/// Size: 0x04
		/// </summary>
		public float NextDirectionChangeTime
		{
			get
			{
				return ReadSingle(0x1618);
			}
			set
			{
				WriteSingle(0x1618,value);
			}
		}
		
		/// <summary>
		/// Name: BounceMaxLinearStretchSeconds
		/// Type: FloatProperty
		/// Offset: 0x161C
		/// Size: 0x04
		/// </summary>
		public float BounceMaxLinearStretchSeconds
		{
			get
			{
				return ReadSingle(0x161C);
			}
			set
			{
				WriteSingle(0x161C,value);
			}
		}
		
		/// <summary>
		/// Name: BounceForceDirectionChangeMaxAngle
		/// Type: FloatProperty
		/// Offset: 0x1620
		/// Size: 0x04
		/// </summary>
		public float BounceForceDirectionChangeMaxAngle
		{
			get
			{
				return ReadSingle(0x1620);
			}
			set
			{
				WriteSingle(0x1620,value);
			}
		}
		
		/// <summary>
		/// Name: PrevLocation
		/// Type: StructProperty
		/// Offset: 0x1624
		/// Size: 0x0C
		/// </summary>
		public FVector PrevLocation => ReadStruct<FVector>(0x1624);
		
		/// <summary>
		/// Name: NextBlockCheckTime
		/// Type: FloatProperty
		/// Offset: 0x1630
		/// Size: 0x04
		/// </summary>
		public float NextBlockCheckTime
		{
			get
			{
				return ReadSingle(0x1630);
			}
			set
			{
				WriteSingle(0x1630,value);
			}
		}
		
		/// <summary>
		/// Name: MaxBlockTime
		/// Type: FloatProperty
		/// Offset: 0x1634
		/// Size: 0x04
		/// </summary>
		public float MaxBlockTime
		{
			get
			{
				return ReadSingle(0x1634);
			}
			set
			{
				WriteSingle(0x1634,value);
			}
		}
		
	}


	/// <summary>
	/// AHeatmapGenerator_C:AActor
	/// Size: 0x420
	/// Properties: 6
	/// </summary>
	public class AHeatmapGenerator_C:AActor
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: SlackUser
		/// Type: StrProperty
		/// Offset: 0x3E0
		/// Size: 0x10
		/// </summary>
		public FString SlackUser => new FString(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: ClassesToFind
		/// Type: TArray<>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: GeneratedData
		/// Type: StrProperty
		/// Offset: 0x400
		/// Size: 0x10
		/// </summary>
		public FString GeneratedData => new FString(BaseAddress+0x400);
		
		/// <summary>
		/// Name: DataList
		/// Type: TArray<>
		/// Offset: 0x410
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


}

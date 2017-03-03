using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Debug
{
	/// <summary>
	/// ABPSharedDebugInfo_C:ASharedDebugInfo
	/// Size: 0x3F0
	/// Properties: 4
	/// </summary>
	public class ABPSharedDebugInfo_C:ASharedDebugInfo
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: OnlinePlayerCount
		/// Type: IntProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public int OnlinePlayerCount
		{
			get
			{
				return ReadInt32(0x3E8);
			}
			set
			{
				WriteInt32(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: ServerFPS
		/// Type: IntProperty
		/// Offset: 0x3EC
		/// Size: 0x04
		/// </summary>
		public int ServerFPS
		{
			get
			{
				return ReadInt32(0x3EC);
			}
			set
			{
				WriteInt32(0x3EC,value);
			}
		}
		
	}


}

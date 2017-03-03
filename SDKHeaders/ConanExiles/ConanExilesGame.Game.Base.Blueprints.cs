using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Base.Blueprints
{
	/// <summary>
	/// ABP_Client_Trigger_PlayerSpawnSwitch_C:AActor
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class ABP_Client_Trigger_PlayerSpawnSwitch_C:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3D8);
		
	}


}

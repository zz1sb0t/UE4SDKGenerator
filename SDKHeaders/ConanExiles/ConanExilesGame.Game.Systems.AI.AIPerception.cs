using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI.AI_Controllers;


namespace ConanExilesGame.Game.Systems.AI.AIPerception
{
	/// <summary>
	/// UBTService_ProximitySensePlayers_C:UBTService_BlueprintBase
	/// Size: 0xC8
	/// Properties: 5
	/// </summary>
	public class UBTService_ProximitySensePlayers_C:UBTService_BlueprintBase
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x98);
		
		/// <summary>
		/// Name: SearchRadius
		/// Type: FloatProperty
		/// Offset: 0xA0
		/// Size: 0x04
		/// </summary>
		public float SearchRadius
		{
			get
			{
				return ReadSingle(0xA0);
			}
			set
			{
				WriteSingle(0xA0,value);
			}
		}
		
		/// <summary>
		/// Name: ControlledPawn
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public APawn ControlledPawn => ReadUObject<APawn>(0xA8);
		
		/// <summary>
		/// Name: NPCController
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public AAI_Controller_NPC_C NPCController => ReadUObject<AAI_Controller_NPC_C>(0xB0);
		
		/// <summary>
		/// Name: ClosePlayers
		/// Type: TArray<APawn>
		/// Offset: 0xB8
		/// Size: 0x10
		/// SubElement Size: 0x430
		/// </summary>
		public TArray<APawn> ClosePlayers => new TArray<APawn>(BaseAddress+0xB8);
		
	}


}

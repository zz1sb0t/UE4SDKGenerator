using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;


namespace ConanExilesGame.Game.Tools.CommandPanel
{
	/// <summary>
	/// FNPC_Counter_Structure:
	/// Size: 0x14
	/// Properties: 2
	/// </summary>
	public class FNPC_Counter_Structure:MemoryObject
	{
		public override int ObjectSize => 20;
		/// <summary>
		/// Name: NPC_5_3979345C4D6470B523C850AE57E2AF7C
		/// Type: StrProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FString NPC_5_3979345C4D6470B523C850AE57E2AF7C => new FString(BaseAddress+0x00);
		
		/// <summary>
		/// Name: Amount_2_2615BE9F4141969A8BC37EA7CD8FB8D8
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int Amount_2_2615BE9F4141969A8BC37EA7CD8FB8D8
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
	}


}

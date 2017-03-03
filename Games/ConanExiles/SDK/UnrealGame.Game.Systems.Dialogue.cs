using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.AI;


namespace ConanExilesGame.Game.Systems.Dialogue
{
	/// <summary>
	/// FNpcDialogue_TableStructure:
	/// Size: 0x60
	/// Properties: 10
	/// </summary>
	public class FNpcDialogue_TableStructure:MemoryObject
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: InitialGreeting_2_2A3778CE4CDFA9B5383FF084A6CDB58D
		/// Type: ObjectProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		public USoundBase InitialGreeting_2_2A3778CE4CDFA9B5383FF084A6CDB58D => ReadUObject<USoundBase>(0x00);
		
		/// <summary>
		/// Name: Greeting_14_DF9ED9A7416281F2F3006B900DA9FA45
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public USoundBase Greeting_14_DF9ED9A7416281F2F3006B900DA9FA45 => ReadUObject<USoundBase>(0x08);
		
		/// <summary>
		/// Name: Farewell_15_ABA5824C4CDF1668C862AFBE150F0D23
		/// Type: ObjectProperty
		/// Offset: 0x10
		/// Size: 0x08
		/// </summary>
		public USoundBase Farewell_15_ABA5824C4CDF1668C862AFBE150F0D23 => ReadUObject<USoundBase>(0x10);
		
		/// <summary>
		/// Name: Conversation_18_B63A4AF84F957DAAE502D797ABCBB629
		/// Type: TArray<USoundBase>
		/// Offset: 0x18
		/// Size: 0x10
		/// SubElement Size: 0x70
		/// </summary>
		public TArray<USoundBase> Conversation_18_B63A4AF84F957DAAE502D797ABCBB629 => new TArray<USoundBase>(BaseAddress+0x18);
		
		/// <summary>
		/// Name: StartCombat_11_0BB7A3664E2E3744D3540D95A1AF588A
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public USoundBase StartCombat_11_0BB7A3664E2E3744D3540D95A1AF588A => ReadUObject<USoundBase>(0x28);
		
		/// <summary>
		/// Name: DuringCombat_13_294013714CBB8E489A100581B7F45557
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public USoundBase DuringCombat_13_294013714CBB8E489A100581B7F45557 => ReadUObject<USoundBase>(0x30);
		
		/// <summary>
		/// Name: Death_17_068E559B46439D5F6BBF8E9BAF60E324
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public USoundBase Death_17_068E559B46439D5F6BBF8E9BAF60E324 => ReadUObject<USoundBase>(0x38);
		
		/// <summary>
		/// Name: Hit_21_04B1FBB145B14796CA40779C44F899EC
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public USoundBase Hit_21_04B1FBB145B14796CA40779C44F899EC => ReadUObject<USoundBase>(0x40);
		
		/// <summary>
		/// Name: OfferedEmote_24_4C55B61F44FDE28FD24847A3567A7D3C
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte OfferedEmote_24_4C55B61F44FDE28FD24847A3567A7D3C
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: OfferedFeatIDs_32_4B95EECF4FE3DA42F6D33792C308B821
		/// Type: TArray<>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UBP_DialogueParams_C:UBP_NPCBehaviorParameters_C
	/// Size: 0x40
	/// Properties: 1
	/// </summary>
	public class UBP_DialogueParams_C:UBP_NPCBehaviorParameters_C
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: DialogueTableEntry
		/// Type: NameProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		
	}


}

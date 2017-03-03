using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Components;
using ConanExilesGame.Game.Systems.Dialogue;
using ConanExilesGame.Game.UI.Dialogue;


namespace ConanExilesGame.Game.Systems.Components
{
	/// <summary>
	/// UNotificationComponent_C:UActorComponent
	/// Size: 0xD8
	/// Properties: 0
	/// </summary>
	public class UNotificationComponent_C:UActorComponent
	{
		public override int ObjectSize => 216;
	}


	/// <summary>
	/// UComponentHelpers_C:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UComponentHelpers_C:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNavigationComponent_C:UConanCharacterComponent
	/// Size: 0xF8
	/// Properties: 4
	/// </summary>
	public class UNavigationComponent_C:UConanCharacterComponent
	{
		public override int ObjectSize => 248;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xE0);
		
		/// <summary>
		/// Name: TileGenerationRadius
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float TileGenerationRadius
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
		/// Name: TileRemovalRadius
		/// Type: FloatProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public float TileRemovalRadius
		{
			get
			{
				return ReadSingle(0xEC);
			}
			set
			{
				WriteSingle(0xEC,value);
			}
		}
		
		/// <summary>
		/// Name: NavDataConfigName
		/// Type: NameProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UPlayerNotificationComponent_C:UNotificationComponent_C
	/// Size: 0xF1
	/// Properties: 2
	/// </summary>
	public class UPlayerNotificationComponent_C:UNotificationComponent_C
	{
		public override int ObjectSize => 241;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: InteractNotificationCooldownInProgress
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool InteractNotificationCooldownInProgress
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
		
	}


	/// <summary>
	/// UBP_NarratorComponent_C:UActorComponent
	/// Size: 0xF0
	/// Properties: 3
	/// </summary>
	public class UBP_NarratorComponent_C:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: NextNarratorCue
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public USoundCue NextNarratorCue => ReadUObject<USoundCue>(0xE0);
		
		/// <summary>
		/// Name: NarratorAudioComp
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent NarratorAudioComp => ReadUObject<UConanAudioComponent>(0xE8);
		
	}


	/// <summary>
	/// UDialogueComponent_C:UActorComponent
	/// Size: 0x198
	/// Properties: 15
	/// </summary>
	public class UDialogueComponent_C:UActorComponent
	{
		public override int ObjectSize => 408;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: DialogueGUIModuleName
		/// Type: NameProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Dialogue
		/// Type: StructProperty
		/// Offset: 0xE8
		/// Size: 0x60
		/// </summary>
		public FNpcDialogue_TableStructure Dialogue => ReadStruct<FNpcDialogue_TableStructure>(0xE8);
		
		/// <summary>
		/// Name: DialogueTableEntry
		/// Type: NameProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CurrentConversationIndex
		/// Type: IntProperty
		/// Offset: 0x150
		/// Size: 0x04
		/// </summary>
		public int CurrentConversationIndex
		{
			get
			{
				return ReadInt32(0x150);
			}
			set
			{
				WriteInt32(0x150,value);
			}
		}
		
		/// <summary>
		/// Name: PlayedInitialGreeting
		/// Type: BoolProperty
		/// Offset: 0x154
		/// Size: 0x01
		/// </summary>
		public bool PlayedInitialGreeting
		{
			get
			{
				return ReadBool(0x154);
			}
			set
			{
				WriteBool(0x154,value);
			}
		}
		
		/// <summary>
		/// Name: DialogueLoaded
		/// Type: BoolProperty
		/// Offset: 0x155
		/// Size: 0x01
		/// </summary>
		public bool DialogueLoaded
		{
			get
			{
				return ReadBool(0x155);
			}
			set
			{
				WriteBool(0x155,value);
			}
		}
		
		/// <summary>
		/// Name: ClientInDialogue
		/// Type: BoolProperty
		/// Offset: 0x156
		/// Size: 0x01
		/// </summary>
		public bool ClientInDialogue
		{
			get
			{
				return ReadBool(0x156);
			}
			set
			{
				WriteBool(0x156,value);
			}
		}
		
		/// <summary>
		/// Name: DialogueComponent
		/// Type: ObjectProperty
		/// Offset: 0x158
		/// Size: 0x08
		/// </summary>
		public UDialogueComponent_C DialogueComponent => ReadUObject<UDialogueComponent_C>(0x158);
		
		/// <summary>
		/// Name: NpcPawn
		/// Type: ObjectProperty
		/// Offset: 0x160
		/// Size: 0x08
		/// </summary>
		public APawn NpcPawn => ReadUObject<APawn>(0x160);
		
		/// <summary>
		/// Name: DialogueWidget
		/// Type: ObjectProperty
		/// Offset: 0x168
		/// Size: 0x08
		/// </summary>
		public UW_NPCDialogue_C DialogueWidget => ReadUObject<UW_NPCDialogue_C>(0x168);
		
		/// <summary>
		/// Name: VoiceAudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent VoiceAudioComponent => ReadUObject<UConanAudioComponent>(0x170);
		
		/// <summary>
		/// Name: AI_State
		/// Type: ByteProperty
		/// Offset: 0x178
		/// Size: 0x01
		/// </summary>
		public byte AI_State
		{
			get
			{
				return ReadByte(0x178);
			}
			set
			{
				WriteByte(0x178,value);
			}
		}
		
		/// <summary>
		/// Name: PlayersTalkingToMe
		/// Type: TArray<AActor>
		/// Offset: 0x180
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> PlayersTalkingToMe => new TArray<AActor>(BaseAddress+0x180);
		
		/// <summary>
		/// Name: CheckPlayersGoneTimer
		/// Type: StructProperty
		/// Offset: 0x190
		/// Size: 0x08
		/// </summary>
		public FTimerHandle CheckPlayersGoneTimer => ReadStruct<FTimerHandle>(0x190);
		
	}


}

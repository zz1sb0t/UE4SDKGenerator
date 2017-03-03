using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.UI.Framework;
using ConanExilesGame.Game.Systems.Components;


namespace ConanExilesGame.Game.UI.Dialogue
{
	/// <summary>
	/// UW_NPCDialogue_C:UItemInfoPopup
	/// Size: 0x440
	/// Properties: 16
	/// </summary>
	public class UW_NPCDialogue_C:UItemInfoPopup
	{
		public override int ObjectSize => 1088;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3A8);
		
		/// <summary>
		/// Name: B_Goodbye
		/// Type: ObjectProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Goodbye => ReadUObject<UW_ButtonNormal_C>(0x3B0);
		
		/// <summary>
		/// Name: B_LearnEmote
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_LearnEmote => ReadUObject<UW_ButtonNormal_C>(0x3B8);
		
		/// <summary>
		/// Name: B_LearnRecipe
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_LearnRecipe => ReadUObject<UW_ButtonNormal_C>(0x3C0);
		
		/// <summary>
		/// Name: B_LearnReligion
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_LearnReligion => ReadUObject<UW_ButtonNormal_C>(0x3C8);
		
		/// <summary>
		/// Name: B_Talk
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UW_ButtonNormal_C B_Talk => ReadUObject<UW_ButtonNormal_C>(0x3D0);
		
		/// <summary>
		/// Name: MainCanvas
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UCanvasPanel MainCanvas => ReadUObject<UCanvasPanel>(0x3D8);
		
		/// <summary>
		/// Name: Name
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UTextBlock Name => ReadUObject<UTextBlock>(0x3E0);
		
		/// <summary>
		/// Name: NPCName
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UTextBlock NPCName => ReadUObject<UTextBlock>(0x3E8);
		
		/// <summary>
		/// Name: VerticalList
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UVerticalBox VerticalList => ReadUObject<UVerticalBox>(0x3F0);
		
		/// <summary>
		/// Name: NPC
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public AConanCharacter NPC => ReadUObject<AConanCharacter>(0x3F8);
		
		/// <summary>
		/// Name: NPCDialogueComponent
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UDialogueComponent_C NPCDialogueComponent => ReadUObject<UDialogueComponent_C>(0x400);
		
		/// <summary>
		/// Name: PlayerDialogueComponent
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UDialogueComponent_C PlayerDialogueComponent => ReadUObject<UDialogueComponent_C>(0x408);
		
		/// <summary>
		/// Name: PlayerDialogueComponentName
		/// Type: StrProperty
		/// Offset: 0x410
		/// Size: 0x10
		/// </summary>
		public FString PlayerDialogueComponentName => new FString(BaseAddress+0x410);
		
		/// <summary>
		/// Name: NpcDialogueComponentName
		/// Type: StrProperty
		/// Offset: 0x420
		/// Size: 0x10
		/// </summary>
		public FString NpcDialogueComponentName => new FString(BaseAddress+0x420);
		
		/// <summary>
		/// Name: B_LearnButtons
		/// Type: TArray<UW_ButtonNormal_C>
		/// Offset: 0x430
		/// Size: 0x10
		/// SubElement Size: 0xBA8
		/// </summary>
		public TArray<UW_ButtonNormal_C> B_LearnButtons => new TArray<UW_ButtonNormal_C>(BaseAddress+0x430);
		
	}


}

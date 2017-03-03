using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;


namespace UnrealGame.Game.UI.VoiceChat
{
	/// <summary>
	/// UW_VoiceChatLine_C:UUserWidget
	/// Size: 0x250
	/// Properties: 3
	/// </summary>
	public class UW_VoiceChatLine_C:UUserWidget
	{
		public override int ObjectSize => 592;
		/// <summary>
		/// Name: ImageMicrophone
		/// Type: ObjectProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public UImage ImageMicrophone => ReadUObject<UImage>(0x238);
		
		/// <summary>
		/// Name: ImageMuted
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UImage ImageMuted => ReadUObject<UImage>(0x240);
		
		/// <summary>
		/// Name: ImageSpeakingHead
		/// Type: ObjectProperty
		/// Offset: 0x248
		/// Size: 0x08
		/// </summary>
		public UImage ImageSpeakingHead => ReadUObject<UImage>(0x248);
		
	}


	/// <summary>
	/// UW_VoiceChatWindow_C:UVoiceChatWindow
	/// Size: 0x390
	/// Properties: 1
	/// </summary>
	public class UW_VoiceChatWindow_C:UVoiceChatWindow
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: UVerticalBox
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UVerticalBox UVerticalBox => ReadUObject<UVerticalBox>(0x388);
		
	}


}

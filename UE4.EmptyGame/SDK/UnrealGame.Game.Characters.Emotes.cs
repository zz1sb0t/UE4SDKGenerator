using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;
using UnrealGame.Game.Characters;


namespace UnrealGame.Game.Characters.Emotes
{
	/// <summary>
	/// UBPEmoteController_C:UEmoteController
	/// Size: 0x101
	/// Properties: 3
	/// </summary>
	public class UBPEmoteController_C:UEmoteController
	{
		public override int ObjectSize => 257;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xF0);
		
		/// <summary>
		/// Name: OwnerCharacter
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public ABaseBPChar_C OwnerCharacter => ReadUObject<ABaseBPChar_C>(0xF8);
		
		/// <summary>
		/// Name: WasInThirdPerson
		/// Type: BoolProperty
		/// Offset: 0x100
		/// Size: 0x01
		/// </summary>
		public bool WasInThirdPerson
		{
			get
			{
				return ReadBool(0x100);
			}
			set
			{
				WriteBool(0x100,value);
			}
		}
		
	}


}

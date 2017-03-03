using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Characters;


namespace ConanExilesGame.Game.Characters.Emotes
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

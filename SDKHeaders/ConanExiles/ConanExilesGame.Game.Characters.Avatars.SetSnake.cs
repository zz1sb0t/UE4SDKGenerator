using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters.Avatars;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Combat;


namespace ConanExilesGame.Game.Characters.Avatars.SetSnake
{
	/// <summary>
	/// ABP_AvatarSetSnakeCharacter_C:ABP_AvatarCharacter_C
	/// Size: 0xB11
	/// Properties: 11
	/// </summary>
	public class ABP_AvatarSetSnakeCharacter_C:ABP_AvatarCharacter_C
	{
		public override int ObjectSize => 2833;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xAC0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xAC0);
		
		/// <summary>
		/// Name: SlitherSound
		/// Type: ObjectProperty
		/// Offset: 0xAC8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent SlitherSound => ReadUObject<UConanAudioComponent>(0xAC8);
		
		/// <summary>
		/// Name: HitLoc7
		/// Type: ObjectProperty
		/// Offset: 0xAD0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc7 => ReadUObject<UBoxComponent>(0xAD0);
		
		/// <summary>
		/// Name: HitLoc16
		/// Type: ObjectProperty
		/// Offset: 0xAD8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc16 => ReadUObject<UBoxComponent>(0xAD8);
		
		/// <summary>
		/// Name: HitLoc32
		/// Type: ObjectProperty
		/// Offset: 0xAE0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc32 => ReadUObject<UBoxComponent>(0xAE0);
		
		/// <summary>
		/// Name: HitLoc39
		/// Type: ObjectProperty
		/// Offset: 0xAE8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc39 => ReadUObject<UBoxComponent>(0xAE8);
		
		/// <summary>
		/// Name: HitLoc45
		/// Type: ObjectProperty
		/// Offset: 0xAF0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc45 => ReadUObject<UBoxComponent>(0xAF0);
		
		/// <summary>
		/// Name: HitLoc49
		/// Type: ObjectProperty
		/// Offset: 0xAF8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent HitLoc49 => ReadUObject<UBoxComponent>(0xAF8);
		
		/// <summary>
		/// Name: SweepDamageComponent
		/// Type: ObjectProperty
		/// Offset: 0xB00
		/// Size: 0x08
		/// </summary>
		public USweepDamageComponent_C SweepDamageComponent => ReadUObject<USweepDamageComponent_C>(0xB00);
		
		/// <summary>
		/// Name: HitLoc_Head
		/// Type: ObjectProperty
		/// Offset: 0xB08
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent HitLoc_Head => ReadUObject<UCapsuleComponent>(0xB08);
		
		/// <summary>
		/// Name: IsPlayingMovingSound
		/// Type: BoolProperty
		/// Offset: 0xB10
		/// Size: 0x01
		/// </summary>
		public bool IsPlayingMovingSound
		{
			get
			{
				return ReadBool(0xB10);
			}
			set
			{
				WriteBool(0xB10,value);
			}
		}
		
	}


}

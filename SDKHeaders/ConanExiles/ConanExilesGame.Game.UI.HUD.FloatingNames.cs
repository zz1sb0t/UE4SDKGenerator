using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building;


namespace ConanExilesGame.Game.UI.HUD.FloatingNames
{
	/// <summary>
	/// UW_FloatingName_C:UFloatingNameBase
	/// Size: 0x338
	/// Properties: 5
	/// </summary>
	public class UW_FloatingName_C:UFloatingNameBase
	{
		public override int ObjectSize => 824;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x310);
		
		/// <summary>
		/// Name: CharacterName
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UTextBlock CharacterName => ReadUObject<UTextBlock>(0x318);
		
		/// <summary>
		/// Name: I_MicIcon
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UImage I_MicIcon => ReadUObject<UImage>(0x320);
		
		/// <summary>
		/// Name: PlayerName
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UTextBlock PlayerName => ReadUObject<UTextBlock>(0x328);
		
		/// <summary>
		/// Name: Status
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UTextBlock Status => ReadUObject<UTextBlock>(0x330);
		
	}


	/// <summary>
	/// UW_OnScreenInfoContainer_C:UWindowRoot
	/// Size: 0x3C4
	/// Properties: 10
	/// </summary>
	public class UW_OnScreenInfoContainer_C:UWindowRoot
	{
		public override int ObjectSize => 964;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: Content
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UNamedSlot Content => ReadUObject<UNamedSlot>(0x380);
		
		/// <summary>
		/// Name: Owner
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public AConanCharacter Owner => ReadUObject<AConanCharacter>(0x388);
		
		/// <summary>
		/// Name: ActiveWidget
		/// Type: NameProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ActiveObject
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UObject ActiveObject => ReadUObject<UObject>(0x398);
		
		/// <summary>
		/// Name: ActiveModule
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UWindowRoot ActiveModule => ReadUObject<UWindowRoot>(0x3A0);
		
		/// <summary>
		/// Name: objectIndex
		/// Type: IntProperty
		/// Offset: 0x3A8
		/// Size: 0x04
		/// </summary>
		public int objectIndex
		{
			get
			{
				return ReadInt32(0x3A8);
			}
			set
			{
				WriteInt32(0x3A8,value);
			}
		}
		
		/// <summary>
		/// Name: Timer
		/// Type: StructProperty
		/// Offset: 0x3B0
		/// Size: 0x08
		/// </summary>
		public FTimerHandle Timer => ReadStruct<FTimerHandle>(0x3B0);
		
		/// <summary>
		/// Name: BuildingSystem
		/// Type: ObjectProperty
		/// Offset: 0x3B8
		/// Size: 0x08
		/// </summary>
		public UBP_BuildSystem_v2_C BuildingSystem => ReadUObject<UBP_BuildSystem_v2_C>(0x3B8);
		
		/// <summary>
		/// Name: ActiveObjectIndex
		/// Type: IntProperty
		/// Offset: 0x3C0
		/// Size: 0x04
		/// </summary>
		public int ActiveObjectIndex
		{
			get
			{
				return ReadInt32(0x3C0);
			}
			set
			{
				WriteInt32(0x3C0,value);
			}
		}
		
	}


}

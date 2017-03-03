using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Items.LoreObjects;
using ConanExilesGame.Game.Systems.Components;


namespace ConanExilesGame.Game.Items.LoreObjects
{
	/// <summary>
	/// UBP_LoreInteractor_C:UActorComponent
	/// Size: 0xF0
	/// Properties: 2
	/// </summary>
	public class UBP_LoreInteractor_C:UActorComponent
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
		/// Name: PickedupLoreItems
		/// Type: TArray<>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// ABP_interactable_clientside_C:AActor
	/// Size: 0x490
	/// Properties: 12
	/// </summary>
	public class ABP_interactable_clientside_C:AActor
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x3D8);
		
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x3E0);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3E8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F0);
		
		/// <summary>
		/// Name: LoreItemID
		/// Type: IntProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public int LoreItemID
		{
			get
			{
				return ReadInt32(0x3F8);
			}
			set
			{
				WriteInt32(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: DisplayInteractionText
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool DisplayInteractionText
		{
			get
			{
				return ReadBool(0x3FC);
			}
			set
			{
				WriteBool(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: LoreInfo
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x78
		/// </summary>
		public FLoreInfo LoreInfo => ReadStruct<FLoreInfo>(0x400);
		
		/// <summary>
		/// Name: Canbeusedagain
		/// Type: BoolProperty
		/// Offset: 0x478
		/// Size: 0x01
		/// </summary>
		public bool Canbeusedagain
		{
			get
			{
				return ReadBool(0x478);
			}
			set
			{
				WriteBool(0x478,value);
			}
		}
		
		/// <summary>
		/// Name: Loreitemdurability
		/// Type: FloatProperty
		/// Offset: 0x47C
		/// Size: 0x04
		/// </summary>
		public float Loreitemdurability
		{
			get
			{
				return ReadSingle(0x47C);
			}
			set
			{
				WriteSingle(0x47C,value);
			}
		}
		
		/// <summary>
		/// Name: RetriggerDelayTimeHandle
		/// Type: StructProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public FTimerHandle RetriggerDelayTimeHandle => ReadStruct<FTimerHandle>(0x480);
		
		/// <summary>
		/// Name: PlayerNotificationComponent
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public UPlayerNotificationComponent_C PlayerNotificationComponent => ReadUObject<UPlayerNotificationComponent_C>(0x488);
		
	}


	/// <summary>
	/// FLoreInfo:
	/// Size: 0x71
	/// Properties: 7
	/// </summary>
	public class FLoreInfo:MemoryObject
	{
		public override int ObjectSize => 113;
		/// <summary>
		/// Name: Name_8_53C1825943B8561A24E7FFB07EE88342
		/// Type: TextProperty
		/// Offset: 0x00
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Description_One_13_0E08FD9748086DA89F215AB4C1EBFA54
		/// Type: TextProperty
		/// Offset: 0x18
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Description_Two_20_AFA553F1474F7F69B8CCAAA97E37B244
		/// Type: TextProperty
		/// Offset: 0x30
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Description_Three_19_5E649FFA4C09C7E7CA2550AC5F0837AE
		/// Type: TextProperty
		/// Offset: 0x48
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Image_22_E7562E0743116212FDE97AAAA557B5BB
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UTexture2D Image_22_E7562E0743116212FDE97AAAA557B5BB => ReadUObject<UTexture2D>(0x60);
		
		/// <summary>
		/// Name: Sound_17_A532AB1F4C0DB50583D50CAD4117ED6F
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_17_A532AB1F4C0DB50583D50CAD4117ED6F => ReadUObject<USoundCue>(0x68);
		
		/// <summary>
		/// Name: IsGameItem_26_6147D0FD4DDDBCC413FF55A01CE125EE
		/// Type: BoolProperty
		/// Offset: 0x70
		/// Size: 0x01
		/// </summary>
		public bool IsGameItem_26_6147D0FD4DDDBCC413FF55A01CE125EE
		{
			get
			{
				return ReadBool(0x70);
			}
			set
			{
				WriteBool(0x70,value);
			}
		}
		
	}


	/// <summary>
	/// ALore3_C:ALoreMeshActor
	/// Size: 0x3F0
	/// Properties: 0
	/// </summary>
	public class ALore3_C:ALoreMeshActor
	{
		public override int ObjectSize => 1008;
	}


}

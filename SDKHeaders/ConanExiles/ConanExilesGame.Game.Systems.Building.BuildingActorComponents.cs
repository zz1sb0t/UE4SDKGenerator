using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Systems.Building.BuildingActorComponents;


namespace ConanExilesGame.Game.Systems.Building.BuildingActorComponents
{
	/// <summary>
	/// U00_BP_SC_Building_MasterSceneComponent_C:USceneComponent
	/// Size: 0x228
	/// Properties: 1
	/// </summary>
	public class U00_BP_SC_Building_MasterSceneComponent_C:USceneComponent
	{
		public override int ObjectSize => 552;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x220
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x220);
		
	}


	/// <summary>
	/// U00_BP_AC_Building_MasterActorComp_C:UActorComponent
	/// Size: 0xE0
	/// Properties: 1
	/// </summary>
	public class U00_BP_AC_Building_MasterActorComp_C:UActorComponent
	{
		public override int ObjectSize => 224;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
	}


	/// <summary>
	/// UBP_BAC_SpawnLootOnDestroyed_C:UActorComponent
	/// Size: 0xE0
	/// Properties: 1
	/// </summary>
	public class UBP_BAC_SpawnLootOnDestroyed_C:UActorComponent
	{
		public override int ObjectSize => 224;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
	}


	/// <summary>
	/// UBP_BAC_Storage_C:U00_BP_AC_Building_MasterActorComp_C
	/// Size: 0x111
	/// Properties: 6
	/// </summary>
	public class UBP_BAC_Storage_C:U00_BP_AC_Building_MasterActorComp_C
	{
		public override int ObjectSize => 273;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xE0);
		
		/// <summary>
		/// Name: PlayersInteractingWithChest
		/// Type: TArray<APlayerController>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x6C8
		/// </summary>
		public TArray<APlayerController> PlayersInteractingWithChest => new TArray<APlayerController>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: AnimInstance
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public UAnimInstance AnimInstance => ReadUObject<UAnimInstance>(0xF8);
		
		/// <summary>
		/// Name: Sound_Open
		/// Type: ObjectProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Open => ReadUObject<USoundCue>(0x100);
		
		/// <summary>
		/// Name: Sound_Close
		/// Type: ObjectProperty
		/// Offset: 0x108
		/// Size: 0x08
		/// </summary>
		public USoundCue Sound_Close => ReadUObject<USoundCue>(0x108);
		
		/// <summary>
		/// Name: OpenState
		/// Type: BoolProperty
		/// Offset: 0x110
		/// Size: 0x01
		/// </summary>
		public bool OpenState
		{
			get
			{
				return ReadBool(0x110);
			}
			set
			{
				WriteBool(0x110,value);
			}
		}
		
	}


	/// <summary>
	/// UBP_BAC_CraftingStation_C:U00_BP_AC_Building_MasterActorComp_C
	/// Size: 0xEA
	/// Properties: 3
	/// </summary>
	public class UBP_BAC_CraftingStation_C:U00_BP_AC_Building_MasterActorComp_C
	{
		public override int ObjectSize => 234;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xE0);
		
		/// <summary>
		/// Name: IsOpen
		/// Type: BoolProperty
		/// Offset: 0xE8
		/// Size: 0x01
		/// </summary>
		public bool IsOpen
		{
			get
			{
				return ReadBool(0xE8);
			}
			set
			{
				WriteBool(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: IsMachine
		/// Type: BoolProperty
		/// Offset: 0xE9
		/// Size: 0x01
		/// </summary>
		public bool IsMachine
		{
			get
			{
				return ReadBool(0xE9);
			}
			set
			{
				WriteBool(0xE9,value);
			}
		}
		
	}


}

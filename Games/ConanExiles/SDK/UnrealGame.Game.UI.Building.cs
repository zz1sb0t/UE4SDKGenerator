using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.Building
{
	/// <summary>
	/// UW_CanBuildIndicator_C:UWindowRoot
	/// Size: 0x3A0
	/// Properties: 3
	/// </summary>
	public class UW_CanBuildIndicator_C:UWindowRoot
	{
		public override int ObjectSize => 928;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x378);
		
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UImage Image => ReadUObject<UImage>(0x380);
		
		/// <summary>
		/// Name: BlockedReason
		/// Type: TextProperty
		/// Offset: 0x388
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UW_SpawnPointSet_C:UUserWidget
	/// Size: 0x240
	/// Properties: 1
	/// </summary>
	public class UW_SpawnPointSet_C:UUserWidget
	{
		public override int ObjectSize => 576;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x238);
		
	}


}

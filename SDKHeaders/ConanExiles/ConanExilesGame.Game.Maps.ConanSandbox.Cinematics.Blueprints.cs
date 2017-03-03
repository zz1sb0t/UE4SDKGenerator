using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Maps.ConanSandbox.Cinematics.Blueprints;


namespace ConanExilesGame.Game.Maps.ConanSandbox.Cinematics.Blueprints
{
	/// <summary>
	/// ABP_base_cinematic_triggerbox_C:ATriggerBox
	/// Size: 0x3E8
	/// Properties: 1
	/// </summary>
	public class ABP_base_cinematic_triggerbox_C:ATriggerBox
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: cinematic
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public ALevelSequenceActor cinematic => ReadUObject<ALevelSequenceActor>(0x3E0);
		
	}


	/// <summary>
	/// ABP_cinematic_triggerbox_C:ABP_base_cinematic_triggerbox_C
	/// Size: 0x3F0
	/// Properties: 1
	/// </summary>
	public class ABP_cinematic_triggerbox_C:ABP_base_cinematic_triggerbox_C
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
	}


	/// <summary>
	/// ABP_cinematic_triggerbox_shortkill_C:ABP_base_cinematic_triggerbox_C
	/// Size: 0x3F8
	/// Properties: 2
	/// </summary>
	public class ABP_cinematic_triggerbox_shortkill_C:ABP_base_cinematic_triggerbox_C
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public AController Controller => ReadUObject<AController>(0x3F0);
		
	}


	/// <summary>
	/// ABP_cinematic_triggerbox_cinematic_event_C:ABP_base_cinematic_triggerbox_C
	/// Size: 0x3F0
	/// Properties: 1
	/// </summary>
	public class ABP_cinematic_triggerbox_cinematic_event_C:ABP_base_cinematic_triggerbox_C
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E8);
		
	}


}

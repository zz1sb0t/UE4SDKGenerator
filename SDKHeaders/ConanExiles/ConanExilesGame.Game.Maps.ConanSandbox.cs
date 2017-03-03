using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Maps.ConanSandbox
{
	/// <summary>
	/// AConanSandbox_C:AConanSandboxLevelScriptActor
	/// Size: 0x430
	/// Properties: 4
	/// </summary>
	public class AConanSandbox_C:AConanSandboxLevelScriptActor
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D8);
		
		/// <summary>
		/// Name: SkyLightCurve
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SkyLightCurve => ReadUObject<UCurveLinearColor>(0x3E0);
		
		/// <summary>
		/// Name: HeightmapList
		/// Type: TArray<FName>
		/// Offset: 0x3E8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> HeightmapList => new TArray<FName>(BaseAddress+0x3E8);
		
		/// <summary>
		/// Name: SandStormLocation
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x30
		/// </summary>
		public FTransform SandStormLocation => ReadStruct<FTransform>(0x400);
		
	}


	/// <summary>
	/// UBP_ConanWorldComposition_C:UConanWorldComposition
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class UBP_ConanWorldComposition_C:UConanWorldComposition
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// AConanSandbox_SOUND_C:ALevelScriptActor
	/// Size: 0x3F8
	/// Properties: 4
	/// </summary>
	public class AConanSandbox_SOUND_C:ALevelScriptActor
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: Music_TEMP
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Music_TEMP => ReadUObject<UConanAudioComponent>(0x3D8);
		
		/// <summary>
		/// Name: Underwater
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Underwater => ReadUObject<UConanAudioComponent>(0x3E0);
		
		/// <summary>
		/// Name: UnderwaterSound
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent UnderwaterSound => ReadUObject<UConanAudioComponent>(0x3E8);
		
		/// <summary>
		/// Name: NewVar
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent NewVar => ReadUObject<UConanAudioComponent>(0x3F0);
		
	}


}

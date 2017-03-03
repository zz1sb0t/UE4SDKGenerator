using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExiles.Script;


namespace ConanExiles.Game.Dev.SmokeTests
{
	/// <summary>
	/// ATestSceneLoader_C:AActor
	/// Size: 0x3F2
	/// Properties: 6
	/// </summary>
	public class ATestSceneLoader_C:AActor
	{
		public override int ObjectSize => 1010;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: RunSmokeTests
		/// Type: BoolProperty
		/// Offset: 0x3E0
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: SmokeTestLevelName
		/// Type: NameProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: RunSmokeTestsOnBeginPlay
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: SmokeTestsHaveBeenStarted
		/// Type: BoolProperty
		/// Offset: 0x3F1
		/// Size: 0x01
		/// </summary>
		
	}


	/// <summary>
	/// ATestList_C:AActor
	/// Size: 0x401
	/// Properties: 5
	/// </summary>
	public class ATestList_C:AActor
	{
		public override int ObjectSize => 1025;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: TestSources
		/// Type: TArray<AActor>
		/// Offset: 0x3E0
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> TestSources => new TArray<AActor>(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: Testables
		/// Type: TArray<UTestable>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UTestable> Testables => new TArray<UTestable>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: RunOnDedicatedServer
		/// Type: BoolProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		
	}


}

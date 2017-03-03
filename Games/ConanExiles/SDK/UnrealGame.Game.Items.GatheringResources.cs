using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Items.GatheringResources
{
	/// <summary>
	/// ASM_KappaEggs_Blueprint_C:AActor
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class ASM_KappaEggs_Blueprint_C:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: InstancedBushes
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UInstancedStaticMeshComponent InstancedBushes => ReadUObject<UInstancedStaticMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: SharedRoot
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent SharedRoot => ReadUObject<USceneComponent>(0x3D8);
		
	}


}

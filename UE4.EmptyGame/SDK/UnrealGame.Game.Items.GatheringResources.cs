using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;


namespace UnrealGame.Game.Items.GatheringResources
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

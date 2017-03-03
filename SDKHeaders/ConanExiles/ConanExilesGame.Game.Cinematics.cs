using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Cinematics
{
	/// <summary>
	/// ABP_Cinematictrigger_C:AActor
	/// Size: 0x3F1
	/// Properties: 5
	/// </summary>
	public class ABP_Cinematictrigger_C:AActor
	{
		public override int ObjectSize => 1009;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent SkeletalMesh => ReadUObject<USkeletalMeshComponent>(0x3D8);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3E0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: playerseenbatdemon
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool playerseenbatdemon
		{
			get
			{
				return ReadBool(0x3F0);
			}
			set
			{
				WriteBool(0x3F0,value);
			}
		}
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game
{
	/// <summary>
	/// ABP_TimeOfDayManager_C:AConanTimeOfDayManager
	/// Size: 0x414
	/// Properties: 4
	/// </summary>
	public class ABP_TimeOfDayManager_C:AConanTimeOfDayManager
	{
		public override int ObjectSize => 1044;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: AmbientSounds
		/// Type: TArray<AConanAmbientSound>
		/// Offset: 0x400
		/// Size: 0x10
		/// SubElement Size: 0x3D8
		/// </summary>
		public TArray<AConanAmbientSound> AmbientSounds => new TArray<AConanAmbientSound>(BaseAddress+0x400);
		
		/// <summary>
		/// Name: UpdateAmbientSoundTimer
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float UpdateAmbientSoundTimer
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
	}


}

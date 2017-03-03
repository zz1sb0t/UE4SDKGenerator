using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Developers.tommyr
{
	/// <summary>
	/// AResourceBillboardActor_C:AActor
	/// Size: 0x3E4
	/// Properties: 3
	/// </summary>
	public class AResourceBillboardActor_C:AActor
	{
		public override int ObjectSize => 996;
		/// <summary>
		/// Name: Billboard
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent Billboard => ReadUObject<UBillboardComponent>(0x3D0);
		
		/// <summary>
		/// Name: Sprite
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UTexture2D Sprite => ReadUObject<UTexture2D>(0x3D8);
		
		/// <summary>
		/// Name: ZOffset
		/// Type: FloatProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public float ZOffset
		{
			get
			{
				return ReadSingle(0x3E0);
			}
			set
			{
				WriteSingle(0x3E0,value);
			}
		}
		
	}


}

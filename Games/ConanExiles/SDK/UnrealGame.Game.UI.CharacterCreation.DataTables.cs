using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.UI.CharacterCreation.DataTables
{
	/// <summary>
	/// FHairTableEntry:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FHairTableEntry:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: Mesh_3_63144EF24C0F9BAAEEE0838E52B72E70
		/// Type: ObjectProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		public USkeletalMesh Mesh_3_63144EF24C0F9BAAEEE0838E52B72E70 => ReadUObject<USkeletalMesh>(0x00);
		
		/// <summary>
		/// Name: HighQualityMesh_5_A0B8E23C4A11F6EADB132CB66F15612E
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public USkeletalMesh HighQualityMesh_5_A0B8E23C4A11F6EADB132CB66F15612E => ReadUObject<USkeletalMesh>(0x08);
		
		/// <summary>
		/// Name: HairLineTexture_8_A675B8F04D7A1F9BCBCEEC9761D4CE2E
		/// Type: ObjectProperty
		/// Offset: 0x10
		/// Size: 0x08
		/// </summary>
		public UTexture HairLineTexture_8_A675B8F04D7A1F9BCBCEEC9761D4CE2E => ReadUObject<UTexture>(0x10);
		
	}


	/// <summary>
	/// FTextureSet:
	/// Size: 0x18
	/// Properties: 3
	/// </summary>
	public class FTextureSet:MemoryObject
	{
		public override int ObjectSize => 24;
		/// <summary>
		/// Name: DiffuseTexture_2_A2C17E214B835C9277DEB3BDF37B9282
		/// Type: ObjectProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		public UTexture DiffuseTexture_2_A2C17E214B835C9277DEB3BDF37B9282 => ReadUObject<UTexture>(0x00);
		
		/// <summary>
		/// Name: NormalTexture_4_6C2BA45A4E339D2F7046FC9765147D3D
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public UTexture NormalTexture_4_6C2BA45A4E339D2F7046FC9765147D3D => ReadUObject<UTexture>(0x08);
		
		/// <summary>
		/// Name: Icon_6_12BD8E6E41BB51FB55962AAE33C228A4
		/// Type: ObjectProperty
		/// Offset: 0x10
		/// Size: 0x08
		/// </summary>
		public UTexture Icon_6_12BD8E6E41BB51FB55962AAE33C228A4 => ReadUObject<UTexture>(0x10);
		
	}


	/// <summary>
	/// FVoiceOption:
	/// Size: 0x28
	/// Properties: 3
	/// </summary>
	public class FVoiceOption:MemoryObject
	{
		public override int ObjectSize => 40;
		/// <summary>
		/// Name: Voice_5_779289A1403621853F6DC6B1251FFFBD
		/// Type: ByteProperty
		/// Offset: 0x00
		/// Size: 0x01
		/// </summary>
		public byte Voice_5_779289A1403621853F6DC6B1251FFFBD
		{
			get
			{
				return ReadByte(0x00);
			}
			set
			{
				WriteByte(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: VoiceName_9_4853958A4CD36A74ACC77D9542C79BFB
		/// Type: TextProperty
		/// Offset: 0x08
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: SoundCue_11_F0FB45444506D9E4058199948EEF8058
		/// Type: ObjectProperty
		/// Offset: 0x20
		/// Size: 0x08
		/// </summary>
		public USoundCue SoundCue_11_F0FB45444506D9E4058199948EEF8058 => ReadUObject<USoundCue>(0x20);
		
	}


}

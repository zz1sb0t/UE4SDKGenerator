using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;


namespace ConanExilesGame.Game.Characters.NPCs
{
	/// <summary>
	/// FMonsterStatTableStruct:
	/// Size: 0x24
	/// Properties: 9
	/// </summary>
	public class FMonsterStatTableStruct:MemoryObject
	{
		public override int ObjectSize => 36;
		/// <summary>
		/// Name: MonsterHealth_10_84C470A049A332604A8FF6A811BF24C7
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int MonsterHealth_10_84C470A049A332604A8FF6A811BF24C7
		{
			get
			{
				return ReadInt32(0x00);
			}
			set
			{
				WriteInt32(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: MonsterArmor_8_E6AE21E94674D6E02EEEB781B5F8517B
		/// Type: FloatProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public float MonsterArmor_8_E6AE21E94674D6E02EEEB781B5F8517B
		{
			get
			{
				return ReadSingle(0x04);
			}
			set
			{
				WriteSingle(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: MonsterXP_7_DCAD8F1049EA77163A93EB81EDE8E974
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int MonsterXP_7_DCAD8F1049EA77163A93EB81EDE8E974
		{
			get
			{
				return ReadInt32(0x08);
			}
			set
			{
				WriteInt32(0x08,value);
			}
		}
		
		/// <summary>
		/// Name: KBDefense_13_5C79BDF64DB198AE1989848C63C30BF7
		/// Type: IntProperty
		/// Offset: 0x0C
		/// Size: 0x04
		/// </summary>
		public int KBDefense_13_5C79BDF64DB198AE1989848C63C30BF7
		{
			get
			{
				return ReadInt32(0x0C);
			}
			set
			{
				WriteInt32(0x0C,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD1Distance_19_00F83C57482487994110F5A0479DF637
		/// Type: FloatProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public float AILOD1Distance_19_00F83C57482487994110F5A0479DF637
		{
			get
			{
				return ReadSingle(0x10);
			}
			set
			{
				WriteSingle(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD2Distance_20_E389B18040E4485F0971BDBD3CAAA571
		/// Type: FloatProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public float AILOD2Distance_20_E389B18040E4485F0971BDBD3CAAA571
		{
			get
			{
				return ReadSingle(0x14);
			}
			set
			{
				WriteSingle(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: YawRotationRate_23_08444E34479B19A2CA9C2F843CCD61AF
		/// Type: FloatProperty
		/// Offset: 0x18
		/// Size: 0x04
		/// </summary>
		public float YawRotationRate_23_08444E34479B19A2CA9C2F843CCD61AF
		{
			get
			{
				return ReadSingle(0x18);
			}
			set
			{
				WriteSingle(0x18,value);
			}
		}
		
		/// <summary>
		/// Name: PredictionHistorySeconds_26_999E12AE4B1FAEE97E066F8D95BC5F83
		/// Type: FloatProperty
		/// Offset: 0x1C
		/// Size: 0x04
		/// </summary>
		public float PredictionHistorySeconds_26_999E12AE4B1FAEE97E066F8D95BC5F83
		{
			get
			{
				return ReadSingle(0x1C);
			}
			set
			{
				WriteSingle(0x1C,value);
			}
		}
		
		/// <summary>
		/// Name: PredictionOffsetSeconds_28_5FAE522A4D1DB88BDEE2B7A2BA39F174
		/// Type: FloatProperty
		/// Offset: 0x20
		/// Size: 0x04
		/// </summary>
		public float PredictionOffsetSeconds_28_5FAE522A4D1DB88BDEE2B7A2BA39F174
		{
			get
			{
				return ReadSingle(0x20);
			}
			set
			{
				WriteSingle(0x20,value);
			}
		}
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;


namespace ConanExilesGame.Game.Systems.Spawning.Humans
{
	/// <summary>
	/// FNPC_Human_Visuals_Structure:
	/// Size: 0x3C
	/// Properties: 15
	/// </summary>
	public class FNPC_Human_Visuals_Structure:MemoryObject
	{
		public override int ObjectSize => 60;
		/// <summary>
		/// Name: Var1_14_0EC430B0471C444BD95AE6B756550740
		/// Type: IntProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public int Var1_14_0EC430B0471C444BD95AE6B756550740
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
		/// Name: Var2_15_00F248A042A6AAE2DE465E88979C925C
		/// Type: IntProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public int Var2_15_00F248A042A6AAE2DE465E88979C925C
		{
			get
			{
				return ReadInt32(0x04);
			}
			set
			{
				WriteInt32(0x04,value);
			}
		}
		
		/// <summary>
		/// Name: Var3_16_977DCFE343C4B2FD23EAF3B77B395C65
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int Var3_16_977DCFE343C4B2FD23EAF3B77B395C65
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
		/// Name: Var4_17_449267824C864627B085EA8E4175DED4
		/// Type: IntProperty
		/// Offset: 0x0C
		/// Size: 0x04
		/// </summary>
		public int Var4_17_449267824C864627B085EA8E4175DED4
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
		/// Name: Var5_28_D7E6CBD149A8DF418F233E882395F1E8
		/// Type: IntProperty
		/// Offset: 0x10
		/// Size: 0x04
		/// </summary>
		public int Var5_28_D7E6CBD149A8DF418F233E882395F1E8
		{
			get
			{
				return ReadInt32(0x10);
			}
			set
			{
				WriteInt32(0x10,value);
			}
		}
		
		/// <summary>
		/// Name: Var6_29_AE581FFC4EDB52ECA093D983F3CA12C6
		/// Type: IntProperty
		/// Offset: 0x14
		/// Size: 0x04
		/// </summary>
		public int Var6_29_AE581FFC4EDB52ECA093D983F3CA12C6
		{
			get
			{
				return ReadInt32(0x14);
			}
			set
			{
				WriteInt32(0x14,value);
			}
		}
		
		/// <summary>
		/// Name: Var7_30_C6D527AF4D268A5F18BA60B317EC56D9
		/// Type: IntProperty
		/// Offset: 0x18
		/// Size: 0x04
		/// </summary>
		public int Var7_30_C6D527AF4D268A5F18BA60B317EC56D9
		{
			get
			{
				return ReadInt32(0x18);
			}
			set
			{
				WriteInt32(0x18,value);
			}
		}
		
		/// <summary>
		/// Name: Var8_31_C8F8ADF94A76AD80444FB3AB0A2E22D8
		/// Type: IntProperty
		/// Offset: 0x1C
		/// Size: 0x04
		/// </summary>
		public int Var8_31_C8F8ADF94A76AD80444FB3AB0A2E22D8
		{
			get
			{
				return ReadInt32(0x1C);
			}
			set
			{
				WriteInt32(0x1C,value);
			}
		}
		
		/// <summary>
		/// Name: Var9_32_18EF367B4809C0C738F4EF9E36818039
		/// Type: IntProperty
		/// Offset: 0x20
		/// Size: 0x04
		/// </summary>
		public int Var9_32_18EF367B4809C0C738F4EF9E36818039
		{
			get
			{
				return ReadInt32(0x20);
			}
			set
			{
				WriteInt32(0x20,value);
			}
		}
		
		/// <summary>
		/// Name: Var10_45_A9C641194DDA3B9B4B80ADA4859E836F
		/// Type: IntProperty
		/// Offset: 0x24
		/// Size: 0x04
		/// </summary>
		public int Var10_45_A9C641194DDA3B9B4B80ADA4859E836F
		{
			get
			{
				return ReadInt32(0x24);
			}
			set
			{
				WriteInt32(0x24,value);
			}
		}
		
		/// <summary>
		/// Name: Var11_46_1E775AF442D7B900127775A16A119FBD
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int Var11_46_1E775AF442D7B900127775A16A119FBD
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: Var12_47_D83EA10741823FF39B347389A4C19AB6
		/// Type: IntProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public int Var12_47_D83EA10741823FF39B347389A4C19AB6
		{
			get
			{
				return ReadInt32(0x2C);
			}
			set
			{
				WriteInt32(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: Var13_48_4E9E7C6041488CFE973D48B842C56972
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int Var13_48_4E9E7C6041488CFE973D48B842C56972
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: Var14_49_44501AAA4A9F1E8498B48181282EFBC3
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int Var14_49_44501AAA4A9F1E8498B48181282EFBC3
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: Var15_50_A3520462417B7E304F8275BF16D9EDB4
		/// Type: IntProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public int Var15_50_A3520462417B7E304F8275BF16D9EDB4
		{
			get
			{
				return ReadInt32(0x38);
			}
			set
			{
				WriteInt32(0x38,value);
			}
		}
		
	}


}

using UE4.EmptyGame;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;
using UE4.EmptyGame.UnrealStructures;
using UnrealGame.Script;
using UnrealGame.Game.Systems.Inventory;


namespace UnrealGame.Game.Items.Hunger
{
	/// <summary>
	/// UIWaterSource_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UIWaterSource_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBPGameItemWaterskin_C:UBPGameItem_C
	/// Size: 0x36C
	/// Properties: 2
	/// </summary>
	public class UBPGameItemWaterskin_C:UBPGameItem_C
	{
		public override int ObjectSize => 876;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x360);
		
		/// <summary>
		/// Name: OnUseModifyDurabilityValue
		/// Type: FloatProperty
		/// Offset: 0x368
		/// Size: 0x04
		/// </summary>
		public float OnUseModifyDurabilityValue
		{
			get
			{
				return ReadSingle(0x368);
			}
			set
			{
				WriteSingle(0x368,value);
			}
		}
		
	}


}

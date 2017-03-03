using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Corruption
{
	/// <summary>
	/// ABP_TriggerArea_Corruption_C:AActor
	/// Size: 0x414
	/// Properties: 18
	/// </summary>
	public class ABP_TriggerArea_Corruption_C:AActor
	{
		public override int ObjectSize => 1044;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Sphere
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Sphere => ReadUObject<UStaticMeshComponent>(0x3D8);
		
		/// <summary>
		/// Name: EnergySource
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UEnergySourceComponent EnergySource => ReadUObject<UEnergySourceComponent>(0x3E0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: EnergyType
		/// Type: ByteProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public byte EnergyType
		{
			get
			{
				return ReadByte(0x3F0);
			}
			set
			{
				WriteByte(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: ItemForce
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float ItemForce
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: MinRadius
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float MinRadius
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxRadius
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float MaxRadius
		{
			get
			{
				return ReadSingle(0x3FC);
			}
			set
			{
				WriteSingle(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: useStatForce
		/// Type: BoolProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public bool useStatForce
		{
			get
			{
				return ReadBool(0x400);
			}
			set
			{
				WriteBool(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: DynamicForceStat
		/// Type: ByteProperty
		/// Offset: 0x401
		/// Size: 0x01
		/// </summary>
		public byte DynamicForceStat
		{
			get
			{
				return ReadByte(0x401);
			}
			set
			{
				WriteByte(0x401,value);
			}
		}
		
		/// <summary>
		/// Name: LimitUpper
		/// Type: BoolProperty
		/// Offset: 0x402
		/// Size: 0x01
		/// </summary>
		public bool LimitUpper
		{
			get
			{
				return ReadBool(0x402);
			}
			set
			{
				WriteBool(0x402,value);
			}
		}
		
		/// <summary>
		/// Name: LimitLower
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float LimitLower
		{
			get
			{
				return ReadSingle(0x404);
			}
			set
			{
				WriteSingle(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: LimitLower3
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool LimitLower3
		{
			get
			{
				return ReadBool(0x408);
			}
			set
			{
				WriteBool(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: MinEnergy
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float MinEnergy
		{
			get
			{
				return ReadSingle(0x40C);
			}
			set
			{
				WriteSingle(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: UseEnergyReceiverMinMax
		/// Type: BoolProperty
		/// Offset: 0x410
		/// Size: 0x01
		/// </summary>
		public bool UseEnergyReceiverMinMax
		{
			get
			{
				return ReadBool(0x410);
			}
			set
			{
				WriteBool(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: UseStatMinMax
		/// Type: BoolProperty
		/// Offset: 0x411
		/// Size: 0x01
		/// </summary>
		public bool UseStatMinMax
		{
			get
			{
				return ReadBool(0x411);
			}
			set
			{
				WriteBool(0x411,value);
			}
		}
		
		/// <summary>
		/// Name: StatMinMaxEnergy
		/// Type: ByteProperty
		/// Offset: 0x412
		/// Size: 0x01
		/// </summary>
		public byte StatMinMaxEnergy
		{
			get
			{
				return ReadByte(0x412);
			}
			set
			{
				WriteByte(0x412,value);
			}
		}
		
		/// <summary>
		/// Name: SizetoFit
		/// Type: BoolProperty
		/// Offset: 0x413
		/// Size: 0x01
		/// </summary>
		public bool SizetoFit
		{
			get
			{
				return ReadBool(0x413);
			}
			set
			{
				WriteBool(0x413,value);
			}
		}
		
	}


}

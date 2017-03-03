using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Sound.Audio_Blueprints
{
	/// <summary>
	/// AAudio_POPS_Sphere_C:AActor
	/// Size: 0x440
	/// Properties: 21
	/// </summary>
	public class AAudio_POPS_Sphere_C:AActor
	{
		public override int ObjectSize => 1088;
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
		public USphereComponent Sphere => ReadUObject<USphereComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio => ReadUObject<USoundCue>(0x3E8);
		
		/// <summary>
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float DelayMin
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float delaymax
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
		/// Name: RangeXMin
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float RangeXMin
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
		/// Name: RangeXMax
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float RangeXMax
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
		/// Name: RangeYMin
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float RangeYMin
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RangeYMax
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
		/// Name: UserPlayerRotation
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation
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
		/// Name: Audio2
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio2 => ReadUObject<USoundCue>(0x410);
		
		/// <summary>
		/// Name: DelayMin2
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float DelayMin2
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax2
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float DelayMax2
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin2
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float RangeXMin2
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax2
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float RangeXMax2
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin2
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float RangeYMin2
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax2
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float RangeYMax2
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation2
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation2
		{
			get
			{
				return ReadBool(0x430);
			}
			set
			{
				WriteBool(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: Size
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float Size
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: Reverb
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UReverbEffect Reverb => ReadUObject<UReverbEffect>(0x438);
		
	}


	/// <summary>
	/// AAudio_POP_Area_Trigger_Controller_C:AActor
	/// Size: 0x499
	/// Properties: 36
	/// </summary>
	public class AAudio_POP_Area_Trigger_Controller_C:AActor
	{
		public override int ObjectSize => 1177;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: ConanAudio
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ConanAudio => ReadUObject<UConanAudioComponent>(0x3D8);
		
		/// <summary>
		/// Name: Billboard
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent Billboard => ReadUObject<UBillboardComponent>(0x3E0);
		
		/// <summary>
		/// Name: Reverb
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UReverbEffect Reverb => ReadUObject<UReverbEffect>(0x3E8);
		
		/// <summary>
		/// Name: TriggerVolume
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public ATriggerVolume TriggerVolume => ReadUObject<ATriggerVolume>(0x3F0);
		
		/// <summary>
		/// Name: _3D_EnterSound
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USoundBase _3D_EnterSound => ReadUObject<USoundBase>(0x3F8);
		
		/// <summary>
		/// Name: _3D_LeaveSound
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public USoundBase _3D_LeaveSound => ReadUObject<USoundBase>(0x400);
		
		/// <summary>
		/// Name: _2D_Sound_Loop
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public USoundBase _2D_Sound_Loop => ReadUObject<USoundBase>(0x408);
		
		/// <summary>
		/// Name: MIX
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USoundMix MIX => ReadUObject<USoundMix>(0x410);
		
		/// <summary>
		/// Name: _2DFadein
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float _2DFadein
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: _2DFadeout
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float _2DFadeout
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: _3DSound1
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public USoundCue _3DSound1 => ReadUObject<USoundCue>(0x420);
		
		/// <summary>
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float DelayMin
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float delaymax
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmin
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float RangeXmin
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmax
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float RangeXmax
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmin
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float RangeYmin
		{
			get
			{
				return ReadSingle(0x438);
			}
			set
			{
				WriteSingle(0x438,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax
		/// Type: FloatProperty
		/// Offset: 0x43C
		/// Size: 0x04
		/// </summary>
		public float RangeYmax
		{
			get
			{
				return ReadSingle(0x43C);
			}
			set
			{
				WriteSingle(0x43C,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerOrientation
		/// Type: BoolProperty
		/// Offset: 0x440
		/// Size: 0x01
		/// </summary>
		public bool PlayerOrientation
		{
			get
			{
				return ReadBool(0x440);
			}
			set
			{
				WriteBool(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: _3DSound2
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public USoundCue _3DSound2 => ReadUObject<USoundCue>(0x448);
		
		/// <summary>
		/// Name: DelayMin2
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float DelayMin2
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax2
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float DelayMax2
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmin2
		/// Type: FloatProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public float RangeXmin2
		{
			get
			{
				return ReadSingle(0x458);
			}
			set
			{
				WriteSingle(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmax2
		/// Type: FloatProperty
		/// Offset: 0x45C
		/// Size: 0x04
		/// </summary>
		public float RangeXmax2
		{
			get
			{
				return ReadSingle(0x45C);
			}
			set
			{
				WriteSingle(0x45C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmin2
		/// Type: FloatProperty
		/// Offset: 0x460
		/// Size: 0x04
		/// </summary>
		public float RangeYmin2
		{
			get
			{
				return ReadSingle(0x460);
			}
			set
			{
				WriteSingle(0x460,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax2
		/// Type: FloatProperty
		/// Offset: 0x464
		/// Size: 0x04
		/// </summary>
		public float RangeYmax2
		{
			get
			{
				return ReadSingle(0x464);
			}
			set
			{
				WriteSingle(0x464,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerOrientation2
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool PlayerOrientation2
		{
			get
			{
				return ReadBool(0x468);
			}
			set
			{
				WriteBool(0x468,value);
			}
		}
		
		/// <summary>
		/// Name: CachedAudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent CachedAudioComponent => ReadUObject<UConanAudioComponent>(0x470);
		
		/// <summary>
		/// Name: _3DSound3
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public USoundCue _3DSound3 => ReadUObject<USoundCue>(0x478);
		
		/// <summary>
		/// Name: DelayMin3
		/// Type: FloatProperty
		/// Offset: 0x480
		/// Size: 0x04
		/// </summary>
		public float DelayMin3
		{
			get
			{
				return ReadSingle(0x480);
			}
			set
			{
				WriteSingle(0x480,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax3
		/// Type: FloatProperty
		/// Offset: 0x484
		/// Size: 0x04
		/// </summary>
		public float DelayMax3
		{
			get
			{
				return ReadSingle(0x484);
			}
			set
			{
				WriteSingle(0x484,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmin3
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float RangeXmin3
		{
			get
			{
				return ReadSingle(0x488);
			}
			set
			{
				WriteSingle(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXmax3
		/// Type: FloatProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public float RangeXmax3
		{
			get
			{
				return ReadSingle(0x48C);
			}
			set
			{
				WriteSingle(0x48C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmin3
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float RangeYmin3
		{
			get
			{
				return ReadSingle(0x490);
			}
			set
			{
				WriteSingle(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax3
		/// Type: FloatProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public float RangeYmax3
		{
			get
			{
				return ReadSingle(0x494);
			}
			set
			{
				WriteSingle(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerOrientation3
		/// Type: BoolProperty
		/// Offset: 0x498
		/// Size: 0x01
		/// </summary>
		public bool PlayerOrientation3
		{
			get
			{
				return ReadBool(0x498);
			}
			set
			{
				WriteBool(0x498,value);
			}
		}
		
	}


	/// <summary>
	/// APOI_ACTOR_C:AActor
	/// Size: 0x3E4
	/// Properties: 3
	/// </summary>
	public class APOI_ACTOR_C:AActor
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


	/// <summary>
	/// AAudio_POPS_Box_C:AActor
	/// Size: 0x431
	/// Properties: 19
	/// </summary>
	public class AAudio_POPS_Box_C:AActor
	{
		public override int ObjectSize => 1073;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Box
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UBoxComponent Box => ReadUObject<UBoxComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio => ReadUObject<USoundCue>(0x3E8);
		
		/// <summary>
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float DelayMin
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float delaymax
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
		/// Name: RangeXMin
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float RangeXMin
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
		/// Name: RangeXMax
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float RangeXMax
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
		/// Name: RangeYMin
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float RangeYMin
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RangeYMax
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
		/// Name: UserPlayerRotation
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation
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
		/// Name: Audio2
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio2 => ReadUObject<USoundCue>(0x410);
		
		/// <summary>
		/// Name: DelayMin2
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float DelayMin2
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax2
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float DelayMax2
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin2
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float RangeXMin2
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax2
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float RangeXMax2
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin2
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float RangeYMin2
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax2
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float RangeYMax2
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation2
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation2
		{
			get
			{
				return ReadBool(0x430);
			}
			set
			{
				WriteBool(0x430,value);
			}
		}
		
	}


	/// <summary>
	/// AAudio_POPS_Sphere_2D_3D_master_C:AActor
	/// Size: 0x488
	/// Properties: 33
	/// </summary>
	public class AAudio_POPS_Sphere_2D_3D_master_C:AActor
	{
		public override int ObjectSize => 1160;
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
		public USphereComponent Sphere => ReadUObject<USphereComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio => ReadUObject<USoundCue>(0x3E8);
		
		/// <summary>
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float DelayMin
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float delaymax
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
		/// Name: RangeXMin
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float RangeXMin
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
		/// Name: RangeXMax
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float RangeXMax
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
		/// Name: RangeYMin
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float RangeYMin
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RangeYMax
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
		/// Name: UserPlayerRotation
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation
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
		/// Name: Audio2
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio2 => ReadUObject<USoundCue>(0x410);
		
		/// <summary>
		/// Name: DelayMin2
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float DelayMin2
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax2
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float DelayMax2
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin2
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float RangeXMin2
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax2
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float RangeXMax2
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin2
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float RangeYMin2
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax2
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float RangeYmax2
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation2
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation2
		{
			get
			{
				return ReadBool(0x430);
			}
			set
			{
				WriteBool(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: Audio3
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio3 => ReadUObject<USoundCue>(0x438);
		
		/// <summary>
		/// Name: DelayMin3
		/// Type: FloatProperty
		/// Offset: 0x440
		/// Size: 0x04
		/// </summary>
		public float DelayMin3
		{
			get
			{
				return ReadSingle(0x440);
			}
			set
			{
				WriteSingle(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax3
		/// Type: FloatProperty
		/// Offset: 0x444
		/// Size: 0x04
		/// </summary>
		public float DelayMax3
		{
			get
			{
				return ReadSingle(0x444);
			}
			set
			{
				WriteSingle(0x444,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin3
		/// Type: FloatProperty
		/// Offset: 0x448
		/// Size: 0x04
		/// </summary>
		public float RangeXMin3
		{
			get
			{
				return ReadSingle(0x448);
			}
			set
			{
				WriteSingle(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax3
		/// Type: FloatProperty
		/// Offset: 0x44C
		/// Size: 0x04
		/// </summary>
		public float RangeXMax3
		{
			get
			{
				return ReadSingle(0x44C);
			}
			set
			{
				WriteSingle(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin3
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float RangeYMin3
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax3
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float RangeYmax3
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation3
		/// Type: BoolProperty
		/// Offset: 0x458
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation3
		{
			get
			{
				return ReadBool(0x458);
			}
			set
			{
				WriteBool(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: _2dsound
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USoundBase _2dsound => ReadUObject<USoundBase>(0x460);
		
		/// <summary>
		/// Name: _2dsound_fadein
		/// Type: FloatProperty
		/// Offset: 0x468
		/// Size: 0x04
		/// </summary>
		public float _2dsound_fadein
		{
			get
			{
				return ReadSingle(0x468);
			}
			set
			{
				WriteSingle(0x468,value);
			}
		}
		
		/// <summary>
		/// Name: _2dsound_fadeout
		/// Type: FloatProperty
		/// Offset: 0x46C
		/// Size: 0x04
		/// </summary>
		public float _2dsound_fadeout
		{
			get
			{
				return ReadSingle(0x46C);
			}
			set
			{
				WriteSingle(0x46C,value);
			}
		}
		
		/// <summary>
		/// Name: Reverb
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UReverbEffect Reverb => ReadUObject<UReverbEffect>(0x470);
		
		/// <summary>
		/// Name: Size
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float Size
		{
			get
			{
				return ReadSingle(0x478);
			}
			set
			{
				WriteSingle(0x478,value);
			}
		}
		
		/// <summary>
		/// Name: CachedAudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent CachedAudioComponent => ReadUObject<UConanAudioComponent>(0x480);
		
	}


	/// <summary>
	/// AAudio_POPS_Sphere_Pirates_C:AActor
	/// Size: 0x484
	/// Properties: 33
	/// </summary>
	public class AAudio_POPS_Sphere_Pirates_C:AActor
	{
		public override int ObjectSize => 1156;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: Capsule
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent Capsule => ReadUObject<UCapsuleComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio => ReadUObject<USoundCue>(0x3E8);
		
		/// <summary>
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float DelayMin
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float delaymax
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
		/// Name: RangeXMin
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float RangeXMin
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
		/// Name: RangeXMax
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float RangeXMax
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
		/// Name: RangeYMin
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float RangeYMin
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMax
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RangeYMax
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
		/// Name: UserPlayerRotation
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation
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
		/// Name: Audio2
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio2 => ReadUObject<USoundCue>(0x410);
		
		/// <summary>
		/// Name: DelayMin2
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float DelayMin2
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax2
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float DelayMax2
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin2
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float RangeXMin2
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax2
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float RangeXMax2
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin2
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float RangeYMin2
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax2
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float RangeYmax2
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation2
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation2
		{
			get
			{
				return ReadBool(0x430);
			}
			set
			{
				WriteBool(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: lastAudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent lastAudioComponent => ReadUObject<UConanAudioComponent>(0x438);
		
		/// <summary>
		/// Name: Audio3
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public USoundCue Audio3 => ReadUObject<USoundCue>(0x440);
		
		/// <summary>
		/// Name: DelayMin3
		/// Type: FloatProperty
		/// Offset: 0x448
		/// Size: 0x04
		/// </summary>
		public float DelayMin3
		{
			get
			{
				return ReadSingle(0x448);
			}
			set
			{
				WriteSingle(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax3
		/// Type: FloatProperty
		/// Offset: 0x44C
		/// Size: 0x04
		/// </summary>
		public float DelayMax3
		{
			get
			{
				return ReadSingle(0x44C);
			}
			set
			{
				WriteSingle(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMin3
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float RangeXMin3
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: RangeXMax3
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float RangeXMax3
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYMin3
		/// Type: FloatProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public float RangeYMin3
		{
			get
			{
				return ReadSingle(0x458);
			}
			set
			{
				WriteSingle(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: RangeYmax3
		/// Type: FloatProperty
		/// Offset: 0x45C
		/// Size: 0x04
		/// </summary>
		public float RangeYmax3
		{
			get
			{
				return ReadSingle(0x45C);
			}
			set
			{
				WriteSingle(0x45C,value);
			}
		}
		
		/// <summary>
		/// Name: UserPlayerRotation3
		/// Type: BoolProperty
		/// Offset: 0x460
		/// Size: 0x01
		/// </summary>
		public bool UserPlayerRotation3
		{
			get
			{
				return ReadBool(0x460);
			}
			set
			{
				WriteBool(0x460,value);
			}
		}
		
		/// <summary>
		/// Name: _2dsound
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public USoundBase _2dsound => ReadUObject<USoundBase>(0x468);
		
		/// <summary>
		/// Name: _2dsound_fadein
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float _2dsound_fadein
		{
			get
			{
				return ReadSingle(0x470);
			}
			set
			{
				WriteSingle(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: _2dsound_fadeout
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float _2dsound_fadeout
		{
			get
			{
				return ReadSingle(0x474);
			}
			set
			{
				WriteSingle(0x474,value);
			}
		}
		
		/// <summary>
		/// Name: Reverb
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UReverbEffect Reverb => ReadUObject<UReverbEffect>(0x478);
		
		/// <summary>
		/// Name: Size
		/// Type: FloatProperty
		/// Offset: 0x480
		/// Size: 0x04
		/// </summary>
		public float Size
		{
			get
			{
				return ReadSingle(0x480);
			}
			set
			{
				WriteSingle(0x480,value);
			}
		}
		
	}


	/// <summary>
	/// AAudio_WOP_Rand_Play_Location_C:AActor
	/// Size: 0x464
	/// Properties: 28
	/// </summary>
	public class AAudio_WOP_Rand_Play_Location_C:AActor
	{
		public override int ObjectSize => 1124;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3D0);
		
		/// <summary>
		/// Name: ConanAudio
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ConanAudio => ReadUObject<UConanAudioComponent>(0x3D8);
		
		/// <summary>
		/// Name: Sphere
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USphereComponent Sphere => ReadUObject<USphereComponent>(0x3E0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: Sound
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USoundBase Sound => ReadUObject<USoundBase>(0x3F0);
		
		/// <summary>
		/// Name: volume1
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float volume1
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
		/// Name: DelayMin
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float DelayMin
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
		/// Name: delaymax
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float delaymax
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: xmin
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float xmin
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
		/// Name: xmax
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float xmax
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: ymin
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float ymin
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
		/// Name: ymax
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float ymax
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
		
		/// <summary>
		/// Name: Sound2
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public USoundBase Sound2 => ReadUObject<USoundBase>(0x418);
		
		/// <summary>
		/// Name: volume2
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float volume2
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: delaymin2
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float delaymin2
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: delaymax2
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float delaymax2
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: xmin2
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float xmin2
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: xmax2
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float xmax2
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: ymin2
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float ymin2
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: ymax2
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float ymax2
		{
			get
			{
				return ReadSingle(0x438);
			}
			set
			{
				WriteSingle(0x438,value);
			}
		}
		
		/// <summary>
		/// Name: Sound3
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public USoundBase Sound3 => ReadUObject<USoundBase>(0x440);
		
		/// <summary>
		/// Name: volume3
		/// Type: FloatProperty
		/// Offset: 0x448
		/// Size: 0x04
		/// </summary>
		public float volume3
		{
			get
			{
				return ReadSingle(0x448);
			}
			set
			{
				WriteSingle(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMin3
		/// Type: FloatProperty
		/// Offset: 0x44C
		/// Size: 0x04
		/// </summary>
		public float DelayMin3
		{
			get
			{
				return ReadSingle(0x44C);
			}
			set
			{
				WriteSingle(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: DelayMax3
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float DelayMax3
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: xmin3
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float xmin3
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: xmax3
		/// Type: FloatProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public float xmax3
		{
			get
			{
				return ReadSingle(0x458);
			}
			set
			{
				WriteSingle(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: ymin3
		/// Type: FloatProperty
		/// Offset: 0x45C
		/// Size: 0x04
		/// </summary>
		public float ymin3
		{
			get
			{
				return ReadSingle(0x45C);
			}
			set
			{
				WriteSingle(0x45C,value);
			}
		}
		
		/// <summary>
		/// Name: ymax3
		/// Type: FloatProperty
		/// Offset: 0x460
		/// Size: 0x04
		/// </summary>
		public float ymax3
		{
			get
			{
				return ReadSingle(0x460);
			}
			set
			{
				WriteSingle(0x460,value);
			}
		}
		
	}


}

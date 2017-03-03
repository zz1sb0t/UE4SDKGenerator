using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Marketplace.UltraDynamicSky.Blueprints;


namespace ConanExilesGame.Game.Marketplace.UltraDynamicSky.Blueprints
{
	/// <summary>
	/// AUltra_Dynamic_Sky_BP_C:ADynamicSkyBase
	/// Size: 0x69C
	/// Properties: 100
	/// </summary>
	public class AUltra_Dynamic_Sky_BP_C:ADynamicSkyBase
	{
		public override int ObjectSize => 1692;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E0);
		
		/// <summary>
		/// Name: Sun_Root
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UArrowComponent Sun_Root => ReadUObject<UArrowComponent>(0x3E8);
		
		/// <summary>
		/// Name: Ultra_Dynamic_Sky_Sphere
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Ultra_Dynamic_Sky_Sphere => ReadUObject<UStaticMeshComponent>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: DirectionLightSun
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight DirectionLightSun => ReadUObject<ADirectionalLight>(0x400);
		
		/// <summary>
		/// Name: UDM_mat
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic UDM_mat => ReadUObject<UMaterialInstanceDynamic>(0x408);
		
		/// <summary>
		/// Name: RefreshSettings
		/// Type: BoolProperty
		/// Offset: 0x410
		/// Size: 0x01
		/// </summary>
		public bool RefreshSettings
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
		/// Name: CloudSpeed
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float CloudSpeed
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensity
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float CloudDensity
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
		/// Name: CloudWispsOpacity
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float CloudWispsOpacity
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
		/// Name: HorizonBaseColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor HorizonBaseColorCurve => ReadUObject<UCurveLinearColor>(0x420);
		
		/// <summary>
		/// Name: ZenithBaseColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor ZenithBaseColorCurve => ReadUObject<UCurveLinearColor>(0x428);
		
		/// <summary>
		/// Name: CloudLightColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudLightColorCurve => ReadUObject<UCurveLinearColor>(0x430);
		
		/// <summary>
		/// Name: CloudDarkColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudDarkColorCurve => ReadUObject<UCurveLinearColor>(0x438);
		
		/// <summary>
		/// Name: SunColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunColorCurve => ReadUObject<UCurveLinearColor>(0x440);
		
		/// <summary>
		/// Name: ShineIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ShineIntensityCurve => ReadUObject<UCurveFloat>(0x448);
		
		/// <summary>
		/// Name: Saturation
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float Saturation
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
		/// Name: SunCloudyColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunCloudyColorCurve => ReadUObject<UCurveLinearColor>(0x458);
		
		/// <summary>
		/// Name: ExponentialHeightFog
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public AExponentialHeightFog ExponentialHeightFog => ReadUObject<AExponentialHeightFog>(0x460);
		
		/// <summary>
		/// Name: StarsIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UCurveFloat StarsIntensityCurve => ReadUObject<UCurveFloat>(0x468);
		
		/// <summary>
		/// Name: CloudPhase
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float CloudPhase
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
		/// Name: MoonScale
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float MoonScale
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
		/// Name: MoonInclination
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float MoonInclination
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
		/// Name: MoonPhase
		/// Type: FloatProperty
		/// Offset: 0x47C
		/// Size: 0x04
		/// </summary>
		public float MoonPhase
		{
			get
			{
				return ReadSingle(0x47C);
			}
			set
			{
				WriteSingle(0x47C,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetAdvancedSettingsusingTimeofDay
		/// Type: BoolProperty
		/// Offset: 0x480
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetAdvancedSettingsusingTimeofDay
		{
			get
			{
				return ReadBool(0x480);
			}
			set
			{
				WriteBool(0x480,value);
			}
		}
		
		/// <summary>
		/// Name: StarsVisibility
		/// Type: FloatProperty
		/// Offset: 0x484
		/// Size: 0x04
		/// </summary>
		public float StarsVisibility
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
		/// Name: MoonIntensity
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float MoonIntensity
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
		/// Name: MoonPosition
		/// Type: FloatProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public float MoonPosition
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
		/// Name: SunAngle
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float SunAngle
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
		/// Name: HorizonBaseColor
		/// Type: StructProperty
		/// Offset: 0x494
		/// Size: 0x10
		/// </summary>
		public FLinearColor HorizonBaseColor => ReadStruct<FLinearColor>(0x494);
		
		/// <summary>
		/// Name: ZenithBaseColor
		/// Type: StructProperty
		/// Offset: 0x4A4
		/// Size: 0x10
		/// </summary>
		public FLinearColor ZenithBaseColor => ReadStruct<FLinearColor>(0x4A4);
		
		/// <summary>
		/// Name: CloudLightColor
		/// Type: StructProperty
		/// Offset: 0x4B4
		/// Size: 0x10
		/// </summary>
		public FLinearColor CloudLightColor => ReadStruct<FLinearColor>(0x4B4);
		
		/// <summary>
		/// Name: CloudDarkColor
		/// Type: StructProperty
		/// Offset: 0x4C4
		/// Size: 0x10
		/// </summary>
		public FLinearColor CloudDarkColor => ReadStruct<FLinearColor>(0x4C4);
		
		/// <summary>
		/// Name: SunColor
		/// Type: StructProperty
		/// Offset: 0x4D4
		/// Size: 0x10
		/// </summary>
		public FLinearColor SunColor => ReadStruct<FLinearColor>(0x4D4);
		
		/// <summary>
		/// Name: CloudShineIntensity
		/// Type: FloatProperty
		/// Offset: 0x4E4
		/// Size: 0x04
		/// </summary>
		public float CloudShineIntensity
		{
			get
			{
				return ReadSingle(0x4E4);
			}
			set
			{
				WriteSingle(0x4E4,value);
			}
		}
		
		/// <summary>
		/// Name: SunLightColor
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x10
		/// </summary>
		public FLinearColor SunLightColor => ReadStruct<FLinearColor>(0x4E8);
		
		/// <summary>
		/// Name: DayLength
		/// Type: FloatProperty
		/// Offset: 0x4F8
		/// Size: 0x04
		/// </summary>
		public float DayLength
		{
			get
			{
				return ReadSingle(0x4F8);
			}
			set
			{
				WriteSingle(0x4F8,value);
			}
		}
		
		/// <summary>
		/// Name: MoonPositionCurve
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public UCurveFloat MoonPositionCurve => ReadUObject<UCurveFloat>(0x500);
		
		/// <summary>
		/// Name: AnimateDayNightCycle
		/// Type: BoolProperty
		/// Offset: 0x508
		/// Size: 0x01
		/// </summary>
		public bool AnimateDayNightCycle
		{
			get
			{
				return ReadBool(0x508);
			}
			set
			{
				WriteBool(0x508,value);
			}
		}
		
		/// <summary>
		/// Name: SimulateCloudDensityChanges
		/// Type: BoolProperty
		/// Offset: 0x509
		/// Size: 0x01
		/// </summary>
		public bool SimulateCloudDensityChanges
		{
			get
			{
				return ReadBool(0x509);
			}
			set
			{
				WriteBool(0x509,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityShiftFrequencymin
		/// Type: FloatProperty
		/// Offset: 0x50C
		/// Size: 0x04
		/// </summary>
		public float CloudDensityShiftFrequencymin
		{
			get
			{
				return ReadSingle(0x50C);
			}
			set
			{
				WriteSingle(0x50C,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityShiftFrequencymax
		/// Type: FloatProperty
		/// Offset: 0x510
		/// Size: 0x04
		/// </summary>
		public float CloudDensityShiftFrequencymax
		{
			get
			{
				return ReadSingle(0x510);
			}
			set
			{
				WriteSingle(0x510,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensity_target
		/// Type: FloatProperty
		/// Offset: 0x514
		/// Size: 0x04
		/// </summary>
		public float CloudDensity_target
		{
			get
			{
				return ReadSingle(0x514);
			}
			set
			{
				WriteSingle(0x514,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityChangeSmoothing
		/// Type: FloatProperty
		/// Offset: 0x518
		/// Size: 0x04
		/// </summary>
		public float CloudDensityChangeSmoothing
		{
			get
			{
				return ReadSingle(0x518);
			}
			set
			{
				WriteSingle(0x518,value);
			}
		}
		
		/// <summary>
		/// Name: CloudOpacity
		/// Type: FloatProperty
		/// Offset: 0x51C
		/// Size: 0x04
		/// </summary>
		public float CloudOpacity
		{
			get
			{
				return ReadSingle(0x51C);
			}
			set
			{
				WriteSingle(0x51C,value);
			}
		}
		
		/// <summary>
		/// Name: OverallIntensity
		/// Type: FloatProperty
		/// Offset: 0x520
		/// Size: 0x04
		/// </summary>
		public float OverallIntensity
		{
			get
			{
				return ReadSingle(0x520);
			}
			set
			{
				WriteSingle(0x520,value);
			}
		}
		
		/// <summary>
		/// Name: SunBrightness
		/// Type: FloatProperty
		/// Offset: 0x524
		/// Size: 0x04
		/// </summary>
		public float SunBrightness
		{
			get
			{
				return ReadSingle(0x524);
			}
			set
			{
				WriteSingle(0x524,value);
			}
		}
		
		/// <summary>
		/// Name: MoonColor
		/// Type: StructProperty
		/// Offset: 0x528
		/// Size: 0x10
		/// </summary>
		public FLinearColor MoonColor => ReadStruct<FLinearColor>(0x528);
		
		/// <summary>
		/// Name: ShineVariation
		/// Type: FloatProperty
		/// Offset: 0x538
		/// Size: 0x04
		/// </summary>
		public float ShineVariation
		{
			get
			{
				return ReadSingle(0x538);
			}
			set
			{
				WriteSingle(0x538,value);
			}
		}
		
		/// <summary>
		/// Name: SunLightingIntensity
		/// Type: FloatProperty
		/// Offset: 0x53C
		/// Size: 0x04
		/// </summary>
		public float SunLightingIntensity
		{
			get
			{
				return ReadSingle(0x53C);
			}
			set
			{
				WriteSingle(0x53C,value);
			}
		}
		
		/// <summary>
		/// Name: SunHighlightRadius_curve
		/// Type: ObjectProperty
		/// Offset: 0x540
		/// Size: 0x08
		/// </summary>
		public UCurveFloat SunHighlightRadius_curve => ReadUObject<UCurveFloat>(0x540);
		
		/// <summary>
		/// Name: SunHighlightRadius
		/// Type: FloatProperty
		/// Offset: 0x548
		/// Size: 0x04
		/// </summary>
		public float SunHighlightRadius
		{
			get
			{
				return ReadSingle(0x548);
			}
			set
			{
				WriteSingle(0x548,value);
			}
		}
		
		/// <summary>
		/// Name: FirstDay
		/// Type: BoolProperty
		/// Offset: 0x54C
		/// Size: 0x01
		/// </summary>
		public bool FirstDay
		{
			get
			{
				return ReadBool(0x54C);
			}
			set
			{
				WriteBool(0x54C,value);
			}
		}
		
		/// <summary>
		/// Name: SimulateMoonPhaseChanges
		/// Type: BoolProperty
		/// Offset: 0x54D
		/// Size: 0x01
		/// </summary>
		public bool SimulateMoonPhaseChanges
		{
			get
			{
				return ReadBool(0x54D);
			}
			set
			{
				WriteBool(0x54D,value);
			}
		}
		
		/// <summary>
		/// Name: Stars_Intensity
		/// Type: FloatProperty
		/// Offset: 0x550
		/// Size: 0x04
		/// </summary>
		public float Stars_Intensity
		{
			get
			{
				return ReadSingle(0x550);
			}
			set
			{
				WriteSingle(0x550,value);
			}
		}
		
		/// <summary>
		/// Name: Stars_Color
		/// Type: StructProperty
		/// Offset: 0x554
		/// Size: 0x10
		/// </summary>
		public FLinearColor Stars_Color => ReadStruct<FLinearColor>(0x554);
		
		/// <summary>
		/// Name: MoonOrbitOffset
		/// Type: FloatProperty
		/// Offset: 0x564
		/// Size: 0x04
		/// </summary>
		public float MoonOrbitOffset
		{
			get
			{
				return ReadSingle(0x564);
			}
			set
			{
				WriteSingle(0x564,value);
			}
		}
		
		/// <summary>
		/// Name: SunRotation
		/// Type: StructProperty
		/// Offset: 0x568
		/// Size: 0x0C
		/// </summary>
		public FRotator SunRotation => ReadStruct<FRotator>(0x568);
		
		/// <summary>
		/// Name: SunRadius
		/// Type: FloatProperty
		/// Offset: 0x574
		/// Size: 0x04
		/// </summary>
		public float SunRadius
		{
			get
			{
				return ReadSingle(0x574);
			}
			set
			{
				WriteSingle(0x574,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsMID
		/// Type: ObjectProperty
		/// Offset: 0x578
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic CloudShadowsMID => ReadUObject<UMaterialInstanceDynamic>(0x578);
		
		/// <summary>
		/// Name: UseCloudShadows
		/// Type: BoolProperty
		/// Offset: 0x580
		/// Size: 0x01
		/// </summary>
		public bool UseCloudShadows
		{
			get
			{
				return ReadBool(0x580);
			}
			set
			{
				WriteBool(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsScale
		/// Type: FloatProperty
		/// Offset: 0x584
		/// Size: 0x04
		/// </summary>
		public float CloudShadowsScale
		{
			get
			{
				return ReadSingle(0x584);
			}
			set
			{
				WriteSingle(0x584,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsIntensity
		/// Type: FloatProperty
		/// Offset: 0x588
		/// Size: 0x04
		/// </summary>
		public float CloudShadowsIntensity
		{
			get
			{
				return ReadSingle(0x588);
			}
			set
			{
				WriteSingle(0x588,value);
			}
		}
		
		/// <summary>
		/// Name: MoonLight
		/// Type: ObjectProperty
		/// Offset: 0x590
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight MoonLight => ReadUObject<ADirectionalLight>(0x590);
		
		/// <summary>
		/// Name: ManuallySelectSunColor
		/// Type: BoolProperty
		/// Offset: 0x598
		/// Size: 0x01
		/// </summary>
		public bool ManuallySelectSunColor
		{
			get
			{
				return ReadBool(0x598);
			}
			set
			{
				WriteBool(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetMoonLightRotation
		/// Type: BoolProperty
		/// Offset: 0x599
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetMoonLightRotation
		{
			get
			{
				return ReadBool(0x599);
			}
			set
			{
				WriteBool(0x599,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetSunLightRotation
		/// Type: BoolProperty
		/// Offset: 0x59A
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetSunLightRotation
		{
			get
			{
				return ReadBool(0x59A);
			}
			set
			{
				WriteBool(0x59A,value);
			}
		}
		
		/// <summary>
		/// Name: MoonlightIntensity
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float MoonlightIntensity
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: StarsSpeed
		/// Type: FloatProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public float StarsSpeed
		{
			get
			{
				return ReadSingle(0x5A0);
			}
			set
			{
				WriteSingle(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: SunInclination
		/// Type: FloatProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public float SunInclination
		{
			get
			{
				return ReadSingle(0x5A4);
			}
			set
			{
				WriteSingle(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: SunYaw
		/// Type: FloatProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public float SunYaw
		{
			get
			{
				return ReadSingle(0x5A8);
			}
			set
			{
				WriteSingle(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: MoonRotation
		/// Type: FloatProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public float MoonRotation
		{
			get
			{
				return ReadSingle(0x5AC);
			}
			set
			{
				WriteSingle(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: CustomMoonTexture
		/// Type: ObjectProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public UTexture2D CustomMoonTexture => ReadUObject<UTexture2D>(0x5B0);
		
		/// <summary>
		/// Name: UseCustomMoonTexture
		/// Type: BoolProperty
		/// Offset: 0x5B8
		/// Size: 0x01
		/// </summary>
		public bool UseCustomMoonTexture
		{
			get
			{
				return ReadBool(0x5B8);
			}
			set
			{
				WriteBool(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: SkyLight
		/// Type: ObjectProperty
		/// Offset: 0x5C0
		/// Size: 0x08
		/// </summary>
		public ASkyLight SkyLight => ReadUObject<ASkyLight>(0x5C0);
		
		/// <summary>
		/// Name: RecaptureSkylightperiodically
		/// Type: BoolProperty
		/// Offset: 0x5C8
		/// Size: 0x01
		/// </summary>
		public bool RecaptureSkylightperiodically
		{
			get
			{
				return ReadBool(0x5C8);
			}
			set
			{
				WriteBool(0x5C8,value);
			}
		}
		
		/// <summary>
		/// Name: SkyLightrecaptureperiod
		/// Type: FloatProperty
		/// Offset: 0x5CC
		/// Size: 0x04
		/// </summary>
		public float SkyLightrecaptureperiod
		{
			get
			{
				return ReadSingle(0x5CC);
			}
			set
			{
				WriteSingle(0x5CC,value);
			}
		}
		
		/// <summary>
		/// Name: NightFilterCurve
		/// Type: ObjectProperty
		/// Offset: 0x5D0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat NightFilterCurve => ReadUObject<UCurveFloat>(0x5D0);
		
		/// <summary>
		/// Name: Nightbrightness
		/// Type: FloatProperty
		/// Offset: 0x5D8
		/// Size: 0x04
		/// </summary>
		public float Nightbrightness
		{
			get
			{
				return ReadSingle(0x5D8);
			}
			set
			{
				WriteSingle(0x5D8,value);
			}
		}
		
		/// <summary>
		/// Name: AmbCubemaps
		/// Type: TArray<UTextureCube>
		/// Offset: 0x5E0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UTextureCube> AmbCubemaps => new TArray<UTextureCube>(BaseAddress+0x5E0);
		
		/// <summary>
		/// Name: SkylightCubemapBlend
		/// Type: BoolProperty
		/// Offset: 0x5F0
		/// Size: 0x01
		/// </summary>
		public bool SkylightCubemapBlend
		{
			get
			{
				return ReadBool(0x5F0);
			}
			set
			{
				WriteBool(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: LastBaseCubemapIndex
		/// Type: IntProperty
		/// Offset: 0x5F4
		/// Size: 0x04
		/// </summary>
		public int LastBaseCubemapIndex
		{
			get
			{
				return ReadInt32(0x5F4);
			}
			set
			{
				WriteInt32(0x5F4,value);
			}
		}
		
		/// <summary>
		/// Name: FogIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x5F8
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogIntensityCurve => ReadUObject<UCurveFloat>(0x5F8);
		
		/// <summary>
		/// Name: FogstartdistCurve
		/// Type: ObjectProperty
		/// Offset: 0x600
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogstartdistCurve => ReadUObject<UCurveFloat>(0x600);
		
		/// <summary>
		/// Name: Curvesin0to24range
		/// Type: BoolProperty
		/// Offset: 0x608
		/// Size: 0x01
		/// </summary>
		public bool Curvesin0to24range
		{
			get
			{
				return ReadBool(0x608);
			}
			set
			{
				WriteBool(0x608,value);
			}
		}
		
		/// <summary>
		/// Name: Fogcolouroverride
		/// Type: BoolProperty
		/// Offset: 0x609
		/// Size: 0x01
		/// </summary>
		public bool Fogcolouroverride
		{
			get
			{
				return ReadBool(0x609);
			}
			set
			{
				WriteBool(0x609,value);
			}
		}
		
		/// <summary>
		/// Name: Fogcolouroverridecurve
		/// Type: ObjectProperty
		/// Offset: 0x610
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor Fogcolouroverridecurve => ReadUObject<UCurveLinearColor>(0x610);
		
		/// <summary>
		/// Name: AreaSpecificSettings
		/// Type: TArray<FSkyCurveSet>
		/// Offset: 0x618
		/// Size: 0x10
		/// SubElement Size: 0xC9
		/// </summary>
		public TArray<FSkyCurveSet> AreaSpecificSettings => new TArray<FSkyCurveSet>(BaseAddress+0x618);
		
		/// <summary>
		/// Name: relevantAreaIndices
		/// Type: TArray<>
		/// Offset: 0x628
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: relevantAreaCoeffs
		/// Type: TArray<>
		/// Offset: 0x638
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SummedAreaWeights
		/// Type: FloatProperty
		/// Offset: 0x648
		/// Size: 0x04
		/// </summary>
		public float SummedAreaWeights
		{
			get
			{
				return ReadSingle(0x648);
			}
			set
			{
				WriteSingle(0x648,value);
			}
		}
		
		/// <summary>
		/// Name: fogFalloffCurve
		/// Type: ObjectProperty
		/// Offset: 0x650
		/// Size: 0x08
		/// </summary>
		public UCurveFloat fogFalloffCurve => ReadUObject<UCurveFloat>(0x650);
		
		/// <summary>
		/// Name: sunlightInsityCurve
		/// Type: ObjectProperty
		/// Offset: 0x658
		/// Size: 0x08
		/// </summary>
		public UCurveFloat sunlightInsityCurve => ReadUObject<UCurveFloat>(0x658);
		
		/// <summary>
		/// Name: skylightIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x660
		/// Size: 0x08
		/// </summary>
		public UCurveFloat skylightIntensityCurve => ReadUObject<UCurveFloat>(0x660);
		
		/// <summary>
		/// Name: cloudDensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x668
		/// Size: 0x08
		/// </summary>
		public UCurveFloat cloudDensityCurve => ReadUObject<UCurveFloat>(0x668);
		
		/// <summary>
		/// Name: lastFrameApproxLightColour
		/// Type: StructProperty
		/// Offset: 0x670
		/// Size: 0x10
		/// </summary>
		public FLinearColor lastFrameApproxLightColour => ReadStruct<FLinearColor>(0x670);
		
		/// <summary>
		/// Name: FogHeightCurve
		/// Type: ObjectProperty
		/// Offset: 0x680
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogHeightCurve => ReadUObject<UCurveFloat>(0x680);
		
		/// <summary>
		/// Name: FogHeightRelativeToPlayer
		/// Type: BoolProperty
		/// Offset: 0x688
		/// Size: 0x01
		/// </summary>
		public bool FogHeightRelativeToPlayer
		{
			get
			{
				return ReadBool(0x688);
			}
			set
			{
				WriteBool(0x688,value);
			}
		}
		
		/// <summary>
		/// Name: ResolvedFogHeight
		/// Type: FloatProperty
		/// Offset: 0x68C
		/// Size: 0x04
		/// </summary>
		public float ResolvedFogHeight
		{
			get
			{
				return ReadSingle(0x68C);
			}
			set
			{
				WriteSingle(0x68C,value);
			}
		}
		
		/// <summary>
		/// Name: defaultEnvAreaPos
		/// Type: StructProperty
		/// Offset: 0x690
		/// Size: 0x0C
		/// </summary>
		public FVector defaultEnvAreaPos => ReadStruct<FVector>(0x690);
		
	}


	/// <summary>
	/// FSkyCurveSet:
	/// Size: 0xC9
	/// Properties: 26
	/// </summary>
	public class FSkyCurveSet:MemoryObject
	{
		public override int ObjectSize => 201;
		/// <summary>
		/// Name: name_51_01DB10B1486BB2EFEDBD38905F20E0DF
		/// Type: StrProperty
		/// Offset: 0x00
		/// Size: 0x10
		/// </summary>
		public FString name_51_01DB10B1486BB2EFEDBD38905F20E0DF => new FString(BaseAddress+0x00);
		
		/// <summary>
		/// Name: HorizonColourCurve_6_8C19535B4FE2D510B37EBB97FD19736E
		/// Type: ObjectProperty
		/// Offset: 0x10
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor HorizonColourCurve_6_8C19535B4FE2D510B37EBB97FD19736E => ReadUObject<UCurveLinearColor>(0x10);
		
		/// <summary>
		/// Name: ZenithColourCurve_8_04A4734B49C727E69DE2EA849D76155E
		/// Type: ObjectProperty
		/// Offset: 0x18
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor ZenithColourCurve_8_04A4734B49C727E69DE2EA849D76155E => ReadUObject<UCurveLinearColor>(0x18);
		
		/// <summary>
		/// Name: CloudLightColourCurve_10_CA1F39EB4DDDDD35E819EA9F78DACF63
		/// Type: ObjectProperty
		/// Offset: 0x20
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudLightColourCurve_10_CA1F39EB4DDDDD35E819EA9F78DACF63 => ReadUObject<UCurveLinearColor>(0x20);
		
		/// <summary>
		/// Name: CloudDarkColourCurve_12_CCCA062D4E1CF9C4E2EADE8AC80A3E3E
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudDarkColourCurve_12_CCCA062D4E1CF9C4E2EADE8AC80A3E3E => ReadUObject<UCurveLinearColor>(0x28);
		
		/// <summary>
		/// Name: SunColourCurve_14_2AB0FF3144D09B2258E0B4B5B11878C4
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunColourCurve_14_2AB0FF3144D09B2258E0B4B5B11878C4 => ReadUObject<UCurveLinearColor>(0x30);
		
		/// <summary>
		/// Name: ShineIntensityCurve_18_ABFCED494B88475A06536FA853EFBE33
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ShineIntensityCurve_18_ABFCED494B88475A06536FA853EFBE33 => ReadUObject<UCurveFloat>(0x38);
		
		/// <summary>
		/// Name: SunCloudyColourCurve_21_281E61DA453B0DF611416F929E51963C
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunCloudyColourCurve_21_281E61DA453B0DF611416F929E51963C => ReadUObject<UCurveLinearColor>(0x40);
		
		/// <summary>
		/// Name: StarsIntensityCurve_24_A016DEC24B07556DC4266E897200FF78
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UCurveFloat StarsIntensityCurve_24_A016DEC24B07556DC4266E897200FF78 => ReadUObject<UCurveFloat>(0x48);
		
		/// <summary>
		/// Name: MoonPositionCurve_26_CBC57190488D930BDA24BEBF703FE9C1
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UCurveFloat MoonPositionCurve_26_CBC57190488D930BDA24BEBF703FE9C1 => ReadUObject<UCurveFloat>(0x50);
		
		/// <summary>
		/// Name: SunHighlightRadiusCurve_28_B3E4ABCF4053B304C8A029868720AFEF
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UCurveFloat SunHighlightRadiusCurve_28_B3E4ABCF4053B304C8A029868720AFEF => ReadUObject<UCurveFloat>(0x58);
		
		/// <summary>
		/// Name: NightFilterCurve_30_5782CD594B220954B07AE0A4A8EA7B7D
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UCurveFloat NightFilterCurve_30_5782CD594B220954B07AE0A4A8EA7B7D => ReadUObject<UCurveFloat>(0x60);
		
		/// <summary>
		/// Name: FogIntensityCurve_32_DAF14A6940C18EC5F8F1CBADE53598F4
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogIntensityCurve_32_DAF14A6940C18EC5F8F1CBADE53598F4 => ReadUObject<UCurveFloat>(0x68);
		
		/// <summary>
		/// Name: FogStartDistCurve_34_2C829BC446C3BF7F4AF7CA9E4776D38D
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogStartDistCurve_34_2C829BC446C3BF7F4AF7CA9E4776D38D => ReadUObject<UCurveFloat>(0x70);
		
		/// <summary>
		/// Name: FogColourOverrideCurve_37_2E0DEDC644B16FA3F44A58971A4B4E0B
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor FogColourOverrideCurve_37_2E0DEDC644B16FA3F44A58971A4B4E0B => ReadUObject<UCurveLinearColor>(0x78);
		
		/// <summary>
		/// Name: Volume_81_A6F6B54E485424C4E08E6990DB08CF77
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public AVolume Volume_81_A6F6B54E485424C4E08E6990DB08CF77 => ReadUObject<AVolume>(0x80);
		
		/// <summary>
		/// Name: Center_45_A6A7F64745BB9E26226EDD848C4362C6
		/// Type: StructProperty
		/// Offset: 0x88
		/// Size: 0x0C
		/// </summary>
		public FVector Center_45_A6A7F64745BB9E26226EDD848C4362C6 => ReadStruct<FVector>(0x88);
		
		/// <summary>
		/// Name: radius_48_1DB5324545A86F1A83F2E2A9834F61E3
		/// Type: FloatProperty
		/// Offset: 0x94
		/// Size: 0x04
		/// </summary>
		public float radius_48_1DB5324545A86F1A83F2E2A9834F61E3
		{
			get
			{
				return ReadSingle(0x94);
			}
			set
			{
				WriteSingle(0x94,value);
			}
		}
		
		/// <summary>
		/// Name: fadeExponent_54_EA4DFDBD44A35B8E6E41F3BC0C79410B
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float fadeExponent_54_EA4DFDBD44A35B8E6E41F3BC0C79410B
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: Priority_72_54A6583241E9625103077DB750513486
		/// Type: FloatProperty
		/// Offset: 0x9C
		/// Size: 0x04
		/// </summary>
		public float Priority_72_54A6583241E9625103077DB750513486
		{
			get
			{
				return ReadSingle(0x9C);
			}
			set
			{
				WriteSingle(0x9C,value);
			}
		}
		
		/// <summary>
		/// Name: fogFalloff_57_38BD5A7F4F6319DFD68A2EA7DE97D8A2
		/// Type: ObjectProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat fogFalloff_57_38BD5A7F4F6319DFD68A2EA7DE97D8A2 => ReadUObject<UCurveFloat>(0xA0);
		
		/// <summary>
		/// Name: sunlightIntensity_62_C343E4BC4A10E648A5186588C88C7AAF
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public UCurveFloat sunlightIntensity_62_C343E4BC4A10E648A5186588C88C7AAF => ReadUObject<UCurveFloat>(0xA8);
		
		/// <summary>
		/// Name: skylightIntensity_63_6EB0FEF34C2A129937F66B9B9D702C64
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat skylightIntensity_63_6EB0FEF34C2A129937F66B9B9D702C64 => ReadUObject<UCurveFloat>(0xB0);
		
		/// <summary>
		/// Name: cloudDensity_66_BE7BCD784F32236DB6DE71BF74406453
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public UCurveFloat cloudDensity_66_BE7BCD784F32236DB6DE71BF74406453 => ReadUObject<UCurveFloat>(0xB8);
		
		/// <summary>
		/// Name: FogHeightOffset_75_11A015C34C208F05D56BFA85885434B6
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FogHeightOffset_75_11A015C34C208F05D56BFA85885434B6 => ReadUObject<UCurveFloat>(0xC0);
		
		/// <summary>
		/// Name: FogHeightRelativeToPlayer_78_78C84B4A49FDDA25C5BE4FBF4C93F735
		/// Type: BoolProperty
		/// Offset: 0xC8
		/// Size: 0x01
		/// </summary>
		public bool FogHeightRelativeToPlayer_78_78C84B4A49FDDA25C5BE4FBF4C93F735
		{
			get
			{
				return ReadBool(0xC8);
			}
			set
			{
				WriteBool(0xC8,value);
			}
		}
		
	}


	/// <summary>
	/// ASandstorm_Sky_C:ADynamicSkyBase
	/// Size: 0x5FC
	/// Properties: 83
	/// </summary>
	public class ASandstorm_Sky_C:ADynamicSkyBase
	{
		public override int ObjectSize => 1532;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E0);
		
		/// <summary>
		/// Name: Sun_Root
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UArrowComponent Sun_Root => ReadUObject<UArrowComponent>(0x3E8);
		
		/// <summary>
		/// Name: Ultra_Dynamic_Sky_Sphere
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Ultra_Dynamic_Sky_Sphere => ReadUObject<UStaticMeshComponent>(0x3F0);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: DirectionLightSun
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight DirectionLightSun => ReadUObject<ADirectionalLight>(0x400);
		
		/// <summary>
		/// Name: UDM_mat
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic UDM_mat => ReadUObject<UMaterialInstanceDynamic>(0x408);
		
		/// <summary>
		/// Name: RefreshSettings
		/// Type: BoolProperty
		/// Offset: 0x410
		/// Size: 0x01
		/// </summary>
		public bool RefreshSettings
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
		/// Name: CloudSpeed
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float CloudSpeed
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensity
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float CloudDensity
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
		/// Name: CloudWispsOpacity
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float CloudWispsOpacity
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
		/// Name: HorizonBaseColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor HorizonBaseColorCurve => ReadUObject<UCurveLinearColor>(0x420);
		
		/// <summary>
		/// Name: ZenithBaseColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor ZenithBaseColorCurve => ReadUObject<UCurveLinearColor>(0x428);
		
		/// <summary>
		/// Name: CloudLightColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudLightColorCurve => ReadUObject<UCurveLinearColor>(0x430);
		
		/// <summary>
		/// Name: CloudDarkColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor CloudDarkColorCurve => ReadUObject<UCurveLinearColor>(0x438);
		
		/// <summary>
		/// Name: SunColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunColorCurve => ReadUObject<UCurveLinearColor>(0x440);
		
		/// <summary>
		/// Name: ShineIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UCurveFloat ShineIntensityCurve => ReadUObject<UCurveFloat>(0x448);
		
		/// <summary>
		/// Name: Saturation
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float Saturation
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
		/// Name: SunCloudyColorCurve
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UCurveLinearColor SunCloudyColorCurve => ReadUObject<UCurveLinearColor>(0x458);
		
		/// <summary>
		/// Name: ExponentialHeightFog
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public AExponentialHeightFog ExponentialHeightFog => ReadUObject<AExponentialHeightFog>(0x460);
		
		/// <summary>
		/// Name: StarsIntensityCurve
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public UCurveFloat StarsIntensityCurve => ReadUObject<UCurveFloat>(0x468);
		
		/// <summary>
		/// Name: CloudPhase
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float CloudPhase
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
		/// Name: MoonScale
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float MoonScale
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
		/// Name: MoonInclination
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float MoonInclination
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
		/// Name: MoonPhase
		/// Type: FloatProperty
		/// Offset: 0x47C
		/// Size: 0x04
		/// </summary>
		public float MoonPhase
		{
			get
			{
				return ReadSingle(0x47C);
			}
			set
			{
				WriteSingle(0x47C,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetAdvancedSettingsusingTimeofDay
		/// Type: BoolProperty
		/// Offset: 0x480
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetAdvancedSettingsusingTimeofDay
		{
			get
			{
				return ReadBool(0x480);
			}
			set
			{
				WriteBool(0x480,value);
			}
		}
		
		/// <summary>
		/// Name: StarsVisibility
		/// Type: FloatProperty
		/// Offset: 0x484
		/// Size: 0x04
		/// </summary>
		public float StarsVisibility
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
		/// Name: MoonIntensity
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float MoonIntensity
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
		/// Name: MoonPosition
		/// Type: FloatProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public float MoonPosition
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
		/// Name: SunAngle
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float SunAngle
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
		/// Name: HorizonBaseColor
		/// Type: StructProperty
		/// Offset: 0x494
		/// Size: 0x10
		/// </summary>
		public FLinearColor HorizonBaseColor => ReadStruct<FLinearColor>(0x494);
		
		/// <summary>
		/// Name: ZenithBaseColor
		/// Type: StructProperty
		/// Offset: 0x4A4
		/// Size: 0x10
		/// </summary>
		public FLinearColor ZenithBaseColor => ReadStruct<FLinearColor>(0x4A4);
		
		/// <summary>
		/// Name: CloudLightColor
		/// Type: StructProperty
		/// Offset: 0x4B4
		/// Size: 0x10
		/// </summary>
		public FLinearColor CloudLightColor => ReadStruct<FLinearColor>(0x4B4);
		
		/// <summary>
		/// Name: CloudDarkColor
		/// Type: StructProperty
		/// Offset: 0x4C4
		/// Size: 0x10
		/// </summary>
		public FLinearColor CloudDarkColor => ReadStruct<FLinearColor>(0x4C4);
		
		/// <summary>
		/// Name: SunColor
		/// Type: StructProperty
		/// Offset: 0x4D4
		/// Size: 0x10
		/// </summary>
		public FLinearColor SunColor => ReadStruct<FLinearColor>(0x4D4);
		
		/// <summary>
		/// Name: CloudShineIntensity
		/// Type: FloatProperty
		/// Offset: 0x4E4
		/// Size: 0x04
		/// </summary>
		public float CloudShineIntensity
		{
			get
			{
				return ReadSingle(0x4E4);
			}
			set
			{
				WriteSingle(0x4E4,value);
			}
		}
		
		/// <summary>
		/// Name: SunLightColor
		/// Type: StructProperty
		/// Offset: 0x4E8
		/// Size: 0x10
		/// </summary>
		public FLinearColor SunLightColor => ReadStruct<FLinearColor>(0x4E8);
		
		/// <summary>
		/// Name: DayLength
		/// Type: FloatProperty
		/// Offset: 0x4F8
		/// Size: 0x04
		/// </summary>
		public float DayLength
		{
			get
			{
				return ReadSingle(0x4F8);
			}
			set
			{
				WriteSingle(0x4F8,value);
			}
		}
		
		/// <summary>
		/// Name: MoonPositionCurve
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public UCurveFloat MoonPositionCurve => ReadUObject<UCurveFloat>(0x500);
		
		/// <summary>
		/// Name: AnimateDayNightCycle
		/// Type: BoolProperty
		/// Offset: 0x508
		/// Size: 0x01
		/// </summary>
		public bool AnimateDayNightCycle
		{
			get
			{
				return ReadBool(0x508);
			}
			set
			{
				WriteBool(0x508,value);
			}
		}
		
		/// <summary>
		/// Name: SimulateCloudDensityChanges
		/// Type: BoolProperty
		/// Offset: 0x509
		/// Size: 0x01
		/// </summary>
		public bool SimulateCloudDensityChanges
		{
			get
			{
				return ReadBool(0x509);
			}
			set
			{
				WriteBool(0x509,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityShiftFrequencymin
		/// Type: FloatProperty
		/// Offset: 0x50C
		/// Size: 0x04
		/// </summary>
		public float CloudDensityShiftFrequencymin
		{
			get
			{
				return ReadSingle(0x50C);
			}
			set
			{
				WriteSingle(0x50C,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityShiftFrequencymax
		/// Type: FloatProperty
		/// Offset: 0x510
		/// Size: 0x04
		/// </summary>
		public float CloudDensityShiftFrequencymax
		{
			get
			{
				return ReadSingle(0x510);
			}
			set
			{
				WriteSingle(0x510,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensity_target
		/// Type: FloatProperty
		/// Offset: 0x514
		/// Size: 0x04
		/// </summary>
		public float CloudDensity_target
		{
			get
			{
				return ReadSingle(0x514);
			}
			set
			{
				WriteSingle(0x514,value);
			}
		}
		
		/// <summary>
		/// Name: CloudDensityChangeSmoothing
		/// Type: FloatProperty
		/// Offset: 0x518
		/// Size: 0x04
		/// </summary>
		public float CloudDensityChangeSmoothing
		{
			get
			{
				return ReadSingle(0x518);
			}
			set
			{
				WriteSingle(0x518,value);
			}
		}
		
		/// <summary>
		/// Name: CloudOpacity
		/// Type: FloatProperty
		/// Offset: 0x51C
		/// Size: 0x04
		/// </summary>
		public float CloudOpacity
		{
			get
			{
				return ReadSingle(0x51C);
			}
			set
			{
				WriteSingle(0x51C,value);
			}
		}
		
		/// <summary>
		/// Name: OverallIntensity
		/// Type: FloatProperty
		/// Offset: 0x520
		/// Size: 0x04
		/// </summary>
		public float OverallIntensity
		{
			get
			{
				return ReadSingle(0x520);
			}
			set
			{
				WriteSingle(0x520,value);
			}
		}
		
		/// <summary>
		/// Name: SunBrightness
		/// Type: FloatProperty
		/// Offset: 0x524
		/// Size: 0x04
		/// </summary>
		public float SunBrightness
		{
			get
			{
				return ReadSingle(0x524);
			}
			set
			{
				WriteSingle(0x524,value);
			}
		}
		
		/// <summary>
		/// Name: MoonColor
		/// Type: StructProperty
		/// Offset: 0x528
		/// Size: 0x10
		/// </summary>
		public FLinearColor MoonColor => ReadStruct<FLinearColor>(0x528);
		
		/// <summary>
		/// Name: ShineVariation
		/// Type: FloatProperty
		/// Offset: 0x538
		/// Size: 0x04
		/// </summary>
		public float ShineVariation
		{
			get
			{
				return ReadSingle(0x538);
			}
			set
			{
				WriteSingle(0x538,value);
			}
		}
		
		/// <summary>
		/// Name: SunLightingIntensity
		/// Type: FloatProperty
		/// Offset: 0x53C
		/// Size: 0x04
		/// </summary>
		public float SunLightingIntensity
		{
			get
			{
				return ReadSingle(0x53C);
			}
			set
			{
				WriteSingle(0x53C,value);
			}
		}
		
		/// <summary>
		/// Name: SunHighlightRadius_curve
		/// Type: ObjectProperty
		/// Offset: 0x540
		/// Size: 0x08
		/// </summary>
		public UCurveFloat SunHighlightRadius_curve => ReadUObject<UCurveFloat>(0x540);
		
		/// <summary>
		/// Name: SunHighlightRadius
		/// Type: FloatProperty
		/// Offset: 0x548
		/// Size: 0x04
		/// </summary>
		public float SunHighlightRadius
		{
			get
			{
				return ReadSingle(0x548);
			}
			set
			{
				WriteSingle(0x548,value);
			}
		}
		
		/// <summary>
		/// Name: FirstDay
		/// Type: BoolProperty
		/// Offset: 0x54C
		/// Size: 0x01
		/// </summary>
		public bool FirstDay
		{
			get
			{
				return ReadBool(0x54C);
			}
			set
			{
				WriteBool(0x54C,value);
			}
		}
		
		/// <summary>
		/// Name: SimulateMoonPhaseChanges
		/// Type: BoolProperty
		/// Offset: 0x54D
		/// Size: 0x01
		/// </summary>
		public bool SimulateMoonPhaseChanges
		{
			get
			{
				return ReadBool(0x54D);
			}
			set
			{
				WriteBool(0x54D,value);
			}
		}
		
		/// <summary>
		/// Name: Stars_Intensity
		/// Type: FloatProperty
		/// Offset: 0x550
		/// Size: 0x04
		/// </summary>
		public float Stars_Intensity
		{
			get
			{
				return ReadSingle(0x550);
			}
			set
			{
				WriteSingle(0x550,value);
			}
		}
		
		/// <summary>
		/// Name: Stars_Color
		/// Type: StructProperty
		/// Offset: 0x554
		/// Size: 0x10
		/// </summary>
		public FLinearColor Stars_Color => ReadStruct<FLinearColor>(0x554);
		
		/// <summary>
		/// Name: MoonOrbitOffset
		/// Type: FloatProperty
		/// Offset: 0x564
		/// Size: 0x04
		/// </summary>
		public float MoonOrbitOffset
		{
			get
			{
				return ReadSingle(0x564);
			}
			set
			{
				WriteSingle(0x564,value);
			}
		}
		
		/// <summary>
		/// Name: SunRotation
		/// Type: StructProperty
		/// Offset: 0x568
		/// Size: 0x0C
		/// </summary>
		public FRotator SunRotation => ReadStruct<FRotator>(0x568);
		
		/// <summary>
		/// Name: SunRadius
		/// Type: FloatProperty
		/// Offset: 0x574
		/// Size: 0x04
		/// </summary>
		public float SunRadius
		{
			get
			{
				return ReadSingle(0x574);
			}
			set
			{
				WriteSingle(0x574,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsMID
		/// Type: ObjectProperty
		/// Offset: 0x578
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic CloudShadowsMID => ReadUObject<UMaterialInstanceDynamic>(0x578);
		
		/// <summary>
		/// Name: UseCloudShadows
		/// Type: BoolProperty
		/// Offset: 0x580
		/// Size: 0x01
		/// </summary>
		public bool UseCloudShadows
		{
			get
			{
				return ReadBool(0x580);
			}
			set
			{
				WriteBool(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsScale
		/// Type: FloatProperty
		/// Offset: 0x584
		/// Size: 0x04
		/// </summary>
		public float CloudShadowsScale
		{
			get
			{
				return ReadSingle(0x584);
			}
			set
			{
				WriteSingle(0x584,value);
			}
		}
		
		/// <summary>
		/// Name: CloudShadowsIntensity
		/// Type: FloatProperty
		/// Offset: 0x588
		/// Size: 0x04
		/// </summary>
		public float CloudShadowsIntensity
		{
			get
			{
				return ReadSingle(0x588);
			}
			set
			{
				WriteSingle(0x588,value);
			}
		}
		
		/// <summary>
		/// Name: MoonLight
		/// Type: ObjectProperty
		/// Offset: 0x590
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight MoonLight => ReadUObject<ADirectionalLight>(0x590);
		
		/// <summary>
		/// Name: ManuallySelectSunColor
		/// Type: BoolProperty
		/// Offset: 0x598
		/// Size: 0x01
		/// </summary>
		public bool ManuallySelectSunColor
		{
			get
			{
				return ReadBool(0x598);
			}
			set
			{
				WriteBool(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetMoonLightRotation
		/// Type: BoolProperty
		/// Offset: 0x599
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetMoonLightRotation
		{
			get
			{
				return ReadBool(0x599);
			}
			set
			{
				WriteBool(0x599,value);
			}
		}
		
		/// <summary>
		/// Name: AutomaticallySetSunLightRotation
		/// Type: BoolProperty
		/// Offset: 0x59A
		/// Size: 0x01
		/// </summary>
		public bool AutomaticallySetSunLightRotation
		{
			get
			{
				return ReadBool(0x59A);
			}
			set
			{
				WriteBool(0x59A,value);
			}
		}
		
		/// <summary>
		/// Name: MoonlightIntensity
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float MoonlightIntensity
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: StarsSpeed
		/// Type: FloatProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public float StarsSpeed
		{
			get
			{
				return ReadSingle(0x5A0);
			}
			set
			{
				WriteSingle(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: SunInclination
		/// Type: FloatProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public float SunInclination
		{
			get
			{
				return ReadSingle(0x5A4);
			}
			set
			{
				WriteSingle(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: SunYaw
		/// Type: FloatProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public float SunYaw
		{
			get
			{
				return ReadSingle(0x5A8);
			}
			set
			{
				WriteSingle(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: MoonRotation
		/// Type: FloatProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public float MoonRotation
		{
			get
			{
				return ReadSingle(0x5AC);
			}
			set
			{
				WriteSingle(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: CustomMoonTexture
		/// Type: ObjectProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public UTexture2D CustomMoonTexture => ReadUObject<UTexture2D>(0x5B0);
		
		/// <summary>
		/// Name: UseCustomMoonTexture
		/// Type: BoolProperty
		/// Offset: 0x5B8
		/// Size: 0x01
		/// </summary>
		public bool UseCustomMoonTexture
		{
			get
			{
				return ReadBool(0x5B8);
			}
			set
			{
				WriteBool(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: SkyLight
		/// Type: ObjectProperty
		/// Offset: 0x5C0
		/// Size: 0x08
		/// </summary>
		public ASkyLight SkyLight => ReadUObject<ASkyLight>(0x5C0);
		
		/// <summary>
		/// Name: RecaptureSkylightperiodically
		/// Type: BoolProperty
		/// Offset: 0x5C8
		/// Size: 0x01
		/// </summary>
		public bool RecaptureSkylightperiodically
		{
			get
			{
				return ReadBool(0x5C8);
			}
			set
			{
				WriteBool(0x5C8,value);
			}
		}
		
		/// <summary>
		/// Name: SkyLightrecaptureperiod
		/// Type: FloatProperty
		/// Offset: 0x5CC
		/// Size: 0x04
		/// </summary>
		public float SkyLightrecaptureperiod
		{
			get
			{
				return ReadSingle(0x5CC);
			}
			set
			{
				WriteSingle(0x5CC,value);
			}
		}
		
		/// <summary>
		/// Name: NightFilterCurve
		/// Type: ObjectProperty
		/// Offset: 0x5D0
		/// Size: 0x08
		/// </summary>
		public UCurveFloat NightFilterCurve => ReadUObject<UCurveFloat>(0x5D0);
		
		/// <summary>
		/// Name: Nightbrightness
		/// Type: FloatProperty
		/// Offset: 0x5D8
		/// Size: 0x04
		/// </summary>
		public float Nightbrightness
		{
			get
			{
				return ReadSingle(0x5D8);
			}
			set
			{
				WriteSingle(0x5D8,value);
			}
		}
		
		/// <summary>
		/// Name: AmbCubemaps
		/// Type: TArray<UTextureCube>
		/// Offset: 0x5E0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UTextureCube> AmbCubemaps => new TArray<UTextureCube>(BaseAddress+0x5E0);
		
		/// <summary>
		/// Name: SkylightCubemapBlend
		/// Type: BoolProperty
		/// Offset: 0x5F0
		/// Size: 0x01
		/// </summary>
		public bool SkylightCubemapBlend
		{
			get
			{
				return ReadBool(0x5F0);
			}
			set
			{
				WriteBool(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: LastBaseCubemapIndex
		/// Type: IntProperty
		/// Offset: 0x5F4
		/// Size: 0x04
		/// </summary>
		public int LastBaseCubemapIndex
		{
			get
			{
				return ReadInt32(0x5F4);
			}
			set
			{
				WriteInt32(0x5F4,value);
			}
		}
		
		/// <summary>
		/// Name: opacityFactor
		/// Type: FloatProperty
		/// Offset: 0x5F8
		/// Size: 0x04
		/// </summary>
		public float opacityFactor
		{
			get
			{
				return ReadSingle(0x5F8);
			}
			set
			{
				WriteSingle(0x5F8,value);
			}
		}
		
	}


}

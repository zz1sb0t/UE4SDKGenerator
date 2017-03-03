using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;
using ConanExilesGame.Game.Environment.Sandstorm;
using ConanExilesGame.Game.Marketplace.UltraDynamicSky.Blueprints;


namespace ConanExilesGame.Game.Environment.Sandstorm
{
	/// <summary>
	/// ABP_Sandstorm_SplineActor_C:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ABP_Sandstorm_SplineActor_C:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: Spline
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public USplineComponent Spline => ReadUObject<USplineComponent>(0x3D0);
		
	}


	/// <summary>
	/// UBP_SandstormInterface_C:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBP_SandstormInterface_C:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBP_AC_SandstormController_C:UActorComponent
	/// Size: 0x100
	/// Properties: 3
	/// </summary>
	public class UBP_AC_SandstormController_C:UActorComponent
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: Sandstorm
		/// Type: TArray<>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: IsActiveSandstorm
		/// Type: TArray<>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// ABP_SandStorm_C:AActor
	/// Size: 0x500
	/// Properties: 32
	/// </summary>
	public class ABP_SandStorm_C:AActor
	{
		public override int ObjectSize => 1280;
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
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio => ReadUObject<UConanAudioComponent>(0x3E0);
		
		/// <summary>
		/// Name: ParticleSystemDustAndDebris
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystemDustAndDebris => ReadUObject<UParticleSystemComponent>(0x3E8);
		
		/// <summary>
		/// Name: DustAndDebrisHolder
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent DustAndDebrisHolder => ReadUObject<UStaticMeshComponent>(0x3F0);
		
		/// <summary>
		/// Name: SandstormMesh
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SandstormMesh => ReadUObject<UStaticMeshComponent>(0x3F8);
		
		/// <summary>
		/// Name: ParticleSystemLightning
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystemLightning => ReadUObject<UParticleSystemComponent>(0x400);
		
		/// <summary>
		/// Name: Spline
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public USplineComponent Spline => ReadUObject<USplineComponent>(0x408);
		
		/// <summary>
		/// Name: Arrow
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UArrowComponent Arrow => ReadUObject<UArrowComponent>(0x410);
		
		/// <summary>
		/// Name: ParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystem => ReadUObject<UParticleSystemComponent>(0x418);
		
		/// <summary>
		/// Name: LastFramePos
		/// Type: StructProperty
		/// Offset: 0x420
		/// Size: 0x0C
		/// </summary>
		public FVector LastFramePos => ReadStruct<FVector>(0x420);
		
		/// <summary>
		/// Name: DefaultPositon
		/// Type: StructProperty
		/// Offset: 0x42C
		/// Size: 0x0C
		/// </summary>
		public FVector DefaultPositon => ReadStruct<FVector>(0x42C);
		
		/// <summary>
		/// Name: VelocityScaleForParticle
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float VelocityScaleForParticle
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
		/// Name: SandstormEdgeOffset
		/// Type: FloatProperty
		/// Offset: 0x43C
		/// Size: 0x04
		/// </summary>
		public float SandstormEdgeOffset
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
		/// Name: SplineToUse
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public USplineComponent SplineToUse => ReadUObject<USplineComponent>(0x440);
		
		/// <summary>
		/// Name: SplineActorsToUse
		/// Type: TArray<ABP_Sandstorm_SplineActor_C>
		/// Offset: 0x448
		/// Size: 0x10
		/// SubElement Size: 0x3D8
		/// </summary>
		public TArray<ABP_Sandstorm_SplineActor_C> SplineActorsToUse => new TArray<ABP_Sandstorm_SplineActor_C>(BaseAddress+0x448);
		
		/// <summary>
		/// Name: AffectWind
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public AWindDirectionalSource AffectWind => ReadUObject<AWindDirectionalSource>(0x458);
		
		/// <summary>
		/// Name: WindExp
		/// Type: FloatProperty
		/// Offset: 0x460
		/// Size: 0x04
		/// </summary>
		public float WindExp
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
		/// Name: MaxWindStrength
		/// Type: FloatProperty
		/// Offset: 0x464
		/// Size: 0x04
		/// </summary>
		public float MaxWindStrength
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
		/// Name: MaxWindSpeed
		/// Type: FloatProperty
		/// Offset: 0x468
		/// Size: 0x04
		/// </summary>
		public float MaxWindSpeed
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
		/// Name: CurrentWindStrength
		/// Type: FloatProperty
		/// Offset: 0x46C
		/// Size: 0x04
		/// </summary>
		public float CurrentWindStrength
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
		/// Name: CurrentWindSpeed
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float CurrentWindSpeed
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
		/// Name: Winds
		/// Type: TArray<AWindDirectionalSource>
		/// Offset: 0x478
		/// Size: 0x10
		/// SubElement Size: 0x3D8
		/// </summary>
		public TArray<AWindDirectionalSource> Winds => new TArray<AWindDirectionalSource>(BaseAddress+0x478);
		
		/// <summary>
		/// Name: SandstormBuff
		/// Type: ClassProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayersAffectedBySandstorm
		/// Type: TArray<AActor>
		/// Offset: 0x490
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> PlayersAffectedBySandstorm => new TArray<AActor>(BaseAddress+0x490);
		
		/// <summary>
		/// Name: NavData
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public ANavigationData NavData => ReadUObject<ANavigationData>(0x4A0);
		
		/// <summary>
		/// Name: Wind_Direction
		/// Type: StructProperty
		/// Offset: 0x4A8
		/// Size: 0x0C
		/// </summary>
		public FRotator Wind_Direction => ReadStruct<FRotator>(0x4A8);
		
		/// <summary>
		/// Name: DistanceTravelled
		/// Type: FloatProperty
		/// Offset: 0x4B4
		/// Size: 0x04
		/// </summary>
		public float DistanceTravelled
		{
			get
			{
				return ReadSingle(0x4B4);
			}
			set
			{
				WriteSingle(0x4B4,value);
			}
		}
		
		/// <summary>
		/// Name: Velocity
		/// Type: FloatProperty
		/// Offset: 0x4B8
		/// Size: 0x04
		/// </summary>
		public float Velocity
		{
			get
			{
				return ReadSingle(0x4B8);
			}
			set
			{
				WriteSingle(0x4B8,value);
			}
		}
		
		/// <summary>
		/// Name: SandstormSize
		/// Type: FloatProperty
		/// Offset: 0x4BC
		/// Size: 0x04
		/// </summary>
		public float SandstormSize
		{
			get
			{
				return ReadSingle(0x4BC);
			}
			set
			{
				WriteSingle(0x4BC,value);
			}
		}
		
		/// <summary>
		/// Name: BreatherMaskIsActive
		/// Type: BoolProperty
		/// Offset: 0x4C0
		/// Size: 0x01
		/// </summary>
		public bool BreatherMaskIsActive
		{
			get
			{
				return ReadBool(0x4C0);
			}
			set
			{
				WriteBool(0x4C0,value);
			}
		}
		
		/// <summary>
		/// Name: NewVar
		/// Type: StructProperty
		/// Offset: 0x4D0
		/// Size: 0x30
		/// </summary>
		public FTransform NewVar => ReadStruct<FTransform>(0x4D0);
		
	}


	/// <summary>
	/// UBP_AC_AffectedBySandstorm_C:UActorComponent
	/// Size: 0x100
	/// Properties: 6
	/// </summary>
	public class UBP_AC_AffectedBySandstorm_C:UActorComponent
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0xD8);
		
		/// <summary>
		/// Name: Sandstorms
		/// Type: TArray<>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SandstormSize
		/// Type: FloatProperty
		/// Offset: 0xF0
		/// Size: 0x04
		/// </summary>
		public float SandstormSize
		{
			get
			{
				return ReadSingle(0xF0);
			}
			set
			{
				WriteSingle(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: InsideSandstorm
		/// Type: BoolProperty
		/// Offset: 0xF4
		/// Size: 0x01
		/// </summary>
		public bool InsideSandstorm
		{
			get
			{
				return ReadBool(0xF4);
			}
			set
			{
				WriteBool(0xF4,value);
			}
		}
		
		/// <summary>
		/// Name: SandStormActive
		/// Type: BoolProperty
		/// Offset: 0xF5
		/// Size: 0x01
		/// </summary>
		public bool SandStormActive
		{
			get
			{
				return ReadBool(0xF5);
			}
			set
			{
				WriteBool(0xF5,value);
			}
		}
		
		/// <summary>
		/// Name: TimerHandle
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public FTimerHandle TimerHandle => ReadStruct<FTimerHandle>(0xF8);
		
	}


	/// <summary>
	/// ABP_Sandstorm_Sky_Fade_C:ADynamicSkyBase
	/// Size: 0x620
	/// Properties: 49
	/// </summary>
	public class ABP_Sandstorm_Sky_Fade_C:ADynamicSkyBase
	{
		public override int ObjectSize => 1568;
		/// <summary>
		/// Name: UberGraphFrame
		/// Type: StructProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public FPointerToUberGraphFrame UberGraphFrame => ReadStruct<FPointerToUberGraphFrame>(0x3E0);
		
		/// <summary>
		/// Name: SunLight_Active
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UDirectionalLightComponent SunLight_Active => ReadUObject<UDirectionalLightComponent>(0x3E8);
		
		/// <summary>
		/// Name: ExponentialHeightFog_Active
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UExponentialHeightFogComponent ExponentialHeightFog_Active => ReadUObject<UExponentialHeightFogComponent>(0x3F0);
		
		/// <summary>
		/// Name: SkyLight_Active
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USkyLightComponent SkyLight_Active => ReadUObject<USkyLightComponent>(0x3F8);
		
		/// <summary>
		/// Name: DefaultSceneRoot
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public USceneComponent DefaultSceneRoot => ReadUObject<USceneComponent>(0x400);
		
		/// <summary>
		/// Name: FadeValueOverride
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float FadeValueOverride
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
		/// Name: LerpByDistance
		/// Type: BoolProperty
		/// Offset: 0x40C
		/// Size: 0x01
		/// </summary>
		public bool LerpByDistance
		{
			get
			{
				return ReadBool(0x40C);
			}
			set
			{
				WriteBool(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: SunLight_Normal
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight SunLight_Normal => ReadUObject<ADirectionalLight>(0x410);
		
		/// <summary>
		/// Name: SunLight_Sandstorm
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public ADirectionalLight SunLight_Sandstorm => ReadUObject<ADirectionalLight>(0x418);
		
		/// <summary>
		/// Name: SkyLight_Normal
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public ASkyLight SkyLight_Normal => ReadUObject<ASkyLight>(0x420);
		
		/// <summary>
		/// Name: SkyLight_Sandstorm
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public ASkyLight SkyLight_Sandstorm => ReadUObject<ASkyLight>(0x428);
		
		/// <summary>
		/// Name: HeightFog_Normal
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public AExponentialHeightFog HeightFog_Normal => ReadUObject<AExponentialHeightFog>(0x430);
		
		/// <summary>
		/// Name: HeightFog_Sandstorm
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public AExponentialHeightFog HeightFog_Sandstorm => ReadUObject<AExponentialHeightFog>(0x438);
		
		/// <summary>
		/// Name: Sandstorm_Movie
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UMediaPlayer Sandstorm_Movie => ReadUObject<UMediaPlayer>(0x440);
		
		/// <summary>
		/// Name: Sandstorm_Wall_Mesh
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent Sandstorm_Wall_Mesh => ReadUObject<UStaticMeshComponent>(0x448);
		
		/// <summary>
		/// Name: Sandstorm_Wall_Mesh_AlphaMaterial
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface Sandstorm_Wall_Mesh_AlphaMaterial => ReadUObject<UMaterialInterface>(0x450);
		
		/// <summary>
		/// Name: Sandstorm_ParticleEmitter
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent Sandstorm_ParticleEmitter => ReadUObject<UParticleSystemComponent>(0x458);
		
		/// <summary>
		/// Name: DynamicSky_Normal
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public AUltra_Dynamic_Sky_BP_C DynamicSky_Normal => ReadUObject<AUltra_Dynamic_Sky_BP_C>(0x460);
		
		/// <summary>
		/// Name: DynamicSky_Sandstorm
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public ASandstorm_Sky_C DynamicSky_Sandstorm => ReadUObject<ASandstorm_Sky_C>(0x468);
		
		/// <summary>
		/// Name: SkyCubemap_Normal
		/// Type: TArray<UTextureCube>
		/// Offset: 0x470
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UTextureCube> SkyCubemap_Normal => new TArray<UTextureCube>(BaseAddress+0x470);
		
		/// <summary>
		/// Name: SkyCubemap_Sandstorm
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UTextureCube SkyCubemap_Sandstorm => ReadUObject<UTextureCube>(0x480);
		
		/// <summary>
		/// Name: SkyCubemapFade
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float SkyCubemapFade
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
		/// Name: SkyCubemapFadeTimeOfDay
		/// Type: FloatProperty
		/// Offset: 0x48C
		/// Size: 0x04
		/// </summary>
		public float SkyCubemapFadeTimeOfDay
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
		/// Name: SkyCubemapFadeSpeed
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float SkyCubemapFadeSpeed
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
		/// Name: SkyCubemapFadeFrom
		/// Type: IntProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public int SkyCubemapFadeFrom
		{
			get
			{
				return ReadInt32(0x494);
			}
			set
			{
				WriteInt32(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: SkyCubemapFadeTo
		/// Type: IntProperty
		/// Offset: 0x498
		/// Size: 0x04
		/// </summary>
		public int SkyCubemapFadeTo
		{
			get
			{
				return ReadInt32(0x498);
			}
			set
			{
				WriteInt32(0x498,value);
			}
		}
		
		/// <summary>
		/// Name: SunLight_Material
		/// Type: ObjectProperty
		/// Offset: 0x4A0
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic SunLight_Material => ReadUObject<UMaterialInstanceDynamic>(0x4A0);
		
		/// <summary>
		/// Name: SandstormOriginalMaterial
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface SandstormOriginalMaterial => ReadUObject<UMaterialInterface>(0x4A8);
		
		/// <summary>
		/// Name: SandstormDynamicMaterial
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic SandstormDynamicMaterial => ReadUObject<UMaterialInstanceDynamic>(0x4B0);
		
		/// <summary>
		/// Name: SandstormDynamicMaterialTop
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic SandstormDynamicMaterialTop => ReadUObject<UMaterialInstanceDynamic>(0x4B8);
		
		/// <summary>
		/// Name: SandStormActor
		/// Type: ObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public ABP_SandStorm_C SandStormActor => ReadUObject<ABP_SandStorm_C>(0x4C0);
		
		/// <summary>
		/// Name: FadeParameters
		/// Type: TArray<FFadeParams>
		/// Offset: 0x4C8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FFadeParams> FadeParameters => new TArray<FFadeParams>(BaseAddress+0x4C8);
		
		/// <summary>
		/// Name: SunlightFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4D8
		/// Size: 0x04
		/// </summary>
		public int SunlightFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4D8);
			}
			set
			{
				WriteInt32(0x4D8,value);
			}
		}
		
		/// <summary>
		/// Name: SkylightFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4DC
		/// Size: 0x04
		/// </summary>
		public int SkylightFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4DC);
			}
			set
			{
				WriteInt32(0x4DC,value);
			}
		}
		
		/// <summary>
		/// Name: HeightFogFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4E0
		/// Size: 0x04
		/// </summary>
		public int HeightFogFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4E0);
			}
			set
			{
				WriteInt32(0x4E0,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4E4
		/// Size: 0x04
		/// </summary>
		public int PostProcessFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4E4);
			}
			set
			{
				WriteInt32(0x4E4,value);
			}
		}
		
		/// <summary>
		/// Name: DynamicSkyFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4E8
		/// Size: 0x04
		/// </summary>
		public int DynamicSkyFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4E8);
			}
			set
			{
				WriteInt32(0x4E8,value);
			}
		}
		
		/// <summary>
		/// Name: SandStormWallFadeParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4EC
		/// Size: 0x04
		/// </summary>
		public int SandStormWallFadeParametersIndex
		{
			get
			{
				return ReadInt32(0x4EC);
			}
			set
			{
				WriteInt32(0x4EC,value);
			}
		}
		
		/// <summary>
		/// Name: HeightFogColourParametersIndex
		/// Type: IntProperty
		/// Offset: 0x4F0
		/// Size: 0x04
		/// </summary>
		public int HeightFogColourParametersIndex
		{
			get
			{
				return ReadInt32(0x4F0);
			}
			set
			{
				WriteInt32(0x4F0,value);
			}
		}
		
		/// <summary>
		/// Name: FadeValues
		/// Type: TArray<>
		/// Offset: 0x4F8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: AreaSpecificSettingsIndex
		/// Type: IntProperty
		/// Offset: 0x508
		/// Size: 0x04
		/// </summary>
		public int AreaSpecificSettingsIndex
		{
			get
			{
				return ReadInt32(0x508);
			}
			set
			{
				WriteInt32(0x508,value);
			}
		}
		
		/// <summary>
		/// Name: SkyCurveSet
		/// Type: StructProperty
		/// Offset: 0x510
		/// Size: 0xD0
		/// </summary>
		public FSkyCurveSet SkyCurveSet => ReadStruct<FSkyCurveSet>(0x510);
		
		/// <summary>
		/// Name: Sandstorm_ParticleEmitter_DustAndDebris
		/// Type: ObjectProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent Sandstorm_ParticleEmitter_DustAndDebris => ReadUObject<UParticleSystemComponent>(0x5E0);
		
		/// <summary>
		/// Name: PlayerLocation
		/// Type: StructProperty
		/// Offset: 0x5E8
		/// Size: 0x0C
		/// </summary>
		public FVector PlayerLocation => ReadStruct<FVector>(0x5E8);
		
		/// <summary>
		/// Name: InsideParticleFadeParams
		/// Type: TArray<FParticleFadeIndex>
		/// Offset: 0x5F8
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FParticleFadeIndex> InsideParticleFadeParams => new TArray<FParticleFadeIndex>(BaseAddress+0x5F8);
		
		/// <summary>
		/// Name: StopTicking
		/// Type: BoolProperty
		/// Offset: 0x608
		/// Size: 0x01
		/// </summary>
		public bool StopTicking
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
		/// Name: FogHeight
		/// Type: FloatProperty
		/// Offset: 0x60C
		/// Size: 0x04
		/// </summary>
		public float FogHeight
		{
			get
			{
				return ReadSingle(0x60C);
			}
			set
			{
				WriteSingle(0x60C,value);
			}
		}
		
		/// <summary>
		/// Name: Sandstorm_ParticleEmitter_Lightning
		/// Type: ObjectProperty
		/// Offset: 0x610
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent Sandstorm_ParticleEmitter_Lightning => ReadUObject<UParticleSystemComponent>(0x610);
		
		/// <summary>
		/// Name: DustAndDebrisHolder
		/// Type: ObjectProperty
		/// Offset: 0x618
		/// Size: 0x08
		/// </summary>
		public USceneComponent DustAndDebrisHolder => ReadUObject<USceneComponent>(0x618);
		
	}


	/// <summary>
	/// FFadeParams:
	/// Size: 0x10
	/// Properties: 3
	/// </summary>
	public class FFadeParams:MemoryObject
	{
		public override int ObjectSize => 16;
		/// <summary>
		/// Name: FadeStart_2_5F11C41F46FB9D51C35AE3AB39709C6B
		/// Type: FloatProperty
		/// Offset: 0x00
		/// Size: 0x04
		/// </summary>
		public float FadeStart_2_5F11C41F46FB9D51C35AE3AB39709C6B
		{
			get
			{
				return ReadSingle(0x00);
			}
			set
			{
				WriteSingle(0x00,value);
			}
		}
		
		/// <summary>
		/// Name: FadeEnd_5_B4E1C2EB43A82A1D6C20938EB920EC98
		/// Type: FloatProperty
		/// Offset: 0x04
		/// Size: 0x04
		/// </summary>
		public float FadeEnd_5_B4E1C2EB43A82A1D6C20938EB920EC98
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
		/// Name: FadeCurve_8_33AC7BC74A0D973CEB282D90171B458E
		/// Type: ObjectProperty
		/// Offset: 0x08
		/// Size: 0x08
		/// </summary>
		public UCurveFloat FadeCurve_8_33AC7BC74A0D973CEB282D90171B458E => ReadUObject<UCurveFloat>(0x08);
		
	}


	/// <summary>
	/// FParticleFadeIndex:
	/// Size: 0x0C
	/// Properties: 2
	/// </summary>
	public class FParticleFadeIndex:MemoryObject
	{
		public override int ObjectSize => 12;
		/// <summary>
		/// Name: ParameterName_2_5B61F98D40F8EBF7590AE2A68682D8B9
		/// Type: NameProperty
		/// Offset: 0x00
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: FadeIndex_5_73D59DE94EE2AD14CF5B838C4212E5D6
		/// Type: IntProperty
		/// Offset: 0x08
		/// Size: 0x04
		/// </summary>
		public int FadeIndex_5_73D59DE94EE2AD14CF5B838C4212E5D6
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
		
	}


}

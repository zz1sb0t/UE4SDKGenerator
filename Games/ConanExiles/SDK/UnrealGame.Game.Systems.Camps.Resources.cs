using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Systems.Camps;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Systems.Camps.Resources
{
	/// <summary>
	/// ABP_CA_WindChime_01a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x410
	/// Properties: 3
	/// </summary>
	public class ABP_CA_WindChime_01a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: SM_Wind_Chime_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_Wind_Chime_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: sfx_wind_chimes_chinese_bamboo_Cue
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent sfx_wind_chimes_chinese_bamboo_Cue => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_Wind_Chime
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_Wind_Chime => ReadUObject<UStaticMeshComponent>(0x408);
		
	}


	/// <summary>
	/// ABP_CA_Tree_Skulls_1a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Tree_Skulls_1a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_Tree_Skulls_1a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Tree_Skulls_1a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_Tree_Skulls_1a
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Tree_Skulls_1a => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Campfire_1b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x428
	/// Properties: 6
	/// </summary>
	public class ABP_CA_Campfire_1b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: fireplace_1_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent fireplace_1_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: ConanAudio
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ConanAudio => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: PointLight1
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight1 => ReadUObject<UPointLightComponent>(0x408);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x410);
		
		/// <summary>
		/// Name: P_Campfire
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent P_Campfire => ReadUObject<UParticleSystemComponent>(0x418);
		
		/// <summary>
		/// Name: fireplace
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent fireplace => ReadUObject<UStaticMeshComponent>(0x420);
		
	}


	/// <summary>
	/// ABP_CA_Torch_Skull_01a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x428
	/// Properties: 6
	/// </summary>
	public class ABP_CA_Torch_Skull_01a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: SM_CA_Torch_Skull_01a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Torch_Skull_01a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_CA_Torch_Skull_01a
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Torch_Skull_01a => ReadUObject<UStaticMeshComponent>(0x408);
		
		/// <summary>
		/// Name: PointLight1
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight1 => ReadUObject<UPointLightComponent>(0x410);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x418);
		
		/// <summary>
		/// Name: P_TorchFire1
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent P_TorchFire1 => ReadUObject<UParticleSystemComponent>(0x420);
		
	}


	/// <summary>
	/// ABP_CA_Tent_Small_1c_C:ABP_MasterCampPlaceable_C
	/// Size: 0x410
	/// Properties: 3
	/// </summary>
	public class ABP_CA_Tent_Small_1c_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: SM_CA_Tent_Small_1c_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Tent_Small_1c_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: ConanAudio
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ConanAudio => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_tent_small
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_tent_small => ReadUObject<UStaticMeshComponent>(0x408);
		
	}


	/// <summary>
	/// ABP_CA_Tent_Small_1b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x410
	/// Properties: 3
	/// </summary>
	public class ABP_CA_Tent_Small_1b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: SM_CA_Tent_Small_1b_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Tent_Small_1b_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: ConanAudio
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent ConanAudio => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_CA_Tent_Small_1b
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Tent_Small_1b => ReadUObject<UStaticMeshComponent>(0x408);
		
	}


	/// <summary>
	/// ABP_CA_Tent_Small_1a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x410
	/// Properties: 3
	/// </summary>
	public class ABP_CA_Tent_Small_1a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: SM_CA_Tent_Small_1a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Tent_Small_1a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_CA_Tent_Small_1a
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Tent_Small_1a => ReadUObject<UStaticMeshComponent>(0x408);
		
	}


	/// <summary>
	/// ABP_CA_SkullSpikes_1d_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_SkullSpikes_1d_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1d_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_SkullSpikes_1d_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1d
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_SkullSpikes_1d => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_SkullSpikes_1c_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_SkullSpikes_1c_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1c_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_SkullSpikes_1c_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1c
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_SkullSpikes_1c => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_SkullSpikes_1b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_SkullSpikes_1b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1b_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_SkullSpikes_1b_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1b
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_SkullSpikes_1b => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_SkullSpikes_1a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_SkullSpikes_1a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_SkullSpikes_1a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_SkullSpikes_1a
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_SkullSpikes_1a => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_FenceStakes_01b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_FenceStakes_01b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_FenceStakes_01b_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_FenceStakes_01b_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: StaticMesh30
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh30 => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_FenceStakes_01a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_FenceStakes_01a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_FenceStakes_01a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_FenceStakes_01a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: StaticMesh30
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh30 => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Campfire_1a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x428
	/// Properties: 6
	/// </summary>
	public class ABP_CA_Campfire_1a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: SM_CA_Campfire_1a_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Campfire_1a_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: Audio_Fire
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio_Fire => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_CA_Campfire_1a
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Campfire_1a => ReadUObject<UStaticMeshComponent>(0x408);
		
		/// <summary>
		/// Name: PointLight1
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight1 => ReadUObject<UPointLightComponent>(0x410);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x418);
		
		/// <summary>
		/// Name: P_Campfire
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent P_Campfire => ReadUObject<UParticleSystemComponent>(0x420);
		
	}


	/// <summary>
	/// ABP_CA_Bench_Log_01a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Bench_Log_01a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_LogBench2_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_LogBench2_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_LogBench
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_LogBench => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Bedrolls_1e_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Bedrolls_1e_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_bedroll_messy_1_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_bedroll_messy_1_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Bedrolls_1d_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Bedrolls_1d_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_bedroll_clean_1_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_bedroll_clean_1_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMesh => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Bedrolls_1c_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Bedrolls_1c_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_Bedrolls_1c_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Bedrolls_1c_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_Bedrolls_1c
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Bedrolls_1c => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Bedrolls_1b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x408
	/// Properties: 2
	/// </summary>
	public class ABP_CA_Bedrolls_1b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: SM_CA_Bedrolls_1b_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Bedrolls_1b_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: SM_CA_Bedrolls_1b
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Bedrolls_1b => ReadUObject<UStaticMeshComponent>(0x400);
		
	}


	/// <summary>
	/// ABP_CA_Altar_Yog_t2_C:ABP_MasterCampPlaceable_C
	/// Size: 0x428
	/// Properties: 6
	/// </summary>
	public class ABP_CA_Altar_Yog_t2_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: SM_CA_Altar_Yog_t2_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Altar_Yog_t2_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: sfx_wind_chimes_bamboo_bone_magic_Cue
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent sfx_wind_chimes_bamboo_bone_magic_Cue => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: sfx_fire_altar_1_Cue
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent sfx_fire_altar_1_Cue => ReadUObject<UConanAudioComponent>(0x408);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x410);
		
		/// <summary>
		/// Name: ParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystem => ReadUObject<UParticleSystemComponent>(0x418);
		
		/// <summary>
		/// Name: SM_CA_Altar_Yog_t2
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Altar_Yog_t2 => ReadUObject<UStaticMeshComponent>(0x420);
		
	}


	/// <summary>
	/// ABP_CA_Altar_Yog_t1b_C:ABP_MasterCampPlaceable_C
	/// Size: 0x420
	/// Properties: 5
	/// </summary>
	public class ABP_CA_Altar_Yog_t1b_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: SM_CA_Altar_Yog_t1b_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_CA_Altar_Yog_t1b_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: sfx_fire_altar_1_Cue
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent sfx_fire_altar_1_Cue => ReadUObject<UConanAudioComponent>(0x400);
		
		/// <summary>
		/// Name: SM_CA_Altar_Yog_t1b
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_CA_Altar_Yog_t1b => ReadUObject<UStaticMeshComponent>(0x408);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x410);
		
		/// <summary>
		/// Name: ParticleSystem
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystem => ReadUObject<UParticleSystemComponent>(0x418);
		
	}


	/// <summary>
	/// ABP_CA_Bonfire_1a_C:ABP_MasterCampPlaceable_C
	/// Size: 0x430
	/// Properties: 7
	/// </summary>
	public class ABP_CA_Bonfire_1a_C:ABP_MasterCampPlaceable_C
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: SM_Bonfire_DM
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent SM_Bonfire_DM => ReadUObject<UDestructibleComponent>(0x3F8);
		
		/// <summary>
		/// Name: PointLight1
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight1 => ReadUObject<UPointLightComponent>(0x400);
		
		/// <summary>
		/// Name: PointLight
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLight => ReadUObject<UPointLightComponent>(0x408);
		
		/// <summary>
		/// Name: ParticleSystemFire
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystemFire => ReadUObject<UParticleSystemComponent>(0x410);
		
		/// <summary>
		/// Name: ParticleSystemSmoke
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystemSmoke => ReadUObject<UParticleSystemComponent>(0x418);
		
		/// <summary>
		/// Name: Audio
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent Audio => ReadUObject<UConanAudioComponent>(0x420);
		
		/// <summary>
		/// Name: SM_Bonfire
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent SM_Bonfire => ReadUObject<UStaticMeshComponent>(0x428);
		
	}


}

using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Game.Characters;
using ConanExilesGame.Script;


namespace ConanExilesGame.Game.Characters.NPCs.Set_snake.blueprints
{
	/// <summary>
	/// ABP_set_snake_C:ABaseBPWildlife_C
	/// Size: 0x11E0
	/// Properties: 26
	/// </summary>
	public class ABP_set_snake_C:ABaseBPWildlife_C
	{
		public override int ObjectSize => 4576;
		/// <summary>
		/// Name: snake_head
		/// Type: ObjectProperty
		/// Offset: 0x1110
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake_head => ReadUObject<UCapsuleComponent>(0x1110);
		
		/// <summary>
		/// Name: snake
		/// Type: ObjectProperty
		/// Offset: 0x1118
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake => ReadUObject<UCapsuleComponent>(0x1118);
		
		/// <summary>
		/// Name: snake1
		/// Type: ObjectProperty
		/// Offset: 0x1120
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake1 => ReadUObject<UCapsuleComponent>(0x1120);
		
		/// <summary>
		/// Name: snake2
		/// Type: ObjectProperty
		/// Offset: 0x1128
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake2 => ReadUObject<UCapsuleComponent>(0x1128);
		
		/// <summary>
		/// Name: snake3
		/// Type: ObjectProperty
		/// Offset: 0x1130
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake3 => ReadUObject<UCapsuleComponent>(0x1130);
		
		/// <summary>
		/// Name: snake4
		/// Type: ObjectProperty
		/// Offset: 0x1138
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake4 => ReadUObject<UCapsuleComponent>(0x1138);
		
		/// <summary>
		/// Name: snake5
		/// Type: ObjectProperty
		/// Offset: 0x1140
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake5 => ReadUObject<UCapsuleComponent>(0x1140);
		
		/// <summary>
		/// Name: snake6
		/// Type: ObjectProperty
		/// Offset: 0x1148
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake6 => ReadUObject<UCapsuleComponent>(0x1148);
		
		/// <summary>
		/// Name: snake7
		/// Type: ObjectProperty
		/// Offset: 0x1150
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake7 => ReadUObject<UCapsuleComponent>(0x1150);
		
		/// <summary>
		/// Name: snake8
		/// Type: ObjectProperty
		/// Offset: 0x1158
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake8 => ReadUObject<UCapsuleComponent>(0x1158);
		
		/// <summary>
		/// Name: snake9
		/// Type: ObjectProperty
		/// Offset: 0x1160
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake9 => ReadUObject<UCapsuleComponent>(0x1160);
		
		/// <summary>
		/// Name: snake10
		/// Type: ObjectProperty
		/// Offset: 0x1168
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake10 => ReadUObject<UCapsuleComponent>(0x1168);
		
		/// <summary>
		/// Name: snake11
		/// Type: ObjectProperty
		/// Offset: 0x1170
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake11 => ReadUObject<UCapsuleComponent>(0x1170);
		
		/// <summary>
		/// Name: snake12
		/// Type: ObjectProperty
		/// Offset: 0x1178
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake12 => ReadUObject<UCapsuleComponent>(0x1178);
		
		/// <summary>
		/// Name: snake13
		/// Type: ObjectProperty
		/// Offset: 0x1180
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake13 => ReadUObject<UCapsuleComponent>(0x1180);
		
		/// <summary>
		/// Name: snake14
		/// Type: ObjectProperty
		/// Offset: 0x1188
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake14 => ReadUObject<UCapsuleComponent>(0x1188);
		
		/// <summary>
		/// Name: snake15
		/// Type: ObjectProperty
		/// Offset: 0x1190
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake15 => ReadUObject<UCapsuleComponent>(0x1190);
		
		/// <summary>
		/// Name: snake16
		/// Type: ObjectProperty
		/// Offset: 0x1198
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake16 => ReadUObject<UCapsuleComponent>(0x1198);
		
		/// <summary>
		/// Name: snake17
		/// Type: ObjectProperty
		/// Offset: 0x11A0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake17 => ReadUObject<UCapsuleComponent>(0x11A0);
		
		/// <summary>
		/// Name: snake18
		/// Type: ObjectProperty
		/// Offset: 0x11A8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake18 => ReadUObject<UCapsuleComponent>(0x11A8);
		
		/// <summary>
		/// Name: snake19
		/// Type: ObjectProperty
		/// Offset: 0x11B0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake19 => ReadUObject<UCapsuleComponent>(0x11B0);
		
		/// <summary>
		/// Name: snake20
		/// Type: ObjectProperty
		/// Offset: 0x11B8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake20 => ReadUObject<UCapsuleComponent>(0x11B8);
		
		/// <summary>
		/// Name: snake21
		/// Type: ObjectProperty
		/// Offset: 0x11C0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake21 => ReadUObject<UCapsuleComponent>(0x11C0);
		
		/// <summary>
		/// Name: snake22
		/// Type: ObjectProperty
		/// Offset: 0x11C8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake22 => ReadUObject<UCapsuleComponent>(0x11C8);
		
		/// <summary>
		/// Name: snake23
		/// Type: ObjectProperty
		/// Offset: 0x11D0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake23 => ReadUObject<UCapsuleComponent>(0x11D0);
		
		/// <summary>
		/// Name: snake24
		/// Type: ObjectProperty
		/// Offset: 0x11D8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent snake24 => ReadUObject<UCapsuleComponent>(0x11D8);
		
	}


}

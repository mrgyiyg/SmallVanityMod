using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SmallVanityProject.NPCs
{
	internal class AntNPC : ModNPC
	{

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ant");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Scorpion];
			Main.npcCatchable[npc.type] = true;
		}

		public override void SetDefaults() {
			npc.width = 16;
			npc.height = 10;
			npc.CloneDefaults(NPCID.Scorpion);
			npc.catchItem = (short)ModContent.ItemType<AntItem>();
			npc.lavaImmune = true;
			npc.friendly = true;
			aiType = NPCID.Scorpion;
			animationType = NPCID.Scorpion;
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDay.Chance * 0.1f;
			return SpawnCondition.OverworldDaySandCritter.Chance * 0.1f;
			return SpawnCondition.Underground.Chance * 0.1f;
		}
		
		public override void OnCatchNPC(Player player, Item item) {
			item.stack = 1;

				}

		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("NPCs/AntHalf1"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("NPCs/AntHalf2"), npc.scale);
			}
		}

	}

	internal class AntItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ant");
		}

		public override void SetDefaults() {
			item.useStyle = 1;
			item.autoReuse = true;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 999;
			item.consumable = true;
			item.width = 16;
			item.height = 10;
			item.noUseGraphic = true;
			item.CloneDefaults(ItemID.Scorpion);
			item.bait = 5;
			item.makeNPC = (short)ModContent.NPCType<AntNPC>();
		}
	}
}

using System;
using SmallVanityProject.Items;
using SmallVanityProject.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SmallVanityProject.NPCs
{
	[AutoloadHead]
	public class StarTouched : ModNPC
	{
		public override string Texture => "SmallVanityProject/NPCs/StarTouched";

		public override bool Autoload(ref string name) {
			name = "Startouched";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Startouched");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 10;
		}

		public override void SetDefaults() {
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 40;
			npc.height = 56;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
			for (int k = 0; k < 255; k++) {
				Player player = Main.player[k];
				if (!player.active) {
					continue;
				}

				foreach (Item item in player.inventory) {
					if (item.type == ItemID.FragmentStardust) {
						return true;
					}
				}
			}
			return false;
		}

		public override string TownNPCName() {
			switch (WorldGen.genRand.Next(4)) {
				case 0:
					return "Zone";
				case 1:
					return "Veke";
				case 2:
					return "Zzazz";
				default:
					return "Ezil";
			}
		}

		public override string GetChat() {

			switch (Main.rand.Next(4)) {
				case 0:
					return "Don't you ever get tired of being an individual?";
					
				case 1:
					return "This could be us, if you'd become one with the hive.";
					
				case 2:
					return "You're all so single-minded.";
					
				default:
					return "Know what it's like to be part of a hive mind? Would you like to??";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2) {
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop) {
			if (firstButton) {
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot) {
		
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<StarCell>());
			nextSlot++;
		shop.item[nextSlot].SetDefaults(ModContent.ItemType<StardustTendril>());
			nextSlot++;
		shop.item[nextSlot].SetDefaults(ModContent.ItemType<FlowInvaderShard>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<MilkywayScarf>());
			nextSlot++;
		shop.item[nextSlot].SetDefaults(ModContent.ItemType<TwinklePopperMask>());
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.StardustMonolith);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.StardustDye);
			nextSlot++;
			
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
			damage = 30;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = mod.ProjectileType("Twinkleshot");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}

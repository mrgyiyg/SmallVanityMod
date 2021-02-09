using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	public class FlowInvaderShard : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flow Invader Shard");
			Tooltip.SetDefault("Sparkly, and still glowing slightly");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("MiniFlowInvader");
			item.buffType = mod.BuffType("PersonalSpaceInvader");
			item.width = 22;
            		item.height = 22;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SmallVanityProject.Items
{
	public class GinjiroTen : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Angelic Digital Friend");
			Tooltip.SetDefault("Summons Ginjirotenshi to follow you");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("GinjiroTenPet");
			item.buffType = mod.BuffType("GinjiroTenBuff");
			item.width = 36;
            		item.height = 36;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddIngredient(ItemID.AngelHalo, 1);
            recipe.AddIngredient(ItemID.Gravestone, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe  .AddRecipe();
        }		

	}
}

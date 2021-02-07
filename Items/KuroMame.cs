using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
    class KuroMame : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Transitional Digital Friend");
            Tooltip.SetDefault("Summons Kuromametchi to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("KuroMamePet");
            item.buffType = mod.BuffType("KuroMameBuff");
            item.width = 36;
            item.height = 36;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Spike, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe  .AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}

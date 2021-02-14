using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
    class MitraShell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange-spotted Miter Shell");
            Tooltip.SetDefault("Someone still lives here...");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.shoot = mod.ProjectileType("MitraMitra");
            item.buffType = mod.BuffType("MitraBuff");
            item.width = 40;
            item.height = 24;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 8;
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

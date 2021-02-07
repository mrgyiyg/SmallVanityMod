using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Buffs
{
    public class KuroMameBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Kuromametchi");
            Description.SetDefault("you better respect my daughter, buddy!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<VainPlayer>().kuroMame = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("KuroMamePet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("KuroMamePet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}

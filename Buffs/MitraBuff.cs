using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Buffs
{
    public class MitraBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Mitra Mitra");
            Description.SetDefault("What a lovely shell");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<VainPlayer>().mitraMitra = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("MitraMitra")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("MitraMitra"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}

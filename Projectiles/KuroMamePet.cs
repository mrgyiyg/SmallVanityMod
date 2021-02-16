using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Projectiles
{
    public class KuroMamePet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kuromametchi");
            Main.projFrames[projectile.type] = 10;
            Main.projPet[projectile.type] = true;
        }    
    
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CursedSapling);
            aiType = ProjectileID.CursedSapling;
            projectile.width = 38;
            projectile.height = 59;
            drawOriginOffsetY = 3;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.blackCat = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            VainPlayer modPlayer = player.GetModPlayer<VainPlayer>();
            if (player.dead)
            {
                modPlayer.kuroMame = false;
            }

            if (modPlayer.kuroMame)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}

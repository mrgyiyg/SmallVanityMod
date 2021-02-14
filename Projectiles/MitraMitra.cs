using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Projectiles
{
    public class MitraMitra : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mitra Mitra");
            Main.projFrames[projectile.type] = 8;
            Main.projPet[projectile.type] = true;
        }    
    
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bunny);
            aiType = ProjectileID.Bunny;
            projectile.width = 60;
            projectile.height = 32;
            drawOriginOffsetY = 3;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.bunny = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            VainPlayer modPlayer = player.GetModPlayer<VainPlayer>();
            if (player.dead)
            {
                modPlayer.mitraMitra = false;
            }

            if (modPlayer.mitraMitra)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}

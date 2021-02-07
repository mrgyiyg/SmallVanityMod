using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Projectiles
{
    public class MiniFlowInvader : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mini Flow Invader");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }    
    

	public override void SetDefaults() {
		projectile.CloneDefaults(ProjectileID.ZephyrFish);
		aiType = ProjectileID.ZephyrFish;
		projectile.width = 24;
		projectile.height = 34;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            VainPlayer modPlayer = player.GetModPlayer<VainPlayer>();
            if (player.dead)
            {
                modPlayer.flowInvaded = false;
            }

            if (modPlayer.flowInvaded)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}

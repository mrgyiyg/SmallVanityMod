using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Projectiles
{
    public class GinjiroTenPet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ginjirotenshi");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }    
    

	public override void SetDefaults() {
		projectile.CloneDefaults(ProjectileID.ZephyrFish);
		aiType = ProjectileID.ZephyrFish;
		projectile.width = 38;
		projectile.height = 36;
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
                modPlayer.ginjiroTen = false;
            }

            if (modPlayer.ginjiroTen)
            {
                projectile.timeLeft = 2;
            }
            
            #region Animation and visuals
		Lighting.AddLight(projectile.Center, Color.White.ToVector3() * 0.18f);
		#endregion
        }

    }
}

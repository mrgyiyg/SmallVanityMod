using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SmallVanityProject.Projectiles
{
	public class Twinkleshot : ModProjectile
	{
	        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 1;
        }   
	
		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StardustJellyfishSmall);
			aiType = ProjectileID.StardustJellyfishSmall;
			projectile.width = 26;
			projectile.height = 26;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.magic = true;
			projectile.light = 0.8f;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.timeLeft = 600;
		}
	}
}

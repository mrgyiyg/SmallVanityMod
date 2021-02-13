using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using SmallVanityProject.BaseFiles;

namespace SmallVanityProject.Projectiles
{
	public class Perry : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Perry Perihelion");
			Main.projFrames[projectile.type] = 8;
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
			ProjectileID.Sets.LightPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.MagicLantern);
			projectile.width = 32;
			projectile.height = 24;
			projectile.penetrate = -1;
			projectile.netImportant = true;
			projectile.timeLeft *= 5;
			projectile.friendly = true;
			projectile.ignoreWater = true;
			projectile.scale = 0.8f;
			projectile.tileCollide = false;
		}

		private const int fadeInTicks = 30;
		private const int fullBrightTicks = 200;
		private const int fadeOutTicks = 30;
		private const int range = 500;
		private readonly int rangeHypoteneus = (int)Math.Sqrt(range * range + range * range);

		public override void AI() {
			Player player = Main.player[projectile.owner];
			VainPlayer modPlayer = player.GetModPlayer<VainPlayer>();
			if (!player.active) {
				projectile.active = false;
				return;
			}
			if (player.dead) {
				modPlayer.perryPerihelion = false;
			}
			if (modPlayer.perryPerihelion) {
				projectile.timeLeft = 2;
			}
		#region Animation and visuals
		Lighting.AddLight(projectile.Center, Color.Yellow.ToVector3() * 1.5f);
		
if (projectile.velocity.X >= 1 || projectile.velocity.X <= -1 || projectile.velocity.Y <= 2)
            {
		if (Main.rand.NextBool(10)) {
                int num145 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 55, 0f, 0f, 200, new Color(255, 255, 255), 0.8f);
			Main.dust[num145].velocity *= 0.3f;
		}
}
else
{
		if (Main.rand.NextBool(30)) {
                int num145 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 55, 0f, 0f, 200, new Color(255, 255, 255), 0.8f);
			Main.dust[num145].velocity *= 0.3f;
			}                                            
            }
		#endregion
			}
		}
	}

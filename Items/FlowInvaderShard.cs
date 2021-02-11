using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SmallVanityProject.Items
{
	public class FlowInvaderShard : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Flow Invader Shard");
			Tooltip.SetDefault("Sparkly, and still glowing slightly");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = mod.ProjectileType("MiniFlowInvader");
			item.buffType = mod.BuffType("PersonalSpaceInvader");
			item.width = 22;
            		item.height = 22;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
		
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float  scale, int whoAmI) 	
{
	Texture2D texture = mod.GetTexture("Items/Glow/FlowInvaderShard_Glow");
	spriteBatch.Draw
	(
		texture,
		new Vector2
		(
			item.position.X - Main.screenPosition.X + item.width * 0.5f,
			item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
		),
		new Rectangle(0, 0, texture.Width, texture.Height),
		Color.White,
		rotation,
		texture.Size() * 0.5f,
		scale, 
		SpriteEffects.None, 
		0f
	);
}
	}
}

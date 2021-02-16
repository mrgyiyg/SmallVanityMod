using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Neck)]
	class MilkywayScarf : ModItem
	{

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Milkyway Scarf");
			}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 28;
			item.height = 28;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}
		
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float  scale, int whoAmI) 	
{
	Texture2D texture = mod.GetTexture("Items/Glow/MilkywayScarf_Glow");
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

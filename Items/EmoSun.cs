using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class EmoSun : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Emo Sun Mask");
			Tooltip.SetDefault("Perhaps someday you will learn that there are consequences for your actions");
			}
			
		public override void SetDefaults() {
			item.width = 32;
			item.height = 28;
			item.rare = ItemRarityID.Red;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunMask, 1);
			recipe.AddIngredient(ItemID.BlackPaint, 1);
			recipe.AddIngredient(ItemID.GraveMarker, 1);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

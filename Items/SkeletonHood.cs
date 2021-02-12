using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SkeletonHood : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cutesy Skeleton Hood");
			Tooltip.SetDefault("Not a very intimidating skeleton");
			}
			
		public override void SetDefaults() {
			item.width = 24;
			item.height = 22;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 5);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
	}
}
}

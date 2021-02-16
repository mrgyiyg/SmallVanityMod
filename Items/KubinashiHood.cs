using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class KubinashiHood : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Kubinashi Hood");
			Tooltip.SetDefault("Don't lose your head over it, haha");
			}
			
		public override void SetDefaults() {
			item.width = 26;
			item.height = 22;
			item.rare = ItemRarityID.Red;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackString, 1);
			recipe.AddIngredient(ItemID.CursedFlame, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

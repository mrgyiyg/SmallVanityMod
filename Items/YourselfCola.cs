using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	public class YourselfCola : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Caution: May actually be soy sauce");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Red;
			item.healLife = 100;
			item.healMana = 100;
			item.potion = true;
			item.value = Item.buyPrice(gold: 1);
		}

		public override void GetHealLife(Player player, bool quickHeal, ref int healValue) {
			healValue = player.statLifeMax2 / 2;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StrangeBrew, 1);
			recipe.AddIngredient(ItemID.FamiliarShirt, 1);			
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

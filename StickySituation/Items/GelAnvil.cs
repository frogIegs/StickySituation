using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
	public class GelAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Gel Anvil");
			Tooltip.SetDefault("Functions as a normal anvil.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("GelAnvil");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.IronAnvil);
			recipe1.AddIngredient(null, "GelBar", 5);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.LeadAnvil);
			recipe2.AddIngredient(null, "GelBar", 5);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
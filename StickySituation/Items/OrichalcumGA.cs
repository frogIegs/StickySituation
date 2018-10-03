using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
	public class OrichalcumGA : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Orichalcum Gel Anvil");
			Tooltip.SetDefault("Functions as a orichalcum anvil.");
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
            item.rare = 3;
			item.consumable = true;
			item.value = 15000;
			item.createTile = mod.TileType("OrichalcumGA");
		}

		public override void AddRecipes()
		{
            ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.OrichalcumAnvil);
			recipe2.AddIngredient(null, "GelBar", 10);
            recipe2.AddTile(null, "GelAnvil");
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
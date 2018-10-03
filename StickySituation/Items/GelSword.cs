using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
	public class GelSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Sword");
			Tooltip.SetDefault("Sticky and tasty!");
		}
		public override void SetDefaults()
		{
			item.damage = 21;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 75;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelBar", 8);
			recipe.AddTile(null, "GelAnvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
            ModRecipe recipe_1 = new ModRecipe(mod);
			recipe_1.AddIngredient(null, "GelBar", 8);
			recipe_1.AddTile(null, "MythrilGA");
			recipe_1.SetResult(this);
			recipe_1.AddRecipe();
            ModRecipe recipe_2 = new ModRecipe(mod);
			recipe_2.AddIngredient(null, "GelBar", 8);
			recipe_2.AddTile(null, "OrichalcumGA");
			recipe_2.SetResult(this);
			recipe_2.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.GoldCrown);
            recipe1.AddTile(TileID.Anvils);
            recipe1.SetResult(ItemID.PlatinumCrown);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.PlatinumCrown);
            recipe2.AddTile(TileID.Anvils);
            recipe2.SetResult(ItemID.GoldCrown);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.GoldBar);
            recipe3.AddTile(TileID.Anvils);
            recipe3.SetResult(ItemID.PlatinumBar);
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(mod);
            recipe4.AddIngredient(ItemID.PlatinumBar);
            recipe4.AddTile(TileID.Anvils);
            recipe4.SetResult(ItemID.GoldBar);
            recipe4.AddRecipe();

            ModRecipe recipe5 = new ModRecipe(mod);
            recipe5.AddIngredient(ItemID.IronBar, 10);
            recipe5.AddIngredient(ItemID.Gel, 35);
            recipe5.AddTile(TileID.Anvils);
            recipe5.SetResult(ItemID.Solidifier);
            recipe5.AddRecipe();

            ModRecipe recipe6 = new ModRecipe(mod);
            recipe6.AddIngredient(ItemID.LeadBar, 10);
            recipe6.AddIngredient(ItemID.Gel, 35);
            recipe6.AddTile(TileID.Anvils);
            recipe6.SetResult(ItemID.Solidifier);
            recipe6.AddRecipe();
		}

        
	}
}

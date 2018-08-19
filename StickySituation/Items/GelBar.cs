using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
    public class GelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel Bar");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 100000;
            item.createTile = mod.TileType("GelBar");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.Gel, 4);
            recipe1.AddTile(TileID.Furnaces);
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}
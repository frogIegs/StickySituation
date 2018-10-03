using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
    public class PinkGelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Gel Bar");
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
            item.createTile = mod.TileType("PinkGelBar");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.PinkGel, 5);
            recipe1.AddTile(TileID.AdamantiteForge);
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}
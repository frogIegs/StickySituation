using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Tools
{
    public class PinkGelMultiTool : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Gel Multi-Tool");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 15;
            item.axe = 25;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
            item.hammer = 165;       //How much hammer power the weapon has
            item.pick = 150;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelPickaxe");
            recipe.AddIngredient(null, "GelHamaxe");
            recipe.AddTile(null, "GelAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "GelPickaxe");
            recipe2.AddIngredient(null, "GelHamaxe");
            recipe2.AddTile(null, "MythrilGA");
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "GelPickaxe");
            recipe3.AddIngredient(null, "GelHamaxe");
            recipe3.AddTile(null, "OrichalcumGA");
            recipe3.SetResult(this);
            recipe3.AddRecipe();
        }

    }
}

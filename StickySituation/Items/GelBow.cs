using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace StickySituation.Items
{
    public class GelBow : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Bow");
			Tooltip.SetDefault("Sticky and tasty!");
		}
        public override void SetDefaults()
        {
            item.damage = 24;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1.5f;
            item.value = 75;
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelBar", 11);
            recipe.AddTile(null, "GelAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
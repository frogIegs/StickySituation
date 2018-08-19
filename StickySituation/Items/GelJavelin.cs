using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 

namespace StickySituation.Items
{
    public class GelJavelin : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Javelin");
			Tooltip.SetDefault("Sticky and tasty!");
		}
        public override void SetDefaults()
        {
           // item.name = "Gel Boomerang";   //this is the item name
            item.damage = 14;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;       //this is how fast you use the item
            item.useAnimation = 25;   //this is how fast the animation when the item is used
            item.useStyle = 1;      
            item.knockBack = 4;
            item.value = 1;
            item.rare = 1;
            item.reuseDelay = 10;    //this is the item delay
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("GelJavelinP");  //javelin projectile
            item.shootSpeed = 50f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 999;       //this is the max stack of this item
            item.consumable = true;  //this make the item consumable when used
            item.noUseGraphic = true;
                       
        }
       public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelBar", 5);
			recipe.AddTile(null, "GelAnvil");
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
    }
}

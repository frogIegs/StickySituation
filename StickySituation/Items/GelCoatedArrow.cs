using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using StickySituation.Items;

namespace StickySituation.Items
{
    public class GelCoatedArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel Coated Arrow");
            Tooltip.SetDefault("Covers your foes with gel!");
        }
        public override void SetDefaults()
        {
            item.damage = 11;    //The damage stat for the Weapon.
            item.ranged = true;  //This defines if it does Ranged damage and if its effected by Ranged increasing Armor/Accessories.
            item.width = 8;  //The size of the width of the hitbox in pixels.
            item.height = 8;   //The size of the height of the hitbox in pixels.
            item.maxStack = 999; //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once fired
            item.knockBack = 1.5f;  //Added with the weapon's knockback
            item.value = Item.buyPrice(0, 0, 2, 50); //	How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 20silvers)
            item.rare = 1;   //The color the title of your Weapon when hovering over it ingame  
            item.shoot = mod.ProjectileType("GelCoatedArrowP");  //This defines what type of projectile this weapon will shoot	
            item.shootSpeed = 2f; //Added to the weapon's shoot speed
            item.ammo = 40;    //This defines what type of ammo is. 40 is arrow
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 10);
            recipe.AddIngredient(null, "GelBar", 1);
            recipe.AddTile(null, "GelAnvil");
            recipe.SetResult(this, 10);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.WoodenArrow, 10);
            recipe2.AddIngredient(null, "GelBar", 1);
            recipe2.AddTile(null, "OrichalcumGA");
            recipe2.SetResult(this, 10);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.WoodenArrow, 10);
            recipe3.AddIngredient(null, "GelBar", 1);
            recipe3.AddTile(null, "MythrilGA");
            recipe3.SetResult(this, 10);
            recipe3.AddRecipe();
        }
    }
}
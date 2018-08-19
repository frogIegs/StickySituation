using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.NPCs
{   
    public class Merchant : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:  //change Dryad whith what NPC you want

                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelBow"));  //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelSword"));    //this is an example of how to add a terraria item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelYoyo"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelBoomerang"));
                    }
                    if (NPC.downedSlimeKing)   //this make so when the king slime is killed the town npc will sell this
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldCrown);  //an example of how to add a vanilla terraria item
                        nextSlot++;
                    }
                    else
                    {    //This make that the npc will always sell this
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelCoatedArrow"));   //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GelJavelin"));   //this is an example of how to add your item
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.Gel);     //this is an example of how to add a terraria item
                        nextSlot++;
                    }
                    if (Main.player[Main.myPlayer].ZoneHoly)//if the player is in jungle the npc will sell whis.  Change ZoneJungle with what zone you want: ZoneCorrupt for Corupption, ZoneCrimson for Crimson, ZoneDesert for Desert, ZoneDungeon for Dungeon, ZoneGlowshroom for Glowing Mushroom biome, ZoneHoly for The Hallow, ZoneJungle for Jungle, ZoneMeteor for Meteorite biome, ZoneSnow for Snow biome.
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PinkGel); //this is an example of how to add a terraria item
                        nextSlot++;
                    }

                    break;
            }
        }
    }
}
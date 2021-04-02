using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeitoMod.Swords.SupremeGrade.Murakumogiri
{
    public class Murokamagiri : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Hmm... I wonder if you could talk to someone to figure more out about this naginata...");
        }

        public override void SetDefaults()
        {
            item.damage = 320;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 67;            //Weapon's texture's width
            item.height = 72;           //Weapon's texture's height
            item.useTime = 20;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 20;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 3;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 6;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(gold: 54);           //The value of the weapon
            item.rare = 12;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
        }
    }
}
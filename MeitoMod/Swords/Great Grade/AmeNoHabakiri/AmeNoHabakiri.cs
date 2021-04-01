using System;

namespace MeitoMod.Swords.GreatGrade.AmeNoHabakiri
{
	public class Enma : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Hmm... I wonder if you could talk to someone to figure out more about this sword...");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 54;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
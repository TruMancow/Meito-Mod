using System;

namespace MeitoMod.Swords.GreatGrade.Enma
{
	public class Enma : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Enma doesn't seem to respond well to your commands. Maybe if you could prove yourself to her...");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 54;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
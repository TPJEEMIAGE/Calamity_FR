﻿using System;
using CalamityMod;
using CalamityMod.UI;
using Terraria;
using Terraria.ModLoader;
using CalamityFR.DraedonLogs;
using CalamityMod.Items.DraedonMisc;

namespace CalamityFR.DraedonLogs
{
	public class DraedonSnowLogTranslated : ModItem
	{
		public override string Texture => "CalamityMod/Items/DraedonMisc/DraedonsLogSnowBiome";

		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Journal de Draedon - Les étendues gelées (Traduit)");
			base.Tooltip.SetDefault("Cliquez pour voir son contenu");
		}

		public override void SetDefaults()
		{
			base.Item.width = 28;
			base.Item.height = 28;
			base.Item.rare = ModLoader.GetMod("CalamityMod").Find<ModRarity>("DarkOrange").Type;
			base.Item.useAnimation = (base.Item.useTime = 20);
			base.Item.useStyle = 4;
		}

		public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
		{
			if (Main.myPlayer == player.whoAmI)
			{
				PopupGUIManager.FlipActivityOfGUIWithType(typeof(SnowGUI));
			}
			return true;
		}

		public override void AddRecipes()
        {
			Recipe modRecipe = Recipe.Create(this.Type);
			modRecipe.AddIngredient(ModContent.ItemType<DraedonsLogSnowBiome>());
			modRecipe.Register();

			Recipe reverseModRecipe = Recipe.Create(ModContent.ItemType<DraedonsLogSnowBiome>());
			reverseModRecipe.AddIngredient(ModContent.ItemType<DraedonSnowLogTranslated>());
			reverseModRecipe.Register();

		}
	}
}
﻿using Terraria.ModLoader;
using Terraria.ID;

namespace Thinf.Items.Placeables
{
	public class WheatSeeds : ModItem
	{
        public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Plants a tomato crop\nUse on tilled dirt");
        }
        public override void SetDefaults()
		{
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 16;
			item.height = 16;
			item.value = 500;
			item.createTile = ModContent.TileType<Blocks.WheatTile>();
		}
	}
}
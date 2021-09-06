using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace Thinf.Items.THE_SUPER_COOL_BADASS_LORE
{
    public class CacterusBusinessCard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cacterus' Business Card");
            Tooltip.SetDefault("It has an email attached:\nFor complaints please contact: cacterusofficial@gmail.com\n\n\nLore?");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = 4;
        }
        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Tink, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }
    }
}

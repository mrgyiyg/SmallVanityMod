using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;

using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace SmallVanityProject.BaseFiles
{
    public class VainPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool minionName;
        public bool kuroMame;
        public bool flowInvaded;
        public static bool hasProjectile;

        public override void ResetEffects()
        {
            minionName = false;
            kuroMame = false;
            flowInvaded = false;
        }
    }
}

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
using Terraria.DataStructures;
using Terraria.ModLoader.IO;
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
public static readonly PlayerLayer StarCellMaskGlow = new PlayerLayer("SmallVanityProject", "StarCellMaskGlow", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
        {
            if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
            {
                return;
            }
        
            Player drawPlayer = drawInfo.drawPlayer;
            Mod mod = ModLoader.GetMod("SmallVanityProject");

            if (drawPlayer.head != mod.GetEquipSlot("StarCell", EquipType.Head))
            {                
                return;
            }

            Texture2D texture = mod.GetTexture("Items/Glow/StarCell_Head_Glow");

            float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
            float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 - 1f;
            Vector2 origin = drawInfo.headOrigin;
            Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
            float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
            Color color = Color.White;
            Rectangle frame = drawPlayer.bodyFrame;
            float rotation = drawPlayer.bodyRotation;
            SpriteEffects spriteEffects = drawInfo.spriteEffects;

	DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
	
            drawData.shader = drawInfo.headArmorShader;
                
            Main.playerDrawData.Add(drawData);
        });

        public static readonly PlayerLayer TwinklePopperMaskGlow = new PlayerLayer("SmallVanityProject", "TwinklePopperGlow", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
        {
            if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
            {
                return;
            }
        
            Player drawPlayer = drawInfo.drawPlayer;
            Mod mod = ModLoader.GetMod("SmallVanityProject");

            if (drawPlayer.head != mod.GetEquipSlot("TwinklePopperMask", EquipType.Head))
            {
                

                return;
            }

            Texture2D texture = mod.GetTexture("Items/Glow/TwinklePopperMask_Head_Glow");

            float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
            float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 - 1f;

            Vector2 origin = drawInfo.headOrigin;

            Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;

            float alpha = (255 - drawPlayer.immuneAlpha) / 255f;

            Color color = Color.White;

            Rectangle frame = drawPlayer.bodyFrame;

            float rotation = drawPlayer.bodyRotation;

            SpriteEffects spriteEffects = drawInfo.spriteEffects;

            DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0)
            {
                shader = drawInfo.headArmorShader
                

            };
            Main.playerDrawData.Add(drawData);
        });

public static readonly PlayerLayer DustyScarf = new PlayerLayer("SmallVanityProject", "DustyScarf", PlayerLayer.NeckAcc, delegate (PlayerDrawInfo drawInfo) {


    	if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
            {
                return;
            }
            
            
            Player drawPlayer = drawInfo.drawPlayer;
            Mod mod = ModLoader.GetMod("SmallVanityProject");
            
           if (drawPlayer.neck != mod.GetEquipSlot("MilkywayScarf", EquipType.Neck)) 
           	{
			return;
		}

            Texture2D texture = mod.GetTexture("Items/Glow/MilkywayScarf_Neck_Glow");

            float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
            float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 - 1f;

            Vector2 origin = drawInfo.headOrigin;

            Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;

            float alpha = (255 - drawPlayer.immuneAlpha) / 255f;

            Color color = Color.White;

            Rectangle frame = drawPlayer.bodyFrame;

            float rotation = drawPlayer.bodyRotation;

            SpriteEffects spriteEffects = drawInfo.spriteEffects;

DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0)
            {
                shader = drawInfo.neckShader
            };
            Main.playerDrawData.Add(drawData);
        });
        
         public override void ModifyDrawLayers(List<PlayerLayer> layers) {
         	int headLayer = layers.FindIndex(i => i == PlayerLayer.Head);

		if (headLayer > -1) {
			layers.Insert(headLayer + 1, StarCellMaskGlow);
			layers.Insert(headLayer + 1, TwinklePopperMaskGlow);
				}
				
		if (player.neck == mod.GetEquipSlot("MilkywayScarf", EquipType.Neck)) {
		int neckLayer = layers.FindIndex(l => l == PlayerLayer.NeckAcc);

		if (neckLayer > -1) {
			layers.Insert(neckLayer + 1, DustyScarf);
				}
			}

		}        

		}
    }    

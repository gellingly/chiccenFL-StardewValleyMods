﻿using Microsoft.Xna.Framework;

namespace WaterYourCrops
{
    partial class ModEntry
    {
        private static void GetColor(string field = "none")
        {
            if (field != "color") return;

            switch (Config.IndicatorColor)
            {
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Red":
                    color = Color.Red;
                    break;
                case "Pink":
                    color = Color.LightPink;
                    break;
                case "Gray":
                    color = Color.LightGray;
                    break;
                case "Black":
                    color = Color.Black;
                    break;
                default:
                    color = Color.White;
                    break;

            }

            Log($"Set color to {Config.IndicatorColor}");
        }
    }
}
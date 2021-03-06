﻿using System.Drawing;
using System.Drawing.Imaging;

namespace ReSizer.ToolHelpers
{
    public static class ImageExtensions
    {
        /// <summary>
        ///     Extension method to help save out images. If codec is null, it'll save as original format
        /// </summary>
        /// <param name="image">Image to save</param>
        /// <param name="path">Path to save it to</param>
        /// <param name="codec">Codec to save as (can be null).</param>
        /// <param name="dryRun"></param>
        public static void Save(this Image image, string path, ImageCodecInfo codec, bool dryRun)
        {
            if (dryRun)
            {
                Logger.WriteLine("Would have created {0}", path);
            }
            else
            {
                if (codec == null)
                {
                    // Saves as original
                    image.Save(path);
                }
                else
                {
                    // Saves with customized codec
                    image.Save(path, codec, null);
                }
                Logger.WriteLine("Created {0}", path);
            }
        }
    }
}


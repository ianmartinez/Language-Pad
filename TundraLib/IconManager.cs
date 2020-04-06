﻿using System.Drawing;
using System.Linq;
using System.Reflection;

namespace TundraLib
{
    public enum IconSize
    {
        IconSmall, IconLarge
    }

    public enum IconResolution
    {
        Normal, HiDPI
    }

    public class IconManager
    {
        public static Bitmap Get(string name, IconSize iconSize, IconResolution iconResolution)
        {
            string folder;

            if (iconResolution == IconResolution.Normal)
                folder = (iconSize == IconSize.IconLarge) ? "Icon32" : "Icon24";
            else
                folder = (iconSize == IconSize.IconLarge) ? "Icon48" : "Icon32";

            var resourceName = string.Format("TundraLib.Resources.{0}.{1}.png", folder, name);
            var assembly = Assembly.GetExecutingAssembly();
            // Find what files are available:
            // var names = assembly.GetManifestResourceNames().Where(n => n.Contains(".Icon48.")).ToArray();
            var s = assembly.GetManifestResourceStream(resourceName);
            return new Bitmap(s);
        }
    }
}

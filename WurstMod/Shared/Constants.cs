﻿using System.IO;
using BepInEx;

namespace WurstMod.Shared
{
    internal static class Constants
    {
        public static readonly string LegacyLevelsDirectory = Path.Combine(Paths.PluginPath, "LegacyCustomLevels");
        public const string FilenameLevelData = "leveldata";
        public const string FilenameLevelInfo = "info.json";
        public const string FilenameLevelThumbnail = "thumb.png";

        public const string RootObjectLevelName = "[LEVEL]";

        public const string GamemodeTakeAndHold = "h3vr.take_and_hold";
        public const string GamemodeSandbox = "h3vr.sandbox";
    }
}
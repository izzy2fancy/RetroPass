using System;

namespace RetroPass
{
    [Serializable]
    public class Platform
    {
        public Platform() { }

        public Platform(Platform other)
        {
            this.Name = other.Name;
            this.SourceName = other.SourceName;
            this.Emulator = other.Emulator;
            this.BoxFrontPath = other.BoxFrontPath;
            this.ScreenshotGameTitlePath = other.ScreenshotGameTitlePath;
            this.ScreenshotGameplayPath = other.ScreenshotGameplayPath;
            this.ScreenshotGameSelectPath = other.ScreenshotGameSelectPath;
            this.VideoPath = other.VideoPath;
        }
    }
}
        public enum EmulatorType
        {
            retroarch,
            rgx,
            xbsx2,
            dolphin,
            xenia,
            ppsspp,
            xeniacanary,
            duckstation,
            duckstationuwp
        }

        public string Name { get; set; }
        public string SourceName { get; set; }
        public EmulatorType Emulator { get; set; }
        public string BoxFrontPath { get; set; }
        public string ScreenshotGameTitlePath { get; set; }
        public string ScreenshotGameplayPath { get; set; }
        public string ScreenshotGameSelectPath { get; set; }
        public string VideoPath { get; set; }

        [XmlIgnore]
        public StorageFolder BoxFrontFolder { get; set; }

        public void SetEmulatorType(string emulatorPath)
        {
            // Your existing logic for setting the EmulatorType based on emulatorPath
        }

        public Platform Clone()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

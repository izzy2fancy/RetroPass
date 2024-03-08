using System.Xml.Serialization;
using Windows.Storage;

namespace RetroPass
{
    public class Platform
    {
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
        public EmulatorTypeEnum Emulator { get; set; }
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
            // Make sure to update references to the property as EmulatorTypeEnum
        }

        public Platform Clone()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

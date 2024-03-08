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
            xeniacanary,
            ppsspp,
            duckstation,
            duckstationuwp,
        }

        public string Name { get; set; }
        public string SourceName { get; set; }
        public EmulatorType EmulatorType { get; set; }
        public string BoxFrontPath { get; set; }
        public string ScreenshotGameTitlePath { get; set; }
        public string ScreenshotGameplayPath { get; set; }
        public string ScreenshotGameSelectPath { get; set; }
        public string VideoPath { get; set; }

        [XmlIgnoreAttribute]
        public StorageFolder BoxFrontFolder { get; set; }

        public void SetEmulatorType(string emulatorPath)
        {
            if (string.IsNullOrEmpty(emulatorPath))
            {
                // Default to retroarch if emulator path is empty
                EmulatorType = EmulatorType.retroarch;
                return;
            }

            switch (emulatorPath.ToLower())
            {
                case string s when s.Contains("pcsx2") || s.Contains("xbsx2"):
                    EmulatorType = EmulatorType.xbsx2;
                    break;
                case string s when s.Contains("retrix"):
                    EmulatorType = EmulatorType.rgx;
                    break;
                case string s when s.Contains("dolphin"):
                    EmulatorType = EmulatorType.dolphin;
                    break;
                case string s when s.Contains("xenia-canary") || s.Contains("xeniacanary"):
                    EmulatorType = EmulatorType.xeniacanary;
                    break;
                case string s when s.Contains("xenia"):
                    EmulatorType = EmulatorType.xenia;
                    break;
                case string s when s.Contains("ppsspp"):
                    EmulatorType = EmulatorType.ppsspp;
                    break;
                case string s when s.Contains("duckstation"):
                    EmulatorType = EmulatorType.duckstation;
                    break;
                case string s when s.Contains("duckstation-uwp"):
                    EmulatorType = EmulatorType.duckstationuwp;
                    break;
                default:
                    // Let it default to retroarch if no match is found
                    EmulatorType = EmulatorType.retroarch;
                    break;
            }
        }

        public Platform Clone()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

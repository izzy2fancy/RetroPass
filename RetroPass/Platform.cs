using System.Xml.Serialization;

namespace RetroPass
{
    public class Platform
    {
        public enum EmulatorType
        {
            Retroarch,
            Rgx,
            Xbsx2,
            Dolphin,
            Xenia,
            Xeniacanary,
            Ppsspp,
            Duckstation,
            Duckstationuwp
        }

        public string Name { get; set; }
        public string SourceName { get; set; }
        public EmulatorType Type { get; set; }
        public string BoxFrontPath { get; set; }
        public string ScreenshotGameTitlePath { get; set; }
        public string ScreenshotGameplayPath { get; set; }
        public string ScreenshotGameSelectPath { get; set; }
        public string VideoPath { get; set; }

        [XmlIgnore]
        public string BoxFrontFolderPath { get; set; }

        public void SetEmulatorType(string emulatorPath)
        {
            if (!string.IsNullOrEmpty(emulatorPath))
            {
                if (emulatorPath.Contains("pcsx2", System.StringComparison.CurrentCultureIgnoreCase) ||
                    emulatorPath.Contains("xbsx2", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Xbsx2;
                }
                else if (emulatorPath.Contains("retrix", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Rgx;
                }
                else if (emulatorPath.Contains("dolphin", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Dolphin;
                }
                else if (emulatorPath.Contains("xenia-canary", System.StringComparison.CurrentCultureIgnoreCase) ||
                         emulatorPath.Contains("xeniacanary", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Xeniacanary;
                }
                else if (emulatorPath.Contains("xenia", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Xenia;
                }
                else if (emulatorPath.Contains("ppsspp", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Ppsspp;
                }
                else if (emulatorPath.Contains("duckstation-uwp", System.StringComparison.CurrentCultureIgnoreCase) ||
                         emulatorPath.Contains("duckstation-uwp.exe", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Duckstationuwp;
                }
                else if (emulatorPath.Contains("duckstation", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Type = EmulatorType.Duckstation;
                }
                else
                {
                    Type = EmulatorType.Retroarch;
                }
            }
        }

        public Platform Copy()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

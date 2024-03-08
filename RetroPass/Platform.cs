using System.Xml.Serialization;
using Windows.Storage;

namespace RetroPass
{
    public class Platform
    {
        public enum EEmulatorType
        {
            retroarch,
            rgx,
            xbsx2,
            dolphin,
            xenia,
            xeniacanary,
            ppsspp,
            duckstation,
            duckstation_uwp,
        }

        public string Name { get; set; }
        public string SourceName { get; set; }
        public EEmulatorType EmulatorType { get; set; }
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
                EmulatorType = EEmulatorType.retroarch;
                return;
            }

            if (emulatorPath.Contains("pcsx2", System.StringComparison.CurrentCultureIgnoreCase) ||
                emulatorPath.Contains("xbsx2", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.xbsx2;
            }
            else if (emulatorPath.Contains("retrix", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.rgx;
            }
            else if (emulatorPath.Contains("dolphin", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.dolphin;
            }
            else if (emulatorPath.Contains("xenia-canary", System.StringComparison.CurrentCultureIgnoreCase) ||
                     emulatorPath.Contains("xeniacanary", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.xeniacanary;
            }
            else if (emulatorPath.Contains("xenia", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.xenia;
            }
            else if (emulatorPath.Contains("ppsspp", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.ppsspp;
            }
            else if (emulatorPath.Contains("duckstation", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.duckstation;
            }
            else if (emulatorPath.Contains("duckstation-uwp", System.StringComparison.CurrentCultureIgnoreCase))
            {
                EmulatorType = EEmulatorType.duckstation_uwp;
            }
            else
            {
                // Let it default to retroarch if no match is found
                EmulatorType = EEmulatorType.retroarch;
            }
        }

        public Platform Copy()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

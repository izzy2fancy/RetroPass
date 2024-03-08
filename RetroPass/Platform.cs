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
        public PlatformEmulatorType EmulatorType { get; set; }
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
    EmulatorType = PlatformEmulatorType.retroarch;
    return;
}

if (emulatorPath.Contains("pcsx2", System.StringComparison.CurrentCultureIgnoreCase) ||
    emulatorPath.Contains("xbsx2", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.xbsx2;
}
else if (emulatorPath.Contains("retrix", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.rgx;
}
else if (emulatorPath.Contains("dolphin", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.dolphin;
}
else if (emulatorPath.Contains("xenia-canary", System.StringComparison.CurrentCultureIgnoreCase) ||
         emulatorPath.Contains("xeniacanary", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.xeniacanary;
}
else if (emulatorPath.Contains("xenia", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.xenia;
}
else if (emulatorPath.Contains("ppsspp", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.ppsspp;
}
else if (emulatorPath.Contains("duckstation", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.duckstation;
}
else if (emulatorPath.Contains("duckstation-uwp", System.StringComparison.CurrentCultureIgnoreCase))
{
    EmulatorType = PlatformEmulatorType.duckstationuwp;
}
else
{
    // Let it default to retroarch if no match is found
    EmulatorType = PlatformEmulatorType.retroarch;
}
        public Platform Clone()
        {
            return (Platform)this.MemberwiseClone();
        }
    }
}

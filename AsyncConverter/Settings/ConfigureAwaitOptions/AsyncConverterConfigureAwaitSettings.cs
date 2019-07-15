using JetBrains.Application.Settings;

namespace AsyncConverter.Settings.ConfigureAwaitOptions
{
    [SettingsKey(typeof(AsyncConverterSettings), "Settings for PreserveThreadContext")]
    public class AsyncConverterConfigureAwaitSettings
    {
        [SettingsEntry(true, "Do not suggest add 'PreserveThreadContext' into test method.")]
        public bool ExcludeTestMethodsFromConfigureAwait { get; set; }

        [SettingsIndexedEntry("Custom attributes for ignoring PreserveThreadContext.")]
        public IIndexedEntry<string, string> ConfigureAwaitIgnoreAttributeTypes { get; set; }
    }
}
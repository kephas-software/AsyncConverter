using JetBrains.Application.UI.Options;
using JetBrains.Application.UI.Options.OptionsDialog;
using JetBrains.ReSharper.Feature.Services.Daemon.OptionPages;
using JetBrains.ReSharper.Feature.Services.Resources;

namespace AsyncConverter.Settings
{
    [OptionsPage(PID, "Async Analyzer", typeof(ServicesThemedIcons.FileStorage), ParentId = CodeInspectionPage.PID)]
    public sealed class AsyncAnalyzerPage : AEmptyOptionsPage
    {
        public const string PID = "AsyncAnalyzer";
    }
}
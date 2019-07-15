using System.Collections.Generic;
using AsyncConverter.Highlightings;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Feature.Services.Intentions;
using JetBrains.ReSharper.Feature.Services.QuickFixes;
using JetBrains.Util;

namespace AsyncConverter.QuickFixes
{
    [QuickFix]
    public class PreserveThreadContextQuickFix : IQuickFix
    {
        private readonly PreserveThreadContextHighlighting preserveThreadContextHighlighting;

        public PreserveThreadContextQuickFix(PreserveThreadContextHighlighting preserveThreadContextHighlighting)
        {
            this.preserveThreadContextHighlighting = preserveThreadContextHighlighting;
        }


        public bool IsAvailable(IUserDataHolder cache)
        {
            return this.preserveThreadContextHighlighting.IsValid();
        }

        public IEnumerable<IntentionAction> CreateBulbItems()
        {
            return new []
                   {
                       new PreserveThreadContextAction(this.preserveThreadContextHighlighting),
                   }.ToQuickFixIntentions();
        }
    }
}
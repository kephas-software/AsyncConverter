using AsyncConverter.QuickFixes;

namespace AsyncConverter.Tests.QuickFixes
{
    public class PreserveThreadContextQuickFixTests : QuickFixBaseTests<PreserveThreadContextQuickFix>
    {
        protected override string Folder => @"PreserveThreadContext";
    }
}
using System;
using AsyncConverter.Highlightings;
using JetBrains.Application.Progress;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl;

namespace AsyncConverter.QuickFixes
{
    public class PreserveThreadContextAction : BulbActionBase
    {
        private readonly PreserveThreadContextHighlighting preserveThreadContextHighlighting;

        public PreserveThreadContextAction(PreserveThreadContextHighlighting preserveThreadContextHighlighting)
        {
            this.preserveThreadContextHighlighting = preserveThreadContextHighlighting;
        }
        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            var awaitExpression = this.preserveThreadContextHighlighting.AwaitExpression;
            var factory = CSharpElementFactory.GetInstance(awaitExpression);
            var taskWithConfiguring = factory.CreateExpression($"$0.PreserveThreadContext()", awaitExpression.Task);
            awaitExpression.Task.ReplaceBy(taskWithConfiguring);
            return null;
        }

        public override string Text => $"Add PreserveThreadContext()";
    }
}
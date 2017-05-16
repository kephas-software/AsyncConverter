using System.Linq;
using AsyncConverter.AsyncHelpers.Checker;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace AsyncConverter.Helpers
{
    [SolutionComponent]
    public class AwaitEliderChecker : IAwaitEliderChecker
    {
        private readonly ILastNodeChecker lastNodeChecker;

        public AwaitEliderChecker(ILastNodeChecker lastNodeChecker)
        {
            this.lastNodeChecker = lastNodeChecker;
        }

        public bool CanElide(IParametersOwnerDeclaration element)
        {
            var awaitExpressions = element.DescendantsInScope<IAwaitExpression>().ToArray();

            //TODO: think about this, different settings
            if (awaitExpressions.Length != 1)
                return false;

            var awaitExpression = awaitExpressions.First();
            if (!lastNodeChecker.IsLastNode(awaitExpression))
                return false;

            return true;
        }
    }
}
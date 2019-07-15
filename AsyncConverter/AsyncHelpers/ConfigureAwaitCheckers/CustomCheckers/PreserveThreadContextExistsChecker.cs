using System.Linq;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace AsyncConverter.AsyncHelpers.ConfigureAwaitCheckers.CustomCheckers
{
    [SolutionComponent]
    public class PreserveThreadContextExistsChecker : IConfigureAwaitCustomChecker
    {
        public bool CanBeAdded(IAwaitExpression element)
        {
            var type = element.Task.Type();
            if (type.IsTask() || type.IsGenericTask())
                return true;

            var resolveResult = (type as IDeclaredType)?.Resolve();
            var typeElement = resolveResult?.DeclaredElement as ITypeElement;
            return typeElement?.Methods.Any(x => x.ShortName == "PreserveThreadContext" && x.Parameters.Count == 0) == true;
        }
    }
}
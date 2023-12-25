using DryIoc.FastExpressionCompiler.LightExpression;
using NUnit.Framework;

namespace DryIoc.IssuesTests
{
    [TestFixture]
    public class GHIssue173_Validate_method_throws_TypeInitializationException_for_OpenGenericTypeKey : ITest
    {
        public int Run()
        {
            Test();
            return 1;
        }

        [Test]
        public void Test()
        {
            var key = new ResolutionKeyAndRequiredOpenGenericType(GetType(), "the-key");

            var expr = key.ToExpression(k => Expression.Constant(k));

            Assert.IsNotNull(expr);
        }
    }
}
using NUnit.Framework;
using System;
using System.Activities.Statements;

namespace GigHub.IntegrationTests
{
    public class Isolated : Attribute, ITestAction
    {
        private TransactionScope _transactionScope;
        public void BeforeTest(TestDetails testDetails)
        {
            _transactionScope = new TransactionScope();
        }

        public void AfterTest(TestDetails testDetails)
        {
            _transactionScope.Dispose();
            // return this(testDetails);
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }
    }
}

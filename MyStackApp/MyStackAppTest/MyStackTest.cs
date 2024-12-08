using MyStackApp;
using NUnit.Framework;

namespace MyStackAppTest
{
    [TestFixture]
    public class MyStackTest
    {
        
        [Test]
        public async Task IsEmptyTest()
        {
            var stack = new MyStack();
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public async Task PushOneItem()
        {
            var stack = new MyStack();
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(1, stack.Size());

        }

        [Test]
        public async Task PushThreeItem()
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(3, stack.Size());

        }

        [Test]
        public async Task PopOneItem()
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(2, stack.Size());

        }



        #region extra
        /*private MyStack _myStack;
        [SetUp]
        public void Setup()
        {
            _myStack = new MyStack();
        }
        [Test]
        public void DoSomethingTest()
        {
            _myStack.DoSomething();

        }*/
        #endregion


    }
}

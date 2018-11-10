using NUnit.Framework;

namespace StackUI.Tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_IsExeption()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_IsAdded()
        {
            var stack = new Stack<string>();
            stack.Push("coś nie string");
            Assert.That(() => stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_IsExeption()
        {
            var stack = new Stack<string>();            
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_GetsResultAndDeleteFromList()
        {
            var stack = new Stack<string>();
            stack.Push("5");
            stack.Push("6");
            stack.Push("7");
            Assert.That(() => stack.Pop(), Is.EqualTo("7"));
            Assert.That(() => stack.Count, Is.EqualTo(2));
        }
        //Peek

        [Test]
        public void Peek_IsExeption()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_GetsResultAndDeleteFromList()
        {
            var stack = new Stack<string>();
            stack.Push("5");
            stack.Push("6");
            stack.Push("7");
            Assert.That(() => stack.Peek(), Is.EqualTo("7"));
            Assert.That(() => stack.Peek(), Is.EqualTo("7"));
            Assert.That(() => stack.Count, Is.EqualTo(3));
        }
    }
}

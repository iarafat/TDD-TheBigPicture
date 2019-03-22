using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes.Library;
using System;

namespace Classes.Tests
{
    [TestClass]
    public class StackGenericTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyGenericStack<string>();
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopOffMultipleItems()
        {
            var stack = new MyGenericStack<string>();
            stack.Push("foo");
            stack.Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }
    }
}
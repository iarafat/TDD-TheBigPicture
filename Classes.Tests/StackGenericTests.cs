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
            var stack = new MyGenericStack<string>()
            .Push("foo")
            .Push("bar");
            
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }
        
        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            var stack = new MyGenericStack<string>();
            Assert.AreEqual(null, stack.Pop());
        }
        
    }
}
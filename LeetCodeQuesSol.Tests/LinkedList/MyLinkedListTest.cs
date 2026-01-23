using LeetCodeQuesSol.LinkedList;
using Xunit;

namespace LeetCodeQuesSol.Tests.LinkedList
{
    public class MyLinkedListTest
    {
        [Fact]
        public void Test_AddAtHead()
        {
            var list = new MyLinkedList();
            list.AddAtHead(10);
            Assert.Equal(10, list.Get(0));
            list.AddAtHead(20);
            Assert.Equal(20, list.Get(0));
            Assert.Equal(10, list.Get(1));
        }

        [Fact]
        public void Test_AddAtTail()
        {
            var list = new MyLinkedList();
            list.AddAtTail(1);
            Assert.Equal(1, list.Get(0));
            list.AddAtTail(2);
            Assert.Equal(2, list.Get(1));
        }

        [Fact]
        public void Test_AddAtIndex()
        {
            var list = new MyLinkedList();
            list.AddAtHead(1); // [1]
            list.AddAtTail(3); // [1,3]
            list.AddAtIndex(1, 2); // [1,2,3]
            Assert.Equal(1, list.Get(0));
            Assert.Equal(2, list.Get(1));
            Assert.Equal(3, list.Get(2));
            list.AddAtIndex(0, 0); // [0,1,2,3]
            Assert.Equal(0, list.Get(0));
        }

        [Fact]
        public void Test_DeleteAtIndex()
        {
            var list = new MyLinkedList();
            list.AddAtHead(1);
            list.AddAtTail(2);
            list.AddAtTail(3); // [1,2,3]
            list.DeleteAtIndex(1); // [1,3]
            Assert.Equal(1, list.Get(0));
            Assert.Equal(3, list.Get(1));
            Assert.Equal(-1, list.Get(2)); // Out of bounds
        }

        [Fact]
        public void Test_Get()
        {
            var list = new MyLinkedList();
            Assert.Equal(-1, list.Get(0)); // Empty list
            list.AddAtHead(5);
            Assert.Equal(5, list.Get(0));
            Assert.Equal(-1, list.Get(1)); // Out of bounds
        }
    }
}

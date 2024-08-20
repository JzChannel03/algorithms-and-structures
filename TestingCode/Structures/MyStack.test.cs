using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures;

namespace TestingCode.Structures
{
    public class MyStackTest
    {
        [Fact]
        public void Push_AddsElementToStack()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act
            stack.Push(1);

            // Assert
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void Pop_RemovesAndReturnsLastElement()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void Peek_ReturnsLastElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(2, stack.Pop()); // Asegura que el elemento aún esté en la pila
        }

        [Fact]
        public void Pop_ThrowsException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Peek_ThrowsException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
    }
}

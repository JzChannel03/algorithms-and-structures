using Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode.Structures
{
    public class MyListTests
    {
        [Fact]
        public void Add_AddsElementToList_WhenListIsEmpty()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);

            // Assert
            Assert.NotNull(list.first);
            Assert.Equal(1, list.first.value);
        }

        [Fact]
        public void Add_AddsElementToEndOfList_WhenListIsNotEmpty()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Add(3);

            // Assert
            var secondElement = list.first.next;
            var thirdElement = secondElement.next;

            Assert.Equal(3, thirdElement.value);
            Assert.Null(thirdElement.next);
        }

        [Fact]
        public void ForEach_IteratesOverAllElementsInList()
        {
            // Arrange
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            var output = new System.Collections.Generic.List<int>();

            // Redirect the Console output
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                list.ForEach();
                output = consoleOutput.GetOutput().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
                                  .Where(line => line.StartsWith("Value:"))
                                  .Select(line => int.Parse(line.Substring(7)))
                                  .ToList();
            }

            // Assert
            Assert.Equal(new[] { 1, 2, 3 }, output);
        }

        [Fact]
        public void ForEach_DoesNothing_WhenListIsEmpty()
        {
            // Arrange
            var list = new MyList<int>();

            // Redirect the Console output
            using (var consoleOutput = new ConsoleOutput())
            {
                // Act
                list.ForEach();
                var output = consoleOutput.GetOutput();

                // Assert
                Assert.True(string.IsNullOrEmpty(output));
            }
        }
    }

    // Helper class to capture console output
    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter stringWriter;
        private readonly System.IO.TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new System.IO.StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOutput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}

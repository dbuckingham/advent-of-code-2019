using Microsoft.VisualStudio.TestTools.UnitTesting;
using day02.Common;
using System.Collections.Generic;

namespace day02.Tests
{
    [TestClass]
    public class IntcodeIntrepreterTests
    {
        [TestMethod]
        public void Run_addition_opcode_test()
        {
            // Arrange
            var instructions = new int[] {1, 5, 6, 7, 99, 1, 1, 0};

            // Act
            var results = IntcodeInterpreter.Run(instructions);
            
            foreach(int item in results)
            {
                System.Diagnostics.Debug.Write($"{item}, ");
            }

            // Assert
            Assert.IsTrue(instructions[5] == 1);
            Assert.IsTrue(instructions[6] == 1);
            Assert.IsTrue(instructions[7] == 2);
        }

        [TestMethod]
        public void Run_multiplication_opcode_test()
        {
            // Arrange
            var instructions = new int[] {2, 5, 6, 7, 99, 2, 2, 0};

            // Act
            var results = IntcodeInterpreter.Run(instructions);
            
            PrintInstructions(results);

            // Assert
            Assert.IsTrue(instructions[5] == 2);
            Assert.IsTrue(instructions[6] == 2);
            Assert.IsTrue(instructions[7] == 4);
        }

        [TestMethod]
        public void Run_example_program_test()
        {
            // Arrange
            var instructions = new int[] {1,9,10,3,2,3,11,0,99,30,40,50};

            // Act
            var results = IntcodeInterpreter.Run(instructions);
            
            PrintInstructions(results);

            // Assert
            Assert.IsTrue(results[0] == 3500);
            Assert.IsTrue(results[1] == 9);
            Assert.IsTrue(results[2] == 10);
            Assert.IsTrue(results[3] == 70);
            Assert.IsTrue(results[4] == 2);
            Assert.IsTrue(results[5] == 3);
            Assert.IsTrue(results[6] == 11);
            Assert.IsTrue(results[7] == 0);
            Assert.IsTrue(results[8] == 99);
            Assert.IsTrue(results[9] == 30);
            Assert.IsTrue(results[10] == 40);
            Assert.IsTrue(results[11] == 50);
        }
        
        [TestMethod]
        public void Run_sample_3_program_test()
        {
            // Arrange
            var instructions = new int[] {2,4,4,5,99,0};

            // Act
            var results = IntcodeInterpreter.Run(instructions);
            
            PrintInstructions(results);

            // Assert
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Run_sample_4_program_test()
        {
            // Arrange
            var instructions = new int[] {1,1,1,4,99,5,6,0,99};

            // Act
            var results = IntcodeInterpreter.Run(instructions);
            
            PrintInstructions(results);

            // Assert
            Assert.IsTrue(instructions[0] == 30);
            Assert.IsTrue(instructions[1] == 1);
            Assert.IsTrue(instructions[2] == 1);
            Assert.IsTrue(instructions[3] == 4);
            Assert.IsTrue(instructions[4] == 2);
            Assert.IsTrue(instructions[5] == 5);
            Assert.IsTrue(instructions[6] == 6);
            Assert.IsTrue(instructions[7] == 0);
            Assert.IsTrue(instructions[8] == 99);
        }

        private void PrintInstructions(IList<int> instructions)
        {
            foreach(int item in instructions)
            {
                System.Diagnostics.Debug.Write($"{item}, ");
            } 
        }
    }
}

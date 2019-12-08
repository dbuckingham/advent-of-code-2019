using System;
using System.Collections.Generic;

namespace day02.Common
{
    public class IntcodeInterpreter
    {
        private const int TERMINATING_VALUE = 99;
        public static IList<int> Run(IList<int> instructions)
        {
            var offset = 0;
            var opcode = instructions[offset];

            while(opcode != TERMINATING_VALUE)
            {
                var position1 = instructions[++offset];
                var position2 = instructions[++offset];
                var position3 = instructions[++offset];

                System.Diagnostics.Debug.WriteLine($"opcode = {opcode}, pos1 = {position1}, pos2 = {position2}, pos3 = {position3}");

                var runner = OpcodeRunnerFactory.Generate(opcode);
                var result = runner.Run(instructions[position1], instructions[position2]);

                System.Diagnostics.Debug.WriteLine($"Using IOpcodeRunner of type {runner.GetType().ToString()}");

                instructions[position3] = result;

                opcode = instructions[++offset];
                System.Diagnostics.Debug.WriteLine($"opcode = {opcode}");
            }

            return instructions;
        }
    }

    internal class OpcodeRunnerFactory
    {
        private const int ADDITION_OPCODE = 1;
        private const int MULTIPLCATION_OPCODE = 2;

        public static IOpcodeRunner Generate(int opcode)
        {
            switch(opcode)
            {
                case ADDITION_OPCODE:
                    return new AdditionOpcodeRunner();

                case MULTIPLCATION_OPCODE:
                    return new MultiplicationOpcodeRunner();

                default:
                    throw new Exception($"Opcode {opcode} is not supported.");
            }
        }
    }
}

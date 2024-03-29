﻿using System;
using System.Collections.Generic;

namespace day02.Common
{
    public class IntcodeInterpreter
    {
        private const int TERMINATING_VALUE = 99;
        public static IList<int> Run(IList<int> instructions)
        {
            var instructionPointer = 0;
            var opcode = instructions[instructionPointer];

            while(opcode != TERMINATING_VALUE)
            {
                var parameter1 = instructions[++instructionPointer];
                var parameter2 = instructions[++instructionPointer];
                var parameter3 = instructions[++instructionPointer];

                System.Diagnostics.Debug.WriteLine($"opcode = {opcode}, param1 = {parameter1}, param2 = {parameter2}, param3 = {parameter3}");

                var runner = OpcodeRunnerFactory.Generate(opcode);
                var result = runner.Run(instructions[parameter1], instructions[parameter2]);

                System.Diagnostics.Debug.WriteLine($"Using IOpcodeRunner of type {runner.GetType().ToString()}");

                instructions[parameter3] = result;

                opcode = instructions[++instructionPointer];
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

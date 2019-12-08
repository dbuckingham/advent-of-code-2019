namespace day02.Common
{
    internal class AdditionOpcodeRunner : IOpcodeRunner
    {
        public int Run(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
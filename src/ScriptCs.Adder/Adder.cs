using ScriptCs.Contracts;
namespace ScriptCs.Adder
{
    public class Adder : IScriptPackContext
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

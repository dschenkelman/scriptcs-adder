using ScriptCs.Contracts;

namespace ScriptCs.Adder
{
    public class AdderScriptPack : IScriptPack
    {
        public IScriptPackContext GetContext()
        {
            return new Adder();
        }

        public void Initialize(IScriptPackSession session)
        {
        }

        public void Terminate()
        {
        }
    }
}

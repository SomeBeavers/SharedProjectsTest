namespace SharedProject
{
    internal abstract class FU1_Shared
    {

        public abstract bool CheckAnalyzers(string baseDirectory);
    }

    internal sealed class FU1_Shared_Derived1 : FU1_Shared
    {
        public override bool CheckAnalyzers(string baseDirectory)
        {
            return false;
        }
    }
    internal sealed class FU1_Shared_Derived2 : FU1_Shared
    {
        public override bool CheckAnalyzers(string baseDirectory)
        {
            return false;
        }
    }
}
using SharedProject;

namespace FrameworkReferencingShared2
{
    internal sealed class FU_Framework2 : FU1_Shared
    {
        public override bool CheckAnalyzers(string baseDirectory)
        {
            return true;
        }
    }

}
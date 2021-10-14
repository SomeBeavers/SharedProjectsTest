using SharedProject;

namespace FrameworkReferencingShared1
{
    internal sealed class FU_Framework1 : FU1_Shared
    {
        public override bool CheckAnalyzers(string baseDirectory)
        {
            return false;
        }
    }
}
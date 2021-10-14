using SharedProject;

namespace FrameworkReferencingShared1
{
    internal sealed class FU2_Framework1 : FU1_Shared
    {
        public override bool CheckAnalyzers(string baseDirectory)
        {
            FU2_Shared.CheckAnalyzers("");
            return false;
        }
    }
}
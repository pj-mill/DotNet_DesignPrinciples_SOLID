using LiskovSubstitutionPrinciple.Solution.Abstract;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class UserSettings : IReadSettings, IWriteSettings
    {
        public void Load()
        {
            // Simulate implementation here
        }

        public void Persist()
        {
            // Simulate implementation here
        }
    }
}

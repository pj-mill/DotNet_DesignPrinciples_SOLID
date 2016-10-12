using InterfaceSegregationPrinciple.Solution.Abstract;

namespace InterfaceSegregationPrinciple.Solution
{
    public class ApplicationSettings : IReadSettings, IWriteSettings
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

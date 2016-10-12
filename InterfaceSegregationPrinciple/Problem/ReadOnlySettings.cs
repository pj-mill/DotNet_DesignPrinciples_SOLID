using InterfaceSegregationPrinciple.Problem.Abstract;
using System;

namespace InterfaceSegregationPrinciple.Problem
{
    public class ReadOnlySettings : ISettings
    {
        public void Load()
        {
            // Simulate implementation here
        }

        public void Persist()
        {
            // Problem Here, As this only needs to read settings, this method is not required
            throw new NotImplementedException();
        }
    }
}

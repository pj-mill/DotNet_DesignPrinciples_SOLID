using LiskovSubstitutionPrinciple.Problem.Abstract;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Problem
{
    public class Problem
    {
        public static void Run()
        {
            List<ISettings> settings = new List<ISettings>();

            settings.Add(new ApplicationSettings());
            settings.Add(new UserSettings());
            settings.Add(new ReadOnlySettings());

            // Load settings
            foreach (var setting in settings)
            {
                setting.Load();
            }

            // Persist settings
            // This will throw an error for 'ReadOnlySettings' instance because it does not implement the 'Persist' method
            foreach (var setting in settings)
            {
                setting.Persist();
            }
        }
    }
}

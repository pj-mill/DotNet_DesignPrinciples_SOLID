using InterfaceSegregationPrinciple.Solution.Abstract;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Solution
{
    public class Solution
    {
        public static void Run()
        {
            List<IReadSettings> readSettings = new List<IReadSettings>(); // Read only settings

            readSettings.Add(new ApplicationSettings());
            readSettings.Add(new UserSettings());
            readSettings.Add(new ReadOnlySettings());

            // Load settings
            foreach (var setting in readSettings)
            {
                setting.Load();
            }

            // Persist settings
            // Will not compile because none of these instances contain the 'Persist' method
            foreach (var setting in readSettings)
            {
                //setting.Persist();
            }


            //--------------------------------------------------------------------------------------


            List<IWriteSettings> writeSettings = new List<IWriteSettings>(); // Write only settings

            writeSettings.Add(new ApplicationSettings());
            writeSettings.Add(new UserSettings());
            // writeSettings.Add(new ReadOnlySettings()); This will no longer compile

            // Load settings
            foreach (var setting in writeSettings)
            {
                // setting.Load();                  This will no longer compile
            }

            // Persist settings
            // Will not compile because none of these instances contain the 'Persist' method
            foreach (var setting in writeSettings)
            {
                setting.Persist();
            }
        }
    }
}

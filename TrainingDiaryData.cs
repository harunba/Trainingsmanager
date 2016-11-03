using System.Collections.Generic;

namespace Trainingsmanager
{
    public class TrainingDiaryData
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public List<TrainingData> Sets { get; set; }
    }
}

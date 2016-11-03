using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainingsmanager
{
    public class TrainingData
    {
        public string Focus { get; set; }

        public string DayName { get; set; }

        public DateTime Date { get; set; }

        public List<ExerciseData> Exercises { get; set; }

    }
}

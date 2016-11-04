using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Trainingsmanager
{
    /// <summary>
    /// Interaction logic for Exercise.xaml
    /// </summary>
    public partial class Exercise : UserControl
    {
        public Exercise()
        {
            InitializeComponent();
        }

        public ExerciseData GetExerciseData()
        {
            var myExerciseData = new ExerciseData();
            myExerciseData.Name = exerciseName.Text;
            myExerciseData.Reps = exerciseReps.Text;
            myExerciseData.Sets = exerciseSets.Text;
            myExerciseData.Weight = exerciseWeight.Text;
   
            return myExerciseData;
        }
    }
}

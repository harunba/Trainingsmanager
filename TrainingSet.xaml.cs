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
    /// Interaction logic for TrainingSet.xaml
    /// </summary>
    public partial class TrainingSet : UserControl
    {
        public TrainingSet()
        {
            InitializeComponent();
        }

        public string DayName {
            get
            {
                return (string)dayLabel.Content;
            }
            set
            {
                dayLabel.Content = value;
            }}

        public TrainingData GetTrainingData()
        {
            var myTrainingData = new TrainingData();
            myTrainingData.DayName = DayName;
            var mySelectedItem = (ComboBoxItem)focusComboBox.SelectedItem;
            if(mySelectedItem != null)
            {
                myTrainingData.Focus = (string)mySelectedItem.Content;
            }
            
            myTrainingData.Exercises = new List<ExerciseData>();
            var firstExerciseData = firstExercise.GetExerciseData();
            myTrainingData.Exercises.Add(firstExerciseData);
            var secondExerciseData = secondExercise.GetExerciseData();
            myTrainingData.Exercises.Add(secondExerciseData);
            var thirdExerciseData = thirdExercise.GetExerciseData();
            myTrainingData.Exercises.Add(thirdExerciseData);
            var fourthExerciseData = fourthExercise.GetExerciseData();
            myTrainingData.Exercises.Add(fourthExerciseData);
            var fifthExerciseData = fifthExercise.GetExerciseData();
            myTrainingData.Exercises.Add(fifthExerciseData);
            return myTrainingData;
        }

        public void SetTrainingData(TrainingData trainingData)
        {
            firstExercise.SetExercise(trainingData.Exercises[0]);
            secondExercise.SetExercise(trainingData.Exercises[1]);
            thirdExercise.SetExercise(trainingData.Exercises[2]);
            fourthExercise.SetExercise(trainingData.Exercises[3]);
            fifthExercise.SetExercise(trainingData.Exercises[4]);


        }
    }

    
}

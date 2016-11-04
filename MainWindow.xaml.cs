using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Trainingsmanager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            var isChosen = saveFileDialog.ShowDialog();
            if (isChosen == true)
            {
                var myDiary = new TrainingDiaryData();
                myDiary.FirstName = Firstnamebox.Text;
                myDiary.LastName = Lastnamebox.Text;
                myDiary.Sets = new List<TrainingData>();
                var mondaySet = mondayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(mondaySet);
                var tuesdaySet = tuesdayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(tuesdaySet);
                var wednesdayset = wednesdayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(wednesdayset);
                var thursdaySet = thursdayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(thursdaySet);
                var fridaySet = fridayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(fridaySet);
                var saturdaySet = saturdayTrainingSet.GetTrainingData();

                myDiary.Sets.Add(saturdaySet);
                var sundaySet = sundayTrainingSet.GetTrainingData();
                myDiary.Sets.Add(sundaySet);
                string json = JsonConvert.SerializeObject(myDiary);

                //write string to file
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);
            }
            
        }

        private void Button_Click1(object reciever, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var isChosen = openFileDialog.ShowDialog();
            if (isChosen == true) {
                var content = File.ReadAllText(openFileDialog.FileName);
                var myDiary = JsonConvert.DeserializeObject<TrainingDiaryData>(content);
                Firstnamebox.Text = myDiary.FirstName;
                Lastnamebox.Text = myDiary.LastName;
                mondayTrainingSet.SetTrainingData(myDiary.Sets[0]);
                tuesdayTrainingSet.SetTrainingData(myDiary.Sets[1]);
                wednesdayTrainingSet.SetTrainingData(myDiary.Sets[2]);
                thursdayTrainingSet.SetTrainingData(myDiary.Sets[3]);
                fridayTrainingSet.SetTrainingData(myDiary.Sets[4]);
                saturdayTrainingSet.SetTrainingData(myDiary.Sets[5]);
                sundayTrainingSet.SetTrainingData(myDiary.Sets[6]);


            }
        }
    }
   
}

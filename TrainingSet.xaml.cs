﻿using System;
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
            return myTrainingData;
        }
    }

    
}

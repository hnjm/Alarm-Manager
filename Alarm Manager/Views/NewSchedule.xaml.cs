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
using Alarm_Manager.ViewModel;
using MahApps.Metro.Controls;

namespace Alarm_Manager
{
    /// <summary>
    /// Interaction logic for NewAlarm.xaml
    /// </summary>
    public partial class NewSchedule 
    {
        public NewSchedule()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            (new ViewModelLocator()).Main.NewScheduleFlyoutStatus = false;
        }
    }
}
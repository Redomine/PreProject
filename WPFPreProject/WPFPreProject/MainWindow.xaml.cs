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

namespace WPFPreProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        ApplicationContext db;



        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();


            List<building> buildingRows = db.buildings.ToList();

            string data = "";
            foreach (building buildingRow in buildingRows)
                data += buildingRow.buildingName + "  |  ";

            dataDisplay.Text = data;

        }
    }
}

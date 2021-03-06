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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel view = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = view;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            view.Add_color_to_list();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            view.RemoveSelectedColor();
        }
    }
}

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
using System.Windows.Shapes;

namespace PL.Engineer
{
    /// <summary>
    /// Interaction logic for EngineerListWindow.xaml
    /// </summary>
    public partial class EngineerListWindow : Window
    {
        public EngineerListWindow()
        {
            InitializeComponent();
        }

        private void AddItemEngineerButton_Click(object sender, RoutedEventArgs e)
        {
            // פתיחת חלון חדש (לדוגמה, אפשר להשתמש בתיבת דו-שיח פשוטה)
            AddEngineerWindow addItemWindow = new AddEngineerWindow();
            addItemWindow.ShowDialog();

            // כאן תוכל לטפל במידע שהוסף לרשימה או לעשות כל פעולה נדרשת לאחר סגירת החלון החדש
        }
    }
}


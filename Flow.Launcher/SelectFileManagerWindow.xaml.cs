﻿using Flow.Launcher.Infrastructure.UserSettings;
using Flow.Launcher.ViewModel;
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
using System.Windows.Shapes;

namespace Flow.Launcher
{
    /// <summary>
    /// SelectFileManagerWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SelectFileManagerWindow : Window
    {
        public Settings Settings { get; }

        public SelectFileManagerWindow(Settings settings)
        {
            Settings = settings;
            InitializeComponent();
        }
    }
}

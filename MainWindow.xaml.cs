
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

using SteamWorkshopLib;

namespace Launcher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WinResize winResize = new WinResize(this);
        }

        private void Exit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            this.startgame.Foreground = new SolidColorBrush(Color.FromArgb(255, 164, 164, 164));
        }

        private void startgame_MouseLeave(object sender, MouseEventArgs e)
        {
            this.startgame.Foreground = new SolidColorBrush(Color.FromArgb(255, 230, 230, 230));
        }
    }
}

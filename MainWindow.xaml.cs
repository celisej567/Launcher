
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
using System.Media;
using System.IO;

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


            RandomSound();


        }

        private void startgame_MouseLeave(object sender, MouseEventArgs e)
        {
            this.startgame.Foreground = new SolidColorBrush(Color.FromArgb(255, 230, 230, 230));
        }

        private void Exit_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Exit.Visibility = Visibility.Hidden;
            this.BiggerExit.Visibility = Visibility.Visible;
        }

        private void Exit_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Exit.Visibility = Visibility.Visible;
            this.BiggerExit.Visibility = Visibility.Hidden;
        }

        private void BiggerHide_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Hide_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Hide.Visibility = Visibility.Hidden;
            this.BiggerHide.Visibility = Visibility.Visible;
        }

        private void Hide_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Hide.Visibility = Visibility.Visible;
            this.BiggerHide.Visibility = Visibility.Hidden;
        }

        private void Exit_enter(object sender, MouseEventArgs e)
        {
            
            this.exitgame.Foreground = new SolidColorBrush(Color.FromArgb(255, 164, 164, 164));
            RandomSound();
             
        }

        private void Exit_leave(object sender, MouseEventArgs e)
        {
            this.exitgame.Foreground = new SolidColorBrush(Color.FromArgb(255, 230, 230, 230));
        }



        public void RandomSound()
        {
            Random rnd = new Random();
            int sound = rnd.Next(0, 20);
            UnmanagedMemoryStream[] rndsong =
            {
                Properties.Resources._1,
                Properties.Resources._2,
                Properties.Resources._3,
                Properties.Resources._4,
                Properties.Resources._5,
                Properties.Resources._6,
                Properties.Resources._7,
                Properties.Resources._8,
                Properties.Resources._9,
                Properties.Resources._10,
                Properties.Resources._11,
                Properties.Resources._12,
                Properties.Resources._13,
                Properties.Resources._13,
                Properties.Resources._14,
                Properties.Resources._15,
                Properties.Resources._17,
                Properties.Resources._18,
                Properties.Resources._19,
                Properties.Resources._20,
                Properties.Resources._21
            };
            SoundPlayer sp = new SoundPlayer(rndsong[sound]);
            
            sp.Play();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

namespace Пр_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons = new Button[9];
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();


            buttons = [_1, _2, _3, _4, _5, _6, _7, _8, _9];

        }
        public void proverla_nicha()
        {
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == true)
            {
                tablo.Text = "Ничья";
                _1.IsEnabled = false;
            }
            if (_2.IsEnabled == true & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _2.IsEnabled = false;
            }
            if (_2.IsEnabled == false  & _3.IsEnabled == true & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _3.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == true & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _4.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == true & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _5.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == true & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _6.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == true & _8.IsEnabled == false & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _7.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == true & _9.IsEnabled == false & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _8.IsEnabled = false;
            }
            if (_2.IsEnabled == false & _3.IsEnabled == false & _4.IsEnabled == false & _5.IsEnabled == false & _6.IsEnabled == false & _7.IsEnabled == false & _8.IsEnabled == false & _9.IsEnabled == true & _1.IsEnabled == false)
            {
                tablo.Text = "Ничья";
                _9.IsEnabled = false;
            }

        }
        public void logic_krest()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;

            tablo.Text = "Крестики Wins\n  krestality";

        }
        public void logic_null()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;

            tablo.Text = "Нолики  Wins\n Nullity";
        }

        public void logic_innun()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;

        }
        public void yslovie_podeds()
        {

        }
        public void logic_clear()
        {
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";
            tablo.Text = " ";

        }

        private void Nachalo_click(object sender, RoutedEventArgs e)
        {


            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            logic_clear();


        }
        


        private void ckik(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "O";
            (sender as Button).IsEnabled = false;


            int index = random.Next(buttons.Length);
            while (buttons[index].IsEnabled == false)
            {
                index = random.Next(buttons.Length);

            }
            buttons[index].Content = "X";
            buttons[index].IsEnabled = false;
            if (_1.Content == "O" & _2.Content == "O" & _3.Content == "O")
            {


                logic_null();
            }
            else if (_1.Content == "X" & _2.Content == "X" & _3.Content == "X")
            {
                logic_krest();
            }
            else if (_4.Content == "O" & _5.Content == "O" & _6.Content == "O")
            {
                logic_null();
            }
            else if (_4.Content == "X" & _5.Content == "X" & _6.Content == "X")
            {
                logic_krest();
            }
           else  if (_7.Content == "O" & _8.Content == "O" & _9.Content == "O")
            {
                logic_null();
            }
            else if (_7.Content == "X" & _8.Content == "X" & _9.Content == "X")
            {
                logic_krest();
            }
           else if (_1.Content == "O" & _4.Content == "O" & _7.Content == "O")
            {
                logic_null();
            }
           else if (_1.Content == "X" & _4.Content == "X" & _7.Content == "X")
            {
                logic_krest();
            }
          else  if (_3.Content == "O" & _6.Content == "O" & _9.Content == "O")
            {
                logic_null();
            }
          else  if (_3.Content == "X" & _6.Content == "X" & _9.Content == "X")
            {
                logic_krest();
            }
          else  if (_1.Content == "O" & _5.Content == "O" & _9.Content == "O")
            {
                logic_null();
            }
          else  if (_1.Content == "X" & _5.Content == "X" & _9.Content == "X")
            {
                logic_krest();
            }
          else  if (_3.Content == "O" & _5.Content == "O" & _7.Content == "O")
            {
                logic_null();
            }
          else  if (_3.Content == "X" & _5.Content == "X" & _7.Content == "X")
            {
                logic_krest();
            }
           else if (_2.Content == "O" & _5.Content == "O" & _8.Content == "O")
            {
                logic_null();
            }
           else if (_2.Content == "X" & _5.Content == "X" & _8.Content == "X")
            {
                logic_krest();
            }
            proverla_nicha();

           



        }

        
    }
}

        



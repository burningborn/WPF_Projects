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

namespace SSP_Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SSP_Game You = new SSP_Game();
        private SSP_Game Computer = new SSP_Game();
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myMove_Click(object sender, RoutedEventArgs e)
        {
            youBox.Text = "";
            computerBox.Text = "";
            outText.Text = "";
        }
        public void resultFunc(SSP_Game one, SSP_Game two)
        {
            int key = SSP_Game.Fight(one, two);
            switch (key)
            {
                case 1:
                    outText.Text = "Вы выиграли";
                    break;
                case -1:
                    outText.Text = "Выиграл компьтер";
                    break;
                case 0:
                    outText.Text = "НИЧЬЯ";
                    break;
                default:
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Computer.Bones();
            computerBox.Text = Computer.status;
            do
            {
            You.Bones();
            }
            while (You.status == Computer.status);
            youBox.Text = You.status;

            resultFunc(You, Computer);
        }       
    }
}

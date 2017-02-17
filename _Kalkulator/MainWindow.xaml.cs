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

namespace _Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int x;
        public double pierwsza = 1;
        public double druga;
        public int y = 0;
        public void Dodawanie()
        {
            druga = Convert.ToDouble(Wyswietlacz.Text);
            pierwsza += druga;
            
        }
        public void Odejmowanie()
        {
            druga = Convert.ToDouble(Wyswietlacz.Text);
            pierwsza -= druga;
        }
        public void Mnozenie()
        {
            druga = Convert.ToDouble(Wyswietlacz.Text);
            pierwsza = pierwsza * druga;
        }
        public void Dzielenie()
        {
            druga = Convert.ToDouble(Wyswietlacz.Text);
            pierwsza = pierwsza / druga;
        }
   
           

        public MainWindow()
        {
            InitializeComponent();

        }


        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 1;
           
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 2;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 3;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 4;
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 6;
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 5;
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 7;
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 8;
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 9;

        }

        private void Bmnozenie_Click(object sender, RoutedEventArgs e)
        {   
            if (x==3)
            {
                x = 1;
            }
            else if (x == 5)
            {
                Dodawanie();
                x = 1;

                
            }
            else if (Wyswietlacz.Text=="")
            {
                x = 1;
                pierwsza = pierwsza * druga;
               

            }
            else if (x == 2)
            {
                Dzielenie();
                x = 1;
                
            }
            else if (x == 4)
            {
                x = 1;
                Odejmowanie();


            }
            else
            {

                x = 1;
                druga = Convert.ToDouble(Wyswietlacz.Text);
                pierwsza = pierwsza * druga;
            }
            Podwyswietlacz.Text = pierwsza.ToString();
                Wyswietlacz.Text += "*";
                Ekranik.Text += Wyswietlacz.Text;
            
                Wyswietlacz.Text = "";



                y = 1;
            
        }

        private void Bdzielenie_Click(object sender, RoutedEventArgs e)
        {
            if (x==3)
            {
                x = 1;
            }
           
            else if(x==5)
            {
                Dodawanie();
                x = 2;
            }
            else if (Wyswietlacz.Text == "")
            {
                x = 2;
                if (y == 0)
                {
                    pierwsza = druga;
                }
                else
                {
                    pierwsza = pierwsza / druga;
                }

                Podwyswietlacz.Text = pierwsza.ToString();
                Wyswietlacz.Text += ":";
                Ekranik.Text += Wyswietlacz.Text;

                Wyswietlacz.Text = "";
                y = 1;
            }
            else if (x == 4)
            {
                x = 2;
                Odejmowanie();


            }
            else if (x==1)
            {
                Mnozenie();
                x = 2;
            }
            else
            {
                x = 2;
                druga = Convert.ToDouble(Wyswietlacz.Text);
                if (y == 0)
                {
                    pierwsza = druga;
                }
                else
                {
                    pierwsza = pierwsza / druga;
                }
            }
          
           
           

            Podwyswietlacz.Text = pierwsza.ToString();
            Wyswietlacz.Text += ":";
            Ekranik.Text += Wyswietlacz.Text;
            
            Wyswietlacz.Text = "";
            y = 1;

        }

        private void Bprocent_Click(object sender, RoutedEventArgs e)
        {
            x = 3;
            druga = Convert.ToDouble(Wyswietlacz.Text);
            druga = druga * 0.01;
            pierwsza = pierwsza * druga;
            Podwyswietlacz.Text = pierwsza.ToString();
            Wyswietlacz.Text += "%";
            Ekranik.Text += Wyswietlacz.Text;
            Wyswietlacz.Text = "";
            y = 1;
        }

        private void Brownasie_Click(object sender, RoutedEventArgs e)
        {
            if (x==0)
            {
                pierwsza = 0;
                
            }
            else if ((Wyswietlacz.Text == "")&&(x==2))
            {
               
                pierwsza = pierwsza / druga;


            }
            else if ((Wyswietlacz.Text == "")&&(x==4))
            {

                pierwsza = pierwsza - druga;


            }
            else if ((Wyswietlacz.Text == "") && (x == 5))
            {

                pierwsza = pierwsza + druga;


            }
            else if ((Wyswietlacz.Text == "")&&(x==1))
            {
                
                pierwsza = pierwsza * druga;


            }
            else if (x == 3)
            {
                druga = Convert.ToDouble(Wyswietlacz.Text);
                druga = druga * 0.01;
                pierwsza += pierwsza * druga;
                
            }
            else if (x == 1)
            {
                Mnozenie();
                
            }
            else if (x == 4)
            {
                
                Odejmowanie();


            }
            else if (x == 2)
            {
                Dzielenie();
               

            }
            else
            {
                
                Dodawanie();
            }

            Wyswietlacz.Text += "=";
            Ekranik.Text += Wyswietlacz.Text;
            Podwyswietlacz.Text= pierwsza.ToString();
            Wyswietlacz.Text = "";
        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {

            if (x == 0)
            {
                
                druga = Convert.ToDouble(Wyswietlacz.Text);
                pierwsza = druga;
              
                x = 4;
            }
            else if (Wyswietlacz.Text == "")
            {

                pierwsza = pierwsza-druga;


            }
            else if(x == 3)
            {
                druga = Convert.ToDouble(Wyswietlacz.Text);
                druga = druga * 0.01;
                pierwsza -= pierwsza * druga;
            }
            else if (x == 2)
            {
                Dzielenie();
                x = 4;

            }
            else if (x == 1)
            {
                Mnozenie();
                x = 4;
            }
            else if (x == 5)
            {
                Dodawanie();
                x = 4;
            }
            else 
            {
                x = 4;
                Odejmowanie();

                
            }
          
            
            Podwyswietlacz.Text = pierwsza.ToString();
            Wyswietlacz.Text += "-";
            Ekranik.Text += Wyswietlacz.Text;
            Wyswietlacz.Text = "";
            y = 1; 
        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {

            if (x == 0)
            {
                pierwsza = 0;
            }
            if (x == 3)
            {
                druga = Convert.ToDouble(Wyswietlacz.Text);
                druga = druga * 0.01;
                pierwsza+=pierwsza*druga;
            }
            else if (Wyswietlacz.Text == "") 
            {

                pierwsza = pierwsza + druga;


            }
            else if (x == 1)
            {
                Mnozenie();
                x = 5; 
            }
            else if (x == 4)
            {
                x = 5;
                Odejmowanie();


            }
            else if (x == 2)
            {
                Dzielenie();
                x = 5;

            }
            else
            {
                x = 5;
                Dodawanie();
            }

           
            Podwyswietlacz.Text = pierwsza.ToString();
            Wyswietlacz.Text += "+";
            Ekranik.Text += Wyswietlacz.Text;
            Wyswietlacz.Text = "";
            y = 1;
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Podwyswietlacz.Text = "";
            Wyswietlacz.Text += 0;

        }

        private void Bprzecinek_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.Text += ",";
        }
        private void Bwyczyscwszystko_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.Text = "";
            Ekranik.Text = "";
            Podwyswietlacz.Text = "";
            pierwsza = 1;
            druga = 0;
            x = 0;
            y = 0;
        }

        private void Bwyczysc_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.Text = "";
        }
    }
}



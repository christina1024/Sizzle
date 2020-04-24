using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;




namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private int time = 15;
        private DispatcherTimer Timer;
        private int hours;
        private int minutes;
        private int seconds;
        private int trig = 0;
        Timer timer;

        public Page1()
        {
            InitializeComponent();           
        }

        private void Follow_Click(object sender, RoutedEventArgs e)
        {
            Follow.Content = Follow.Content == "Follow" ? "Following" : "Follow";
        }

        private void Quinoa_Click(object sender, RoutedEventArgs e)
        {
            if (QuinoaText.Text == "Red Quinoa")                
            {
                QuinoaText.Text = "White Quinoa";
            } else
            {
                QuinoaText.Text = "Red Quinoa";
            }
            
        }


        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            //hours = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            //minutes = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            //seconds = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            hours = 0;
            minutes = 10;
            seconds = 10;

            //label1.text = hours.tostring();
            //label2.text = minutes.tostring();
            //label3.text = seconds.tostring();
            if (trig == 0)
            {

            }
                timeLabel.Visibility = Visibility.Visible;
                TimerButton.Visibility = Visibility.Hidden;
                timer = new System.Timers.Timer(1000);
                timer.Elapsed += timer1_Tick; 
                //timer1.elapsed += new eventhandler(timer1_tick);
                trig = 1;
            //timer.Start();*/
            timeLabel.Visibility = Visibility.Visible;
            TimerButton.Visibility = Visibility.Hidden;
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
            if(time > 0)
            {
                if(time <= 10)
                {
                    if (time % 2 == 0)
                    {
                        timeLabel.Foreground = new SolidColorBrush(Color.FromRgb(251, 108, 108));
                    }
                    else {
                        timeLabel.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    }
                    time--;
                    if(time % 60 > 9) { timeLabel.Content ="00:00:"+ time % 60;}
                    else { timeLabel.Content = "00:00:0" + time % 60; }
                    

                }
                else
                {
                    time--;
                    if (time % 60 > 9) { timeLabel.Content = "00:00:" + time % 60; }
                    else { timeLabel.Content = "00:00:0" + time % 60; }
                }
            }

            if (time == 0)
            {
                stopTimer.Visibility = Visibility.Visible;
                stopTimerb.Visibility = Visibility.Visible;
            }
        }
        /*private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                if (minutes > 0 || hours > 0)
                {
                    if (minutes == 0)
                    {
                        if (hours >= 0)
                        {
                            hours = hours - 1;
                            minutes = 60;
                            if (hours < 0)
                            {
                                hours = 0;
                            }
                        }
                    }
                    minutes = minutes - 1;
                    seconds = 59;
                    var timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                    string tempstring = "";
                    tempstring += hours + ":" + minutes + ":" + seconds;
                    timeLabel.Content = tempstring;

                    //label1.Text = hours.ToString();
                    //label2.Text = minutes.ToString();
                    //label3.Text = seconds.ToString();
                    if (minutes < 0)
                    {
                        minutes = 0;
                    }

                }
                if (seconds < 0)
                {
                    seconds = 0;
                }

                timer.Stop();
            }
            string temp = "";
            temp += hours + ":" + minutes + ":" + seconds;
            timeLabel.Content = temp;

            //label1.Text = hours.ToString();
            //label2.Text = minutes.ToString();
            //label3.Text = seconds.ToString();
        }
        */
        private void Ingredients_Click(object sender, RoutedEventArgs e)
        {
            IngredientStack.BringIntoView();
        }

        private void Appliances_Click(object sender, RoutedEventArgs e)
        {
            ApplianceStack.BringIntoView();
        }

        private void Note_Click(object sender, RoutedEventArgs e)
        {
            NoteStack.BringIntoView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void textB_MouseEnter(object sender, MouseEventArgs e)
        {
            if (textB.Text == "Enter Keywords for Recipes")
            {
                textB.Text = "";

                textB.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void textB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (textB.Text == "")
            {
                textB.Text = "Enter Keywords for Recipes";

                textB.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void stopTimerb_Click(object sender, RoutedEventArgs e)
        {
            stopTimer.Visibility = Visibility.Hidden;
            stopTimerb.Visibility = Visibility.Hidden;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            a1.Visibility = Visibility.Hidden;
            s1.Visibility = Visibility.Visible;
            addlist();
        }

        private void Image_MouseDown_11(object sender, MouseButtonEventArgs e)
        {
            s1.Visibility = Visibility.Hidden;
            a1.Visibility = Visibility.Visible;
            sublist();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            a2.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Visible;
            addlist();
        }

        private void Image_MouseDown_22(object sender, MouseButtonEventArgs e)
        {
            s2.Visibility = Visibility.Hidden;
            a2.Visibility = Visibility.Visible;
            sublist();
        }
        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            a3.Visibility = Visibility.Hidden;
            s3.Visibility = Visibility.Visible;
            addlist();
        }

        private void Image_MouseDown_33(object sender, MouseButtonEventArgs e)
        {
            s3.Visibility = Visibility.Hidden;
            a3.Visibility = Visibility.Visible;
            sublist();
        }

        private void addlist() {
            var num = Convert.ChangeType(shoppingList.Content, typeof(int)) as int?;
            num++;
            shoppingList.Content = num;
        }
        private void sublist() {
            var num = Convert.ChangeType(shoppingList.Content, typeof(int)) as int?;
            num--;
            shoppingList.Content = num;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ShoppingList.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

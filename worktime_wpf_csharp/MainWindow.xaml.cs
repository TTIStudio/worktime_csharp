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

namespace worktime_wpf_csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// 待补充功能
    /// 关闭程序保存log到txt文档
    /// 独立的设置win：
    ///     保存路径
    ///     是否显示日期
    ///     
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        DateTime StartTime = DateTime.Now;
        DateTime CurrentTime = DateTime.Now;
        TimeSpan totalworkingtime=new TimeSpan(0,0,0,0);
        TimeSpan totalnothingtime = new TimeSpan(0, 0, 0, 0);
    
        //DateTime CurrentTime = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();

            //  DispatcherTimer setup
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,50);
            dispatcherTimer.Start();



            CheckBox_WorkingState.Content = "Doing Nothing";
            StartTime = CurrentTime;
            Textbox_Log.Text += "\r\n";
            Textbox_Log.Text += "Nothing";
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += CurrentTime.ToString(@"yyyy.MM.dd HH\:mm\:ss");
            //this.TextBox_eventlog.TextChanged += new EventHandler(TextBox_eventlog_TextChanged);
        }


        //这两个调用有大量的重复代码，应该可以使用checkchange一个调用并精简
        private void CheckBox_WorkingState_Checked(object sender, RoutedEventArgs e)
        {
            //if(CheckBox_WorkingState.IsChecked==true)

            //end the last doing nothing

           Textbox_Log.Text += "\t";
           Textbox_Log.Text += CurrentTime.ToString(@"yyyy.MM.dd HH\:mm\:ss");   //end time point

            Textbox_Log.Text += "\t";
            Textbox_Log.Text += (CurrentTime - StartTime).ToString(@"hh\:mm\:ss");
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += TextBox_eventlog.Text;
            TextBox_eventlog.Text = "";//cleaning the log texbox
            //analysis
            totalnothingtime += (CurrentTime - StartTime);
            TextBlock_TotalnothingTime.Text = "totally wasted time: " + totalnothingtime.ToString(@"hh\:mm\:ss");


            //working part
            CheckBox_WorkingState.Content = "Working";//start a working

                StartTime = CurrentTime;
                Textbox_Log.Text += "\r\n";
                Textbox_Log.Text += "Doing";
            Textbox_Log.Text += "\t";
            Textbox_Log.Text+= CurrentTime.ToString(@"yyyy.MM.dd HH\:mm\:ss");

        }

        private void CheckBox_WorkingState_unChecked(object sender, RoutedEventArgs e)
        {
            //if (CheckBox_WorkingState.IsChecked == false)


            //end the last doing part
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += CurrentTime.ToString(@"yyyy.MM.dd HH\:mm\:ss");   //end time point
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += (CurrentTime - StartTime).ToString(@"hh\:mm\:ss");   //time duration
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += TextBox_eventlog.Text;
            TextBox_eventlog.Text = "";//cleaning the log texbox
            //analysis
            totalworkingtime += (CurrentTime - StartTime);
            //TextBlock_TotalTime.Text = totalworkingtime.ToString();
            TextBlock_TotalTime.Text = "totally work time: "+totalworkingtime.ToString(@"hh\:mm\:ss");


            //Doing nothing part
            CheckBox_WorkingState.Content = "Doing Nothing";
            StartTime = CurrentTime;
            Textbox_Log.Text += "\r\n";
            Textbox_Log.Text += "Nothing";
            Textbox_Log.Text += "\t";
            Textbox_Log.Text += CurrentTime.ToString(@"yyyy.MM.dd HH\:mm\:ss");


        }


        //  System.Windows.Threading.DispatcherTimer.Tick handler
        //
        //  Updates the current seconds display and calls
        //  InvalidateRequerySuggested on the CommandManager to force 
        //  the Command to raise the CanExecuteChanged event.
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //time giver
            CurrentTime = DateTime.Now;
            //TimeSpan Timer = new TimeSpan(1,1,1);
            //Timer = (Timenow - StartTime);
            //TextBlock_TimerDisplay.Text = Timer.ToString("g");
            //TextBlock_TimerDisplay.Text = string.Format("{0:d/M/yyyy HH:mm:ss}", (Timenow - StartTime).ToString());

            //string[] fmts = { "c", "g", "G", @"hh\:mm\:ss", "%m' min.'" };
            TextBlock_TimerDisplay.Text = (CurrentTime - StartTime).ToString(@"hh\:mm\:ss");
            //TextBlock_TimerDisplay.Text= DateTime.Now.Second.ToString();


            CommandManager.InvalidateRequerySuggested();
        }

        void TextBox_eventlog_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Size size = System.Windows.TextRenderer.MeasureText(TextBox_eventlog.Text, TextBox_eventlog.Font);
            //TextBox_eventlog.Width = size.Width;
            //TextBox_eventlog.Height = size.Height;

            //TextBox_eventlog.siz
        }

        private void TextBox_eventlog_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Return)& (Keyboard.Modifiers==ModifierKeys.Control))
            {
                CheckBox_WorkingState.IsChecked = !CheckBox_WorkingState.IsChecked;
            }
        }
    }
}



/* Timer Example from UART Timer
 https://github.com/tyskink/MachineLearningTools_Desketop/blob/master/MachineLearningTools(x64)/Form1.cs

             private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - m_StartTime;
            DateTime n = new DateTime(span.Ticks);
            if (checkBox_Timer.Checked==true)
            {
              label_Timer.Text = n.ToString("HH:mm:ss:fff");
            }
            
        }

*/

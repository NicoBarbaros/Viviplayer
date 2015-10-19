using System;
using System.Windows;
using System.Windows.Forms;


namespace ViviPlayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // Play Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            slider.Value = mediaElement.Position.TotalSeconds;
        }
        //Stop button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();

            try
            {
                mediaElement.Source = new Uri(ofd.FileName);
                textBlock.Text = mediaElement.Volume.ToString();
                mediaElement.Pause();
            }

            catch
            {
                new NullReferenceException("Error");
            }

            System.Windows.Threading.DispatcherTimer dispatchTimer = new System.Windows.Threading.DispatcherTimer();
            dispatchTimer.Tick += new EventHandler(timer_Tick);
            dispatchTimer.Interval = new TimeSpan(0, 0, 1);
            dispatchTimer.Start();
        }

        private void button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaElement.Volume += 0.1;


            if (mediaElement.Volume <= 1)
            {
                textBlock.Text = mediaElement.Volume.ToString();
            }

            else
            {
                mediaElement.Volume = 1;
                // Posible assign volume as text
                textBlock.Text = 1.ToString();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Volume -= 0.1;

            if (mediaElement.Volume < 1 && mediaElement.Volume > 0.1)
            {
                textBlock.Text = mediaElement.Volume.ToString();
            }

            else
            {
                mediaElement.Volume = 0.1;
                textBlock.Text = 0.1.ToString();
            }
        }
    }
}

namespace zad3KontWyb
{
    public partial class MainPage : ContentPage
    {
        int count = 1;

        public MainPage()
        {
            InitializeComponent();
        }
        public void TimeChange(object sender, TimeChangedEventArgs e)
        {
            
        }
        void StepperChange(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;

            stepLabel.Text = "a";            

      

        }

    }
}

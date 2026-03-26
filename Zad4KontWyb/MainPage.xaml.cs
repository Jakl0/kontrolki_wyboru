namespace Zad4KontWyb
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int pakiet = 200;
        int price;
        string firm = "a";
        string dat;

        public MainPage()
        {
            InitializeComponent();
            Picke.SelectedIndexChanged += PickerChange;
            Bas.CheckedChanged += PakietChanged;
            Stan.CheckedChanged += PakietChanged;
            Prem.CheckedChanged += PakietChanged;
            Steph.ValueChanged += StepperChange;
            _data.DateSelected += DateChange;
            baton.Clicked += onClick;
        }
        public void DateChange(object sender, DateChangedEventArgs e)
        {
            DateTime ddaattaa = e.NewDate;
            dat = $"{ddaattaa:dd.MM.yyyy}";
        }
        void StepperChange(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;

            count = int.Parse(newValue.ToString());
            price = pakiet + (100 * count);
            _stepLabel.Text = newValue.ToString();

            priceLabel.Text = $"Cena końcowa : {price} zł";


        }
        public void PickerChange(object sender, EventArgs e)
        {
            var picker = (Picker)sender;

            switch (picker.SelectedIndex)
            {
                case 0:
                    firm = "Biedronka";
                    break;

                case 1:
                    firm = "Żabka";
                    break;

                case 2:
                    firm = "Lidl";
                    break;

                case 3:
                    firm = "Aldi";
                    break;
                case 4:
                    firm = "Siatex";
                    break;
                case 5:
                    firm = "Inna";
                    break;

                default:
                    firm = "%nie_wybrano%";
                    break;

            }
        }


        void PakietChanged(object sender, CheckedChangedEventArgs e)

        {

            if (e.Value)

            {

                var radioButton = (RadioButton)sender;

                string selectedValue = radioButton.Value?.ToString();



                pakiet = int.Parse(radioButton.Value?.ToString());

                price = pakiet + (100 * count);


                priceLabel.Text = $"Cena końcowa : {price} zł";
            }
        }
        void onClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(surnameEntry.Text) || string.IsNullOrEmpty(mailEntry.Text) ||firm=="a")
            {
                DisplayAlert("Błąd", "Musisz wypełnić wszystkie pola", "OK");
            }
            else
            {
                DisplayAlert("Zarejestrowano Pomyślnie", $"Firma: {firm}; Data: {dat}; Cena: {price}","OK");
            }
        }
    }
}

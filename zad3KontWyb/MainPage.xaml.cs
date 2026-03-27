namespace zad3KontWyb
{
    public partial class MainPage : ContentPage
    {
        int count = 1;
        int size = 20;
        int ciasto = 0;
        int price;
        public MainPage()
        {
            InitializeComponent();
            stepperrr.ValueChanged += StepperChange;
            Smol.CheckedChanged += WielkoscCiastaPizzyChanged;
            Mid.CheckedChanged += WielkoscCiastaPizzyChanged;
            Bigg.CheckedChanged += WielkoscCiastaPizzyChanged;
            Thin.CheckedChanged += CiastoChanged;
            Thick.CheckedChanged += CiastoChanged;
            Cheese.CheckedChanged += CiastoChanged;
        }
        
        void StepperChange(object sender, ValueChangedEventArgs e)
        {
            double newValue = e.NewValue;

            count = int.Parse(newValue.ToString());
            price = (size + ciasto) * count;
            _stepLabel.Text = newValue.ToString();

            PriceLabel.Text = $"Cena końcowa : {price} zł";


        }
        void WielkoscCiastaPizzyChanged(object sender, CheckedChangedEventArgs e)

        {

            if (e.Value)

            {

                var radioButton = (RadioButton)sender;

                string selectedValue = radioButton.Value?.ToString();



                size = int.Parse(radioButton.Value?.ToString());
                price = (size + ciasto) * count;

                PriceLabel.Text = $"Cena końcowa : {price} zł";

            }
        }

        void CiastoChanged(object sender, CheckedChangedEventArgs e)

        {

            if (e.Value)

            {

                var radioButton = (RadioButton)sender;

                string selectedValue = radioButton.Value?.ToString();



                ciasto = int.Parse(radioButton.Value?.ToString());

                price = (size + ciasto) * count;

                PriceLabel.Text = $"Cena końcowa : {price} zł";

            }
        }

    }
}
/*
 ************************************************************************************************* 
 
nazwa funkcji:        WielkoscCiastaPizzyChanged
opis funkcji:        funkcja obsługująca trzy radiobuttony i zmienia wartość ceny całkowitej w czasie rzeczywistym
parametry:           standardowy parametr object sender i parametr daty 

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

nazwa funkcji:        StepperChange
opis funkcji:        funkcja która aktualizuje zmienną posiadającą ilość sztuk pizzy
parametry:           standardowy parametr object sender i parametr ValueChangedEventArgs

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

nazwa funkcji:       CiastoChanged
opis funkcji:        druga funkcja obługująca kolejną grupę trzech radiobuttonów równięż aktualizująca cenę w czasie rzeczywistym
parametry:           standardowe parametry w funkcjach net maui

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************


 */

namespace Zad2KontWyb
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        string pick;
        string dat;
        string tim;

        public void PickerChange(object sender, EventArgs e)
        {
            var picker = (Picker)sender;

            switch (picker.SelectedIndex)
            {
                case 0:
                    pick = "Internisty";
                    break;

                case 1:
                    pick = "Kardiologa";
                    break;

                case 2:
                    pick = "Dermatologa";
                    break;

                case 3:
                    pick = "Okulisty";
                    break;

                default:
                    pick = "%nie_wybrano%";
                    break;

            }
        }
        public void DateChange(object sender, DateChangedEventArgs e)
        {
            DateTime ddaattaa = e.NewDate;
            dat = $"{ddaattaa:dd.MM.yyyy}";
        }
        public void TimeChange(object sender, TimeChangedEventArgs e)
        {
            TimeSpan ts = e.NewTime;
            tim = $"{ts:hh\\:mm}";
        }
        public void onClick(object sender, EventArgs e)
        {
            DisplayAlert($"Wizyta u {pick}", $"dnia {dat} o godzinie {tim}", "OK");
        }
    }
}
/*
 ************************************************************************************************* 
 
nazwa funkcji:        DateChange
opis funkcji:        funkcja służy aktualizacji zmiennej przechowywującej wybraną datę aby wyświetlić ją w alercie
parametry:           standardowy parametr object sender i parametr daty DateChangedEventArgs

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

nazwa funkcji:       PickerChange
opis funkcji:        funkcja aktualizuje zmienną odpowiadającą nazwie specjalisty wybranej przez użytkownika
parametry:           standardowe parametry w funkcjach net maui

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

nazwa funkcji:        TimeChange
opis funkcji:        funkcja która aktualizuje wartość pakietu i cenę końcową gdy zaznaczymy radiobutton
parametry:           standardowy parametr object sender i parametr CheckedChangedEventArgs

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

nazwa funkcji:        onClick
opis funkcji:        funkcja wyświetlająca błędny bądź poprawny alert po kliknięciu przycisku przez użytkownika wyświetlający wybrane dane
parametry:           standardowe parametry w funkcjach net maui

zwracany typ:        brak
autor:               xxxxx



*************************************************************************************************

 */
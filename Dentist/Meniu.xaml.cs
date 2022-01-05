using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dentist
{
    public partial class Meniu : ContentPage
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private async void Cabinete_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CabinetPage());
        }

        private async void Clienti_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientPage());
        }

        private async void Programari_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramarePage());
        }
    }
}
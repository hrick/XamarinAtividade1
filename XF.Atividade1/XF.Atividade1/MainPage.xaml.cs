using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Atividade1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensagem", "Email enviado para flavio@fiap.com", "OK");

        }
      

            void btnConfig_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ControEntregas.Model;

namespace ControEntregas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        Cliente cliente = new Cliente();
        public Menu()
        {
            Token token = PropertiesOperations.GetTokenProperties();
            cliente.idCliente = Convert.ToInt64(token.customerID);
            cliente.token = token;
            InitializeComponent();
        }

        private async void Scan_Tapped(object sender, EventArgs e)
        {
            //actLoading.IsRunning = true;
            ////await Task.Delay(2000);
            //await Navigation.PushAsync(new EntregasV(cliente));
            //actLoading.IsRunning = false;
            try
            {
                var options = new ZXing.Mobile.MobileBarcodeScanningOptions()
                {
                    AutoRotate = false,
                    TryInverted = true,
                    TryHarder = true,
                };
                //options.PossibleFormats = new List<ZXing.BarcodeFormat>()
                //{
                //    ZXing.BarcodeFormat.EAN_8, ZXing.BarcodeFormat.EAN_13
                //};
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan(options);

                actLoading.IsRunning = true;
                txtNumOrden.Text = HandleResult(result);
                actLoading.IsRunning = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNumOrden.Text != null && txtNumOrden.Text != "")
                {
                    actLoading.IsRunning = true;

                    EntregasModel entrega = new EntregasModel();
                    entrega.shipperID = txtNumOrden.Text.Trim();
                    entrega.token = this.cliente.token;
                    await Navigation.PushAsync(new DescripcionEntregas(entrega));

                    actLoading.IsRunning = false;
                    txtNumOrden.Text = string.Empty;
                }
                else
                {
                    await DisplayAlert("Error", "Favor de Introducir # de Orden", "cancel");
                    txtNumOrden.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }


        private string HandleResult(ZXing.Result result)
        {
            try
            {
                if (result != null)
                {
                    return result.Text;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            PropertiesOperations.RemoveProperties();
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopAsync().ConfigureAwait(false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Model;
using ControEntregas.Services;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.Net.Http;

namespace ControEntregas.Model
{
    public class ViewModels
    {
        public List<EntregasM> EntregasList { get; set; }
        private string shipperID;

        public ViewModels(string shipperID)
        {
            this.shipperID = shipperID;
            EntregasList = new List<EntregasM>();
            //Task.Run(() => this.InitializeDataAsync()).Wait();
        }

        private async Task InitializeDataAsync()
        {
            try
            {
                var entregasService = new EntregasServices();
                EntregasList = await entregasService.GetEntregasAsync(shipperID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
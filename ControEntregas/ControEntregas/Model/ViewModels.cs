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
        private Int64 idOrdenEntrega;

        public ViewModels(Int64 idOrdenEntrega)
        {
            this.idOrdenEntrega = idOrdenEntrega;
            EntregasList = new List<EntregasM>();
            Task.Run(() => this.InitializeDataAsync()).Wait();
        }

        private async Task InitializeDataAsync()
        {
            try
            {
                var entregasService = new EntregasServices();
                EntregasList = await entregasService.GetEntregasAsync(idOrdenEntrega);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControEntregas.Services;

namespace ControEntregas.Model
{
    public class ViewModelsEntregas
    {
        public List<EntregasModel> EntregasList { get; set; }
        private Cliente cliente;
        public ViewModelsEntregas(Cliente cliente)
        {
            this.cliente = cliente;
            EntregasList = new List<EntregasModel>();
            Task.Run(() => this.InitializeDataAsync()).Wait();
        }

        private async Task InitializeDataAsync()
        {
            try
            {
                EntregasVServices services = new EntregasVServices();
                EntregasList = await services.Get(cliente.idCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
            cmbFiltroTipoEntrega.SelectedIndexChanged += cmbFiltroTipoEntrega_SelectedIndexChanged;
            HistorialForm_Load(null, null);
        }

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            cmbFiltroTipoEntrega.Items.Add("Todos");
            cmbFiltroTipoEntrega.Items.Add("Dron");
            cmbFiltroTipoEntrega.Items.Add("Motocicleta");
            cmbFiltroTipoEntrega.Items.Add("Camión");
            cmbFiltroTipoEntrega.Items.Add("Bicicleta");
            cmbFiltroTipoEntrega.SelectedIndex = 0;

            MostrarPedidos();
        }

        private void MostrarPedidos(string tipoFiltro = "Todos")
        {
            var pedidos = RegistroPedidos.Instancia.Pedidos;

            var listaFiltrada = tipoFiltro == "Todos"
                ? pedidos
                : pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == tipoFiltro).ToList();

            dgvHistorial.DataSource = listaFiltrada.Select(p => new
            {
                Cliente = p.Cliente,
                Producto = p.Producto,
                Urgente = p.Urgente,
                Peso = p.Peso,
                Distancia = p.Distancia,
                TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                Costo = p.ObtenerCosto()
            }).ToList();
        }

        private void cmbFiltroTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbFiltroTipoEntrega.SelectedItem.ToString();
            MostrarPedidos(tipoSeleccionado);
        }
    }
}

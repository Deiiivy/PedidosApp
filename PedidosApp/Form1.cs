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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbProducto.Items.AddRange(new string[] { "tecnología", "accesorio", "componente" });
            cmbProducto.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);
                Cleaner();

                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()}\n" +
                                    $"Costo: ${pedido.ObtenerCosto():0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cleaner()
        {
            txtCliente.Clear();
            cmbProducto.SelectedIndex = 0;
            chkUrgente.Checked = false;
            nudPeso.Value = 0;
            nudDistancia.Value = 0;
            lblResultado.Text = string.Empty;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            var historial = new HistorialForm();
            historial.ShowDialog();
        }
    }
}

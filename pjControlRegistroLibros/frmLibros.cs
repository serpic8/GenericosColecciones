using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjControlRegistroLibros
{
    public partial class frmLibros : Form
    {
        static int contador;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            lblNumero.Text = GenerarNumero();
        }
        Func<string> GenerarNumero = () => //Investiga que es el func
        {
            contador++;
            return contador.ToString("0000");
        };

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                //Capturando los datos del formulario
                double costo = getCosto();
                string categoria = getCategoria();
                double descuento = AsignaDescuento(categoria, costo);
                double precioVenta = CalculaPrecioVenta(costo, descuento);
                //Enviando a la impresion
                ImprimirRegistro(descuento, precioVenta);
            }
            else
                MessageBox.Show("El error se encuentra en" + Valida());
        }

        //Imprimir registro de ventas
        private void ImprimirRegistro(double descuento, double precioVenta)
        {
            ListViewItem fila = new ListViewItem(getNumero().ToString());
            fila.SubItems.Add(getTitulo());
            fila.SubItems.Add(getCategoria());
            fila.SubItems.Add(getCosto().ToString("0.00")); //To string lo convierte a cadena
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(precioVenta.ToString("0.00"));
            lvLibros.Items.Add(fila);
        }

        Func<double, double, double> CalculaPrecioVenta=(costo, descuento) => costo - descuento;

        Func<string, double, double> AsignaDescuento = (categoria, costo) =>
        {
            double descuento = 0;
            switch (categoria)
            {
                case "Gestion": descuento = 10.0 / 100 * costo; break;
                case "Ingenieria": descuento = 12.0 / 100 * costo; break;
                case "Programacion": descuento = 20.0 / 100 * costo; break;
                case "Base de datos": descuento = 15.0 / 100 * costo; break;

            }
            return descuento;
        };

        //Metodos que capturan los valores
        private int getNumero()
        {
            return int.Parse(lblNumero.Text);
        }

        private string getTitulo()
        {
            return txtTitulo.Text;
        }
        private string getCategoria()
        {
            return cboCategoria.Text;
        }

        private double getCosto()
        {
            return double.Parse(txtCostos.Text);
        }

        private string Valida()  //El valida nos muestra el campo vacio que esta en el programa
        {
            if(txtTitulo.Text.Trim().Length == 0)   //Trim elimina los espacios en blanco
            {
                txtTitulo.Focus();
                return "Titulo de libro";
            }
            else if(cboCategoria.Text.Trim().Length == -1) //Para un campo vacio en el cbo utilizamos -1
            {
                cboCategoria.Focus();
                return "Categoria del libro";
            }
            else if(txtCostos.Text.Trim().Length == 0)
            {
                txtCostos.Focus();
                return "Costos";
            }
            return "";
        }
    }
}

using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Productos : Form
    {
        Entidades.Producto producto = new Entidades.Producto();
        Logica.ServicioProducto servicioProducto = new Logica.ServicioProducto();
        int row = -1;
        public Productos()
        {
            InitializeComponent();
            RefreshLista();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void RefreshLista()
        {
            grillaListaProductos.DataSource = servicioProducto.GetAll();
        }
        void Limpiar()
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxValorVenta.Text = "";
            textBoxDescripcion.Text = "";
        }
        void Llenar(Entidades.Producto producto)
        {
            textBoxCodigo.Text = producto.Codigo;
            textBoxNombre.Text = producto.Nombre;
            textBoxValorVenta.Text = producto.ValorVenta + "";
            textBoxDescripcion.Text = producto.Descripcion;
        }
        void Guardar()
        {
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxValorVenta.Text == "")
            {
                MessageBox.Show("Llene todos los campos, por favor");
            }
            else
            {
                if (row == -1)
                {
                    producto.Codigo = textBoxCodigo.Text;
                    producto.Nombre = textBoxNombre.Text;
                    producto.Descripcion = textBoxDescripcion.Text;
                    producto.ValorVenta = double.Parse(textBoxValorVenta.Text);
                    var Respuesta = MessageBox.Show("Desea guardar el producto?", "Responde...", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        servicioProducto.Guardar(producto);
                        Limpiar();
                        RefreshLista();
                    }
                }
                else
                {
                    producto.Codigo = textBoxCodigo.Text;
                    producto.Nombre = textBoxNombre.Text;
                    producto.Descripcion = textBoxDescripcion.Text;
                    producto.ValorVenta = double.Parse(textBoxValorVenta.Text);
                    servicioProducto.Edit(producto, row);
                    textBoxCodigo.Focus();
                    RefreshLista();
                    Limpiar();
                    row = -1;
                }
            }
        }

        void Eliminar()
        {
            if (row != -1)
            {
                var Respuesta = MessageBox.Show("Desea borrar el producto?", "Responde...", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes)
                {
                    servicioProducto.Delete(row);
                    RefreshLista();
                    Limpiar();
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.PowderBlue;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            textBoxCodigo.Focus();
        }

        private void Productos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void grillaListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            Llenar(servicioProducto.GetAll()[row]);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void grillaListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            Llenar(servicioProducto.GetAll()[row]);
        }
    }
}

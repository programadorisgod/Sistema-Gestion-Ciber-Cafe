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
using Entidades;


namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Clientes : Form

    {
        int p = 0;
        Entidades.Cliente cliente = new Entidades.Cliente();
        Logica.ServicioCliente servicioCliente = new Logica.ServicioCliente();
        public Clientes()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void Limpiar()
        {
            txtcedula.Text = " ";
            txtnombre.Text = " ";
            txtTelefono.Text = " ";
            txtDireccion.Text = " ";
            txtCorreo.Text = " ";
        }
        void Guardar()
        {
            cliente.Cedula = int.Parse(txtcedula.Text);
            cliente.Nombre = txtnombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Correo = txtCorreo.Text;
            if (txtcedula.Text == " " || txtnombre.Text == " " || txtTelefono.Text == " " || txtDireccion.Text == " " || txtCorreo.Text == " ")
            {
                MessageBox.Show("Llene todos los campos, por favor");
            }
            else
            {
                var Respuesta = MessageBox.Show("Desea guardar el contacto?", "Responde...", MessageBoxButtons.YesNoCancel);
                if (Respuesta == DialogResult.Yes)
                {
                    var mensaje = servicioCliente.Guardar(cliente);
                    MessageBox.Show(mensaje);
                }
            }

        }
        void CargarTabla()
        {
            foreach (var item in servicioCliente.GetAll())
            {
                dataGridView1.Rows.Add(item.Cedula, item.Nombre, item.Telefono, item.Direccion, item.Correo);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p = e.RowIndex;
            if (p != 1)
            {
                VerClientes(servicioCliente.GetAll()[e.RowIndex]);
            }

        }
        void VerClientes(Entidades.Cliente cliente)
        {
            txtcedula.Text = Convert.ToString(cliente.Cedula);
            txtnombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            txtCorreo.Text = cliente.Correo;
        }
        void Editar()
        {
            cliente.Cedula = int.Parse(txtcedula.Text);
            cliente.Nombre = txtnombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Correo = txtCorreo.Text;
            dataGridView1[1, p].Value = txtcedula.Text;
            dataGridView1[2, p].Value = txtnombre.Text;
            dataGridView1[3, p].Value = txtTelefono.Text;
            dataGridView1[4, p].Value = txtDireccion.Text;
            dataGridView1[5, p].Value = txtCorreo.Text;
            var mensaje = servicioCliente.Edit(cliente);
            MessageBox.Show(mensaje);
            Limpiar();
            txtnombre.Focus();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var P = new Principal();
            P.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (p != 1)
            {
                dataGridView1.Rows.RemoveAt(p);
                var mensaje = servicioCliente.Delete(p);
                MessageBox.Show(mensaje);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnombre.Focus();
            }
        }

        private void txtcedula_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                txtnombre.Focus();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtcedula.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtnombre.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtTelefono.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtCorreo.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCorreo.Focus();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pictureBox1.Focus();
            }
        }
        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtDireccion.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Focus();
            }
        }

        private void Clientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

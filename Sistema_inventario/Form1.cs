using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNOMBRE.Text != "" && txtCANTIDAD.Text != "" && txtPRECIO.Text != "" && txtTOTAL.Text != "")
            {
                ListViewItem lista = new ListViewItem(txtID.Text);
                lista.SubItems.Add(txtNOMBRE.Text);
                lista.SubItems.Add(txtCANTIDAD.Text);
                lista.SubItems.Add(txtPRECIO.Text);
                lista.SubItems.Add(txtTOTAL.Text);
                listView1.Items.Add(lista);

                txtID.Text = "";
                txtNOMBRE.Text = "";
                txtCANTIDAD.Text = "";
                txtPRECIO.Text = "";
                txtTOTAL.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, Termine de llenar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem selectedItem = listView1.SelectedItems[0];

                if (txtID.Text != "" && txtNOMBRE.Text != "" && txtCANTIDAD.Text != "" && txtPRECIO.Text != "" && txtTOTAL.Text != "")
                {
                    // Modificar los valores del elemento con los nuevos valores de los TextBox
                    selectedItem.SubItems[0].Text = txtID.Text;
                    selectedItem.SubItems[1].Text = txtNOMBRE.Text;
                    selectedItem.SubItems[2].Text = txtCANTIDAD.Text;
                    selectedItem.SubItems[3].Text = txtPRECIO.Text;
                    selectedItem.SubItems[4].Text = txtTOTAL.Text;
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems) 
            {
                lista.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Yamy_Desktop.Models;

namespace Yamy_Desktop.Views
{
    public partial class PreciosForm : Form
    {
        public PreciosForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número, ni un punto ni la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true; // Esto evita que se ingrese el carácter no válido
                MessageBox.Show("Solo números en este campo");
            }

            // Verifica que no se ingresen más de un punto
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
                MessageBox.Show("Ya hay un punto en este campo, solo pude colocarse uno.");
            }
        }

        private void PreciosForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            gb_Confirmar.Visible = false;
        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lbl_tipo.Text = "aumento";
                lbl_tipo.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                lbl_tipo.Text = "reducción";
                lbl_tipo.ForeColor = System.Drawing.Color.Red;
            }
            lbl_porcentaje.Text = textBox1.Text;

            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            gb_Confirmar.Visible = true;
        }

        private void btb_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    List<producto> productos = DB.producto.ToList().FindAll(x => x.fechaBaja == null);

                    if (comboBox1.SelectedIndex == 0)
                    {
                        foreach (producto item in productos)
                        {
                            item.precioUnitario = item.precioUnitario + ((item.precioUnitario * double.Parse(lbl_porcentaje.Text)) / 100);
                        }
                    }
                    else
                    {
                        foreach (producto item in productos)
                        {
                            item.precioUnitario = item.precioUnitario - ((item.precioUnitario * double.Parse(lbl_porcentaje.Text)) / 100);
                        }
                    }

                    // Guardar todos los cambios fuera del bucle
                    DB.SaveChanges();
                }
                MessageBox.Show("Se practicaron los ajustes solicitados correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

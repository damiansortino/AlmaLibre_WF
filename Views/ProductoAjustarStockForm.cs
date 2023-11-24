using System;
using System.Windows.Forms;

namespace Yamy_Desktop.Views
{
    public partial class ProductoAjustarStockForm : Form
    {
        int id = 0;
        public ProductoAjustarStockForm()
        {
            InitializeComponent();
        }
        public ProductoAjustarStockForm(int idproducto)
        {
            InitializeComponent();
            id = idproducto;
            //Llenarlabels();
        }

        /*
        private void Llenarlabels()
        {
            try
            {
                using (baselaymarEntities DB = new baselaymarEntities())
                {
                    producto producto = DB.producto.Find(id);

                    lblCodigo.Text = producto.codigo;
                    lblNombre.Text = producto.nombre;
                    lblDescripcion.Text = producto.descripcion;
                    lblMarca.Text = producto.marca;
                    lblTalle.Text = producto.talle;
                    lblColor.Text = producto.color;
                    lb
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error abriendo el producto para modificar stock \n"+ex.Message);
            }
        }

        */


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoAjustarStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace winform_app
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = new Articulo();
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            lblCodigoMostrar.Text = articulo.Codigo;
            lblNombreMostrar.Text = articulo.Nombre;
            lblDescripcionMostrar.Text = articulo.Descripcion;
            lblPrecioMostrar.Text = articulo.Precio.ToString();
            cargarImagen(articulo.UrlImagen);
            lblCategoriaMostrar.Text = articulo.Categoria.Descripcion;
            lblMarcaMostrar.Text = articulo.Marca.Descripcion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticuloDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticuloDetalle.Load("https://www.shutterstock.com/image-vector/default-ui-image-placeholder-wireframes-600nw-1037719192.jpg");
            }
        }
    }
}

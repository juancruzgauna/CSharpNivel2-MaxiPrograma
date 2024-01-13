using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            lblAgregarArticulo.Text = "Agregar artículo";
        }

        //sobrecargo el constructor del formulario de alta si quiero hacer una modificación
        //de un artículo()
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
            lblAgregarArticulo.Text = "Modificar artículo: " + articulo.Nombre;
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
             

                if(articulo.Id != 0)
                {
                    if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Debe completar Código y Nombre del producto");
                    }
                    else
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                }
                else
                {
                    if(string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Debe completar Código y Nombre del producto");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");                  
                    }
                }

                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                
                Close();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Campo Precio admite solo números y no puede estar vacío");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxAltaArticulo.Load("https://www.shutterstock.com/image-vector/default-ui-image-placeholder-wireframes-600nw-1037719192.jpg");
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        //Manejo de evento KeyPress, para ingresar solo números
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}

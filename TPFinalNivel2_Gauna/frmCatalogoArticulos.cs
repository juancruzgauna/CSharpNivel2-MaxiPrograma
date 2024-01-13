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

namespace winform_app
{
    public partial class frmCatalogoArticulos : Form
    {
        private List<Articulo> listaArticulo;
        private List<Articulo> listaFiltrada;
        public frmCatalogoArticulos()
        {
            InitializeComponent();
        }

        private void frmCatalogoArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://www.shutterstock.com/image-vector/default-ui-image-placeholder-wireframes-600nw-1037719192.jpg");                    
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }
        //BOTÓN BUSCAR DEL FILTRO RÁPIDO ELIMINADO

        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            
            //se debe hacer una limpieza al Data Source antes de pasarle una nueva lista al Data Grid View
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }*/

        //BOTÓN BUSCAR DEL FILTRO RÁPIDO ELIMINADO

        private void btnRestablecer_Click(object sender, EventArgs e)
        {          
            dgvArticulos.DataSource = listaArticulo;
            txtFiltro.Text = "";

            //al hacer click en boton restablecer le devuelvo la listaArticulo a la DataGridView
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            string filtro = txtFiltro.Text;
            validarFiltroRapido(filtro);

            try
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ocultarColumnas();

                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            string filtro = txtFiltro.Text;
            validarFiltroRapido(filtro);
            
            try
            {
                //Pongo la dgv en null ya que si hago un filtro de búsqueda y aprieto detalle
                //me salta una excepción por el hecho de que la Current Row de ese objeto está nula
                //(cambia el Index Change), luego le paso la lista de artículos de nuevo para actualizarla
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ocultarColumnas();

                frmDetalle detalle = new frmDetalle(seleccionado);
                detalle.ShowDialog();    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            if(filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {         
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir?", "Saliendo de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
               Close();
            }
        }

        private bool validarFiltro()
        {
            //SelectedIndex >= 0 tiene algo cargado
            //SelectedInex == -1 no tiene nada seleccionado
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo números para filtrar por un campo numérico...");    
                    return true;    
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                //pregunto si no es número en el if
                if (!(char.IsNumber(caracter)))
                    return false; 
            }
            return true;
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void validarFiltroRapido(string filtro)
        {
            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditos creditos = new frmCreditos();
            creditos.ShowDialog();
        }
    }
}

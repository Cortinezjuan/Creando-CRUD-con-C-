using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            double precio_publico = double.Parse(txtPrecioPublico.Text);
            int existencias = int.Parse(txtExistencias.Text);

            string sql = "INSERT INTO datosproductos (codigo, nombre,descripcion,precio_publico,existencias) VALUES ('"+ codigo + "','" + nombre + "','" + descripcion + "','" + precio_publico + "','" + existencias + "')";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            MySqlDataReader reader = null;
            String sql = "SELECT * FROM datosproductos WHERE codigo LIKE '" + codigo + "' LIMIT 1 ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtCodigo.Text = reader.GetString(0);
                        txtNombre.Text = reader.GetString(1);
                        txtDescripcion.Text = reader.GetString(2);
                        txtPrecioPublico.Text = reader.GetString(3);
                        txtExistencias.Text = reader.GetString(4);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            double precio_publico = double.Parse(txtPrecioPublico.Text);
            int existencias = int.Parse(txtExistencias.Text);

            string sql = "UPDATE  datosproductos SET codigo='" + codigo + "', nombre='" + nombre+"',descripcion='"+descripcion+"',precio_publico='"+precio_publico+"',existencias='"+existencias+"' WHERE codigo='"+codigo+"';";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Modificado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string sql = "DELETE  FROM  datosproductos  WHERE codigo='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioPublico.Text = "";
            txtExistencias.Text = "";
        }
    }
}

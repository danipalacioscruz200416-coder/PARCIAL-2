
//======================================INTEGRANTES=========================================================//
// Integrante 1: Jonathan Hazael Molina Rodriguez
// Integrante 2: Daniel Isaac Palacios Cruz 

using System;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TiendaParcial
{
    public partial class Form1 : Form
    {
        
        string conexionString = "Server=.\\SQLEXPRESS;Database=TiendaParcialDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Productos";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



       

        private void butguardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtproducto.Text) || string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                string.IsNullOrWhiteSpace(txtprecio.Text) || string.IsNullOrWhiteSpace(txtexistencia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtexistencia.Text, out int existencia) || existencia < 0)
            {
                MessageBox.Show("Las existencias deben ser un número entero mayor o igual a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Productos (producto, categoria, precio, existencia) VALUES (@producto, @categoria, @precio, @existencia)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@producto", txtproducto.Text);
                        cmd.Parameters.AddWithValue("@categoria", txtcategoria.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtprecio.Text));
                        cmd.Parameters.AddWithValue("@existencia", Convert.ToInt32(txtexistencia.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butconsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                  
                    string query = "SELECT id_producto, producto, categoria, precio, existencia FROM Productos WHERE producto = @producto";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@producto", txtproducto.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                      
                                txtproducto.Text = reader["producto"].ToString();
                                txtcategoria.Text = reader["categoria"].ToString();
                                txtprecio.Text = reader["precio"].ToString();
                                txtexistencia.Text = reader["existencia"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún producto con ese nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butelimiar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM Productos WHERE producto = @producto";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@producto", txtproducto.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

  
            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtproducto.Text = fila.Cells["producto"].Value.ToString();
                txtcategoria.Text = fila.Cells["categoria"].Value.ToString();
                txtprecio.Text = fila.Cells["precio"].Value.ToString();
                txtexistencia.Text = fila.Cells["existencia"].Value.ToString();
            }
        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            txtproducto.Clear();
            txtcategoria.Clear();
            txtprecio.Clear();
            txtexistencia.Clear();
            txtproducto.Focus();
        }

        private void butrestablecer_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
    }


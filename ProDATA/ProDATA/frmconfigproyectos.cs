using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace ProDATA
{
    public partial class frmconfigproyectos : Form
    {
        public frmconfigproyectos()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        //private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.proyectoBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.prodataDataSet);

        //}

        private void frmconfigproyectos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodataDataSet.Proyecto' table. You can move, or remove it, as needed.
           this.proyectoTableAdapter.Fill(this.prodataDataSet.Proyecto);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltiempo.Text = DateTime.Now.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmprin = new FrmPrincipal();
            frmprin.Show();
               
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
              
                using (ProdataEntities  context = new ProdataEntities())
                {
                    Proyecto proyecto2 = new Proyecto()
                    {
                        
                        Proyecto1 = Convert.ToString(proyectoTextBox.Text),
                        Fechainicio = Convert.ToDateTime(fechainicioDateTimePicker.Text),
                        Descripción = Convert.ToString(descripciónTextBox.Text),
                        
                                             
                    };

                context.Proyectoes.Add(proyecto2);
                context.SaveChanges();
                this.proyectoTableAdapter.Fill(this.prodataDataSet.Proyecto);


            };
                
                }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {

            proyectoBindingSource.RemoveFilter();
            proyectoDataGridView.ClearSelection();
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
           // proyectoDataGridView.DataSource = proyectoTableAdapter.GetData();
            proyectoDataGridView.ResetBindings();
            proyectoDataGridView.Refresh();
            proyectoDataGridView.Update();
            this.proyectoTableAdapter.Fill(this.prodataDataSet.Proyecto);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {


            string searchvalue = txtBuscar.Text;
            if (txtBuscar.Text != "" )
            {
                // Clear all selected cells or rows in the DGV.

                //    proyectoDataGridView.FirstDisplayedCell = null;
               

                // Make every column not sortable.
                //  for (int i = 0; i < proyectoDataGridView.Columns.Count; i++)
                //  proyectoDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                // Set selection mode to Column.
              //  proyectoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                // In case you want the first column selected. 
                //   if (proyectoDataGridView.Columns.Count > 0)  // Check if you have at least one column.
               //  proyectoDataGridView.Columns[0].Selected = true;
                
                proyectoDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
               // (proyectoDataGridView.DataSource as DataTable).DefaultView.RowFilter = " Proyecto  LIKE '" + searchvalue + "%'";
                proyectoBindingSource.Filter = "Proyecto  LIKE '" + searchvalue + "%'";


            }
            else
            {
                MessageBox.Show("Debes seleecionar el criterio de busqueda y escribir en buscar");
                proyectoBindingSource.RemoveFilter();
                proyectoDataGridView.ClearSelection();


            }


        }

        private void proyectoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if(!proyectoDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = proyectoDataGridView.Rows[e.RowIndex];
                idproyectoTextBox.Text = dgv.Cells[0].Value.ToString();
                proyectoTextBox.Text = dgv.Cells[1].Value.ToString();
                fechainicioDateTimePicker.Text = dgv.Cells[2].Value.ToString();
                descripciónTextBox.Text = dgv.Cells[3].Value.ToString();

                BtnEditar.Text = "Guardar";
            }
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                // Instanciamos el DbContext
                var dbcontext = new ProdataEntities();
                // Extraemos el ObjectContext del DbContext (a partir de Entity Framework 4.1)
                var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;
                Proyecto dbproyeecto = new Proyecto()
                {


                };




                //  Grid row = proyectoDataGridView.Rows[e.row]
                //string proyectoid = Convert.ToInt32(proyectoDataGridView.DataKeys);
                //using (ProdataEntities context = new ProdataEntities())
                //    {

                //        {
                //            Proyecto proyecto = (from c in context.Proyectoes
                //                                 where c.Idproyecto == idproyectoTextBox
                //                                 select c).FirstOrDefault();
                //            proyecto.


                //        };

                //        context.Proyectoes.Add(proyecto2);
                //        context.SaveChanges();
                //        this.proyectoTableAdapter.Fill(this.prodataDataSet.Proyecto);


                //    };
                //}else
                //{
                //    this.proyectoTableAdapter.Fill(this.prodataDataSet.Proyecto);
                //    BtnEditar.Text = "Editar";

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
    }
        }
    
    


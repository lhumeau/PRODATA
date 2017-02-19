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


namespace ProDATA
{
    public partial class frmconfigproyectos : Form
    {
        public frmconfigproyectos()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodataDataSet);

        }

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
              
                using (ProdataEntities context = new ProdataEntities())
                {
                    Proyecto proyecto2 = new Proyecto()
                    {
                        Idproyecto = idproyectoTextBox,
                        Proyecto1 = proyectoTextBox,
                        Fechainicio = fechainicioDateTimePicker,
                        Descripción = descripciónTextBox,

                       
                    };
                context.Proyectoes.Add
                   



                };
                
                }
            }
        }
    
    


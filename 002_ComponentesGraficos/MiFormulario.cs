using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_ComponentesGraficos
{
    public partial class MiFormulario : Form
    {
        //logica
        public MiFormulario()
        {
            InitializeComponent();//nunca hay tocarlo
            CLB_CheckeListB.Items.Add("Opcion 5");
        }

        private void BT_Salida_Click(object sender, EventArgs e)
        {
            LB_Mensaje.Text = "Salida";
        }

        private void CB_Validar_CheckedChanged(object sender, EventArgs e)
        {


            LB_Validar.Text = "Valor: " + CB_Validar1.Checked;
            CB_Validar2.CheckedChanged -= null;

            CB_Validar2.Checked = !CB_Validar1.Checked;//esto dispara el evento
            CB_Validar2.CheckedChanged += new System.EventHandler(this.CB_Validar_CheckedChanged);

            //CB_Validar3.CheckedChanged -= null;

            //CB_Validar3.Checked = !CB_Validar1.Checked;//esto dispara el evento
            //CB_Validar3.CheckedChanged += new System.EventHandler(this.CB_Validar3_CheckedChanged);

        }

        private void CB_Validar2_CheckedChanged(object sender, EventArgs e)
        {
            LB_Validar2.Text = "Valor: " + CB_Validar2.Checked;

            CB_Validar1.CheckedChanged -= null;
            CB_Validar1.Checked = !CB_Validar2.Checked;//esto dispara el evento
            CB_Validar1.CheckedChanged += new System.EventHandler(this.CB_Validar2_CheckedChanged);

            //CB_Validar3.CheckedChanged -= null;
            //CB_Validar3.Checked = !CB_Validar2.Checked;//esto dispara el evento
            //CB_Validar3.CheckedChanged += new System.EventHandler(this.CB_Validar3_CheckedChanged);

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LB_ValidarR1.Text = "Valido: " + RB_Validar1.Checked;
        }

        private void RB_Validar2_CheckedChanged(object sender, EventArgs e)
        {
            LB_ValidarR2.Text = "Valido: " + RB_Validar2.Checked;
        }

        private void RB_Validar3_CheckedChanged(object sender, EventArgs e)
        {
            LB_ValidarR3.Text = "Valido: " + RB_Validar3.Checked;
        }

        private void CLB_CheckeListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_OpcionesCLB.Text = CLB_CheckeListB.SelectedItem.ToString() + Environment.NewLine;// SelectedIndex.ToString();


            string listaopcion = "";
            foreach (var item in CLB_CheckeListB.Items)
            {
                //TB_OpcionesCLB.Text = "\n" + item.ToString();
                string opcion = "" + item.ToString();
                //string listaopcion = "";
                bool marcado = false;
                foreach (var item2 in CLB_CheckeListB.CheckedItems)
                {
                    marcado = false;
                    if (opcion == item2.ToString())
                    {
                        marcado = true;
                        break;
                    }
                }

                opcion += ": " + marcado;
                listaopcion += opcion + "\r\n"; // Environment.NewLine;// "\n";
            }
            TB_OpcionesCLB.Text += listaopcion;

        }

        private void MiFormulario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOO2020_3_6AMDataSet2.DataGridView' table. You can move, or remove it, as needed.
            this.dataGridViewTableAdapter.Fill(this.pOO2020_3_6AMDataSet2.DataGridView);
            // TODO: This line of code loads data into the 'pOO2020_3_6AMDataSet1.ComboBox2' table. You can move, or remove it, as needed.
            this.comboBox2TableAdapter.Fill(this.pOO2020_3_6AMDataSet1.ComboBox2);
            // TODO: This line of code loads data into the 'pOO2020_3_6AMDataSet.ComboBox1' table. You can move, or remove it, as needed.
            this.comboBox1TableAdapter.Fill(this.pOO2020_3_6AMDataSet.ComboBox1);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine();
            //ComboBox combo = sender as ComboBox;
            //MessageBox.Show("El valor es:" + combo.SelectedValue);
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine();
            //ComboBox combo = sender as ComboBox;
            //MessageBox.Show("El valor es:" + combo.SelectedValue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LB_hora.Text = DateTime.Now.ToString();
        }
    }
}

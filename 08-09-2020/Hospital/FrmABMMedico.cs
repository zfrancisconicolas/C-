using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_09_2020;

namespace Hospital {
    public partial class FrmABMMedico : Form {
        private Medico miMedico;
        public Medico MiMedico {
            get { return miMedico; }
        }
        
        public FrmABMMedico() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(this.cmbEspecialidad.SelectedIndex != -1) {
                miMedico = new Medico(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.cmbEspecialidad.SelectedItem.ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.txtNombre.Text = "Francisco";
            this.txtApellido.Text = "Zanotti";
            this.txtDni.Text = "38834954";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();
        }
    }
}

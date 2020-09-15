using _08_09_2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital {
    public partial class FrmABMPaciente : Form {
        public FrmABMPaciente() {
            InitializeComponent();
        }

        private Paciente miPaciente;

        public Paciente MiPaciente {
            get { return miPaciente; }
            set { miPaciente = value; }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.miPaciente = new Paciente("Pepe", "Peposo", "12341234", "Duele la muela");
            this.DialogResult = DialogResult.OK;
        }
    }
}

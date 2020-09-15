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
    public partial class FrmPpal : Form {
        Medico[] medicos;
        Paciente[] pacientes;

        public FrmPpal() {
            InitializeComponent();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmABMMedico medicoForm = new FrmABMMedico();
            if(medicoForm.ShowDialog() == DialogResult.OK) {
                if(medicos + medicoForm.MiMedico) {
                    MessageBox.Show("Medico cargado con exito!", "Alta de medico", MessageBoxButtons.YesNo);
                }
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e) {
            medicos = new Medico[25];
            pacientes = new Paciente[25];
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Esta seguro que desea salir?", "Alta de medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;

            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmABMPaciente pacienteForm = new FrmABMPaciente();
            if (pacienteForm.ShowDialog() == DialogResult.OK) {
                if (pacientes + pacienteForm.MiPaciente) {
                    MessageBox.Show("Paciente cargado con exito!", "Alta de paciente", MessageBoxButtons.YesNo);
                }
            }
        }
    }
}

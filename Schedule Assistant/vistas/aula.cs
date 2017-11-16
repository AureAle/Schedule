using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Assistant.vistas
{
    public partial class aula : Form
    {
        private string aulas;
        public aula()
        {
            InitializeComponent();
        }

        private void bttnGuardarAula_Click(object sender, EventArgs e)
        {

            aulas = cmbAula.Text;
            Close();
        }
        public string getAula()
        {
            return this.aulas;
        }
                    
    }
}

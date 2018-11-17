using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        #region FILE
            private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Выход из приложения
            {
                this.Close();
            }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                controller.ReadFIle(openFileDialog.FileName);
            }
        }
        #endregion
    }
}

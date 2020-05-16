using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新規プロジェクトNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        
        }

        private void NewProject()
        {
            Console.WriteLine(CreateFile());
        }


        private string CreateFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                FileName = "NewProject",
                Filter = "Folder|.",
                CheckFileExists = false
            };

            string fileName = "";
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveDialog.FileName;
            }

            return fileName;
        }

    }
}

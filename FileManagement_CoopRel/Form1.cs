using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement_CoopRel
{
    public partial class Form1 : MetroForm
    {
        DocumentCreation document_creation;

        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void createYearTiles(string directory, string type)
        {
            MetroTile x;
            DirectoryInfo di = new DirectoryInfo(directory);
            
            foreach (DirectoryInfo yearDirectory in di.GetDirectories())
            {
                x = new MetroTile();
                x.Name = type + "_year_" + yearDirectory.Name;
                x.Text = "Tahun " + yearDirectory.Name;
                x.Size = new Size(286, 50);
                x.Click += new EventHandler(metrotile_Click);
                daftarTahun.Controls.Add(x);
            }
        }

        // here!
        private void metrotile_Click(object sender, EventArgs e)
        {
            MetroTile x = (MetroTile)sender;
            string[] words = x.Name.Split('_');
            string type = (words[0].Equals("dalamNegeri")) ? "Dalam Negeri" : "Luar Negeri";
            if (Application.OpenForms[words[0] + "_list_" + words[2]] == null)
            {
                DocumentList list = new DocumentList(this, type + "\\" + words[2], type);

                list.Name = words[0]+ "_list_" + words[2];
                list.Text = "Daftar Kerjasama " + type + " " + x.Text;
                list.Size = new Size(879, 565);
                list.Show();
            }
            else
            {
                Form list = Application.OpenForms[words[0] + "_list_" + words[2]];
                list.Activate();
            }
        }

        private void dalamNegeri_Click(object sender, EventArgs e)
        {
            welcomePanel.Visible = false;
            listTahunPanel.Visible = true;
            daftarTahunPanelLabel.Text = "Daftar Tahun Kerjasama Dalam Negeri";

            daftarTahun.Controls.Clear();

            string dalamNegeriDir =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\Dalam Negeri";

            createYearTiles(dalamNegeriDir, "dalamNegeri");
        }

        private void luarNegeri_Click(object sender, EventArgs e)
        {
            welcomePanel.Visible = false;
            listTahunPanel.Visible = true;
            daftarTahunPanelLabel.Text = "Daftar Tahun Kerjasama Luar Negeri";

            daftarTahun.Controls.Clear();

            string luarNegeriDir =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\Luar Negeri";

            createYearTiles(luarNegeriDir, "luarNegeri");
        }
    }
}

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
    public partial class DocumentList : MetroForm
    {
        Form1 parent;
        string path;
        string type;

        public DocumentList(Form1 parent, string path, string type)
        {
            InitializeComponent();
            this.parent = parent;
            this.path =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\" + path;
            this.type = type;
        }

        private void DocumentList_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();

            documents.View = View.Details;
            documents.Sorting = SortOrder.Ascending;
            documents.AllowColumnReorder = true;
            documents.Columns.Add("Hubungan Kerja Sama", 170, HorizontalAlignment.Left);
            documents.Columns.Add("Instansi", 170, HorizontalAlignment.Left);
            documents.Columns.Add("Format Dokumen", 120, HorizontalAlignment.Left);


            foreach (FileInfo file in files)
            {
                string[] words = file.Name.Split('_');
                var item = new ListViewItem(new[] {words[0], words[1], words[2]});
                
                documents.Items.Add(item);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DocumentCreation creation = new DocumentCreation(this, path, type);
            creation.Show();
        }
    }
}

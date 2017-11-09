using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace FileManagement_CoopRel
{
    public partial class DocumentCreation : MetroForm
    {
        DocumentList parent;
        string path;
        string type;

        public DocumentCreation(DocumentList parent, string path, string type)
        {
            InitializeComponent();
            this.parent = parent;
            this.path = path;
            this.type = type;

            // make directory
            string dalamNegeriDir = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\Dalam Negeri";

            string luarNegeriDir =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\Luar Negeri";

            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(dalamNegeriDir))
                {
                    System.IO.Directory.CreateDirectory(dalamNegeriDir);
                }

                if (!System.IO.Directory.Exists(luarNegeriDir))
                {
                    System.IO.Directory.CreateDirectory(luarNegeriDir);
                }
            }
            catch (Exception)
            {
                // Fail silently
            }
        }

        private Microsoft.Office.Interop.Word.Document configureDocument(Microsoft.Office.Interop.Word.Document writer)
        {
            // change page orientation
            // set margin
            Microsoft.Office.Interop.Word.Document result = writer;
            result.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
            result.PageSetup.LeftMargin = 15;
            result.PageSetup.TopMargin = 15;

            return result;
        }

        private void create_Click(object sender, EventArgs e)
        {
            int numColumns = 2;
            int numRows = 5;

            // create document
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Document writer = wordApp.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            writer = configureDocument(writer);


            if (type.Equals("Dalam Negeri"))
            {
                writer.Content.Text = "Kerjasama dalam negeri";
            }
            else if (type.Equals("Luar Negeri"))
            {
                writer.Content.Text = "Kerjasama luar negeri";
            }

            writer.Range(0, 22).Bold = 1;
            writer.Range(0, 22).Font.Size = 16;
            writer.Range(0, 22).ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            writer.Range(0, 22).ParagraphFormat.SpaceAfter = 24;


            // table configuration
            object endOfDoc = "\\endofdoc";
            Microsoft.Office.Interop.Word.Range rangeOfWord = writer.Bookmarks.get_Item(endOfDoc).Range;

            Microsoft.Office.Interop.Word.Table table = writer.Tables.Add(rangeOfWord, numRows, numColumns, ref missing, ref missing);
            table.Range.ParagraphFormat.SpaceAfter = 0;
            table.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            table.Range.Font.Size = 11;
            table.Range.Bold = 0;


            table.Columns[1].PreferredWidth = 200;
            table.Columns[2].PreferredWidth = 550;
            for (int i = 1; i <= numRows; i++)
                for (int j = 1; j <= numColumns; j++)
                    table.Cell(i, j).Range.Borders.Enable = 1;


            wordApp.Visible = false;
            wordApp.ShowAnimation = false;

            // populating table with data



            // save document
            
            Object savedir = path + "\\"+ relTitleTextBox.Text + "_"+ instantTextBox.Text +"_";
            writer.SaveAs2(ref savedir);
            writer.Close(ref missing, ref missing, ref missing);
            wordApp.Quit(ref missing, ref missing, ref missing);


            MessageBox.Show("Document saved");
            parent.DocumentList_Load(sender, e);
        }

        private void DocumentCreation_Load(object sender, EventArgs e)
        {
            
        }
    }
}

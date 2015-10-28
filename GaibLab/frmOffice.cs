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

namespace GaibLab
{
    public partial class frmOffice : Form
    {
        public frmOffice(String alamat)
        {
            InitializeComponent();
            browser.Navigate(alamat);
        }

        /*
        public StringBuilder Convert()
        {
            Application objWord = new Application();

            if (File.Exists(FileToSave))
            {
                File.Delete(FileToSave);
            }
            try
            {
                objWord.Documents.Open(FileName: FullFilePath);
                objWord.Visible = false;
                if (objWord.Documents.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Document oDoc = objWord.ActiveDocument;
                    oDoc.SaveAs(FileName: FileToSave, FileFormat: 10);
                    oDoc.Close(SaveChanges: false);
                }
            }
            finally
            {
                objWord.Application.Quit(SaveChanges: false);
            }
            return base.ReadConvertedFile();
        }*/
    }
}

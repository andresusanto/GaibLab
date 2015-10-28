using System;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace GaibLab
{
    public partial class frmExplorer : Form
    {
        string alamat = @"C:\Users\Andre\Documents\Visual Studio 2015\Projects\GaibLab\GaibLab\menu.xml";

        public frmExplorer()
        {
            InitializeComponent();


            try
            {
                XmlDocument dom = new XmlDocument();
                dom.Load(alamat);
                
                treeView1.Nodes.Clear();
                AddNode(dom.DocumentElement, null);
                treeView1.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    if (inTreeNode == null)
                    {

                        treeView1.Nodes.Add(new TreeNode(xNode.Attributes["text"].InnerText.ToString()));
                        tNode = treeView1.Nodes[i];
                    }
                    else
                    {
                        inTreeNode.Nodes.Add(new TreeNode(xNode.Attributes["text"].InnerText.ToString()));
                        tNode = inTreeNode.Nodes[i];
                    }

                    if (!xNode.Attributes["action"].InnerText.ToString().Equals("0"))
                    {
                        tNode.Tag = xNode.Attributes["action"].InnerText.ToString() + "~|~" + xNode.Attributes["value"].InnerText.ToString();
                    }

                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.Attributes["text"].InnerText.ToString();//(inXmlNode.OuterXml).Trim();
                if (!inXmlNode.Attributes["action"].InnerText.ToString().Equals("0"))
                {
                    inTreeNode.Tag = inXmlNode.Attributes["action"].InnerText.ToString() + "~|~" + inXmlNode.Attributes["value"].InnerText.ToString();
                }
            }
        }

        private void ubahLembarKerja(object sender, EventArgs e)
        {
            viewMenu1.Checked = false;
            viewMenu2.Checked = false;
            viewMenu3.Checked = false;
            viewMenu4.Checked = false;


            if (((ToolStripMenuItem)sender).Tag.Equals("1"))
            {
                listView1.View = View.SmallIcon;
            }else if (((ToolStripMenuItem)sender).Tag.Equals("2"))
            {
                listView1.View = View.LargeIcon;
            }
            else if (((ToolStripMenuItem)sender).Tag.Equals("3"))
            {
                listView1.View = View.Tile;
            }
            else if (((ToolStripMenuItem)sender).Tag.Equals("4"))
            {
                listView1.View = View.Details;
            }

            ((ToolStripMenuItem)sender).Checked = true;
            //listView1.View = 
        }
        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            if (e.Node.Tag == null) return;
            listView1.Items.Add("Video Pengantar Grafika");
            listView1.Items[0].ImageIndex = 5;
            listView1.Items[0].SubItems.Add("MP4");

            listView1.Items.Add("Kuliah 1 - Frame Buffer");
            listView1.Items[1].ImageIndex = 2;
            listView1.Items[1].SubItems.Add("DOCX");

            listView1.Items.Add("Sampel Gambar");
            listView1.Items[2].ImageIndex = 4;
            listView1.Items[2].SubItems.Add("JPG");

            //MessageBox.Show(e.Node.Tag.ToString());
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null) return;

            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                if (listView1.SelectedItems[i].SubItems[1].Text == "MP4")
                {
                    frmPlayer fp = new frmPlayer();
                    fp.Show();
                }else if (listView1.SelectedItems[i].SubItems[1].Text == "DOCX")
                {
                    frmOffice fo = new frmOffice(@"C:\Users\Andre\Documents\Visual Studio 2015\Projects\GaibLab\GaibLab\bin\Debug\doc.htm");
                    fo.Show();
                }
                else if (listView1.SelectedItems[i].SubItems[1].Text == "JPG")
                {
                    frmOffice fo = new frmOffice(@"C:\Users\Andre\Documents\Visual Studio 2015\Projects\GaibLab\GaibLab\bin\Debug\sample.jpg");
                    fo.Show();
                }
            }
        }

        private void recordVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecord fr = new frmRecord();
            fr.Show();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaint fp = new frmPaint();
            fp.Show();
        }
    }
}

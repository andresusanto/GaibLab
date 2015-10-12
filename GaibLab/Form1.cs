using System;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace GaibLab
{
    public partial class Form1 : Form
    {
        string alamat = @"C:\Users\Andre\Documents\Visual Studio 2015\Projects\GaibLab\GaibLab\menu.xml";

        public Form1()
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

                        treeView1.Nodes.Add(new TreeNode(xNode.Name));
                        tNode = treeView1.Nodes[i];
                    }
                    else
                    {
                        inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                        tNode = inTreeNode.Nodes[i];
                    }

                    
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.Attributes["text"].InnerText.ToString();//(inXmlNode.OuterXml).Trim();
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
        
    }
}

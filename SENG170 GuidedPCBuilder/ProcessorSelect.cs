using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENG170_GuidedPCBuilder
{
    public partial class ProcessorSelect : Form
    {
        List<Processor> processorList;
        List<Component> build = new List<Component>();
        public ProcessorSelect(List<Processor> processorList)
        {
            this.processorList = processorList;
            InitializeComponent();
        }

        //Displays the appropriate processors in the listview based upon what is checked
        private void treeView1_AfterCheck_1(object sender, TreeViewEventArgs e)
        {
            //checks all the child nodes in a tree from the checked node
            SetCheck(e.Node, e.Node.Checked);

            //Gets the list of checked 
            List<string> checkedItems = new List<string>();
            foreach (TreeNode theNode in treeView1.Nodes)
            {
                getCheckedNodes(theNode, checkedItems);
            }

            int counter = 0;
            foreach(string s in checkedItems)
            {
                foreach (Processor p in processorList)
                {
                    if(s == "QuadCore" && p.Cores == 4)
                    {
                        if (listBox1.Items.Contains(p.Name))
                        {

                        }
                        else
                        {
                            listBox1.Items.Insert(counter, p.Name);
                            counter++;
                        }
                    }
                    if (s == "8Core" && p.Cores == 8)
                    {
                        if (listBox1.Items.Contains(p.Name))
                        {

                        }
                        else
                        {
                            listBox1.Items.Insert(counter, p.Name);
                            counter++;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
            foreach(Processor p in processorList)
            {
                if(listBox1.SelectedItem.ToString() == p.Name)
                {
                    build.Add(p);
                }
            }
            MessageBox.Show(build[0].ToString());
        }

        //Tells which nodes are checked
        private void getCheckedNodes(TreeNode node, List<string> nodeNames)
        {
            //if this is a leaf...
            if (node.Nodes.Count == 0)
            {
                //if the node was checked...
                if (node.Checked)
                {
                    //add the full path to the arrayList
                    nodeNames.Add(node.Name);
                }
            }
            else
            {
                foreach (TreeNode n in node.Nodes)
                {
                    getCheckedNodes(n, nodeNames);
                }
            }
        }

        //Checks all the child nodes in the tree
        //Test comment to better get aquainted with git
        private void SetCheck(TreeNode node, bool check)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.Checked = check; //check the node
                if (n.Nodes.Count != 0)
                {
                    SetCheck(n, check);
                }
            }
        }

    }
}

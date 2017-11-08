using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ClassDG> list = new List<ClassDG>()
        {
            new ClassDG() {ID="0",PID="",name="0" },
            new ClassDG() {ID="1",PID="",name="1" },
            new ClassDG() {ID="2",PID="1",name="2" },
            new ClassDG() {ID="3",PID="1",name="3" },
            new ClassDG() {ID="4",PID="2",name="4" },
            new ClassDG() {ID="5",PID="4",name="5" }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ClassDG item in list)
            {
                if (string.IsNullOrEmpty(item.PID))
                {
                    this.treeView1.Nodes.Add(item.ID, item.name);
                }
            }

            for (int i = 0; i < this.treeView1.Nodes.Count; i++)
            {
                AddNodes(treeView1.Nodes[i], treeView1.Nodes[i].Name);
            }

        }

        void AddNodes(TreeNode treenode,string id)
        {
            List<ClassDG> lst = list.Where(p => p.PID.Equals(id)).ToList();
            if (treenode == null || lst.Count == 0)
                return;

            foreach (ClassDG item in lst)
            {
                if (treenode.Name.Equals(item.PID))
                {
                    treenode.Nodes.Add(item.ID, item.name);
                }
                for (int i = 0; i < treenode.Nodes.Count; i++)
                {
                    AddNodes(treenode.Nodes[i], item.ID);
                }
            }

        }


    }
}

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
    public partial class Form1 : Form
    {
        List<Processor> processorList = new List<Processor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAMD_Click(object sender, EventArgs e)
        {
            for (int i=0; i < processorList.Count; i++)
            {
                if (processorList[i].Manufacturer == "Intel")
                {
                    processorList.Remove(processorList[i]);
                    i--;
                }
            }

            ProcessorSelect processorSelect = new ProcessorSelect(processorList);
            processorSelect.Show();
            Hide();
        }

        private void btnIntel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < processorList.Count; i++)
            {
                if (processorList[i].Manufacturer == "AMD")
                {
                    processorList.Remove(processorList[i]);
                    i--;
                }
            }
            ProcessorSelect processorSelect = new ProcessorSelect(processorList);
            processorSelect.Show();
            Hide();
        }


        private void buildStock()
        {
            //Build Processors list
            Processor fx8350 = new Processor("FX8350", 8, 4.0, "AMD", "AM3+", 129.99);
            Processor ryzen5 = new Processor("Ryzen 5 1500X", 4, 3.5, "AMD", "AM4", 169.99);
            Processor i57500 = new Processor("i5 7500", 4, 3.4, "Intel", "LGA1151", 199.99);
            Processor i77700 = new Processor("i7 7500", 4, 3.6, "Intel", "LGA1151", 303.69);
            processorList.Add(fx8350);
            processorList.Add(ryzen5);
            processorList.Add(i57500);
            processorList.Add(i77700);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buildStock();
        }
    }
}

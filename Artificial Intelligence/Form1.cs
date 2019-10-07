using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artificial_Intelligence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Değişkenler
        private readonly List<string> MessageSource = new List<string> { "Sen: ", "Bilgisayar: " };
        private readonly DateTime ZamanEtiketi = DateTime.Now;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMessage.Text != "")
                    {
                    listBoxDiyalog.Items.Add(MessageSource[0] + "[" + ZamanEtiketi + "]: " + tbMessage.Text);
                    tbMessage.Text = "";

                }
                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxDiyalog.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDiyalog.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
            else
            {
                listBoxDiyalog.Items.Remove(listBoxDiyalog.SelectedItem);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
           // listBoxDiyalog.selec
        }

        private void btnMultiSelection_Click(object sender, EventArgs e)
        {
            if (listBoxDiyalog.SelectionMode == SelectionMode.One)
            {
                listBoxDiyalog.SelectionMode = SelectionMode.MultiSimple;
                btnMultiSelection.Text = "Tek Seçim";
            }
            else if (listBoxDiyalog.SelectionMode == SelectionMode.MultiSimple)
            {
                listBoxDiyalog.SelectionMode = SelectionMode.One;
                btnMultiSelection.Text = "Çoklu Seçim";
            }
            
        }
    }
}

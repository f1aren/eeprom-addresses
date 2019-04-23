using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            comboBox2.SelectedItem = "0";
            comboBox1.SelectedItem = "Sector A (0x08000000)";
            dataGridView1.Rows.Add(256); // создание колличество строк
        }

        private void button1_Click(object sender, EventArgs e) {
            //dataGridView1.Refresh();
            //if (dataGridView1.Get)
            int address = 0;
            if (comboBox1.SelectedItem.ToString() == "Sector A (0x08000000)") {
                
                address = 0x08000000 + 0x1000 * Convert.ToInt32(comboBox2.SelectedItem);
            } else if (comboBox1.SelectedItem.ToString() == "Sector B (0x08000004)") {
                
                address = 0x08000004 + 0x1000 * Convert.ToInt32(comboBox2.SelectedItem);
            } else if (comboBox1.SelectedItem.ToString() == "Sector C (0x08000008)") {
                
                address = 0x08000008 + 0x1000 * Convert.ToInt32(comboBox2.SelectedItem);
            } else if (comboBox1.SelectedItem.ToString() == "Sector D (0x0800000C)") {
                
                address = 0x0800000C + 0x1000 * Convert.ToInt32(comboBox2.SelectedItem);
            }

            for (int i = 0; i < 256; i++) {
              
                dataGridView1.Rows[i].SetValues(i + 1, "0x0" + Convert.ToString(address, 16).ToUpper(),
                                            "0x0" + Convert.ToString((address + 0x01), 16).ToUpper(),
                                            "0x0" + Convert.ToString((address + 0x02), 16).ToUpper(),
                                            "0x0" + Convert.ToString((address + 0x03), 16).ToUpper());
                address += 0x10;
               
                
            }
            

            /*richTextBox1.Clear();
            int address = 0;
            if (radioButton1.Checked) {
                address = 0x08000000;
            } else if (radioButton2.Checked) {
                address = 0x08000004;
            } else if (radioButton3.Checked) {
                address = 0x08000008;
            } else if (radioButton4.Checked) {
                address = 0x0800000C;
            } else {
                MessageBox.Show("Выберите адрес");
                return;
            }
            
            for (int i = 1; i <= 256; i++ ) {
                richTextBox1.Text += (i + ". 0x" + Convert.ToString(address, 16).ToUpper() 
                    + " - 0x" + Convert.ToString((address + 0x01), 16).ToUpper() 
                    + " - 0x" + Convert.ToString((address + 0x02), 16).ToUpper() 
                    + " - 0x" + Convert.ToString((address + 0x03), 16).ToUpper() + "\n");
                address += 0x10;
            }
           */
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            /*dataGridView1.Rows.Add(256); // создание колличество строк
            int address = 0;
            if (radioButton1.Checked) {
                address = 0x08000000;
            } else if (radioButton2.Checked) {
                address = 0x08000004;
            } else if (radioButton3.Checked) {
                address = 0x08000008;
            } else if (radioButton4.Checked) {
                address = 0x0800000C;
            }
            for (int i = 0; i < 256; i++) {
                dataGridView1.Rows[i].SetValues("0x" + Convert.ToString(address, 16).ToUpper(), 
                                                "0x" + Convert.ToString((address + 0x01), 16).ToUpper(),
                                                "0x" + Convert.ToString((address + 0x02), 16).ToUpper(),
                                                "0x" + Convert.ToString((address + 0x03), 16).ToUpper());
                address += 0x10;
            }*/
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

    }
}

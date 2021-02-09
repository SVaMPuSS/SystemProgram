using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            else
                MessageBox.Show("Ошибка выбора пути");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.ShowHelp = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                textBox2.Text = openFileDialog2.FileName;
            else
                MessageBox.Show("Ошибка выбора пути");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox3.Text = openFileDialog1.FileName;
            else
                MessageBox.Show("Ошибка выбора пути");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog3.FileName;
                Process.Start(openFileDialog3.FileName);
            } else
                MessageBox.Show("Ошибка выбора пути");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = folderBrowserDialog2.SelectedPath;
                Process.Start("explorer.exe", folderBrowserDialog2.SelectedPath);
            } else
                MessageBox.Show("Ошибка выбора пути");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    label4.Visible = false;
                    button4.Visible = false;
                    textBox5.Visible = false;
                    label5.Visible = false;
                    button5.Visible = false;
                    break;
                case 1:
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = true;
                    label4.Visible = true;
                    button4.Visible = true;
                    textBox5.Visible = true;
                    label5.Visible = true;
                    button5.Visible = true;
                    break;
            }
        }

    }
}
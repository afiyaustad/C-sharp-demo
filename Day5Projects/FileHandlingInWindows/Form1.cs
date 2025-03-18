﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHandlingInWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = fontDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string file1 = openFileDialog1.FileName;

                try
                {
                    fs = new FileStream(file1, FileMode.Open);
                    sr = new StreamReader(fs);
                    textBox1.Text = sr.ReadToEnd();

                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string file2 = saveFileDialog1.FileName;
                try
                {

                    fs = new FileStream(file2, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(textBox1.Text);
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                fs = new FileStream(filename, FileMode.Append);
                sw = new StreamWriter(fs);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Text appended successfully.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult sourceResult = openFileDialog1.ShowDialog();
            if (sourceResult == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;

                DialogResult destResult = saveFileDialog1.ShowDialog();
                if (destResult == DialogResult.OK)
                {
                    string destFile = saveFileDialog1.FileName;

                    File.Copy(sourceFile, destFile, true);
                    MessageBox.Show("File copied successfully.");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                if (MessageBox.Show($"Are you sure you want to delete {filename}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(filename);
                    MessageBox.Show("File deleted successfully.");
                }
            }
        }
    }

}
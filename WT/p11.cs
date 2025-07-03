// Assignment No .: 11

using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Text File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save the content from textBox1 into the selected file
                string content = textBox1.Text;

                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, content);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Show the saved file path in the TextBox
                    textBox1.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Open a Text File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog1.FileName);

                    // Display file content inside the TextBox
                    textBox1.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    // Show selected folder path inside the TextBox
                    textBox1.Text = selectedPath;
                }
            }
        }
    }
}


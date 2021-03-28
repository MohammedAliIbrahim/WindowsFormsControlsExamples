using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         //   button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {

                MessageBox.Show("الرجاء إدخال كل البيانات");
                //raise your validation exception
             
            }
            else
            {
               
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                //go to submit
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          if(fontDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Filter = @"All Files|*.txt;*.docx;*.doc;*.pdf*.xls;*.xlsx;*.pptx;*.ppt|Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt"

            //or

            //    "Word Documents|*.doc|Excel Worksheets|*.xls;*.xlsx|" +
            //                "PowerPoint Presentations|*.ppt" +
            //                "|Office Files|*.doc;*.xls;*.xlsx;*.ppt" +
            //                "|Image Files|*.jpg;*.png" +
            //                "|Text Files|*.txt;" +
            //                "|Archives Files|*.zip;*.rar" +
            //                "|All Files|*.*";


            saveFileDialog1.Filter = @"All Files|*.txt;*.docx;*.doc;*.pdf*.xls;*.xlsx;*.pptx;*.ppt|Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SaveFile(saveFileDialog1.FileName) ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            //      openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = @"All Files|*.txt;*.docx;*.doc;*.pdf*.xls;*.xlsx;*.pptx;*.ppt|Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf|Spreadsheet (.xls ,.xlsx)|  *.xls ;*.xlsx|Presentation (.pptx ,.ppt)|*.pptx;*.ppt";
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //   richTextBox1.LoadFile(openFileDialog1.FileName);

           //     var filePath = openFileDialog1.FileName;

               // Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                richTextBox1.Text = fileContent;

            }
        }
    }
}

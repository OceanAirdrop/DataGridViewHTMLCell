using DataGridViewHTML;
using HTMLDataGridViewTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace HTMLDataGridViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
		// test!
                radioButtonOverFlowEllipsis.Checked = true;

                SetupDataGridView(ref dataGridView1);

                TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel labelqwerty = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
                labelqwerty.Text = "This is an <b>HtmlLabel</b> on transparent background with <span style=\"color: red\">colors</span> and links: HTML Renderer";
                labelqwerty.Dock = DockStyle.Fill;
                panel1.Controls.Add(labelqwerty);

                TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
                htmlPanel.Text = "This is an <b>HtmlLabel</b> on transparent background with <span style=\"color: red\">colors</span> and links: HTML Renderer";
                htmlPanel.Dock = DockStyle.Fill;

                string hahah = htmlPanel.GetHtml();

                panel4.Controls.Add(htmlPanel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void SetupDataGridView(ref DataGridView dgv)
        {
            // Setting the style of the DataGridView control
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.ShowCellToolTips = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AddToDataGridView(string htmlText)
        {
            int nNewRow = dataGridView1.Rows.Add();

            int nColCount = 0;

            dataGridView1.Rows[nNewRow].Cells[nColCount++].Value = htmlText;

        }

        private void AddHTMLImageToDataGridView(string htmlText)
        {
            int nNewRow = dataGridView1.Rows.Add();

            Image image = HtmlRender.RenderToImage("<b>hello</b> there");

            int nColCount = 0;

            dataGridView1.Rows[nNewRow].Cells[nColCount++].Value = image;

        }

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = "This is an <b>HtmlLabel</b> on transparent background with <span style=\"color: red\">colors</span> and links: HTML Renderer";

            //"<b>hello</b> there";
        }


        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void buttonGenerateHTMLImage_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { }

        private void OverflowModeTriangle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    if ( c is DataGridViewHTMLCell)
                    {
                        DataGridViewHTMLCell htmlCell = (DataGridViewHTMLCell)c;
                        htmlCell.m_htmlOverflowType = HTMLOverflow.RED_TRIANGLE;
                    }
                }
            }
        }

        public string ImageToBase64(Bitmap image, System.Drawing.Imaging.ImageFormat format)
        {
            string base64String = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                base64String = Convert.ToBase64String(imageBytes);

            }
            return base64String;
        }

        private void AddRow(string html)
        {
            int nNewRow = dataGridView1.Rows.Add();
            
            int nColCount = 0;
            dataGridView1.Rows[nNewRow].Cells[nColCount++].Value = html.ToString();
            dataGridView1.Rows[nNewRow].Cells[nColCount++].Value = html.ToString();
            dataGridView1.Rows[nNewRow].Cells[nColCount++].Value = html.ToString();
        }

        private void buttonSampleHTML1_Click(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();

            //string str = "<img src=\"data:image/gif;base64,R0lGODlhDwAPAKECAAAAzMzM/////wAAACwAAAAADwAPAAACIISPeQHsrZ5ModrLlN48CXF8m2iQ3YmmKqVlRtW4MLwWACH+H09wdGltaXplZCBieSBVbGVhZCBTbWFydFNhdmVyIQAAOw==\"alt=\"Base64 encoded image\"/>";

            Bitmap image = Resources.apple;
            string base64String = ImageToBase64(image, System.Drawing.Imaging.ImageFormat.Png);

            html.AppendLine("<b>hello</b> there. Visit <a href=\"https://github.com/OceanAirdrop\">github.com/OceanAirdrop</a>  for code. Heres a <span style=\"color: red\">random</span> apple ");
            html.AppendLine( string.Format("<img src=\"data:image/gif;base64,{0}\"alt=\"Base64 encoded image\"/>", base64String));

            AddRow(html.ToString());
        }

        private void buttonSampleHTML2_Click(object sender, EventArgs e)
        {
            Bitmap image = Resources.bomb;
            string base64String = ImageToBase64(image, System.Drawing.Imaging.ImageFormat.Png);

            StringBuilder html = new StringBuilder();
            html.AppendLine("boom!!<br/>");
            html.AppendLine(string.Format("<img src=\"data:image/gif;base64,{0}\"alt=\"Base64 encoded image\"/>", base64String));

            AddRow(html.ToString());
        }

        private void buttonSampleHTML3_Click(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<ul>");
            html.AppendLine("    <li>Better performance</li>");
            html.AppendLine("    <li>Support of position CSS property</li>");
            html.AppendLine("    <li>Support of height and min-height CSS property</li>");
            html.AppendLine("    <li>Better tables support, especially layouts</li>");
            html.AppendLine("    <li>Support image align</li>");
            html.AppendLine("    <li>Handle :hover selector</li>");
            html.AppendLine("    <li>Selection by shift+arrows</li>");
            html.AppendLine("    <li>Better HTML tag parsing (optional closing tags)</li>");
            html.AppendLine("    <li>More styles support</li>");
            html.AppendLine("</ul>");

            AddRow(html.ToString());
        }

        private void buttonSampleHTML4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonOverFlowEllipsis_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    if (c is DataGridViewHTMLCell)
                    {
                        DataGridViewHTMLCell htmlCell = (DataGridViewHTMLCell)c;
                        htmlCell.m_htmlOverflowType = HTMLOverflow.ELIPSIS;
                    }
                }
            }
        }

        private void radioButtonOverFlowNone_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    if (c is DataGridViewHTMLCell)
                    {
                        DataGridViewHTMLCell htmlCell = (DataGridViewHTMLCell)c;
                        htmlCell.m_htmlOverflowType = HTMLOverflow.NONE;
                    }
                }
            }
        }

        private void radioButtonOverFlowRedTriangle_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    if (c is DataGridViewHTMLCell)
                    {
                        DataGridViewHTMLCell htmlCell = (DataGridViewHTMLCell)c;
                        htmlCell.m_htmlOverflowType = HTMLOverflow.RED_TRIANGLE;
                    }
                }
            }
        }
    }
}

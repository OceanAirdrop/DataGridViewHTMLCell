namespace HTMLDataGridViewTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSampleHTML1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSampleHTML2 = new System.Windows.Forms.Button();
            this.buttonSampleHTML3 = new System.Windows.Forms.Button();
            this.buttonSampleHTML4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOverFlowNone = new System.Windows.Forms.RadioButton();
            this.radioButtonOverFlowEllipsis = new System.Windows.Forms.RadioButton();
            this.radioButtonOverFlowRedTriangle = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new DataGridViewHTML.DataGridViewHTMLColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 72);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(285, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 72);
            this.panel4.TabIndex = 4;
            // 
            // buttonSampleHTML1
            // 
            this.buttonSampleHTML1.Location = new System.Drawing.Point(12, 408);
            this.buttonSampleHTML1.Name = "buttonSampleHTML1";
            this.buttonSampleHTML1.Size = new System.Drawing.Size(75, 37);
            this.buttonSampleHTML1.TabIndex = 9;
            this.buttonSampleHTML1.Text = "Sample HTML 1";
            this.buttonSampleHTML1.UseVisualStyleBackColor = true;
            this.buttonSampleHTML1.Click += new System.EventHandler(this.buttonSampleHTML1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "HTML Label Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "HTML Panel Control";
            // 
            // buttonSampleHTML2
            // 
            this.buttonSampleHTML2.Location = new System.Drawing.Point(93, 408);
            this.buttonSampleHTML2.Name = "buttonSampleHTML2";
            this.buttonSampleHTML2.Size = new System.Drawing.Size(75, 37);
            this.buttonSampleHTML2.TabIndex = 16;
            this.buttonSampleHTML2.Text = "Sample HTML2";
            this.buttonSampleHTML2.UseVisualStyleBackColor = true;
            this.buttonSampleHTML2.Click += new System.EventHandler(this.buttonSampleHTML2_Click);
            // 
            // buttonSampleHTML3
            // 
            this.buttonSampleHTML3.Location = new System.Drawing.Point(174, 408);
            this.buttonSampleHTML3.Name = "buttonSampleHTML3";
            this.buttonSampleHTML3.Size = new System.Drawing.Size(75, 37);
            this.buttonSampleHTML3.TabIndex = 17;
            this.buttonSampleHTML3.Text = "Sample HTML3";
            this.buttonSampleHTML3.UseVisualStyleBackColor = true;
            this.buttonSampleHTML3.Click += new System.EventHandler(this.buttonSampleHTML3_Click);
            // 
            // buttonSampleHTML4
            // 
            this.buttonSampleHTML4.Location = new System.Drawing.Point(255, 408);
            this.buttonSampleHTML4.Name = "buttonSampleHTML4";
            this.buttonSampleHTML4.Size = new System.Drawing.Size(75, 35);
            this.buttonSampleHTML4.TabIndex = 18;
            this.buttonSampleHTML4.Text = "Sample HTML 4";
            this.buttonSampleHTML4.UseVisualStyleBackColor = true;
            this.buttonSampleHTML4.Click += new System.EventHandler(this.buttonSampleHTML4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOverFlowRedTriangle);
            this.groupBox1.Controls.Add(this.radioButtonOverFlowEllipsis);
            this.groupBox1.Controls.Add(this.radioButtonOverFlowNone);
            this.groupBox1.Location = new System.Drawing.Point(506, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 90);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTML OverFlow Indicator";
            // 
            // radioButtonOverFlowNone
            // 
            this.radioButtonOverFlowNone.AutoSize = true;
            this.radioButtonOverFlowNone.Location = new System.Drawing.Point(40, 20);
            this.radioButtonOverFlowNone.Name = "radioButtonOverFlowNone";
            this.radioButtonOverFlowNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOverFlowNone.TabIndex = 0;
            this.radioButtonOverFlowNone.TabStop = true;
            this.radioButtonOverFlowNone.Text = "None";
            this.radioButtonOverFlowNone.UseVisualStyleBackColor = true;
            this.radioButtonOverFlowNone.CheckedChanged += new System.EventHandler(this.radioButtonOverFlowNone_CheckedChanged);
            // 
            // radioButtonOverFlowEllipsis
            // 
            this.radioButtonOverFlowEllipsis.AutoSize = true;
            this.radioButtonOverFlowEllipsis.Location = new System.Drawing.Point(40, 43);
            this.radioButtonOverFlowEllipsis.Name = "radioButtonOverFlowEllipsis";
            this.radioButtonOverFlowEllipsis.Size = new System.Drawing.Size(74, 17);
            this.radioButtonOverFlowEllipsis.TabIndex = 1;
            this.radioButtonOverFlowEllipsis.TabStop = true;
            this.radioButtonOverFlowEllipsis.Text = "Ellipsis (...)";
            this.radioButtonOverFlowEllipsis.UseVisualStyleBackColor = true;
            this.radioButtonOverFlowEllipsis.CheckedChanged += new System.EventHandler(this.radioButtonOverFlowEllipsis_CheckedChanged);
            // 
            // radioButtonOverFlowRedTriangle
            // 
            this.radioButtonOverFlowRedTriangle.AutoSize = true;
            this.radioButtonOverFlowRedTriangle.Location = new System.Drawing.Point(40, 66);
            this.radioButtonOverFlowRedTriangle.Name = "radioButtonOverFlowRedTriangle";
            this.radioButtonOverFlowRedTriangle.Size = new System.Drawing.Size(86, 17);
            this.radioButtonOverFlowRedTriangle.TabIndex = 2;
            this.radioButtonOverFlowRedTriangle.TabStop = true;
            this.radioButtonOverFlowRedTriangle.Text = "Red Triangle";
            this.radioButtonOverFlowRedTriangle.UseVisualStyleBackColor = true;
            this.radioButtonOverFlowRedTriangle.CheckedChanged += new System.EventHandler(this.radioButtonOverFlowRedTriangle_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnX});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 285);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HTML Text";
            this.Column1.Name = "Column1";
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "Normal Text";
            this.ColumnX.Name = "ColumnX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSampleHTML4);
            this.Controls.Add(this.buttonSampleHTML3);
            this.Controls.Add(this.buttonSampleHTML2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSampleHTML1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "DataGridViewHTMLCell - By Ocean Airdrop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button buttonSampleHTML1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewHTML.DataGridViewHTMLColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSampleHTML2;
        private System.Windows.Forms.Button buttonSampleHTML3;
        private System.Windows.Forms.Button buttonSampleHTML4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOverFlowRedTriangle;
        private System.Windows.Forms.RadioButton radioButtonOverFlowEllipsis;
        private System.Windows.Forms.RadioButton radioButtonOverFlowNone;
    }
}


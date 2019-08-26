namespace ShortestPath
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
            this.drawBtn = new System.Windows.Forms.Button();
            this.pointBtn = new System.Windows.Forms.Button();
            this.xCoorTxtBox = new System.Windows.Forms.TextBox();
            this.yCoorTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DistanceLbl2 = new System.Windows.Forms.Label();
            this.DistanceLbl1 = new System.Windows.Forms.Label();
            this.destinationLbl = new System.Windows.Forms.Label();
            this.SourceLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(51, 352);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(100, 27);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // pointBtn
            // 
            this.pointBtn.Location = new System.Drawing.Point(51, 127);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(100, 28);
            this.pointBtn.TabIndex = 1;
            this.pointBtn.Text = "Add Point";
            this.pointBtn.UseVisualStyleBackColor = true;
            this.pointBtn.Click += new System.EventHandler(this.pointBtn_Click);
            // 
            // xCoorTxtBox
            // 
            this.xCoorTxtBox.Location = new System.Drawing.Point(51, 37);
            this.xCoorTxtBox.Name = "xCoorTxtBox";
            this.xCoorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.xCoorTxtBox.TabIndex = 2;
            this.xCoorTxtBox.Text = "0";
            this.xCoorTxtBox.TextChanged += new System.EventHandler(this.xCoorTxtBox_TextChanged);
            // 
            // yCoorTxtBox
            // 
            this.yCoorTxtBox.Location = new System.Drawing.Point(51, 81);
            this.yCoorTxtBox.Name = "yCoorTxtBox";
            this.yCoorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.yCoorTxtBox.TabIndex = 3;
            this.yCoorTxtBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.DistanceLbl2);
            this.panel1.Controls.Add(this.DistanceLbl1);
            this.panel1.Controls.Add(this.destinationLbl);
            this.panel1.Controls.Add(this.SourceLbl);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.drawBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pointBtn);
            this.panel1.Controls.Add(this.yCoorTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.xCoorTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 689);
            this.panel1.TabIndex = 6;
            // 
            // DistanceLbl2
            // 
            this.DistanceLbl2.AutoSize = true;
            this.DistanceLbl2.Location = new System.Drawing.Point(128, 451);
            this.DistanceLbl2.Name = "DistanceLbl2";
            this.DistanceLbl2.Size = new System.Drawing.Size(0, 17);
            this.DistanceLbl2.TabIndex = 11;
            // 
            // DistanceLbl1
            // 
            this.DistanceLbl1.AutoSize = true;
            this.DistanceLbl1.Location = new System.Drawing.Point(12, 451);
            this.DistanceLbl1.Name = "DistanceLbl1";
            this.DistanceLbl1.Size = new System.Drawing.Size(63, 17);
            this.DistanceLbl1.TabIndex = 10;
            this.DistanceLbl1.Text = "Distance";
            // 
            // destinationLbl
            // 
            this.destinationLbl.AutoSize = true;
            this.destinationLbl.Location = new System.Drawing.Point(3, 282);
            this.destinationLbl.Name = "destinationLbl";
            this.destinationLbl.Size = new System.Drawing.Size(116, 17);
            this.destinationLbl.TabIndex = 9;
            this.destinationLbl.Text = "Destination Index";
            // 
            // SourceLbl
            // 
            this.SourceLbl.AutoSize = true;
            this.SourceLbl.Location = new System.Drawing.Point(3, 230);
            this.SourceLbl.Name = "SourceLbl";
            this.SourceLbl.Size = new System.Drawing.Size(90, 17);
            this.SourceLbl.TabIndex = 8;
            this.SourceLbl.Text = "Source Index";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 22);
            this.textBox1.TabIndex = 6;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.Location = new System.Drawing.Point(225, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(652, 689);
            this.canvas.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(883, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 692);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 689);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortest Path";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button pointBtn;
        private System.Windows.Forms.TextBox xCoorTxtBox;
        private System.Windows.Forms.TextBox yCoorTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label DistanceLbl2;
        private System.Windows.Forms.Label DistanceLbl1;
        private System.Windows.Forms.Label destinationLbl;
        private System.Windows.Forms.Label SourceLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


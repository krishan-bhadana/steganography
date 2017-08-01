namespace steganography
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonbrowsefile = new System.Windows.Forms.Button();
            this.buttonencode = new System.Windows.Forms.Button();
            this.buttondecode = new System.Windows.Forms.Button();
            this.textBoxfilepath = new System.Windows.Forms.TextBox();
            this.textBoxmessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonbrowsefile
            // 
            this.buttonbrowsefile.Location = new System.Drawing.Point(118, 332);
            this.buttonbrowsefile.Name = "buttonbrowsefile";
            this.buttonbrowsefile.Size = new System.Drawing.Size(89, 20);
            this.buttonbrowsefile.TabIndex = 1;
            this.buttonbrowsefile.Text = "Browse File";
            this.buttonbrowsefile.UseVisualStyleBackColor = true;
            this.buttonbrowsefile.Click += new System.EventHandler(this.buttonbrowsefile_Click);
            // 
            // buttonencode
            // 
            this.buttonencode.Location = new System.Drawing.Point(118, 495);
            this.buttonencode.Name = "buttonencode";
            this.buttonencode.Size = new System.Drawing.Size(84, 34);
            this.buttonencode.TabIndex = 2;
            this.buttonencode.Text = "Encode";
            this.buttonencode.UseVisualStyleBackColor = true;
            this.buttonencode.Click += new System.EventHandler(this.buttonencode_Click);
            // 
            // buttondecode
            // 
            this.buttondecode.Location = new System.Drawing.Point(370, 495);
            this.buttondecode.Name = "buttondecode";
            this.buttondecode.Size = new System.Drawing.Size(75, 34);
            this.buttondecode.TabIndex = 3;
            this.buttondecode.Text = "Decode";
            this.buttondecode.UseVisualStyleBackColor = true;
            this.buttondecode.Click += new System.EventHandler(this.buttondecode_Click);
            // 
            // textBoxfilepath
            // 
            this.textBoxfilepath.Location = new System.Drawing.Point(258, 332);
            this.textBoxfilepath.Name = "textBoxfilepath";
            this.textBoxfilepath.Size = new System.Drawing.Size(187, 20);
            this.textBoxfilepath.TabIndex = 4;
            // 
            // textBoxmessage
            // 
            this.textBoxmessage.Location = new System.Drawing.Point(258, 407);
            this.textBoxmessage.Name = "textBoxmessage";
            this.textBoxmessage.Size = new System.Drawing.Size(187, 20);
            this.textBoxmessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter text here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmessage);
            this.Controls.Add(this.textBoxfilepath);
            this.Controls.Add(this.buttondecode);
            this.Controls.Add(this.buttonencode);
            this.Controls.Add(this.buttonbrowsefile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonbrowsefile;
        private System.Windows.Forms.Button buttonencode;
        private System.Windows.Forms.Button buttondecode;
        private System.Windows.Forms.TextBox textBoxfilepath;
        private System.Windows.Forms.TextBox textBoxmessage;
        private System.Windows.Forms.Label label1;
    }
}


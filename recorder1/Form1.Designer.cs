namespace recorder1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbox_inputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_outputDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "RECORD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_inputDevices
            // 
            this.cbox_inputDevices.FormattingEnabled = true;
            this.cbox_inputDevices.Location = new System.Drawing.Point(12, 53);
            this.cbox_inputDevices.Name = "cbox_inputDevices";
            this.cbox_inputDevices.Size = new System.Drawing.Size(176, 23);
            this.cbox_inputDevices.TabIndex = 1;
            this.cbox_inputDevices.SelectedIndexChanged += new System.EventHandler(this.cbox_inputDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recording Devices";
            // 
            // cbox_outputDevices
            // 
            this.cbox_outputDevices.FormattingEnabled = true;
            this.cbox_outputDevices.Location = new System.Drawing.Point(12, 108);
            this.cbox_outputDevices.Name = "cbox_outputDevices";
            this.cbox_outputDevices.Size = new System.Drawing.Size(176, 23);
            this.cbox_outputDevices.TabIndex = 3;
            this.cbox_outputDevices.SelectedIndexChanged += new System.EventHandler(this.cbox_outputDevices_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 189);
            this.Controls.Add(this.cbox_outputDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_inputDevices);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox cbox_inputDevices;
        private Label label1;
        private ComboBox cbox_outputDevices;
    }
}
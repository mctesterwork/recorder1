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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Record = new System.Windows.Forms.Button();
            this.cbox_inputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_outputDevices = new System.Windows.Forms.ComboBox();
            this.chbox_Input = new System.Windows.Forms.CheckBox();
            this.chbox_Output = new System.Windows.Forms.CheckBox();
            this.chbox_ShowClicks = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label_SelectedPath = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbar_Quality = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Quality)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Record
            // 
            this.btn_Record.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Record.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Record.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Record.Location = new System.Drawing.Point(214, 161);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(171, 72);
            this.btn_Record.TabIndex = 0;
            this.btn_Record.Text = "RECORD";
            this.btn_Record.UseVisualStyleBackColor = false;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // cbox_inputDevices
            // 
            this.cbox_inputDevices.FormattingEnabled = true;
            this.cbox_inputDevices.Location = new System.Drawing.Point(12, 66);
            this.cbox_inputDevices.Name = "cbox_inputDevices";
            this.cbox_inputDevices.Size = new System.Drawing.Size(176, 23);
            this.cbox_inputDevices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recording devices";
            // 
            // cbox_outputDevices
            // 
            this.cbox_outputDevices.FormattingEnabled = true;
            this.cbox_outputDevices.Location = new System.Drawing.Point(12, 135);
            this.cbox_outputDevices.Name = "cbox_outputDevices";
            this.cbox_outputDevices.Size = new System.Drawing.Size(176, 23);
            this.cbox_outputDevices.TabIndex = 3;
            // 
            // chbox_Input
            // 
            this.chbox_Input.AutoSize = true;
            this.chbox_Input.Location = new System.Drawing.Point(12, 41);
            this.chbox_Input.Name = "chbox_Input";
            this.chbox_Input.Size = new System.Drawing.Size(86, 19);
            this.chbox_Input.TabIndex = 5;
            this.chbox_Input.Text = "Record Mic";
            this.chbox_Input.UseVisualStyleBackColor = true;
            // 
            // chbox_Output
            // 
            this.chbox_Output.AutoSize = true;
            this.chbox_Output.Location = new System.Drawing.Point(12, 110);
            this.chbox_Output.Name = "chbox_Output";
            this.chbox_Output.Size = new System.Drawing.Size(151, 19);
            this.chbox_Output.TabIndex = 6;
            this.chbox_Output.Text = "Record computer audio";
            this.chbox_Output.UseVisualStyleBackColor = true;
            // 
            // chbox_ShowClicks
            // 
            this.chbox_ShowClicks.AutoSize = true;
            this.chbox_ShowClicks.Location = new System.Drawing.Point(11, 203);
            this.chbox_ShowClicks.Name = "chbox_ShowClicks";
            this.chbox_ShowClicks.Size = new System.Drawing.Size(87, 19);
            this.chbox_ShowClicks.TabIndex = 7;
            this.chbox_ShowClicks.Text = "Show clicks";
            this.chbox_ShowClicks.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Video output";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(214, 37);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 9;
            this.btn_Browse.Text = "browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label_SelectedPath
            // 
            this.label_SelectedPath.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SelectedPath.Location = new System.Drawing.Point(214, 66);
            this.label_SelectedPath.Name = "label_SelectedPath";
            this.label_SelectedPath.Size = new System.Drawing.Size(171, 15);
            this.label_SelectedPath.TabIndex = 10;
            this.label_SelectedPath.Text = "...";
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "Tiny Screen Recorder is still running, you can restore it by clicking on the tray" +
    " icon";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "trayTSR";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // tbar_Quality
            // 
            this.tbar_Quality.LargeChange = 3;
            this.tbar_Quality.Location = new System.Drawing.Point(214, 113);
            this.tbar_Quality.Minimum = 3;
            this.tbar_Quality.Name = "tbar_Quality";
            this.tbar_Quality.Size = new System.Drawing.Size(91, 45);
            this.tbar_Quality.TabIndex = 11;
            this.tbar_Quality.Value = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(214, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Video quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "max.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mouse settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbar_Quality);
            this.Controls.Add(this.label_SelectedPath);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbox_ShowClicks);
            this.Controls.Add(this.chbox_Output);
            this.Controls.Add(this.chbox_Input);
            this.Controls.Add(this.cbox_outputDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_inputDevices);
            this.Controls.Add(this.btn_Record);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tiny Screen Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Quality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Record;
        private ComboBox cbox_inputDevices;
        private Label label1;
        private ComboBox cbox_outputDevices;
        private CheckBox chbox_Input;
        private CheckBox chbox_Output;
        private CheckBox chbox_ShowClicks;
        private Label label2;
        private Button btn_Browse;
        private Label label_SelectedPath;
        private NotifyIcon trayIcon;
        private TrackBar tbar_Quality;
        private Label label4;
        private Label label5;
        private Label label6;
        private FolderBrowserDialog folderBrowserDialog;
    }
}
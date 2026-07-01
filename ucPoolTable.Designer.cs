namespace PoolClub
{
    partial class ucPoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPoolTable = new System.Windows.Forms.GroupBox();
            this.pTableLight = new System.Windows.Forms.Panel();
            this.lblTablePlayer = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbPoolTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPoolTable
            // 
            this.gbPoolTable.BackColor = System.Drawing.SystemColors.ControlText;
            this.gbPoolTable.Controls.Add(this.pTableLight);
            this.gbPoolTable.Controls.Add(this.lblTablePlayer);
            this.gbPoolTable.Controls.Add(this.lblSeconds);
            this.gbPoolTable.Controls.Add(this.label4);
            this.gbPoolTable.Controls.Add(this.label3);
            this.gbPoolTable.Controls.Add(this.lblMinutes);
            this.gbPoolTable.Controls.Add(this.lblHours);
            this.gbPoolTable.Controls.Add(this.btnEnd);
            this.gbPoolTable.Controls.Add(this.btnStart);
            this.gbPoolTable.Controls.Add(this.pbImage);
            this.gbPoolTable.ForeColor = System.Drawing.SystemColors.Window;
            this.gbPoolTable.Location = new System.Drawing.Point(3, 3);
            this.gbPoolTable.Name = "gbPoolTable";
            this.gbPoolTable.Size = new System.Drawing.Size(367, 266);
            this.gbPoolTable.TabIndex = 0;
            this.gbPoolTable.TabStop = false;
            this.gbPoolTable.Text = "table";
            // 
            // pTableLight
            // 
            this.pTableLight.BackColor = System.Drawing.Color.DarkGreen;
            this.pTableLight.Location = new System.Drawing.Point(18, 21);
            this.pTableLight.Name = "pTableLight";
            this.pTableLight.Size = new System.Drawing.Size(308, 10);
            this.pTableLight.TabIndex = 10;
            // 
            // lblTablePlayer
            // 
            this.lblTablePlayer.AutoSize = true;
            this.lblTablePlayer.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablePlayer.Location = new System.Drawing.Point(59, 37);
            this.lblTablePlayer.Name = "lblTablePlayer";
            this.lblTablePlayer.Size = new System.Drawing.Size(144, 31);
            this.lblTablePlayer.TabIndex = 9;
            this.lblTablePlayer.Text = "Table Player";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSeconds.Location = new System.Drawing.Point(169, 227);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(34, 25);
            this.lblSeconds.TabIndex = 8;
            this.lblSeconds.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(141, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(73, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMinutes.Location = new System.Drawing.Point(102, 227);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(34, 25);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "00";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHours.Location = new System.Drawing.Point(33, 227);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(34, 25);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "00";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnd.Location = new System.Drawing.Point(243, 153);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(110, 38);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.Location = new System.Drawing.Point(243, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbImage.Image = global::PoolClub.Properties.Resources.pool;
            this.pbImage.Location = new System.Drawing.Point(18, 71);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(203, 135);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPoolTable);
            this.Name = "ucPoolTable";
            this.Size = new System.Drawing.Size(379, 278);
            this.gbPoolTable.ResumeLayout(false);
            this.gbPoolTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPoolTable;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTablePlayer;
        private System.Windows.Forms.Panel pTableLight;
    }
}

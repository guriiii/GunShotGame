namespace GunShotGame
{
    partial class Form2russian
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
            this.btload = new System.Windows.Forms.Button();
            this.btshoot = new System.Windows.Forms.Button();
            this.btspin = new System.Windows.Forms.Button();
            this.RETRYbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmiss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btload
            // 
            this.btload.BackColor = System.Drawing.SystemColors.ControlText;
            this.btload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btload.ForeColor = System.Drawing.SystemColors.Info;
            this.btload.Location = new System.Drawing.Point(39, 78);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(150, 54);
            this.btload.TabIndex = 0;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = false;
            this.btload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btshoot
            // 
            this.btshoot.BackColor = System.Drawing.SystemColors.ControlText;
            this.btshoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshoot.ForeColor = System.Drawing.SystemColors.Info;
            this.btshoot.Location = new System.Drawing.Point(12, 198);
            this.btshoot.Name = "btshoot";
            this.btshoot.Size = new System.Drawing.Size(106, 54);
            this.btshoot.TabIndex = 1;
            this.btshoot.Text = "Shoot";
            this.btshoot.UseVisualStyleBackColor = false;
            this.btshoot.Click += new System.EventHandler(this.btshoot_Click);
            // 
            // btspin
            // 
            this.btspin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btspin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btspin.ForeColor = System.Drawing.SystemColors.Info;
            this.btspin.Location = new System.Drawing.Point(39, 138);
            this.btspin.Name = "btspin";
            this.btspin.Size = new System.Drawing.Size(150, 54);
            this.btspin.TabIndex = 2;
            this.btspin.Text = "Spin";
            this.btspin.UseVisualStyleBackColor = false;
            this.btspin.Click += new System.EventHandler(this.btspin_Click);
            // 
            // RETRYbtn
            // 
            this.RETRYbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.RETRYbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETRYbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.RETRYbtn.Location = new System.Drawing.Point(39, 358);
            this.RETRYbtn.Name = "RETRYbtn";
            this.RETRYbtn.Size = new System.Drawing.Size(150, 54);
            this.RETRYbtn.TabIndex = 3;
            this.RETRYbtn.Text = "RETRY";
            this.RETRYbtn.UseVisualStyleBackColor = false;
            this.RETRYbtn.Click += new System.EventHandler(this.RETRYbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(236, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 452);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btmiss
            // 
            this.btmiss.BackColor = System.Drawing.SystemColors.ControlText;
            this.btmiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmiss.ForeColor = System.Drawing.SystemColors.Info;
            this.btmiss.Location = new System.Drawing.Point(124, 198);
            this.btmiss.Name = "btmiss";
            this.btmiss.Size = new System.Drawing.Size(106, 54);
            this.btmiss.TabIndex = 5;
            this.btmiss.Text = "Miss";
            this.btmiss.UseVisualStyleBackColor = false;
            this.btmiss.Click += new System.EventHandler(this.btmiss_Click);
            // 
            // Form2russian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmiss);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RETRYbtn);
            this.Controls.Add(this.btspin);
            this.Controls.Add(this.btshoot);
            this.Controls.Add(this.btload);
            this.Name = "Form2russian";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btshoot;
        private System.Windows.Forms.Button btspin;
        private System.Windows.Forms.Button RETRYbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btmiss;
    }
}
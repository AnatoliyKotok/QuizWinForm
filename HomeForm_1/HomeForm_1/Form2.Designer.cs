namespace HomeForm_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbTask = new System.Windows.Forms.Label();
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTask
            // 
            this.lbTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTask.BackColor = System.Drawing.Color.Transparent;
            this.lbTask.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTask.ForeColor = System.Drawing.Color.Maroon;
            this.lbTask.Location = new System.Drawing.Point(212, 36);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(355, 36);
            this.lbTask.TabIndex = 0;
            this.lbTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btYes
            // 
            this.btYes.BackColor = System.Drawing.Color.Transparent;
            this.btYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btYes.BackgroundImage")));
            this.btYes.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYes.ForeColor = System.Drawing.Color.Maroon;
            this.btYes.Location = new System.Drawing.Point(86, 274);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(103, 61);
            this.btYes.TabIndex = 1;
            this.btYes.Text = "Yes";
            this.btYes.UseVisualStyleBackColor = false;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Transparent;
            this.btNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNo.BackgroundImage")));
            this.btNo.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.Maroon;
            this.btNo.Location = new System.Drawing.Point(599, 274);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(99, 61);
            this.btNo.TabIndex = 2;
            this.btNo.Text = "No";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.lbTask);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
    }
}
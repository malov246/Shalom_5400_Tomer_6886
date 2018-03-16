namespace test1
{
    partial class NewMainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowDataTablesButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProcedureBtton = new System.Windows.Forms.Button();
            this.QuerysButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mathematica6Mono", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(143, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to our Amazing program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mathematica6Mono", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose an action to perform:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ShowDataTablesButton);
            this.panel1.Controls.Add(this.DeleteDataButton);
            this.panel1.Controls.Add(this.InsertDataButton);
            this.panel1.Controls.Add(this.UpdateDataButton);
            this.panel1.Location = new System.Drawing.Point(27, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 158);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Table Options";
            // 
            // ShowDataTablesButton
            // 
            this.ShowDataTablesButton.Location = new System.Drawing.Point(32, 36);
            this.ShowDataTablesButton.Name = "ShowDataTablesButton";
            this.ShowDataTablesButton.Size = new System.Drawing.Size(137, 23);
            this.ShowDataTablesButton.TabIndex = 1;
            this.ShowDataTablesButton.Text = "Show";
            this.ShowDataTablesButton.UseVisualStyleBackColor = true;
            this.ShowDataTablesButton.Click += new System.EventHandler(this.ShowDataTablesButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(32, 123);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(137, 23);
            this.DeleteDataButton.TabIndex = 9;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(32, 65);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(137, 23);
            this.InsertDataButton.TabIndex = 2;
            this.InsertDataButton.Text = "Insert";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(32, 94);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(137, 23);
            this.UpdateDataButton.TabIndex = 8;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProcedureBtton);
            this.panel2.Controls.Add(this.QuerysButton);
            this.panel2.Location = new System.Drawing.Point(27, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 81);
            this.panel2.TabIndex = 12;
            // 
            // ProcedureBtton
            // 
            this.ProcedureBtton.Location = new System.Drawing.Point(32, 41);
            this.ProcedureBtton.Name = "ProcedureBtton";
            this.ProcedureBtton.Size = new System.Drawing.Size(137, 23);
            this.ProcedureBtton.TabIndex = 3;
            this.ProcedureBtton.Text = "Perform Procedure";
            this.ProcedureBtton.UseVisualStyleBackColor = true;
            this.ProcedureBtton.Click += new System.EventHandler(this.ProcedureBtton_Click);
            // 
            // QuerysButton
            // 
            this.QuerysButton.Location = new System.Drawing.Point(32, 11);
            this.QuerysButton.Name = "QuerysButton";
            this.QuerysButton.Size = new System.Drawing.Size(137, 24);
            this.QuerysButton.TabIndex = 0;
            this.QuerysButton.Text = "Perform Products Queries";
            this.QuerysButton.UseVisualStyleBackColor = true;
            this.QuerysButton.Click += new System.EventHandler(this.QuerysButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(620, 454);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewMainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(717, 477);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMainProgram";
            this.Text = "Batene Catering Ltd.";
            this.Load += new System.EventHandler(this.NewMainProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowDataTablesButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ProcedureBtton;
        private System.Windows.Forms.Button QuerysButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
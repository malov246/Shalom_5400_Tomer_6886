namespace test1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.availableBooksButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.librariansVeteranButton = new System.Windows.Forms.Button();
            this.memberGTxButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateEligibilityButton = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Data From Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(779, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // availableBooksButton
            // 
            this.availableBooksButton.BackColor = System.Drawing.Color.Red;
            this.availableBooksButton.Location = new System.Drawing.Point(74, 277);
            this.availableBooksButton.Name = "availableBooksButton";
            this.availableBooksButton.Size = new System.Drawing.Size(191, 23);
            this.availableBooksButton.TabIndex = 6;
            this.availableBooksButton.Text = "Get all the available books";
            this.availableBooksButton.UseVisualStyleBackColor = false;
            this.availableBooksButton.Click += new System.EventHandler(this.availableBooksButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose the table";
            // 
            // librariansVeteranButton
            // 
            this.librariansVeteranButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.librariansVeteranButton.Location = new System.Drawing.Point(286, 277);
            this.librariansVeteranButton.Name = "librariansVeteranButton";
            this.librariansVeteranButton.Size = new System.Drawing.Size(226, 23);
            this.librariansVeteranButton.TabIndex = 14;
            this.librariansVeteranButton.Text = "Get all librarians veteran X years";
            this.librariansVeteranButton.UseVisualStyleBackColor = false;
            this.librariansVeteranButton.Click += new System.EventHandler(this.librariansVeteranButton_Click);
            // 
            // memberGTxButton
            // 
            this.memberGTxButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.memberGTxButton.ForeColor = System.Drawing.Color.White;
            this.memberGTxButton.Location = new System.Drawing.Point(530, 277);
            this.memberGTxButton.Name = "memberGTxButton";
            this.memberGTxButton.Size = new System.Drawing.Size(262, 23);
            this.memberGTxButton.TabIndex = 15;
            this.memberGTxButton.Text = "Get all the members whose age is greater than X.";
            this.memberGTxButton.UseVisualStyleBackColor = false;
            this.memberGTxButton.Click += new System.EventHandler(this.memberGTxButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Queries:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Procedure: ";
            // 
            // UpdateEligibilityButton
            // 
            this.UpdateEligibilityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UpdateEligibilityButton.Location = new System.Drawing.Point(74, 367);
            this.UpdateEligibilityButton.Name = "UpdateEligibilityButton";
            this.UpdateEligibilityButton.Size = new System.Drawing.Size(191, 23);
            this.UpdateEligibilityButton.TabIndex = 17;
            this.UpdateEligibilityButton.Text = "Update eligibility";
            this.UpdateEligibilityButton.UseVisualStyleBackColor = false;
            this.UpdateEligibilityButton.Click += new System.EventHandler(this.UpdateEligibilityButton_Click);
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.insert_button.Location = new System.Drawing.Point(74, 322);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(191, 23);
            this.insert_button.TabIndex = 18;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "DML:";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Green;
            this.delete_button.Location = new System.Drawing.Point(286, 322);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(226, 23);
            this.delete_button.TabIndex = 20;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update_button.Location = new System.Drawing.Point(530, 322);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(262, 23);
            this.update_button.TabIndex = 21;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(828, 408);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.UpdateEligibilityButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memberGTxButton);
            this.Controls.Add(this.librariansVeteranButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.availableBooksButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button availableBooksButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button librariansVeteranButton;
        private System.Windows.Forms.Button memberGTxButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateEligibilityButton;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


namespace test1
{
    partial class ChangeCustomer
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label kitchenIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCustomer));
            this.customerIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.kitchenIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            customerIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            kitchenIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            customerIDLabel.Location = new System.Drawing.Point(83, 119);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(127, 25);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            firstNameLabel.Location = new System.Drawing.Point(83, 159);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(112, 25);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // kitchenIDLabel
            // 
            kitchenIDLabel.AutoSize = true;
            kitchenIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            kitchenIDLabel.Location = new System.Drawing.Point(83, 241);
            kitchenIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kitchenIDLabel.Name = "kitchenIDLabel";
            kitchenIDLabel.Size = new System.Drawing.Size(108, 25);
            kitchenIDLabel.TabIndex = 5;
            kitchenIDLabel.Text = "Kitchen ID:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lastNameLabel.Location = new System.Drawing.Point(83, 198);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(112, 25);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // customerIDNumericUpDown
            // 
            this.customerIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customerIDNumericUpDown.Location = new System.Drawing.Point(229, 112);
            this.customerIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.customerIDNumericUpDown.Name = "customerIDNumericUpDown";
            this.customerIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.customerIDNumericUpDown.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameTextBox.Location = new System.Drawing.Point(229, 151);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(159, 30);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // kitchenIDNumericUpDown
            // 
            this.kitchenIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kitchenIDNumericUpDown.Location = new System.Drawing.Point(229, 234);
            this.kitchenIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kitchenIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kitchenIDNumericUpDown.Name = "kitchenIDNumericUpDown";
            this.kitchenIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.kitchenIDNumericUpDown.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameTextBox.Location = new System.Drawing.Point(229, 194);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(159, 30);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please enter the new data";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(179, 298);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 298);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDNumericUpDown);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(kitchenIDLabel);
            this.Controls.Add(this.kitchenIDNumericUpDown);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeCustomer";
            this.Text = "Change Customer";
            this.Load += new System.EventHandler(this.ChangeCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown customerIDNumericUpDown;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.NumericUpDown kitchenIDNumericUpDown;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
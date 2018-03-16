namespace test1
{
    partial class ChangeKitchen
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
            System.Windows.Forms.Label addrNumLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label kitchenIDLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKitchen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addrNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.kitchenIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            addrNumLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            kitchenIDLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrNumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addrNumLabel
            // 
            addrNumLabel.AutoSize = true;
            addrNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            addrNumLabel.Location = new System.Drawing.Point(89, 223);
            addrNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addrNumLabel.Name = "addrNumLabel";
            addrNumLabel.Size = new System.Drawing.Size(137, 25);
            addrNumLabel.TabIndex = 20;
            addrNumLabel.Text = "Address Num:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            cityLabel.Location = new System.Drawing.Point(89, 183);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(52, 25);
            cityLabel.TabIndex = 22;
            cityLabel.Text = "City:";
            // 
            // kitchenIDLabel
            // 
            kitchenIDLabel.AutoSize = true;
            kitchenIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            kitchenIDLabel.Location = new System.Drawing.Point(89, 105);
            kitchenIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kitchenIDLabel.Name = "kitchenIDLabel";
            kitchenIDLabel.Size = new System.Drawing.Size(108, 25);
            kitchenIDLabel.TabIndex = 24;
            kitchenIDLabel.Text = "Kitchen ID:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            streetLabel.Location = new System.Drawing.Point(89, 144);
            streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(70, 25);
            streetLabel.TabIndex = 26;
            streetLabel.Text = "Street:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            supplierIDLabel.Location = new System.Drawing.Point(89, 262);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(114, 25);
            supplierIDLabel.TabIndex = 28;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 351);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(264, 315);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Please enter the new data";
            // 
            // addrNumNumericUpDown
            // 
            this.addrNumNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addrNumNumericUpDown.Location = new System.Drawing.Point(236, 215);
            this.addrNumNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addrNumNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addrNumNumericUpDown.Name = "addrNumNumericUpDown";
            this.addrNumNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.addrNumNumericUpDown.TabIndex = 21;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cityTextBox.Location = new System.Drawing.Point(236, 176);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(159, 30);
            this.cityTextBox.TabIndex = 23;
            // 
            // kitchenIDNumericUpDown
            // 
            this.kitchenIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kitchenIDNumericUpDown.Location = new System.Drawing.Point(236, 97);
            this.kitchenIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kitchenIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kitchenIDNumericUpDown.Name = "kitchenIDNumericUpDown";
            this.kitchenIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.kitchenIDNumericUpDown.TabIndex = 25;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.streetTextBox.Location = new System.Drawing.Point(236, 137);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(159, 30);
            this.streetTextBox.TabIndex = 27;
            // 
            // supplierIDNumericUpDown
            // 
            this.supplierIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supplierIDNumericUpDown.Location = new System.Drawing.Point(236, 255);
            this.supplierIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.supplierIDNumericUpDown.Name = "supplierIDNumericUpDown";
            this.supplierIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.supplierIDNumericUpDown.TabIndex = 29;
            // 
            // ChangeKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(addrNumLabel);
            this.Controls.Add(this.addrNumNumericUpDown);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(kitchenIDLabel);
            this.Controls.Add(this.kitchenIDNumericUpDown);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDNumericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeKitchen";
            this.Text = "Change Kitchen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrNumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown addrNumNumericUpDown;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.NumericUpDown kitchenIDNumericUpDown;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.NumericUpDown supplierIDNumericUpDown;
    }
}
namespace test1
{
    partial class ChangeProduct
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
            System.Windows.Forms.Label caloriesPerKiloLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pricePerWeightLabel;
            System.Windows.Forms.Label productIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeProduct));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.caloriesPerKiloNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pricePerWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            caloriesPerKiloLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pricePerWeightLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesPerKiloNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // caloriesPerKiloLabel
            // 
            caloriesPerKiloLabel.AutoSize = true;
            caloriesPerKiloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            caloriesPerKiloLabel.Location = new System.Drawing.Point(87, 206);
            caloriesPerKiloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            caloriesPerKiloLabel.Name = "caloriesPerKiloLabel";
            caloriesPerKiloLabel.Size = new System.Drawing.Size(155, 25);
            caloriesPerKiloLabel.TabIndex = 23;
            caloriesPerKiloLabel.Text = "Calories Per Kg:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel.Location = new System.Drawing.Point(87, 166);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "Name:";
            // 
            // pricePerWeightLabel
            // 
            pricePerWeightLabel.AutoSize = true;
            pricePerWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            pricePerWeightLabel.Location = new System.Drawing.Point(87, 246);
            pricePerWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pricePerWeightLabel.Name = "pricePerWeightLabel";
            pricePerWeightLabel.Size = new System.Drawing.Size(127, 25);
            pricePerWeightLabel.TabIndex = 27;
            pricePerWeightLabel.Text = "Price Per Kg:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            productIDLabel.Location = new System.Drawing.Point(87, 127);
            productIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(109, 25);
            productIDLabel.TabIndex = 29;
            productIDLabel.Text = "Product ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 356);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(267, 299);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 46);
            this.label2.TabIndex = 20;
            this.label2.Text = "Please enter the new data";
            // 
            // caloriesPerKiloNumericUpDown
            // 
            this.caloriesPerKiloNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.caloriesPerKiloNumericUpDown.Location = new System.Drawing.Point(252, 198);
            this.caloriesPerKiloNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caloriesPerKiloNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.caloriesPerKiloNumericUpDown.Name = "caloriesPerKiloNumericUpDown";
            this.caloriesPerKiloNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.caloriesPerKiloNumericUpDown.TabIndex = 24;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameTextBox.Location = new System.Drawing.Point(252, 159);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 30);
            this.nameTextBox.TabIndex = 26;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // pricePerWeightNumericUpDown
            // 
            this.pricePerWeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pricePerWeightNumericUpDown.Location = new System.Drawing.Point(252, 239);
            this.pricePerWeightNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pricePerWeightNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pricePerWeightNumericUpDown.Name = "pricePerWeightNumericUpDown";
            this.pricePerWeightNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.pricePerWeightNumericUpDown.TabIndex = 28;
            // 
            // productIDNumericUpDown
            // 
            this.productIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productIDNumericUpDown.Location = new System.Drawing.Point(252, 119);
            this.productIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productIDNumericUpDown.Name = "productIDNumericUpDown";
            this.productIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.productIDNumericUpDown.TabIndex = 30;
            this.productIDNumericUpDown.ValueChanged += new System.EventHandler(this.productIDNumericUpDown_ValueChanged);
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(caloriesPerKiloLabel);
            this.Controls.Add(this.caloriesPerKiloNumericUpDown);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(pricePerWeightLabel);
            this.Controls.Add(this.pricePerWeightNumericUpDown);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDNumericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeProduct";
            this.Text = "Change Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesPerKiloNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown caloriesPerKiloNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown pricePerWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown productIDNumericUpDown;
    }
}
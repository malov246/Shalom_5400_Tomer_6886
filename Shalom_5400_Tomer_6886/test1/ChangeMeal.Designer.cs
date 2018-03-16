namespace test1
{
    partial class ChangeMeal
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
            System.Windows.Forms.Label mealIDLabel;
            System.Windows.Forms.Label mealTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMeal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mealIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mealTimeTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            mealIDLabel = new System.Windows.Forms.Label();
            mealTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            customerIDLabel.Location = new System.Drawing.Point(103, 215);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(127, 25);
            customerIDLabel.TabIndex = 23;
            customerIDLabel.Text = "Customer ID:";
            // 
            // mealIDLabel
            // 
            mealIDLabel.AutoSize = true;
            mealIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            mealIDLabel.Location = new System.Drawing.Point(103, 133);
            mealIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mealIDLabel.Name = "mealIDLabel";
            mealIDLabel.Size = new System.Drawing.Size(85, 25);
            mealIDLabel.TabIndex = 25;
            mealIDLabel.Text = "Meal ID:";
            // 
            // mealTimeLabel
            // 
            mealTimeLabel.AutoSize = true;
            mealTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            mealTimeLabel.Location = new System.Drawing.Point(103, 172);
            mealTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mealTimeLabel.Name = "mealTimeLabel";
            mealTimeLabel.Size = new System.Drawing.Size(110, 25);
            mealTimeLabel.TabIndex = 27;
            mealTimeLabel.Text = "Meal Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 350);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(265, 278);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            // customerIDNumericUpDown
            // 
            this.customerIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customerIDNumericUpDown.Location = new System.Drawing.Point(240, 208);
            this.customerIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.customerIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.customerIDNumericUpDown.Name = "customerIDNumericUpDown";
            this.customerIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.customerIDNumericUpDown.TabIndex = 24;
            // 
            // mealIDNumericUpDown
            // 
            this.mealIDNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mealIDNumericUpDown.Location = new System.Drawing.Point(240, 126);
            this.mealIDNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.mealIDNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mealIDNumericUpDown.Name = "mealIDNumericUpDown";
            this.mealIDNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.mealIDNumericUpDown.TabIndex = 26;
            // 
            // mealTimeTextBox
            // 
            this.mealTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mealTimeTextBox.Location = new System.Drawing.Point(240, 165);
            this.mealTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mealTimeTextBox.Name = "mealTimeTextBox";
            this.mealTimeTextBox.Size = new System.Drawing.Size(159, 30);
            this.mealTimeTextBox.TabIndex = 28;
            // 
            // ChangeMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDNumericUpDown);
            this.Controls.Add(mealIDLabel);
            this.Controls.Add(this.mealIDNumericUpDown);
            this.Controls.Add(mealTimeLabel);
            this.Controls.Add(this.mealTimeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeMeal";
            this.Text = "Change Meal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown customerIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown mealIDNumericUpDown;
        private System.Windows.Forms.TextBox mealTimeTextBox;
    }
}
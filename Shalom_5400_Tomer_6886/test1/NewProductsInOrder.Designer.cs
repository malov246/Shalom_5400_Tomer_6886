namespace test1
{
    partial class NewProductsInOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductsInOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShowButton = new System.Windows.Forms.Button();
            this.detailsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(460, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = ":רשימה של כל המוצרים שהוזמנו בהזמנה מהספק";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Query Table:";
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.Location = new System.Drawing.Point(348, 180);
            this.TableDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.Size = new System.Drawing.Size(540, 454);
            this.TableDataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(712, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = ":הכנס מספר הזמנה";
            // 
            // OrderIdNumericUpDown
            // 
            this.OrderIdNumericUpDown.Location = new System.Drawing.Point(623, 81);
            this.OrderIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderIdNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.OrderIdNumericUpDown.Name = "OrderIdNumericUpDown";
            this.OrderIdNumericUpDown.Size = new System.Drawing.Size(81, 22);
            this.OrderIdNumericUpDown.TabIndex = 19;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(464, 81);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(100, 28);
            this.ShowButton.TabIndex = 20;
            this.ShowButton.Text = "הצג";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // detailsCheckBox
            // 
            this.detailsCheckBox.AutoSize = true;
            this.detailsCheckBox.Location = new System.Drawing.Point(464, 113);
            this.detailsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsCheckBox.Name = "detailsCheckBox";
            this.detailsCheckBox.Size = new System.Drawing.Size(136, 21);
            this.detailsCheckBox.TabIndex = 21;
            this.detailsCheckBox.Text = "הצג את כל הנתונים";
            this.detailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewProductsInOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(937, 654);
            this.Controls.Add(this.detailsCheckBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.OrderIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewProductsInOrder";
            this.Text = "Products In Order";
            this.Load += new System.EventHandler(this.NewProductsInReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OrderIdNumericUpDown;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.CheckBox detailsCheckBox;
    }
}
namespace test1
{
    partial class NewProductsQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductsQueries));
            this.ProductsInOrderButton = new System.Windows.Forms.Button();
            this.SumReservationsButton = new System.Windows.Forms.Button();
            this.HealthyProductsButton = new System.Windows.Forms.Button();
            this.PopularProductsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsInOrderButton
            // 
            this.ProductsInOrderButton.Location = new System.Drawing.Point(53, 142);
            this.ProductsInOrderButton.Name = "ProductsInOrderButton";
            this.ProductsInOrderButton.Size = new System.Drawing.Size(155, 24);
            this.ProductsInOrderButton.TabIndex = 0;
            this.ProductsInOrderButton.Text = "Products In Order";
            this.ProductsInOrderButton.UseVisualStyleBackColor = true;
            this.ProductsInOrderButton.Click += new System.EventHandler(this.Query1Button_Click);
            // 
            // SumReservationsButton
            // 
            this.SumReservationsButton.Location = new System.Drawing.Point(53, 99);
            this.SumReservationsButton.Name = "SumReservationsButton";
            this.SumReservationsButton.Size = new System.Drawing.Size(155, 23);
            this.SumReservationsButton.TabIndex = 1;
            this.SumReservationsButton.Text = "Sum of Reservations (in kg)";
            this.SumReservationsButton.UseVisualStyleBackColor = true;
            this.SumReservationsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HealthyProductsButton
            // 
            this.HealthyProductsButton.Location = new System.Drawing.Point(53, 188);
            this.HealthyProductsButton.Name = "HealthyProductsButton";
            this.HealthyProductsButton.Size = new System.Drawing.Size(155, 23);
            this.HealthyProductsButton.TabIndex = 2;
            this.HealthyProductsButton.Text = "Healthy Products";
            this.HealthyProductsButton.UseVisualStyleBackColor = true;
            this.HealthyProductsButton.Click += new System.EventHandler(this.HealthyProductsButton_Click);
            // 
            // PopularProductsButton
            // 
            this.PopularProductsButton.Location = new System.Drawing.Point(53, 231);
            this.PopularProductsButton.Name = "PopularProductsButton";
            this.PopularProductsButton.Size = new System.Drawing.Size(155, 23);
            this.PopularProductsButton.TabIndex = 3;
            this.PopularProductsButton.Text = "Popular Products";
            this.PopularProductsButton.UseVisualStyleBackColor = true;
            this.PopularProductsButton.Click += new System.EventHandler(this.PopularProductsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mathematica6Mono", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose a query to perform:";
            // 
            // NewProductsQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(518, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PopularProductsButton);
            this.Controls.Add(this.HealthyProductsButton);
            this.Controls.Add(this.SumReservationsButton);
            this.Controls.Add(this.ProductsInOrderButton);
            this.Name = "NewProductsQueries";
            this.Text = "Products Queries";
            this.Load += new System.EventHandler(this.ProductsQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductsInOrderButton;
        private System.Windows.Forms.Button SumReservationsButton;
        private System.Windows.Forms.Button HealthyProductsButton;
        private System.Windows.Forms.Button PopularProductsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
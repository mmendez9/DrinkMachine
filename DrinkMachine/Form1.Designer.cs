namespace DrinkMachine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbCola = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLime = new System.Windows.Forms.PictureBox();
            this.pbGrape = new System.Windows.Forms.PictureBox();
            this.pbCream = new System.Windows.Forms.PictureBox();
            this.totalSales = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelCola = new System.Windows.Forms.FlowLayoutPanel();
            this.costCola = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColaLeft = new System.Windows.Forms.Label();
            this.pbBeer = new System.Windows.Forms.PictureBox();
            this.costBeer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BeerLeft = new System.Windows.Forms.Label();
            this.panelBeer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLime = new System.Windows.Forms.FlowLayoutPanel();
            this.costLime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LimeLeft = new System.Windows.Forms.Label();
            this.panelGrape = new System.Windows.Forms.FlowLayoutPanel();
            this.costGrape = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GrapeLeft = new System.Windows.Forms.Label();
            this.panelCream = new System.Windows.Forms.FlowLayoutPanel();
            this.costCream = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CreamLeft = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCream)).BeginInit();
            this.panelCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeer)).BeginInit();
            this.panelBeer.SuspendLayout();
            this.panelLime.SuspendLayout();
            this.panelGrape.SuspendLayout();
            this.panelCream.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Drink";
            // 
            // pbCola
            // 
            this.pbCola.Image = global::DrinkMachine.Properties.Resources.Cola;
            this.pbCola.Location = new System.Drawing.Point(3, 3);
            this.pbCola.Name = "pbCola";
            this.pbCola.Size = new System.Drawing.Size(70, 70);
            this.pbCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCola.TabIndex = 1;
            this.pbCola.TabStop = false;
            this.pbCola.Click += new System.EventHandler(this.pbCola_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLime
            // 
            this.pbLime.Image = global::DrinkMachine.Properties.Resources.LemonLime;
            this.pbLime.Location = new System.Drawing.Point(3, 3);
            this.pbLime.Name = "pbLime";
            this.pbLime.Size = new System.Drawing.Size(70, 70);
            this.pbLime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLime.TabIndex = 1;
            this.pbLime.TabStop = false;
            this.pbLime.Click += new System.EventHandler(this.pbLime_Click);
            // 
            // pbGrape
            // 
            this.pbGrape.Image = global::DrinkMachine.Properties.Resources.GrapeSoda;
            this.pbGrape.Location = new System.Drawing.Point(3, 3);
            this.pbGrape.Name = "pbGrape";
            this.pbGrape.Size = new System.Drawing.Size(70, 70);
            this.pbGrape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrape.TabIndex = 1;
            this.pbGrape.TabStop = false;
            this.pbGrape.Click += new System.EventHandler(this.pbGrape_Click);
            // 
            // pbCream
            // 
            this.pbCream.Image = global::DrinkMachine.Properties.Resources.CreamSoda;
            this.pbCream.Location = new System.Drawing.Point(3, 3);
            this.pbCream.Name = "pbCream";
            this.pbCream.Size = new System.Drawing.Size(70, 70);
            this.pbCream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCream.TabIndex = 1;
            this.pbCream.TabStop = false;
            this.pbCream.Click += new System.EventHandler(this.pbCream_Click);
            // 
            // totalSales
            // 
            this.totalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSales.Location = new System.Drawing.Point(45, 37);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(76, 23);
            this.totalSales.TabIndex = 4;
            this.totalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(42, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Sales";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCola
            // 
            this.panelCola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCola.Controls.Add(this.pbCola);
            this.panelCola.Controls.Add(this.costCola);
            this.panelCola.Controls.Add(this.label3);
            this.panelCola.Controls.Add(this.ColaLeft);
            this.panelCola.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCola.Location = new System.Drawing.Point(12, 28);
            this.panelCola.Name = "panelCola";
            this.panelCola.Size = new System.Drawing.Size(159, 84);
            this.panelCola.TabIndex = 13;
            // 
            // costCola
            // 
            this.costCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costCola.Location = new System.Drawing.Point(79, 0);
            this.costCola.Name = "costCola";
            this.costCola.Size = new System.Drawing.Size(66, 24);
            this.costCola.TabIndex = 5;
            this.costCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drinks Left";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColaLeft
            // 
            this.ColaLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColaLeft.Location = new System.Drawing.Point(79, 47);
            this.ColaLeft.Name = "ColaLeft";
            this.ColaLeft.Size = new System.Drawing.Size(66, 23);
            this.ColaLeft.TabIndex = 7;
            this.ColaLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBeer
            // 
            this.pbBeer.Image = global::DrinkMachine.Properties.Resources.RootBeer;
            this.pbBeer.Location = new System.Drawing.Point(3, 3);
            this.pbBeer.Name = "pbBeer";
            this.pbBeer.Size = new System.Drawing.Size(70, 70);
            this.pbBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBeer.TabIndex = 1;
            this.pbBeer.TabStop = false;
            this.pbBeer.Click += new System.EventHandler(this.pbBeer_Click);
            // 
            // costBeer
            // 
            this.costBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costBeer.Location = new System.Drawing.Point(79, 0);
            this.costBeer.Name = "costBeer";
            this.costBeer.Size = new System.Drawing.Size(66, 24);
            this.costBeer.TabIndex = 2;
            this.costBeer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(79, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Drinks Left";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BeerLeft
            // 
            this.BeerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BeerLeft.Location = new System.Drawing.Point(79, 47);
            this.BeerLeft.Name = "BeerLeft";
            this.BeerLeft.Size = new System.Drawing.Size(66, 23);
            this.BeerLeft.TabIndex = 4;
            this.BeerLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBeer
            // 
            this.panelBeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBeer.Controls.Add(this.pbBeer);
            this.panelBeer.Controls.Add(this.costBeer);
            this.panelBeer.Controls.Add(this.label5);
            this.panelBeer.Controls.Add(this.BeerLeft);
            this.panelBeer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBeer.Location = new System.Drawing.Point(177, 28);
            this.panelBeer.Name = "panelBeer";
            this.panelBeer.Size = new System.Drawing.Size(159, 84);
            this.panelBeer.TabIndex = 14;
            // 
            // panelLime
            // 
            this.panelLime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLime.Controls.Add(this.pbLime);
            this.panelLime.Controls.Add(this.costLime);
            this.panelLime.Controls.Add(this.label8);
            this.panelLime.Controls.Add(this.LimeLeft);
            this.panelLime.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelLime.Location = new System.Drawing.Point(12, 118);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(159, 83);
            this.panelLime.TabIndex = 15;
            // 
            // costLime
            // 
            this.costLime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLime.Location = new System.Drawing.Point(79, 0);
            this.costLime.Name = "costLime";
            this.costLime.Size = new System.Drawing.Size(66, 24);
            this.costLime.TabIndex = 5;
            this.costLime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(79, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Drinks Left";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LimeLeft
            // 
            this.LimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LimeLeft.Location = new System.Drawing.Point(79, 47);
            this.LimeLeft.Name = "LimeLeft";
            this.LimeLeft.Size = new System.Drawing.Size(66, 23);
            this.LimeLeft.TabIndex = 7;
            this.LimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrape
            // 
            this.panelGrape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrape.Controls.Add(this.pbGrape);
            this.panelGrape.Controls.Add(this.costGrape);
            this.panelGrape.Controls.Add(this.label11);
            this.panelGrape.Controls.Add(this.GrapeLeft);
            this.panelGrape.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelGrape.Location = new System.Drawing.Point(177, 118);
            this.panelGrape.Name = "panelGrape";
            this.panelGrape.Size = new System.Drawing.Size(159, 83);
            this.panelGrape.TabIndex = 16;
            // 
            // costGrape
            // 
            this.costGrape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costGrape.Location = new System.Drawing.Point(79, 0);
            this.costGrape.Name = "costGrape";
            this.costGrape.Size = new System.Drawing.Size(66, 24);
            this.costGrape.TabIndex = 5;
            this.costGrape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(79, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Drinks Left";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrapeLeft
            // 
            this.GrapeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrapeLeft.Location = new System.Drawing.Point(79, 47);
            this.GrapeLeft.Name = "GrapeLeft";
            this.GrapeLeft.Size = new System.Drawing.Size(66, 23);
            this.GrapeLeft.TabIndex = 7;
            this.GrapeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCream
            // 
            this.panelCream.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCream.Controls.Add(this.pbCream);
            this.panelCream.Controls.Add(this.costCream);
            this.panelCream.Controls.Add(this.label14);
            this.panelCream.Controls.Add(this.CreamLeft);
            this.panelCream.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCream.Location = new System.Drawing.Point(12, 207);
            this.panelCream.Name = "panelCream";
            this.panelCream.Size = new System.Drawing.Size(159, 83);
            this.panelCream.TabIndex = 17;
            // 
            // costCream
            // 
            this.costCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costCream.Location = new System.Drawing.Point(79, 0);
            this.costCream.Name = "costCream";
            this.costCream.Size = new System.Drawing.Size(66, 24);
            this.costCream.TabIndex = 5;
            this.costCream.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(79, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 23);
            this.label14.TabIndex = 6;
            this.label14.Text = "Drinks Left";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreamLeft
            // 
            this.CreamLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreamLeft.Location = new System.Drawing.Point(79, 47);
            this.CreamLeft.Name = "CreamLeft";
            this.CreamLeft.Size = new System.Drawing.Size(66, 23);
            this.CreamLeft.TabIndex = 7;
            this.CreamLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotal
            // 
            this.panelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTotal.Controls.Add(this.label18);
            this.panelTotal.Controls.Add(this.totalSales);
            this.panelTotal.Location = new System.Drawing.Point(177, 207);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(159, 83);
            this.panelTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 333);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelCream);
            this.Controls.Add(this.panelGrape);
            this.Controls.Add(this.panelLime);
            this.Controls.Add(this.panelBeer);
            this.Controls.Add(this.panelCola);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Drink Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCream)).EndInit();
            this.panelCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBeer)).EndInit();
            this.panelBeer.ResumeLayout(false);
            this.panelLime.ResumeLayout(false);
            this.panelGrape.ResumeLayout(false);
            this.panelCream.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbLime;
        private System.Windows.Forms.PictureBox pbGrape;
        private System.Windows.Forms.PictureBox pbCream;
        private System.Windows.Forms.Label totalSales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel panelCola;
        private System.Windows.Forms.Label costCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ColaLeft;
        private System.Windows.Forms.PictureBox pbBeer;
        private System.Windows.Forms.Label costBeer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BeerLeft;
        private System.Windows.Forms.FlowLayoutPanel panelBeer;
        private System.Windows.Forms.FlowLayoutPanel panelLime;
        private System.Windows.Forms.Label costLime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LimeLeft;
        private System.Windows.Forms.FlowLayoutPanel panelGrape;
        private System.Windows.Forms.Label costGrape;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label GrapeLeft;
        private System.Windows.Forms.FlowLayoutPanel panelCream;
        private System.Windows.Forms.Label costCream;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CreamLeft;
        private System.Windows.Forms.Panel panelTotal;
    }
}


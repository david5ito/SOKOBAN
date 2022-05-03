namespace Sokoban
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pctA = new System.Windows.Forms.PictureBox();
            this.lblPorcentA = new System.Windows.Forms.Label();
            this.lblLifeA = new System.Windows.Forms.Label();
            this.lblMoneyA = new System.Windows.Forms.Label();
            this.btnPlayA = new System.Windows.Forms.Button();
            this.btnDelA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pctB = new System.Windows.Forms.PictureBox();
            this.btnDelB = new System.Windows.Forms.Button();
            this.lblPorcenB = new System.Windows.Forms.Label();
            this.btnPlayB = new System.Windows.Forms.Button();
            this.lblLifeB = new System.Windows.Forms.Label();
            this.lblMoneyB = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pctC = new System.Windows.Forms.PictureBox();
            this.btnDelC = new System.Windows.Forms.Button();
            this.lblPorcentC = new System.Windows.Forms.Label();
            this.btnPlayC = new System.Windows.Forms.Button();
            this.lblLifeC = new System.Windows.Forms.Label();
            this.lblMoneyC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partidas";
            // 
            // pctA
            // 
            this.pctA.Location = new System.Drawing.Point(6, 15);
            this.pctA.Name = "pctA";
            this.pctA.Size = new System.Drawing.Size(247, 130);
            this.pctA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctA.TabIndex = 1;
            this.pctA.TabStop = false;
            // 
            // lblPorcentA
            // 
            this.lblPorcentA.AutoSize = true;
            this.lblPorcentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentA.Location = new System.Drawing.Point(339, 64);
            this.lblPorcentA.Name = "lblPorcentA";
            this.lblPorcentA.Size = new System.Drawing.Size(55, 31);
            this.lblPorcentA.TabIndex = 2;
            this.lblPorcentA.Text = "0%";
            // 
            // lblLifeA
            // 
            this.lblLifeA.AutoSize = true;
            this.lblLifeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeA.Location = new System.Drawing.Point(479, 58);
            this.lblLifeA.Name = "lblLifeA";
            this.lblLifeA.Size = new System.Drawing.Size(74, 24);
            this.lblLifeA.TabIndex = 3;
            this.lblLifeA.Text = "Vidas: ";
            // 
            // lblMoneyA
            // 
            this.lblMoneyA.AutoSize = true;
            this.lblMoneyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyA.Location = new System.Drawing.Point(479, 82);
            this.lblMoneyA.Name = "lblMoneyA";
            this.lblMoneyA.Size = new System.Drawing.Size(32, 24);
            this.lblMoneyA.TabIndex = 4;
            this.lblMoneyA.Text = "$0";
            // 
            // btnPlayA
            // 
            this.btnPlayA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayA.Location = new System.Drawing.Point(672, 19);
            this.btnPlayA.Name = "btnPlayA";
            this.btnPlayA.Size = new System.Drawing.Size(87, 32);
            this.btnPlayA.TabIndex = 5;
            this.btnPlayA.Text = "Jugar";
            this.btnPlayA.UseVisualStyleBackColor = true;
            // 
            // btnDelA
            // 
            this.btnDelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelA.Location = new System.Drawing.Point(672, 117);
            this.btnDelA.Name = "btnDelA";
            this.btnDelA.Size = new System.Drawing.Size(87, 32);
            this.btnDelA.TabIndex = 6;
            this.btnDelA.Text = "Eliminar";
            this.btnDelA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctA);
            this.groupBox1.Controls.Add(this.btnDelA);
            this.groupBox1.Controls.Add(this.lblPorcentA);
            this.groupBox1.Controls.Add(this.btnPlayA);
            this.groupBox1.Controls.Add(this.lblLifeA);
            this.groupBox1.Controls.Add(this.lblMoneyA);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pctB);
            this.groupBox2.Controls.Add(this.btnDelB);
            this.groupBox2.Controls.Add(this.lblPorcenB);
            this.groupBox2.Controls.Add(this.btnPlayB);
            this.groupBox2.Controls.Add(this.lblLifeB);
            this.groupBox2.Controls.Add(this.lblMoneyB);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pctB
            // 
            this.pctB.Location = new System.Drawing.Point(6, 15);
            this.pctB.Name = "pctB";
            this.pctB.Size = new System.Drawing.Size(247, 130);
            this.pctB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctB.TabIndex = 1;
            this.pctB.TabStop = false;
            // 
            // btnDelB
            // 
            this.btnDelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelB.Location = new System.Drawing.Point(672, 117);
            this.btnDelB.Name = "btnDelB";
            this.btnDelB.Size = new System.Drawing.Size(87, 32);
            this.btnDelB.TabIndex = 6;
            this.btnDelB.Text = "Eliminar";
            this.btnDelB.UseVisualStyleBackColor = true;
            // 
            // lblPorcenB
            // 
            this.lblPorcenB.AutoSize = true;
            this.lblPorcenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcenB.Location = new System.Drawing.Point(339, 64);
            this.lblPorcenB.Name = "lblPorcenB";
            this.lblPorcenB.Size = new System.Drawing.Size(55, 31);
            this.lblPorcenB.TabIndex = 2;
            this.lblPorcenB.Text = "0%";
            // 
            // btnPlayB
            // 
            this.btnPlayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayB.Location = new System.Drawing.Point(672, 19);
            this.btnPlayB.Name = "btnPlayB";
            this.btnPlayB.Size = new System.Drawing.Size(87, 32);
            this.btnPlayB.TabIndex = 5;
            this.btnPlayB.Text = "Jugar";
            this.btnPlayB.UseVisualStyleBackColor = true;
            // 
            // lblLifeB
            // 
            this.lblLifeB.AutoSize = true;
            this.lblLifeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeB.Location = new System.Drawing.Point(479, 58);
            this.lblLifeB.Name = "lblLifeB";
            this.lblLifeB.Size = new System.Drawing.Size(74, 24);
            this.lblLifeB.TabIndex = 3;
            this.lblLifeB.Text = "Vidas: ";
            // 
            // lblMoneyB
            // 
            this.lblMoneyB.AutoSize = true;
            this.lblMoneyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyB.Location = new System.Drawing.Point(479, 82);
            this.lblMoneyB.Name = "lblMoneyB";
            this.lblMoneyB.Size = new System.Drawing.Size(32, 24);
            this.lblMoneyB.TabIndex = 4;
            this.lblMoneyB.Text = "$0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pctC);
            this.groupBox3.Controls.Add(this.btnDelC);
            this.groupBox3.Controls.Add(this.lblPorcentC);
            this.groupBox3.Controls.Add(this.btnPlayC);
            this.groupBox3.Controls.Add(this.lblLifeC);
            this.groupBox3.Controls.Add(this.lblMoneyC);
            this.groupBox3.Location = new System.Drawing.Point(12, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 155);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // pctC
            // 
            this.pctC.Location = new System.Drawing.Point(6, 15);
            this.pctC.Name = "pctC";
            this.pctC.Size = new System.Drawing.Size(247, 130);
            this.pctC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctC.TabIndex = 1;
            this.pctC.TabStop = false;
            // 
            // btnDelC
            // 
            this.btnDelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelC.Location = new System.Drawing.Point(672, 117);
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(87, 32);
            this.btnDelC.TabIndex = 6;
            this.btnDelC.Text = "Eliminar";
            this.btnDelC.UseVisualStyleBackColor = true;
            // 
            // lblPorcentC
            // 
            this.lblPorcentC.AutoSize = true;
            this.lblPorcentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentC.Location = new System.Drawing.Point(339, 64);
            this.lblPorcentC.Name = "lblPorcentC";
            this.lblPorcentC.Size = new System.Drawing.Size(55, 31);
            this.lblPorcentC.TabIndex = 2;
            this.lblPorcentC.Text = "0%";
            // 
            // btnPlayC
            // 
            this.btnPlayC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayC.Location = new System.Drawing.Point(672, 19);
            this.btnPlayC.Name = "btnPlayC";
            this.btnPlayC.Size = new System.Drawing.Size(87, 32);
            this.btnPlayC.TabIndex = 5;
            this.btnPlayC.Text = "Jugar";
            this.btnPlayC.UseVisualStyleBackColor = true;
            // 
            // lblLifeC
            // 
            this.lblLifeC.AutoSize = true;
            this.lblLifeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeC.Location = new System.Drawing.Point(479, 58);
            this.lblLifeC.Name = "lblLifeC";
            this.lblLifeC.Size = new System.Drawing.Size(74, 24);
            this.lblLifeC.TabIndex = 3;
            this.lblLifeC.Text = "Vidas: ";
            // 
            // lblMoneyC
            // 
            this.lblMoneyC.AutoSize = true;
            this.lblMoneyC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyC.Location = new System.Drawing.Point(479, 82);
            this.lblMoneyC.Name = "lblMoneyC";
            this.lblMoneyC.Size = new System.Drawing.Size(32, 24);
            this.lblMoneyC.TabIndex = 4;
            this.lblMoneyC.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Menú partidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctA;
        private System.Windows.Forms.Label lblPorcentA;
        private System.Windows.Forms.Label lblLifeA;
        private System.Windows.Forms.Label lblMoneyA;
        private System.Windows.Forms.Button btnPlayA;
        private System.Windows.Forms.Button btnDelA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctB;
        private System.Windows.Forms.Button btnDelB;
        private System.Windows.Forms.Label lblPorcenB;
        private System.Windows.Forms.Button btnPlayB;
        private System.Windows.Forms.Label lblLifeB;
        private System.Windows.Forms.Label lblMoneyB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pctC;
        private System.Windows.Forms.Button btnDelC;
        private System.Windows.Forms.Label lblPorcentC;
        private System.Windows.Forms.Button btnPlayC;
        private System.Windows.Forms.Label lblLifeC;
        private System.Windows.Forms.Label lblMoneyC;
    }
}


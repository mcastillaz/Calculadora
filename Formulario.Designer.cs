namespace AppCalculator
{
    partial class Formulario
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
            this.textBoxValorA = new System.Windows.Forms.TextBox();
            this.textBoxValorB = new System.Windows.Forms.TextBox();
            this.textBoxValorC = new System.Windows.Forms.TextBox();
            this.textBoxValorX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor A";
            // 
            // textBoxValorA
            // 
            this.textBoxValorA.Location = new System.Drawing.Point(47, 75);
            this.textBoxValorA.Name = "textBoxValorA";
            this.textBoxValorA.Size = new System.Drawing.Size(68, 31);
            this.textBoxValorA.TabIndex = 3;
            // 
            // textBoxValorB
            // 
            this.textBoxValorB.Location = new System.Drawing.Point(152, 75);
            this.textBoxValorB.Name = "textBoxValorB";
            this.textBoxValorB.Size = new System.Drawing.Size(68, 31);
            this.textBoxValorB.TabIndex = 4;
            // 
            // textBoxValorC
            // 
            this.textBoxValorC.Location = new System.Drawing.Point(261, 75);
            this.textBoxValorC.Name = "textBoxValorC";
            this.textBoxValorC.Size = new System.Drawing.Size(68, 31);
            this.textBoxValorC.TabIndex = 5;
            // 
            // textBoxValorX
            // 
            this.textBoxValorX.Location = new System.Drawing.Point(370, 75);
            this.textBoxValorX.Name = "textBoxValorX";
            this.textBoxValorX.Size = new System.Drawing.Size(68, 31);
            this.textBoxValorX.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor X";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(501, 72);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(112, 34);
            this.buttonCalcular.TabIndex = 10;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 156);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValorX);
            this.Controls.Add(this.textBoxValorC);
            this.Controls.Add(this.textBoxValorB);
            this.Controls.Add(this.textBoxValorA);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxValorA;
        private TextBox textBoxValorB;
        private TextBox textBoxValorC;
        private TextBox textBoxValorX;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalcular;
    }
}
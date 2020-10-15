namespace PracticaContadores
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
            this.ButtNewNumber = new System.Windows.Forms.Button();
            this.ButDeleteNumber = new System.Windows.Forms.Button();
            this.LabelScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtNewNumber
            // 
            this.ButtNewNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ButtNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtNewNumber.ForeColor = System.Drawing.Color.White;
            this.ButtNewNumber.Location = new System.Drawing.Point(45, 127);
            this.ButtNewNumber.Name = "ButtNewNumber";
            this.ButtNewNumber.Size = new System.Drawing.Size(131, 23);
            this.ButtNewNumber.TabIndex = 0;
            this.ButtNewNumber.Text = "Numero nuevo";
            this.ButtNewNumber.UseVisualStyleBackColor = false;
            this.ButtNewNumber.Click += new System.EventHandler(this.ButtNewNumber_Click);
            // 
            // ButDeleteNumber
            // 
            this.ButDeleteNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ButDeleteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButDeleteNumber.ForeColor = System.Drawing.Color.White;
            this.ButDeleteNumber.Location = new System.Drawing.Point(189, 127);
            this.ButDeleteNumber.Name = "ButDeleteNumber";
            this.ButDeleteNumber.Size = new System.Drawing.Size(136, 23);
            this.ButDeleteNumber.TabIndex = 1;
            this.ButDeleteNumber.Text = "Borrar ultimo numero";
            this.ButDeleteNumber.UseVisualStyleBackColor = false;
            this.ButDeleteNumber.Click += new System.EventHandler(this.ButDeleteNumber_Click);
            // 
            // LabelScreen
            // 
            this.LabelScreen.AutoSize = true;
            this.LabelScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScreen.ForeColor = System.Drawing.Color.White;
            this.LabelScreen.Location = new System.Drawing.Point(165, 48);
            this.LabelScreen.Name = "LabelScreen";
            this.LabelScreen.Size = new System.Drawing.Size(40, 42);
            this.LabelScreen.TabIndex = 2;
            this.LabelScreen.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(371, 174);
            this.Controls.Add(this.LabelScreen);
            this.Controls.Add(this.ButDeleteNumber);
            this.Controls.Add(this.ButtNewNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador. v1.0 - NelsonJfsg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtNewNumber;
        private System.Windows.Forms.Button ButDeleteNumber;
        private System.Windows.Forms.Label LabelScreen;
    }
}


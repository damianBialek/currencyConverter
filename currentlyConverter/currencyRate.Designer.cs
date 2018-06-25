namespace currentlyConverter
{
    partial class currencyRate
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.currencyCodeLabel = new System.Windows.Forms.Label();
            this.currencyRateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyCodeLabel
            // 
            this.currencyCodeLabel.AutoSize = true;
            this.currencyCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currencyCodeLabel.Location = new System.Drawing.Point(-6, 0);
            this.currencyCodeLabel.Name = "currencyCodeLabel";
            this.currencyCodeLabel.Size = new System.Drawing.Size(0, 24);
            this.currencyCodeLabel.TabIndex = 0;
            // 
            // currencyRateLabel
            // 
            this.currencyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currencyRateLabel.Location = new System.Drawing.Point(60, 0);
            this.currencyRateLabel.Name = "currencyRateLabel";
            this.currencyRateLabel.Size = new System.Drawing.Size(65, 23);
            this.currencyRateLabel.TabIndex = 1;
            this.currencyRateLabel.Text = "14000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLN";
            // 
            // currencyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currencyRateLabel);
            this.Controls.Add(this.currencyCodeLabel);
            this.Name = "currencyRate";
            this.Size = new System.Drawing.Size(194, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyCodeLabel;
        private System.Windows.Forms.Label currencyRateLabel;
        private System.Windows.Forms.Label label1;
    }
}

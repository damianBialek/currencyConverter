namespace currencyConverter.Controls
{
    partial class exchangeRatesControl
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
            this.exchangeRatesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // exchangeRatesPanel
            // 
            this.exchangeRatesPanel.AutoScroll = true;
            this.exchangeRatesPanel.Location = new System.Drawing.Point(3, 3);
            this.exchangeRatesPanel.Name = "exchangeRatesPanel";
            this.exchangeRatesPanel.Size = new System.Drawing.Size(240, 580);
            this.exchangeRatesPanel.TabIndex = 0;
            // 
            // exchangeRatesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.exchangeRatesPanel);
            this.Name = "exchangeRatesControl";
            this.Size = new System.Drawing.Size(246, 585);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel exchangeRatesPanel;
    }
}

namespace currencyConverter
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.fromCurrentylComboBox = new System.Windows.Forms.ComboBox();
            this.toCurrentlyComboBox = new System.Windows.Forms.ComboBox();
            this.inputValueTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.openAllRatesButton = new System.Windows.Forms.Button();
            this.exchangeRatesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fromCurrentylComboBox
            // 
            this.fromCurrentylComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromCurrentylComboBox.FormattingEnabled = true;
            this.fromCurrentylComboBox.Location = new System.Drawing.Point(28, 89);
            this.fromCurrentylComboBox.Name = "fromCurrentylComboBox";
            this.fromCurrentylComboBox.Size = new System.Drawing.Size(121, 24);
            this.fromCurrentylComboBox.TabIndex = 1;
            // 
            // toCurrentlyComboBox
            // 
            this.toCurrentlyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toCurrentlyComboBox.FormattingEnabled = true;
            this.toCurrentlyComboBox.Location = new System.Drawing.Point(28, 145);
            this.toCurrentlyComboBox.Name = "toCurrentlyComboBox";
            this.toCurrentlyComboBox.Size = new System.Drawing.Size(121, 24);
            this.toCurrentlyComboBox.TabIndex = 1;
            // 
            // inputValueTextBox
            // 
            this.inputValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputValueTextBox.Location = new System.Drawing.Point(28, 34);
            this.inputValueTextBox.Name = "inputValueTextBox";
            this.inputValueTextBox.Size = new System.Drawing.Size(121, 24);
            this.inputValueTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.convertButton.Location = new System.Drawing.Point(28, 186);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(121, 30);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(69, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(79, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(65, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value";
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.convertedValueLabel.Location = new System.Drawing.Point(12, 254);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(155, 23);
            this.convertedValueLabel.TabIndex = 9;
            this.convertedValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openAllRatesButton
            // 
            this.openAllRatesButton.Location = new System.Drawing.Point(171, 34);
            this.openAllRatesButton.Name = "openAllRatesButton";
            this.openAllRatesButton.Size = new System.Drawing.Size(75, 23);
            this.openAllRatesButton.TabIndex = 10;
            this.openAllRatesButton.Text = "Show Rates";
            this.openAllRatesButton.UseVisualStyleBackColor = true;
            this.openAllRatesButton.Click += new System.EventHandler(this.openAllRatesButton_Click);
            // 
            // exchangeRatesPanel
            // 
            this.exchangeRatesPanel.AutoSize = true;
            this.exchangeRatesPanel.Location = new System.Drawing.Point(252, 13);
            this.exchangeRatesPanel.Name = "exchangeRatesPanel";
            this.exchangeRatesPanel.Size = new System.Drawing.Size(75, 100);
            this.exchangeRatesPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(330, 289);
            this.Controls.Add(this.exchangeRatesPanel);
            this.Controls.Add(this.openAllRatesButton);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputValueTextBox);
            this.Controls.Add(this.toCurrentlyComboBox);
            this.Controls.Add(this.fromCurrentylComboBox);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromCurrentylComboBox;
        private System.Windows.Forms.ComboBox toCurrentlyComboBox;
        private System.Windows.Forms.TextBox inputValueTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.Button openAllRatesButton;
        private System.Windows.Forms.FlowLayoutPanel exchangeRatesPanel;
    }
}


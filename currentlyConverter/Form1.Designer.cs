namespace currentlyConverter
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
            this.SuspendLayout();
            // 
            // fromCurrentylComboBox
            // 
            this.fromCurrentylComboBox.FormattingEnabled = true;
            this.fromCurrentylComboBox.Location = new System.Drawing.Point(161, 12);
            this.fromCurrentylComboBox.Name = "fromCurrentylComboBox";
            this.fromCurrentylComboBox.Size = new System.Drawing.Size(121, 21);
            this.fromCurrentylComboBox.TabIndex = 0;
            // 
            // toCurrentlyComboBox
            // 
            this.toCurrentlyComboBox.FormattingEnabled = true;
            this.toCurrentlyComboBox.Location = new System.Drawing.Point(325, 13);
            this.toCurrentlyComboBox.Name = "toCurrentlyComboBox";
            this.toCurrentlyComboBox.Size = new System.Drawing.Size(121, 21);
            this.toCurrentlyComboBox.TabIndex = 1;
            // 
            // inputValueTextBox
            // 
            this.inputValueTextBox.Location = new System.Drawing.Point(31, 13);
            this.inputValueTextBox.Name = "inputValueTextBox";
            this.inputValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputValueTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(483, 10);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 494);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputValueTextBox);
            this.Controls.Add(this.toCurrentlyComboBox);
            this.Controls.Add(this.fromCurrentylComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromCurrentylComboBox;
        private System.Windows.Forms.ComboBox toCurrentlyComboBox;
        private System.Windows.Forms.TextBox inputValueTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}


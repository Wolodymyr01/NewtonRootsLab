namespace RootsByNewton
{
    partial class RootsCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootsCalculator));
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.InputPower = new System.Windows.Forms.TextBox();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputNumber
            // 
            resources.ApplyResources(this.InputNumber, "InputNumber");
            this.InputNumber.Name = "InputNumber";
            // 
            // CalculateButton
            // 
            resources.ApplyResources(this.CalculateButton, "CalculateButton");
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateRoot);
            // 
            // InputPower
            // 
            resources.ApplyResources(this.InputPower, "InputPower");
            this.InputPower.Name = "InputPower";
            // 
            // Accuracy
            // 
            resources.ApplyResources(this.Accuracy, "Accuracy");
            this.Accuracy.Name = "Accuracy";
            // 
            // RootsCalculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.InputPower);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InputNumber);
            this.Name = "RootsCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox InputPower;
        private System.Windows.Forms.TextBox Accuracy;
    }
}


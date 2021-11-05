
namespace Zork_Builder.UserControls
{
    partial class NeighborControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // directionComboBox
            // 
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(3, 29);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(147, 21);
            this.directionComboBox.TabIndex = 1;
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(3, 3);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.Size = new System.Drawing.Size(147, 20);
            this.directionTextBox.TabIndex = 0;
            // 
            // NeighborControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.directionComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Name = "NeighborControl";
            this.Size = new System.Drawing.Size(154, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.TextBox directionTextBox;
    }
}

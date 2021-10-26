
namespace Zork_Builder
{
    partial class DeletePlayerForm
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
            this.DeleteCancelButton = new System.Windows.Forms.Button();
            this.DeleteConfirmButton = new System.Windows.Forms.Button();
            this.WARNINGLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteCancelButton
            // 
            this.DeleteCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteCancelButton.Location = new System.Drawing.Point(284, 29);
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.DeleteCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCancelButton.TabIndex = 2;
            this.DeleteCancelButton.Text = "Cancel";
            this.DeleteCancelButton.UseVisualStyleBackColor = true;
            this.DeleteCancelButton.Click += new System.EventHandler(this.DeleteCancelButton_Click);
            // 
            // DeleteConfirmButton
            // 
            this.DeleteConfirmButton.Location = new System.Drawing.Point(192, 29);
            this.DeleteConfirmButton.Name = "DeleteConfirmButton";
            this.DeleteConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteConfirmButton.TabIndex = 3;
            this.DeleteConfirmButton.Text = "Delete";
            this.DeleteConfirmButton.UseVisualStyleBackColor = true;
            // 
            // WARNINGLabel
            // 
            this.WARNINGLabel.AutoSize = true;
            this.WARNINGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WARNINGLabel.Location = new System.Drawing.Point(2, 9);
            this.WARNINGLabel.Name = "WARNINGLabel";
            this.WARNINGLabel.Size = new System.Drawing.Size(373, 17);
            this.WARNINGLabel.TabIndex = 4;
            this.WARNINGLabel.Text = "WARNING: Deleting this will perminetly remove this Room.";
            // 
            // DeletePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DeleteCancelButton;
            this.ClientSize = new System.Drawing.Size(371, 57);
            this.Controls.Add(this.WARNINGLabel);
            this.Controls.Add(this.DeleteConfirmButton);
            this.Controls.Add(this.DeleteCancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeletePlayerForm";
            this.Text = "DeletePlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteCancelButton;
        private System.Windows.Forms.Button DeleteConfirmButton;
        private System.Windows.Forms.Label WARNINGLabel;
    }
}
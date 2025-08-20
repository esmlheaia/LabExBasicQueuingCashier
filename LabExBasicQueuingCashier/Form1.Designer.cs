namespace LabExBasicQueuingCashier
{
    partial class Form1
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
            this.bttnCashier = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCashier
            // 
            this.bttnCashier.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnCashier.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCashier.Location = new System.Drawing.Point(25, 38);
            this.bttnCashier.Name = "bttnCashier";
            this.bttnCashier.Size = new System.Drawing.Size(94, 86);
            this.bttnCashier.TabIndex = 0;
            this.bttnCashier.Text = "Cashier";
            this.bttnCashier.UseVisualStyleBackColor = false;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(144, 87);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(120, 37);
            this.lblQueue.TabIndex = 1;
            this.lblQueue.Text = "Queue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position in Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(370, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.bttnCashier);
            this.Name = "Form1";
            this.Text = "QueuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCashier;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label1;
    }
}


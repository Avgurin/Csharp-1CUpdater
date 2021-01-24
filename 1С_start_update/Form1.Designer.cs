
namespace _1С_start_update
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
            this.infoTB = new System.Windows.Forms.TextBox();
            this.oldAddressTB = new System.Windows.Forms.TextBox();
            this.oldAddressLabel = new System.Windows.Forms.Label();
            this.newAddressLabel = new System.Windows.Forms.Label();
            this.newAddressTB = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoTB
            // 
            this.infoTB.Location = new System.Drawing.Point(12, 65);
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            this.infoTB.Size = new System.Drawing.Size(307, 162);
            this.infoTB.TabIndex = 0;
            this.infoTB.TabStop = false;
            // 
            // oldAddressTB
            // 
            this.oldAddressTB.Location = new System.Drawing.Point(96, 13);
            this.oldAddressTB.Name = "oldAddressTB";
            this.oldAddressTB.Size = new System.Drawing.Size(100, 20);
            this.oldAddressTB.TabIndex = 5;
            this.oldAddressTB.Text = "10.58.1.31";
            // 
            // oldAddressLabel
            // 
            this.oldAddressLabel.AutoSize = true;
            this.oldAddressLabel.Location = new System.Drawing.Point(9, 16);
            this.oldAddressLabel.Name = "oldAddressLabel";
            this.oldAddressLabel.Size = new System.Drawing.Size(81, 13);
            this.oldAddressLabel.TabIndex = 2;
            this.oldAddressLabel.Text = "Старый адрес:";
            // 
            // newAddressLabel
            // 
            this.newAddressLabel.AutoSize = true;
            this.newAddressLabel.Location = new System.Drawing.Point(13, 43);
            this.newAddressLabel.Name = "newAddressLabel";
            this.newAddressLabel.Size = new System.Drawing.Size(77, 13);
            this.newAddressLabel.TabIndex = 3;
            this.newAddressLabel.Text = "Новый адрес:";
            // 
            // newAddressTB
            // 
            this.newAddressTB.Location = new System.Drawing.Point(96, 39);
            this.newAddressTB.Name = "newAddressTB";
            this.newAddressTB.Size = new System.Drawing.Size(100, 20);
            this.newAddressTB.TabIndex = 6;
            this.newAddressTB.Text = "10.58.1.30";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(214, 13);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(104, 46);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Обновить адрес";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 237);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.newAddressTB);
            this.Controls.Add(this.newAddressLabel);
            this.Controls.Add(this.oldAddressLabel);
            this.Controls.Add(this.oldAddressTB);
            this.Controls.Add(this.infoTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1C Menu Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.TextBox oldAddressTB;
        private System.Windows.Forms.Label oldAddressLabel;
        private System.Windows.Forms.Label newAddressLabel;
        private System.Windows.Forms.TextBox newAddressTB;
        private System.Windows.Forms.Button updateBtn;
    }
}


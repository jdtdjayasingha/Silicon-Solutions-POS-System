namespace SiliconSolutions
{
    partial class Brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand));
            textEditName = new DevExpress.XtraEditors.TextEdit();
            textEditDescription = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            buttonSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditDescription.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEditName
            // 
            textEditName.Location = new System.Drawing.Point(94, 11);
            textEditName.Margin = new System.Windows.Forms.Padding(2);
            textEditName.Name = "textEditName";
            textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textEditName.Properties.Appearance.Options.UseFont = true;
            textEditName.Size = new System.Drawing.Size(186, 22);
            textEditName.TabIndex = 0;
            // 
            // textEditDescription
            // 
            textEditDescription.Location = new System.Drawing.Point(418, 11);
            textEditDescription.Margin = new System.Windows.Forms.Padding(2);
            textEditDescription.Name = "textEditDescription";
            textEditDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textEditDescription.Properties.Appearance.Options.UseFont = true;
            textEditDescription.Size = new System.Drawing.Size(186, 22);
            textEditDescription.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(11, 14);
            labelControl1.Margin = new System.Windows.Forms.Padding(2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(79, 16);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Brand Name -";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(305, 14);
            labelControl2.Margin = new System.Windows.Forms.Padding(2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(109, 16);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Brand Description -";
            // 
            // buttonSave
            // 
            buttonSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonSave.Appearance.Options.UseFont = true;
            buttonSave.Location = new System.Drawing.Point(529, 54);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.Click += buttonSave_Click;
            // 
            // Brand
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1364, 736);
            Controls.Add(buttonSave);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(textEditDescription);
            Controls.Add(textEditName);
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("Brand.IconOptions.Icon");
            Name = "Brand";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Brand";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditDescription.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
    }
}


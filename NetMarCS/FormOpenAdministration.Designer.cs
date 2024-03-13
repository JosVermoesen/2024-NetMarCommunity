namespace NetMar
{
    partial class FormOpenAdministration
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
            OpenAdministration = new Button();
            CloseButton = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            CompaniesList = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenAdministration
            // 
            OpenAdministration.DialogResult = DialogResult.OK;
            OpenAdministration.Location = new Point(12, 205);
            OpenAdministration.Name = "OpenAdministration";
            OpenAdministration.Size = new Size(111, 23);
            OpenAdministration.TabIndex = 0;
            OpenAdministration.Text = "Open Admin";
            OpenAdministration.UseVisualStyleBackColor = true;
            OpenAdministration.Click += OpenAdministration_Click;
            // 
            // CloseButton
            // 
            CloseButton.DialogResult = DialogResult.Cancel;
            CloseButton.Location = new Point(330, 205);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(111, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Sluiten";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 51);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Database";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(366, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.Yes;
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Server";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Lokaal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CompaniesList
            // 
            CompaniesList.Location = new Point(12, 69);
            CompaniesList.Name = "CompaniesList";
            CompaniesList.Size = new Size(429, 130);
            CompaniesList.TabIndex = 3;
            CompaniesList.UseCompatibleStateImageBehavior = false;
            // 
            // FormOpenAdministration
            // 
            AcceptButton = OpenAdministration;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(453, 240);
            ControlBox = false;
            Controls.Add(CompaniesList);
            Controls.Add(groupBox1);
            Controls.Add(CloseButton);
            Controls.Add(OpenAdministration);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormOpenAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bedrijf Openen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OpenAdministration;
        private Button CloseButton;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListView CompaniesList;
    }
}
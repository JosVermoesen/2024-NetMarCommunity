namespace NetMar
{
    partial class FormBYPERDAT
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
            ProcessingDate = new DateTimePicker();
            LabelProcessingDate = new Label();
            LabelAccountingPeriod = new Label();
            AccountingPeriod = new ComboBox();
            AccountingYear = new ComboBox();
            LabelAccountingYear = new Label();
            ButtonMinimize = new Button();
            SuspendLayout();
            // 
            // ProcessingDate
            // 
            ProcessingDate.Location = new Point(12, 27);
            ProcessingDate.Name = "ProcessingDate";
            ProcessingDate.Size = new Size(200, 23);
            ProcessingDate.TabIndex = 1;
            // 
            // LabelProcessingDate
            // 
            LabelProcessingDate.AutoSize = true;
            LabelProcessingDate.Location = new Point(12, 9);
            LabelProcessingDate.Name = "LabelProcessingDate";
            LabelProcessingDate.Size = new Size(104, 15);
            LabelProcessingDate.TabIndex = 0;
            LabelProcessingDate.Text = "&Datum Verwerking";
            // 
            // LabelAccountingPeriod
            // 
            LabelAccountingPeriod.AutoSize = true;
            LabelAccountingPeriod.Location = new Point(12, 59);
            LabelAccountingPeriod.Name = "LabelAccountingPeriod";
            LabelAccountingPeriod.Size = new Size(89, 15);
            LabelAccountingPeriod.TabIndex = 4;
            LabelAccountingPeriod.Text = "Actieve &Periode";
            // 
            // AccountingPeriod
            // 
            AccountingPeriod.FormattingEnabled = true;
            AccountingPeriod.Location = new Point(12, 77);
            AccountingPeriod.Name = "AccountingPeriod";
            AccountingPeriod.Size = new Size(171, 23);
            AccountingPeriod.TabIndex = 5;
            // 
            // AccountingYear
            // 
            AccountingYear.FormattingEnabled = true;
            AccountingYear.Location = new Point(221, 27);
            AccountingYear.Name = "AccountingYear";
            AccountingYear.Size = new Size(86, 23);
            AccountingYear.TabIndex = 3;
            // 
            // LabelAccountingYear
            // 
            LabelAccountingYear.AutoSize = true;
            LabelAccountingYear.Location = new Point(221, 9);
            LabelAccountingYear.Name = "LabelAccountingYear";
            LabelAccountingYear.Size = new Size(86, 15);
            LabelAccountingYear.TabIndex = 2;
            LabelAccountingYear.Text = "Actief &Boekjaar";
            // 
            // ButtonMinimize
            // 
            ButtonMinimize.Location = new Point(189, 80);
            ButtonMinimize.Name = "ButtonMinimize";
            ButtonMinimize.Size = new Size(118, 23);
            ButtonMinimize.TabIndex = 11;
            ButtonMinimize.Text = "Minimalizeren";
            ButtonMinimize.UseVisualStyleBackColor = true;
            ButtonMinimize.Click += ButtonMinimize_Click;
            // 
            // FormBYPERDAT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonMinimize;
            ClientSize = new Size(323, 115);
            ControlBox = false;
            Controls.Add(ButtonMinimize);
            Controls.Add(LabelAccountingYear);
            Controls.Add(AccountingYear);
            Controls.Add(AccountingPeriod);
            Controls.Add(LabelAccountingPeriod);
            Controls.Add(LabelProcessingDate);
            Controls.Add(ProcessingDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBYPERDAT";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Boekperiode";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ProcessingDate;
        private Label LabelProcessingDate;
        private Label LabelAccountingPeriod;
        private ComboBox AccountingPeriod;
        private ComboBox AccountingYear;
        private Label LabelAccountingYear;
        private Button ButtonMinimize;
    }
}
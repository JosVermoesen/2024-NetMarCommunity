namespace NetMar
{
    partial class FormBookOnLedger
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
            BookingType = new ComboBox();
            BookingDescription = new TextBox();
            DescriptionLabel = new Label();
            ButtonClose = new Button();
            ProcessingDate = new DateTimePicker();
            DCChoice = new GroupBox();
            TRFlag = new CheckBox();
            CChoice = new RadioButton();
            DChoice = new RadioButton();
            Amount = new TextBox();
            AmountLabel = new Label();
            ButtonClear = new Button();
            ButtonBookIT = new Button();
            ButtonAdd = new Button();
            LedgerEntries = new ListBox();
            LedgerAccountLabel = new Label();
            AmountSquareCheck = new TextBox();
            label1 = new Label();
            NumberAccount = new TextBox();
            NumberCounterAccount = new TextBox();
            NumberAccountLabel = new Label();
            NumberCounterAccountLabel = new Label();
            DCChoice.SuspendLayout();
            SuspendLayout();
            // 
            // BookingType
            // 
            BookingType.FormattingEnabled = true;
            BookingType.Location = new Point(12, 26);
            BookingType.Name = "BookingType";
            BookingType.Size = new Size(201, 23);
            BookingType.TabIndex = 0;
            // 
            // BookingDescription
            // 
            BookingDescription.Location = new Point(219, 26);
            BookingDescription.Name = "BookingDescription";
            BookingDescription.Size = new Size(213, 23);
            BookingDescription.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(219, 8);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(124, 15);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Boeking &Omschrijving";
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(357, 123);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(75, 23);
            ButtonClose.TabIndex = 3;
            ButtonClose.Text = "Sluiten";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ProcessingDate
            // 
            ProcessingDate.Location = new Point(13, 55);
            ProcessingDate.Name = "ProcessingDate";
            ProcessingDate.Size = new Size(200, 23);
            ProcessingDate.TabIndex = 4;
            // 
            // DCChoice
            // 
            DCChoice.Controls.Add(TRFlag);
            DCChoice.Controls.Add(CChoice);
            DCChoice.Controls.Add(DChoice);
            DCChoice.Location = new Point(222, 55);
            DCChoice.Name = "DCChoice";
            DCChoice.Size = new Size(121, 91);
            DCChoice.TabIndex = 5;
            DCChoice.TabStop = false;
            DCChoice.Text = "D/C Keuze";
            // 
            // TRFlag
            // 
            TRFlag.AutoSize = true;
            TRFlag.Location = new Point(6, 70);
            TRFlag.Name = "TRFlag";
            TRFlag.Size = new Size(119, 19);
            TRFlag.TabIndex = 2;
            TRFlag.Text = "&Tegenrekening (/)";
            TRFlag.UseVisualStyleBackColor = true;
            // 
            // CChoice
            // 
            CChoice.AutoSize = true;
            CChoice.Location = new Point(6, 45);
            CChoice.Name = "CChoice";
            CChoice.Size = new Size(96, 19);
            CChoice.TabIndex = 1;
            CChoice.Text = "&Crediteren (-)";
            CChoice.UseVisualStyleBackColor = true;
            // 
            // DChoice
            // 
            DChoice.AutoSize = true;
            DChoice.Checked = true;
            DChoice.Location = new Point(7, 20);
            DChoice.Name = "DChoice";
            DChoice.Size = new Size(95, 19);
            DChoice.TabIndex = 0;
            DChoice.TabStop = true;
            DChoice.Text = "&Debiteren (+)";
            DChoice.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            Amount.Location = new Point(13, 99);
            Amount.Name = "Amount";
            Amount.Size = new Size(111, 23);
            Amount.TabIndex = 6;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(13, 81);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(44, 15);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "&Bedrag";
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(357, 94);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 8;
            ButtonClear.Text = "Schoon";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonBookIT
            // 
            ButtonBookIT.Location = new Point(357, 65);
            ButtonBookIT.Name = "ButtonBookIT";
            ButtonBookIT.Size = new Size(75, 23);
            ButtonBookIT.TabIndex = 9;
            ButtonBookIT.Text = "Boeken";
            ButtonBookIT.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(138, 99);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 10;
            ButtonAdd.Text = "Toevoegen";
            ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // LedgerEntries
            // 
            LedgerEntries.FormattingEnabled = true;
            LedgerEntries.ItemHeight = 15;
            LedgerEntries.Location = new Point(12, 204);
            LedgerEntries.Name = "LedgerEntries";
            LedgerEntries.Size = new Size(548, 214);
            LedgerEntries.TabIndex = 11;
            // 
            // LedgerAccountLabel
            // 
            LedgerAccountLabel.AutoSize = true;
            LedgerAccountLabel.Location = new Point(12, 129);
            LedgerAccountLabel.Name = "LedgerAccountLabel";
            LedgerAccountLabel.Size = new Size(77, 15);
            LedgerAccountLabel.TabIndex = 12;
            LedgerAccountLabel.Text = "Rekening(en)";
            // 
            // AmountSquareCheck
            // 
            AmountSquareCheck.BackColor = SystemColors.Info;
            AmountSquareCheck.ForeColor = SystemColors.WindowText;
            AmountSquareCheck.Location = new Point(449, 66);
            AmountSquareCheck.Name = "AmountSquareCheck";
            AmountSquareCheck.Size = new Size(111, 23);
            AmountSquareCheck.TabIndex = 13;
            AmountSquareCheck.TabStop = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(449, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 35);
            label1.TabIndex = 14;
            label1.Text = "Saldo nog toe te wijzen";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // NumberAccount
            // 
            NumberAccount.Location = new Point(13, 147);
            NumberAccount.Name = "NumberAccount";
            NumberAccount.Size = new Size(111, 23);
            NumberAccount.TabIndex = 15;
            // 
            // NumberCounterAccount
            // 
            NumberCounterAccount.Location = new Point(13, 176);
            NumberCounterAccount.Name = "NumberCounterAccount";
            NumberCounterAccount.Size = new Size(111, 23);
            NumberCounterAccount.TabIndex = 16;
            // 
            // NumberAccountLabel
            // 
            NumberAccountLabel.BorderStyle = BorderStyle.Fixed3D;
            NumberAccountLabel.Location = new Point(138, 149);
            NumberAccountLabel.Name = "NumberAccountLabel";
            NumberAccountLabel.Size = new Size(201, 21);
            NumberAccountLabel.TabIndex = 17;
            NumberAccountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // NumberCounterAccountLabel
            // 
            NumberCounterAccountLabel.BorderStyle = BorderStyle.Fixed3D;
            NumberCounterAccountLabel.Location = new Point(138, 178);
            NumberCounterAccountLabel.Name = "NumberCounterAccountLabel";
            NumberCounterAccountLabel.Size = new Size(201, 21);
            NumberCounterAccountLabel.TabIndex = 18;
            NumberCounterAccountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // FormBookOnLedger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonClose;
            ClientSize = new Size(565, 424);
            ControlBox = false;
            Controls.Add(NumberCounterAccountLabel);
            Controls.Add(NumberAccountLabel);
            Controls.Add(NumberCounterAccount);
            Controls.Add(NumberAccount);
            Controls.Add(label1);
            Controls.Add(AmountSquareCheck);
            Controls.Add(LedgerAccountLabel);
            Controls.Add(LedgerEntries);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonBookIT);
            Controls.Add(ButtonClear);
            Controls.Add(AmountLabel);
            Controls.Add(Amount);
            Controls.Add(DCChoice);
            Controls.Add(ProcessingDate);
            Controls.Add(ButtonClose);
            Controls.Add(DescriptionLabel);
            Controls.Add(BookingDescription);
            Controls.Add(BookingType);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormBookOnLedger";
            StartPosition = FormStartPosition.Manual;
            Text = "Ctrl+Shift+F5 Diverse Posten";
            DCChoice.ResumeLayout(false);
            DCChoice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BookingType;
        private TextBox BookingDescription;
        private Label DescriptionLabel;
        private Button ButtonClose;
        private DateTimePicker ProcessingDate;
        private GroupBox DCChoice;
        private RadioButton CChoice;
        private RadioButton DChoice;
        private CheckBox TRFlag;
        private TextBox Amount;
        private Label AmountLabel;
        private Button ButtonClear;
        private Button ButtonBookIT;
        private Button ButtonAdd;
        private ListBox LedgerEntries;
        private Label LedgerAccountLabel;
        private TextBox AmountSquareCheck;
        private Label label1;
        private TextBox NumberAccount;
        private TextBox NumberCounterAccount;
        private Label NumberAccountLabel;
        private Label NumberCounterAccountLabel;
    }
}
namespace C__Translator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            textOutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            cmbSourceLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            cmbTargetLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            btnTranslate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.DefaultText = "";
            textInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textInput.Font = new Font("The Bold Font", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            textInput.ForeColor = Color.Black;
            textInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textInput.Location = new Point(8, 16);
            textInput.Margin = new Padding(4, 3, 4, 3);
            textInput.Name = "textInput";
            textInput.PasswordChar = '\0';
            textInput.PlaceholderForeColor = Color.Black;
            textInput.PlaceholderText = "Type In Here";
            textInput.SelectedText = "";
            textInput.Size = new Size(392, 312);
            textInput.TabIndex = 0;
            textInput.TextOffset = new Point(0, -110);
            // 
            // textOutput
            // 
            textOutput.DefaultText = "";
            textOutput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textOutput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textOutput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textOutput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textOutput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textOutput.Font = new Font("The Bold Font", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            textOutput.ForeColor = Color.Black;
            textOutput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textOutput.Location = new Point(400, 16);
            textOutput.Margin = new Padding(4, 3, 4, 3);
            textOutput.Name = "textOutput";
            textOutput.PasswordChar = '\0';
            textOutput.PlaceholderForeColor = Color.Black;
            textOutput.PlaceholderText = "Translated Text...";
            textOutput.ReadOnly = true;
            textOutput.SelectedText = "";
            textOutput.Size = new Size(392, 312);
            textOutput.TabIndex = 1;
            textOutput.TextOffset = new Point(0, -110);
            textOutput.TextChanged += textOutput_TextChanged;
            // 
            // cmbSourceLanguage
            // 
            cmbSourceLanguage.BackColor = Color.Transparent;
            cmbSourceLanguage.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSourceLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSourceLanguage.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbSourceLanguage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbSourceLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSourceLanguage.ForeColor = Color.FromArgb(68, 88, 112);
            cmbSourceLanguage.ItemHeight = 30;
            cmbSourceLanguage.Location = new Point(109, 359);
            cmbSourceLanguage.Name = "cmbSourceLanguage";
            cmbSourceLanguage.Size = new Size(140, 36);
            cmbSourceLanguage.TabIndex = 2;
            // 
            // cmbTargetLanguage
            // 
            cmbTargetLanguage.BackColor = Color.Transparent;
            cmbTargetLanguage.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTargetLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTargetLanguage.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTargetLanguage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTargetLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTargetLanguage.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTargetLanguage.ItemHeight = 30;
            cmbTargetLanguage.Location = new Point(543, 359);
            cmbTargetLanguage.Name = "cmbTargetLanguage";
            cmbTargetLanguage.Size = new Size(140, 36);
            cmbTargetLanguage.TabIndex = 3;
            // 
            // btnTranslate
            // 
            btnTranslate.DisabledState.BorderColor = Color.DarkGray;
            btnTranslate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTranslate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTranslate.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnTranslate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTranslate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTranslate.ForeColor = Color.White;
            btnTranslate.Location = new Point(297, 389);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(180, 45);
            btnTranslate.TabIndex = 4;
            btnTranslate.Text = "Translate";
            btnTranslate.Click += btnTranslate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTranslate);
            Controls.Add(cmbTargetLanguage);
            Controls.Add(cmbSourceLanguage);
            Controls.Add(textOutput);
            Controls.Add(textInput);
            ForeColor = Color.FromArgb(68, 88, 112);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Translator";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textOutput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnTranslate;
    }
}
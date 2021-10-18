
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.label_AboutLetter = new System.Windows.Forms.Label();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.textbox_Letter = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FindLetter = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Location = new System.Drawing.Point(80, 57);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(131, 13);
            this.label_AboutInput.TabIndex = 0;
            this.label_AboutInput.Text = "Набор строк для поиска";
            this.label_AboutInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_AboutLetter
            // 
            this.label_AboutLetter.AutoSize = true;
            this.label_AboutLetter.Location = new System.Drawing.Point(292, 57);
            this.label_AboutLetter.Name = "label_AboutLetter";
            this.label_AboutLetter.Size = new System.Drawing.Size(76, 13);
            this.label_AboutLetter.TabIndex = 1;
            this.label_AboutLetter.Text = "Буква поиска";
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Items.AddRange(new object[] {
            "Нпвмопмтгшыурт впшрыувирмщыгшрйЗНГЫИМЬДЮШРОьтяшчсжщфуа",
            "пяжыдпржщшптЫУПШожэй2цукенгшщзхъфЫВАПРОЛДЖЭ\\фывапролджэ\\ячсмитьбю."});
            this.listBox_Input.Location = new System.Drawing.Point(83, 123);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(471, 69);
            this.listBox_Input.TabIndex = 2;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // textbox_Letter
            // 
            this.textbox_Letter.Location = new System.Drawing.Point(281, 97);
            this.textbox_Letter.Name = "textbox_Letter";
            this.textbox_Letter.Size = new System.Drawing.Size(100, 20);
            this.textbox_Letter.TabIndex = 3;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(39, 385);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(160, 385);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(295, 385);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_FindLetter
            // 
            this.button_FindLetter.Location = new System.Drawing.Point(295, 299);
            this.button_FindLetter.Name = "button_FindLetter";
            this.button_FindLetter.Size = new System.Drawing.Size(75, 23);
            this.button_FindLetter.TabIndex = 7;
            this.button_FindLetter.Text = "Посчитать";
            this.button_FindLetter.UseVisualStyleBackColor = true;
            this.button_FindLetter.Click += new System.EventHandler(this.button_FindLetter_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt|*.txt";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button_FindLetter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textbox_Letter);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.label_AboutLetter);
            this.Controls.Add(this.label_AboutInput);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.Label label_AboutLetter;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.TextBox textbox_Letter;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FindLetter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    }
}


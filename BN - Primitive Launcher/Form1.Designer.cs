﻿
namespace BN_Primitive_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kenanBox = new System.Windows.Forms.CheckBox();
            this.backupBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.graveyardBox = new System.Windows.Forms.CheckBox();
            this.memorialBox = new System.Windows.Forms.CheckBox();
            this.templatesBox = new System.Windows.Forms.CheckBox();
            this.configBox = new System.Windows.Forms.CheckBox();
            this.fontBox = new System.Windows.Forms.CheckBox();
            this.soundBox = new System.Windows.Forms.CheckBox();
            this.ModsBox = new System.Windows.Forms.CheckBox();
            this.saveBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BN root folder:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(169, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(132, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(63, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 152);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(259, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Click += new System.EventHandler(this.statusStrip1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(88, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Folders to carry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(81, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Update completed!";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(103, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Backup...";
            this.label4.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(51, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BN_Primitive_Launcher.Properties.Settings.Default, "GameState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cataclysmbn-win64-tiles-o3",
            "cataclysmbn-win64-tiles",
            "cataclysmbn-win32-tiles"});
            this.comboBox1.Location = new System.Drawing.Point(52, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = global::BN_Primitive_Launcher.Properties.Settings.Default.GameState;
            // 
            // kenanBox
            // 
            this.kenanBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.KenanState;
            this.kenanBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kenanBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "KenanState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kenanBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kenanBox.Location = new System.Drawing.Point(51, 311);
            this.kenanBox.Name = "kenanBox";
            this.kenanBox.Size = new System.Drawing.Size(196, 17);
            this.kenanBox.TabIndex = 20;
            this.kenanBox.Text = "Install Kenan\'s modpack";
            this.kenanBox.UseVisualStyleBackColor = true;
            // 
            // backupBox
            // 
            this.backupBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.backupBoxState;
            this.backupBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "backupBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backupBox.Location = new System.Drawing.Point(51, 288);
            this.backupBox.Name = "backupBox";
            this.backupBox.Size = new System.Drawing.Size(196, 17);
            this.backupBox.TabIndex = 15;
            this.backupBox.Text = "Current version full backup";
            this.backupBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BN_Primitive_Launcher.Properties.Settings.Default, "TextboxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(63, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = global::BN_Primitive_Launcher.Properties.Settings.Default.TextboxState;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // graveyardBox
            // 
            this.graveyardBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.graveyardBoxState;
            this.graveyardBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.graveyardBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "graveyardBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.graveyardBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graveyardBox.Location = new System.Drawing.Point(130, 265);
            this.graveyardBox.Name = "graveyardBox";
            this.graveyardBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.graveyardBox.Size = new System.Drawing.Size(117, 17);
            this.graveyardBox.TabIndex = 13;
            this.graveyardBox.Text = "graveyard folder\\";
            this.graveyardBox.UseVisualStyleBackColor = true;
            // 
            // memorialBox
            // 
            this.memorialBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.memorialBoxState;
            this.memorialBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memorialBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "memorialBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memorialBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.memorialBox.Location = new System.Drawing.Point(12, 265);
            this.memorialBox.Name = "memorialBox";
            this.memorialBox.Size = new System.Drawing.Size(114, 17);
            this.memorialBox.TabIndex = 12;
            this.memorialBox.Text = "\\memorial folder";
            this.memorialBox.UseVisualStyleBackColor = true;
            // 
            // templatesBox
            // 
            this.templatesBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.templatesBoxState;
            this.templatesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.templatesBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "templatesBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.templatesBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.templatesBox.Location = new System.Drawing.Point(125, 242);
            this.templatesBox.Name = "templatesBox";
            this.templatesBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.templatesBox.Size = new System.Drawing.Size(122, 17);
            this.templatesBox.TabIndex = 11;
            this.templatesBox.Text = "templates folder\\";
            this.templatesBox.UseVisualStyleBackColor = true;
            // 
            // configBox
            // 
            this.configBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.configBoxState;
            this.configBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.configBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "configBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.configBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.configBox.Location = new System.Drawing.Point(12, 242);
            this.configBox.Name = "configBox";
            this.configBox.Size = new System.Drawing.Size(101, 17);
            this.configBox.TabIndex = 10;
            this.configBox.Text = "\\config folder";
            this.configBox.UseVisualStyleBackColor = true;
            // 
            // fontBox
            // 
            this.fontBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.fontBoxState;
            this.fontBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fontBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "fontBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fontBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fontBox.Location = new System.Drawing.Point(137, 219);
            this.fontBox.Name = "fontBox";
            this.fontBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fontBox.Size = new System.Drawing.Size(110, 17);
            this.fontBox.TabIndex = 9;
            this.fontBox.Text = "font folder\\";
            this.fontBox.UseVisualStyleBackColor = true;
            // 
            // soundBox
            // 
            this.soundBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.soundBoxState;
            this.soundBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "soundBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.soundBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.soundBox.Location = new System.Drawing.Point(134, 196);
            this.soundBox.Name = "soundBox";
            this.soundBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.soundBox.Size = new System.Drawing.Size(113, 17);
            this.soundBox.TabIndex = 8;
            this.soundBox.Text = "Sounds";
            this.soundBox.UseVisualStyleBackColor = true;
            // 
            // ModsBox
            // 
            this.ModsBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.ModBoxState;
            this.ModsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModsBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "ModBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ModsBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ModsBox.Location = new System.Drawing.Point(12, 219);
            this.ModsBox.Name = "ModsBox";
            this.ModsBox.Size = new System.Drawing.Size(110, 17);
            this.ModsBox.TabIndex = 7;
            this.ModsBox.Text = "\\Mods folder";
            this.ModsBox.UseVisualStyleBackColor = true;
            // 
            // saveBox
            // 
            this.saveBox.Checked = global::BN_Primitive_Launcher.Properties.Settings.Default.savesBoxState;
            this.saveBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BN_Primitive_Launcher.Properties.Settings.Default, "savesBoxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saveBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveBox.Location = new System.Drawing.Point(12, 196);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(113, 17);
            this.saveBox.TabIndex = 0;
            this.saveBox.Text = "Saves";
            this.saveBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 174);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kenanBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.graveyardBox);
            this.Controls.Add(this.memorialBox);
            this.Controls.Add(this.templatesBox);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.ModsBox);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(275, 400);
            this.MinimumSize = new System.Drawing.Size(275, 213);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BN Primitive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox saveBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox ModsBox;
        private System.Windows.Forms.CheckBox soundBox;
        private System.Windows.Forms.CheckBox fontBox;
        private System.Windows.Forms.CheckBox configBox;
        private System.Windows.Forms.CheckBox templatesBox;
        private System.Windows.Forms.CheckBox memorialBox;
        private System.Windows.Forms.CheckBox graveyardBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox backupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox kenanBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


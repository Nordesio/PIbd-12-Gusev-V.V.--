
namespace WindowsFormsWarships
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.buttonSetWarship = new System.Windows.Forms.Button();
            this.buttonSetLinkor = new System.Windows.Forms.Button();
            this.buttonTakeWarship = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDockName = new System.Windows.Forms.TextBox();
            this.listBoxDocks = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelDock = new System.Windows.Forms.Button();
            this.buttonAddDock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(754, 450);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // buttonSetWarship
            // 
            this.buttonSetWarship.Location = new System.Drawing.Point(767, 232);
            this.buttonSetWarship.Name = "buttonSetWarship";
            this.buttonSetWarship.Size = new System.Drawing.Size(90, 50);
            this.buttonSetWarship.TabIndex = 1;
            this.buttonSetWarship.Text = "Добавить боевой корабль";
            this.buttonSetWarship.UseVisualStyleBackColor = true;
            this.buttonSetWarship.Click += new System.EventHandler(this.buttonSetWarship_Click);
            // 
            // buttonSetLinkor
            // 
            this.buttonSetLinkor.Location = new System.Drawing.Point(767, 288);
            this.buttonSetLinkor.Name = "buttonSetLinkor";
            this.buttonSetLinkor.Size = new System.Drawing.Size(87, 34);
            this.buttonSetLinkor.TabIndex = 2;
            this.buttonSetLinkor.Text = "Добавить линкор";
            this.buttonSetLinkor.UseVisualStyleBackColor = true;
            this.buttonSetLinkor.Click += new System.EventHandler(this.buttonSetLinkor_Click);
            // 
            // buttonTakeWarship
            // 
            this.buttonTakeWarship.Location = new System.Drawing.Point(7, 76);
            this.buttonTakeWarship.Name = "buttonTakeWarship";
            this.buttonTakeWarship.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeWarship.TabIndex = 3;
            this.buttonTakeWarship.Text = "Забрать";
            this.buttonTakeWarship.UseVisualStyleBackColor = true;
            this.buttonTakeWarship.Click += new System.EventHandler(this.buttonTakeWarship_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.buttonTakeWarship);
            this.groupBox1.Location = new System.Drawing.Point(760, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать корабль";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(52, 50);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доки:";
            // 
            // textBoxDockName
            // 
            this.textBoxDockName.Location = new System.Drawing.Point(6, 25);
            this.textBoxDockName.Name = "textBoxDockName";
            this.textBoxDockName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDockName.TabIndex = 8;
            // 
            // listBoxDocks
            // 
            this.listBoxDocks.FormattingEnabled = true;
            this.listBoxDocks.Location = new System.Drawing.Point(6, 80);
            this.listBoxDocks.Name = "listBoxDocks";
            this.listBoxDocks.Size = new System.Drawing.Size(100, 95);
            this.listBoxDocks.TabIndex = 9;
            this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxDocks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDelDock);
            this.groupBox2.Controls.Add(this.buttonAddDock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDockName);
            this.groupBox2.Controls.Add(this.listBoxDocks);
            this.groupBox2.Location = new System.Drawing.Point(760, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 214);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // buttonDelDock
            // 
            this.buttonDelDock.Location = new System.Drawing.Point(10, 185);
            this.buttonDelDock.Name = "buttonDelDock";
            this.buttonDelDock.Size = new System.Drawing.Size(88, 23);
            this.buttonDelDock.TabIndex = 7;
            this.buttonDelDock.Text = "Удалить док";
            this.buttonDelDock.UseVisualStyleBackColor = true;
            this.buttonDelDock.Click += new System.EventHandler(this.buttonDelDock_Click);
            // 
            // buttonAddDock
            // 
            this.buttonAddDock.Location = new System.Drawing.Point(7, 51);
            this.buttonAddDock.Name = "buttonAddDock";
            this.buttonAddDock.Size = new System.Drawing.Size(90, 23);
            this.buttonAddDock.TabIndex = 13;
            this.buttonAddDock.Text = "Добавить док";
            this.buttonAddDock.UseVisualStyleBackColor = true;
            this.buttonAddDock.Click += new System.EventHandler(this.buttonAddDock_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetLinkor);
            this.Controls.Add(this.buttonSetWarship);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "Док";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonSetWarship;
        private System.Windows.Forms.Button buttonSetLinkor;
        private System.Windows.Forms.Button buttonTakeWarship;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDockName;
        private System.Windows.Forms.ListBox listBoxDocks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelDock;
        private System.Windows.Forms.Button buttonAddDock;
    }
}
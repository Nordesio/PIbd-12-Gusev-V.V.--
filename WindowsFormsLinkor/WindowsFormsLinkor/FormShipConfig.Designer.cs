namespace WindowsFormsShips
{
    partial class FormShipConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSideWeapons = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontWeapon = new System.Windows.Forms.CheckBox();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelLinkor = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.panelShip = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.panelShip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSideWeapons);
            this.groupBox1.Controls.Add(this.checkBoxFrontWeapon);
            this.groupBox1.Controls.Add(this.numericWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericSpeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // checkBoxSideWeapons
            // 
            this.checkBoxSideWeapons.AutoSize = true;
            this.checkBoxSideWeapons.Location = new System.Drawing.Point(201, 100);
            this.checkBoxSideWeapons.Name = "checkBoxSideWeapons";
            this.checkBoxSideWeapons.Size = new System.Drawing.Size(138, 21);
            this.checkBoxSideWeapons.TabIndex = 6;
            this.checkBoxSideWeapons.Text = "Боковые орудия";
            this.checkBoxSideWeapons.UseVisualStyleBackColor = true;
            this.checkBoxSideWeapons.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxFrontWeapon
            // 
            this.checkBoxFrontWeapon.AutoSize = true;
            this.checkBoxFrontWeapon.Location = new System.Drawing.Point(201, 49);
            this.checkBoxFrontWeapon.Name = "checkBoxFrontWeapon";
            this.checkBoxFrontWeapon.Size = new System.Drawing.Size(147, 21);
            this.checkBoxFrontWeapon.TabIndex = 4;
            this.checkBoxFrontWeapon.Text = "Переднее орудие";
            this.checkBoxFrontWeapon.UseVisualStyleBackColor = true;
            this.checkBoxFrontWeapon.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(87, 130);
            this.numericWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(58, 22);
            this.numericWeight.TabIndex = 2;
            this.numericWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericWeight.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес корабля";
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(87, 66);
            this.numericSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(58, 22);
            this.numericSpeed.TabIndex = 3;
            this.numericSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericSpeed.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLinkor);
            this.groupBox2.Controls.Add(this.labelShip);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип корабля";
            // 
            // labelLinkor
            // 
            this.labelLinkor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLinkor.Location = new System.Drawing.Point(19, 79);
            this.labelLinkor.Name = "labelLinkor";
            this.labelLinkor.Size = new System.Drawing.Size(142, 24);
            this.labelLinkor.TabIndex = 1;
            this.labelLinkor.Text = "Линкор";
            this.labelLinkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLinkor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLinkor_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(19, 42);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(142, 26);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Обычный корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(17, 19);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(163, 84);
            this.pictureBoxShip.TabIndex = 2;
            this.pictureBoxShip.TabStop = false;
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(224, 12);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(200, 123);
            this.panelShip.TabIndex = 3;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelPink);
            this.groupBox3.Controls.Add(this.panelBlue);
            this.groupBox3.Controls.Add(this.panelOrange);
            this.groupBox3.Controls.Add(this.panelYellow);
            this.groupBox3.Controls.Add(this.panelBlack);
            this.groupBox3.Controls.Add(this.panelGreen);
            this.groupBox3.Controls.Add(this.panelWhite);
            this.groupBox3.Controls.Add(this.panelNavy);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Location = new System.Drawing.Point(430, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Violet;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(59, 109);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(38, 35);
            this.panelPink.TabIndex = 7;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(15, 109);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 35);
            this.panelBlue.TabIndex = 6;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(59, 68);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 35);
            this.panelOrange.TabIndex = 5;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(15, 68);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 35);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(217, 109);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 35);
            this.panelBlack.TabIndex = 6;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(173, 109);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 35);
            this.panelGreen.TabIndex = 5;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(217, 68);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(38, 35);
            this.panelWhite.TabIndex = 4;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavy.Location = new System.Drawing.Point(173, 68);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(38, 35);
            this.panelNavy.TabIndex = 3;
            this.panelNavy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(173, 18);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(110, 32);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelBaseColor.Location = new System.Drawing.Point(6, 18);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(151, 32);
            this.labelBaseColor.TabIndex = 0;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(626, 203);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(626, 258);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 317);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormShipConfig";
            this.Text = "FormShipConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.panelShip.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSideWeapons;
        private System.Windows.Forms.CheckBox checkBoxFrontWeapon;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLinkor;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}
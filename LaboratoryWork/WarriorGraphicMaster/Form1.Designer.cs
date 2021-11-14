namespace WarriorGraphicMaster
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBright = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonBinColor = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.PicPage = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PicPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBright
            // 
            this.buttonBright.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBright.Location = new System.Drawing.Point(780, 40);
            this.buttonBright.Name = "buttonBright";
            this.buttonBright.Size = new System.Drawing.Size(200, 63);
            this.buttonBright.TabIndex = 1;
            this.buttonBright.Text = "Изображение";
            this.buttonBright.UseVisualStyleBackColor = true;
            this.buttonBright.Click += new System.EventHandler(this.buttonBright_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegative.Location = new System.Drawing.Point(780, 231);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(200, 63);
            this.buttonNegative.TabIndex = 3;
            this.buttonNegative.Text = "Негатив";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonBinColor
            // 
            this.buttonBinColor.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinColor.Location = new System.Drawing.Point(780, 135);
            this.buttonBinColor.Name = "buttonBinColor";
            this.buttonBinColor.Size = new System.Drawing.Size(200, 63);
            this.buttonBinColor.TabIndex = 7;
            this.buttonBinColor.Text = "Бинарный";
            this.buttonBinColor.UseVisualStyleBackColor = true;
            this.buttonBinColor.Click += new System.EventHandler(this.buttonBinColor_Click);
            // 

            // PicPage
            // 
            this.PicPage.Controls.Add(this.pictureBox);
            this.PicPage.Location = new System.Drawing.Point(4, 22);
            this.PicPage.Name = "PicPage";
            this.PicPage.Padding = new System.Windows.Forms.Padding(3);
            this.PicPage.Size = new System.Drawing.Size(667, 504);
            this.PicPage.TabIndex = 0;
            this.PicPage.Text = "Picture";
            this.PicPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(21, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 480);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PicPage);
            this.tabControl.ItemSize = new System.Drawing.Size(45, 18);
            this.tabControl.Location = new System.Drawing.Point(22, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(675, 530);
            this.tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 572);
            this.Controls.Add(this.buttonBinColor);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonBright);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.PicPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonBinColor;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TabPage PicPage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabControl tabControl;
    }
}


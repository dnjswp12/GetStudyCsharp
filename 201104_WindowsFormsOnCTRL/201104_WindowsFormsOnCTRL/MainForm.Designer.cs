namespace _201104_WindowsFormsOnCTRL
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtsimpleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProg = new System.Windows.Forms.Button();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(242, 73);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(61, 19);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "굵게\r\n";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(304, 72);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(74, 19);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "이텔릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtsimpleText
            // 
            this.txtsimpleText.Location = new System.Drawing.Point(66, 104);
            this.txtsimpleText.Name = "txtsimpleText";
            this.txtsimpleText.Size = new System.Drawing.Size(312, 25);
            this.txtsimpleText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Font : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsimpleText);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProg);
            this.groupBox2.Controls.Add(this.pgDummy);
            this.groupBox2.Location = new System.Drawing.Point(35, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 117);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TrackBar, ProgressBar";
            // 
            // btnProg
            // 
            this.btnProg.Location = new System.Drawing.Point(190, 24);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(75, 29);
            this.btnProg.TabIndex = 1;
            this.btnProg.Text = "progress";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.progress_Increase);
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(6, 59);
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(484, 46);
            this.pgDummy.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(35, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modal and Modaless";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "MsgBox";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modaless";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Modaless_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvDummy);
            this.groupBox4.Controls.Add(this.tvDummy);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(35, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 201);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TreeView and ListView";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "자식 추가";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "루트 추가";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(7, 25);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(230, 135);
            this.tvDummy.TabIndex = 4;
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(243, 25);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(247, 135);
            this.lvDummy.TabIndex = 5;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 683);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.TextBox txtsimpleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
    }
}


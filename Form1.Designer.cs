namespace FortuneTeller
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btResult = new System.Windows.Forms.Button();
            this.tbBirthTime = new System.Windows.Forms.TextBox();
            this.tbBirthDay = new System.Windows.Forms.TextBox();
            this.lbBirthTime = new System.Windows.Forms.Label();
            this.lbBirthDay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btResult);
            this.groupBox1.Controls.Add(this.tbBirthTime);
            this.groupBox1.Controls.Add(this.tbBirthDay);
            this.groupBox1.Controls.Add(this.lbBirthTime);
            this.groupBox1.Controls.Add(this.lbBirthDay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(22, 293);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(303, 52);
            this.btResult.TabIndex = 4;
            this.btResult.Text = "사주 결과 보기";
            this.btResult.UseVisualStyleBackColor = true;
            // 
            // tbBirthTime
            // 
            this.tbBirthTime.Location = new System.Drawing.Point(22, 160);
            this.tbBirthTime.Name = "tbBirthTime";
            this.tbBirthTime.Size = new System.Drawing.Size(100, 21);
            this.tbBirthTime.TabIndex = 3;
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.Location = new System.Drawing.Point(22, 75);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(100, 21);
            this.tbBirthDay.TabIndex = 2;
            // 
            // lbBirthTime
            // 
            this.lbBirthTime.AutoSize = true;
            this.lbBirthTime.Location = new System.Drawing.Point(20, 124);
            this.lbBirthTime.Name = "lbBirthTime";
            this.lbBirthTime.Size = new System.Drawing.Size(161, 12);
            this.lbBirthTime.TabIndex = 1;
            this.lbBirthTime.Text = "태어난 시각을 입력해주세요.";
            // 
            // lbBirthDay
            // 
            this.lbBirthDay.AutoSize = true;
            this.lbBirthDay.Location = new System.Drawing.Point(20, 48);
            this.lbBirthDay.Name = "lbBirthDay";
            this.lbBirthDay.Size = new System.Drawing.Size(145, 12);
            this.lbBirthDay.TabIndex = 0;
            this.lbBirthDay.Text = "생년월일을 입력해주세요.";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(364, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "포츈텔러 3103김지혜";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbBirthDay;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.TextBox tbBirthTime;
        private System.Windows.Forms.TextBox tbBirthDay;
        private System.Windows.Forms.Label lbBirthTime;
    }
}


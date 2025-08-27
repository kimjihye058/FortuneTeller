namespace FortuneTeller
{
    partial class FormHistory
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(319, 59);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "내역 새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-24 09:12:45 - 19981215 14 - 오늘은 새로운 기회가 열릴 것입니다",
            "2025-08-24 10:05:21 - 20030527 06 - 오늘은 주변 사람과의 대화에 귀 기울이세요",
            "2025-08-24 11:33:09 - 19951108 22 - 오늘은 계획했던 일을 실행하기 좋은 날입니다",
            "2025-08-24 12:47:55 - 20010419 09 - 오늘은 작은 일에도 감사하는 마음을 가지세요",
            "2025-08-24 14:16:30 - 19990723 18 - 오늘은 금전적인 운이 따르니 지혜롭게 사용하세요",
            "2025-08-24 15:42:12 - 20021011 07 - 오늘은 가족과의 시간이 큰 힘이 됩니다",
            "2025-08-24 17:29:40 - 19960228 20 - 오늘은 건강을 위해 휴식이 필요합니다"});
            this.lbHistory.Location = new System.Drawing.Point(13, 86);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(319, 340);
            this.lbHistory.TabIndex = 1;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormHistory";
            this.Text = "내역보기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbHistory;
    }
}
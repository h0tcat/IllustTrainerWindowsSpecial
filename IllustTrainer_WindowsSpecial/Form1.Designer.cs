namespace IllustTrainer_WindowsSpecial
{
    partial class titleForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tipsText = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BeginnerModeButton = new System.Windows.Forms.Button();
            this.freeModeButton = new System.Windows.Forms.Button();
            this.referrenceModeButton = new System.Windows.Forms.Button();
            this.tipsTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.tipsText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 574);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1015, 84);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tipsText
            // 
            this.tipsText.AutoSize = true;
            this.tipsText.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tipsText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tipsText.Location = new System.Drawing.Point(3, 0);
            this.tipsText.Name = "tipsText";
            this.tipsText.Size = new System.Drawing.Size(529, 19);
            this.tipsText.TabIndex = 0;
            this.tipsText.Text = "Tips:初めはだれしも初心者だからできるところからやってみよう。";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.BeginnerModeButton);
            this.flowLayoutPanel2.Controls.Add(this.freeModeButton);
            this.flowLayoutPanel2.Controls.Add(this.referrenceModeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(299, 205);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(451, 363);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // BeginnerModeButton
            // 
            this.BeginnerModeButton.Location = new System.Drawing.Point(3, 3);
            this.BeginnerModeButton.Name = "BeginnerModeButton";
            this.BeginnerModeButton.Size = new System.Drawing.Size(448, 115);
            this.BeginnerModeButton.TabIndex = 0;
            this.BeginnerModeButton.Text = "ビギナーモード(おすすめ)";
            this.BeginnerModeButton.UseVisualStyleBackColor = true;
            this.BeginnerModeButton.Click += new System.EventHandler(this.BeginnerModeButton_Click);
            // 
            // freeModeButton
            // 
            this.freeModeButton.Location = new System.Drawing.Point(3, 124);
            this.freeModeButton.Name = "freeModeButton";
            this.freeModeButton.Size = new System.Drawing.Size(448, 115);
            this.freeModeButton.TabIndex = 2;
            this.freeModeButton.Text = "フリーモード";
            this.freeModeButton.UseVisualStyleBackColor = true;
            this.freeModeButton.Click += new System.EventHandler(this.freeModeButton_Click);
            // 
            // referrenceModeButton
            // 
            this.referrenceModeButton.Location = new System.Drawing.Point(3, 245);
            this.referrenceModeButton.Name = "referrenceModeButton";
            this.referrenceModeButton.Size = new System.Drawing.Size(448, 115);
            this.referrenceModeButton.TabIndex = 3;
            this.referrenceModeButton.Text = "リファレンス";
            this.referrenceModeButton.UseVisualStyleBackColor = true;
            // 
            // tipsTimer
            // 
            this.tipsTimer.Enabled = true;
            this.tipsTimer.Interval = 2500;
            this.tipsTimer.Tick += new System.EventHandler(this.tipsTimer_Tick);
            // 
            // titleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 670);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "titleForm";
            this.Text = "Illust Trainer Windows Special";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.titleForm_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label tipsText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BeginnerModeButton;
        private System.Windows.Forms.Button freeModeButton;
        private System.Windows.Forms.Button referrenceModeButton;
        private System.Windows.Forms.Timer tipsTimer;
    }
}


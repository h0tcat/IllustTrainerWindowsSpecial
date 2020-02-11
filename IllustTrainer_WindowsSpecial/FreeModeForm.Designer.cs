namespace IllustTrainer_WindowsSpecial
{
    partial class FreeModeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.musicFilePathText = new System.Windows.Forms.TextBox();
            this.browseMusicFileButton = new System.Windows.Forms.Button();
            this.playBgmButton = new System.Windows.Forms.Button();
            this.stopBgmButton = new System.Windows.Forms.Button();
            this.isLoopPlay = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.canvas = new Microsoft.Ink.InkPicture();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画像を保存するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openSoundFileDIalog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 555);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.changeColorButton);
            this.flowLayoutPanel1.Controls.Add(this.penButton);
            this.flowLayoutPanel1.Controls.Add(this.eraserButton);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.musicFilePathText);
            this.flowLayoutPanel1.Controls.Add(this.browseMusicFileButton);
            this.flowLayoutPanel1.Controls.Add(this.playBgmButton);
            this.flowLayoutPanel1.Controls.Add(this.stopBgmButton);
            this.flowLayoutPanel1.Controls.Add(this.isLoopPlay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 555);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tool";
            // 
            // changeColorButton
            // 
            this.changeColorButton.Location = new System.Drawing.Point(3, 20);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(195, 46);
            this.changeColorButton.TabIndex = 2;
            this.changeColorButton.Text = "描画色の変更";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(3, 72);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(194, 45);
            this.penButton.TabIndex = 0;
            this.penButton.Text = "ペン";
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Location = new System.Drawing.Point(3, 123);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(194, 45);
            this.eraserButton.TabIndex = 3;
            this.eraserButton.Text = "消しゴム";
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ペンの太さ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 174);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Music";
            // 
            // musicFilePathText
            // 
            this.musicFilePathText.Location = new System.Drawing.Point(3, 219);
            this.musicFilePathText.Name = "musicFilePathText";
            this.musicFilePathText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.musicFilePathText.Size = new System.Drawing.Size(189, 22);
            this.musicFilePathText.TabIndex = 11;
            // 
            // browseMusicFileButton
            // 
            this.browseMusicFileButton.Location = new System.Drawing.Point(3, 247);
            this.browseMusicFileButton.Name = "browseMusicFileButton";
            this.browseMusicFileButton.Size = new System.Drawing.Size(194, 51);
            this.browseMusicFileButton.TabIndex = 9;
            this.browseMusicFileButton.Text = "音楽を選択する";
            this.browseMusicFileButton.UseVisualStyleBackColor = true;
            this.browseMusicFileButton.Click += new System.EventHandler(this.browseMusicFileButton_Click);
            // 
            // playBgmButton
            // 
            this.playBgmButton.Location = new System.Drawing.Point(3, 304);
            this.playBgmButton.Name = "playBgmButton";
            this.playBgmButton.Size = new System.Drawing.Size(194, 51);
            this.playBgmButton.TabIndex = 6;
            this.playBgmButton.Text = "再生";
            this.playBgmButton.UseVisualStyleBackColor = true;
            this.playBgmButton.Click += new System.EventHandler(this.playBgmButton_Click);
            // 
            // stopBgmButton
            // 
            this.stopBgmButton.Location = new System.Drawing.Point(3, 361);
            this.stopBgmButton.Name = "stopBgmButton";
            this.stopBgmButton.Size = new System.Drawing.Size(194, 51);
            this.stopBgmButton.TabIndex = 10;
            this.stopBgmButton.Text = "停止";
            this.stopBgmButton.UseVisualStyleBackColor = true;
            // 
            // isLoopPlay
            // 
            this.isLoopPlay.AutoSize = true;
            this.isLoopPlay.Location = new System.Drawing.Point(3, 418);
            this.isLoopPlay.Name = "isLoopPlay";
            this.isLoopPlay.Size = new System.Drawing.Size(125, 21);
            this.isLoopPlay.TabIndex = 8;
            this.isLoopPlay.Text = "ループ再生にする";
            this.isLoopPlay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.canvas);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 555);
            this.panel2.TabIndex = 1;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.EraserWidth = 4;
            this.canvas.Location = new System.Drawing.Point(0, 28);
            this.canvas.MarginX = -2147483648;
            this.canvas.MarginY = -2147483648;
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(977, 527);
            this.canvas.TabIndex = 0;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCanvasToolStripMenuItem,
            this.画像を保存するToolStripMenuItem,
            this.backTitleToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // newCanvasToolStripMenuItem
            // 
            this.newCanvasToolStripMenuItem.Name = "newCanvasToolStripMenuItem";
            this.newCanvasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCanvasToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.newCanvasToolStripMenuItem.Text = "new Canvas";
            // 
            // 画像を保存するToolStripMenuItem
            // 
            this.画像を保存するToolStripMenuItem.Name = "画像を保存するToolStripMenuItem";
            this.画像を保存するToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.画像を保存するToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.画像を保存するToolStripMenuItem.Text = "保存";
            this.画像を保存するToolStripMenuItem.Click += new System.EventHandler(this.画像を保存するToolStripMenuItem_Click);
            // 
            // backTitleToolStripMenuItem
            // 
            this.backTitleToolStripMenuItem.Name = "backTitleToolStripMenuItem";
            this.backTitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.backTitleToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.backTitleToolStripMenuItem.Text = "Back Title";
            this.backTitleToolStripMenuItem.Click += new System.EventHandler(this.backTitleToolStripMenuItem_Click);
            // 
            // ColorPicker
            // 
            this.ColorPicker.AnyColor = true;
            this.ColorPicker.FullOpen = true;
            this.ColorPicker.ShowHelp = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "png ファイル (*.png)|*.png|すべてのファイル (*.*)|*.*";
            this.openFileDialog.InitialDirectory = ".";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "gif ファイル (*.gif)|*.gif|Isfファイル (*.isf)|*.isf";
            // 
            // openSoundFileDIalog
            // 
            this.openSoundFileDIalog.FileName = "openFileDialog";
            this.openSoundFileDIalog.Filter = "wav ファイル (*.wav)|*.wav";
            // 
            // FreeModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FreeModeForm";
            this.Text = "IllustTrainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FreeModeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Ink.InkPicture canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playBgmButton;
        private System.Windows.Forms.CheckBox isLoopPlay;
        private System.Windows.Forms.Button browseMusicFileButton;
        private System.Windows.Forms.Button stopBgmButton;
        private System.Windows.Forms.TextBox musicFilePathText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画像を保存するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backTitleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openSoundFileDIalog;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nori.soft.util;

namespace IllustTrainer_WindowsSpecial
{
    public partial class FreeModeForm : Form
    {
        private SoundHelper workBgm;
        public FreeModeForm()
        {
            InitializeComponent();
        }



        private void changeColorButton_Click(object sender, EventArgs e)
        {
            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.DefaultDrawingAttributes.Width = (float)this.numericUpDown1.Value;

            this.ColorPicker.ShowDialog();
        }

        private void backTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var YesNoResponse = MessageBox.Show("タイトル画面に戻りますか?" +
                "(もし、絵を描いていて保存していないで戻ってしまうと、描いた絵が消えてしまいます)",
                "本当にタイトル画面に戻りますか?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            switch (YesNoResponse)
            {
                case DialogResult.Yes:
                    try
                    {
                        workBgm.Dispose();
                    }
                    catch (NullReferenceException NullE)
                    {
                        //Pass
                    }
                    finally
                    {
                        //Back Title
                        this.Close();
                    }
                    break;
            }
        }

        private void FreeModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.workBgm.Stop();
                this.workBgm.Dispose();
            }catch(NullReferenceException NullE)
            {
                //pass
            }
            this.Visible = false;
        }

        private void browseMusicFileButton_Click(object sender, EventArgs e)
        {
            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.DefaultDrawingAttributes.Width = (float)this.numericUpDown1.Value;
            var openFileDialogResponse = this.openSoundFileDIalog.ShowDialog();
            if (openFileDialogResponse == DialogResult.OK)
            {
                this.musicFilePathText.Text = this.openSoundFileDIalog.FileName;
            }
            else
            {
                //pass
            }
        }

        private void playBgmButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
                this.workBgm = this.workBgm = new SoundHelper(this.musicFilePathText.Text);
                if (isLoopPlay.Checked)
                {
                    this.workBgm.PlayLooping();
                }
                else
                {
                    this.workBgm.Play();
                }
            }
            catch (Exception IOE)
            {
                MessageBox.Show("無効なファイル名です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void penButton_Click(object sender, EventArgs e)
        {

            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.DefaultDrawingAttributes.Width = (float)this.numericUpDown1.Value;
            this.canvas.EditingMode = Microsoft.Ink.InkOverlayEditingMode.Ink;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.EraserWidth = (int)this.numericUpDown1.Value;
            this.canvas.EditingMode = Microsoft.Ink.InkOverlayEditingMode.Delete;
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.DefaultDrawingAttributes.Color = this.ColorPicker.Color;
            this.canvas.DefaultDrawingAttributes.Width = (float)this.numericUpDown1.Value;
        }

        private void 画像を保存するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialogResponse = this.saveFileDialog.ShowDialog();
            if (saveFileDialogResponse == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                string ext = System.IO.Path.GetExtension(fileName).ToLower();
                switch (ext)
                {
                    case ".isf":

                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {


                            byte[] isfData = this.canvas.Ink.Save(Microsoft.Ink.PersistenceFormat.InkSerializedFormat);


                            fs.Write(isfData, 0, isfData.Length);


                        }
                        break;
                    case ".gif":
                        using (FileStream fs = new FileStream(fileName, FileMode.Create))
                        {


                            byte[] isfData = this.canvas.Ink.Save(Microsoft.Ink.PersistenceFormat.Gif);


                            fs.Write(isfData, 0, isfData.Length);


                        }
                        break;
                }
            }
        }
    }
}

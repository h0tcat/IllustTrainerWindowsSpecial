using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nori.soft.util;

namespace IllustTrainer_WindowsSpecial
{
    public partial class titleForm : Form
    {
        private SoundHelper titleBgm;
        private int tipsCnt;

        public FreeModeForm freeMode;


        public titleForm()
        {

            //モードを取得しておく
            freeMode = new FreeModeForm();

            InitializeComponent();
        }

        private void tipsTimer_Tick(object sender, EventArgs e)
        {
            //美術に関する(?)tipsを表示する
            switch (this.tipsCnt)
            {
                case 1:
                    this.tipsText.Text = "Tips:" + "疲れたら、たまに休憩するのもあり、周りをよく観察して描くとGood!";
                    break;
                case 2:
                    this.tipsText.Text = "Tips:" + "デジタルの絵を描くときは、ペンタブを持っていると絵が、かきやすいです";
                    break;
                case 3:
                    this.tipsText.Text = "Tips:" + "絵をシェアするときは、最初は近くの友達や、先生に見てもらったほうが、フィードバックを受けやすいと思います";
                    break;
                case 4:
                    this.tipsText.Text = "Tips:" + "もし、行き詰まったら、リファレンスを参考にしてみてください。";
                    break;
                default:
                    //カウントのリセット
                    this.tipsCnt = 0;
                    this.tipsText.Text = "Tips:" + "初めはだれしも初心者だからできるところからやってみよう。";
                    break;

            }
            this.tipsCnt++;
        }

        private void BeginnerModeButton_Click(object sender, EventArgs e)
        {

        }

        private void freeModeButton_Click(object sender, EventArgs e)
        {
            //フリーモードに切り替える
            if (!freeMode.Visible)
            {
                this.freeMode = new FreeModeForm();
                this.freeMode.Show();
            }

        }

        private void titleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.titleBgm.Dispose();
            }
            catch (NullReferenceException NullE)
            {
                //pass
            }

        }
    }
}

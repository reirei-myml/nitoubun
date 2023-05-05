using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nitoubun
{
    public partial class FrmNitoubun : Form
    {
        /// <summary>
        /// 割る数（固定）
        /// </summary>
        private const Double DIV = 2;

        /// <summary>
        /// 割った回数
        /// </summary>
        private Double cnt;

        /// <summary>
        /// ○等分(DIVの累乗で求める)
        /// </summary>
        private Double powered;

        public FrmNitoubun()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面初期表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNitoubun_Load(object sender, EventArgs e)
        {
                btnReset_Click(sender, e);
                btnNext.Focus();
        }

        /// <summary>
        /// 「もう１回！」ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            cnt = cnt + 1;
            CalcAndShowResult();

        }

        /// <summary>
        /// リセットボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            cnt = 1;
            CalcAndShowResult();
        }

        private void CalcAndShowResult()
        {

            //計算
            CalcPow();

            //ラベルの移動
            this.LblMove(ref lblCnt, ref lblConstCnt);
            this.LblMove(ref lblPowered, ref lblConstPowered);

            //描画
            ShowDevidedPic();
        }

        /// <summary>
        /// 累乗の計算と表示
        /// </summary>
        private void CalcPow()
        {
            powered = Math.Pow(DIV, cnt);
            lblCnt.Text = cnt.ToString();
            lblPowered.Text = powered.ToString();

        }

        /// <summary>
        /// 円をpowered等分した画を生成
        /// </summary>
        private void ShowDevidedPic()
        {
            Double limitPow = 2048; //円の断面が視認不可になってしまう大体の数字
            if (powered > limitPow) { return; }

            Bitmap canvas = new Bitmap(pBox.Width, pBox.Height);
            Graphics g = Graphics.FromImage(canvas);

            //円弧をpowered回描画する
            for (double i = 0; i < powered; i++)
            {
                g.DrawPie(
                      Pens.Blue
                    , 0
                    , 0
                    , pBox.Width-10
                    , pBox.Height-10
                    , (float)(360 / powered * i)
                    , (float)(360 / powered)
                    );
            }

            g.Dispose();
            pBox.Image = canvas;

        }


        /// <summary>
        /// 桁数に合わせてラベルの位置を調整
        /// </summary>
        /// <param name="leftLabel"></param>
        /// <param name="rightLabel"></param>
        private void LblMove(ref Label leftLabel,ref Label rightLabel)
        {
            rightLabel.Location = new Point(leftLabel.Location.X + leftLabel.Width
                                            , leftLabel.Location.Y + leftLabel.Height - rightLabel.Height);
        }

        /// <summary>
        /// おわりボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

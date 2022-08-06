using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipGame : Form
{
    public partial class CoinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;

        public CoinFlipGame()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            int result = coinFlip.Next(1, 3);

            //The Result is Heads
            if(result == 1)
            {
                CoinImage.ImageLocation = @"C:\Users\LiamEncabo\CoinFlip\Heads.png";
                CoinImage.SizeMode = PicturesBoxSizeMode.StretchImage;
                heads++;
                HeadsLabel.Text = "Heads: " + heads.ToString();
            }
            //The Result is Tails
            else
            {
                CoinImage.ImageLocation = @"C:\Users\LiamEncabo\CoinFlip\Tails.png";
                CoinImage.SizeMode = PicturesBoxSizeMode.StretchImage;
                tails++;
                TailsLabel.Text = "Tails: " + tails.ToString();
            }
        }
    }
}
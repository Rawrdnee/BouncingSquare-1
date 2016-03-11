using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingSquare
{
    public partial class frmBouncingSquare : Form
    {
        Int32 iCount = 0;
        List<PictureBox> pictures = new List<PictureBox>();
        Random rRand = new Random();
        Paddle paddle;


        /******************************************
        *           Form Handlers Below           *
        ******************************************/
        public frmBouncingSquare()
        {
            InitializeComponent();
            this.KeyDown += FrmBouncingSquare_KeyDown;
            this.Load += FrmBouncingSquare_Load;
            this.MouseMove += FrmBouncingSquare_MouseMove;
            pictures.Add(pbHeart1);
            pictures.Add(pbHeart2);
            pictures.Add(pbHeart3);
            Cursor.Hide();
        }

        private void FrmBouncingSquare_MouseMove(object sender, MouseEventArgs e)
        {
            paddle.Location = e.Location.X;
        }

        private void FrmBouncingSquare_Load(object sender, EventArgs e)
        {
            paddle = new Paddle(this, rRand);
        }

        private void FrmBouncingSquare_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                this.Close();
                Application.Exit();
            }
            else if(e.KeyData == Keys.N)
            {
                Square square = new Square(this, rRand, paddle, pictures);
                iCount++;
                lblSquareCount.Text = iCount.ToString();
            }
            else if(e.KeyData == Keys.Left || e.KeyData == Keys.Right)
            {
                paddle.Key = e.KeyData;
            }
        }

    }
}

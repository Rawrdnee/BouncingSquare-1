using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BouncingSquare
{
    public class Paddle
    {

        #region Private Members
        private Form _form = null;
        private PictureBox _box = null;
        private Random _rnd = null;
        #endregion

        #region Public Properties
        public Keys Key
        {
            set
            {
                if(value == Keys.Left)
                {
                    Point location = _box.Location;
                    location.X -= 80;
                    if (location.X >=  0)
                    {
                        // Moves the paddle
                        _box.Location = location;
                    }
                    else
                    {
                        location.X = 0;
                        _box.Location = location;
                    }
                }
                else if(value == Keys.Right)
                {
                    Point location = _box.Location;
                    location.X += 80;
                    if (location.X <= _form.Width - _box.Width -10)
                    {
                        // Moves the paddle
                        _box.Location = location;
                    }
                    else
                    {
                        location.X = _form.Width - _box.Width - 10;
                        _box.Location = location;
                    }
                }

            }
        }
        public PictureBox Box
        {
            get { return _box; }
        }
        public Int32 Location
        {
            set
            {
                Point location = _box.Location;
                location.X = value;
                _box.Location = location;
            }
        }
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        #endregion

        #region Public Events

        #endregion

        #region Public Event Handlers

        #endregion

        #region Construction
        public Paddle(Form frm, Random rnd)
        {
            _box = new PictureBox();
            _form = frm;
            _rnd = rnd;
            Size size = new Size(100, 20);
            Int32 x = (_form.Width / 2) - (_box.Width / 2);
            Int32 y = _form.Height - _box.Height;
            Point location = new Point(x,y);
            _box.Location = location;
            _box.BackColor = Color.White;
            _form.Controls.Add(_box);
        }
        #endregion

    }
}

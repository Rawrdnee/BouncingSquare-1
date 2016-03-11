using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingSquare
{
    public class Square: IDisposable
    {
        #region Private Members
        private Guid _id = Guid.Empty;
        private Form _form = null;
        private PictureBox _box = null;
        private Timer _timer = null;
        private int _xDir = 0;
        private int _yDir = 0;
        private Random _rnd = null;
        private Image _explosion = null;
        private Timer _tmrExplosion = null;
        private Paddle _paddle = null;
        private List<PictureBox> _hearts = null;
        #endregion

        #region Public Properties
        public PictureBox Box
        {
            get { return _box; }
        }
        public int xDir
        {
            get { return _xDir; }
            set { _xDir = value; }
        }
        public int yDir
        {
            get { return _yDir; }
            set { _yDir = value; }
        }
        public Guid Id
        {
            get { return _id; }
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        private void Move()
        {
            Point location = _box.Location;
            location.X += _xDir;
            location.Y += _yDir;
            _box.Location = location;

            // if the square hits the bottom of the screen, then remove the square
            if (location.Y > _form.Height - _box.Height)
            {
                if(_hearts.Count > 0)
                {
                    PictureBox pbHeart = _hearts[_hearts.Count-1];
                    pbHeart.Visible = false;
                    _hearts.TrimExcess();
                }
                // this gets rid of "this" square
                Dispose();
            }
            // causes the square to change directions once it hits the edges of the screen
            else if (location.Y <= 0)
            {
                _yDir = -_yDir;
            }
            else if (location.X >= _form.Width - _box.Width)
            {
                _xDir = -_xDir;
            }
            else if (location.X <= 0)
            {
                _xDir = -_xDir;
            }
            // if the square hits the paddle, then deflect the square
            else if (_paddle.Box.Bounds.IntersectsWith(_box.Bounds))
            {
                _yDir = -yDir;
            }

            
        }
        #endregion

        #region Event Handlers
        private void _timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        private void _tmrExplosion_Tick(object sender, EventArgs e)
        {
            _tmrExplosion.Enabled = false;
            Dispose();
        }
        #endregion

        #region Construction
        public Square(Form frm, Random rnd, Paddle paddle, List<PictureBox> hearts)
        {
            // use the label for a picture? (the heart)
            _hearts = hearts;
            _paddle = paddle;
            _tmrExplosion = new Timer();
            _tmrExplosion.Interval = 5000;
            _tmrExplosion.Tick += _tmrExplosion_Tick;
            _rnd = rnd;
            _form = frm;
            _box = new PictureBox();
            _box.Width = _rnd.Next(10, 50);
            _box.Height = _rnd.Next(10, 50);
            _box.BackColor = Color.FromArgb(_rnd.Next(0, 256), _rnd.Next(0, 256), _rnd.Next(0, 256));
            Point location = new Point();

            location.X = _rnd.Next(0, _form.Width - _box.Width);
            location.Y = _rnd.Next(0, _form.Height - _box.Height);
            _box.Location = location;

            // creates a new timer which runs at the given interval(milliseconds)
            _timer = new Timer();
            _timer.Interval = 1;
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;

            // this assigns a random speed upon instantiating a square
            do
            {
                _xDir = rnd.Next(-5, 6);
            } while (_xDir == 0);
            do
            {
                _yDir = rnd.Next(-5, 6);
            } while (_yDir == 0);

            _form.Controls.Add(_box);
            Bitmap bmp = new Bitmap("Images/Explode.gif");
            _explosion = bmp;
            _id = Guid.NewGuid();
        }


        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _timer.Enabled = false;
                    _box.Dispose();
                    _explosion = null;
                    _form.Controls.Remove(_box);
                    _form = null;
                    _rnd = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Square() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}

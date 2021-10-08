using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NQueenHillClimbing
{
    public partial class Form1 : Form
    {
        private float _cellSize;
        private int _moves;
        private Board _initialState, _currentState;
        private Point _step;
        private List<Point> _lowestMoves;
        //private Random rand = new Random(69);

        public Form1()
        {
            InitializeComponent();
            _moves = 0;
            _cellSize = initialState.Width / (int)nQueen.Value;
            _initialState = new Board((int)nQueen.Value);
            //_initialState = new Board(Enumerable.Repeat((int)nQueen.Value / 2, (int)nQueen.Value).ToArray());
            _currentState = new Board(_initialState);
            calculateAndPaintUpdate();
        }

        private void initialState_Paint(object sender, PaintEventArgs e)
        {
            int n = _initialState.n;
            for (int column = 0; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    if ((column + row) % 2 == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.Gray, column * _cellSize, row * _cellSize, _cellSize, _cellSize);
                    }
                    if (_initialState.columns[column] == row)
                    {
                        e.Graphics.FillEllipse(Brushes.Black, column * _cellSize, row * _cellSize, _cellSize, _cellSize);
                    }
                }
            }
        }

        private void currentState_Paint(object sender, PaintEventArgs e)
        {
            int n = _currentState.n;
            for (int column = 0; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    if ((column + row) % 2 == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.Gray, column * _cellSize, row * _cellSize, _cellSize, _cellSize);
                    }
                    if (_currentState.columns[column] == row)
                    {
                        e.Graphics.FillEllipse(Brushes.Black, column * _cellSize, row * _cellSize, _cellSize, _cellSize);
                    }
                }
            }
        }

        private void calculateUpdate()
        {
            _currentState.getHeurestic();
            _lowestMoves = _currentState.getLowestMoves();
            _step = _lowestMoves[new Random().Next(_lowestMoves.Count)];
            //_step = _lowestMoves[rand.Next(_lowestMoves.Count)];
        }

        private void paintUpdate()
        {
            moves.Text = _moves.ToString();
            initAttackingPair.Text = _initialState.getAttackingPairs().ToString();
            currentAttackingPair.Text = _currentState.getAttackingPairs().ToString();
            minAttackingPair.Text = _currentState.lowestMove.ToString();
            step.Text = _step.ToString();
            int tempCounter = 0;
            lowestMoves.Items.Clear();
            foreach (Point point in _lowestMoves)
            {
                lowestMoves.Items.Add((++tempCounter) + ". \t" + point.ToString());
            }
            initialState.Refresh();
            currentState.Refresh();
        }

        private void calculateAndPaintUpdate()
        {
            calculateUpdate();
            paintUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _moves = 0;
            _initialState.shuffle();
            //_initialState = new Board(Enumerable.Repeat((int)nQueen.Value / 2, (int)nQueen.Value).ToArray());
            _currentState.copy(_initialState);
            calculateAndPaintUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentState.getAttackingPairs() == 0) return;
            _currentState.columns[_step.X] = _step.Y;
            _moves++;
            calculateAndPaintUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solving.Visible = true;
            solving.Refresh();
            while (_currentState.getAttackingPairs() > 0)
            {
                _currentState.columns[_step.X] = _step.Y;
                _moves++;
                if (animate.Checked)
                {
                    calculateAndPaintUpdate();
                    System.Threading.Thread.Sleep((int)animationSpeed.Value);
                }
                else
                {
                    calculateUpdate();
                }
            }
            if (!animate.Checked)
            {
                paintUpdate();
            }
            solving.Visible = false;
            solving.Refresh();
        }

        private void nQueen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void nQueen_ValueChanged(object sender, EventArgs e)
        {
            _moves = 0;
            _cellSize = initialState.Width / (int)nQueen.Value;
            _initialState = new Board((int)nQueen.Value);
            //_initialState = new Board(Enumerable.Repeat((int)nQueen.Value / 2, (int)nQueen.Value).ToArray());
            _currentState = new Board(_initialState);
            calculateAndPaintUpdate();
        }

        private void animationSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void animate_CheckedChanged(object sender, EventArgs e)
        {
            animationSpeed.Enabled = animate.Checked;
            animationSpeed.Refresh();
        }
    }
}

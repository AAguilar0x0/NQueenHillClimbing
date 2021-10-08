
namespace NQueenHillClimbing
{
    partial class Form1
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
            this.initialState = new System.Windows.Forms.PictureBox();
            this.currentState = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minAttackingPair = new System.Windows.Forms.Label();
            this.lowestMoves = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.initAttackingPair = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentAttackingPair = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.moves = new System.Windows.Forms.Label();
            this.nQueen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.solving = new System.Windows.Forms.Label();
            this.animate = new System.Windows.Forms.CheckBox();
            this.animationSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.initialState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // initialState
            // 
            this.initialState.Location = new System.Drawing.Point(12, 12);
            this.initialState.Name = "initialState";
            this.initialState.Size = new System.Drawing.Size(300, 300);
            this.initialState.TabIndex = 0;
            this.initialState.TabStop = false;
            this.initialState.Paint += new System.Windows.Forms.PaintEventHandler(this.initialState_Paint);
            // 
            // currentState
            // 
            this.currentState.Location = new System.Drawing.Point(532, 12);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(300, 300);
            this.currentState.TabIndex = 1;
            this.currentState.TabStop = false;
            this.currentState.Paint += new System.Windows.Forms.PaintEventHandler(this.currentState_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lowest attacking pair:";
            // 
            // minAttackingPair
            // 
            this.minAttackingPair.AutoSize = true;
            this.minAttackingPair.Location = new System.Drawing.Point(464, 12);
            this.minAttackingPair.Name = "minAttackingPair";
            this.minAttackingPair.Size = new System.Drawing.Size(30, 13);
            this.minAttackingPair.TabIndex = 3;
            this.minAttackingPair.Text = "UNK";
            // 
            // lowestMoves
            // 
            this.lowestMoves.FormattingEnabled = true;
            this.lowestMoves.Location = new System.Drawing.Point(328, 32);
            this.lowestMoves.Name = "lowestMoves";
            this.lowestMoves.Size = new System.Drawing.Size(192, 160);
            this.lowestMoves.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Solve";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Attacking pair(s):";
            // 
            // initAttackingPair
            // 
            this.initAttackingPair.AutoSize = true;
            this.initAttackingPair.Location = new System.Drawing.Point(104, 315);
            this.initAttackingPair.Name = "initAttackingPair";
            this.initAttackingPair.Size = new System.Drawing.Size(30, 13);
            this.initAttackingPair.TabIndex = 9;
            this.initAttackingPair.Text = "UNK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attacking pair(s):";
            // 
            // currentAttackingPair
            // 
            this.currentAttackingPair.AutoSize = true;
            this.currentAttackingPair.Location = new System.Drawing.Point(621, 315);
            this.currentAttackingPair.Name = "currentAttackingPair";
            this.currentAttackingPair.Size = new System.Drawing.Size(30, 13);
            this.currentAttackingPair.TabIndex = 11;
            this.currentAttackingPair.Text = "UNK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Step:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Moves:";
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(380, 208);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(30, 13);
            this.step.TabIndex = 14;
            this.step.Text = "UNK";
            // 
            // moves
            // 
            this.moves.AutoSize = true;
            this.moves.Location = new System.Drawing.Point(380, 224);
            this.moves.Name = "moves";
            this.moves.Size = new System.Drawing.Size(30, 13);
            this.moves.TabIndex = 15;
            this.moves.Text = "UNK";
            // 
            // nQueen
            // 
            this.nQueen.Location = new System.Drawing.Point(419, 288);
            this.nQueen.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nQueen.Name = "nQueen";
            this.nQueen.Size = new System.Drawing.Size(75, 20);
            this.nQueen.TabIndex = 16;
            this.nQueen.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nQueen.ValueChanged += new System.EventHandler(this.nQueen_ValueChanged);
            this.nQueen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nQueen_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "N Queens:";
            // 
            // solving
            // 
            this.solving.AutoSize = true;
            this.solving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solving.Location = new System.Drawing.Point(392, 336);
            this.solving.Name = "solving";
            this.solving.Size = new System.Drawing.Size(61, 13);
            this.solving.TabIndex = 18;
            this.solving.Text = "Solving...";
            this.solving.Visible = false;
            // 
            // animate
            // 
            this.animate.AutoSize = true;
            this.animate.Checked = true;
            this.animate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animate.Location = new System.Drawing.Point(328, 256);
            this.animate.Name = "animate";
            this.animate.Size = new System.Drawing.Size(64, 17);
            this.animate.TabIndex = 19;
            this.animate.Text = "Animate";
            this.animate.UseVisualStyleBackColor = true;
            this.animate.CheckedChanged += new System.EventHandler(this.animate_CheckedChanged);
            // 
            // animationSpeed
            // 
            this.animationSpeed.Location = new System.Drawing.Point(400, 256);
            this.animationSpeed.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.animationSpeed.Name = "animationSpeed";
            this.animationSpeed.Size = new System.Drawing.Size(120, 20);
            this.animationSpeed.TabIndex = 20;
            this.animationSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.animationSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.animationSpeed_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 414);
            this.Controls.Add(this.animationSpeed);
            this.Controls.Add(this.animate);
            this.Controls.Add(this.solving);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nQueen);
            this.Controls.Add(this.moves);
            this.Controls.Add(this.step);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentAttackingPair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initAttackingPair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lowestMoves);
            this.Controls.Add(this.minAttackingPair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentState);
            this.Controls.Add(this.initialState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "N Queens Hill Climbing";
            ((System.ComponentModel.ISupportInitialize)(this.initialState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox initialState;
        private System.Windows.Forms.PictureBox currentState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minAttackingPair;
        private System.Windows.Forms.ListBox lowestMoves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label initAttackingPair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentAttackingPair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Label moves;
        private System.Windows.Forms.NumericUpDown nQueen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label solving;
        private System.Windows.Forms.CheckBox animate;
        private System.Windows.Forms.NumericUpDown animationSpeed;
    }
}


namespace Snake_Game
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
            this.components = new System.ComponentModel.Container();
            this.snakeCanvas = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeCanvas
            // 
            this.snakeCanvas.BackColor = System.Drawing.Color.Gray;
            this.snakeCanvas.Location = new System.Drawing.Point(13, 13);
            this.snakeCanvas.Name = "snakeCanvas";
            this.snakeCanvas.Size = new System.Drawing.Size(541, 560);
            this.snakeCanvas.TabIndex = 0;
            this.snakeCanvas.TabStop = false;
            this.snakeCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(560, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(82, 23);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE: ";
            this.scoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(648, 13);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(32, 23);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "00";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(184, 263);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(123, 23);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 584);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.snakeCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeCanvas;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}


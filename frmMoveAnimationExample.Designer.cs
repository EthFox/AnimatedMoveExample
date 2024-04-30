namespace AnimatedMoveExample
{
	partial class frmMoveAnimationExample
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
			this.animatedSquare = new System.Windows.Forms.PictureBox();
			this.MoveStaggerTimer = new System.Windows.Forms.Timer(this.components);
			this.unanimatedSquare = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.animatedSquare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unanimatedSquare)).BeginInit();
			this.SuspendLayout();
			// 
			// animatedSquare
			// 
			this.animatedSquare.BackColor = System.Drawing.Color.DodgerBlue;
			this.animatedSquare.Location = new System.Drawing.Point(171, 193);
			this.animatedSquare.Name = "animatedSquare";
			this.animatedSquare.Size = new System.Drawing.Size(50, 50);
			this.animatedSquare.TabIndex = 1;
			this.animatedSquare.TabStop = false;
			// 
			// MoveStaggerTimer
			// 
			this.MoveStaggerTimer.Interval = 10;
			this.MoveStaggerTimer.Tick += new System.EventHandler(this.MoveStaggerTimer_Tick);
			// 
			// unanimatedSquare
			// 
			this.unanimatedSquare.BackColor = System.Drawing.Color.DodgerBlue;
			this.unanimatedSquare.Location = new System.Drawing.Point(530, 193);
			this.unanimatedSquare.Name = "unanimatedSquare";
			this.unanimatedSquare.Size = new System.Drawing.Size(50, 50);
			this.unanimatedSquare.TabIndex = 2;
			this.unanimatedSquare.TabStop = false;
			// 
			// frmMoveAnimationExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.unanimatedSquare);
			this.Controls.Add(this.animatedSquare);
			this.Name = "frmMoveAnimationExample";
			this.Text = "Move \"Animation\" Example";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMoveAnimationExample_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.animatedSquare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unanimatedSquare)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox animatedSquare;
		private System.Windows.Forms.Timer MoveStaggerTimer;
		private System.Windows.Forms.PictureBox unanimatedSquare;
	}
}


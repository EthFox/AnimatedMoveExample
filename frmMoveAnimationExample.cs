using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedMoveExample
{
	public partial class frmMoveAnimationExample : Form
	{
		public frmMoveAnimationExample()
		{
			InitializeComponent();
		}

		// allow for easy changes of how smooth you want the move to be (staggerNumber) and how far it goes (staggerAmount) \\
		const int staggerNumber = 5;
		const int moveAmount = 50;

		Point OffsetAmount; // allows calculations in tick event to work no matter the direction
		int staggerCounter; // stop the timer once the move has finished

		private void frmMoveAnimationExample_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Modification of KeyPress example \\
			char KeyPressed = e.KeyChar; 
			
			switch (KeyPressed)
			{
				case 'w':
					OffsetAmount = new Point(0, -moveAmount);
					break;
				case 'a':
					OffsetAmount = new Point(-moveAmount, 0);
					break;
				case 's':
					OffsetAmount = new Point(0, moveAmount);
					break;
				case 'd':
					OffsetAmount = new Point(moveAmount, 0);
					break;
				case '\u001b':
					this.Close();
					break;
			}

			MoveStaggerTimer.Start(); // once the direction to move has been found, start the move process

			// move unanimated square for comparison
			Point unanimatedLoc = unanimatedSquare.Location;
			unanimatedLoc.Offset(OffsetAmount);
			unanimatedSquare.Location = unanimatedLoc;
		}

		private void MoveStaggerTimer_Tick(object sender, EventArgs e) 
		{ // interval property currently set to 10, 100 times a second
			Point squareLoc = animatedSquare.Location;

			// stagger by the correct portion of the whole move distance
			squareLoc.Offset(OffsetAmount.X / staggerNumber, OffsetAmount.Y / staggerNumber); 
			++staggerCounter; // increment counter

			animatedSquare.Location = squareLoc; // move to offset location

			if (staggerCounter == staggerNumber) // if move is finished
			{
				MoveStaggerTimer.Stop(); // stop timer
				staggerCounter = 0; // reset counter
			}
		}
	}
}

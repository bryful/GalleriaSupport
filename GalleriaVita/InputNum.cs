using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleriaVita
{
	public enum IN_MODE
	{
		n0 = 0,
		n1,
		n2,
		n3,
		n4,
		n5,
		n6,
		n7,
		n8,
		n9,
		nA,
		nB,
		nC,
		nD,
		nE,
		nF,
		nP1,
		nP10,
		nM1,
		nM10,
		nCL,
		nBS,
		COUNT,
	}
	public partial class InputNum : UserControl
	{

		public class ModeEventArgs : EventArgs
		{
			public IN_MODE Mode;
		}
		public delegate void ModeEventHandler(object sender, ModeEventArgs e);

		//イベントデリゲートの宣言
		public event ModeEventHandler Mode;

		protected virtual void OnMode(ModeEventArgs e)
		{
			if (Mode != null)
			{
				Mode(this, e);
			}
		}



		public InputNum()
		{
			InitializeComponent();

			b0.Tag = (object)IN_MODE.n0;
			b1.Tag = (object)IN_MODE.n1;
			b2.Tag = (object)IN_MODE.n2;
			b3.Tag = (object)IN_MODE.n3;
			b4.Tag = (object)IN_MODE.n4;
			b5.Tag = (object)IN_MODE.n5;
			b6.Tag = (object)IN_MODE.n6;
			b7.Tag = (object)IN_MODE.n7;
			b8.Tag = (object)IN_MODE.n8;
			b9.Tag = (object)IN_MODE.n9;

			bA.Tag = (object)IN_MODE.nA;
			bB.Tag = (object)IN_MODE.nB;
			bC.Tag = (object)IN_MODE.nC;
			bD.Tag = (object)IN_MODE.nD;
			bE.Tag = (object)IN_MODE.nE;
			bF.Tag = (object)IN_MODE.nF;

			bPluss.Tag = (object)IN_MODE.nP1;
			b10Pluss.Tag = (object)IN_MODE.nP10;
			bMinus.Tag = (object)IN_MODE.nM1;
			b10Minus.Tag = (object)IN_MODE.nM10;

			bCL.Tag = (object)IN_MODE.nCL;
			bBS.Tag = (object)IN_MODE.nBS;
		}

		private void bCL_Click(object sender, EventArgs e)
		{
			IN_MODE m = (IN_MODE)((Button)sender).Tag;

			ModeEventArgs ma = new ModeEventArgs();
			ma.Mode = m;
			OnMode(ma);
		}
	}
}

using BRY;
using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleriaVita
{
	public class Hex_input_CB : Control
	{
		private bool m_Checked = false;
		public bool Checked
		{
			get { return m_Checked; }
			set
			{
				m_Checked = value;
				this.Invalidate();
			}
		}
		public Hex_input_CB()
		{
			this.Size = new Size(20, 20);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			SolidBrush sb = new SolidBrush(this.ForeColor);
			Pen p = new Pen(this.ForeColor);
			Graphics g = e.Graphics;

			try
			{
				Rectangle rct = new Rectangle(0, 0, this.ClientSize.Width - (int)p.Width, this.ClientSize.Height - (int)p.Width);
				g.DrawRectangle(p, rct);

				if (m_Checked == true)
				{
					rct = new Rectangle(3, 3, 14, 14);
					g.FillRectangle(sb, rct);
				}
			}
			finally
			{
				p.Dispose();
				sb.Dispose();

			}
		}
	}
}

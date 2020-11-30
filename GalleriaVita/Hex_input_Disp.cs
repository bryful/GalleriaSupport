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
	public class Hex_input_Disp : Control
	{
		// ****************************************************************
		private bool m_IsHex = true;
		public bool IsHex
		{
			get { return m_IsHex; }
			set { m_IsHex = value; this.Invalidate(); }
		}

		private int m_Inter = 17;
		public int Inter
		{
			get{return m_Inter;}
			set 
			{ 
				m_Inter = value;
				this.Invalidate();
			}
		}
		private long m_Value = 0;
		public long Value
		{
			get { return m_Value; }
			set
			{
				long v = value;
				if (v < 0) v = 0;
				else if (v > 0xFFFFFFFF) v = 0xFFFFFFFF;
				if (m_Value != v)
				{
					m_Value = v;
					this.Invalidate();
				}
			}
		}
		// ****************************************************************
		public Hex_input_Disp()
		{
			this.Size = new Size(200, 40);
			this.BackColor = SystemColors.Window;
			this.Font = new Font(this.Font.FontFamily, 30);
		}
		// ****************************************************************
		protected override void OnPaint(PaintEventArgs e)
		{
			//base.OnPaint(e);
			SolidBrush sb = new SolidBrush(this.BackColor);
			StringFormat sf = new StringFormat();
			Pen p = new Pen(this.ForeColor);
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			Graphics g = e.Graphics;
			try
			{
				Rectangle rct = new Rectangle(0, 0, this.Width, this.Height);
				g.FillRectangle(sb, rct);
				rct = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
				g.DrawRectangle(p, rct);

				sb.Color = this.ForeColor;
				int ba = 16;
				if (m_IsHex == false) ba = 10;
				string s = Convert.ToString(this.Value, ba).ToUpper();
				if (m_IsHex == true) s = "0x" + s;
				if (s.Length>0)
				{
					for(int i=s.Length-1;i>=0;i--)
					{
						int i2 = s.Length - 1 - i+ 1;
						rct = new Rectangle( (this.Width - i2 * m_Inter), 0, m_Inter, this.Height);
						g.DrawString(s.Substring(i, 1), this.Font, sb, rct, sf);
					}
				}

			}
			finally
			{
				sb.Dispose();
				p.Dispose();
			}
		}

	}
}

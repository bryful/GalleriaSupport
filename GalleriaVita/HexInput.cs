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
	// *******************************************************************************
	public class HexInput : Control
	{
		// 2186841624
		// 82588E18
		private Hex_input_Disp m_disp = new Hex_input_Disp();
		private Label m_lb = new Label();
		private Hex_input_CB m_cr = new Hex_input_CB();
		// **************************************************
		public long Value
		{
			get { return m_disp.Value; }
			set { m_disp.Value = value; }
		}

		// **************************************************
		public bool Checked
		{
			get { return m_cr.Checked; }
			set 
			{
				m_cr.Checked = value;
			}
		}
		public bool IsHex
		{
			get { return m_disp.IsHex; }
			set { m_disp.IsHex = value; }
		}

		// **************************************************
		public HexInput()
		{
			this.Size = new Size(225, 60);

			m_lb.Font = new Font(this.Font.FontFamily, 14);
			m_lb.AutoSize = false;
			m_lb.Size = new Size(200, 18);
			m_lb.Location = new Point(25, 0);
			m_lb.Text = "キャリーオーバー";

			m_cr.Location = new Point(0, 25);

			m_disp.Font = new Font(this.Font.FontFamily, 24);
			m_disp.Location = new Point(25, 20);
			this.Controls.Add(m_lb);
			this.Controls.Add(m_cr);
			this.Controls.Add(m_disp);

			m_lb.MouseDown += Target_MouseDown;
			m_cr.MouseDown += Target_MouseDown;
		}

		private void Target_MouseDown(object sender, MouseEventArgs e)
		{
			if (m_cr.Checked == true) return;
			int cnt = this.Parent.Controls.Count;
			if (cnt>=2)
			{
				for ( int i = 0; i<cnt;i++)
				{
					if (this.Parent.Controls[i] is HexInput)
					{
						Control hi = this.Parent.Controls[i];
						((HexInput)hi).Checked = false;
					}
				}
			}
			m_cr.Checked = true;
		}
		// **************************************************
		// **************************************************

	}
}

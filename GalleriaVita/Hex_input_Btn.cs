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
	public class Hex_input_Btn : Button
	{
		private IN_MODE m_mode = IN_MODE.NONE;
		public IN_MODE Mode
		{
			get { return m_mode; }
			set
			{
				SetMode(value);
			}
		}
		public Hex_input_Btn()
		{
			this.Size = new Size(75, 55);
			this.Font = new Font(this.Font.FontFamily, 24);
		}
		// *********************************************************
		protected override void OnTextChanged(EventArgs e)
		{
			SetMode(m_mode);
		}
		// *********************************************************
		private bool m_flag = false;
		public void SetMode(IN_MODE m)
		{
			m_mode = m;
			int v = (int)m;
			if (m_flag == true) return;
			m_flag = true;
			if ((v >= 0) && (v < (int)IN_MODE.COUNT))
			{
				this.Text = Hex_input_def.Cap[v];
			}
			else
			{
				this.Text = "--";
			}
			m_flag = false;
		}
	}
}

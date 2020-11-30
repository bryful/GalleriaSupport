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
	public partial class AdrValue : UserControl
	{
		private InputNum m_InputNum = null;
		public InputNum InputNum
		{
			get { return m_InputNum; }
			set
			{
				if(value==null)
				{
					if (m_InputNum != null)
					{
						m_InputNum.Mode -= M_InputNum_Mode;
					}
				}
				m_InputNum = value;

				if(m_InputNum !=null)
				{
					m_InputNum.Mode += M_InputNum_Mode;
				}
			}
		}

		private void M_InputNum_Mode(object sender, InputNum.ModeEventArgs e)
		{
			decimal v = 0;
			decimal ten = 0x10;
			if (cbHex.Checked)
			{
				ten = 0x10;
			}
			else
			{
				ten = 10;
			}
			switch ( e.Mode)
			{
				case IN_MODE.n0:
				case IN_MODE.n1:
				case IN_MODE.n2:
				case IN_MODE.n3:
				case IN_MODE.n4:
				case IN_MODE.n5:
				case IN_MODE.n6:
				case IN_MODE.n7:
				case IN_MODE.n8:
				case IN_MODE.n9:
				case IN_MODE.nA:
				case IN_MODE.nB:
				case IN_MODE.nC:
				case IN_MODE.nD:
				case IN_MODE.nF:
					v = numericUpDown1.Value;
					v = v * ten + (decimal)e.Mode;
					if (v < 0xFFFFFFFF)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;
				case IN_MODE.nBS:
					v = numericUpDown1.Value;
					v = Math.Floor( v / ten);
					if (numericUpDown1.Value != v)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;
				case IN_MODE.nCL:
					numericUpDown1.Value = (decimal)0;
					OnValueChanged(new EventArgs());
					break;
				case IN_MODE.nP1:
					v = numericUpDown1.Value;
					v += 1;
					if (v < 0xFFFFFFFF)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;
				case IN_MODE.nP10:
					v = numericUpDown1.Value;
					v += ten;
					if (v < 0xFFFFFFFF)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;
				case IN_MODE.nM1:
					v = numericUpDown1.Value;
					v -= 1;
					if (v < 0) v = 0;
					if (numericUpDown1.Value != v)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;
				case IN_MODE.nM10:
					v = numericUpDown1.Value;
					v -= ten;
					if (v < 0) v = 0;
					if (numericUpDown1.Value != v)
					{
						numericUpDown1.Value = v;
						OnValueChanged(new EventArgs());
					}
					break;

			}
		}

		public event EventHandler TargetON;
		protected virtual void OnTargetON(EventArgs e)
		{
			if (TargetON != null)
			{
				TargetON(this, e);
			}
		}
		public string Caption
		{
			get { return rb1.Text; }
			set { rb1.Text = value; }
		}
		public bool Target
		{
			get { return rb1.Checked; }
			set 
			{
				rb1.Checked = value;
				numericUpDown1.Enabled = value;
			}
		}
		public decimal Value
		{
			get { return numericUpDown1.Value; }
			set {
				if ((value >= numericUpDown1.Minimum)&&(value<=numericUpDown1.Maximum))
				{
					numericUpDown1.Value = value;
				}
			}
		}
		public event EventHandler ValueChanged;
		protected virtual void OnValueChanged(EventArgs e)
		{
			if (ValueChanged != null)
			{
				ValueChanged(this, e);
			}
		}


		public AdrValue()
		{
			InitializeComponent();

			numericUpDown1.Enabled = rb1.Checked;
			numericUpDown1.Hexadecimal = cbHex.Checked;
			cbHex.CheckedChanged += CbHex_CheckedChanged;
			rb1.CheckedChanged += Rb1_CheckedChanged;

			numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if(Target==true)
			{
				OnValueChanged(new EventArgs());
			}
		}

		private void Rb1_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown1.Enabled = rb1.Checked;
			if (rb1.Checked==true)
			{
				OnTargetON(new EventArgs());
			}
		}

		private void CbHex_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDown1.Hexadecimal = cbHex.Checked;
		}
	}
}

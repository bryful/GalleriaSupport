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

/// <summary>
/// 基本となるアプリのスケルトン
/// </summary>
namespace GalleriaVita
{

	public partial class Form1 : Form
	{
		private int target = -1;
		private AdrValue[] adrValues = new AdrValue[4];
		//-------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
		{
			InitializeComponent();

			adrValues[0] = adrG;
			adrValues[1] = adrMana;
			adrValues[2] = adrRF;
			adrValues[3] = adrCO;

			adrValues[0].Tag = (object)0;
			adrValues[1].Tag = (object)1;
			adrValues[2].Tag = (object)2;
			adrValues[3].Tag = (object)3;

			adrValues[0].TargetON += Form1_TargetON;
			adrValues[1].TargetON += Form1_TargetON;
			adrValues[2].TargetON += Form1_TargetON;
			adrValues[3].TargetON += Form1_TargetON;


			adrValues[0].ValueChanged += Form1_ValueChanged;
			adrValues[1].ValueChanged += Form1_ValueChanged;
			adrValues[2].ValueChanged += Form1_ValueChanged;
			adrValues[3].ValueChanged += Form1_ValueChanged;
		}

		private void Form1_ValueChanged(object sender, EventArgs e)
		{
			long [] tbl = new long[] {0,0x8, 0x10,0x60};
			if (target < 0) return;
			long v = 0;
			switch(target)
			{
				case 0:
					v = (long)adrValues[0].Value;
					adrValues[1].Value = (decimal)(v + (tbl[1] - tbl[0]));
					adrValues[2].Value = (decimal)(v + (tbl[2] - tbl[0]));
					adrValues[3].Value = (decimal)(v + (tbl[3] - tbl[0]));
					break;
				case 1:
					v = (long)adrValues[1].Value;
					adrValues[0].Value = (decimal)(v + (tbl[0] - tbl[1]));
					adrValues[2].Value = (decimal)(v + (tbl[2] - tbl[1]));
					adrValues[3].Value = (decimal)(v + (tbl[3] - tbl[1]));
					break;
				case 2:
					v = (long)adrValues[2].Value;
					adrValues[0].Value = (decimal)(v + (tbl[0] - tbl[2]));
					adrValues[1].Value = (decimal)(v + (tbl[1] - tbl[2]));
					adrValues[3].Value = (decimal)(v + (tbl[3] - tbl[2]));
					break;
				case 3:
					v = (long)adrValues[3].Value;
					adrValues[0].Value = (decimal)(v + (tbl[0] - tbl[3]));
					adrValues[1].Value = (decimal)(v + (tbl[1] - tbl[3]));
					adrValues[2].Value = (decimal)(v + (tbl[2] - tbl[3]));
					break;
			}
		}

		private void Form1_TargetON(object sender, EventArgs e)
		{
			if (target >= 0)
			{
				adrValues[target].Target = false;
				adrValues[target].InputNum = null;
			}
			int v = (int)((AdrValue)sender).Tag;
			target = v;
			adrValues[target].InputNum = inputNum1;
		}

		/// <summary>
		/// コントロールの初期化はこっちでやる
		/// </summary>
		protected override void InitLayout()
		{
			base.InitLayout();
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォーム作成時に呼ばれる
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			//設定ファイルの読み込み
			JsonPref pref = new JsonPref();
			if (pref.Load())
			{
				bool ok = false;
				Point p = pref.GetPoint("Point", out ok);
				if (ok) this.Location = p;
			}
			this.Text = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
		}
		//-------------------------------------------------------------
		/// <summary>
		/// フォームが閉じられた時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//設定ファイルの保存
			JsonPref pref = new JsonPref();
			pref.SetPoint("Point", this.Location);
			pref.Save();

		}
		//-------------------------------------------------------------
		/// <summary>
		/// ドラッグ＆ドロップの準備
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
		}
		/// <summary>
		/// ドラッグ＆ドロップの本体
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
		}
		//-------------------------------------------------------------
		/// <summary>
		/// ダミー関数
		/// </summary>
		/// <param name="cmd"></param>
		public void GetCommand(string[] cmd)
		{
			if (cmd.Length > 0)
			{
				foreach (string s in cmd)
				{
				}
			}
		}
		/// <summary>
		/// メニューの終了
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//-------------------------------------------------------------
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppInfoDialog.ShowAppInfoDialog();
		}
	}
}

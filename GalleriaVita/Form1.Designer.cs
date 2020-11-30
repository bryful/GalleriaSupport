
namespace GalleriaVita
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hexInput1 = new GalleriaVita.HexInput();
			this.inputNum1 = new GalleriaVita.InputNum();
			this.adrCO = new GalleriaVita.AdrValue();
			this.adrRF = new GalleriaVita.AdrValue();
			this.adrMana = new GalleriaVita.AdrValue();
			this.adrG = new GalleriaVita.AdrValue();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(615, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.aboutToolStripMenuItem.Text = "バージョン情報の表示";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// hexInput1
			// 
			this.hexInput1.BackColor = System.Drawing.SystemColors.Control;
			this.hexInput1.Checked = false;
			this.hexInput1.IsHex = true;
			this.hexInput1.Location = new System.Drawing.Point(25, 371);
			this.hexInput1.Name = "hexInput1";
			this.hexInput1.Size = new System.Drawing.Size(225, 64);
			this.hexInput1.TabIndex = 7;
			this.hexInput1.Text = "hexInput1";
			this.hexInput1.Value = ((long)(64));
			// 
			// inputNum1
			// 
			this.inputNum1.Location = new System.Drawing.Point(268, 27);
			this.inputNum1.Name = "inputNum1";
			this.inputNum1.Size = new System.Drawing.Size(356, 427);
			this.inputNum1.TabIndex = 6;
			// 
			// adrCO
			// 
			this.adrCO.Caption = "キャリーオーバー";
			this.adrCO.InputNum = null;
			this.adrCO.Location = new System.Drawing.Point(12, 285);
			this.adrCO.MaximumSize = new System.Drawing.Size(250, 80);
			this.adrCO.MinimumSize = new System.Drawing.Size(250, 80);
			this.adrCO.Name = "adrCO";
			this.adrCO.Size = new System.Drawing.Size(250, 80);
			this.adrCO.TabIndex = 5;
			this.adrCO.Target = false;
			this.adrCO.Value = new decimal(new int[] {
            -2108125672,
            0,
            0,
            0});
			// 
			// adrRF
			// 
			this.adrRF.Caption = "リーンフォース";
			this.adrRF.InputNum = null;
			this.adrRF.Location = new System.Drawing.Point(12, 199);
			this.adrRF.MaximumSize = new System.Drawing.Size(250, 80);
			this.adrRF.MinimumSize = new System.Drawing.Size(250, 80);
			this.adrRF.Name = "adrRF";
			this.adrRF.Size = new System.Drawing.Size(250, 80);
			this.adrRF.TabIndex = 4;
			this.adrRF.Target = false;
			this.adrRF.Value = new decimal(new int[] {
            -2108125672,
            0,
            0,
            0});
			// 
			// adrMana
			// 
			this.adrMana.Caption = "マナ";
			this.adrMana.InputNum = null;
			this.adrMana.Location = new System.Drawing.Point(12, 113);
			this.adrMana.MaximumSize = new System.Drawing.Size(250, 80);
			this.adrMana.MinimumSize = new System.Drawing.Size(250, 80);
			this.adrMana.Name = "adrMana";
			this.adrMana.Size = new System.Drawing.Size(250, 80);
			this.adrMana.TabIndex = 3;
			this.adrMana.Target = false;
			this.adrMana.Value = new decimal(new int[] {
            -2108125672,
            0,
            0,
            0});
			// 
			// adrG
			// 
			this.adrG.Caption = "銀貨";
			this.adrG.InputNum = null;
			this.adrG.Location = new System.Drawing.Point(12, 27);
			this.adrG.MaximumSize = new System.Drawing.Size(250, 80);
			this.adrG.MinimumSize = new System.Drawing.Size(250, 80);
			this.adrG.Name = "adrG";
			this.adrG.Size = new System.Drawing.Size(250, 80);
			this.adrG.TabIndex = 2;
			this.adrG.Target = false;
			this.adrG.Value = new decimal(new int[] {
            -2108125672,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 459);
			this.Controls.Add(this.hexInput1);
			this.Controls.Add(this.inputNum1);
			this.Controls.Add(this.adrCO);
			this.Controls.Add(this.adrRF);
			this.Controls.Add(this.adrMana);
			this.Controls.Add(this.adrG);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Galleria Vita Support";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private AdrValue adrG;
		private AdrValue adrMana;
		private AdrValue adrRF;
		private AdrValue adrCO;
		private InputNum inputNum1;
		private HexInput hexInput1;
	}
}


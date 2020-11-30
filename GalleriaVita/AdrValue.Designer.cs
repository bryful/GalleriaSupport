
namespace GalleriaVita
{
	partial class AdrValue
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

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.cbHex = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// rb1
			// 
			this.rb1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rb1.Location = new System.Drawing.Point(3, 5);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(169, 28);
			this.rb1.TabIndex = 0;
			this.rb1.TabStop = true;
			this.rb1.Text = "キャリーオーバー";
			this.rb1.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numericUpDown1.Hexadecimal = true;
			this.numericUpDown1.Location = new System.Drawing.Point(3, 39);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            -2063597568,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(242, 39);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            -2108125672,
            0,
            0,
            0});
			// 
			// cbHex
			// 
			this.cbHex.AutoSize = true;
			this.cbHex.Checked = true;
			this.cbHex.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHex.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbHex.Location = new System.Drawing.Point(178, 8);
			this.cbHex.Name = "cbHex";
			this.cbHex.Size = new System.Drawing.Size(67, 25);
			this.cbHex.TabIndex = 2;
			this.cbHex.Text = "HEX";
			this.cbHex.UseVisualStyleBackColor = true;
			// 
			// AdrValue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbHex);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.rb1);
			this.MaximumSize = new System.Drawing.Size(250, 80);
			this.MinimumSize = new System.Drawing.Size(250, 80);
			this.Name = "AdrValue";
			this.Size = new System.Drawing.Size(250, 80);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox cbHex;
	}
}

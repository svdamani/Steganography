namespace Steganography
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.saveImageButton = new System.Windows.Forms.Button();
			this.encodeButton = new System.Windows.Forms.Button();
			this.decodeButton = new System.Windows.Forms.Button();
			this.saveTextButton = new System.Windows.Forms.Button();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.psnrTextBox = new System.Windows.Forms.TextBox();
			this.mseTextBox = new System.Windows.Forms.TextBox();
			this.decodeTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.encodeTextBox = new System.Windows.Forms.TextBox();
			this.base64TextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.toolStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(400, 400);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// textBox
			// 
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(424, 12);
			this.textBox.Margin = new System.Windows.Forms.Padding(4);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.Size = new System.Drawing.Size(360, 175);
			this.textBox.TabIndex = 1;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(507, 201);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(256, 26);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.UseSystemPasswordChar = true;
			this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(421, 204);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(69, 18);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "Password";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(41, 420);
			this.browseButton.Margin = new System.Windows.Forms.Padding(4);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(114, 34);
			this.browseButton.TabIndex = 5;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// saveImageButton
			// 
			this.saveImageButton.Location = new System.Drawing.Point(333, 420);
			this.saveImageButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveImageButton.Name = "saveImageButton";
			this.saveImageButton.Size = new System.Drawing.Size(114, 34);
			this.saveImageButton.TabIndex = 6;
			this.saveImageButton.Text = "Save Image";
			this.saveImageButton.UseVisualStyleBackColor = true;
			this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
			// 
			// encodeButton
			// 
			this.encodeButton.Location = new System.Drawing.Point(190, 420);
			this.encodeButton.Margin = new System.Windows.Forms.Padding(4);
			this.encodeButton.Name = "encodeButton";
			this.encodeButton.Size = new System.Drawing.Size(114, 34);
			this.encodeButton.TabIndex = 7;
			this.encodeButton.Text = "Encode";
			this.encodeButton.UseVisualStyleBackColor = true;
			this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
			// 
			// decodeButton
			// 
			this.decodeButton.Location = new System.Drawing.Point(475, 419);
			this.decodeButton.Margin = new System.Windows.Forms.Padding(4);
			this.decodeButton.Name = "decodeButton";
			this.decodeButton.Size = new System.Drawing.Size(114, 34);
			this.decodeButton.TabIndex = 8;
			this.decodeButton.Text = "Decode";
			this.decodeButton.UseVisualStyleBackColor = true;
			this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
			// 
			// saveTextButton
			// 
			this.saveTextButton.Location = new System.Drawing.Point(622, 419);
			this.saveTextButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveTextButton.Name = "saveTextButton";
			this.saveTextButton.Size = new System.Drawing.Size(114, 34);
			this.saveTextButton.TabIndex = 9;
			this.saveTextButton.Text = "Save Text";
			this.saveTextButton.UseVisualStyleBackColor = true;
			this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
			this.toolStrip.Location = new System.Drawing.Point(0, 676);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(797, 25);
			this.toolStrip.TabIndex = 10;
			// 
			// toolStripLabel
			// 
			this.toolStripLabel.Name = "toolStripLabel";
			this.toolStripLabel.Size = new System.Drawing.Size(0, 22);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.psnrTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.mseTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.decodeTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.encodeTextBox, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 473);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 188);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// psnrTextBox
			// 
			this.psnrTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.psnrTextBox.Location = new System.Drawing.Point(189, 150);
			this.psnrTextBox.Name = "psnrTextBox";
			this.psnrTextBox.ReadOnly = true;
			this.psnrTextBox.Size = new System.Drawing.Size(100, 26);
			this.psnrTextBox.TabIndex = 7;
			// 
			// mseTextBox
			// 
			this.mseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mseTextBox.Location = new System.Drawing.Point(189, 102);
			this.mseTextBox.Name = "mseTextBox";
			this.mseTextBox.ReadOnly = true;
			this.mseTextBox.Size = new System.Drawing.Size(100, 26);
			this.mseTextBox.TabIndex = 6;
			// 
			// decodeTextBox
			// 
			this.decodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.decodeTextBox.Location = new System.Drawing.Point(189, 56);
			this.decodeTextBox.Name = "decodeTextBox";
			this.decodeTextBox.ReadOnly = true;
			this.decodeTextBox.Size = new System.Drawing.Size(100, 26);
			this.decodeTextBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Encode Time (ms)";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mean Square Error";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Decode Time (ms)";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Peak SNR";
			// 
			// encodeTextBox
			// 
			this.encodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.encodeTextBox.Location = new System.Drawing.Point(189, 10);
			this.encodeTextBox.Name = "encodeTextBox";
			this.encodeTextBox.ReadOnly = true;
			this.encodeTextBox.Size = new System.Drawing.Size(100, 26);
			this.encodeTextBox.TabIndex = 4;
			// 
			// base64TextBox
			// 
			this.base64TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.base64TextBox.Location = new System.Drawing.Point(424, 237);
			this.base64TextBox.Multiline = true;
			this.base64TextBox.Name = "base64TextBox";
			this.base64TextBox.ReadOnly = true;
			this.base64TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.base64TextBox.Size = new System.Drawing.Size(360, 175);
			this.base64TextBox.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 701);
			this.Controls.Add(this.base64TextBox);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.saveTextButton);
			this.Controls.Add(this.decodeButton);
			this.Controls.Add(this.encodeButton);
			this.Controls.Add(this.saveImageButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.pictureBox);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LSB Image Steganography";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button saveImageButton;
		private System.Windows.Forms.Button encodeButton;
		private System.Windows.Forms.Button decodeButton;
		private System.Windows.Forms.Button saveTextButton;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel toolStripLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox psnrTextBox;
		private System.Windows.Forms.TextBox mseTextBox;
		private System.Windows.Forms.TextBox decodeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox encodeTextBox;
		private System.Windows.Forms.TextBox base64TextBox;
	}
}


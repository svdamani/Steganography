using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Steganography {
	public partial class MainForm : Form {
		private string initialDir = AppDomain.CurrentDomain.BaseDirectory;

		private OpenFileDialog openFileDialog = new OpenFileDialog { Title = "Open" };

		private SaveFileDialog saveFileDialog = new SaveFileDialog { Title = "Save" };

		private Bitmap originalImg;

		public MainForm() => InitializeComponent();

		#region - Events -

		private void MainForm_Load(object sender, EventArgs e) {
		}

		private void browseButton_Click(object sender, EventArgs e) {
			openFileDialog.InitialDirectory = initialDir;
			openFileDialog.Filter = "Image Files (*.bmp, *.png)|*.bmp; *.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				pictureBox.Image = Image.FromFile(openFileDialog.FileName);
				var maxLength = pictureBox.Image.Width * pictureBox.Image.Height / 8;
				textBox.MaxLength = maxLength;
				initialDir = Path.GetDirectoryName(openFileDialog.FileName);
				ClearFields();
			}
		}

		private void saveImageButton_Click(object sender, EventArgs e) {
			saveFileDialog.InitialDirectory = initialDir;
			saveFileDialog.Filter = "Bitmap Image (.bmp)|*.bmp|PNG Image (.png)|*.png";
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				switch (saveFileDialog.FilterIndex) {
				case 1:
					pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
					break;
				case 2:
					pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
					break;
				}
				initialDir = Path.GetDirectoryName(saveFileDialog.FileName);
			}
		}

		private void saveTextButton_Click(object sender, EventArgs e) {
			saveFileDialog.InitialDirectory = initialDir;
			saveFileDialog.Filter = "Text File (.txt)|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(saveFileDialog.FileName, textBox.Text);
				initialDir = Path.GetDirectoryName(saveFileDialog.FileName);
			}
		}

		private void encodeButton_Click(object sender, EventArgs e) {
			if (!IsValid())
				return;
			ClearFields();
			var time = Time(() => {
				var text = Crypto.Encrypt(textBox.Text, passwordBox.Text);
				originalImg = new Bitmap(pictureBox.Image);
				var stegoImage = Stego.Encode(originalImg, text);
				var mse = CalculateMse(originalImg, stegoImage);
				var psnr = 20 * Math.Log10(255 / Math.Sqrt(mse));
				pictureBox.Image = stegoImage;
				textBox.Text = "";
				passwordBox.Text = "";
				mseTextBox.Text = $"{mse}";
				psnrTextBox.Text = $"{psnr}";
			});
			encodeTextBox.Text = $"{time}";
		}

		private void decodeButton_Click(object sender, EventArgs e) {
			if (!IsValid(false))
				return;
			var time = Time(() => {
				var bmp = new Bitmap(pictureBox.Image);
				var text = Stego.Decode(bmp);
				pictureBox.Image = originalImg ?? bmp;
				textBox.Text = Crypto.Decrypt(text, passwordBox.Text);
			});
			ClearFields();
			decodeTextBox.Text = $"{time}";
		}

		private void passwordBox_TextChanged(object sender, EventArgs e) {
			base64TextBox.Text = Crypto.Encrypt(textBox.Text, passwordBox.Text);
		}

		#endregion

		#region - Helpers -

		private bool IsValid(bool required = true) {
			if (pictureBox.Image == null) {
				toolStripLabel.Text = "Error: Please select a cover image.";
				return false;
			}
			if (required && string.IsNullOrWhiteSpace(textBox.Text)) {
				toolStripLabel.Text = "Error: The text you want to hide can't be empty.";
				return false;
			}
			if (string.IsNullOrWhiteSpace(passwordBox.Text)) {
				toolStripLabel.Text = "Error: The encryption password can't be empty.";
				return false;
			}
			toolStripLabel.Text = "";
			return true;
		}

		private long Time(Action action) {
			toolStripLabel.Text = "";
			var watch = Stopwatch.StartNew();
			action();
			watch.Stop();
			var elapsed = watch.ElapsedMilliseconds;
			// toolStripLabel.Text = $"Time taken: {elapsed} ms";
			return elapsed;
		}

		private void ClearFields() {
			encodeTextBox.Text = "";
			decodeTextBox.Text = "";
			mseTextBox.Text = "";
			psnrTextBox.Text = "";
		}

		private double CalculateMse(Bitmap bmp1, Bitmap bmp2) {
			var width = bmp1.Width;
			var height = bmp1.Height;
			var total = 0.0;
			for (var x = 0; x < width; ++x) {
				for (var y = 0; y < height; ++y) {
					var p1 = bmp1.GetPixel(x, y);
					var p2 = bmp2.GetPixel(x, y);
					total += Math.Pow(p1.R - p2.R, 2) + Math.Pow(p1.G - p2.G, 2) + Math.Pow(p1.B - p2.B, 2);
				}
			}
			return total / (width * height * 1.0);
		}

		#endregion
	}
}
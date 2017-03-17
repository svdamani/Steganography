using System.Drawing;

namespace Steganography {
	internal static class Stego {
		public static Bitmap Encode(Bitmap image, string text) {
			var bmp = new Bitmap(image);
			var zeroFill = false;
			var charIdx = 0;
			var charVal = 0;
			var pixelIdx = 0L;
			var zeros = 0;
			int red = 0, green = 0, blue = 0;
			for (var x = 0; x < bmp.Width; x++) {
				for (var y = 0; y < bmp.Height; y++) {
					var pixel = bmp.GetPixel(x, y);
					red = pixel.R - pixel.R % 2;
					green = pixel.G - pixel.G % 2;
					blue = pixel.B - pixel.B % 2;

					for (int n = 0; n < 3; n++) {
						if (pixelIdx % 8 == 0) {
							if (zeroFill && zeros == 8) {
								if ((pixelIdx - 1) % 3 < 2)
									bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
								return bmp;
							}
							if (charIdx >= text.Length)
								zeroFill = true;
							else
								charVal = text[charIdx++];
						}

						switch (pixelIdx % 3) {
						case 0:
							if (!zeroFill) {
								red += charVal % 2;
								charVal /= 2;
							}
							break;
						case 1:
							if (!zeroFill) {
								green += charVal % 2;
								charVal /= 2;
							}
							break;
						case 2:
							if (!zeroFill) {
								blue += charVal % 2;
								charVal /= 2;
							}
							bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
							break;
						}
						pixelIdx++;
						if (zeroFill)
							zeros++;
					}
				}
			}
			return bmp;
		}

		public static string Decode(Bitmap bmp) {
			var colorIdx = 0;
			var charVal = 0;
			var text = "";
			for (var x = 0; x < bmp.Width; x++) {
				for (var y = 0; y < bmp.Height; y++) {
					var pixel = bmp.GetPixel(x, y);
					for (var n = 0; n < 3; n++) {
						switch (colorIdx % 3) {
						case 0:
							charVal = charVal * 2 + pixel.R % 2;
							break;
						case 1:
							charVal = charVal * 2 + pixel.G % 2;
							break;
						case 2:
							charVal = charVal * 2 + pixel.B % 2;
							break;
						}
						colorIdx++;
						if (colorIdx % 8 == 0) {
							charVal = ReverseBits(charVal);
							if (charVal == 0)
								return text;
							text += (char)charVal;
						}
					}
				}
			}
			return text;
		}

		private static int ReverseBits(int n) {
			var result = 0;
			for (var i = 0; i < 8; i++) {
				result = result * 2 + n % 2;
				n /= 2;
			}
			return result;
		}
	}
}
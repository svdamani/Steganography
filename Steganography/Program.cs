﻿using System;
using System.Windows.Forms;

namespace Steganography {
	internal static class Program {
		// The main entry point for the application.
		[STAThread]
		private static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
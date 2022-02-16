using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Blackjack
{
	class PreferenceProfile
	{
		private string prefsFile = Environment.CurrentDirectory + "\\TableColor.prefs";
		public Color BackColor { get; set; } = Color.Green;

		public void LoadPreferences(Form form)
		{
			if (form == null) return;
			if (File.Exists(prefsFile))
			{
				BinaryFormatter bfmt = new BinaryFormatter();
				FileStream str = new FileStream(prefsFile, FileMode.Open, FileAccess.Read, FileShare.None);
				BackColor = (Color)bfmt.Deserialize(str);
				str.Close();
			}
			SetPreferences(form);
		}

		public void SavePreferences()
		{
			BinaryFormatter bfmt = new BinaryFormatter();
			FileStream str = new FileStream(prefsFile, FileMode.Create, FileAccess.Write, FileShare.None);
			bfmt.Serialize(str, BackColor);
			str.Close();
		}

		public void SetPreferences(Form form)
		{
			if (form == null) return;
			form.BackColor = BackColor;
			SavePreferences();
		}

		public void ResetDefaultPreferences(Form form)
		{
			if (File.Exists(prefsFile)) File.Delete(prefsFile);
			BackColor = Color.Green;
			SetPreferences(form);
		}
	}
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LilithsThroneXMLGenerator
{
	public partial class Chooser : Form
	{
		public Chooser()
		{
			InitializeComponent();
		}
		public static string path = Directory.GetCurrentDirectory();
		private void button1_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(path + "/DataSources/Data.xml") == true)
			{
				if (modChooser.Text == "Clothing")
			{
				Hide();
				ClothingForm clothingForm = new ClothingForm();
				clothingForm.ShowDialog();
				Close();
			}
				if (modChooser.Text == "Weapon")
			{
				Hide();
				WeaponForm weaponForm = new WeaponForm();
				weaponForm.ShowDialog();
				Close();
			}
				if (modChooser.Text == "Tattoo")
			{
				Hide();
				TattooForm tattooForm = new TattooForm();
				tattooForm.ShowDialog();
				Close();
			}
				else
			{
				MessageBox.Show("You need to choose which type of mod you want to create.");
			}
			}
			else
			{
				MessageBox.Show("You are missing the DataSources directory. It needs to be in the same folder as this .EXE.");
			}
		}
	}
}

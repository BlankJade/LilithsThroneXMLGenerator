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
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Schema;

namespace LilithsThroneXMLGenerator
{
	public partial class TattooForm : Form
	{
		public TattooForm()
		{
			InitializeComponent();
			onload();

		}
		public static string path = Directory.GetCurrentDirectory();
		XDocument data = XDocument.Load(path + "/DataSources/Data.xml");
		private void onload()
		{
			foreach (XElement element in data.Descendants("slot"))
			{
				slots.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("colour"))
			{
				apc.Items.Add(element.Value);
				asc.Items.Add(element.Value);
				atc.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("colourType"))
			{
				apct.Items.Add(element.Value);
				asct.Items.Add(element.Value);
				atct.Items.Add(element.Value);
			}
		}

		private void apct_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (apct.Text == "CUSTOM")
			{
				apc.Enabled = true;
			}
			else
			{
				apc.Enabled = false;
				for (int i = 0; i < apc.Items.Count; i++)
				{
					apc.SetItemChecked(i, false);
				}
			}
		}
		private void asct_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (asct.Text == "CUSTOM")
			{
				asc.Enabled = true;
			}
			else
			{
				asc.Enabled = false;
				for (int i = 0; i < asc.Items.Count; i++)
				{
					asc.SetItemChecked(i, false);
				}
			}
		}
		private void atct_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (atct.Text == "CUSTOM")
			{
				atc.Enabled = true;
			}
			else
			{
				atc.Enabled = false;
				for (int i = 0; i < atc.Items.Count; i++)
				{
					atc.SetItemChecked(i, false);
				}
			}
		}
		private void GenerateXML()
		{
			XDocument xmlDocument = new XDocument(
					new XDeclaration("1.0", "utf-8", "no"),
						new XElement("tattoo",
							new XElement("coreAtributes",
								new XElement("value", numericUpDown1.Value),
								new XElement("name", new XCData(textBox1.Text)),
								new XElement("description", new XCData(textBox2.Text)),
								new XElement("imageName", textBox3.Text),
								new XElement("enchantmentLimit", numericUpDown2.ToString()),
								new XElement("slotAvailability"),
								new XElement("primaryColours"),
								new XElement("secondaryColours"),
								new XElement("tertiaryColours"))));

			foreach (var slot in slots.CheckedItems)
			{
				xmlDocument.XPathSelectElement("tattoo/coreAtributes/slotAvailability").Add(new XElement("slot", slot.ToString()));
			}

			if (apct.Text == "CUSTOM")
			{
				foreach (var colour in apc.CheckedItems)
				{
					xmlDocument.XPathSelectElement("tattoo/coreAtributes/primaryColours").Add(new XElement("colour", colour.ToString()));
				}
			}
			else if (apct.Text != "")
			{
				xmlDocument.XPathSelectElement("tattoo/coreAtributes/primaryColours").Add(new XAttribute("values", apct.Text));
			}
			
			if (asct.Text == "CUSTOM")
			{
				foreach (var colour in asc.CheckedItems)
				{
					xmlDocument.XPathSelectElement("tattoo/coreAtributes/secondaryColours").Add(new XElement("colour", colour.ToString()));
				}
			}
			else if (asct.Text != "")
			{
				xmlDocument.XPathSelectElement("tattoo/coreAtributes/secondaryColours").Add(new XAttribute("values", asct.Text));
			}
			if (atct.Text == "CUSTOM")
			{
				foreach (var colour in atc.CheckedItems)
				{
					xmlDocument.XPathSelectElement("tattoo/coreAtributes/tertiaryColours").Add(new XElement("colour", colour.ToString()));
				}
			}
			else if (atct.Text != "")
			{
				xmlDocument.XPathSelectElement("tattoo/coreAtributes/tertiaryColours").Add(new XAttribute("values", atct.Text));
			}
			
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = ("\t")
			};
			using (XmlWriter writer = XmlTextWriter.Create(path + "/XMLGeneratorTempData/previewtattoo.xml", settings))
			{
				xmlDocument.Save(writer);
			}
			SaveFileDialog saveFileDialog1 = new SaveFileDialog
			{
				Filter = "XML Document|*.xml",
				Title = "Save your XML to..."
			};
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (saveFileDialog1.FileName != "")
				{
					try
					{
						if (Directory.Exists(path + "/XMLGeneratorTempData") == false)
						{
							Directory.CreateDirectory(path + "/XMLGeneratorTempData");
						}
						File.Copy(path + "/XMLGeneratorTempData/previewtattoo.xml", saveFileDialog1.FileName, true);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				else
				{
					MessageBox.Show("You forgot to set a filename");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GenerateXML();
		}

		private void TattooForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			Owner.Show();
		}
	}
}

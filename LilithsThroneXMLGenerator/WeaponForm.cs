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
	public partial class WeaponForm : Form
	{
		public WeaponForm()
		{
			InitializeComponent();
			onload();
		}
		private int Enchantments = 0;
		public static string path = Directory.GetCurrentDirectory();
		XDocument data = XDocument.Load(path + "/DataSources/Data.xml");
		private void onload()
		{
			foreach (XElement element in data.Descendants("damageVariance"))
			{
				comboBox5.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("spell"))
			{
				comboBox6.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("weaponAttribute"))
			{
				comboBox10.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("tag"))
			{
				itemTags.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("damageType"))
			{
				damageTypes.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("colour"))
			{
				colour1.Items.Add(element.Value);
				colour2.Items.Add(element.Value);
				colour3.Items.Add(element.Value);
				colour4.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("colourType"))
			{
				prim.Items.Add(element.Value);
				primd.Items.Add(element.Value);
				sec.Items.Add(element.Value);
				secd.Items.Add(element.Value);
			}
		}
		
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				numericUpDown4.Enabled = true;
				button1.Enabled = true;
			}
			else
			{
				numericUpDown4.Enabled = false;
				button1.Enabled = false;
			}
		}
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox3.Text == "CUSTOM")
			{
				textBox7.Enabled = true;
			}
			else
			{
				textBox7.Enabled = false;
			}
		}
		private void prim_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (prim.Text == "CUSTOM")
			{
				colour1.Enabled = true;
			}
			else
			{
				colour1.Enabled = false;
			}
		}
		private void primd_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (primd.Text == "CUSTOM")
			{
				colour2.Enabled = true;
			}
			else
			{
				colour2.Enabled = false;
			}
		}
		private void sec_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sec.Text == "CUSTOM")
			{
				colour3.Enabled = true;
			}
			else
			{
				colour3.Enabled = false;
			}
		}
		private void secd_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (secd.Text == "CUSTOM")
			{
				colour4.Enabled = true;
			}
			else
			{
				colour4.Enabled = false;
			}
		}

		public static List<string> Hit = new List<string>();
		public static List<string> Miss = new List<string>();		
		//Hit&Miss Texts
		private void button6_Click(object sender, EventArgs e)
		{
			Hit.Add(textBox13.Text);
			comboBox15.Items.Clear();
			foreach (string text in Hit)
			{
				comboBox15.Items.Add(text);
			}
			textBox13.Text = "";
		}
		private void button7_Click(object sender, EventArgs e)
		{
			Miss.Add(textBox14.Text);
			comboBox16.Items.Clear();
			foreach (string text in Miss)
			{
				comboBox16.Items.Add(text);
			}
			textBox14.Text = "";
		}
		private void button4_Click(object sender, EventArgs e)
		{
			Hit.RemoveAt(comboBox15.SelectedIndex);
			comboBox15.Items.Clear();
			foreach (string text in Hit)
			{
				comboBox15.Items.Add(text);
			}
			comboBox15.Text = "";
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Miss.RemoveAt(comboBox16.SelectedIndex);
			comboBox16.Items.Clear();
			foreach (string text in Miss)
			{
				comboBox16.Items.Add(text);
			}
			comboBox16.Text = "";
		}

		//data grid view
		private void button1_Click(object sender, EventArgs e)
		{
			if (Enchantments < numericUpDown3.Value)
			{
				if (comboBox8.Text != "")
				{ 
					if (comboBox9.Text != "")
					{
						if (comboBox10.Text != "")
						{
							int b = dataGridView1.Rows.Add();
							dataGridView1.Rows[b].Cells[0].Value = comboBox7.Text;
							dataGridView1.Rows[b].Cells[1].Value = numericUpDown5.Value;
							dataGridView1.Rows[b].Cells[2].Value = comboBox8.Text;
							dataGridView1.Rows[b].Cells[3].Value = comboBox9.Text;
							dataGridView1.Rows[b].Cells[4].Value = comboBox10.Text;
							dataGridView1.Rows[b].Cells[5].Value = numericUpDown6.Value;
							Enchantments++;
						}
						else
						{
							MessageBox.Show("You are missing some variables there friend.");
						}
					}
					else
					{
						MessageBox.Show("You are missing some variables there friend.");
					}
				}
				else
				{
					MessageBox.Show("You are missing some variables there friend.");
				}
			}
			else
			{
				MessageBox.Show("You have too few enchantment slots. Consider adding some.");
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count != 0)
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				{
					dataGridView1.Rows.RemoveAt(row.Index);
					Enchantments--;
				}
			}
			else
			{
				MessageBox.Show("You have no rows selected");
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you really sure you want to do this?", "Remove all Enchantments", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//removal proccess
				dataGridView1.Rows.Clear();
				//reset enchantLimit
				Enchantments = 0;
			}
		}


		private string determiner;
		private string plural;
		private string enchantment;
		void Replacements()
		{
			if (comboBox3.Text == "CUSTOM")
			{
				determiner = textBox7.Text;
			}
			if (comboBox3.Text != "CUSTOM")
			{
				determiner = comboBox3.Text;
			}
			if (checkBox1.Checked == true)
			{
				plural = "true";
			}
			if (checkBox1.Checked == false)
			{
				plural = "false";
			}
			if (numericUpDown4.Value == 0)
			{
				enchantment = "";
			}
			if (numericUpDown4.Value != 0)
			{
				enchantment = numericUpDown4.Value.ToString();
			}
		}
		private void GeneratePreview()
		{

			Replacements();
			XDocument xmlDocument = new XDocument(
					new XDeclaration("1.0", "utf-8", "no"),
						new XElement("weapon",
							new XElement("coreAttributes",
								new XElement("value", numericUpDown1.Value),
								new XElement("melee", comboBox1.Text),
								new XElement("twoHanded", comboBox2.Text),
								new XElement("determiner", new XCData(determiner.ToString())),
								new XElement("name", new XCData(textBox1.Text)),
								new XElement("namePlural", new XAttribute("pluralByDefault", plural.ToString()), new XCData(textBox2.Text)),
								new XElement("description", new XCData(textBox3.Text)),
								new XElement("attackDescriptor", textBox4.Text),
								new XElement("attackTooltipDescription", textBox12.Text),
								new XElement("rarity", comboBox4.Text),
								new XElement("equipText", textBox10.Text),
								new XElement("unequipText", textBox11.Text),
								new XElement("imageName", textBox5.Text),
								new XElement("imageEquippedName", textBox6.Text),
								new XElement("damage", numericUpDown2.Value),
								new XElement("arcaneCost", numericUpDown3.Value),
								new XElement("damageVariance", comboBox5.Text),
								new XElement("availableDamageTypes"),
								new XElement("spells"),
								new XElement("enchantmentLimit", enchantment.ToString()),
								new XElement("effects"),
								new XElement("primaryColours"),
								new XElement("primaryColoursDye"),
								new XElement("secondaryColours"),
								new XElement("secondaryColoursDye"),
								new XElement("itemTags")),
							new XElement("hitDescriptions"),
							new XElement("missDescriptions")));

			if (comboBox6.Text != "")
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/spells").Add(new XElement("spell", comboBox6.Text));
			}
			foreach (var item in damageTypes.CheckedItems)
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/availableDamageTypes").Add(new XElement("damageType", item.ToString()));
			}
			if (prim.Text == "CUSTOM")
			{
				foreach (var colour in colour1.CheckedItems)
				{
					xmlDocument.XPathSelectElement("weapon/coreAttributes/primaryColours").Add(new XElement("colour", colour.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/primaryColours").Add(new XAttribute("values", prim.Text));
			}
			if (primd.Text == "CUSTOM")
			{
				foreach (var colour in colour2.CheckedItems)
				{
					xmlDocument.XPathSelectElement("weapon/coreAttributes/primaryColoursDye").Add(new XElement("colour", colour.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/primaryColoursDye").Add(new XAttribute("values", prim.Text));
			}
			if (sec.Text == "CUSTOM")
			{
				foreach (var colour in colour3.CheckedItems)
				{
					xmlDocument.XPathSelectElement("weapon/coreAttributes/secondaryColours").Add(new XElement("colour", colour.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/secondaryColours").Add(new XAttribute("values", prim.Text));
			}
			if (secd.Text == "CUSTOM")
			{
				foreach (var colour in colour4.CheckedItems)
				{
					xmlDocument.XPathSelectElement("weapon/coreAttributes/secondaryColoursDye").Add(new XElement("colour", colour.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/secondaryColoursDye").Add(new XAttribute("values", prim.Text));
			}
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/effects").Add(new XElement("effect", new XAttribute("itemEffectType", dataGridView1.Rows[i].Cells[0].Value.ToString()), new XAttribute("limit", dataGridView1.Rows[i].Cells[1].Value.ToString()), new XAttribute("potency", dataGridView1.Rows[i].Cells[2].Value.ToString()), new XAttribute("primaryModifier", dataGridView1.Rows[i].Cells[3].Value.ToString()), new XAttribute("secondaryModifier", dataGridView1.Rows[i].Cells[4].Value.ToString()), new XAttribute("timer", dataGridView1.Rows[i].Cells[5].Value.ToString())));
			}
			foreach (var item in itemTags.CheckedItems)
			{
				xmlDocument.XPathSelectElement("weapon/coreAttributes/itemTags").Add(new XElement("tag", item.ToString()));
			}
			foreach (string hit in Hit)
			{
				xmlDocument.XPathSelectElement("weapon/hitDescriptions").Add(new XElement("hitText", new XCData(hit)));
			}
			foreach (string miss in Miss)
			{
				xmlDocument.XPathSelectElement("weapon/missDescriptions").Add(new XElement("missText", new XCData(miss)));
			}
			//save
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = ("\t")
			};
			using (XmlWriter writer = XmlTextWriter.Create(path + "/XMLGeneratorTempData/previewweapon.xml", settings))
			{
				xmlDocument.Save(writer);
			}
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab == tabControl1.TabPages["savepreview"])
			{
				GeneratePreview();
				previewBox.Text = XDocument.Load(path + "/XMLGeneratorTempData/previewweapon.xml").ToString();
			}
		}
		private void button8_Click(object sender, EventArgs e)
		{
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
							GeneratePreview();
						}
						File.Copy(path + "/XMLGeneratorTempData/previewweapon.xml", saveFileDialog1.FileName, true);
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
		private void WeaponForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			Owner.Show();
		}

		
	}
}

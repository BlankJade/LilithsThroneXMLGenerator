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
	public partial class ClothingForm : Form
	{
		//Initialize Common things.
		public ClothingForm()
		{
			InitializeComponent();
			onload();
		}
		public static string path = Directory.GetCurrentDirectory();
		XDocument data = XDocument.Load(path + "/DataSources/Data.xml");
		private int Enchantments = 0;

		//code
		public void onload()
		{
			foreach (XElement element in data.Descendants("colour"))
			{
				colour1.Items.Add(element.Value);
				colour2.Items.Add(element.Value);
				colour3.Items.Add(element.Value);
				colour4.Items.Add(element.Value);
				colour5.Items.Add(element.Value);
				colour6.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("colourType"))
			{
				comboBox10.Items.Add(element.Value);
				comboBox11.Items.Add(element.Value);
				comboBox12.Items.Add(element.Value);
				comboBox13.Items.Add(element.Value);
				comboBox14.Items.Add(element.Value);
				comboBox15.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("set"))
			{
				comboBox5.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("slot"))
			{
				comboBox3.Items.Add(element.Value);
				incSlots.Items.Add(element.Value);
				csBox1.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("tag"))
			{
				itemTags.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("bp"))
			{
				bbpBox1.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("cl"))
			{
				cabBox1.Items.Add(element.Value);
				carBox1.Items.Add(element.Value);
			}
			previewBox.ScrollBars = ScrollBars.Vertical;
		}
		public void checkLimit()
		{
			if (comboBox9.Text == "TF_MOD_SIZE")
			{
				if (comboBox8.Text == "TF_FACE")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else if (comboBox8.Text == "TF_CORE")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 244;
				}
				else if (comboBox8.Text == "TF_HAIR")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 140;
				}
				else if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 91;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 40;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 50;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}

			}
			if (comboBox9.Text == "TF_MOD_SIZE_SECONDARY")
			{
				if (comboBox8.Text == "TF_CORE")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 100;
				}
				else if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_SIZE_TERTIARY")
			{
				if (comboBox8.Text == "TF_CORE")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 100;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_CAPACITY")
			{
				if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 40;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 40;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 40;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 40;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_ELASTICITY")
			{
				if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_PLASTICITY")
			{
				if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_WETNESS")
			{
				if (comboBox8.Text == "TF_ASS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 10000;
				}
				else if (comboBox8.Text == "TF_VAGINA")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 7;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_CUM_EXPULSION")
			{
				if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 100;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_REGENERATION")
			{
				if (comboBox8.Text == "TF_BREASTS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else if (comboBox8.Text == "TF_PENIS")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 4;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
			if (comboBox9.Text == "TF_MOD_FEMININITY")
			{
				if (comboBox8.Text == "TF_CORE")
				{
					numericUpDown4.Enabled = true;
					numericUpDown4.Maximum = 100;
				}
				else
				{
					numericUpDown4.Enabled = false;
				}
			}
		}
		//preview Generator
		private string determiner;
		private string plural;
		private string enchantment;
		void Replacements()
		{
			if (comboBox1.Text == "CUSTOM")
			{
				determiner = textBox1.Text;
			}
			if (comboBox1.Text != "CUSTOM")
			{
				determiner = comboBox1.Text;
			}
			if (checkBox1.Checked == true)
			{
				plural = "true";
			}
			if (checkBox1.Checked == false)
			{
				plural = "false";
			}
			if (numericUpDown3.Value == 0)
			{
				enchantment = "";
			}
			if (numericUpDown3.Value != 0)
			{
				enchantment = numericUpDown3.Value.ToString();
			}
		}
		private void GeneratePreview()
		{

			Replacements();
			XDocument xmlDocument = new XDocument(
					new XDeclaration("1.0", "utf-8", "no"),
						new XElement("clothing",
							new XElement("coreAtributes",
								new XElement("value", numericUpDown1.Value),
								new XElement("determiner", new XCData(determiner.ToString())),
								new XElement("name", new XCData(textBox2.Text)),
								new XElement("namePlural", new XAttribute("pluralByDefault", plural.ToString()), new XCData(textBox3.Text)),
								new XElement("description", new XCData(textBox4.Text)),
								new XElement("physicalResistance", numericUpDown2.Value),
								new XElement("femininity", comboBox2.Text),
								new XElement("slot", comboBox3.Text),
								new XElement("rarity", comboBox4.Text),
								new XElement("clothingSet", comboBox5.Text),
								new XElement("imageName", textBox5.Text),
								new XElement("imageEquippedName", textBox6.Text),
								new XElement("enchantmentLimit", enchantment.ToString()),
								new XElement("effects"),
								new XElement("blockedPartsList",
									new XElement("blockedParts",
										new XElement("displacementType", "REMOVE_OR_EQUIP"),
										new XElement("clothingAccessRequired"),
										new XElement("blockedBodyParts"),
										new XElement("clothingAccessBlocked"),
										new XElement("concealedSlots"))),
								new XElement("incompatibleSlots"),
								new XElement("primaryColours"),
								new XElement("primaryColoursDye"),
								new XElement("secondaryColours"),
								new XElement("secondaryColoursDye"),
								new XElement("tertiaryColours"),
								new XElement("tertiaryColoursDye"),
								new XElement("itemTags")),
							new XElement("displacementText", new XAttribute("type", "REMOVE_OR_EQUIP"),
								new XElement("playerSelf", new XCData(dText1.Text)),
								new XElement("playerNPC", new XCData(dText2.Text)),
								new XElement("playerNPCRough", new XCData(dText3.Text)),
								new XElement("NPCSelf", new XCData(dText4.Text)),
								new XElement("NPCPlayer", new XCData(dText5.Text)),
								new XElement("NPCPlayerRough", new XCData(dText6.Text)),
								new XElement("NPCOtherNPC", new XCData(dText7.Text)),
								new XElement("NPCOtherNPCRough", new XCData(dText8.Text))),
							new XElement("replacementText", new XAttribute("type", "REMOVE_OR_EQUIP"),
								new XElement("playerSelf", new XCData(rText1.Text)),
								new XElement("playerNPC", new XCData(rText2.Text)),
								new XElement("playerNPCRough", new XCData(rText3.Text)),
								new XElement("NPCSelf", new XCData(rText4.Text)),
								new XElement("NPCPlayer", new XCData(rText5.Text)),
								new XElement("NPCPlayerRough", new XCData(rText6.Text)),
								new XElement("NPCOtherNPC", new XCData(rText7.Text)),
								new XElement("NPCOtherNPCRough", new XCData(rText8.Text)))));
			//Add in more data
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/effects").Add(new XElement("effect", new XAttribute("itemEffectType", dataGridView1.Rows[i].Cells[0].Value.ToString()), new XAttribute("limit", dataGridView1.Rows[i].Cells[1].Value.ToString()), new XAttribute("potency", dataGridView1.Rows[i].Cells[2].Value.ToString()), new XAttribute("primaryModifier", dataGridView1.Rows[i].Cells[3].Value.ToString()), new XAttribute("secondaryModifier", dataGridView1.Rows[i].Cells[4].Value.ToString()), new XAttribute("timer", dataGridView1.Rows[i].Cells[5].Value.ToString())));
			}
			foreach (var item in carBox1.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[1]/clothingAccessRequired").Add(new XElement("clothingAccess", item.ToString()));
			}
			foreach (var item in cabBox1.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[1]/clothingAccessBlocked").Add(new XElement("clothingAccess", item.ToString()));
			}
			foreach (var item in csBox1.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[1]/concealedSlots").Add(new XElement("slot", item.ToString()));
			}
			foreach (var item in bbpBox1.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[1]/blockedBodyParts").Add(new XElement("bodyPart", item.ToString()));
			}
			foreach (var item in incSlots.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/incompatibleSlots").Add(new XElement("slot", item.ToString()));
			}
			foreach (var item in itemTags.CheckedItems)
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/itemTags").Add(new XElement("tag", item.ToString()));
			}
			if (comboBox10.Text == "CUSTOM")
			{
				foreach (var item in colour1.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/primaryColours").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/primaryColours").Add(new XAttribute("values", comboBox10.Text));
			}
			if (comboBox11.Text == "CUSTOM")
			{
				foreach (var item in colour2.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/primaryColoursDye").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/primaryColoursDye").Add(new XAttribute("values", comboBox11.Text));
			}
			if (comboBox12.Text == "CUSTOM")
			{
				foreach (var item in colour3.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/secondaryColours").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/secondaryColours").Add(new XAttribute("values", comboBox12.Text));
			}
			if (comboBox13.Text == "CUSTOM")
			{
				foreach (var item in colour4.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/secondaryColoursDye").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/secondaryColoursDye").Add(new XAttribute("values", comboBox13.Text));
			}
			if (comboBox14.Text == "CUSTOM")
			{
				foreach (var item in colour5.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/tertiaryColours").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/tertiaryColours").Add(new XAttribute("values", comboBox14.Text));
			}
			if (comboBox15.Text == "CUSTOM")
			{
				foreach (var item in colour6.CheckedItems)
				{
					xmlDocument.XPathSelectElement("clothing/coreAtributes/tertiaryColours").Add(new XElement("colour", item.ToString()));
				}
			}
			else
			{
				xmlDocument.XPathSelectElement("clothing/coreAtributes/tertiaryColoursDye").Add(new XAttribute("values", comboBox15.Text));
			}

			if (Clothing_Arrays.lPlacement.Count != 0)
			{
				for (int i = 0; i < Clothing_Arrays.lPlacement.Count; i++)
				{
					int ian = 2 + i;
					if (Clothing_Arrays.lPlacement[i].Count == 2)
					{
						xmlDocument.XPathSelectElement("clothing").Add(new XElement("displacementText", new XAttribute("type", Clothing_Arrays.lPlacement[i][0])));
						xmlDocument.XPathSelectElement("clothing").Add(new XElement("replacementText", new XAttribute("type", Clothing_Arrays.lPlacement[i][1])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("playerSelf", new XCData(Clothing_Arrays.lTexts[i][0])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("playerNPC", new XCData(Clothing_Arrays.lTexts[i][1])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("playerNPCRough", new XCData(Clothing_Arrays.lTexts[i][2])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("NPCSelf", new XCData(Clothing_Arrays.lTexts[i][3])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("NPCPlayer", new XCData(Clothing_Arrays.lTexts[i][4])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("NPCPlayerRough", new XCData(Clothing_Arrays.lTexts[i][5])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("NPCOtherNPC", new XCData(Clothing_Arrays.lTexts[i][6])));
						xmlDocument.XPathSelectElement("clothing/displacementText[last()]").Add(new XElement("NPCOtherNPCRough", new XCData(Clothing_Arrays.lTexts[i][7])));

						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("playerSelf", new XCData(Clothing_Arrays.lTexts[i][8])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("playerNPC", new XCData(Clothing_Arrays.lTexts[i][9])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("playerNPCRough", new XCData(Clothing_Arrays.lTexts[i][10])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("NPCSelf", new XCData(Clothing_Arrays.lTexts[i][11])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("NPCPlayer", new XCData(Clothing_Arrays.lTexts[i][12])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("NPCPlayerRough", new XCData(Clothing_Arrays.lTexts[i][13])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("NPCOtherNPC", new XCData(Clothing_Arrays.lTexts[i][14])));
						xmlDocument.XPathSelectElement("clothing/replacementText[last()]").Add(new XElement("NPCOtherNPCRough", new XCData(Clothing_Arrays.lTexts[i][15])));

					}
					else if (Clothing_Arrays.lPlacement[i].Count == 1)
					{
						xmlDocument.XPathSelectElement("clothing").Add(new XElement("displacementText", new XAttribute("type", Clothing_Arrays.lPlacement[i][0])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("playerSelf", new XCData(Clothing_Arrays.lTexts[i][0])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("playerNPC", new XCData(Clothing_Arrays.lTexts[i][1])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("playerNPCRough", new XCData(Clothing_Arrays.lTexts[i][2])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("NPCSelf", new XCData(Clothing_Arrays.lTexts[i][3])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("NPCPlayer", new XCData(Clothing_Arrays.lTexts[i][4])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("NPCPlayerRough", new XCData(Clothing_Arrays.lTexts[i][5])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("NPCOtherNPC", new XCData(Clothing_Arrays.lTexts[i][6])));
						xmlDocument.XPathSelectElement("clothing/displacementText[" + ian + "]").Add(new XElement("NPCOtherNPCRough", new XCData(Clothing_Arrays.lTexts[i][7])));

					}
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList").Add(new XElement("blockedParts"));
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]").Add(new XElement("displacementType", Clothing_Arrays.lPlacement[i][0]));
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]").Add(new XElement("clothingAccessRequired"));
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]").Add(new XElement("blockedBodyParts"));
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]").Add(new XElement("clothingAccessBlocked"));
					xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]").Add(new XElement("concealedSlots"));
					for (int a = 0; a < Clothing_Arrays.lclothingAccessRequired[i].Count; a++)
					{
						xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]/clothingAccessRequired").Add(new XElement("clothingAccess", Clothing_Arrays.lclothingAccessRequired[i][a]));
					}
					for (int a = 0; a < Clothing_Arrays.lclothingAccessBlocked[i].Count; a++)
					{
						xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]/clothingAccessBlocked").Add(new XElement("clothingAccess", Clothing_Arrays.lclothingAccessBlocked[i][a]));
					}
					for (int a = 0; a < Clothing_Arrays.lblockedBodyParts[i].Count; a++)
					{
						xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]/blockedBodyParts").Add(new XElement("bodyPart", Clothing_Arrays.lblockedBodyParts[i][a]));
					}
					for (int a = 0; a < Clothing_Arrays.lconcealedSlots[i].Count; a++)
					{
						xmlDocument.XPathSelectElement("clothing/coreAtributes/blockedPartsList/blockedParts[" + ian + "]/concealedSlots").Add(new XElement("slot", Clothing_Arrays.lconcealedSlots[i][a]));
					}
				}
			}




			//save
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = ("\t")
			};
			using (XmlWriter writer = XmlTextWriter.Create(path + "/XMLGeneratorTempData/preview.xml", settings))
			{
				xmlDocument.Save(writer);
			}

		}
		//events
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "CUSTOM")
			{
				textBox1.Enabled = true;
			}
			else
			{
				textBox1.Enabled = false;
			}
		}
		private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox10.Text == "CUSTOM")
			{
				colour1.Enabled = true;
			}
			else
			{
				colour1.Enabled = false;
				foreach (int i in colour1.CheckedIndices)
				{
					colour1.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox11.Text == "CUSTOM")
			{
				colour2.Enabled = true;
			}
			else
			{
				colour2.Enabled = false;
				foreach (int i in colour2.CheckedIndices)
				{
					colour2.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox12.Text == "CUSTOM")
			{
				colour3.Enabled = true;
			}
			else
			{
				colour3.Enabled = false;
				foreach (int i in colour3.CheckedIndices)
				{
					colour3.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox13.Text == "CUSTOM")
			{
				colour4.Enabled = true;
			}
			else
			{
				colour4.Enabled = false;
				foreach (int i in colour4.CheckedIndices)
				{
					colour4.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox14.Text == "CUSTOM")
			{
				colour5.Enabled = true;
			}
			else
			{
				colour5.Enabled = false;
				foreach (int i in colour5.CheckedIndices)
				{
					colour5.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox15.Text == "CUSTOM")
			{
				colour6.Enabled = true;
			}
			else
			{
				colour6.Enabled = false;
				foreach (int i in colour6.CheckedIndices)
				{
					colour6.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				textBox3.Enabled = false;
			}
			else
			{
				textBox3.Enabled = true;
			}
		}
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				numericUpDown3.Enabled = true;
				button1.Enabled = true;
			}
			else
			{
				numericUpDown3.Enabled = false;
				button1.Enabled = false;
			}
		}
		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox9.Items.Clear();
			if (comboBox8.SelectedItem.ToString() == "CLOTHING_ATTRIBUTE")
			{
				comboBox9.Items.Clear();
				foreach (XElement element in data.Descendants("clothingAttribute"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "CLOTHING_ENSLAVEMENT")
			{
				comboBox9.Items.Clear();
				foreach (XElement element in data.Descendants("ens"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "CLOTHING_SEALING")
			{
				comboBox9.Items.Clear();
				foreach (XElement element in data.Descendants("seal"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_MOD_FETISH_BODY_PART")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/bodyPartFetishes/fetish"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_MOD_FETISH_BEHAVIOUR")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/behaviourFetishes/fetish"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_FACE")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/faceTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_CORE")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/coreTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_HAIR")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/hairTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_ASS")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/assTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_PENIS")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/penisTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_BREASTS")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/breastsTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			if (comboBox8.SelectedItem.ToString() == "TF_VAGINA")
			{
				foreach (XElement element in data.XPathSelectElements("root/clothingEnchantmentData/vaginaTF/TF"))
				{
					comboBox9.Items.Add(element.Value);
				}
			}
			comboBox9.SelectedIndex = 0;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (Enchantments < numericUpDown3.Value)
			{
				if (comboBox7.Text != "")
				{
					if (comboBox8.Text != "")
					{
						int b = dataGridView1.Rows.Add();
						dataGridView1.Rows[b].Cells[0].Value = comboBox6.Text;
						dataGridView1.Rows[b].Cells[1].Value = numericUpDown4.Value;
						dataGridView1.Rows[b].Cells[2].Value = comboBox7.Text;
						dataGridView1.Rows[b].Cells[3].Value = comboBox8.Text;
						dataGridView1.Rows[b].Cells[4].Value = comboBox9.Text;
						dataGridView1.Rows[b].Cells[5].Value = numericUpDown5.Value;
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
		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			if (numericUpDown3.Value < dataGridView1.RowCount)
			{
				numericUpDown3.Value = dataGridView1.RowCount;
			}
		}
		private void button4_Click(object sender, EventArgs e)
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
						System.IO.File.Copy(path + "/XMLGeneratorTempData/preview.xml", saveFileDialog1.FileName, true);
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
		//add new displacement
		private void button5_Click(object sender, EventArgs e)
		{
			if (displacementBox.Text != "")
			{
				DisplacementManager displacementTab = new DisplacementManager();
				displacementTab.Dock = DockStyle.Fill;
				TabPage newTabpage = new TabPage();
				displacementTab.Parent = this;
				newTabpage.Text = displacementBox.Text;
				newTabpage.Controls.Add(displacementTab);
				tabControl2.TabPages.Add(newTabpage);
				displacementTab.comboBox1.Text = displacementBox.Text;
				if (replacementBox.Text != "")
				{
				displacementTab.comboBox2.Text = replacementBox.Text;
				}
				displacementBox.Text = "";
				replacementBox.Text = "";
				displacementTab.saveclick += new EventHandler(button6_Click);
			}
			else
			{
				MessageBox.Show("You need to choose a Displacement type before you can create a new Displacement.");
			}
		}
		//remove active displacement tab
		private void button6_Click(object sender, EventArgs e)
		{
			tabControl2.TabPages.Remove(tabControl2.SelectedTab);
		}
		//remove all displacements
		private void button7_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you really sure you want to do this?", "Remove all Displacements", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				tabControl2.TabPages.Clear();
				Clothing_Arrays.lclothingAccessBlocked.Clear();
				Clothing_Arrays.lclothingAccessRequired.Clear();
				Clothing_Arrays.lconcealedSlots.Clear();
				Clothing_Arrays.lPlacement.Clear();
				Clothing_Arrays.lTexts.Clear();
				Clothing_Arrays.lblockedBodyParts.Clear();
			}
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab == tabControl1.TabPages["prevsav"])
			{
				listEdit.Items.Clear();
				for (int i = 0; i < Clothing_Arrays.lPlacement.Count; i++)
				{
					if (Clothing_Arrays.lPlacement[i].Count != 2)
					{
						listEdit.Items.Add(Clothing_Arrays.lPlacement[i][0]);
					}
					else
					{
						listEdit.Items.Add(string.Format("{0} | {1}", Clothing_Arrays.lPlacement[i][0], Clothing_Arrays.lPlacement[i][1]));
					}
				}
				GeneratePreview();
				previewBox.Text = XDocument.Load(path + "/XMLGeneratorTempData/preview.xml").ToString();
			}
		}
		private void button8_Click(object sender, EventArgs e)
		{
			Clothing_Arrays.lclothingAccessBlocked.RemoveAt(listEdit.SelectedIndex);
			Clothing_Arrays.lclothingAccessRequired.RemoveAt(listEdit.SelectedIndex);
			Clothing_Arrays.lconcealedSlots.RemoveAt(listEdit.SelectedIndex);
			Clothing_Arrays.lPlacement.RemoveAt(listEdit.SelectedIndex);
			Clothing_Arrays.lTexts.RemoveAt(listEdit.SelectedIndex);
			Clothing_Arrays.lblockedBodyParts.RemoveAt(listEdit.SelectedIndex);
			listEdit.Items.Clear();
			for (int i = 0; i < Clothing_Arrays.lPlacement.Count; i++)
			{
				if (Clothing_Arrays.lPlacement[i].Count != 2)
				{
					listEdit.Items.Add(Clothing_Arrays.lPlacement[i][0]);
				}
				else
				{
					listEdit.Items.Add(string.Format("{0} | {1}", Clothing_Arrays.lPlacement[i][0], Clothing_Arrays.lPlacement[i][1]));
				}
			}
			GeneratePreview();
			previewBox.Text = XDocument.Load(path + "/XMLGeneratorTempData/preview.xml").ToString();
			listEdit.Text = "";
		}
		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkLimit();
		}

		


		public void ClothingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			Owner.Show();
		}

		
	}
}

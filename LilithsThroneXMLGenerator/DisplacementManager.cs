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
	public partial class DisplacementManager : UserControl
	{
		public DisplacementManager()
		{
			InitializeComponent();
			onload();
		}
		public static string path = Directory.GetCurrentDirectory();
		XDocument data = XDocument.Load(path + "/DataSources/Data.xml");
		private void onload()
		{
			foreach (XElement element in data.Descendants("bp"))
			{
				bbpBox1.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("cl"))
			{
				cabBox1.Items.Add(element.Value);
				carBox1.Items.Add(element.Value);
			}
			foreach (XElement element in data.Descendants("slot"))
			{
				csBox1.Items.Add(element.Value);
			}
		}

		private static List<string> tempclothingAccessRequired = new List<string>();
		private static List<string> tempclothingAccessBlocked = new List<string>();
		private static List<string> tempconcealedSlots = new List<string>();
		private static List<string> tempblockedBodyParts = new List<string>();
		private static List<string> tempPlacement = new List<string>();
		private static List<string> tempText = new List<string>();

		public event EventHandler saveclick;
		public void raisesaveclick()
		{
			saveclick?.Invoke(this, new EventArgs());
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text != "")
			{
				if (dText1.Text != "")
				{
					if (dText2.Text != "")
					{
						if (dText3.Text != "")
						{
							if (dText4.Text != "")
							{
								if (dText5.Text != "")
								{
									if (dText6.Text != "")
									{
										if (dText7.Text != "")
										{
											if (dText8.Text != "")
											{
												if (comboBox2.Text != "")
												{
													if (rText1.Text != "")
													{
														if (rText2.Text != "")
														{
															if (rText3.Text != "")
															{
																if (rText4.Text != "")
																{
																	if (rText5.Text != "")
																	{
																		if (rText6.Text != "")
																		{
																			if (rText7.Text != "")
																			{
																				if (rText8.Text != "")
																				{
																					tempPlacement.Add(comboBox1.Text);
																					tempPlacement.Add(comboBox2.Text);
																					foreach (var item in carBox1.CheckedItems)
																					{
																						tempclothingAccessRequired.Add(item.ToString());
																					}
																					foreach (var item in cabBox1.CheckedItems)
																					{
																						tempclothingAccessBlocked.Add(item.ToString());
																					}
																					foreach (var item in csBox1.CheckedItems)
																					{
																						tempconcealedSlots.Add(item.ToString());
																					}
																					foreach (var item in bbpBox1.CheckedItems)
																					{
																						tempclothingAccessBlocked.Add(item.ToString());
																					}
																					tempText.Add(dText1.Text);
																					tempText.Add(dText2.Text);
																					tempText.Add(dText3.Text);
																					tempText.Add(dText4.Text);
																					tempText.Add(dText5.Text);
																					tempText.Add(dText6.Text);
																					tempText.Add(dText7.Text);
																					tempText.Add(dText8.Text);
																					tempText.Add(rText1.Text);
																					tempText.Add(rText2.Text);
																					tempText.Add(rText3.Text);
																					tempText.Add(rText4.Text);
																					tempText.Add(rText5.Text);
																					tempText.Add(rText6.Text);
																					tempText.Add(rText7.Text);
																					tempText.Add(rText8.Text);
																					Clothing_Arrays.lPlacement.Add(new List<string>(tempPlacement));
																					Clothing_Arrays.lclothingAccessRequired.Add(new List<string>(tempclothingAccessRequired));
																					Clothing_Arrays.lclothingAccessBlocked.Add(new List<string>(tempclothingAccessBlocked));
																					Clothing_Arrays.lblockedBodyParts.Add(new List<string>(tempblockedBodyParts));
																					Clothing_Arrays.lconcealedSlots.Add(new List<string>(tempconcealedSlots));
																					Clothing_Arrays.lTexts.Add(new List<string>(tempText));
																					tempclothingAccessBlocked.Clear();
																					tempclothingAccessRequired.Clear();
																					tempconcealedSlots.Clear();
																					tempPlacement.Clear();
																					tempText.Clear();
																					tempblockedBodyParts.Clear();
																					raisesaveclick();
																				}
																				else
																				{
																					MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 8th is missing.");
																				}
																			}
																			else
																			{
																				MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 7th is missing.");
																			}
																		}
																		else
																		{
																			MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 6th is missing.");
																		}
																	}
																	else
																	{
																		MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 5th is missing.");
																	}
																}
																else
																{
																	MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 4th is missing.");
																}
															}
															else
															{
																MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 3rd is missing.");
															}
														}
														else
														{
															MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 2nd is missing.");
														}
													}
													else
													{
														MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a replacement but the 1st is missing.");
													}
												}
												else
												{
													tempPlacement.Add(comboBox1.Text);
													foreach (var item in carBox1.CheckedItems)
													{
														tempclothingAccessRequired.Add(item.ToString());
													}
													foreach (var item in cabBox1.CheckedItems)
													{
														tempclothingAccessBlocked.Add(item.ToString());
													}
													foreach (var item in csBox1.CheckedItems)
													{
														tempconcealedSlots.Add(item.ToString());
													}
													foreach (var item in bbpBox1.CheckedItems)
													{
														tempclothingAccessBlocked.Add(item.ToString());
													}
													tempText.Add(dText1.Text);
													tempText.Add(dText2.Text);
													tempText.Add(dText3.Text);
													tempText.Add(dText4.Text);
													tempText.Add(dText5.Text);
													tempText.Add(dText6.Text);
													tempText.Add(dText7.Text);
													tempText.Add(dText8.Text);
													Clothing_Arrays.lPlacement.Add(new List<string>(tempPlacement));
													Clothing_Arrays.lclothingAccessRequired.Add(new List<string>(tempclothingAccessRequired));
													Clothing_Arrays.lclothingAccessBlocked.Add(new List<string>(tempclothingAccessBlocked));
													Clothing_Arrays.lblockedBodyParts.Add(new List<string>(tempblockedBodyParts));
													Clothing_Arrays.lconcealedSlots.Add(new List<string>(tempconcealedSlots));
													Clothing_Arrays.lTexts.Add(new List<string>(tempText));
													tempclothingAccessBlocked.Clear();
													tempclothingAccessRequired.Clear();
													tempconcealedSlots.Clear();
													tempPlacement.Clear();
													tempText.Clear();
													tempblockedBodyParts.Clear();
													raisesaveclick();
												}
											}
											else
											{
												MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 8th is missing.");
											}
										}
										else
										{
											MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 7th is missing.");
										}
									}
									else
									{
										MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 6th is missing.");
									}
								}
								else
								{
									MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 5th is missing.");
								}
							}
							else
							{
								MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 4th is missing.");
							}
						}
						else
						{
							MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 3rd is missing.");
						}
					}
					else
					{
						MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 2nd is missing.");
					}
				}
				else
				{
					MessageBox.Show("You are not done here. Check for blank Textboxes. You selected a Displacement but the 1st is missing.");
				}
			}
			else
			{
				MessageBox.Show("You are not done here. You have not selected a Displacement.");
			}
		}
	}
}

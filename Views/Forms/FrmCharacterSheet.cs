using System;
using System.Drawing;
using System.Windows.Forms;
using Views;
using Model;
using Presenters;
using Presenter;

namespace Main
{

	/// <summary>
	///				!!! IMPORTANT !!!
	///				
	/// THIS FORM WORKS WITH A FAKE CHAR, WHICH IS ACTUALLY A NEW CHARACTER THAT LIVES AND DIES HERE. IT ONLY SERVES THE MERE PURPOSE OF
	/// HAVING A DUMMY TO WORK ON, BEFORE ALL THE REAL CHANGES ARE PERFORMED ON THE REAL CHARACTER AND OTHER CHARACTERS RELATED TO IT.
	/// 
	/// MAY THE CHANGES NOT BE CONFIRMED AT THE END OF THIS FORM, NOTHING REALLY REACHES THE ORIGINAL CHARACTER. OTHERWISE ANY CHANGES
	/// ARE PASSED FROM THE FAKE CHAR TO THE ORIGINAL CHAR, AND FROM THE ORIGINAL TO THE OTHERS.
	/// </summary>
	public partial class FrmCharacterSheet : Form , ICharacterSheet
	{
		//*************************************************
		Character character;
		Character fakeCharacter;

		Character characterEventArgs;
		string auxString;

		int edited = 0;	// EDITED = 0: NO CHANGES WERE PERFORMED. EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED. EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.
        int option = 0;
        int initialized = 0;
		Image raceImage; Image genderImage; Image conditionImage; Image spConditionImage;

		readonly CharacterSheetPresenter _characterSheetPresenter;
		readonly MainPresenter _mainPresenter;
		//*************************************************

        public FrmCharacterSheet(Character character, int option, MainPresenter mainPresenter)
        {
            InitializeComponent();

            _characterSheetPresenter = new CharacterSheetPresenter(this, _mainPresenter, character, option);
			_mainPresenter = mainPresenter;

            if (option == 0) // IF THE FORM IS ONLY TO VIEW A CHAR, I DISABLE THE EDIT.
            {
                DisableAll();
                grpBox_Edit.Visible = false;
                btn_Accept.Enabled = false;
                btn_Cancel.Enabled = false;
                btn_Undo.Enabled = false;
            }
            else if (option == 1) // IF FOR NEW CHAR
            {
                lbl_Characer.Text = "New Character Sheet";
                this.Text = "New Character Sheet";
                EnableAll();
            }
            else
            {
                EnableAll();
                this.Text = "Character Sheet";
            }

            this.option = option;
            lbl_FamilyNode.Text = "";
        }

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public int Option
		{
			get { return option; }
			set { option = value;  }
		}

		public Character CharacterEventArgs
		{
			get { return characterEventArgs; }
			set { characterEventArgs = value;  }
		}

		public string AuxString
		{
			get { return auxString; }
			set { auxString = value; }
		}

        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------

        void Btn_CancelClick(object sender, EventArgs e) // IF CHANGES ARE REJECTED, THE FAKE CHAR IS FILLED AGAIN WITH THE ORIGINAL VALUES.
		{
			edited = 0;
			this.Close();
		}

		//--------------------------------------------

		private void Btn_Undo_Click(object sender, EventArgs e)
		{
			Undo.Invoke(this, EventArgs.Empty);
			LoadCharacter();
			//DisableAll();
			FillBars();
			if (option != 1)
			{
				edited = 0;
			}
		}

		//--------------------------------------------

		private void Btn_Accept_Click(object sender, EventArgs e)
		{
			edited = 2;		
			ConfirmEdit(characterEventArgs); // IF THE CHANGES ARE ACCEPTED, THE NEW VALUES ARE SET ON THE FAKE CHAR.

			EditCharData.Invoke(this, characterEventArgs);

			MessageBox.Show("Changes saved.");
			this.Close();
		}

		//--------------------------------------------

		private void btn_AddFamilyTie_Click(object sender, EventArgs e)
		{
			try
			{
				if (tv_Family.SelectedNode.Level == 1 && cmbBox_Characters.SelectedItem != null)
				{
					AddFamilyTie(this, (Character)cmbBox_Characters.SelectedItem);

					TreeNode newNode = new TreeNode(); // I CREATE A NEW TREE NODE.

                    newNode.Text = characterEventArgs.ToString(); // SET THE NODE'S TEXT AS THE CHAR IT REPRESENTS
                    newNode.Name = characterEventArgs.ID.ToString(); // AND THE ID IS THE CHAR'S ID.

                    tv_Family.SelectedNode.Nodes.Add(newNode); // ADD THE NODE TO THE TREE
					tv_Family.SelectedNode.ExpandAll(); // AND EXPAND.

					PopulateCharsCmbBox(); // REPOPULATE THE COMBOBOX FROM WHICH I CAN PICK A DIFFERENT CHAR.
					InitializedConditional();
				}
			}
			catch
			{

			}
		}

		//--------------------------------------------

		private void btn_RmvFamilyTie_Click(object sender, EventArgs e)
		{
			try
			{
				if (tv_Family.SelectedNode.Level == 2) // SELECTED NODE
				{
					// HERE I USED TO REMOVE NODES ON THE CHARS THOSE NODES POINTED TO DIRECTLY. THIS CHANGED WHEN I IMPLEMENTED THE POV OF USING A FAKE
					// CHAR INSTEAD OF WORKING DIRECTLY WITH THE ORIGINAL ONE.

					RemoveFamilyTie.Invoke(this, Convert.ToInt32(tv_Family.SelectedNode.Name));

					tv_Family.SelectedNode.Remove(); // I FINALLY REMOVE THE NODE FROM THE TREEVIEW.
					PopulateCharsCmbBox(); // AND REPOPULATE THE COMBO BOX.
					InitializedConditional();
				}

			}
			catch
			{

			}
		}

		//--------------------------------------------

		/// <summary>
		/// THERE'S NOT MUCH TO SAY ABOUT THIS METHOD. IT OPENS A NEW CHARACTER SHEET IN VIEW-ONLY MODE TO VIEW THE CHAR THE NODE
		/// REPRESENTS.
		/// </summary>
		private void tv_Family_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			foreach (Character aCharacter in Lists.Characters)
			{
				if (aCharacter.ID == Convert.ToInt32(e.Node.Name))
				{
					FrmCharacterSheet viewThisChar = new FrmCharacterSheet(aCharacter, 0, _mainPresenter);
					viewThisChar.Show();
					break;
				}
			}
		}

		//--------------------------------------------

		/// <summary>
		/// FORM LOAD. HERE I LOAD THE CHARACTER AND POPULATE ALL THE MAIN COMBOBOXES.
		/// FINALLY I DRAW THE BARS AND TREEVIEW.
		/// </summary>
		void FrmViewCharLoad(object sender, EventArgs e)
		{
			LoadCharacter();

			foreach (var value in Enum.GetValues(typeof(Race)))
			{
				cmbBox_Race.Items.Add(value.ToString());
			}
			cmbBox_Race.Text = character.Race.ToString();

			foreach (var value in Enum.GetValues(typeof(Gender)))
			{
				cmbBox_Gender.Items.Add(value.ToString());
			}
			cmbBox_Gender.Text = character.Gender.ToString();

			foreach (var value in Enum.GetValues(typeof(Condition)))
			{
				cmbBox_Condition.Items.Add(value.ToString());
			}
			cmbBox_Condition.Text = character.Condition.ToString();

			foreach (var value in Enum.GetValues(typeof(SpecialCondition)))
			{
				cmbBox_SpCondition.Items.Add(value.ToString());
			}
			cmbBox_SpCondition.Text = character.SpecialCondition.ToString();

			cmbBox_IsAlive.Items.Add("Yes");
			cmbBox_IsAlive.Items.Add("No");
			cmbBox_IsAlive.Text = character.IsAliveStr;


			FillBars();
			DrawTreeView();
			initialized = 1; // THIS IS IMPORTANT FOR THE CASE OF GOLEMS.			
		}

		//--------------------------------------------

		void FrmViewCharFormClosing(object sender, FormClosingEventArgs e)
		{
			OnCloseCheck();
		}

		//--------------------------------------------

		private void OnCloseCheck()
		{
			// EDITED = 0: NO CHANGES WERE PERFORMED.
			// EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED.
			// EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.

			if (edited == 1 || option == 1) // IF THE CHARACTER IS EITHER EDITED BUT NOT CONFIRMED OR THE CHARACTER IS NEW
			{
				string warningText = "";

				if (option == 1 && edited == 1) // IF THE CHARACTER IS NEW AND UNCONFIRMED
				{
					warningText = "Do you want to apply the current changes?\n\n" +
						"If you click 'NO' the character is going to be discarded.";

				}
				else if (edited == 1) // IF THE CHANGES ARE UNCONFIRMED
				{
					warningText = "Do you want to apply the current changes?";

				}
				else if (option == 1 && edited == 2) // IN THE SPECIFIC CASE OF A NEW CHAR WITH CONFIRMED CHANGES
				{
					SaveCharData();
					this.DialogResult = DialogResult.OK;
					return; // I ESCAPE THE METHOD
				}
				else if (edited == 0)
				{
					this.DialogResult = DialogResult.Cancel;
					return;
				}

				DialogResult warning = MessageBox.Show(warningText, "Warning", MessageBoxButtons.YesNo);

				if (warning == DialogResult.Yes)
				{
					SaveCharData();
					this.DialogResult = DialogResult.OK;

				}
				else
				{
					this.DialogResult = DialogResult.Cancel;
				}
			}
			else if (edited == 2) // IF CHANGES ARE CONFIRMED
			{
				SaveCharData();
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				this.DialogResult = DialogResult.Cancel;
			}
		}

		//--------------------------------------------

		private void ConfirmEdit(Character characterEventArgs)
		{
			characterEventArgs.Name = txtBox_Name.Text;
            characterEventArgs.Age = Convert.ToInt32(nud_Age.Value);
			nud_Age.Visible = false;
            characterEventArgs.Race = (Race)Enum.Parse(typeof(Race), cmbBox_Race.Text);
            characterEventArgs.Gender = (Gender)Enum.Parse(typeof(Gender), cmbBox_Gender.Text);
            characterEventArgs.Condition = (Condition)Enum.Parse(typeof(Condition), cmbBox_Condition.Text);
            characterEventArgs.SpecialCondition = (SpecialCondition)Enum.Parse(typeof(SpecialCondition), cmbBox_SpCondition.Text);
            characterEventArgs.Description = rchTxtBox_Description.Rtf;

			if (cmbBox_IsAlive.Text == "Yes")
			{
                characterEventArgs.IsAlive = true;
			}
			else
			{
                characterEventArgs.IsAlive = false;
			}

            characterEventArgs.Strength = Convert.ToInt32(nud_Strength.Value);
            characterEventArgs.Melee = Convert.ToInt32(nud_Melee.Value);
            characterEventArgs.Mining = Convert.ToInt32(nud_Mining.Value);
            characterEventArgs.Harvesting = Convert.ToInt32(nud_Harvesting.Value);
            characterEventArgs.Smithing = Convert.ToInt32(nud_Smithing.Value);

            characterEventArgs.Dexterity = Convert.ToInt32(nud_Dexterity.Value);
            characterEventArgs.Marksman = Convert.ToInt32(nud_Marksman.Value);
            characterEventArgs.Ranching = Convert.ToInt32(nud_Ranching.Value);
            characterEventArgs.Tailoring = Convert.ToInt32(nud_Tailoring.Value);
            characterEventArgs.Cooking = Convert.ToInt32(nud_Cooking.Value);

            characterEventArgs.Knowledge = Convert.ToInt32(nud_Knowledge.Value);
            characterEventArgs.Alchemy = Convert.ToInt32(nud_Alchemy.Value);
            characterEventArgs.Engineering = Convert.ToInt32(nud_Engineering.Value);
            characterEventArgs.Guile = Convert.ToInt32(nud_Guile.Value);
            characterEventArgs.Manufacturing = Convert.ToInt32(nud_Manufacturing.Value);

			//DisableAll();

		}

		//--------------------------------------------

		private void SaveCharData()
		{
			// HERE ALL THE CHANGES ARE PASSED TO THE ORIGINAL CHARACTER, WHICH IS LATER RETRIEVED.
			// THIS IS DUE ALL THE OPERATION IS CONFIRMED TO BE APPLIED. OTHERWISE NOTHING OF THIS HAPPENS.
			
			//ConfirmEdit();
			Utilities.AssignFakeValuesToOriginal(fakeCharacter, character);

			Utilities.SyncFamilyTies(fakeCharacter, character);
		}

		//-----------------------------------------------------
		//------------------ [ TEXT FORMAT ]
		//-----------------------------------------------------

		void Btn_BoldClick(object sender, EventArgs e)
		{
			BoldText();
		}

		//--------------------------------------------

		private void BoldText()
		{
			Font new1, old1;
			old1 = rchTxtBox_Description.SelectionFont;
			if (old1.Bold)
			{
				new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
			}
			else
			{
				new1 = new Font(old1, old1.Style | FontStyle.Bold);
			}

			rchTxtBox_Description.SelectionFont = new1;
			rchTxtBox_Description.Focus();
		}

		//--------------------------------------------

		void Btn_ItalicClick(object sender, EventArgs e)
		{
			ItalicText();
		}

		//--------------------------------------------

		private void ItalicText()
		{
			Font new1, old1;
			old1 = rchTxtBox_Description.SelectionFont;
			if (old1.Italic)
			{
				new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
			}
			else
			{
				new1 = new Font(old1, old1.Style | FontStyle.Italic);
			}

			rchTxtBox_Description.SelectionFont = new1;
			rchTxtBox_Description.Focus();
		}

		//--------------------------------------------

		void Btn_UnderlineClick(object sender, EventArgs e)
		{
			UnderlineText();
		}

		//--------------------------------------------

		private void UnderlineText()
		{
			Font new1, old1;
			old1 = rchTxtBox_Description.SelectionFont;
			if (old1.Underline)
			{
				new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
			}
			else
			{
				new1 = new Font(old1, old1.Style | FontStyle.Underline);
			}

			rchTxtBox_Description.SelectionFont = new1;
			rchTxtBox_Description.Focus();
		}

		//-----------------------------------------------------
		//------------------ [ METHODS ]
		//-----------------------------------------------------

		private void DrawTreeView()
		{
			tv_Family.Nodes.Add("Character: " + character.Name);
			tv_Family.Nodes[0].Nodes.Add("Parents");
			tv_Family.Nodes[0].Nodes.Add("Siblings");
			tv_Family.Nodes[0].Nodes.Add("Spouses");
			tv_Family.Nodes[0].Nodes.Add("Children");

			tv_Family.Nodes[0].ExpandAll();
			PopulateCharsCmbBox();

			PopulateTree();
		}

		//--------------------------------------------
		private void PopulateTree()
		{
			// OK, I NEED TO DOCUMENT THIS 'CUZ I'M STARTING TO LOSE THE FOCUS.

			foreach (FamilyTieNode tieNode in character.Family) // I CHECK THE FAMILY OF THE CHAR...
			{
				foreach (Character aCharacter in Lists.Characters) // ... AGAINST THE LIST OF CHARS...
				{
					if (aCharacter.ID == tieNode.Id) // WHENEVER I FIND THE CHAR...
					{
						foreach (TreeNode node in tv_Family.Nodes[0].Nodes) // I CHECK THE NODES...
						{
							if (node.Text == tieNode.Tie) // ... AND WHEN I FIND THE CORRECT TYPE OF FAMILY TIE...
							{
								TreeNode newNode = new TreeNode();

								newNode.Text = aCharacter.ToString();
								newNode.Name = aCharacter.ID.ToString();

								node.Nodes.Add(newNode); // ... I ADD THE CHAR TO IT.
							}
						}
					}
				}
			}
			tv_Family.ExpandAll();
		}

		//--------------------------------------------

		private void PopulateCharsCmbBox()
		{
			cmbBox_Characters.Items.Clear();

			foreach (Character aCharacter in _mainPresenter.Characters)
			{
				if (aCharacter.ID != _characterSheetPresenter.Character.ID)
				{
					if (_characterSheetPresenter.FakeCharacter.Family.Count > 0)
					{
						bool addChar = true;

						foreach (FamilyTieNode familyTie in _characterSheetPresenter.FakeCharacter.Family)
						{
							if (aCharacter.ID == familyTie.Id)
							{
								addChar = false;
							}
						}

						if (addChar == true)
						{
							cmbBox_Characters.Items.Add(aCharacter);
						}

					}
					else
					{
						cmbBox_Characters.Items.Add(aCharacter);
					}
				}
			}
		}

		//--------------------------------------------

		private void LoadCharacter()
		{
			Bitmap charPicture = PictureSerializer.TurnStringToImage(fakeCharacter.CharPicture);

			if (charPicture != null)
			{
				pictureBox1.BackgroundImage = charPicture;
				pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			}
			else
			{
				pictureBox1.BackgroundImage = null;
			}

			txtBox_Name.Text = fakeCharacter.Name;
			rchTxtBox_Description.Rtf = fakeCharacter.Description;
			txtBox_Age.Text = fakeCharacter.Age.ToString();
			nud_Age.Value = fakeCharacter.Age;
			if (fakeCharacter.Birthday == null || fakeCharacter.Birthday.Year == null || fakeCharacter.Birthday.Day == null || fakeCharacter.Birthday.Hour == null)
			{
				txtBox_Birthday.Text = "-- / -- / --";
				if (fakeCharacter.Birthday == null)
				{
					Date newBirthday = new Date("--", "--", "--");
					fakeCharacter.Birthday = newBirthday;
				}
			}
			else
			{
				txtBox_Birthday.Text = fakeCharacter.Birthday.ToString();
			}
			if (fakeCharacter.Deathday == null || fakeCharacter.Deathday.Year == null || fakeCharacter.Deathday.Day == null || fakeCharacter.Deathday.Hour == null)
			{
				txtBox_Deathday.Text = "-- / -- / --";
				if (fakeCharacter.Deathday == null)
				{
					Date newDeathday = new Date("--", "--", "--"); // NOTE TO MYSELF: REWRITE THIS!! - 10/30/22 NAH, IT'S FINE.
					fakeCharacter.Deathday = newDeathday;
				}
			}
			else
			{
				txtBox_Deathday.Text = fakeCharacter.Deathday.ToString();
			}
			cmbBox_Race.Text = fakeCharacter.Race.ToString();
			cmbBox_Gender.Text = fakeCharacter.Gender.ToString();
			cmbBox_Condition.Text = fakeCharacter.Condition.ToString();
			cmbBox_SpCondition.Text = fakeCharacter.SpecialCondition.ToString();

			Utilities.RaceImagePicker(fakeCharacter.Race.ToString(), picBox_Race, raceImage);
		}

		//--------------------------------------------

		private void FillBars()
		{
			Utilities.ProgressBarFiller(pBar_Strength, "Strength", fakeCharacter.Strength);
			Utilities.ProgressBarFiller(pBar_Melee, "Melee", fakeCharacter.Melee);
			Utilities.ProgressBarFiller(pBar_Mining, "Mining", fakeCharacter.Mining);
			Utilities.ProgressBarFiller(pBar_Harvesting, "Harvesting", fakeCharacter.Harvesting);
			Utilities.ProgressBarFiller(pBar_Smithing, "Smithing", fakeCharacter.Smithing);
			nud_Strength.Value = fakeCharacter.Strength;
			nud_Melee.Value = fakeCharacter.Melee;
			nud_Mining.Value = fakeCharacter.Mining;
			nud_Harvesting.Value = fakeCharacter.Harvesting;
			nud_Smithing.Value = fakeCharacter.Smithing;

			Utilities.ProgressBarFiller(pBar_Dexterity, "Dexterity", fakeCharacter.Dexterity);
			Utilities.ProgressBarFiller(pBar_Marksman, "Marksman", fakeCharacter.Marksman);
			Utilities.ProgressBarFiller(pBar_Ranching, "Ranching", fakeCharacter.Ranching);
			Utilities.ProgressBarFiller(pBar_Tailoring, "Tailoring", fakeCharacter.Tailoring);
			Utilities.ProgressBarFiller(pBar_Cooking, "Cooking", fakeCharacter.Cooking);
			nud_Dexterity.Value = fakeCharacter.Dexterity;
			nud_Marksman.Value = fakeCharacter.Marksman;
			nud_Ranching.Value = fakeCharacter.Ranching;
			nud_Tailoring.Value = fakeCharacter.Tailoring;
			nud_Cooking.Value = fakeCharacter.Cooking;

			Utilities.ProgressBarFiller(pBar_Knowledge, "Knowledge", fakeCharacter.Knowledge);
			Utilities.ProgressBarFiller(pBar_Alchemy, "Alchemy", fakeCharacter.Alchemy);
			Utilities.ProgressBarFiller(pBar_Engineering, "Engineering", fakeCharacter.Engineering);
			Utilities.ProgressBarFiller(pBar_Guile, "Guile", fakeCharacter.Guile);
			Utilities.ProgressBarFiller(pBar_Manufacturing, "Manufacturing", fakeCharacter.Manufacturing);
			nud_Knowledge.Value = fakeCharacter.Knowledge;
			nud_Alchemy.Value = fakeCharacter.Alchemy;
			nud_Engineering.Value = fakeCharacter.Engineering;
			nud_Guile.Value = fakeCharacter.Guile;
			nud_Manufacturing.Value = fakeCharacter.Manufacturing;
		}

		//--------------------------------------------

		private void DisableAll()
		{
			nud_Age.Visible = false;

			txtBox_Name.Enabled = false;
			rchTxtBox_Description.Enabled = false;

			cmbBox_Race.Enabled = false;
			cmbBox_Gender.Enabled = false;
			cmbBox_Condition.Enabled = false;
			cmbBox_SpCondition.Enabled = false;
			cmbBox_IsAlive.Enabled = false;

			//---------- TEXT BUTTONS
			btn_Bold.Enabled = false;
			btn_Italic.Enabled = false;
			btn_Underline.Enabled = false;

			//---------- NUDS
			nud_Age.Enabled = false;
			nud_Strength.Enabled = false;
			nud_Melee.Enabled = false;
			nud_Mining.Enabled = false;
			nud_Harvesting.Enabled = false;
			nud_Smithing.Enabled = false;

			nud_Dexterity.Enabled = false;
			nud_Marksman.Enabled = false;
			nud_Ranching.Enabled = false;
			nud_Tailoring.Enabled = false;
			nud_Cooking.Enabled = false;

			nud_Knowledge.Enabled = false;
			nud_Alchemy.Enabled = false;
			nud_Engineering.Enabled = false;
			nud_Guile.Enabled = false;
			nud_Manufacturing.Enabled = false;

			cmbBox_Characters.Enabled = false;
			btn_AddFamilyTie.Enabled = false;
			btn_RmvFamilyTie.Enabled = false;
		}

		//--------------------------------------------

		private void EnableAll()
		{
			txtBox_Name.Enabled = true;
			nud_Age.Enabled = true; nud_Age.Visible = true;
			cmbBox_Race.Enabled = true;
			cmbBox_Gender.Enabled = true;
			cmbBox_Condition.Enabled = true;
			cmbBox_SpCondition.Enabled = true;
			rchTxtBox_Description.Enabled = true;
			cmbBox_IsAlive.Enabled = true;
			btn_Bold.Enabled = true;
			btn_Italic.Enabled = true;
			btn_Underline.Enabled = true;

			nud_Strength.Enabled = true;
			nud_Melee.Enabled = true;
			nud_Mining.Enabled = true;
			nud_Harvesting.Enabled = true;
			nud_Smithing.Enabled = true;

			nud_Dexterity.Enabled = true;
			nud_Marksman.Enabled = true;
			nud_Ranching.Enabled = true;
			nud_Tailoring.Enabled = true;
			nud_Cooking.Enabled = true;

			nud_Knowledge.Enabled = true;
			nud_Alchemy.Enabled = true;
			nud_Engineering.Enabled = true;
			nud_Guile.Enabled = true;
			nud_Manufacturing.Enabled = true;

			cmbBox_Characters.Enabled = true;
			btn_AddFamilyTie.Enabled = true;
			btn_RmvFamilyTie.Enabled = true;
		}

		//-----------------------------------------------------
		//------------------ [ NUDS ]
		//-----------------------------------------------------

		private void nud_Age_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			txtBox_Age.Text = nud_Age.Value.ToString();
		}

		//--------------------------------------------

		void Nud_StrengthValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Strength, "Strength", Convert.ToInt32(nud_Strength.Value));
		}
		void Nud_MeleeValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Melee, "Melee", Convert.ToInt32(nud_Melee.Value));
		}
		void Nud_MiningValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Mining, "Mining", Convert.ToInt32(nud_Mining.Value));
		}
		void Nud_HarvestingValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Harvesting, "Harvesting", Convert.ToInt32(nud_Harvesting.Value));
		}
		void Nud_SmithingValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Smithing, "Smithing", Convert.ToInt32(nud_Smithing.Value));
		}
		void Nud_DexterityValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Dexterity, "Dexterity", Convert.ToInt32(nud_Dexterity.Value));
		}
		void Nud_MarksmanValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Marksman, "Marksman", Convert.ToInt32(nud_Marksman.Value));
		}
		void Nud_RanchingValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Ranching, "Ranching", Convert.ToInt32(nud_Ranching.Value));
		}
		void Nud_TailoringValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Tailoring, "Tailoring", Convert.ToInt32(nud_Tailoring.Value));
		}
		void Nud_CookingValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Cooking, "Cooking", Convert.ToInt32(nud_Cooking.Value));
		}

		private void nud_Knowledge_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Knowledge, "Knowledge", Convert.ToInt32(nud_Knowledge.Value));
		}

		private void nud_Alchemy_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Alchemy, "Alchemy", Convert.ToInt32(nud_Alchemy.Value));
		}

		private void nud_Engineering_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Engineering, "Engineering", Convert.ToInt32(nud_Engineering.Value));
		}

		private void nud_Guile_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Guile, "Guile", Convert.ToInt32(nud_Guile.Value));
		}

		private void nud_Manufacturing_ValueChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ProgressBarFiller(pBar_Manufacturing, "Manufacturing", Convert.ToInt32(nud_Manufacturing.Value));
		}

		//--------------------------------------------
		private void tv_Family_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
		{
			if (e.Node.Level == 2)
			{
				toolTip1.Show("Double-click the node to see the char!", this, PointToClient(MousePosition), 3000);
			}
		}

		//--------------------------------------------

		/// <summary>
		/// A PARTICULAR EVENT. GOLEMS CAN ONLY BE NORMAL, SO IF THE RACE IS GOLEM THE CONDITION HAS TO BE DISABLED.
		/// ELSE, IT HAS TO BE ENABLED. THIS CHECK MUST ONLY HAPPEN AFTER THE INITIALIZATION.
		/// </summary>
		private void cmbBox_Race_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitializedConditional();

			if (cmbBox_Race.Text == "Golem")
			{
				if (initialized == 1)
				{
					cmbBox_Condition.Enabled = false;

				}
				cmbBox_Condition.Text = "Normal";
			}
			else
			{
				if (initialized == 1)
				{
					cmbBox_Condition.Enabled = true;
				}
			}

			Utilities.RaceImagePicker(cmbBox_Race.Text, picBox_Race, raceImage);
		}

		//--------------------------------------------

		private void cmbBox_Gender_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.GenderImagePicker(cmbBox_Gender.Text, picBox_Gender, genderImage);
		}

		private void cmbBox_Condition_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.ConditionImagePicker(cmbBox_Condition.Text, picBox_Condition, conditionImage);
		}

		private void cmbBox_SpCondition_SelectedIndexChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			Utilities.SpConditionImagePicker(cmbBox_SpCondition.Text, picBox_SpCondition, spConditionImage);
		}

		private void tv_Family_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Level == 1)
			{
				lbl_FamilyNode.Text = e.Node.Text;
			}
			else
			{
				lbl_FamilyNode.Text = "";
			}
		}

		private void txtBox_Name_TextChanged(object sender, EventArgs e)
		{
			if (initialized == 1)
			{
				edited = 1;
			}
		}

		private void InitializedConditional()
		{
			if (initialized == 1)
			{
				edited = 1;
			}
		}

		private void rchTxtBox_Description_TextChanged(object sender, EventArgs e)
		{
			InitializedConditional();
		}
		void CmbBox_IsAliveSelectedIndexChanged(object sender, EventArgs e)
		{
			InitializedConditional();
			if (cmbBox_IsAlive.Text == "Yes")
			{
				grpBox_DeathDay.Enabled = false;
				fakeCharacter.Deathday.Year = "--";
				fakeCharacter.Deathday.Day = "--";
				fakeCharacter.Deathday.Hour = "--";
				txtBox_Deathday.Text = fakeCharacter.Deathday.ToString();

			}
			else
			{
				grpBox_DeathDay.Enabled = true;
				txtBox_Deathday.Text = fakeCharacter.Deathday.ToString();
			}
		}
		void Btn_EditBirthdayClick(object sender, EventArgs e)
		{
			InitializedConditional();
			FrmDateSetter dateSetting = new FrmDateSetter(fakeCharacter.Birthday);
			if (dateSetting.ShowDialog() == DialogResult.OK)
			{
				fakeCharacter.Birthday = dateSetting.GetDate;
			}
			txtBox_Birthday.Text = fakeCharacter.Birthday.ToString();
		}
		void Btn_EditDeathdayClick(object sender, EventArgs e)
		{
			InitializedConditional();
			FrmDateSetter dateSetting = new FrmDateSetter(fakeCharacter.Deathday);
			if (dateSetting.ShowDialog() == DialogResult.OK)
			{
				fakeCharacter.Deathday = dateSetting.GetDate;
			}
			txtBox_Deathday.Text = fakeCharacter.Deathday.ToString();
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
				return createParams;
			}
		}

		private void btn_LoadPictore_Click(object sender, EventArgs e)
		{
			fakeCharacter.CharPicture = PictureSerializer.UploadImageAsString();

			Bitmap newImage = PictureSerializer.TurnStringToImage(fakeCharacter.CharPicture);

			if (newImage != null)
			{
				pictureBox1.BackgroundImage = newImage;
				pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			}
			else
			{
				pictureBox1.BackgroundImage = null;
			}	
		}

		private void btn_DiscardPicture_Click(object sender, EventArgs e)
		{
			fakeCharacter.CharPicture = "";

			pictureBox1.BackgroundImage = null;
		}

		//-----------------------------------------------------
		//------------------ [ EVENTS ]
		//-----------------------------------------------------

		public event EventHandler Undo;
		public event EventHandler<Character> EditCharData;
		public event EventHandler<Character> AddFamilyTie;
		public event EventHandler<int> RemoveFamilyTie;

        void FrmViewCharKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                BoldText();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
            {
                ItalicText(); // THIS PARTICULAR ONE DOESN'T SEEM TO WORK WELL ...
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                UnderlineText();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Model;
using Presenter;
using System.Threading;
using System.Runtime.Serialization;

namespace Views
{
	public partial class FrmCharactersMain : Form, IMainView, ICharacters
    {

        //*************************************************
        MainForm main;
		readonly MainPresenter presenter;
		readonly CharactersPresenter charPresenter;

        //*************************************************

        public FrmCharactersMain(MainForm mainform)

        {
            InitializeComponent();
            main = mainform;       
			
            charPresenter = new CharactersPresenter(this);
			presenter = new MainPresenter(this);
			RetrieveData.Invoke(this, EventArgs.Empty);
            //DrawDataTable(0);
        }

        //-----------------------------------------------------
		//------------------ [ PROPERTIES ]
		//-----------------------------------------------------
		
		public MainForm Main
		{
			get { return main; }			
		}
		
		public string Lbl_Characters
		{
			set { lbl_CharactersCount.Text = value; }
		}
		
		public string Lbl_MaroDate
		{			
			set { lbl_MaroDate.Text = value; }
		}
        
        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------
        
        private void btn_Characters_Click(object sender, EventArgs e)
        {
//            Character newCharacter = new Character(1);
//            newCharacter.ID = Lists.ID + 1; // <<--- THIS IS IMPORTANT. THE NEW CHAR NEEDS A PROVISORY ID IF I WANT TO BE ABLE TO ADD
//            // FAMILY TIES TO IT.
//
//            FrmCharacterSheet addCharacter = new FrmCharacterSheet(newCharacter, 0, 1);            
//            if(addCharacter.ShowDialog() == DialogResult.OK)
//            {
//                Character aNewCharacter = addCharacter.Character;
//                
//                Lists.ID++; // IF THE NEW CHAR IS CONFIRMED THEN I ADD 1 TO THE ID.
//                Lists.Characters.Add(aNewCharacter);
//
//                DrawDataTable(1);
//                UpdateInfo();
//            }        	
        }     
                
        //------------------
        
		void Btn_SaveClick(object sender, EventArgs e)
		{
			SaveFile.Invoke(this, EventArgs.Empty);
			MessageBox.Show("The current list has been saved.");			
		}
		
		//------------------
		
		void Btn_ClearListClick(object sender, EventArgs e)
		{			
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the list of characters?\n\n" +
			                                            "All characters are gonna be erased and this cannot be undone.", "Clear Characters List", MessageBoxButtons.YesNo);
			
			if(dialogResult == DialogResult.Yes)
			{
				Clear.Invoke(this, EventArgs.Empty);
				DrawDataTable(1);
				//UpdateInfo();
            }
		}
		
		//------------------
		
		void Btn_LoadClick(object sender, EventArgs e)
		{
            if (File.Exists("Characters.json"))
            {
                if(main.Presenter.Characters != null && main.Presenter.Characters.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to load a list of characters?\n\n" +
                    "All the current characters are gonna be erased and this cannot be undone.", "Load Characters List", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    	LoadFile.Invoke(this, EventArgs.Empty);
                    	DrawDataTable(0);
                    }
                }
                else
                {
                	LoadFile.Invoke(this, EventArgs.Empty);
					DrawDataTable(0);                	
                }
            }
            else
            {
                MessageBox.Show("There's no file to load.");
            }
        }

        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------


        //------------------

        private void FrmCharactersMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        	main.Show();
        }
        
        //------------------

        private void FrmCharactersMain_Load(object sender, EventArgs e)
        {
//            UpdateInfo();
        }
        
        //------------------

		private void DrawDataTable(int opt)
        {			
            DataGridViewButtonColumn removeChar = new DataGridViewButtonColumn()
            {
                Name = "DGV_RemoveChar",
                Text = "Delete",
                HeaderText = "Delete",
                UseColumnTextForButtonValue = true
            };
            
            DataGridViewButtonColumn viewChar = new DataGridViewButtonColumn()
            {
            	Name = "DGV_ViewChar",
            	Text = "View",
            	HeaderText = "View",
            	UseColumnTextForButtonValue = true
            	
            };

            if (opt == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                charPresenter.CharsDT.Rows.Clear();
            }

            charPresenter.CharsDT = new DataTable();
            charPresenter.CharsDTDV = charPresenter.CharsDT.DefaultView;

            charPresenter.CharsDT.Columns.Add("ID", typeof(int));
            charPresenter.CharsDT.Columns.Add("Name", typeof(string));
            charPresenter.CharsDT.Columns.Add("Age", typeof(int));
            charPresenter.CharsDT.Columns.Add("Gender", typeof(string));
            charPresenter.CharsDT.Columns.Add("Race", typeof(string));
            charPresenter.CharsDT.Columns.Add("Condition", typeof(string));
            charPresenter.CharsDT.Columns.Add("Special Condition", typeof(string));
            charPresenter.CharsDT.Columns.Add("Is Alive?", typeof(string));

            foreach (Character aCharacter in main.Presenter.Characters)
            {
                charPresenter.CharsDT.Rows.Add(aCharacter.ID,aCharacter.Name,aCharacter.Age,aCharacter.Gender,aCharacter.Race,
            	                 aCharacter.Condition,aCharacter.SpecialCondition,aCharacter.IsAliveStr);
            }

            dataGridView1.DataSource = charPresenter.CharsDT;
            dataGridView1.Columns.Add(removeChar);
            dataGridView1.Columns.Add(viewChar);
        }
		
		//------------------
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			if (dataGridView1.Columns[e.ColumnIndex].Name == "DGV_RemoveChar")
//			{
//				FrmRemoveCharacter removeCharacter = new FrmRemoveCharacter();
//				if(removeCharacter.ShowDialog() == DialogResult.OK)
//				{
//					int index = dataGridView1.CurrentRow.Index;
//
//                    SyncCharsAtRemoval(Lists.Characters[dataGridView1.CurrentRow.Index]);
//                    // THIS MAY LOOK TRIVIAL, BUT IT'S VERY IMPORTANT SINCE IT'S AN UPDATE. - NOT ALL CHANGES ARE PERFORMED AT THE CHAR SHEET
//                    // AND THIS IS ONE OF THOSE.
//
//					Lists.Characters.RemoveAt(index);		
//					DrawDataTable(1);
//                    UpdateInfo();
//                }        		
//        	}
//			
//			if(dataGridView1.Columns[e.ColumnIndex].Name == "DGV_ViewChar")
//			{
//				FrmCharacterSheet viewChar = new FrmCharacterSheet(Lists.Characters[dataGridView1.CurrentRow.Index], 0, 0);				
//				if(viewChar.ShowDialog() == DialogResult.OK)
//				{
//					Lists.Characters[dataGridView1.CurrentRow.Index] = viewChar.Character;
//					DrawDataTable(1);
//				}
//				else
//				{
//					DrawDataTable(1);
//				}
//			}	        	
		}
		
		//------------------

        private void SyncCharsAtRemoval(Character charToRemove)
        {
//            foreach(Character character in Lists.Characters)
//            {
//                foreach(FamilyTieNode familyTieNode in character.Family)
//                {
//                    if(familyTieNode.Id == charToRemove.ID)
//                    {
//                        character.Family.Remove(familyTieNode);
//                        break;
//                    }
//                }
//            }
        }

        //------------------
        
        private void UpdateInfo()
        {            
//			lbl_CharactersCount.Text = Lists.Characters.Count.ToString();
//
//            if(Lists.Characters.Count > 0)
//            {
//            	//btn_ClearList.ForeColor = Color.Black;
//            	btn_ClearList.Enabled = true;
//            	
//            	//btn_CalcAgeAll.ForeColor = Color.Black;
//            	btn_CalcAgeAll.Enabled = true;
//            }
//            else
//            {
//            	//btn_ClearList.ForeColor = Color.Gray;
//            	btn_ClearList.Enabled = false;
//            	
//            	//btn_CalcAgeAll.ForeColor = Color.Gray;
//            	btn_CalcAgeAll.Enabled = false;
//            }
//			/*if(loaded!=0){
//				lbl_LoadedValue.Text = "Yes";
//			}
//			else{
//				lbl_LoadedValue.Text = "No";
//			}*/
		}

		void Btn_CalcAgeAllClick(object sender, EventArgs e)
		{
//			Action<string> message = (string text) => MessageBox.Show(text);
//			//DELEGATE. USED TO PASS A LAMBDA METHOD.
//			
//			Utilities.CalcCharsAge(message);
//			DrawDataTable(1);
		}
		
		//-----------------------------------------------------
		//------------------ [ EVENTS ]
		//-----------------------------------------------------	

		public event EventHandler RetrieveData;
		public event EventHandler AddCharacter;
		public event EventHandler LoadFile;
		public event EventHandler SaveFile;
		public event EventHandler Clear;
		
		private void FrmCharactersMain_KeyDown(object sender, KeyEventArgs e)
        {
        	if (e.KeyCode == Keys.Escape)
        	{
        		this.Close();
        	}
        }
    }
}

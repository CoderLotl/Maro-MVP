using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Model;
using Presenter;

namespace Views
{
	public partial class FrmCharactersMain : Form, ICharactersView
    {

        //*************************************************

        MainForm main;
		readonly CharactersPresenter _charPresenter;
        readonly ICharactersService _charactersService;
        readonly IVariables _variables;

        //*************************************************

        public FrmCharactersMain(MainForm mainform, ICharactersService charactersService, IVariables variables)

        {
            InitializeComponent();
            main = mainform;
            _charactersService = charactersService;
            _variables = variables;

            _charPresenter = new CharactersPresenter(this, charactersService);
            lbl_MaroDate.Text = main.Lbl_MaroDate;
            DrawDataTable(0);
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
        
        private void btn_AddCharacter_Click(object sender, EventArgs e)
        {
            FrmCharacterSheet frmCharacterSheet = new FrmCharacterSheet(null, 1, _charactersService, _variables);
            if(frmCharacterSheet.ShowDialog() == DialogResult.OK)
            {
                DrawDataTable(1);
                UpdateInfo();
            }
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
				UpdateInfo();
            }
		}
		
		//------------------
		
		void Btn_LoadClick(object sender, EventArgs e)
		{
            if (File.Exists("Characters.json"))
            {
                if(_charactersService.Characters != null && _charactersService.Characters.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to load a list of characters?\n\n" +
                    "All the current characters are gonna be erased and this cannot be undone.", "Load Characters List", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    	LoadFile.Invoke(this, EventArgs.Empty);
                    	DrawDataTable(0);
                        UpdateInfo();
                    }
                }
                else
                {
                	LoadFile.Invoke(this, EventArgs.Empty);
					DrawDataTable(0);
                    UpdateInfo();
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
            UpdateInfo();
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
                _charPresenter.CharsDT.Rows.Clear();
            }

            _charPresenter.CharsDT = new DataTable();
            _charPresenter.CharsDTDV = _charPresenter.CharsDT.DefaultView;

            _charPresenter.CharsDT.Columns.Add("ID", typeof(int));
            _charPresenter.CharsDT.Columns.Add("Name", typeof(string));
            _charPresenter.CharsDT.Columns.Add("Age", typeof(int));
            _charPresenter.CharsDT.Columns.Add("Gender", typeof(string));
            _charPresenter.CharsDT.Columns.Add("Race", typeof(string));
            _charPresenter.CharsDT.Columns.Add("Condition", typeof(string));
            _charPresenter.CharsDT.Columns.Add("Special Condition", typeof(string));
            _charPresenter.CharsDT.Columns.Add("Is Alive?", typeof(string));

            foreach (Character aCharacter in _charactersService.Characters)
            {
                _charPresenter.CharsDT.Rows.Add(aCharacter.ID,aCharacter.Name,aCharacter.Age,aCharacter.Gender,aCharacter.Race,
            	                 aCharacter.Condition,aCharacter.SpecialCondition,aCharacter.IsAliveStr);
            }

            dataGridView1.DataSource = _charPresenter.CharsDT;
            dataGridView1.Columns.Add(removeChar);
            dataGridView1.Columns.Add(viewChar);
        }
		
		//------------------
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGV_RemoveChar")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this character?","Remove character",MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    RemoveCharacter.Invoke(this, dataGridView1.CurrentRow.Index);

                    DrawDataTable(1);
                    UpdateInfo();
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGV_ViewChar")
            {
                FrmCharacterSheet viewChar = new FrmCharacterSheet(_charactersService.Characters[dataGridView1.CurrentRow.Index], 2, _charactersService, _variables);
                if (viewChar.ShowDialog() == DialogResult.OK)
                {
                    _charactersService.Characters[dataGridView1.CurrentRow.Index] = viewChar.PresenterCharacter;
                    DrawDataTable(1);
                }
                else
                {
                    DrawDataTable(1);
                }
            }
        }
		
		//------------------
        
        private void UpdateInfo()
        {
            UpdateAmountOfCharacters.Invoke(this, EventArgs.Empty);

            if (_charactersService.Characters.Count > 0)
            {                
                btn_ClearList.Enabled = true;                                
                btn_CalcAgeAll.Enabled = true;
            }
            else
            {                
                btn_ClearList.Enabled = false;                
                btn_CalcAgeAll.Enabled = false;
            }
            //			/*if(loaded!=0){
            //				lbl_LoadedValue.Text = "Yes";
            //			}
            //			else{
            //				lbl_LoadedValue.Text = "No";
            //			}*/
        }

		void Btn_CalcAgeAllClick(object sender, EventArgs e)
		{
            Action<string> message = (string text) => MessageBox.Show(text);
            //DELEGATE. USED TO PASS A LAMBDA METHOD.
            //			
            CalculateCharsAge(this, message);
            DrawDataTable(1);
        }

        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------	
                
		public event EventHandler AddCharacter;
        public event EventHandler<int> RemoveCharacter;
        public event EventHandler LoadFile;
		public event EventHandler SaveFile;
		public event EventHandler Clear;
        public event EventHandler UpdateAmountOfCharacters;
        public event EventHandler<Action<string>> CalculateCharsAge;

        private void FrmCharactersMain_KeyDown(object sender, KeyEventArgs e)
        {
        	if (e.KeyCode == Keys.Escape)
        	{
        		this.Close();
        	}
        }
    }
}

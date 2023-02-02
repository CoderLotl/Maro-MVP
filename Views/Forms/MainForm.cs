﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace Views
{
    public partial class MainForm : Form, IMainView
    {
        //*************************************************		

        readonly MainPresenter presenter;

        //*************************************************

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            RetrieveData.Invoke(this, EventArgs.Empty);
        }

        //-------------------------------------------------------------------------------------

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public string Lbl_MaroDate
        {
            get { return lbl_MaroDate.Text;  }
            set { lbl_MaroDate.Text = value; }
        }

        //-----------------------------------------------------
        //------------------ [ BUTTONS ]
        //-----------------------------------------------------

        //------------------ [ CHARACTERS ]

        void Btn_CharactersClick(object sender, EventArgs e)
        {
            FrmCharactersMain characters = new FrmCharactersMain(this, presenter.charactersService);
            characters.Show();
            this.Hide();
        }

        //------------------ [ OPTIONS ]

        void Btn_OptionsClick(object sender, EventArgs e)
        {

        }

        //------------------ [ EXIT ]

        void Btn_ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }


        //-----------------------------------------------------
        //------------------ [ EVENTS ]
        //-----------------------------------------------------	

        public event EventHandler RetrieveData;

    }
}

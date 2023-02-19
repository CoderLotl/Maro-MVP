using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace Views
{

	public partial class FrmDateSetter : Form
	{
		TimeUnit date;
		public FrmDateSetter(TimeUnit date)
		{
			InitializeComponent();
			this.date = date;
			
			PopulateComboboxes();

		}
		
		public TimeUnit GetDate
		{
			get{ return date;	}
		}
		
		private void PopulateComboboxes()
		{
			int Year;
			int Day;
			int Hour;
			
			if(int.TryParse(date.Year, out Year) == true)
			{
				nud_Year.Value = Year;
			}
			else
			{
				nud_Year.Value = 0;
			}
			
			cmbBox_Day.Items.Add("--");
			cmbBox_Hour.Items.Add("--");
			
			for (int i = 0; i < 20; i++)
			{
				cmbBox_Day.Items.Add((i+1).ToString());				
			}
			for (int i = 0; i < 12; i++)
			{
				cmbBox_Hour.Items.Add((i+1).ToString());				
			}
			
			if(int.TryParse(date.Day, out Day) == true)
			{
				cmbBox_Day.Text = Day.ToString();
			}
			else
			{
				cmbBox_Day.Text = "--";
			}
			
			if(int.TryParse(date.Hour, out Hour) == true)
			{
				cmbBox_Hour.Text = Hour.ToString();
			}
			else
			{
				cmbBox_Hour.Text = "--";
			}
		}
		
		
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		
		
		
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			date.Year = nud_Year.Value.ToString();
			date.Day = cmbBox_Day.Text;
			date.Hour = cmbBox_Hour.Text;
			
			this.DialogResult = DialogResult.OK;
		}
	}
}

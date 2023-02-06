using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace Views
{
	public partial class FrmTileDetails : Form
	{
		LocationNode originalLocationNode;
		LocationNode fakeLocationNode;
		PictureSerializer pictureSerializer;


        public FrmTileDetails(LocationNode locationNode)
		{
			InitializeComponent();
			
			pictureSerializer = new PictureSerializer();
			this.originalLocationNode= locationNode;
			fakeLocationNode = CreateFakeLocationNode();
			
			pictureBox1.BackgroundImage = pictureSerializer.TurnStringToImage( fakeLocationNode.LocationImage );
			richTextBox1.Text = fakeLocationNode.Description;
			textBox1.Text = fakeLocationNode.LocationName;
			textBox2.Text = fakeLocationNode.LocationType;			
		}


        public LocationNode FakeLocationNode
        {
        	get { return fakeLocationNode; }
        }
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			fakeLocationNode.Description = richTextBox1.Text;
			fakeLocationNode.LocationName = textBox1.Text;
			fakeLocationNode.LocationType = textBox2.Text;

            this.DialogResult = DialogResult.OK;
		}
		
		private LocationNode CreateFakeLocationNode()
		{
			LocationNode fakeLocationNode = new LocationNode();
			
			fakeLocationNode.LocationImage = originalLocationNode.LocationImage;
			fakeLocationNode.Description = originalLocationNode.Description;
			fakeLocationNode.LocationName = originalLocationNode.LocationName;
			fakeLocationNode.LocationType = originalLocationNode.LocationType;
			
			return fakeLocationNode;
		}
	}
}

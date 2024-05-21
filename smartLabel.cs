/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/21/2024
 * Time: 9:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mouseDrawing
{
	/// <summary>
	/// Description of smartLabel.
	/// </summary>
	public partial class smartLabel : UserControl
	{
		public smartLabel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public ListBoxLabels lblx;
		public bool selected = false;
		public int currentInList = -1;
		public void setCurrentInList(int x)
		{
			this.currentInList = x;
		}
		void SmartLabelLoad(object sender, EventArgs e)
		{
			try{
				lblx = (ListBoxLabels)Parent;
			}
			catch{}
		}
		public void setLabelText(string s)
		{
			this.label1.Text = s;
		}
		public void deselecte()
		{
			if(selected==true)
			{
				selected = false;
				this.BackColor = Color.White;
				lblx.setCurrentSelected(0);
			}
		}
		public bool selectdeselectoperation()
		{
			if(selected==true)
			{
				selected = false;
				this.BackColor = Color.White;
				lblx.setCurrentSelected(0);
				return false;
			}
			else{
				selected = true;
				this.BackColor = Color.Red;
				lblx.setCurrentSelected(this.currentInList);
				return true;
			}
			
		}
		void Label1Click(object sender, EventArgs e)
		{
			selectdeselectoperation();
			
		}
	}
}

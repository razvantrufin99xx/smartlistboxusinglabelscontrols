/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/21/2024
 * Time: 9:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace mouseDrawing
{
	/// <summary>
	/// Description of ListBoxLabels.
	/// </summary>
	public partial class ListBoxLabels : UserControl
	{
		public ListBoxLabels()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public int currentSelected = -1;
		public MainForm mf;
		public void setCurrentSelected(int sel)
		{
			currentSelected = sel;
			mf.Text = currentSelected.ToString();
			for(int i = 0 ; i < labels.Count; i++)
			{
				if(labels[i].currentInList!= currentSelected)
				{
				labels[i].deselecte();
				}
			}
			mf.setSelectedItemInList(sel);
			
		}
		public List<smartLabel>labels = new List<smartLabel>();
		public void addLabel(string s)
		{
			this.labels.Add(new smartLabel());
			labels[labels.Count-1].setLabelText(s);
			labels[labels.Count-1].setCurrentInList(labels.Count-1);
			
		}
		public void showLabel(int i )
		{
			this.Controls.Add(this.labels[i]);
			Refresh();
		}
		public void positioningLabel(int i)
		{
			this.Controls[i].Left = 0;
			this.Controls[i].Top = 23 * (1+i);
			this.Controls[i].Width = 200;
		}
		public void setHeight()
		{
			this.Height = labels.Count*23+2;
		}
		public void setWidth()
		{
			this.Width = 202;
			
		}
		public void addNewItem(string s)
		{
			addLabel(s);
			showLabel(labels.Count-1);
			positioningLabel(labels.Count-1);
			setHeight();
		}
		void ListBoxLabelsLoad(object sender, EventArgs e)
		{
			try
			{
				mf = (MainForm)ParentForm;
			}
			catch{}
			
			setHeight();
			setWidth();
		}
	}
}

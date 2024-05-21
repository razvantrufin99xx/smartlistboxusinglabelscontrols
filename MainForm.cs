/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/20/2024
 * Time: 5:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mouseDrawing
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// : Add constructor code after the InitializeComponent() call.
			//
	  }
		public class shape{
			public List<int> pozitii = new List<int>();
			public string tip;
			public shape(int x1, int y1, int x2, int y2,string pt)
			{
				this.pozitii.Add(x1);
				this.pozitii.Add(y1);
				this.pozitii.Add(x2);
				this.pozitii.Add(y2);
				this.tip = pt;
			}
			public void modifyShape(int pc, int x1, int y1, int x2, int y2,string pt, ref TextBox debugtxt)
			{
				this.pozitii[0]=x1;
				this.pozitii[1]=y1;
				this.pozitii[2]=x2;
				this.pozitii[3]=y2;
				this.tip = pt;
				
				string s = pc.ToString() + ";" +pozitii[0].ToString()  + ";" +  pozitii[1].ToString()  + ";" + pozitii[2].ToString()  + ";" + pozitii[3].ToString()  + ";" + this.tip;
				//debugtxt.Text = s ;
					
			}
			
			public void addShapeToList(int pc, ref ListBox l, ref TextBox debugtxt)
			{
				string s = pc.ToString() + ";" +pozitii[0].ToString()  + ";" +  pozitii[1].ToString()  + ";" + pozitii[2].ToString()  + ";" + pozitii[3].ToString()  + ";" + this.tip;
				//debugtxt.Text = s ;
				l.Items.Add(s);
			}
			public void modifyShapeInList(int pc, ref ListBox l, ref TextBox debugtxt)
			{
				/*
				 
				 ASTA DA O EROARE FOARTE MARE
				 OBIECTUL LISTBOX ARE TEXTUL FIX DUPA ADAUGARE EL NU SE MAI POATE MODIFICA
				 DACA INCERCI SA MODIFICI SI MACAR O LITERA APLICATIA SE INCHIDE DAND O EROARE AIUREA
				DE VINA ESTE FUNCTIA DRAWMODE DIN LISTBOX CONTROL
				 */
				//debugtxt.Text = l.Items[pc].ToString() ;
				string s = pc.ToString() + ";" +pozitii[0].ToString()  + ";" +  pozitii[1].ToString()  + ";" + pozitii[2].ToString()  + ";" + pozitii[3].ToString()   + ";" + this.tip;
				//debugtxt.Text = l.Items[pc].ToString() ;
				
				//THIS MAKE A BIG ERROR 
				//l.Items[pc] = s;
				
				
			}
		
			
		}
		
		
		//main
		
		public int selectedindex = -1;
		public List<shape>forme = new List<shape>();
		public ListBoxLabels lbl = new ListBoxLabels();
		
		
		
		
		
		public void updateall(ref ListBox l, ref List<shape> f, ref TextBox t)
		{
			//delete all
			listBox1.Items.Clear();
			//rewriteall
			for(int i = 0 ; i < f.Count; i++ )
			{
				f[i].addShapeToList(i,ref l, ref t);
			}
		}
		             
		void MainFormMouseUp(object sender, MouseEventArgs e)
		{
		
		
		
	
			this.textBox3.Text = this.textBox1.Text;
			this.textBox4.Text = this.textBox2.Text;
			this.textBox1.Text = e.X.ToString();
			this.textBox2.Text = e.Y.ToString();
			int a1 = int.Parse(this.textBox1.Text);
			int a2 = int.Parse(this.textBox2.Text);
			int b1 = int.Parse(this.textBox3.Text);
			int b2 = int.Parse(this.textBox4.Text);
			string sape = this.textBox6.Text;
			forme.Add(new shape(a1,a2,b1,b2,sape));
			int c = forme.Count-1;
			forme[c].addShapeToList(c,ref this.listBox1,ref this.textBox7);
			
			lbl.addNewItem(a1.ToString()+";"+a2.ToString()+";"+b1.ToString()+";"+b2.ToString()+";"+sape+";"+c.ToString());
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Controls.Add(lbl);
			lbl.Left  = 600;
			lbl.Top = 60;
		}
		public void setSelectedItemInList(int x)
		{
			int n = x;
			selectedindex = n;
			this.textBox1.Text = forme[n].pozitii[0].ToString();
			this.textBox2.Text = forme[n].pozitii[1].ToString();
			this.textBox3.Text = forme[n].pozitii[2].ToString();
			this.textBox4.Text = forme[n].pozitii[3].ToString();
			this.textBox5.Text = n.ToString();
			this.textBox6.Text = forme[n].tip;
		}
		void ListBox1SelectedValueChanged(object sender, EventArgs e)
		{
			int n = listBox1.SelectedIndex;
			selectedindex = n;
			this.textBox1.Text = forme[n].pozitii[0].ToString();
			this.textBox2.Text = forme[n].pozitii[1].ToString();
			this.textBox3.Text = forme[n].pozitii[2].ToString();
			this.textBox4.Text = forme[n].pozitii[3].ToString();
			this.textBox5.Text = n.ToString();
			this.textBox6.Text = forme[n].tip;
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			Text = selectedindex.ToString();
			int a1 = int.Parse(this.textBox1.Text);
			int a2 = int.Parse(this.textBox2.Text);
			int b1 = int.Parse(this.textBox3.Text);
			int b2 = int.Parse(this.textBox4.Text);
			string sape = this.textBox6.Text;
			forme[selectedindex].modifyShape(selectedindex,a1,a2,b1,b2,sape,ref this.textBox7);
			
			//PRODUCE O ERAORE FOARTE MARE
			//forme[selectedindex].modifyShapeInList(selectedindex,ref this.listBox1,ref this.textBox7);
			updateall(ref this.listBox1, ref this.forme, ref this.textBox7);
			
			string news = a1.ToString()+";"+a2.ToString()+";"+b1.ToString()+";"+b2.ToString()+";"+sape+";"+selectedindex.ToString();
			this.lbl.labels[selectedindex].setLabelText(news);
		}
	}
}

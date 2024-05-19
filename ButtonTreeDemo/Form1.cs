using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics ;

using ButtonTree;
namespace ButtonTree
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private ButtonTree buttonTree1;
	
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTree1 = new ButtonTree();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(256, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTree1
            // 
            this.buttonTree1.AutoScroll = true;
            this.buttonTree1.ButtonNodeSize = new System.Drawing.Size(150, 20);
            this.buttonTree1.IndicatorButtonSeparator = 5;
            this.buttonTree1.IndicatorButtonSize = new System.Drawing.Size(10, 10);
            this.buttonTree1.IndicatorOffImage = ((System.Drawing.Image)(resources.GetObject("buttonTree1.IndicatorOffImage")));
            this.buttonTree1.IndicatorOnImage = ((System.Drawing.Image)(resources.GetObject("buttonTree1.IndicatorOnImage")));
            this.buttonTree1.Location = new System.Drawing.Point(16, 8);
            this.buttonTree1.MyImage = ((System.Drawing.Image)(resources.GetObject("buttonTree1.MyImage")));
            this.buttonTree1.Name = "buttonTree1";
            this.buttonTree1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonTree1.Size = new System.Drawing.Size(200, 288);
            this.buttonTree1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(400, 318);
            this.Controls.Add(this.buttonTree1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//ButtonNode.RootPanel=panel1;
			ButtonNode btnNode=new ButtonNode();
			ButtonNode btnNode2=new ButtonNode();
			ButtonNode btnNode3=new ButtonNode();
			ButtonNode btnNode4=new ButtonNode();
			ButtonNode btnNode5=new ButtonNode();
			ButtonNode btnNode6=new ButtonNode();
			ButtonNode btnNode7=new ButtonNode();
			ButtonNode btnNode8=new ButtonNode();
			ButtonNode btnNode9=new ButtonNode();
			ButtonNode btnNode10=new ButtonNode();
			ButtonNode btnNode11=new ButtonNode();
		
			
			btnNode3.AddChild(btnNode5);
			btnNode3.AddChild(btnNode6);
			btnNode4.AddChild(btnNode7);
			btnNode4.AddChild(btnNode8);
			btnNode4.AddChild(btnNode9);
			btnNode.AddChild(btnNode2);
			btnNode.AddChild(btnNode3);
			btnNode.AddChild(btnNode4);
			btnNode.AddChild(btnNode10);
			btnNode.AddChild(btnNode11);
			
			
			
			btnNode.NodeButton.Text="Milton";
			btnNode2.NodeButton.Text="Syed Md. Abul Bashar";
			btnNode3.NodeButton.Text="Mobile:";
			btnNode4.NodeButton.Text="Email:";
			btnNode5.NodeButton.Text="01712578150";
			btnNode6.NodeButton.Text="0191403410";
			btnNode7.NodeButton.Text="miltoncse00@yahoo.com";
			btnNode8.NodeButton.Text="miltoncse00@hotmail.com";
			btnNode9.NodeButton.Text="miltoncse00@juno.com";
			btnNode10.NodeButton.Text="Photo";
			btnNode11.NodeButton.Text="Article";
			btnNode10.NodeButton.Click+=new EventHandler(NodeButton_Click);
			btnNode11.NodeButton.Click+=new EventHandler(NodeButton_Click);
		
			
			//			btnNode.Level=0;
//			btnNode2.Level=0;
//			btnNode3.Level=1;
//			btnNode4.Level=2;
//			btnNode5.Level=1;
	buttonTree1.Add(btnNode);

			//	panel1.Add(btnNode2);
		//panel1.ReLoad();


		}

		private void NodeButton_Click(object sender, EventArgs e)
		{
			
			MiButton btn=(MiButton)sender;
			if(btn.MiNode.Count>0)
				btn.MiNode.ChangeNodeState(); 
			if(btn.Text=="Photo")
			{		
				string strPath=Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")) ;
				strPath=strPath.Substring(0, strPath.LastIndexOf("\\")) ;
  	
				strPath=strPath+@"\Milton.jpg";

			
				
				pictureBox1.Image =Image.FromFile(strPath)  ;
			}
			if(btn.Text=="Article")
			{			
				Process myProcess=new Process();
				myProcess.StartInfo.FileName="iexplore.exe";
				myProcess.StartInfo.Arguments ="http://www.codeproject.com/csharp/EmailChecking.asp";
				myProcess.Start();


			}
		}
	}
}

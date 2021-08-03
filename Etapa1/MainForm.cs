/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 23/01/2019
 * Time: 01:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Etapa1
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
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Graphics g ;
		void ButtonOpenClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string ruta = openFileDialog1.FileName;
			pictureBoxImg.Image = new Bitmap(ruta);
		}
		
		void ButtonFindCicleCentersClick(object sender, EventArgs e)
		{
			Bitmap bmpImage = new Bitmap(openFileDialog1.FileName);
			findCenter(bmpImage);
			pictureBoxImg.Image=bmpImage;		
		}
		void findCenter(Bitmap bmp){
			int contCicles;
			List<Circle>lc = new List<Circle>();
			contCicles = 0;
			for(int y = 0; y <bmp.Height; ++y){
				for(int x = 0; x < bmp.Width;++x){
					Color c = bmp.GetPixel(x,y);
					if(c.R == 0)
						if(c.G == 0)
							if(c.B == 0){
								int x_i;
								int x_f;
								int y_i;
								int y_f;
								int x_act;
								int y_act;
								int y_m;
								int x_m;
								
								x_i = x;
								x_act = x_i;
								y_act = y;
								y_i = y;
								Color c_act = c;
								bool isBlack;
								isBlack = true;
								do{
									y_act++;
									c_act = bmp.GetPixel(x,y_act);
										if(c_act.R != 0)
											isBlack = false;
										if(c_act.G != 0)
											isBlack = false;
										if(c_act.B != 0)
											isBlack = false;
								}while(isBlack);
								y_f = y_act-1;
								y_m = (y_i + y_f)/2;
								
								
								isBlack = true;
								x_act = x;
								do{
									x_act--;
									c_act = bmp.GetPixel(x_act,y_m);
									if(c_act.R != 0)
										isBlack = false;
									if(c_act.G != 0)
										isBlack = false;
									if(c_act.B != 0)
										isBlack = false;
								}while(isBlack);
								x_i = x_act+1;
								
								isBlack=true;
								x_act = x;
								do{
									x_act++;
									c_act = bmp.GetPixel(x_act,y_m);
									if(c_act.R != 0)
										isBlack = false;
									if(c_act.G != 0)
										isBlack = false;
									if(c_act.B != 0)
										isBlack = false;
								}while(isBlack);
								x_f = x_act-1;
								int r = (x_f - x_i)/2;
								x_m = (x_f + x_i)/2;
								
								//PINTAR CIRCULO//
								SolidBrush blueBrush = new SolidBrush(Color.Blue);
								//g = this.CreateGraphics();
								g=Graphics.FromImage(bmp);
								
								
								//drawCircleBlue(g,blueBrush,x_i,y_i,r);
								drawCircleBlueRectangle(g,blueBrush,x_i,y_i,r);
								//g.FillEllipse(blueBrush,center_x-2,center_y-2,diam_x+10,diam_y+10);
								//g.FillEllipse(blueBrush,new Rectangle(center_x,center_y,diam_x,diam_y)); Numero enteros
								//
								drawCenter(x_m,y_m, bmp);
								Circle circle = new Circle(x_m,y_m,r,contCicles);
								contCicles++;
								lc.Add(circle);
								//return;
							}
				}
			}
			listBoxCenter.DataSource = lc;
		}
		
		void drawCircleBlue(Graphics g,SolidBrush blueBrush,float center_x,float center_y,float radius){
			float diam = (radius*2)+15;
			center_x-=3;
			center_y-=3;
			g.FillEllipse(blueBrush,center_x,center_y,diam,diam);
		}
		void drawCircleBlueRectangle(Graphics g, SolidBrush blueBrush, float center_x,float center_y,float radius){
			center_x-=9;
			center_y-=9;
			float diam = (radius*2)+20;
			g.FillEllipse(blueBrush,new RectangleF(center_x,center_y,diam,diam));
		}
		
		
		void drawCenter(int x, int y, Bitmap bmp){
			for(int j = -5; j <=5;j++){
				for(int i = -5; i <= 5; i++){
					bmp.SetPixel(x+i,y+j,Color.Red);
				}
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 28/01/2019
 * Time: 02:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Etapa1
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle
	{
		private int x;
		private int y;
		private int r;
		private int id;
		public Circle(int x,int y,int id,int r)
		{
			this.x = x;
			this.y = y;
			this.r = r;
			this.id = id;
		}
		public override string ToString()
		{
			return string.Format("[X={0}, Y={1}, R={2}, Id={3}]", x, y, r, id);
			String s = "";
			s = "x: "+x+" y: "+y+" r: "+r;
			return s;
		}
		

	}
}

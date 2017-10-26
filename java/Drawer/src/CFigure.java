import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.util.Random;

import javax.swing.JPanel;

public class CFigure extends JPanel 
{
	Color col;
	int w;
	int type;
	
	
	public CFigure(Point p1, Point p2, XData d) 
	{
		setLocation(p1);
		setSize(p2.x - p1.x, p2.y - p1.y);
		
		col = d.col;
		w = d.w;
		type = d.t;
	}
	
	@Override
	public void paint(Graphics go) 
	{
		//super.paint(go);
		Graphics2D g = (Graphics2D) go;
		g.setColor(col);
		g.setStroke(new BasicStroke(w));
		switch (type) 
		{
			case 0: g.drawRect(1, 1, getWidth()-2, getHeight()-2);break;
			case 1: g.fillOval(1, 1, getWidth()-2, getHeight()-2);break;
			case 2: g.drawRoundRect(1, 1, getWidth()-2, getHeight()-2, 50, 50);break;
			case 3: g.drawLine(1, 1, getWidth()-2, getHeight()-2);break;
		}		
	}	
}

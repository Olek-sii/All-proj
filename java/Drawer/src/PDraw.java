import java.awt.Point;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.JPanel;

public class PDraw extends JPanel implements MouseListener
{
	XData data;
	Point p;
	
	public PDraw(XCommand cmd) 
	{
		data = cmd.data;
		setLayout(null);
		addMouseListener(this);
	}

	@Override
	public void mousePressed(MouseEvent e) 
	{
		p = e.getPoint();
	}
	@Override

	public void mouseReleased(MouseEvent e) 
	{
		add( new CFigure(p, e.getPoint(), data));
		repaint();
	}
	
	@Override
	public void mouseClicked(MouseEvent e) {}
	@Override
	public void mouseEntered(MouseEvent e) {}
	@Override
	public void mouseExited(MouseEvent e) {}
}

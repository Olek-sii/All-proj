import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

public class MMenu extends JMenuBar 
{
	public MMenu(XCommand cmd) 
	{
		JMenu mnuType  = new JMenu("Figure Type");
		
		JMenuItem mnuRect = new JMenuItem("Rect");
		JMenuItem mnuOval = new JMenuItem("Oval");
		JMenuItem mnuRRec = new JMenuItem("RRec");
		JMenuItem mnuLine = new JMenuItem("Line");
		
		mnuRect.setActionCommand("Rect");
		mnuOval.setActionCommand("Oval");
		mnuRRec.setActionCommand("RRec");
		mnuLine.setActionCommand("Line");
		
		mnuRect.addActionListener(cmd.aType);
		mnuOval.addActionListener(cmd.aType);
		mnuRRec.addActionListener(cmd.aType);
		mnuLine.addActionListener(cmd.aType);
		
		mnuType.add(mnuRect);
		mnuType.add(mnuOval);
		mnuType.add(mnuRRec);
		mnuType.add(mnuLine);
		
		add( mnuType );
	}

}

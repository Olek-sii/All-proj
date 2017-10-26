import javax.swing.JButton;
import javax.swing.JPanel;

public class PType extends JPanel 
{
	public PType(XCommand cmd) 
	{
		setLayout(null);
		
		JButton btnRect = new JButton("Rect");
		JButton btnOval = new JButton("Oval");
		JButton btnRRec = new JButton("RRec");
		JButton btnLine = new JButton("Line");
		
		btnRect.setBounds(10,10, 120,20);
		btnOval.setBounds(10,40, 120,20);
		btnRRec.setBounds(10,70, 120,20);
		btnLine.setBounds(10,100,120,20);
		
		btnRect.setActionCommand("Rect");
		btnOval.setActionCommand("Oval");
		btnRRec.setActionCommand("RRec");
		btnLine.setActionCommand("Line");
		
		btnRect.addActionListener(cmd.aType);
		btnOval.addActionListener(cmd.aType);
		btnRRec.addActionListener(cmd.aType);
		btnLine.addActionListener(cmd.aType);
		
		add( btnRect );
		add( btnOval );
		add( btnRRec );
		add( btnLine );
	}
}

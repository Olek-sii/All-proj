import javax.swing.JPanel;

public class CPanel extends JPanel
{
	PDraw pd;
	PType pt;
	public CPanel(XCommand cmd) 
	{
		setLayout(null);
		
		pd = new PDraw(cmd);
		pt = new PType(cmd);
		
		pd.setBounds(200, 0, 570,530);
		pt.setBounds(0,0,200,200);
		
		add( pd );
		add( pt );
	}
}

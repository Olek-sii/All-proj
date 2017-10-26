import javax.swing.JFrame;

public class CFrame extends JFrame 
{
	public CFrame() 
	{
		setBounds(100, 100, 700, 700);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		XCommand cmd = new XCommand();
		MMenu    mnu = new MMenu(cmd);
		CPanel   cp  = new CPanel(cmd);
		
		setJMenuBar( mnu );
		add( cp );
		
		setVisible(true);
	}
}

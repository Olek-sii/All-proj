import java.awt.Color;
import javax.swing.JFrame;
import javax.swing.JTextField;
public class CFrame extends JFrame 
{
	public CFrame() 
	{
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setTitle("Calc");
		setBounds(300,100,250,250);
		JTextField inp=new JTextField();
		inp.setEnabled(true);
		add(inp);
		CPanel cp=new CPanel();
		cp.setBackground(Color.YELLOW);
		add(cp);
		setVisible(true);
	}
}

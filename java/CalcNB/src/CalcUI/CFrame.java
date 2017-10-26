package CalcUI;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import CalcLogic.CalcAPI;

public class CFrame extends JFrame 
{
	JTextField fx;
	JTextField fy;
	JTextField fop;
	JTextField fres;
	
	public CFrame() 
	{
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		setTitle("CalcNB");
		setBounds(0,0,300,300);
		setLayout(new GridLayout(1,1));
		
		JPanel jp=new JPanel();
						
		add(jp);
		
		jp.setLayout(new GridLayout(4, 2));
			
		addFields(jp);
		addButton(jp);
		
		setVisible(true);
	}
	
	private void addFields(JPanel jp)
	{
		JLabel jt1=new JLabel("X=");
		jp.add(jt1);		
		fx=new JTextField(15);
		fx.setName("fx");
		jp.add(fx);
			
		JLabel jt3=new JLabel("OP=");
		jp.add(jt3);		
		fop=new JTextField(15);
		fop.setName("fop");
		jp.add(fop);
		
		JLabel jt2=new JLabel("Y=");
		jp.add(jt2);		
		fy=new JTextField(15);
		fy.setName("fy");
		jp.add(fy);				
		
		fres=new JTextField(15);
		fres.setName("fres");
		jp.add(fres);
	}
	
	private void addButton(JPanel jp)
	{
		JButton calc=new JButton("Calc");
		calc.setName("calc");
		jp.add(calc);
		
		calc.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				int a=Integer.parseInt(fx.getText());
				int b=Integer.parseInt(fy.getText());
				char o=fop.getText().charAt(0);
				fres.setText(CalcAPI.Calc(a, b, o)+"");
			}
		});
	}
}
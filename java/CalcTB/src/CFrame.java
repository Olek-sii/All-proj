import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class CFrame extends JFrame 
{
	public CFrame() 
	{
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setTitle("Calc");
		setBounds(300,100,250,250);
		JPanel jp=new JPanel();
		setLayout(new GridLayout(1,1));
		add(jp);
		jp.setLayout(new GridLayout(4, 2));
		JLabel jt1=new JLabel("A=");
		jp.add(jt1);
		JTextField fa=new JTextField(15);
		jp.add(fa);
		JLabel jt2=new JLabel("B=");
		jp.add(jt2);
		JTextField fb=new JTextField(15);
		jp.add(fb);
		JLabel jt3=new JLabel("OP=");
		jp.add(jt3);
		JTextField fop=new JTextField(15);
		jp.add(fop);
		JTextField answ=new JTextField(15);
		answ.setEnabled(false);
		answ.setDisabledTextColor(Color.BLACK);
		jp.add(answ);
		JButton calc=new JButton("Calc");
		jp.add(calc);
		calc.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				int a=Integer.parseInt(fa.getText());
				int b=Integer.parseInt(fb.getText());
				char o=fop.getText().charAt(0);
				answ.setText(CalcAPI.Calc(a, b, o)+"");
			}
		});
		setVisible(true);
	}
}
import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class CPanel extends JPanel 
{
	private int a=0;
	private char op='+';
	public CPanel() 
	{
		setLayout(new GridLayout(4, 5));
		JTextField inp=new JTextField();
		inp.setDisabledTextColor(Color.BLACK);
		inp.setEnabled(false);
		add(inp);
		JButton plus = new JButton("+");
		add(plus);
		JButton minus = new JButton("-");
		add(minus);
		JButton mul = new JButton("*");
		add(mul);
		JButton div = new JButton("/");
		add(div);
		JButton num0 = new JButton("0");
		add(num0);
		JButton num1 = new JButton("1");
		add(num1);
		JButton num2 = new JButton("2");
		add(num2);
		JButton num3 = new JButton("3");
		add(num3);
		JButton num4 = new JButton("4");
		add(num4);
		JButton num5 = new JButton("5");
		add(num5);
		JButton num6 = new JButton("6");
		add(num6);
		JButton num7 = new JButton("7");
		add(num7);
		JButton num8 = new JButton("8");
		add(num8);
		JButton num9 = new JButton("9");
		add(num9);
		JButton cancel = new JButton("C");
		add(cancel);
		JButton calc=new JButton("=");
		add(calc);
		num0.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'0');
			}
		});
		num1.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'1');
			}
		});
		num2.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'2');
			}
		});
		num3.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'3');
			}
		});
		num4.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'4');
			}
		});
		num5.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'5');
			}
		});
		num6.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'6');
			}
		});
		num7.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'7');
			}
		});
		num8.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'8');
			}
		});
		num9.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				inp.setText(inp.getText()+'9');
			}
		});
		
		plus.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				a = Integer.valueOf(inp.getText());
				op='+';
				inp.setText("");
			}
		});
		minus.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				a = Integer.valueOf(inp.getText());
				op='-';
				inp.setText("");
			}
		});
		mul.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				a = Integer.valueOf(inp.getText());
				op='*';
				inp.setText("");
			}
		});
		div.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				a = Integer.valueOf(inp.getText());
				op='/';
				inp.setText("");
			}
		});
		
		calc.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				int b = Integer.valueOf(inp.getText());
				int answer=CalcAPI.Calc(a,b,op);
				inp.setText(""+answer);
			}
		});
		cancel.addActionListener(new ActionListener() 
		{
			@Override
			public void actionPerformed(ActionEvent arg0) 
			{
				a = 0;
				op='+';
				inp.setText("");
			}
		});
	}
}

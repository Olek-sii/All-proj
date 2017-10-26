package CalcLogic;

public class CalcAPI
{
	public static int Calc(int a,int b,String op)
	{

		String opp = "+-/*";
		if( opp.indexOf(op.charAt(0)) == -1 )
			throw new IllegalArgumentException();
		if( op.charAt(0) == '/' && b == 0 )
			throw new ArithmeticException();
		int answ=0;
		switch(op)
		{
		case "+":
			answ=a+b;
			break;
		case "-":
			answ=a-b;
			break;
		case "*":
			answ=a*b;
			break;
		case "/":
			answ=a/b;
			break;
		}
		return answ;
	}
}

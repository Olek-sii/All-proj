
public class CalcAPI {
	public static int Calc(int a, int b, char op) {
		if (op == '/' && b == 0)
			throw new ArithmeticException();

		int answ = 0;
		switch (op) {
		case '+':
			answ = a + b;
			break;
		case '-':
			answ = a - b;
			break;
		case '*':
			answ = a * b;
			break;
		case '/':
			answ = a / b;
			break;
		default:
			throw new IllegalArgumentException();
		}
		return answ;
	}
}

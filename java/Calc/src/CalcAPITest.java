import static org.junit.Assert.*;

import org.junit.Test;

public class CalcAPITest {

	@Test (expected = ArithmeticException.class)
	public void testCalcEx_div0() 
	{
		CalcAPI.Calc(5, 0, '/');
	}
	
	@Test (expected = IllegalArgumentException.class)
	public void testCalcEx_op() 
	{
		CalcAPI.Calc(5, 5, '~');
	}

	@Test
	public void testCalcPlus() 
	{
		int res = CalcAPI.Calc(10, 5, '+');
		assertEquals(15, res);
	}
	@Test
	public void testCalcMinus() 
	{
		int res = CalcAPI.Calc(15, 5, '-');
		assertEquals(10, res);
	}
	@Test
	public void testCalcDiv() 
	{
		int res = CalcAPI.Calc(50, 50, '/');
		assertEquals(1, res);
	}
	@Test
	public void testCalcMult() 
	{
		int res = CalcAPI.Calc(5, 2, '*');
		assertEquals(10, res);
	}
}

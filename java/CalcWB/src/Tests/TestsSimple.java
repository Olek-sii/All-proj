package Tests;
import static org.junit.Assert.*;

import java.util.Arrays;
import java.util.Collection;

import org.assertj.swing.fixture.FrameFixture;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import org.junit.runners.Parameterized.Parameters;

import CalcUI.CFrame;

@RunWith(Parameterized.class)
public class TestsSimple 
{
	private FrameFixture calc;
	
	@Before
	public void setUp() 
	{

		calc = new FrameFixture(new CFrame());
	}
	
	@After
	public void tearDown() 
	{
 
		calc.cleanUp();
	}
	
 	private String numberA;

    
    public TestsSimple(String numberA) 
    {
        this.numberA = numberA;
    }

    
    @Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(new Object[][]{
                {"fy"},
                {"fx"},
                {"fop"},
                {"fres"}
        });
    }

    @Test
	public void testSimple() 
	{	
		assertEquals(true, calc.textBox(numberA).isEnabled());
	}
}

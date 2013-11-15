import static org.junit.Assert.*;

import org.junit.Test;

public class TestBusinessLogic {

	@Test
	public void testAdd() {
		assertEquals("3 + 3 must be 6", 6, BusinessLogic.Add(3,  3));
	}

	@Test
	public void testMultiply() {
		assertEquals("3 * 3 must be 9", 9, BusinessLogic.Multiply(3,  3));
	}

	@Test
	public void testSubtract() {
		assertEquals("3 - 3 must be 0", 0, BusinessLogic.Subtract(3,  3));
	}
	
	@Test
	public void testDevide() {
		assertEquals("3 / 3 must be 1", 1, BusinessLogic.Devide(3,  3));
	}

}

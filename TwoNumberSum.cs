using System;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		// Write your code here.
		int aIndex = 0;
		
		while (aIndex < array.Length) {
			int nextIndex = aIndex + 1;
			while (nextIndex < array.Length) {
				int currentValue = array[aIndex];
				int nextValue = array[nextIndex];
				if (currentValue + nextValue == targetSum) return new int[]{currentValue , nextValue};
				nextIndex++;
			}
			aIndex++;
		}
		
		return new int[0];
	}
}

public class ProgramTest {
	[Test]
	public void TestCase1() {
		int[] output = Program.TwoNumberSum(new int[] {3, 5, -4, 8, 11, 1, -1, 6}, 10);
		Utils.AssertTrue(output.Length == 2);
		Utils.AssertTrue(Array.Exists(output, e => e == -1));
		Utils.AssertTrue(Array.Exists(output, e => e == 11));
	}
}

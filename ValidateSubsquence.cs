using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
		int arrayIndex = 0;
		int sequenceIndex = 0;
		while ((arrayIndex < array.Count) && (sequenceIndex < sequence.Count)) {
			if (array[arrayIndex] == sequence[sequenceIndex]) {
				arrayIndex++;
				sequenceIndex++;
			}
			else {
				arrayIndex++;
			}
		}
		return sequenceIndex == sequence.Count;
	}
}

public class ProgramTest {
	[Test]
	public void TestCase1() {
		List<int> array = new List<int> {
			5, 1, 22, 25, 6, -1, 8, 10
		};
		List<int> sequence = new List<int> {
			1, 6, -1, 10
		};
		Utils.AssertTrue(Program.IsValidSubsequence(array, sequence));
	}
}

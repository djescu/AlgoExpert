/*
	Encontrar tres números que sumen el valor objetivo.

	Ordenamos el array para asi poder descartar ciertos valores durante el proceso de suma.
	Se coge un valor del array y se va probrando con dos indices: por delantes y por detrás para ver si suma.
	Dependiendo del valor de la suma se incrementa el índice de delante o el de atrás.

	O(n^2) Time | O(n) Space where n is de length of the array.
*/

using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		// Write your code here.
		int index = 0;
		List<int[]> result = new List<int[]>();
		
		// Sort array.
		Array.Sort(array);
		// Loop until array value < targetSum
		while ((index < array.Length) && (array[index] < targetSum)) {
			int forward = index + 1;
			int backward = array.Length - 1;
			
			// While forward not overpass backward.
			while (forward < backward) {
				int sum = array[index] + array[backward] + array[forward];
				//Check sum.
				if (sum == targetSum) {
					int[] values = {array[index], array[forward], array[backward]};
					result.Add(values);
					forward++;
					backward--;
				}
				else {
					if (sum > targetSum) backward--;
					else forward++;
				}
			}
			
			index++;
		}
		
		return result;
	}
}

public class ProgramTest {
	private bool compare(List<int[]> triplets1, List<int[]> triplets2) {
		if (triplets1.Count != triplets2.Count) return false;
		for (int i = 0; i < triplets1.Count; i++) {
			if (!Enumerable.SequenceEqual(triplets1[i], triplets2[i])) {
				return false;
			}
		}
		return true;
	}

	[Test]
	public void TestCase1() {
		List<int[]> expected = new List<int[]>();
		expected.Add(new int[] {-8, 2, 6});
		expected.Add(new int[] {-8, 3, 5});
		expected.Add(new int[] {-6, 1, 5});
		List<int[]> output =
		  Program.ThreeNumberSum(new int[] {12, 3, 1, 2, -6, 5, -8, 6}, 0);
		Utils.AssertTrue(this.compare(output, expected));
	}
}

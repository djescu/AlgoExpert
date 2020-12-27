/*
	Verificar que los carácteres de la secuencia aparecen en el array original.
	
	Punteros al comienzo de cada lista.
	Se comprueba el valor de la secuencia y dependiendo de si se encuentra o no se incrementa un puntero o ambos.

	O(n) Time | O(1) Space where n is de length of the array.
*/

using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {

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

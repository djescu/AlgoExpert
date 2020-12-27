/*
	Encontrar la menor diferencia entre los números de los arrays.

	Ordenar los arrays para descartar valores.
	Se comprueba la diferencia y se queda con la menor. Además:
        - Si es 0 (o los valores son iguales) se han encontrado los números.
        - Si el valor del primer array es menor que el del segundo se incrementa el índice del primer array.
        - Si el valor del segundo array es menor que el del primero se incrementa el índice del segundo array.

	O(nlog(n) + mlog(m)) Time | O(1) Space where n is de length of the array one and m is de length of the array two.
*/

using System;

public class Program {
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) {

		Array.Sort(arrayOne);
		Array.Sort(arrayTwo);

		int indexOne = 0;
		int indexTwo = 0;
		int lowestDifference = Int32.MaxValue;
		int difference = 0;
		int[] result = new int[] {};

		while ((indexOne < arrayOne.Length) && (indexTwo < arrayTwo.Length)) {
			int valueOne = arrayOne[indexOne];
			int valueTwo = arrayTwo[indexTwo];

			if (valueOne == valueTwo) return new int[] {valueOne, valueTwo};
			else {
	
				if (valueOne < valueTwo) {
					difference = valueTwo - valueOne;
					indexOne++;
				}
				else {
					difference = valueOne - valueTwo;
					indexTwo++;
				}
				if (difference < lowestDifference) {
					lowestDifference = difference;
					result = new int[] {valueOne, valueTwo};
				}
			}
		}
		
		return result;
	}
}

public class ProgramTest {
	[Test]
	public void TestCase1() {
		int[] expected = {28, 26};
		Utils.AssertTrue(Enumerable.SequenceEqual(Program.SmallestDifference(new int[] {-1,
		                                                                                5,
		                                                                                10,
		                                                                                20,
		                                                                                28,
		                                                                                3},
		  new int[] {26,
		             134,
		             135,
		             15,
		             17}),
		  expected));
	}
}
/*
	Verificar que la cadena recibida se lee igual de izquierda a derecha que de derecha a izquierda.
	
	Recorro por delante y por detrás para comparar carácteres.
    Si los carácteres coinciden movemos los indices. Si no no es necesario continuar.

	O(n) Time | O(n) Space where n is de length of the array.
*/

using System;

public class Program {
	public static bool IsPalindrome(string str) {
		// Write your code here.
		
		int beginIndex = 0;
		int lastIndex = str.Length - 1;
		
		while (beginIndex <= lastIndex) {
			if (beginIndex == lastIndex) return true;
			if (str[beginIndex] == str[lastIndex]) {
				beginIndex++;
				lastIndex--;
			}
			else return false;
		}
		
		return true;
	}
}
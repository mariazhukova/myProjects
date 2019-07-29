// fibonachi.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


class Fibonacci {
public:
	static int get(int n) {
		int *arr = new int [n];
		arr[0] = 0;
		arr[1] = 1;
		int last_digit;
		for (int i = 2; i <= n; i++) {
			arr[i] = arr[i - 1] + arr[i - 2];
			last_digit = fabs((arr[i - 1] + arr[i - 2]) % 10);
		}
		return  last_digit;
	}
};

int main(void) {
	int n = 3;
	cin >> n;
	cout << Fibonacci::get(n) << endl;
	return 0;
}


//encrypt and decrypt.
#include<iostream>
using namespace std;
void encrypt()
{
	int input, n1, n2, n3, n4;
	cout << "Enter a 4 digit number:\t";
	cin >> input;
	if (input > 999 && input < 10000)
	{
		n4 = input % 10;
		input /= 10;
		n3 = input % 10;
		input /= 10;
		n2 = input % 10;
		input /= 10;
		n1 = input;
		n1 = n1 + n3;
		n3 = n1 - n3;
		n1 = n1 - n3;
		n2 = n2 + n4;
		n4 = n2 - n4;
		n2 = n2 - n4;

		cout << "Encrypted form is:\t" << n1 << n2 << n3 << n4 << endl;
	}
	else
		cout << "Input a 4 digit number!" << endl;

	system("pause");
}
void decrypt()
{
	int input, n1, n2, n3, n4;
	cout << "Enter a 4 digit number:\t";
	cin >> input;
	if (input > 999 && input < 10000)
	{
		n4 = input % 10;
		input /= 10;
		n3 = input % 10;
		input /= 10;
		n2 = input % 10;
		input /= 10;
		n1 = input;
		n1 = n1 + n3;
		n3 = n1 - n3;
		n1 = n1 - n3;
		n2 = n2 + n4;
		n4 = n2 - n4;
		n2 = n2 - n4;

		cout << "Encrypted form is:\t" << n1 << n2 << n3 << n4 << endl;
	}
	else
		cout << "Input a 4 digit number!" << endl;

	system("pause");
}
void main()
{
	char option; 
		cout << "enter the option :";
		cin >> option;
	if (option=='e')
		encrypt();
	if (option == 'd')
		decrypt();
	system("pause>0");
}

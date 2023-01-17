// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <sstream>

using namespace std;

int main()
{
   /* int numbers[] = {5,6,7};
	char text[7];

	for (size_t i = 0; i < 3; i++)
	{
		cout << &numbers[i] << ", " << endl;
		

		
	}*/

	string input;

	getline(cin, input);       // read line from console and put it in input;
	istringstream numbers(input);
	int num1, num2;


	for (size_t i = 0; i < 2; i++)
	{
		numbers >> num1;
		cout << num1;
	}

	/*fgets(text, 10, stdin);
	printf(text);

	int* second = new int[5] {1,2,4};

	char text2[20];

	fgets(text2, 20, stdin);


	printf("%s", &text2);



	second[4] = 5;

	for (size_t i = 0; i <5; i++)
	{
		cout << second[i] << endl;

		
	}

	

	FILE* fp;*/
	
	//fputs(text, fp);

	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

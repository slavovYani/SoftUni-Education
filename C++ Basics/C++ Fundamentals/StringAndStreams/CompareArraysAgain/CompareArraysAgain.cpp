

#include <iostream>
#include <cstring>
#include <vector>
#include <sstream>
using namespace std;

bool areArraysEqual(char* first, char* second) {

	if (strlen(first) != strlen(second))
		return false;

	for (size_t i = 0; i < strlen(first); i++)
	{
		if (first[i] != second[i])
		{
			return false;
		}
	}

	return true;
}

bool areArraysEqual(string first, string second) {

	if (first.size() != second.size())
		return false;

	for (size_t i = 0; i < first.size(); i++)
	{
		if (first[i] != second[i])
		{
			return false;
		}
	}

	return true;
}

void parseArray(vector<int> &array, istringstream &stream) {

	int currentNumber;

	while (stream >> currentNumber)
	{
		array.push_back(currentNumber);
	}

}

int main()
{
	char first_array[20];
	char second_array[20];

	string str1, str2;
	/*fgets(first_array, 20, stdin);
	fgets(second_array, 20, stdin);*/

	getline(cin, str1);
	getline(cin, str2);

	vector<int> arr1, arr2;

	istringstream stream1(str1);
	istringstream stream2(str2);

	parseArray(arr1, stream1);
	parseArray(arr1, stream2);

	bool result;
	bool result2;
	//result = areArraysEqual(first_array, second_array);
	result2 = areArraysEqual(str1, str2);


	if (result2)
	{
		cout << "equal";
	}
	else
	{
		cout << "not equal";
	}

}




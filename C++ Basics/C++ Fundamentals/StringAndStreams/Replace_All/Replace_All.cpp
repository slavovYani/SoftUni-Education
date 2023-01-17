
#include <iostream>
#include <string>

using namespace std;

int main()
{
	string input, searched, replaced;

	getline(cin, input);
	getline(cin, searched);
	getline(cin, replaced);

	int lenght = searched.size();
	int index = 0;

	while (true)
	{
		
		index = input.find(searched, index++);

		if (index == -1)
		{
			break;
		} 
		

		input.replace(index, lenght, replaced);

	}

	cout << input << endl;



}


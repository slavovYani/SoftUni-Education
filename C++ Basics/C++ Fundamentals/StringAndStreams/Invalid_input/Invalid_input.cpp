
#include <iostream>
#include <sstream>

using namespace std;

int ToDigit(char c) {
	return c - '0';
}

int main()
{
	string input;
	getline(cin, input);
	istringstream stream(input);

	ostringstream output;

	string current;
	int sum = 0;

	while (stream >> current)
	{
		if (current[0] >= '0' && current[0] <= '9' || current[0] < '0' && current[0] >= '-9')
		{
			sum += stoi(current);
		}
		else if (current[0] == '-' &&  current[1] >= '0' && current[1] <= '9' || current[1] < '0' && current[1] >= '-9')
		{
			sum += stoi(current);
		}
		else
		{
			output << current + string(" ");
		}

	}

	cout << sum << endl;
	cout << output.str();


}


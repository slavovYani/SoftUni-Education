
#include <iostream>
#include <string>
#include <sstream>

using namespace std;

int main()
{
	string start_string;

	getline(cin, start_string);

	ostringstream output;

	char current_char;
	bool is_first_letter = false;

	for (size_t i = 0; i < start_string.size(); i++)
	{
		current_char = start_string[i];

		if (current_char >= 'a' || current_char <= 'z' || current_char >= 'A' || current_char <= 'Z')
		{
			if (is_first_letter)
			{
				current_char = toupper(current_char);
				is_first_letter = false;
			}
		}
		else
		{
			is_first_letter = true;
		}

		output << current_char;
	}


	cout << output.str() << endl;



}


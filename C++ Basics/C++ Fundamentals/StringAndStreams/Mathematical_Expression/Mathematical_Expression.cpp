
#include <iostream>
#include <string>
#include <sstream>


using namespace std;

bool CorrectOrNot(istringstream& stream)
{
	char c;
	int depth = 0;

	while (stream >> c)
	{
		if (c == '(')
		{
			depth++;
		}
		else if (c == ')') 
		{
			depth--;
		}

	}

	if (depth == 0)
	{
		return true;
	}
	
		return false;
	
}

int main(void)
{
	string str;

	getline(cin, str);
	istringstream stream(str);

	
	

	bool isCorrect = CorrectOrNot(stream);
   
	if (isCorrect)
	{
		cout << "correct";
	}
	else
	{
		cout << "incorrect";
	}

	return 0;
}



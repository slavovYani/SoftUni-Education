#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

int main()
{
    char first_array[20];
    char second_array[20];

    fgets(first_array, 20, stdin);
    fgets(second_array, 20, stdin);

    bool result = areArraysEqual(first_array, second_array);

    if (result)
    {
//        cout << "euqal";
        printf("equal");
    }
    else
    {
//        cout << "not equal";
         printf("equal");

    }

}
bool areArraysEqual(char first[],char second[]) {

    if (strlen(first) != strlen(second))
        return false;

    for (size_t i = 0; i < strlen(first); i++)
    {
        if (first[i]!=second[i])
        {
            return false;
        }
    }

    return true;
}




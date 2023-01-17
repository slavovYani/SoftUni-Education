#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
   char text[15];
   scanf("%s",text);
   char name[15];


   if(strcmp("Yani",text) == 0)
   {
       strcpy(name,text);               ///copy one string to another;
       printf("Your name is %s",name);
   }
   else
    {
    puts("Nothing");
   }

    return 0;
}

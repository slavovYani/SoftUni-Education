#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include<string.h>



int main()
{
    int days_vacation;
    char room[30];
    char pos_or_neg[20];
//    bool is_positive;
    double total;

    scanf("%d\n",&days_vacation);
    days_vacation--;
    fgets(room,30,stdin);
    fgets(pos_or_neg,20,stdin);

    int len = strlen(room);
    int len_2 = strlen(pos_or_neg);

    room[len-1]= '\0';
    pos_or_neg[len_2-1]= '\0';

//      gets(room);
//      gets(pos_or_neg);


    if(strcmp(room,"room for one person")==0){
        total = days_vacation * 18.00;

    }
    else if(strcmp(room,"apartment")==0){
        total = days_vacation * 25.00;

        if(days_vacation>=10 && days_vacation <=15){
            total = total * 0.65;
        }
        else if(days_vacation > 15){
            total = total * 0.50;
        }
        else{
            total = total * 0.7;
        }
    }
    else{
        total = days_vacation * 35.00;

        if(days_vacation>=10 && days_vacation <=15){
            total = total * 0.85;
        }
        else if(days_vacation > 15){
            total = total * 0.80;
        }
        else{
            total = total * 0.90;
        }
    }



    if(strcmp(pos_or_neg,"positive")==0){
        total = total*1.25;
        }
    else{
         total = total * 0.9;
    }

      printf("%.2lf", total);


    return 0;
}

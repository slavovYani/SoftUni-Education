#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    double vacantion_price;
    int puzzle_count;
    int dolls_count;
    int teddy_bear_count;
    int minions_count;
    int trucks_count;



    const double puzzle_price = 2.60;
    const double doll_price = 3;
    const double teddy_bear_price = 4.10;
    const double minion_price = 8.20;
    const double truck_price = 2;

//    char* message = malloc(sizeof(char) * 40);


   scanf("%lf", &vacantion_price);
   scanf("%d", &puzzle_count);
   scanf("%d", &dolls_count);
   scanf("%d", &teddy_bear_count);
   scanf("%d", &minions_count);
   scanf("%d", &trucks_count);

   int total_count = puzzle_count + dolls_count + teddy_bear_count + minions_count + trucks_count;

   double total_sum = puzzle_count * puzzle_price + dolls_count * doll_price +
     teddy_bear_count *teddy_bear_price + minions_count * minion_price + trucks_count * truck_price;

   if(total_count>=50){
        total_sum=0.75 * total_sum;  /// 25% discount
   }

   total_sum = total_sum * 0.9;     ///10% rent

   double money;

   if(total_sum>=vacantion_price){
        money = total_sum - vacantion_price;

    printf("Yes! %.2lf lv left.",money);

   }
   else{
        money = vacantion_price - total_sum;
        printf("Not enough money! %.2lf lv needed.",money);

   }
    return 0;
}

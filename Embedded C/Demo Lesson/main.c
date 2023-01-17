#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
 double price;
 scanf("%lf",&price);

 double calculatedprice = price * 7.61;
 double discount = calculatedprice * 0.18;
 double calculated_final_price = calculatedprice - discount;

 char first_text[30] = "The final price is: ";
 char second_text[30] = "The discount is: ";

 printf("%s" "%.2lf lv.\n",first_text, calculated_final_price);
 printf("%s" "%.2lf lv.\n",second_text, discount);
 printf("The final price is: %.2lf.lv.\n",calculated_final_price);


    return 0;
}

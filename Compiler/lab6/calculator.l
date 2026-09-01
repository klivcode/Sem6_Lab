%{
#include <stdio.h>
#include <stdlib.h>

float num1, num2;
char op;
%}

%%

[0-9]+(\.[0-9]+)?   { 
                        if(num1 == 0)
                            num1 = atof(yytext);
                        else
                            num2 = atof(yytext);
                     }

[+]                 { op = '+'; }
[-]                 { op = '-'; }
[*]                 { op = '*'; }
[/]                 { op = '/'; }

\n                  { 
                        switch(op)
                        {
                            case '+': printf("Result = %.2f\n", num1 + num2); break;
                            case '-': printf("Result = %.2f\n", num1 - num2); break;
                            case '*': printf("Result = %.2f\n", num1 * num2); break;
                            case '/': printf("Result = %.2f\n", num1 / num2); break;
                        }
                        return 0;
                    }

[ \t]               ;

%%

int main()
{
    printf("Enter calculation: ");
    yylex();
    return 0;
}

int yywrap()
{
    return 1;
}
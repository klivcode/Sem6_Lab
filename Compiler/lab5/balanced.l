%{
#include <stdio.h>

int count = 0;
int balanced = 1;
%}

%%

[(]    { count++; }

[)]    {
          count--;
          if(count < 0)
              balanced = 0;
       }

\n     { return 0; }

[ \t]  ;

.      ;

%%

int main()
{
    printf("Enter an arithmetic expression: ");
    yylex();

    if(count == 0 && balanced)
        printf("Parentheses are balanced\n");
    else
        printf("Parentheses are not balanced\n");

    return 0;
}

int yywrap()
{
    return 1;
}
%{
#include <stdio.h>

int count = 0;
%}

%%

" "     { count++; }
\t      { count++; }
\n      { return 0; }
.       ;

%%

int main()
{
    printf("Enter a string: ");
    yylex();

    printf("Number of white-spaces = %d\n", count);

    return 0;
}

int yywrap()
{
    return 1;
}
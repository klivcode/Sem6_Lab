%{
#include <stdio.h>

int count = 0;
%}

%%

"int"|"float"|"char"|"double"|"if"|"else"|"for"|"while"|"do"|"return"|"void"|"switch"|"case"|"break"|"continue" {
    count++;
    printf("%s is a keyword\n", yytext);
}

[a-zA-Z_][a-zA-Z0-9_]*    ;

[ \t\n]+    ;

.    ;

%%

int main()
{
    printf("Enter a string: ");
    yylex();

    printf("Total number of keywords = %d\n", count);

    return 0;
}

int yywrap()
{
    return 1;
}
%{
#include <stdio.h>
%}

%%

[a-zA-Z_][a-zA-Z0-9_]* {
    printf("Valid Identifier: %s\n", yytext);
}

[0-9]+ {
    printf("Valid Number: %s\n", yytext);
}

[+\-*/=] {
    printf("Valid Operator: %s\n", yytext);
}

[;,()] {
    printf("Valid Separator: %s\n", yytext);
}

[ \t\n]+ {
    ;
}

. {
    printf("Lexical Error: Invalid character '%s'\n", yytext);
}

%%

int main()
{
    printf("Enter input string:\n");
    yylex();

    return 0;
}

int yywrap()
{
    return 1;
}
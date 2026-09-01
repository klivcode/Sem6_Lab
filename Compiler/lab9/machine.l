%{
#include <stdio.h>
#include <string.h>

char lhs[20];
char arg1[20];
char arg2[20];
char op;

int count = 0;
%}

%%

[a-zA-Z][a-zA-Z0-9]* {
    if(count == 0)
        strcpy(lhs, yytext);
    else if(count == 1)
        strcpy(arg1, yytext);
    else
        strcpy(arg2, yytext);

    count++;
}

= {
    ;
}

[+*/-] {
    op = yytext[0];
}

[ \t]+ {
    ;
}

\n {
    printf("\nSimplified Machine Code:\n");

    printf("MOV R0, %s\n", arg1);

    switch(op)
    {
        case '+':
            printf("ADD R0, %s\n", arg2);
            break;

        case '-':
            printf("SUB R0, %s\n", arg2);
            break;

        case '*':
            printf("MUL R0, %s\n", arg2);
            break;

        case '/':
            printf("DIV R0, %s\n", arg2);
            break;
    }

    printf("MOV %s, R0\n", lhs);

    return 0;
}

. {
    ;
}

%%

int main()
{
    printf("Enter three-address code: ");
    yylex();

    return 0;
}

int yywrap()
{
    return 1;
}
%{
#include <stdio.h>
#include <string.h>

char stack[100][20];
int top = -1;
int temp = 1;

void push(char *str)
{
    strcpy(stack[++top], str);
}

char* pop()
{
    return stack[top--];
}

void generate(char op)
{
    char *a, *b;
    char result[20];

    a = pop();
    b = pop();

    sprintf(result, "t%d", temp++);

    printf("%s = %s %c %s\n", result, b, op, a);

    push(result);
}
%}

%%

[0-9]+|[a-zA-Z]+    { push(yytext); }

[+]                 { generate('+'); }
[-]                 { generate('-'); }
[*]                 { generate('*'); }
[/]                 { generate('/'); }

[ \t\n]+            ;

.                   ;

%%

int main()
{
    printf("Enter postfix expression: ");
    yylex();

    return 0;
}

int yywrap()
{
    return 1;
}

%{
#include <stdio.h>
#include <stdlib.h>

int value[26];
int constant[26] = {0};

void process(char *s)
{
    char x, y, z, op;
    int a, b, result;

    if (sscanf(s, " %c = %d", &x, &a) == 2)
    {
        value[x-'a'] = a;
        constant[x-'a'] = 1;

        printf("%c = %d\n", x, a);
    }
    else if (sscanf(s, " %c = %c %c %c",
                    &x, &y, &op, &z) == 4)
    {
        if (constant[y-'a'] && constant[z-'a'])
        {
            a = value[y-'a'];
            b = value[z-'a'];

            printf("\nConstant Propagation:\n");
            printf("%c = %d %c %d\n", x, a, op, b);

            switch(op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
                default:
                    printf("Invalid operator\n");
                    return;
            }

            printf("Constant Folding:\n");
            printf("%c = %d\n", x, result);

            value[x-'a'] = result;
            constant[x-'a'] = 1;
        }
        else
        {
            printf("%s\n", s);
        }
    }
    else
    {
        printf("Invalid statement: %s\n", s);
    }
}

%}

%%

.*\n       { process(yytext); }

%%

int yywrap()
{
    return 1;
}

int main()
{
    printf("Enter intermediate code:\n");
    yylex();

    return 0;
}

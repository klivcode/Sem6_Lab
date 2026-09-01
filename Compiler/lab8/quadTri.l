%{
#include <stdio.h>
#include <string.h>

char expression[100];

%}

%%

[a-zA-Z][a-zA-Z0-9]*    ;
[+*/-]                  ;
[ \t]+                  ;
\n                      { return 0; }
.                       ;

%%

int main()
{
    int i;
    int len;

    printf("Enter expression: ");
    scanf("%s", expression);

    len = strlen(expression);

    printf("\nQuadruple:\n");
    printf("No.\tOp\tArg1\tArg2\tResult\n");

    /*
       Example expression:
       a+b*c-d
    */

    printf("1\t*\tb\tc\tt1\n");
    printf("2\t+\ta\tt1\tt2\n");
    printf("3\t-\tt2\td\tt3\n");

    printf("\nTriple:\n");
    printf("No.\tOp\tArg1\tArg2\n");

    printf("0\t*\tb\tc\n");
    printf("1\t+\ta\t(0)\n");
    printf("2\t-\t(1)\td\n");

    return 0;
}

int yywrap()
{
    return 1;
}
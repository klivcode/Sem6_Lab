%{
#include <stdio.h>
#include <string.h>

char original[100];
%}

%%

[0-9]+    { strcpy(original, yytext); }
\n        { return 0; }
.         ;

%%

int main()
{
    printf("Enter a number: ");
    yylex();

    int length = strlen(original);
    int palindrome = 1;

    for(int i = 0; i < length / 2; i++)
    {
        if(original[i] != original[length - 1 - i])
        {
            palindrome = 0;
            break;
        }
    }

    if(palindrome)
        printf("%s is a Palindrome\n", original);
    else
        printf("%s is not a Palindrome\n", original);

    return 0;
}

int yywrap()
{
    return 1;
}
%{
#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define MAX 100

char expression[MAX];
char prefix[MAX];

int pos = 0;

char stack[MAX];
int top = -1;

int valueStack[MAX];
int valueTop = -1;

int precedence(char ch)
{
    if(ch == '*' || ch == '/')
        return 2;

    if(ch == '+' || ch == '-')
        return 1;

    return 0;
}

void push(char ch)
{
    stack[++top] = ch;
}

char pop()
{
    return stack[top--];
}

void reverse(char str[])
{
    int i, j;
    char temp;

    j = strlen(str) - 1;

    for(i = 0; i < j; i++, j--)
    {
        temp = str[i];
        str[i] = str[j];
        str[j] = temp;
    }
}

void infixToPrefix()
{
    char temp[MAX];
    int i, j = 0;
    char ch;

    strcpy(temp, expression);

    /* Reverse the expression */
    reverse(temp);

    /* Interchange brackets */
    for(i = 0; temp[i] != '\0'; i++)
    {
        if(temp[i] == '(')
            temp[i] = ')';
        else if(temp[i] == ')')
            temp[i] = '(';
    }

    top = -1;

    for(i = 0; temp[i] != '\0'; i++)
    {
        ch = temp[i];

        /* Operand */
        if(isdigit(ch))
        {
            prefix[j++] = ch;
        }

        /* Opening bracket */
        else if(ch == '(')
        {
            push(ch);
        }

        /* Closing bracket */
        else if(ch == ')')
        {
            while(top != -1 && stack[top] != '(')
            {
                prefix[j++] = pop();
            }

            if(top != -1)
                pop();
        }

        /* Operator */
        else
        {
            while(top != -1 &&
                  stack[top] != '(' &&
                  precedence(stack[top]) > precedence(ch))
            {
                prefix[j++] = pop();
            }

            push(ch);
        }
    }

    while(top != -1)
    {
        prefix[j++] = pop();
    }

    prefix[j] = '\0';

    /* Reverse postfix to obtain prefix */
    reverse(prefix);
}

int evaluatePrefix()
{
    int i;
    int a, b;

    valueTop = -1;

    /* Prefix is evaluated from right to left */
    for(i = strlen(prefix) - 1; i >= 0; i--)
    {
        if(isdigit(prefix[i]))
        {
            valueStack[++valueTop] = prefix[i] - '0';
        }
        else
        {
            a = valueStack[valueTop--];
            b = valueStack[valueTop--];

            switch(prefix[i])
            {
                case '+':
                    valueStack[++valueTop] = a + b;
                    break;

                case '-':
                    valueStack[++valueTop] = a - b;
                    break;

                case '*':
                    valueStack[++valueTop] = a * b;
                    break;

                case '/':
                    valueStack[++valueTop] = a / b;
                    break;
            }
        }
    }

    return valueStack[valueTop];
}
%}

%%

[0-9]      { expression[pos++] = yytext[0]; }

[+\-*/]    { expression[pos++] = yytext[0]; }

[()]       { expression[pos++] = yytext[0]; }

[ \t]      ;

\n         {
              expression[pos] = '\0';
              return 0;
           }

.          ;

%%

int main()
{
    printf("Enter infix expression: ");

    yylex();

    infixToPrefix();

    printf("\nInfix Expression  : %s", expression);
    printf("\nPrefix Expression : %s", prefix);
    printf("\nResult             : %d\n", evaluatePrefix());

    return 0;
}

int yywrap()
{
    return 1;
}
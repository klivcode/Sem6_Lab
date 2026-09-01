#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define MAX 100

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

void infixToPrefix(char infix[], char prefix[])
{
    char temp[MAX];
    int i, j = 0;
    char ch;

    strcpy(temp, infix);

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

        if(isdigit(ch))
        {
            prefix[j++] = ch;
        }
        else if(ch == '(')
        {
            push(ch);
        }
        else if(ch == ')')
        {
            while(top != -1 && stack[top] != '(')
                prefix[j++] = pop();

            if(top != -1)
                pop();
        }
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
        prefix[j++] = pop();

    prefix[j] = '\0';

    reverse(prefix);
}

int evaluatePrefix(char prefix[])
{
    int i;
    int a, b;

    valueTop = -1;

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

int main()
{
    char infix[MAX];
    char prefix[MAX];

    printf("Enter infix expression: ");
    scanf("%s", infix);

    infixToPrefix(infix, prefix);

    printf("\nPrefix Expression = %s", prefix);

    printf("\nResult = %d\n",
           evaluatePrefix(prefix));

    return 0;
}
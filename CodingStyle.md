# Introduction #

This document describes the code guidelines for SharpDoom Milestone 1. Be sure to read it carefully and stick to the guidelines.

# Details #

## File Names ##

Ported file names should be equal to the ones in the Doom source

| m\_argv.c -> m\_argv.cs |
|:------------------------|

## Brackets ##

Backets should be on a newline after the function declaration:

```
void func()
{
    //code here
}
```

## Variable Names ##

Variable names should be comprehensible and easy to understand. They must start with a undercase letter or a underscore (for private variables in a class). They should be similar to the ones in the original Doom souce code.

```
int myVariable;

class Test
{
   private int _variable = 0;
   //more code
}
```
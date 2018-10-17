#include "stdafx.h"

// Crash if the sum is even
int Add(int a, int b)
{
	int c = 0;
	int* ip = NULL;

	c = a + b;

	if (c % 2 == 0)
	{
		*ip = a;
	}
	else
	{
		ip = (int*)malloc(sizeof(int));
		*ip = a;
	}

	if (ip != NULL)
		free(ip);

	return c;
}
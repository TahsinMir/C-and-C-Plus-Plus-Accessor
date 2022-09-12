#include "SampleCppGlue.h"

SampleCpp* CreateInstaceGeneric()
{
	return new SampleCpp();
}

char* TestFunction(SampleCpp* instance, const char* x)
{
	if (instance != NULL)
	{
		return instance->TestFunction(x);
	}

	return NULL;
}
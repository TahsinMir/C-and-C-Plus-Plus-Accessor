#include "SampleCppGlue.h"

SampleCpp* CreateInstaceGeneric()
{
	return new SampleCpp();
}

void VoidTest(SampleCpp* instance, const char* key)
{
	if (instance != NULL)
	{
		instance->VoidTest(key);
	}

	return;
}

char* TestFunction(SampleCpp* instance, const char* x)
{
	if (instance != NULL)
	{
		return instance->TestFunction(x);
	}

	return NULL;
}
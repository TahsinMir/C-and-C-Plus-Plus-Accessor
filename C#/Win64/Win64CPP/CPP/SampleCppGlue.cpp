#include "pch.h"
#include "SampleCppGlue.h"


SampleCpp* CreateInstaceWin64()
{
    return new SampleCpp();
}

int IntegerManipulation(SampleCpp* instance, int x, int y)
{
    if (instance != NULL)
    {
        return instance->IntegerManipulation(x, y);
    }
    return -1;
}


BSTR ReturnAString(SampleCpp* instance)
{
    if (instance != NULL)
    {
        return SysAllocString(instance->ReturnAString());
    }
    return NULL;
}
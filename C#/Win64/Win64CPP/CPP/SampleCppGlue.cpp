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

float FloatManipulation (SampleCpp* instance, float x, float y)
{
    if (instance != NULL)
    {
        return instance->FloatManipulation(x, y);
    }
    return -0.1;
}


BSTR StringManipulation(SampleCpp* instance, BSTR x, BSTR y)
{
    if (instance != NULL)
    {
        return SysAllocString(instance->StringManipulation(x, y));
    }
    return SysAllocString(L"FAIL");
}
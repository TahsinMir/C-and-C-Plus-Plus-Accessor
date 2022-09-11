#pragma once
#include "SampleCpp.h"
#include <comutil.h>


#ifdef __cplusplus
extern "C" {
#endif

	extern __declspec(dllexport) SampleCpp* CreateInstaceWin64();

	extern __declspec(dllexport) int IntegerManipulation(SampleCpp* instance, int x, int y);

	extern __declspec(dllexport) BSTR ReturnAString(SampleCpp* instance);

#ifdef __cplusplus
}
#endif
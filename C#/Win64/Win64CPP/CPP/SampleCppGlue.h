#pragma once
#include "SampleCpp.h"
#include <comutil.h>


#ifdef __cplusplus
extern "C" {
#endif

	extern __declspec(dllexport) SampleCpp* CreateInstaceWin64();

	extern __declspec(dllexport) int IntegerManipulation(SampleCpp* instance, int x, int y);
	extern __declspec(dllexport) float FloatManipulation(SampleCpp* instance, float x, float y);
	extern __declspec(dllexport) BSTR StringManipulation(SampleCpp* instance, BSTR x, BSTR y);

#ifdef __cplusplus
}
#endif
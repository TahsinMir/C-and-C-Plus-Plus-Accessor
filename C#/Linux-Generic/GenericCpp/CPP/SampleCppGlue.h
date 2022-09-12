#pragma once
#include "SampleCpp.h"

#ifdef __cplusplus

extern "C" {

#endif



	extern __attribute__((visibility("default"))) SampleCpp* CreateInstaceGeneric();

	extern __attribute__((visibility("default"))) void VoidTest(SampleCpp* instance, const char* key);
	extern __attribute__((visibility("default"))) char* TestFunction(SampleCpp* instance, const char* x);


#ifdef __cplusplus

}

#endif
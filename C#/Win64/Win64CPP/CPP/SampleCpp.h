#pragma once
#include <iostream>
#include <comutil.h>
#include <map>
#include <locale>
#include <codecvt>
#include <atlcomcli.h>
using namespace std;
class __declspec(dllexport)  SampleCpp
{
public:
	SampleCpp();
	~SampleCpp();
	int IntegerManipulation(int x, int y);
	float FloatManipulation(float x, float y);
	BSTR StringManipulation(BSTR x, BSTR y);
};


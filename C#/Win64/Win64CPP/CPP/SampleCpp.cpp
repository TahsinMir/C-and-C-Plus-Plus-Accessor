#include "pch.h"
#include "SampleCpp.h"


SampleCpp::SampleCpp()
{

}

SampleCpp::~SampleCpp()
{

}

int SampleCpp::IntegerManipulation(int x, int y)
{
	int result = x + y;
	return result;
}

BSTR SampleCpp::ReturnAString()
{
	return SysAllocString(L"THIS IS WORKING");
}
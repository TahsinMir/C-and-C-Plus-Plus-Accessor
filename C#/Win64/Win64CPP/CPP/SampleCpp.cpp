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

float SampleCpp::FloatManipulation(float x, float y)
{
	float result = x + y;
	return result;
}

BSTR SampleCpp::StringManipulation(BSTR x, BSTR y)
{
	// insert as wstring
	assert(x != nullptr);
	std::wstring xWStr(x);

	assert(y != nullptr);
	std::wstring yWStr(y);

	// convert to c++ string
	//setup converter
	using convert_type = std::codecvt_utf8<wchar_t>;
	std::wstring_convert<convert_type, wchar_t> converter;


	std::string xStr = converter.to_bytes(x);
	std::string yStr = converter.to_bytes(y);

	std::string result = xStr + yStr;
	std::wstring wResult = converter.from_bytes(result);

	BSTR resultBstr = SysAllocStringLen(wResult.data(), wResult.size());
	return resultBstr;
}
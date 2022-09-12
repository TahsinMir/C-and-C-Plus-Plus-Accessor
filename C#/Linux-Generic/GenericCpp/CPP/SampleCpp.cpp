#include "SampleCpp.h"

SampleCpp::SampleCpp()

{

}



SampleCpp::~SampleCpp()

{

}

char* SampleCpp::TestFunction(const char* x)
{
    //get std::string
    std::string xStr = x;

    std::string result = xStr + xStr;
    char* resultCharArr = &result[0];
    return resultCharArr;
}
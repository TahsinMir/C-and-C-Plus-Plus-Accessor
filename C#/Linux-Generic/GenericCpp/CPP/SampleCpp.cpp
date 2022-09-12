#include "SampleCpp.h"

SampleCpp::SampleCpp()

{

}



SampleCpp::~SampleCpp()

{

}

void SampleCpp::VoidTest(const char* key)
{
    // get std:: string
    std::string keyStr = key;
    cout<<keyStr<<endl;
    cout<<"void test"<<endl;
}

char* SampleCpp::TestFunction(const char* x)
{
    //get std::string
    std::string xStr = x;

    std::string result = xStr + xStr;
    
    strResponse = result;
    strResponsePtr = &strResponse[0];
    return strResponsePtr;
    /*for (int i=0;i<result.size();i++)
    {
        cout<<resultCharArr[i]<<endl;
    }*/
    // return resultCharArr;
}
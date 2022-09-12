#pragma once
#include <iostream>
#include <locale>
#include <codecvt>

using namespace std;

class __attribute__((visibility("default"))) SampleCpp

{

public:

    SampleCpp();

    ~SampleCpp();

    void VoidTest(const char* key);

    char* TestFunction(const char* x);

private:
    std::string strResponse;
    char* strResponsePtr;    // string response must hold in an instance variable since returning a local varialbe will destroy the value as soon as the function returns
};
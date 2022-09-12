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

    char* TestFunction(const char* x);
};
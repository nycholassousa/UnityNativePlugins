# Unity Native Plugins
This repository contains my progress in developing native Plugins for Unity

## Using
- Visual Studio Community 2015 to create native plugin
- Visual Studio Community 2017 to create the .cs file (I'll work to use one visual studio)
- Unity 2017.3.1f1 to run the plugin

## How to Compile - Native Plugin
### Linux
```sh
g++ -c -Wall -Werror -fpic File.cpp
g++ -shared -o File.so File.o
```

### Windows
Just compile the solution

## How to Run your .cs File
Open unity, drag the file to some object (e.g., Main Camera), then run your project

## Macro to create a shared lib
```cpp
#if defined(_MSC_VER) 	//  Microsoft 
	#define EXPORT __declspec(dllexport)
	#define IMPORT __declspec(dllimport)
#elif defined(__GNUC__)	//  GCC
	#define EXPORT __attribute__((visibility("default")))
	#define IMPORT
#else 	// do nothing and hope for the best?
	#define EXPORT
	#define IMPORT
	#pragma warning Unknown dynamic link import/export semantics.
#endif
```

## Observations
- I'm always compiling as x64
- Possibly some .dlls/.so have different names when compiled, so check the .cs file
// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the DUMMY_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// DUMMY_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef DUMMY_EXPORTS
#define DUMMY_API __declspec(dllexport)
#else
#define DUMMY_API __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C" {
#endif

typedef void* (*delegateType) (void* ptr);

DUMMY_API void* jni4net_zero();

DUMMY_API void* jni4net_dummy(void* ptr);

DUMMY_API delegateType jni4net_gimme();

DUMMY_API void* jni4net_callme(delegateType deledatePtr, void* ptr);

#ifdef __cplusplus
}
#endif

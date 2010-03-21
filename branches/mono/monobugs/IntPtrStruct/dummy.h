#ifndef _jni4net_dummy
#define _jni4net_dummy
#ifdef __cplusplus
extern "C" {
#endif

typedef void* (*delegateType) (void* ptr);

void* jni4net_zero();

void* jni4net_dummy(void* ptr);

delegateType jni4net_gimme();

void* jni4net_callme(delegateType deledatePtr, void* ptr);


#ifdef __cplusplus
}
#endif
#endif

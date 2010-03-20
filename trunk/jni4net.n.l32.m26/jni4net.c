#include "jni4net.h"
#include <stdio.h>
#include <mono/jit/jit.h>
#include <mono/metadata/object.h>

int Java_net_sf_jni4net_Bridge_initDotNet(JNIEnv *env, jclass clazz)
{
	const char* file="/home/rupert/jni4net/trunk/jni4net.tested.n/target/jni4net.n-0.8.0.0.dll";
	MonoDomain *domain;

	domain = mono_jit_init (file);
	if (!domain)
		return 1;

	MonoAssembly *assembly;
	assembly = mono_domain_assembly_open (domain, file);
	if (!assembly)
		return 2;
		
	MonoImage *image;	
	image = mono_assembly_get_image (assembly);
	if (!image)
		return 3;

	MonoClass *klass;
	klass = mono_class_from_name (image, "net.sf.jni4net", "Bridge");
	if (!klass)
		return 4;
		
	MonoMethod *method;
	method = mono_class_get_method_from_name_flags (klass, "initDotNetImpl", 2, 32+8);
	if (!method)
		return 5;
	
	MonoObject* res;//int
	gpointer args [2];
	args [0] = &env;
	args [1] = &clazz;
	res = mono_runtime_invoke (method, NULL, args, NULL);

	return *(int*)mono_object_unbox (res);
}

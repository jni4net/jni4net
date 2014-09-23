Warning: This is not newbie topic and the sample may be obsolete.

This sample wraps Drools - business rules engine
---

[Drools](http://www.jboss.org/drools)

Original tutorial is part of drools distribution.
[tutorial](http://docs.redhat.com/docs/en-US/JBoss_Enterprise_BRMS_Platform/5/html/JBoss_Rules_5_Reference_Guide/chap-examples.html#id3830093)

Folders:
```
lib - contains drools jar files and dependencies, download it from internet please
				antlr-runtime-3.1.3.jar
				drools-api-5.1.1.jar
				drools-compiler-5.1.1.jar
				drools-core-5.1.1.jar
				drools-decisiontables-5.1.1.jar
				ecj-3.5.1.jar
				jaxb-api-2.2.1.jar
				jaxb-xjc-2.2.1.1.jar
				mvel2-2.0.16.jar
				xstream-1.3.1.jar
drools-api-5.1.1.j4n - I used proxygen to generate wrapper around drools-api-5.1.1.jar
domain               - I translated fact object from drools tutorial to C#, there is 
                       dependency to jni4net because of java.util.Date, otherwise it's 
                       independent domain.
domain.j4n           - I used proxygen to generate wrapper around domain above. This is 
                       necessary to make the domain visible to drools engine on 
                       Java side.
examples             - I translated the drools tutorial from Java to C#. 
                       This is main program to run.
```
            
Notes
---
I had to hack few files, because proxygen is not yet smart enough.
Particulary in domain.j4n, the C# constants are not generated into Java proxies by proxygen.
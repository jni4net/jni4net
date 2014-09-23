Warning: This is not newbie topic and the sample is probably convoluted.

Shows how to incrementaly build classes which use each other. 
---

1) go thru directories `circular1` - `circular7`
2) in each directory see what are inputs and run batches `build1.cmd` - `build7.cmd`
3) after each build script some artifac will be generated. Review it.
4) when you reach `circular7/build7.cmd` look into `circular7/target` there will be final products: `circular.dll`, `circular.jar`

Whole sample flat looks like this. A uses B, B uses A.
When we start A.main() we will get "m1 called" twice. 
Once from instance passed to C# and second from instance creadted in C#.

Java 
---

```
public interface IA {
  void m1();
}

public interface IB {
  void m2(IA a);
}

public class A implements IA {
  public void m1()
  {
     System.out.println("m1 called");
  }

  public static void main(String args[]) throws java.io.IOException
  {
     net.sf.jni4net.Bridge.init();
     net.sf.jni4net.Bridge.LoadAndRegisterAssembly("circular.dll");
     
     IB b = new B();
     b.m2(new A());
  }
}
```

C# 
---

```
public class B: IB
{
  public void m2(IA a)
  {
     a.m1();

     A a2=new A();
     a2.m1();
  }
}
```
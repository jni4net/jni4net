package j4n;

public class A implements IA
{
  public void m1()
  {
     System.out.println("m1 called");
  }

  public static void main(String args[]) throws java.io.IOException
  {
     net.sf.jni4net.Bridge.init();
     net.sf.jni4net.Bridge.LoadAndRegisterAssemblyFrom(new java.io.File("target/circular.dll"));
     
     IB b = new B();
     b.m2(new A());
  }
}

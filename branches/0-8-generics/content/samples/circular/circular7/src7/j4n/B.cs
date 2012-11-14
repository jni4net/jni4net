namespace j4n
{
	public class B: IB
	{
	  public void m2(IA a)
	  {
	     a.m1();

       // now we closed circle	     
	     A a2=new A();
	     a2.m1();
	  }
  }	
}
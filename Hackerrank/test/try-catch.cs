using System;
using System.IO;

public class Answer
{
    /// Executes the service with the given​​​​​​‌​​​‌​​‌​‌​‌‌​‌​‌​​‌​‌‌​‌ connection.
    public void Run(Service s, Connection c)
    {
        try {
    	    s.SetConnection(c);
		    s.Execute();
		    c.Commit();
        }
        catch (Exception ex) {
            c.Rollback();
            throw ex;
        }
        finally {
            c.Close();
        }
	}
}

/// Definition of a service
public interface Service
{
	void Execute();
	void SetConnection(Connection c);
}

/// Definition of a connection
public interface Connection
{
	void Commit();
	void Rollback();
	void Close();
}


public static void Main(String[] args) {
  new Answer().Run(new MyService(), new MyConnection());
}

class MyService : Service
{
    public void Execute() { Console.WriteLine("Execute"); }
    public void SetConnection(Connection c) { Console.WriteLine("SetConnection"); }
}

class MyConnection : Connection
{
    public void Rollback() { Console.WriteLine("Rollback"); }
	public void Commit() { Console.WriteLine("Commit"); }
	public void Close() { Console.WriteLine("Close"); }
}






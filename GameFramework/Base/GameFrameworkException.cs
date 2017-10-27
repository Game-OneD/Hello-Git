using System;

namespace GameFramework
{



}

public class GameFrameworkException : Exception
{
    public GameFrameworkException() : base()
    {

    }

    public GameFrameworkException(string message) : base(message)
    {

    }

    public GameFrameworkException(string message, Exception innerException) : base(message, innerException)
    {

    }    
}

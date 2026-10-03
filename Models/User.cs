namespace auth30.Models;
public class User
{
    public int Id {get;set;}
    public string? UserName{get;set;}
    public string? HashedPassword{get;set;}
    public int Solved{get;set;}
    public int Attempt{get;set;}
    }
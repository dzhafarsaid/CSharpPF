using System;

namespace CSharpPFCursus.model;

public interface IKost
{
    public bool Menselijk {get;}
    public decimal BerekenKostprijs();
}

using System;

namespace Firma;

public interface IKost
{
    public bool Menselijk {get;}
    public decimal BerekenKostprijs();
}

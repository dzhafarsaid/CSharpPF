using System;

namespace CSharpPFOefeningen.model;

public class Stookketel : IVervuiler
{
    public Stookketel( float cONorm)
    {
        CONorm = cONorm;
    }
    private float cONorm;
    public float CONorm
    {
        get => cONorm;
        set { if (value>0f) cONorm = value;}
    }
    public double GeefVervuiling()
    {
        return cONorm * 100;
    }
}

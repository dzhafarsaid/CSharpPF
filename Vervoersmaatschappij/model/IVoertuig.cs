using System;

namespace Vervoersmaatschappij.model;

public interface IVoertuig
{
    public string InfoTonen();
    public decimal Operationelekosten {get;}
}

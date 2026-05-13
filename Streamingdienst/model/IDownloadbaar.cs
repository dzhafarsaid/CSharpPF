using System;

namespace Streamingdienst.model;

public interface IDownloadbaar
{
    public string Downloaden();
    public decimal BestandsgrootteInGB {get;}
}

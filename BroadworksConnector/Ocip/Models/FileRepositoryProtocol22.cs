using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// File repository protocol.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum FileRepositoryProtocol22
    {
        [XmlEnum(Name = "WebDAV")]
        WebDAV,
        [XmlEnum(Name = "FTP")]
        FTP,
        [XmlEnum(Name = "FTPS")]
        FTPS,
        [XmlEnum(Name = "SFTP")]
        SFTP,
    }
}

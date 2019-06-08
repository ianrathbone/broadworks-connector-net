using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationAddClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _securityClassificationName;

    [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
    public string SecurityClassificationName {
        get => _securityClassificationName;
        set {
            SecurityClassificationNameSpecified = true;
            _securityClassificationName = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
}
}

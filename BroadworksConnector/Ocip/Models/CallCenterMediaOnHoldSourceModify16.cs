using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceModify16 
{
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection {
        get => _audioMessageSourceSelection;
        set {
            AudioMessageSourceSelectionSpecified = true;
            _audioMessageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioMessageSourceSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify _externalAudioSource;

    [XmlElement(ElementName = "externalAudioSource", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalAudioSource {
        get => _externalAudioSource;
        set {
            ExternalAudioSourceSpecified = true;
            _externalAudioSource = value;
        }
    }

    [XmlIgnore]
    public bool ExternalAudioSourceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection {
        get => _videoMessageSourceSelection;
        set {
            VideoMessageSourceSelectionSpecified = true;
            _videoMessageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoMessageSourceSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify _externalVideoSource;

    [XmlElement(ElementName = "externalVideoSource", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalVideoSource {
        get => _externalVideoSource;
        set {
            ExternalVideoSourceSpecified = true;
            _externalVideoSource = value;
        }
    }

    [XmlIgnore]
    public bool ExternalVideoSourceSpecified { get; set; }
}
}
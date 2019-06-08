using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantReadMenu 
{
    private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

    [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection {
        get => _announcementSelection;
        set {
            AnnouncementSelectionSpecified = true;
            _announcementSelection = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementSelectionSpecified { get; set; }
    private string _audioFileDescription;

    [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
    public string AudioFileDescription {
        get => _audioFileDescription;
        set {
            AudioFileDescriptionSpecified = true;
            _audioFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileDescriptionSpecified { get; set; }
    private string _videoFileDescription;

    [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
    public string VideoFileDescription {
        get => _videoFileDescription;
        set {
            VideoFileDescriptionSpecified = true;
            _videoFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileDescriptionSpecified { get; set; }
    private bool _enableFirstMenuLevelExtensionDialing;

    [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false, Namespace = "")]
    public bool EnableFirstMenuLevelExtensionDialing {
        get => _enableFirstMenuLevelExtensionDialing;
        set {
            EnableFirstMenuLevelExtensionDialingSpecified = true;
            _enableFirstMenuLevelExtensionDialing = value;
        }
    }

    [XmlIgnore]
    public bool EnableFirstMenuLevelExtensionDialingSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration> _keyConfiguration;

    [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration> KeyConfiguration {
        get => _keyConfiguration;
        set {
            KeyConfigurationSpecified = true;
            _keyConfiguration = value;
        }
    }

    [XmlIgnore]
    public bool KeyConfigurationSpecified { get; set; }
}
}

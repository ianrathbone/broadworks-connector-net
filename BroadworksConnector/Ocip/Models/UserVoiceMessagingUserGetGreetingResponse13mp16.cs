using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetGreetingResponse13mp16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection {
        get => _busyAnnouncementSelection;
        set {
            BusyAnnouncementSelectionSpecified = true;
            _busyAnnouncementSelection = value;
        }
    }

    [XmlIgnore]
    public bool BusyAnnouncementSelectionSpecified { get; set; }
    private string _busyPersonalAudioFile;

    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false, Namespace = "")]
    public string BusyPersonalAudioFile {
        get => _busyPersonalAudioFile;
        set {
            BusyPersonalAudioFileSpecified = true;
            _busyPersonalAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool BusyPersonalAudioFileSpecified { get; set; }
    private string _busyPersonalVideoFile;

    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false, Namespace = "")]
    public string BusyPersonalVideoFile {
        get => _busyPersonalVideoFile;
        set {
            BusyPersonalVideoFileSpecified = true;
            _busyPersonalVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool BusyPersonalVideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection _noAnswerAnnouncementSelection;

    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection {
        get => _noAnswerAnnouncementSelection;
        set {
            NoAnswerAnnouncementSelectionSpecified = true;
            _noAnswerAnnouncementSelection = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAnnouncementSelectionSpecified { get; set; }
    private string _noAnswerPersonalAudioFile;

    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false, Namespace = "")]
    public string NoAnswerPersonalAudioFile {
        get => _noAnswerPersonalAudioFile;
        set {
            NoAnswerPersonalAudioFileSpecified = true;
            _noAnswerPersonalAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerPersonalAudioFileSpecified { get; set; }
    private string _noAnswerPersonalVideoFile;

    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false, Namespace = "")]
    public string NoAnswerPersonalVideoFile {
        get => _noAnswerPersonalVideoFile;
        set {
            NoAnswerPersonalVideoFileSpecified = true;
            _noAnswerPersonalVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerPersonalVideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead _noAnswerAlternateGreeting01;

    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting01 {
        get => _noAnswerAlternateGreeting01;
        set {
            NoAnswerAlternateGreeting01Specified = true;
            _noAnswerAlternateGreeting01 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting01Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead _noAnswerAlternateGreeting02;

    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting02 {
        get => _noAnswerAlternateGreeting02;
        set {
            NoAnswerAlternateGreeting02Specified = true;
            _noAnswerAlternateGreeting02 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting02Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead _noAnswerAlternateGreeting03;

    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting03 {
        get => _noAnswerAlternateGreeting03;
        set {
            NoAnswerAlternateGreeting03Specified = true;
            _noAnswerAlternateGreeting03 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting03Specified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
}
}
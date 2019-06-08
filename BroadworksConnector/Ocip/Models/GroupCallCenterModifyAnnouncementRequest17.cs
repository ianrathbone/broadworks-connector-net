using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAnnouncementRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _playEntranceMessage;

    [XmlElement(ElementName = "playEntranceMessage", IsNullable = false, Namespace = "")]
    public bool PlayEntranceMessage {
        get => _playEntranceMessage;
        set {
            PlayEntranceMessageSpecified = true;
            _playEntranceMessage = value;
        }
    }

    [XmlIgnore]
    public bool PlayEntranceMessageSpecified { get; set; }
    private bool _mandatoryEntranceMessage;

    [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false, Namespace = "")]
    public bool MandatoryEntranceMessage {
        get => _mandatoryEntranceMessage;
        set {
            MandatoryEntranceMessageSpecified = true;
            _mandatoryEntranceMessage = value;
        }
    }

    [XmlIgnore]
    public bool MandatoryEntranceMessageSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceAudioMessageSelection;

    [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection {
        get => _entranceAudioMessageSelection;
        set {
            EntranceAudioMessageSelectionSpecified = true;
            _entranceAudioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool EntranceAudioMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _entranceMessageAudioUrlList;

    [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageAudioUrlList {
        get => _entranceMessageAudioUrlList;
        set {
            EntranceMessageAudioUrlListSpecified = true;
            _entranceMessageAudioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageAudioUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _entranceMessageAudioFileList;

    [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageAudioFileList {
        get => _entranceMessageAudioFileList;
        set {
            EntranceMessageAudioFileListSpecified = true;
            _entranceMessageAudioFileList = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageAudioFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _entranceVideoMessageSelection;

    [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection {
        get => _entranceVideoMessageSelection;
        set {
            EntranceVideoMessageSelectionSpecified = true;
            _entranceVideoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool EntranceVideoMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _entranceMessageVideoUrlList;

    [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageVideoUrlList {
        get => _entranceMessageVideoUrlList;
        set {
            EntranceMessageVideoUrlListSpecified = true;
            _entranceMessageVideoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageVideoUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _entranceMessageVideoFileList;

    [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageVideoFileList {
        get => _entranceMessageVideoFileList;
        set {
            EntranceMessageVideoFileListSpecified = true;
            _entranceMessageVideoFileList = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageVideoFileListSpecified { get; set; }
    private bool _playPeriodicComfortMessage;

    [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false, Namespace = "")]
    public bool PlayPeriodicComfortMessage {
        get => _playPeriodicComfortMessage;
        set {
            PlayPeriodicComfortMessageSpecified = true;
            _playPeriodicComfortMessage = value;
        }
    }

    [XmlIgnore]
    public bool PlayPeriodicComfortMessageSpecified { get; set; }
    private int _timeBetweenComfortMessagesSeconds;

    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
    public int TimeBetweenComfortMessagesSeconds {
        get => _timeBetweenComfortMessagesSeconds;
        set {
            TimeBetweenComfortMessagesSecondsSpecified = true;
            _timeBetweenComfortMessagesSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortAudioMessageSelection;

    [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection {
        get => _periodicComfortAudioMessageSelection;
        set {
            PeriodicComfortAudioMessageSelectionSpecified = true;
            _periodicComfortAudioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortAudioMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _periodicComfortMessageAudioUrlList;

    [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageAudioUrlList {
        get => _periodicComfortMessageAudioUrlList;
        set {
            PeriodicComfortMessageAudioUrlListSpecified = true;
            _periodicComfortMessageAudioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageAudioUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _periodicComfortMessageAudioFileList;

    [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageAudioFileList {
        get => _periodicComfortMessageAudioFileList;
        set {
            PeriodicComfortMessageAudioFileListSpecified = true;
            _periodicComfortMessageAudioFileList = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageAudioFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _periodicComfortVideoMessageSelection;

    [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection {
        get => _periodicComfortVideoMessageSelection;
        set {
            PeriodicComfortVideoMessageSelectionSpecified = true;
            _periodicComfortVideoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortVideoMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _periodicComfortMessageVideoUrlList;

    [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageVideoUrlList {
        get => _periodicComfortMessageVideoUrlList;
        set {
            PeriodicComfortMessageVideoUrlListSpecified = true;
            _periodicComfortMessageVideoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageVideoUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _periodicComfortMessageVideoFileList;

    [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageVideoFileList {
        get => _periodicComfortMessageVideoFileList;
        set {
            PeriodicComfortMessageVideoFileListSpecified = true;
            _periodicComfortMessageVideoFileList = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageVideoFileListSpecified { get; set; }
    private bool _enableMediaOnHoldForQueuedCalls;

    [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false, Namespace = "")]
    public bool EnableMediaOnHoldForQueuedCalls {
        get => _enableMediaOnHoldForQueuedCalls;
        set {
            EnableMediaOnHoldForQueuedCallsSpecified = true;
            _enableMediaOnHoldForQueuedCalls = value;
        }
    }

    [XmlIgnore]
    public bool EnableMediaOnHoldForQueuedCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 _mediaOnHoldSource;

    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 MediaOnHoldSource {
        get => _mediaOnHoldSource;
        set {
            MediaOnHoldSourceSpecified = true;
            _mediaOnHoldSource = value;
        }
    }

    [XmlIgnore]
    public bool MediaOnHoldSourceSpecified { get; set; }
    private bool _mediaOnHoldUseAlternateSourceForInternalCalls;

    [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
    public bool MediaOnHoldUseAlternateSourceForInternalCalls {
        get => _mediaOnHoldUseAlternateSourceForInternalCalls;
        set {
            MediaOnHoldUseAlternateSourceForInternalCallsSpecified = true;
            _mediaOnHoldUseAlternateSourceForInternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool MediaOnHoldUseAlternateSourceForInternalCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 _mediaOnHoldInternalSource;

    [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 MediaOnHoldInternalSource {
        get => _mediaOnHoldInternalSource;
        set {
            MediaOnHoldInternalSourceSpecified = true;
            _mediaOnHoldInternalSource = value;
        }
    }

    [XmlIgnore]
    public bool MediaOnHoldInternalSourceSpecified { get; set; }
    private bool _playWhisperMessage;

    [XmlElement(ElementName = "playWhisperMessage", IsNullable = false, Namespace = "")]
    public bool PlayWhisperMessage {
        get => _playWhisperMessage;
        set {
            PlayWhisperMessageSpecified = true;
            _playWhisperMessage = value;
        }
    }

    [XmlIgnore]
    public bool PlayWhisperMessageSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperAudioMessageSelection;

    [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperAudioMessageSelection {
        get => _whisperAudioMessageSelection;
        set {
            WhisperAudioMessageSelectionSpecified = true;
            _whisperAudioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool WhisperAudioMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _whisperMessageAudioUrlList;

    [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageAudioUrlList {
        get => _whisperMessageAudioUrlList;
        set {
            WhisperMessageAudioUrlListSpecified = true;
            _whisperMessageAudioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool WhisperMessageAudioUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _whisperMessageAudioFileList;

    [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageAudioFileList {
        get => _whisperMessageAudioFileList;
        set {
            WhisperMessageAudioFileListSpecified = true;
            _whisperMessageAudioFileList = value;
        }
    }

    [XmlIgnore]
    public bool WhisperMessageAudioFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _whisperVideoMessageSelection;

    [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperVideoMessageSelection {
        get => _whisperVideoMessageSelection;
        set {
            WhisperVideoMessageSelectionSpecified = true;
            _whisperVideoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool WhisperVideoMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _whisperMessageVideoUrlList;

    [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageVideoUrlList {
        get => _whisperMessageVideoUrlList;
        set {
            WhisperMessageVideoUrlListSpecified = true;
            _whisperMessageVideoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool WhisperMessageVideoUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _whisperMessageVideoFileList;

    [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageVideoFileList {
        get => _whisperMessageVideoFileList;
        set {
            WhisperMessageVideoFileListSpecified = true;
            _whisperMessageVideoFileList = value;
        }
    }

    [XmlIgnore]
    public bool WhisperMessageVideoFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsModify _estimatedWaitMessageOptionsModify;

    [XmlElement(ElementName = "estimatedWaitMessageOptionsModify", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EstimatedWaitMessageOptionsModify EstimatedWaitMessageOptionsModify {
        get => _estimatedWaitMessageOptionsModify;
        set {
            EstimatedWaitMessageOptionsModifySpecified = true;
            _estimatedWaitMessageOptionsModify = value;
        }
    }

    [XmlIgnore]
    public bool EstimatedWaitMessageOptionsModifySpecified { get; set; }
}
}

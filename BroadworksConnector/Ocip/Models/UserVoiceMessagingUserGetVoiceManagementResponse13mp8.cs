using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetVoiceManagementRequest13mp8.
    /// Replaced by: UserVoiceMessagingUserGetVoiceManagementResponse17
    /// <see cref="UserVoiceMessagingUserGetVoiceManagementRequest13mp8"/>
    /// <see cref="UserVoiceMessagingUserGetVoiceManagementResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17985""}]")]
    public class UserVoiceMessagingUserGetVoiceManagementResponse13mp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing _processing;

        [XmlElement(ElementName = "processing", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing Processing
        {
            get => _processing;
            set
            {
                ProcessingSpecified = true;
                _processing = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessingSpecified { get; set; }

        private string _voiceMessageDeliveryEmailAddress;

        [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageDeliveryEmailAddress
        {
            get => _voiceMessageDeliveryEmailAddress;
            set
            {
                VoiceMessageDeliveryEmailAddressSpecified = true;
                _voiceMessageDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageDeliveryEmailAddressSpecified { get; set; }

        private bool _usePhoneMessageWaitingIndicator;

        [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool UsePhoneMessageWaitingIndicator
        {
            get => _usePhoneMessageWaitingIndicator;
            set
            {
                UsePhoneMessageWaitingIndicatorSpecified = true;
                _usePhoneMessageWaitingIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool UsePhoneMessageWaitingIndicatorSpecified { get; set; }

        private bool _sendVoiceMessageNotifyEmail;

        [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool SendVoiceMessageNotifyEmail
        {
            get => _sendVoiceMessageNotifyEmail;
            set
            {
                SendVoiceMessageNotifyEmailSpecified = true;
                _sendVoiceMessageNotifyEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendVoiceMessageNotifyEmailSpecified { get; set; }

        private string _voiceMessageNotifyEmailAddress;

        [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageNotifyEmailAddress
        {
            get => _voiceMessageNotifyEmailAddress;
            set
            {
                VoiceMessageNotifyEmailAddressSpecified = true;
                _voiceMessageNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageNotifyEmailAddressSpecified { get; set; }

        private bool _sendCarbonCopyVoiceMessage;

        [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool SendCarbonCopyVoiceMessage
        {
            get => _sendCarbonCopyVoiceMessage;
            set
            {
                SendCarbonCopyVoiceMessageSpecified = true;
                _sendCarbonCopyVoiceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SendCarbonCopyVoiceMessageSpecified { get; set; }

        private string _voiceMessageCarbonCopyEmailAddress;

        [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageCarbonCopyEmailAddress
        {
            get => _voiceMessageCarbonCopyEmailAddress;
            set
            {
                VoiceMessageCarbonCopyEmailAddressSpecified = true;
                _voiceMessageCarbonCopyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageCarbonCopyEmailAddressSpecified { get; set; }

        private bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool TransferOnZeroToPhoneNumber
        {
            get => _transferOnZeroToPhoneNumber;
            set
            {
                TransferOnZeroToPhoneNumberSpecified = true;
                _transferOnZeroToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferPhoneNumberSpecified { get; set; }

        private bool _alwaysRedirectToVoiceMail;

        [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool AlwaysRedirectToVoiceMail
        {
            get => _alwaysRedirectToVoiceMail;
            set
            {
                AlwaysRedirectToVoiceMailSpecified = true;
                _alwaysRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysRedirectToVoiceMailSpecified { get; set; }

        private bool _busyRedirectToVoiceMail;

        [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool BusyRedirectToVoiceMail
        {
            get => _busyRedirectToVoiceMail;
            set
            {
                BusyRedirectToVoiceMailSpecified = true;
                _busyRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool BusyRedirectToVoiceMailSpecified { get; set; }

        private bool _noAnswerRedirectToVoiceMail;

        [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17985")]
        public bool NoAnswerRedirectToVoiceMail
        {
            get => _noAnswerRedirectToVoiceMail;
            set
            {
                NoAnswerRedirectToVoiceMailSpecified = true;
                _noAnswerRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerRedirectToVoiceMailSpecified { get; set; }

    }
}

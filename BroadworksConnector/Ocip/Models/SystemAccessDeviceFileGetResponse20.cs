using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceFileGetRequest20.
    /// <see cref="SystemAccessDeviceFileGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:835""}]")]
    public class SystemAccessDeviceFileGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = true;
                _fileSource = value;
            }
        }

        [XmlIgnore]
        protected bool FileSourceSpecified { get; set; }

        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = true;
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationFileNameSpecified { get; set; }

        private string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AccessUrl
        {
            get => _accessUrl;
            set
            {
                AccessUrlSpecified = true;
                _accessUrl = value;
            }
        }

        [XmlIgnore]
        protected bool AccessUrlSpecified { get; set; }

        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryUrl
        {
            get => _repositoryUrl;
            set
            {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        protected bool RepositoryUrlSpecified { get; set; }

        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TemplateUrl
        {
            get => _templateUrl;
            set
            {
                TemplateUrlSpecified = true;
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateUrlSpecified { get; set; }

        private bool _extendedCaptureEnabled;

        [XmlElement(ElementName = "extendedCaptureEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        public bool ExtendedCaptureEnabled
        {
            get => _extendedCaptureEnabled;
            set
            {
                ExtendedCaptureEnabledSpecified = true;
                _extendedCaptureEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCaptureEnabledSpecified { get; set; }

        private string _extendedCaptureURL;

        [XmlElement(ElementName = "extendedCaptureURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:835")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ExtendedCaptureURL
        {
            get => _extendedCaptureURL;
            set
            {
                ExtendedCaptureURLSpecified = true;
                _extendedCaptureURL = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCaptureURLSpecified { get; set; }

    }
}

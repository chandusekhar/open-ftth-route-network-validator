﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.RouteNetwork.Validator.Config
{
    public class KafkaSetting
    {
        public string Server { get; set; }
        public string PositionFilePath { get; set; }
        public string RouteNetworkEventTopic { get; set; }
        public string GeographicalAreaUpdatedTopic { get; set; }
    }
}

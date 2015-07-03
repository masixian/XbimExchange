﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Xbim.COBieLiteUK
{
    public partial class Impact
    {
        [XmlIgnore, JsonIgnore]
        public override string ObjectType
        {
            get { return ImpactType; }
            set { ImpactType = value; }
        }
    }
}

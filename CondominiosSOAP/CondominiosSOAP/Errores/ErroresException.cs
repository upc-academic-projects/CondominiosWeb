﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CondominiosSOAP.Errores
{
    [DataContract]
    public class ErroresException
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
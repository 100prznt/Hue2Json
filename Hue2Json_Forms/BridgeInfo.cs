﻿using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.Hue2Json
{
    public class BridgeInfo
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// IP der Hue Bridge
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// eindeutige Hardware-ID der Hue Bridge
        /// </summary>
        public string BridgeId { get; set; }

        /// <summary>
        /// Name der Hue Bridge
        /// </summary>
        public string Name { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for BridgeInfo
        /// </summary>
        public BridgeInfo()
        {

        }

        public BridgeInfo(LocatedBridge locatedBridge, string name = null)
        {
            IpAddress = locatedBridge.IpAddress;
            BridgeId = locatedBridge.BridgeId;
            Name = name;
        }

        #endregion Constructor

        #region Services
        public string GetNameString()
        {
            string name = "TODO";

            //TODO Name nach Settings ausgeben
            switch (Controller.GlobalSettings.BridgeNameDisplay)
            {
                case Settings.BridgeNameDisplayEnum.IpOnly:
                    throw new NotImplementedException();
                case Settings.BridgeNameDisplayEnum.IpAndName:
                    throw new NotImplementedException();
                case Settings.BridgeNameDisplayEnum.IpAndId:
                    throw new NotImplementedException();
                default: //NameAndIp
                    name = String.Format("{0} ({1})", Name, IpAddress);
                    break;
            }

            return name;
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
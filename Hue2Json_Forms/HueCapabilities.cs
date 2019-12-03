using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.Hue2Json
{
    public class HueCapabilities
    {
        #region Member

        private RulesCapability m_RulesInUsePercent;
        #endregion Member

        #region Properties

        public Capability Lights { get; set; }

        /// <summary>
        /// Sensoren
        /// </summary>
        //[Obsolete("Abgelöst durch SensorResources")]
        //public Capability Sensors { get; set; }

        /// <summary>
        /// Sensor Subresources
        /// </summary>
        public SensorCapability SensorResources { get; set; }

        public Capability Groups { get; set; }

        public Capability Schedules { get; set; }

        public Capability Resourcelinks { get; set; }

        #region Regeln
        public RulesCapability RulesInUse { get; set; }
        public RulesCapability RulesAvailable { get; set; }

        public RulesCapability RulesInUsePercent
        {
            get
            {
                return new RulesCapability()
                {
                    Actions = RulesInUse.Actions * 100.0 / RulesAvailable.Actions,
                    Conditions = RulesInUse.Conditions * 100.0 / RulesAvailable.Conditions,
                    Count = RulesInUse.Count * 100.0 / RulesAvailable.Count
                };
            }
        }

        public double MeanConditions
        {
            get
            {
                return (double)RulesInUse.Conditions / (double)RulesInUse.Count;
            }
        }

        public double MeanActions
        {
            get
            {
                return (double)RulesInUse.Actions / (double)RulesInUse.Count;
            }
        }
        #endregion Regeln
        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for HueCapabilities
        /// </summary>
        public HueCapabilities()
        {
            Lights = new Capability();
            //Sensors = new Capability();
            SensorResources = new SensorCapability();
            Groups = new Capability();
            Schedules = new Capability();
            Resourcelinks = new Capability();

            RulesInUse = new RulesCapability();
            RulesAvailable = new RulesCapability();
        }

        #endregion Constructor

        #region Services


        #endregion Services

        #region Internal services

        private void updatePercentValues()
        {
            m_RulesInUsePercent = new RulesCapability()
            {
                Actions = RulesInUse.Actions * 100.0 / RulesAvailable.Actions,
                Conditions = RulesInUse.Conditions * 100.0 / RulesAvailable.Conditions,
                Count = RulesInUse.Count * 100.0 / RulesAvailable.Count
            };
        }
        #endregion Internal services

        #region Events


        #endregion Events


    }

    /// <summary>
    /// Allgemeines Capability Objekt
    /// </summary>
    public class Capability
    {
        /// <summary>
        /// In Verwendung
        /// </summary>
        public int InUse { get; set; }

        /// <summary>
        /// Maximal verfügbar auf Bridge
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Prozentualer Wert der Belegung
        /// </summary>
        public double InUsePercent
        {
            get
            {
                return InUse * 100.0 / Total;
            }
        }

        /// <summary>
        /// Gibt eine Zusammenfassung im Format [InUse]/[Available] ([InUsePercent]) zurück
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return InUse + "/" + Total + " (" + InUsePercent.ToString("F1") + " %)";
        }
    }

    /// <summary>
    /// Capability Objekt für Sensoren
    /// </summary>
    public class SensorCapability
    {
        /// <summary>
        /// Summe aller Sensoren
        /// </summary>
        public Capability Total { get; set; }

        public Capability Clip { get; set; }

        /// <summary>
        /// ZigBee Light Link
        /// </summary>
        public Capability Zll { get; set; }

        /// <summary>
        /// ZigBee Green Power
        /// Siehe: https://github.com/dresden-elektronik/deconz-rest-plugin/wiki/Sensors
        /// </summary>
        public Capability Zgp { get; set; }

        public SensorCapability()
        {
            Total = new Capability();
            Clip = new Capability();
            Zll = new Capability();
            Zgp = new Capability();
        }
    }

    /// <summary>
    /// Capability Objekt für Regeln
    /// </summary>
    public class RulesCapability
    {
        /// <summary>
        /// Anzahl an Regeln
        /// </summary>
        public double Count { get; set; }

        /// <summary>
        /// Anzahl an Aktionen
        /// </summary>
        public double Actions { get; set; }


        /// <summary>
        /// Anzahl an Bedingungen
        /// </summary>
        public double Conditions { get; set; }
    }
}

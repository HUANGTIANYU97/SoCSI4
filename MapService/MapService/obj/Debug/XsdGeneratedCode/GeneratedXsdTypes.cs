﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapService.ContractTypes
{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=true)]
    public partial class ArrayOfstring
    {
        
        private string[] stringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("string", IsNullable=true)]
        public string[] @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetContracts
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetContractsResponse
    {
        
        private Composite_Cities[] getContractsResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
        public Composite_Cities[] GetContractsResult
        {
            get
            {
                return this.getContractsResultField;
            }
            set
            {
                this.getContractsResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary", IsNullable=true)]
    public partial class Composite_Cities
    {
        
        private string[] citiesField;
        
        private string country_codeField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Cities
        {
            get
            {
                return this.citiesField;
            }
            set
            {
                this.citiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Country_code
        {
            get
            {
                return this.country_codeField;
            }
            set
            {
                this.country_codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetCityStations
    {
        
        private string cityStationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cityStations
        {
            get
            {
                return this.cityStationsField;
            }
            set
            {
                this.cityStationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class GetCityStationsResponse
    {
        
        private Composite_Stations[] getCityStationsResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
        public Composite_Stations[] GetCityStationsResult
        {
            get
            {
                return this.getCityStationsResultField;
            }
            set
            {
                this.getCityStationsResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary", IsNullable=true)]
    public partial class Composite_Stations
    {
        
        private string addressField;
        
        private int available_bike_standsField;
        
        private bool available_bike_standsFieldSpecified;
        
        private int available_bikesField;
        
        private bool available_bikesFieldSpecified;
        
        private bool bankingField;
        
        private bool bankingFieldSpecified;
        
        private int bike_standsField;
        
        private bool bike_standsFieldSpecified;
        
        private bool bonusField;
        
        private bool bonusFieldSpecified;
        
        private string contract_nameField;
        
        private string last_updateField;
        
        private string nameField;
        
        private int numberField;
        
        private bool numberFieldSpecified;
        
        private Position positionField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public int Available_bike_stands
        {
            get
            {
                return this.available_bike_standsField;
            }
            set
            {
                this.available_bike_standsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Available_bike_standsSpecified
        {
            get
            {
                return this.available_bike_standsFieldSpecified;
            }
            set
            {
                this.available_bike_standsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Available_bikes
        {
            get
            {
                return this.available_bikesField;
            }
            set
            {
                this.available_bikesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Available_bikesSpecified
        {
            get
            {
                return this.available_bikesFieldSpecified;
            }
            set
            {
                this.available_bikesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool Banking
        {
            get
            {
                return this.bankingField;
            }
            set
            {
                this.bankingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BankingSpecified
        {
            get
            {
                return this.bankingFieldSpecified;
            }
            set
            {
                this.bankingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Bike_stands
        {
            get
            {
                return this.bike_standsField;
            }
            set
            {
                this.bike_standsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Bike_standsSpecified
        {
            get
            {
                return this.bike_standsFieldSpecified;
            }
            set
            {
                this.bike_standsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool Bonus
        {
            get
            {
                return this.bonusField;
            }
            set
            {
                this.bonusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BonusSpecified
        {
            get
            {
                return this.bonusFieldSpecified;
            }
            set
            {
                this.bonusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Contract_name
        {
            get
            {
                return this.contract_nameField;
            }
            set
            {
                this.contract_nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Last_update
        {
            get
            {
                return this.last_updateField;
            }
            set
            {
                this.last_updateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberSpecified
        {
            get
            {
                return this.numberFieldSpecified;
            }
            set
            {
                this.numberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Position Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary", IsNullable=true)]
    public partial class Position
    {
        
        private double latField;
        
        private bool latFieldSpecified;
        
        private double lngField;
        
        private bool lngFieldSpecified;
        
        /// <remarks/>
        public double Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatSpecified
        {
            get
            {
                return this.latFieldSpecified;
            }
            set
            {
                this.latFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double Lng
        {
            get
            {
                return this.lngField;
            }
            set
            {
                this.lngField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LngSpecified
        {
            get
            {
                return this.lngFieldSpecified;
            }
            set
            {
                this.lngFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary", IsNullable=true)]
    public partial class ArrayOfComposite_Cities
    {
        
        private Composite_Cities[] composite_CitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Composite_Cities", IsNullable=true)]
        public Composite_Cities[] Composite_Cities
        {
            get
            {
                return this.composite_CitiesField;
            }
            set
            {
                this.composite_CitiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MSBuild", "16.4.0+e901037fe1815eae17424f860412d0b967d09461")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary", IsNullable=true)]
    public partial class ArrayOfComposite_Stations
    {
        
        private Composite_Stations[] composite_StationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Composite_Stations", IsNullable=true)]
        public Composite_Stations[] Composite_Stations
        {
            get
            {
                return this.composite_StationsField;
            }
            set
            {
                this.composite_StationsField = value;
            }
        }
    }
}

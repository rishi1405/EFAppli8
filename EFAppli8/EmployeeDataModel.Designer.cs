﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EmployeeModel", "EmployeeEmployeeContactDetail", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EFAppli8.Employee), "EmployeeContactDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EFAppli8.EmployeeContactDetail), true)]

#endregion

namespace EFAppli8
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeeDBContex : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeeDBContex object using the connection string found in the 'EmployeeDBContex' section of the application configuration file.
        /// </summary>
        public EmployeeDBContex() : base("name=EmployeeDBContex", "EmployeeDBContex")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDBContex object.
        /// </summary>
        public EmployeeDBContex(string connectionString) : base(connectionString, "EmployeeDBContex")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDBContex object.
        /// </summary>
        public EmployeeDBContex(EntityConnection connection) : base(connection, "EmployeeDBContex")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EmployeeContactDetail> EmployeeContactDetails
        {
            get
            {
                if ((_EmployeeContactDetails == null))
                {
                    _EmployeeContactDetails = base.CreateObjectSet<EmployeeContactDetail>("EmployeeContactDetails");
                }
                return _EmployeeContactDetails;
            }
        }
        private ObjectSet<EmployeeContactDetail> _EmployeeContactDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmployeeContactDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployeeContactDetails(EmployeeContactDetail employeeContactDetail)
        {
            base.AddObject("EmployeeContactDetails", employeeContactDetail);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeID)
        {
            Employee employee = new Employee();
            employee.EmployeeID = employeeID;
            return employee;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value, "EmployeeID");
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, true, "Gender");
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeModel", "EmployeeEmployeeContactDetail", "EmployeeContactDetail")]
        public EmployeeContactDetail EmployeeContactDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeContactDetail>("EmployeeModel.EmployeeEmployeeContactDetail", "EmployeeContactDetail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeContactDetail>("EmployeeModel.EmployeeEmployeeContactDetail", "EmployeeContactDetail").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EmployeeContactDetail> EmployeeContactDetailReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeeContactDetail>("EmployeeModel.EmployeeEmployeeContactDetail", "EmployeeContactDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EmployeeContactDetail>("EmployeeModel.EmployeeEmployeeContactDetail", "EmployeeContactDetail", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeModel", Name="EmployeeContactDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeeContactDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeeContactDetail object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        public static EmployeeContactDetail CreateEmployeeContactDetail(global::System.Int32 employeeID)
        {
            EmployeeContactDetail employeeContactDetail = new EmployeeContactDetail();
            employeeContactDetail.EmployeeID = employeeID;
            return employeeContactDetail;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value, "EmployeeID");
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true, "Email");
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Mobile
        {
            get
            {
                return _Mobile;
            }
            set
            {
                OnMobileChanging(value);
                ReportPropertyChanging("Mobile");
                _Mobile = StructuralObject.SetValidValue(value, true, "Mobile");
                ReportPropertyChanged("Mobile");
                OnMobileChanged();
            }
        }
        private global::System.String _Mobile;
        partial void OnMobileChanging(global::System.String value);
        partial void OnMobileChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LandLine
        {
            get
            {
                return _LandLine;
            }
            set
            {
                OnLandLineChanging(value);
                ReportPropertyChanging("LandLine");
                _LandLine = StructuralObject.SetValidValue(value, true, "LandLine");
                ReportPropertyChanged("LandLine");
                OnLandLineChanged();
            }
        }
        private global::System.String _LandLine;
        partial void OnLandLineChanging(global::System.String value);
        partial void OnLandLineChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeModel", "EmployeeEmployeeContactDetail", "Employee")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeModel.EmployeeEmployeeContactDetail", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeModel.EmployeeEmployeeContactDetail", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeModel.EmployeeEmployeeContactDetail", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("EmployeeModel.EmployeeEmployeeContactDetail", "Employee", value);
                }
            }
        }

        #endregion

    }

    #endregion

}

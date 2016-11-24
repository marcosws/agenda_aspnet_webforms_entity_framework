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

[assembly: EdmRelationshipAttribute("AgendaModel", "fk_contatos", "Usuarios", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(agenda_wf_ef.Usuarios), "Contatos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(agenda_wf_ef.Contatos), true)]

#endregion

namespace agenda_wf_ef
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AgendaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AgendaEntities object using the connection string found in the 'AgendaEntities' section of the application configuration file.
        /// </summary>
        public AgendaEntities() : base("name=AgendaEntities", "AgendaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AgendaEntities object.
        /// </summary>
        public AgendaEntities(string connectionString) : base(connectionString, "AgendaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AgendaEntities object.
        /// </summary>
        public AgendaEntities(EntityConnection connection) : base(connection, "AgendaEntities")
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
        public ObjectSet<Contatos> Contatos
        {
            get
            {
                if ((_Contatos == null))
                {
                    _Contatos = base.CreateObjectSet<Contatos>("Contatos");
                }
                return _Contatos;
            }
        }
        private ObjectSet<Contatos> _Contatos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Usuarios> Usuarios
        {
            get
            {
                if ((_Usuarios == null))
                {
                    _Usuarios = base.CreateObjectSet<Usuarios>("Usuarios");
                }
                return _Usuarios;
            }
        }
        private ObjectSet<Usuarios> _Usuarios;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contatos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContatos(Contatos contatos)
        {
            base.AddObject("Contatos", contatos);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Usuarios EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsuarios(Usuarios usuarios)
        {
            base.AddObject("Usuarios", usuarios);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AgendaModel", Name="Contatos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contatos : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contatos object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Contatos CreateContatos(global::System.Int32 id)
        {
            Contatos contatos = new Contatos();
            contatos.Id = id;
            return contatos;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> UsuarioId
        {
            get
            {
                return _UsuarioId;
            }
            set
            {
                OnUsuarioIdChanging(value);
                ReportPropertyChanging("UsuarioId");
                _UsuarioId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UsuarioId");
                OnUsuarioIdChanged();
            }
        }
        private Nullable<global::System.Int32> _UsuarioId;
        partial void OnUsuarioIdChanging(Nullable<global::System.Int32> value);
        partial void OnUsuarioIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cpf
        {
            get
            {
                return _Cpf;
            }
            set
            {
                OnCpfChanging(value);
                ReportPropertyChanging("Cpf");
                _Cpf = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Cpf");
                OnCpfChanged();
            }
        }
        private global::System.String _Cpf;
        partial void OnCpfChanging(global::System.String value);
        partial void OnCpfChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Telefone
        {
            get
            {
                return _Telefone;
            }
            set
            {
                OnTelefoneChanging(value);
                ReportPropertyChanging("Telefone");
                _Telefone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Telefone");
                OnTelefoneChanged();
            }
        }
        private global::System.String _Telefone;
        partial void OnTelefoneChanging(global::System.String value);
        partial void OnTelefoneChanged();
    
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
                _Email = StructuralObject.SetValidValue(value, true);
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
        public global::System.String Site
        {
            get
            {
                return _Site;
            }
            set
            {
                OnSiteChanging(value);
                ReportPropertyChanging("Site");
                _Site = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Site");
                OnSiteChanged();
            }
        }
        private global::System.String _Site;
        partial void OnSiteChanging(global::System.String value);
        partial void OnSiteChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AgendaModel", "fk_contatos", "Usuarios")]
        public Usuarios Usuarios
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuarios>("AgendaModel.fk_contatos", "Usuarios").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuarios>("AgendaModel.fk_contatos", "Usuarios").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Usuarios> UsuariosReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Usuarios>("AgendaModel.fk_contatos", "Usuarios");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Usuarios>("AgendaModel.fk_contatos", "Usuarios", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AgendaModel", Name="Usuarios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Usuarios : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Usuarios object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        public static Usuarios CreateUsuarios(global::System.Int32 id, global::System.String nome)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Id = id;
            usuarios.Nome = nome;
            return usuarios;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
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
                _Email = StructuralObject.SetValidValue(value, true);
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
        public global::System.String Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                OnSenhaChanging(value);
                ReportPropertyChanging("Senha");
                _Senha = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Senha");
                OnSenhaChanged();
            }
        }
        private global::System.String _Senha;
        partial void OnSenhaChanging(global::System.String value);
        partial void OnSenhaChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AgendaModel", "fk_contatos", "Contatos")]
        public EntityCollection<Contatos> Contatos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Contatos>("AgendaModel.fk_contatos", "Contatos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Contatos>("AgendaModel.fk_contatos", "Contatos", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
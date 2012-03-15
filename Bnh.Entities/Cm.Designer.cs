﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("bnhModel", "FK_Brick_Wall", "Wall", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Bnh.Entities.Wall), "Brick", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Bnh.Entities.Brick), true)]
[assembly: EdmRelationshipAttribute("bnhModel", "FK_Wall_SceneTemplate", "SceneTemplate", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Bnh.Entities.SceneTemplate), "Wall", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Bnh.Entities.Wall), true)]

#endregion

namespace Bnh.Entities
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CmEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CmEntities object using the connection string found in the 'CmEntities' section of the application configuration file.
        /// </summary>
        public CmEntities() : this(EntityConnectionHelper.Get("Cm"))
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CmEntities object.
        /// </summary>
        public CmEntities(string connectionString) : base(connectionString, "CmEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CmEntities object.
        /// </summary>
        public CmEntities(EntityConnection connection) : base(connection, "CmEntities")
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
        public ObjectSet<Brick> Bricks
        {
            get
            {
                if ((_Bricks == null))
                {
                    _Bricks = base.CreateObjectSet<Brick>("Bricks");
                }
                return _Bricks;
            }
        }
        private ObjectSet<Brick> _Bricks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Wall> Walls
        {
            get
            {
                if ((_Walls == null))
                {
                    _Walls = base.CreateObjectSet<Wall>("Walls");
                }
                return _Walls;
            }
        }
        private ObjectSet<Wall> _Walls;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SceneTemplate> SceneTemplates
        {
            get
            {
                if ((_SceneTemplates == null))
                {
                    _SceneTemplates = base.CreateObjectSet<SceneTemplate>("SceneTemplates");
                }
                return _SceneTemplates;
            }
        }
        private ObjectSet<SceneTemplate> _SceneTemplates;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Bricks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBricks(Brick brick)
        {
            base.AddObject("Bricks", brick);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Walls EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWalls(Wall wall)
        {
            base.AddObject("Walls", wall);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SceneTemplates EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSceneTemplates(SceneTemplate sceneTemplate)
        {
            base.AddObject("SceneTemplates", sceneTemplate);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="Brick")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(HtmlBrick))]
    [KnownTypeAttribute(typeof(GalleryBrick))]
    [KnownTypeAttribute(typeof(MapBrick))]
    [KnownTypeAttribute(typeof(EmptyBrick))]
    public abstract partial class Brick : EntityObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
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
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 WallId
        {
            get
            {
                return _WallId;
            }
            set
            {
                OnWallIdChanging(value);
                ReportPropertyChanging("WallId");
                _WallId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("WallId");
                OnWallIdChanged();
            }
        }
        private global::System.Int64 _WallId;
        partial void OnWallIdChanging(global::System.Int64 value);
        partial void OnWallIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Single Width
        {
            get
            {
                return _Width;
            }
            set
            {
                OnWidthChanging(value);
                ReportPropertyChanging("Width");
                _Width = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Width");
                OnWidthChanged();
            }
        }
        private global::System.Single _Width;
        partial void OnWidthChanging(global::System.Single value);
        partial void OnWidthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Order
        {
            get
            {
                return _Order;
            }
            set
            {
                OnOrderChanging(value);
                ReportPropertyChanging("Order");
                _Order = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Order");
                OnOrderChanged();
            }
        }
        private global::System.Byte _Order;
        partial void OnOrderChanging(global::System.Byte value);
        partial void OnOrderChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("bnhModel", "FK_Brick_Wall", "Wall")]
        public Wall Wall
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Wall>("bnhModel.FK_Brick_Wall", "Wall").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Wall>("bnhModel.FK_Brick_Wall", "Wall").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Wall> WallReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Wall>("bnhModel.FK_Brick_Wall", "Wall");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Wall>("bnhModel.FK_Brick_Wall", "Wall", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="EmptyBrick")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmptyBrick : Brick
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmptyBrick object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="wallId">Initial value of the WallId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="width">Initial value of the Width property.</param>
        /// <param name="order">Initial value of the Order property.</param>
        public static EmptyBrick CreateEmptyBrick(global::System.Int64 id, global::System.Int64 wallId, global::System.String title, global::System.Single width, global::System.Byte order)
        {
            EmptyBrick emptyBrick = new EmptyBrick();
            emptyBrick.Id = id;
            emptyBrick.WallId = wallId;
            emptyBrick.Title = title;
            emptyBrick.Width = width;
            emptyBrick.Order = order;
            return emptyBrick;
        }

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="GalleryBrick")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GalleryBrick : Brick
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new GalleryBrick object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="wallId">Initial value of the WallId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="width">Initial value of the Width property.</param>
        /// <param name="order">Initial value of the Order property.</param>
        public static GalleryBrick CreateGalleryBrick(global::System.Int64 id, global::System.Int64 wallId, global::System.String title, global::System.Single width, global::System.Byte order)
        {
            GalleryBrick galleryBrick = new GalleryBrick();
            galleryBrick.Id = id;
            galleryBrick.WallId = wallId;
            galleryBrick.Title = title;
            galleryBrick.Width = width;
            galleryBrick.Order = order;
            return galleryBrick;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> ImageListId
        {
            get
            {
                return _ImageListId;
            }
            set
            {
                OnImageListIdChanging(value);
                ReportPropertyChanging("ImageListId");
                _ImageListId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ImageListId");
                OnImageListIdChanged();
            }
        }
        private Nullable<global::System.Int64> _ImageListId;
        partial void OnImageListIdChanging(Nullable<global::System.Int64> value);
        partial void OnImageListIdChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="HtmlBrick")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HtmlBrick : Brick
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new HtmlBrick object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="wallId">Initial value of the WallId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="width">Initial value of the Width property.</param>
        /// <param name="order">Initial value of the Order property.</param>
        public static HtmlBrick CreateHtmlBrick(global::System.Int64 id, global::System.Int64 wallId, global::System.String title, global::System.Single width, global::System.Byte order)
        {
            HtmlBrick htmlBrick = new HtmlBrick();
            htmlBrick.Id = id;
            htmlBrick.WallId = wallId;
            htmlBrick.Title = title;
            htmlBrick.Width = width;
            htmlBrick.Order = order;
            return htmlBrick;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Html
        {
            get
            {
                return _Html;
            }
            set
            {
                OnHtmlChanging(value);
                ReportPropertyChanging("Html");
                _Html = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Html");
                OnHtmlChanged();
            }
        }
        private global::System.String _Html;
        partial void OnHtmlChanging(global::System.String value);
        partial void OnHtmlChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="MapBrick")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MapBrick : Brick
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MapBrick object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="wallId">Initial value of the WallId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="width">Initial value of the Width property.</param>
        /// <param name="order">Initial value of the Order property.</param>
        public static MapBrick CreateMapBrick(global::System.Int64 id, global::System.Int64 wallId, global::System.String title, global::System.Single width, global::System.Byte order)
        {
            MapBrick mapBrick = new MapBrick();
            mapBrick.Id = id;
            mapBrick.WallId = wallId;
            mapBrick.Title = title;
            mapBrick.Width = width;
            mapBrick.Order = order;
            return mapBrick;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GpsLocation
        {
            get
            {
                return _GpsLocation;
            }
            set
            {
                OnGpsLocationChanging(value);
                ReportPropertyChanging("GpsLocation");
                _GpsLocation = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GpsLocation");
                OnGpsLocationChanged();
            }
        }
        private global::System.String _GpsLocation;
        partial void OnGpsLocationChanging(global::System.String value);
        partial void OnGpsLocationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Height
        {
            get
            {
                return _Height;
            }
            set
            {
                OnHeightChanging(value);
                ReportPropertyChanging("Height");
                _Height = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Height");
                OnHeightChanged();
            }
        }
        private Nullable<global::System.Int32> _Height;
        partial void OnHeightChanging(Nullable<global::System.Int32> value);
        partial void OnHeightChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Zoom
        {
            get
            {
                return _Zoom;
            }
            set
            {
                OnZoomChanging(value);
                ReportPropertyChanging("Zoom");
                _Zoom = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Zoom");
                OnZoomChanged();
            }
        }
        private Nullable<global::System.Int32> _Zoom;
        partial void OnZoomChanging(Nullable<global::System.Int32> value);
        partial void OnZoomChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="SceneTemplate")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SceneTemplate : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SceneTemplate object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static SceneTemplate CreateSceneTemplate(global::System.Guid id, global::System.String title)
        {
            SceneTemplate sceneTemplate = new SceneTemplate();
            sceneTemplate.Id = id;
            sceneTemplate.Title = title;
            return sceneTemplate;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
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
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IconUrl
        {
            get
            {
                return _IconUrl;
            }
            set
            {
                OnIconUrlChanging(value);
                ReportPropertyChanging("IconUrl");
                _IconUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IconUrl");
                OnIconUrlChanged();
            }
        }
        private global::System.String _IconUrl;
        partial void OnIconUrlChanging(global::System.String value);
        partial void OnIconUrlChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("bnhModel", "FK_Wall_SceneTemplate", "Wall")]
        public EntityCollection<Wall> Walls
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Wall>("bnhModel.FK_Wall_SceneTemplate", "Wall");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Wall>("bnhModel.FK_Wall_SceneTemplate", "Wall", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="bnhModel", Name="Wall")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Wall : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Wall object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="ownerId">Initial value of the OwnerId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="width">Initial value of the Width property.</param>
        /// <param name="order">Initial value of the Order property.</param>
        public static Wall CreateWall(global::System.Int64 id, global::System.Guid ownerId, global::System.String title, global::System.Single width, global::System.Byte order)
        {
            Wall wall = new Wall();
            wall.Id = id;
            wall.OwnerId = ownerId;
            wall.Title = title;
            wall.Width = width;
            wall.Order = order;
            return wall;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
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
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid OwnerId
        {
            get
            {
                return _OwnerId;
            }
            set
            {
                OnOwnerIdChanging(value);
                ReportPropertyChanging("OwnerId");
                _OwnerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OwnerId");
                OnOwnerIdChanged();
            }
        }
        private global::System.Guid _OwnerId;
        partial void OnOwnerIdChanging(global::System.Guid value);
        partial void OnOwnerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Single Width
        {
            get
            {
                return _Width;
            }
            set
            {
                OnWidthChanging(value);
                ReportPropertyChanging("Width");
                _Width = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Width");
                OnWidthChanged();
            }
        }
        private global::System.Single _Width;
        partial void OnWidthChanging(global::System.Single value);
        partial void OnWidthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Order
        {
            get
            {
                return _Order;
            }
            set
            {
                OnOrderChanging(value);
                ReportPropertyChanging("Order");
                _Order = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Order");
                OnOrderChanged();
            }
        }
        private global::System.Byte _Order;
        partial void OnOrderChanging(global::System.Byte value);
        partial void OnOrderChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("bnhModel", "FK_Brick_Wall", "Brick")]
        public EntityCollection<Brick> Bricks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Brick>("bnhModel.FK_Brick_Wall", "Brick");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Brick>("bnhModel.FK_Brick_Wall", "Brick", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}

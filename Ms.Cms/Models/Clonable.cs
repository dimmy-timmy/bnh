﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.ComponentModel;
using Ms.Cms.Models.Attributes;

namespace Ms.Cms.Models
{
    public partial class Scene : ICloneable
    {
        public virtual Scene Clone()
        {
            var scene = new Scene
            {
                Id = 0,
                OwnerGuidId = this.OwnerGuidId,
                OwnerIntId = this.OwnerIntId,
                OwnerLongId = this.OwnerLongId,
            };

            foreach (var wall in this.Walls)
            {
                scene.Walls.Add(wall.Clone());
            }

            return scene;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }

    public partial class Wall : ICloneable
    {
        public virtual Wall Clone()
        {
            var wall = new Wall
            {
                Id = 0,
                Title = this.Title,
                Width = this.Width,
                Order = this.Order
            };

            foreach (var brick in this.Bricks)
            {
                wall.Bricks.Add(brick.Clone());
            }

            return wall;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }

    public partial class Brick : ICloneable
    {
        public virtual Brick Clone()
        {
            var type = this.GetTypeNonProxy();
            var clone = Activator.CreateInstance(type) as Brick;

            foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (property.CanRead && property.CanWrite)
                {
                    var p = property.GetCustomAttributes(typeof(NonCloneableAttribute), false);
                    if (p.Length > 0)
                        continue;

                    p = property.GetCustomAttributes(typeof(XmlIgnoreAttribute), false);
                    if (p.Length > 0)
                        continue;

                    p = property.GetCustomAttributes(typeof(SoapIgnoreAttribute), false);
                    if (p.Length > 0)
                        continue;

                    p = property.GetCustomAttributes(typeof(BrowsableAttribute), false);
                    if (p.Length > 0 && !(p[0] as BrowsableAttribute).Browsable)
                        continue;

                    var value = property.GetValue(this, null);
                    if(value != null)
                        property.SetValue(clone, value, null);
                }
            }

            return clone;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Italika
{
    public enum Tipo
    {
        Trabajo,
        Deportiva,
        Infantin
    }

    public static class EnumExtensions
    {
        public static string GetDescripcion(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo.CustomAttributes.Count() == 0)
            {
                //No tiene atributos personalizados como descripcion
                return value.ToString();
            }
            else
            {
                //obtener el valor del atributo Display
                var attribute = (DisplayAttribute)
                    fieldInfo.GetCustomAttribute(typeof(DisplayAttribute));

                return attribute.Name;
            }
        }
    }
}
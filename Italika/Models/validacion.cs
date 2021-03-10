using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Italika.Models
{
    [MetadataType(typeof(ProductosMetaData))]

    public partial class Productos
    {
        public Tipo TipoC { get; set; }
    }

    public class ProductosMetaData
    {
       
    }
}
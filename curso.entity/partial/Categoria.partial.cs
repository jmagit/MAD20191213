using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace curso.entity {
    public partial class CategoriaMetadata {
        [Required]
        public int ProductCategoryID { get; set; }
        public Nullable<int> ParentProductCategoryID { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [RegularExpression(@"^[A-Z]\w*")]
        public string Nombre { get; set; }
    }

    [MetadataType(typeof(CategoriaMetadata))]
    partial class Categoria : IValidatableObject {
        public void desctaloga() {
            string s = "";
            StringBuilder cad = new StringBuilder();
            for (var i = 0; i < 10000; i++)
                cad.Append("X");
            s = cad.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            throw new NotImplementedException();
        }
    }
}

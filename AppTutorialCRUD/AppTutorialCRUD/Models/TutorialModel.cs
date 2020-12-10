using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppTutorialCRUD.Models
{
    public class TutorialModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TutorialId { get; set; }
        public string TutorialTitulo { get; set; }
        public string TutorialDescripcion { get; set; }

    }
}

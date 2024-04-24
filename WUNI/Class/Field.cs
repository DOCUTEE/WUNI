using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace WUNI.Class
{
    public class Field
    {
        private string fieldID;
        private string fieldName;

        public Field(string fieldID, string fieldName)
        {
            this.fieldID = fieldID;
            this.fieldName = fieldName;
        }

        public string FieldID { get => fieldID; set => fieldID = value; }
        public string FieldName { get => fieldName; set => fieldName = value; }

     
    }
}

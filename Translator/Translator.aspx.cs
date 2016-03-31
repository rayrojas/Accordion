using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Translator
{
    public partial class Translator : System.Web.UI.Page
    {
        private string[] chromatic = {
            "DO", "DO#", "RE", "RE#", "MI", "FA", "FA#", "SOL", "SOL#", "LA", "LA#", "SI",
            "Do", "Do#", "Re", "Re#", "Mi", "Fa", "Fa#", "Sol", "Sol#", "La", "La#", "Si",
            "do", "do#", "re", "re#", "mi", "fa", "fa#", "sol", "sol#", "la", "la#", "si",
            "dO", "dO#", "rE", "rE#", "mI", "fA", "fA#", "sOL", "sOL#", "lA", "lA#", "sI"
        };
        private string[] G = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
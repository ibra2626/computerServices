using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_services
{
    public class ChangeFilterButtonsText : GridResLocalizer 
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Ara";
            return base.GetLocalizedString(id);
        }
    }
}

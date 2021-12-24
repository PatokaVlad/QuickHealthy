using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.Interfaces.Views
{
    public interface IOfficeView
    {
        void LoadOffices(IEnumerable<OfficeViewModel> offices);
        void ClearOfficeControls();
    }
}

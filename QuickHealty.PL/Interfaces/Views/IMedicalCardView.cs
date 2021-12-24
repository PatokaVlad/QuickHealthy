using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.Interfaces.Views
{
    public interface IMedicalCardView
    {
        void LoadMedicalCards(IEnumerable<MedicalCardViewModel> medicalCards);
        void ClearMedicalCardCreationControls();
        void ClearMedicalCardUpdateControls();
    }
}

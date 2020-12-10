using AppTutorialCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppTutorialCRUD.Services
{
    public interface ITutorials
    {

        Task<List<TutorialModel>> GetListTutorials();
        Task<TutorialModel> GetTutorial(int TutorialId);
        Task<bool> InsertTutorial(TutorialModel tutorialModel);
        Task<bool> UpdateTutorial(TutorialModel tutorialModel);
        Task<bool> DeleteTutorial(TutorialModel tutorialModel);
        Task<bool> DeleteAllTutorials();

    }
}

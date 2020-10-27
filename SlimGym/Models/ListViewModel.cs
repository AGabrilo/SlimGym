using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SlimGym.Models
{
    public class ListViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector { get; set; }
        public ListViewModel()
        {


            MyListCollector = new ObservableCollection<MyListModel>()
            {
                new MyListModel(){id = 1 , ProgramName = "Crossfit" , ProgramDetail = "Advanced" },
                new MyListModel(){ id = 2 , ProgramName = "Flow fit" , ProgramDetail = "Intermediate" },
                new MyListModel(){ id = 3 , ProgramName = "Lift&Pump" , ProgramDetail = "Intermediate" },
                new MyListModel(){ id = 4 , ProgramName = "Fat Burning" , ProgramDetail = "Beginner" },
                 new MyListModel(){id = 5 , ProgramName = "Boks" , ProgramDetail = "Intermediate" },
                new MyListModel(){ id = 6 , ProgramName = "Yoga Therapy" , ProgramDetail = "Beginner" },
                new MyListModel(){ id = 7 , ProgramName = "Zumba" , ProgramDetail = "Intermediate" },
                new MyListModel(){ id = 8 , ProgramName = "Kružni trening" , ProgramDetail = "Intermediate" },
                 new MyListModel(){id = 9 , ProgramName = "Trx" , ProgramDetail = "Advanced" },
                new MyListModel(){ id = 10 , ProgramName = "Aerial Hoop" , ProgramDetail = "Beginner" },
                
            };

        }
    }
}

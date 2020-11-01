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
                new MyListModel(){id = 2 , ProgramName = "Boks" , ProgramDetail = "Intermediate" },
                new MyListModel(){ id = 3 , ProgramName = "Zumba" , ProgramDetail = "Intermediate" },
                new MyListModel(){id = 4 , ProgramName = "Spinning" , ProgramDetail = "Advanced" },
                new MyListModel(){ id = 5 , ProgramName = "Total Body" , ProgramDetail = "Advanced" },
                
            };

        }
    }
}

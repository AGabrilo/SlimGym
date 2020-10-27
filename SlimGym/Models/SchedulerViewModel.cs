using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SlimGym.Models
{
    /// <summary>   
    /// Raspored.   
    /// </summary>
    public class SchedulerViewModel : ContentPage
    {
        public ObservableCollection<Meetings> Meetings { get; set; }
        List<string> eventNameCollection;
        List<Color> colorCollection;

        public SchedulerViewModel()
        {
            Meetings = new ObservableCollection<Meetings>();
            CreateEventNameCollection();
            CreateColorCollection();
            CreateAppointments();
        }
        /// <summary>
        /// Kreirani meetingovi,spremljeno sve u kolekciju.
        /// Postavlja meetingove(programe) 10 dana prije i 10 dana iza trenutnog datuma.
        /// </summary>
        private void CreateAppointments()
        {
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GettingTimeRanges();
            DateTime date;
            DateTime DateFrom = DateTime.Now.AddDays(-10);
            DateTime DateTo = DateTime.Now.AddDays(10);
            DateTime dataRangeStart = DateTime.Now.AddDays(-3);
            DateTime dataRangeEnd = DateTime.Now.AddDays(3);

            for (date = DateFrom; date < DateTo; date = date.AddDays(1))
            {
                if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
                {
                    for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
                    {
                        Meetings meeting = new Meetings();
                        int hour = (randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y));
                        meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                        meeting.To = (meeting.From.AddHours(1));
                        meeting.EventName = eventNameCollection[randomTime.Next(9)];
                        meeting.color = colorCollection[randomTime.Next(9)];
                        if (AdditionalAppointmentIndex % 3 == 0)
                            meeting.AllDay = true;
                        Meetings.Add(meeting);
                    }
                }
                else
                {
                    Meetings meeting = new Meetings();
                    meeting.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(9, 11), 0, 0);
                    meeting.To = (meeting.From.AddHours(1));
                    meeting.EventName = eventNameCollection[randomTime.Next(9)];
                    meeting.color = colorCollection[randomTime.Next(9)];
                    Meetings.Add(meeting);
                }
            }
        }

        /// <summary>  
        /// Kreirani programi  
        /// </summary>  
        private void CreateEventNameCollection()
        {
            eventNameCollection = new List<string>();
            eventNameCollection.Add("Crossfit");
            eventNameCollection.Add("Flow fit");
            eventNameCollection.Add("Lift&Pump");
            eventNameCollection.Add("Fat Burning");
            eventNameCollection.Add("Boks");
            eventNameCollection.Add("Yoga Therapy");
            eventNameCollection.Add("Zumba");
            eventNameCollection.Add("Kruzni trening");
            eventNameCollection.Add("Trx");
            eventNameCollection.Add("Aerial Hoop");
        }

        /// <summary>  
        /// Kreirane boje.  
        /// </summary>  
        private void CreateColorCollection()
        {
            colorCollection = new List<Color>();
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF1BA1E2"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
        }

        /// <summary>
        /// Time range.
        /// </summary>
        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace InterfaceCli.Models
{
    public class Dates
    {
        public Dates()
        {
            MondayOfTheWeek();
        }

        DateTime date1;
        DateTime date2;
        DateTime date3;
        DateTime date4;
        DateTime date5;
        DateTime date6;
        DateTime date7;
        string datestr1;
        string datestr2;
        string datestr3;
        string datestr4;
        string datestr5;
        string datestr6;
        string datestr7;

        public DateTime Date1 { get => date1; set => date1 = value; }
        public DateTime Date2 { get => date2; set => date2 = value; }
        public DateTime Date3 { get => date3; set => date3 = value; }
        public DateTime Date4 { get => date4; set => date4 = value; }
        public DateTime Date5 { get => date5; set => date5 = value; }
        public DateTime Date6 { get => date6; set => date6 = value; }
        public DateTime Date7 { get => date7; set => date7 = value; }
        public string Datestr1 { get => datestr1; set => datestr1 = value; }
        public string Datestr2 { get => datestr2; set => datestr2 = value; }
        public string Datestr3 { get => datestr3; set => datestr3 = value; }
        public string Datestr4 { get => datestr4; set => datestr4 = value; }
        public string Datestr5 { get => datestr5; set => datestr5 = value; }
        public string Datestr6 { get => datestr6; set => datestr6 = value; }
        public string Datestr7 { get => datestr7; set => datestr7 = value; }


        //    public List<Button> ListButton1 { get => listButton1; set => listButton1 = value; }
        //    public List<Button> ListButton2 { get => listButton2; set => listButton2 = value; }
        //    public List<Button> ListButton3 { get => listButton3; set => listButton3 = value; }
        //    public List<Button> ListButton4 { get => listButton4; set => listButton4 = value; }
        //    public List<Button> ListButton5 { get => listButton5; set => listButton5 = value; }
        //    public List<Button> ListButton6 { get => listButton6; set => listButton6 = value; }
        //    public List<Button> ListButton7 { get => listButton7; set => listButton7 = value; }


        //    private List<Button> listButton1 = new List<Button>();
        //    private List<Button> listButton2 = new List<Button>();
        //    private List<Button> listButton3 = new List<Button>();
        //    private List<Button> listButton4 = new List<Button>();
        //    private List<Button> listButton5 = new List<Button>();
        //    private List<Button> listButton6 = new List<Button>();
        //    private List<Button> listButton7 = new List<Button>();

        //    public void Today()
        //    {
        //        if (Date1 == DateTime.Today)
        //        {
        //            Datestr1 = "Aujourd'hui";
        //        }
        //        else if (Date2 == DateTime.Today)
        //        {
        //            Datestr2 = "Aujourd'hui";
        //        }
        //        else if (Date3 == DateTime.Today)
        //        {
        //            Datestr3 = "Aujourd'hui";
        //        }
        //        else if (Date4 == DateTime.Today)
        //        {
        //            Datestr4 = "Aujourd'hui";
        //        }
        //        else if (Date5 == DateTime.Today)
        //        {
        //            Datestr5 = "Aujourd'hui";
        //        }
        //        else if (Date6 == DateTime.Today)
        //        {
        //            Datestr6 = "Aujourd'hui";
        //        }
        //        else if (Date7 == DateTime.Today)
        //        {
        //            Datestr7 = "Aujourd'hui";
        //        }
        //    }


        public void MondayOfTheWeek()
        {
            DateTime currdate = DateTime.Today;
            int delta = DayOfWeek.Monday - currdate.DayOfWeek;
            DateTime monday = currdate.AddDays(delta);

            Date1 = monday;
            Date2 = monday.AddDays(1);
            Date3 = monday.AddDays(2);
            Date4 = monday.AddDays(3);
            Date5 = monday.AddDays(4);
            Date6 = monday.AddDays(5);
            Date7 = monday.AddDays(6);

            Datestr1 = Date1.ToString("dd/MM");
            Datestr2 = Date2.ToString("dd/MM");
            Datestr3 = Date3.ToString("dd/MM");
            Datestr4 = Date4.ToString("dd/MM");
            Datestr5 = Date5.ToString("dd/MM");
            Datestr6 = Date6.ToString("dd/MM");
            Datestr7 = Date7.ToString("dd/MM");

            //Today();
            //Button();
        }

        public void AddWeek()
        {
            Date1 = date1.AddDays(7);
            Date2 = date2.AddDays(7);
            Date3 = date3.AddDays(7);
            Date4 = date4.AddDays(7);
            Date5 = date5.AddDays(7);
            Date6 = date6.AddDays(7);
            Date7 = date7.AddDays(7);

            Datestr1 = Date1.ToString("dd/MM");
            Datestr2 = Date2.ToString("dd/MM");
            Datestr3 = Date3.ToString("dd/MM");
            Datestr4 = Date4.ToString("dd/MM");
            Datestr5 = Date5.ToString("dd/MM");
            Datestr6 = Date6.ToString("dd/MM");
            Datestr7 = Date7.ToString("dd/MM");


            //        Today();
            //        ListButton1.Clear();
            //        ListButton2.Clear();
            //        ListButton3.Clear();
            //        ListButton4.Clear();
            //        ListButton5.Clear();
            //        ListButton6.Clear();
            //        ListButton7.Clear();
            //        Button();
            //        ListButton1.DataBind(); 
            //        CollectionViewSource.GetDefaultView(ListButton2).Refresh();
            //        CollectionViewSource.GetDefaultView(ListButton3).Refresh();
            //        CollectionViewSource.GetDefaultView(ListButton4).Refresh();
            //        CollectionViewSource.GetDefaultView(ListButton5).Refresh();
            //        CollectionViewSource.GetDefaultView(ListButton6).Refresh();
            //        CollectionViewSource.GetDefaultView(ListButton7).Refresh();

        }

        //    public void RemoveWeek()
        //    {
        //        Date1 = date1.AddDays(-7);
        //        Date2 = date2.AddDays(-7);
        //        Date3 = date3.AddDays(-7);
        //        Date4 = date4.AddDays(-7);
        //        Date5 = date5.AddDays(-7);
        //        Date6 = date6.AddDays(-7);
        //        Date7 = date7.AddDays(-7);

        //        Datestr1 = Date1.ToString("dd/MM");
        //        Datestr2 = Date2.ToString("dd/MM");
        //        Datestr3 = Date3.ToString("dd/MM");
        //        Datestr4 = Date4.ToString("dd/MM");
        //        Datestr5 = Date5.ToString("dd/MM");
        //        Datestr6 = Date6.ToString("dd/MM");
        //        Datestr7 = Date7.ToString("dd/MM");

        //        Today();
        //        ListButton1.Clear();
        //        ListButton2.Clear();
        //        ListButton3.Clear();
        //        ListButton4.Clear();
        //        ListButton5.Clear();
        //        ListButton6.Clear();
        //        ListButton7.Clear();
        //        Button();
        //        CollectionViewSource.GetDefaultView(ListButton1).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton2).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton3).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton4).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton5).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton6).Refresh();
        //        CollectionViewSource.GetDefaultView(ListButton7).Refresh();
        //    }
    }
}
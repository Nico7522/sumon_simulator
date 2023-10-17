using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using summon.Models;
using System.Text;
using PersonalTimer = System.Timers;
using System.Diagnostics.Metrics;
using summon.Utils;

namespace summon.Models
{
    public class Banner
    {

     
        #region Field
        private List<Unit> _unitsBanner;
        private string _bannerName;
        public event Action OnSumon;

        #endregion

        #region Props
        public string BannerName { get { return _bannerName; } }
        public List<Unit> UnitsList
        {
            get
            {
                return _unitsBanner.ToList();
            }
        }
        #endregion


        #region Indexers
        public Unit this[string name]
        {
            get
            {
                Unit? isUnitExist = null;
                foreach (Unit unit in _unitsBanner)
                {
                return isUnitExist = unit.Name == name ? unit : null;
                    
                }
                return isUnitExist;
            }
        }


        #endregion

        #region Ctor
        public Banner()
        {
            _unitsBanner = new List<Unit>();


        }
        #endregion

        #region Methods

        public void AddUnit(params Unit[] units)
        {
            foreach (Unit u in units)
            {
                if (_unitsBanner.Contains(u))
                {
                    Console.WriteLine(u.Name);
                    throw new Exception("Unit already in banner");
                }
            }
            _unitsBanner.AddRange(units);
        }

        public void Sumon()
        {
            Dice dice = new Dice(1000);
            int randomInt = dice.Throw();

            if (randomInt >= 1 && randomInt <= 900)
            {
                switch (randomInt)
                {
                    case <= 300:
                        Method.RarityDisplay(_unitsBanner[1]);
                        break;
                    case <= 700:
                        Method.RarityDisplay(_unitsBanner[0]);
                        break;
                    case <= 900:

                        Method.RarityDisplay(_unitsBanner[2]);
                        break;
                }
            }
            else if (randomInt > 900 && randomInt < 990)
            {
                switch (randomInt)
                {
                    case <= 935:
                        Method.RarityDisplay(_unitsBanner[4]);
                        break;
                    case <= 960:
                        Method.RarityDisplay(_unitsBanner[3]);
                        break;
                    case <= 989:
                        Method.RarityDisplay(_unitsBanner[5]);
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Method.RarityDisplay(_unitsBanner[6]);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void StartSumon()
        {
            Console.WriteLine("Single or Multi-summon ? 1 : single, 2 : Multi, 3 : exit");
            string response = Console.ReadLine();
            bool stop = false;
            while ((response != "1" || response != "2" || response != "3") && stop == false)
            {

                if (response == "1")
                {
                    this.Sumon();
                    stop = true;

                }
                else if (response == "2")
                {
                    //int i = 0;
                    //while (i < 10)
                    //{
                    //    //this.OnSumon += this.Sumon;
                    //    i++;
                    //}

                    SumonWithInterval();
                    //OnSumon?.Invoke();
                    stop = true;
                }
                else if (response == "3")
                {
                    Console.WriteLine("Bye !");
                    stop = true;

                }
                else
                {
                    Console.WriteLine("Please tap 1, 2 or 3");
                    response = Console.ReadLine();
                }

            }
        }

        private void DisplayLoading()
        {
            PersonalTimer.Timer bTimer;

            bTimer = new PersonalTimer.Timer();
            int count = 0;
            bTimer.Interval = 300;
            bTimer.Elapsed += OnTimedEvent2;
            bTimer.AutoReset = true;
            bTimer.Enabled = true;
            void OnTimedEvent2(object sender, EventArgs e)
            {
                if (count < 3)
                {
                Console.Write("-");
                count++;
                } else
                {
                    bTimer.Stop();
                }
            }
        }

        public void SumonWithInterval()
        {
            PersonalTimer.Timer aTimer;
         
            aTimer = new PersonalTimer.Timer();
            aTimer.Interval = 1000;
            int count = 0;

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Stop();

            aTimer.Enabled = true;


                Console.WriteLine("Loading ...");
            Console.ReadLine();
            aTimer.Stop();
            void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
            {
                if (count < 10)
                {
                    DisplayLoading();
                    Console.WriteLine();
                    this.Sumon();
                    count++;
             
                }
                else
                {
                    aTimer.Stop();
                    Environment.Exit(0);

                }
            }
        }

        #endregion
    }
}

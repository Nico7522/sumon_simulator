using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
                        Console.WriteLine($"{_unitsBanner[1].Name} | {_unitsBanner[1].Rarity} *");
                        break;
                    case <= 700:
                        Console.WriteLine($"{_unitsBanner[0].Name} | {_unitsBanner[0].Rarity} *");
                        break;
                    case <= 900:
                        Console.WriteLine($"{_unitsBanner[2].Name} | {_unitsBanner[2].Rarity} *");
                        break;
                }
            }
            else if (randomInt > 900 && randomInt < 990)
            {
                switch (randomInt)
                {
                    case <= 935:
                        Console.WriteLine($"{_unitsBanner[4].Name} | {_unitsBanner[4].Rarity} *");
                        break;
                    case <= 960:
                        Console.WriteLine($"{_unitsBanner[3].Name} | {_unitsBanner[3].Rarity} *");
                        break;
                    case <= 989:
                        Console.WriteLine($"{_unitsBanner[5].Name} | {_unitsBanner[5].Rarity} *");
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{_unitsBanner[6].Name} | {_unitsBanner[6].Rarity} *");
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
                    int i = 0;
                    while (i < 10)
                    {
                        this.OnSumon += this.Sumon;
                        i++;
                    }

                    OnSumon?.Invoke();
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
        #endregion
    }
}

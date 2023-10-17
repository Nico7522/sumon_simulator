using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summon.Models
{
    public class Unit
    {

        #region Field
        private string _name;
        private string _rarity;


        #endregion

        #region Props
        public string Name { get { return _name; } }
        public string Rarity { get { return _rarity; } }



        #endregion

        #region Ctor

        public Unit(string name, string rarity)
        {
            this._name = name;
            this._rarity = rarity;
        }
        #endregion
    }
}

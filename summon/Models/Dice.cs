using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summon.Models
{
    public class Dice
    {
        #region Field
        private Random _random;

        #endregion

        #region Props

        public int Minimum { get; set; }  
        public int Maximum { get; set; }
        #endregion

        #region Ctor
        public Dice(int max, int min = 1)
        {
            this.Maximum = max;
            this.Minimum = min;
            _random = new Random();
        }



        #endregion

        #region Methods
        public int Throw()
        {
            return _random.Next(Minimum, Maximum + 1);
        }

        #endregion
    }
}

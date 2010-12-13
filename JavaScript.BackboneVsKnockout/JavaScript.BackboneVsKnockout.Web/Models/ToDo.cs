using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScript.BackboneVsKnockout.Web.Model
{
    public class ToDo
    {
        private static IList<ToDo> _all;

        #region Constructors
        public ToDo()
        {
        }

        public ToDo(string task)
        {
            Task = task;
        }

        static ToDo()
        {
            _all = new List<ToDo>
            {
                new ToDo("Fab Times"),
                new ToDo("Dancing")
            };
        } 
        #endregion

        #region Properties
        public string Task { get; set; }
        public bool Complete { get; set; }
        #endregion

        public static IList<ToDo> All
        {
            get { return _all; }
            set { _all = value; }
        }        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Controls;

namespace WPFPreProject
{
    public class building
    {

        public int id { get; set; }

        public string buildingName { get; set; }


        /*public override string ToString()
        {
            return buildingName;
        }*/

    }



}

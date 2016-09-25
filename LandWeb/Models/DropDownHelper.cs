using LandWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandWeb.Models
{
    public static class DropDownHelper
    {
        public static SelectList GetCellList()
        {
            DAL dal = new DAL(); 
            List<SelectListItem> cellList = new List<SelectListItem>();
            cellList.Add(new SelectListItem()
                {
                    Value = "",
                    Text = "Select"
                }
            );

            foreach (var c in dal.GetCellList().Where(a => a.code != 0))
            {
                cellList.Add(new SelectListItem()
                    {
                        Value = ((int)c.code).ToString(),
                        Text = c.name
                    }
                );
            }


            return new SelectList(cellList);
        }
    }
}
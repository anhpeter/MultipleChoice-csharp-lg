﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    class Msg
    {
        public static String INSERTED = "Inserted successfully!";
        public static String DELETED = "Deleted successfully!";
        public static String UPDATED = "Updated successfully!";
        //
        public static String DELETE_CONFIRM = "Do you want to delete this one?";
        //
        public static String CHOOSE_AN_ITEM = "Please choose an item";
        // VLD
        public static String VLD_REQURIED = "{0} must be not empty.";
        public static String VLD_LENGTH_BETWEEN = "{0} must have length between {1}-{2}.";
        public static String VLD__BETWEEN = "{0} value must between {1}-{2}.";

    }
}

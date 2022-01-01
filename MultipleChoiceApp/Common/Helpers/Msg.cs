using System;
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
        public static String IMPORTED = "Imported {0} items!";
        public static String EXPORTED = "Exported {0} items!";
        public static String IMPORT_DATA_INVALID = "Your import data is invalid!";
        public static String IMPORTED_FAILED = "Failed to import!";
        public static String EXPORTED_FAILED = "Failed to export!";
        //
        public static String DELETE_CONFIRM = "Do you want to delete this one?";
        public static String SUBMIT_EXAM_CONFIRM = "Do you want to submit your exam?";
        //
        public static String CHOOSE_AN_ITEM = "Please choose an item!";
        public static String DELETE_CONSTRAINT_ERROR = "Unable to delete due to reference data lost!";
        // VLD
        public static String VLD_REQURIED = "{0} must be not empty.";
        public static String VLD_NUMBER = "{0} must be a number.";
        public static String VLD_INVALID = "{0} is not valid.";
        public static String VLD_UNIQUE = "{0} must be unique.";
        public static String VLD_LENGTH_BETWEEN = "{0} must have length between {1}-{2}.";
        public static String VLD_MAX_LENGTH = "{0} must have length less than {1}.";
        public static String VLD_BETWEEN = "{0} value must between {1}-{2}.";
        public static String VLD_DATE_NOT_AVAILABLE = "Already have an {0} exam between {1} and {2}";
        // MSG
        public static String TAKEN_EXAM_ALREADY = "You have already taken this exam";
        public static String CHOOSE_AN_EXAM = "Please select your exam!";

    }
}

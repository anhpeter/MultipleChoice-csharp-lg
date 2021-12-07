using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    public class Pagination
    {
        public int itemsPerPage { get; set; }
        public int pageRange { get; set; }
        public int totalItems { get; set; }
        public int totalPage { get; set; }
        public int currentPage { get; set; }
        public int start { get; set; }
        public int end { get; set; }

        public Pagination(int totalItems = 0, int currentPage = 1, int itemsPerPage = 5, int pageRange = 3)
        {
            this.itemsPerPage = itemsPerPage;
            this.pageRange = pageRange;
            setTotalItems(totalItems);
            setCurrentPage(currentPage);
        }

        public void setTotalItems(int value)
        {
            this.totalItems = value;
            this.totalPage = value > 0 ? (int)Math.Ceiling((double)totalItems / this.itemsPerPage) : 10;
        }

        public void setCurrentPage(int value)
        {
            if (value >= 1 && value <= this.totalPage) this.currentPage = value;
            else if (value < 1) this.currentPage = 1;
            else this.currentPage = this.totalPage;
        }

        public void calculate()
        {

            int start;
            if (this.currentPage <= Math.Ceiling((double)this.pageRange / 2))
                start = 1;
            else if (this.currentPage >= totalPage - Math.Floor((double)pageRange / 2))
                start = totalPage - pageRange + 1;
            else start = this.currentPage - (int)Math.Floor((double)pageRange / 2);
            this.start = start;
            this.end = start + pageRange - 1;
        }

        public void showResult()
        {
            Util.log($"\n\nItems Per Page: {itemsPerPage}");
            Util.log($"Page Range: {pageRange}");
            Util.log($"Total Items: {totalItems}");
            Util.log($"Current Page: {currentPage}");
            Util.log($"\n\nTotal Page: {totalPage}");
            Util.log($"Start: {start}");
            Util.log($"End: {end}");
            Util.log("End=====\n\n");
        }

        public int getPrevPage()
        {
            return currentPage > 1 ? currentPage - 1 : 1;
        }

        public int getNextPage()
        {
            return currentPage < totalPage ? currentPage + 1 : totalPage;
        }

        public Boolean isCurrentPage(int i)
        {
            return i == currentPage;
        }

        public Boolean isInvalidPage(int i)
        {
            return i > totalPage;
        }
    }
}

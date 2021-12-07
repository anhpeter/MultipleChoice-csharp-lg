using Bunifu.Framework.UI;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class PaginationControl : UserControl
    {
        public Pagination pagination { get; set; }
        IPagination mainForm;
        public PaginationControl(Pagination pagination, IPagination mainForm)
        {
            this.pagination = pagination;
            this.mainForm = mainForm;
            InitializeComponent();
            pagination.setTotalItems(mainForm.count());
            pagination.calculate();
            pagination.showResult();
            genPagination();
        }

        public void genPagination()
        {
            pnl_pagination_bar.Controls.Clear();
            //
            if (pagination.currentPage == 1)
            {
                pnl_pagination_bar.Controls.Add(genDisableButton("|<", "1"));
                pnl_pagination_bar.Controls.Add(genDisableButton("<", pagination.currentPage - 1 + ""));
            }
            else
            {
                pnl_pagination_bar.Controls.Add(genButton("|<", "1"));
                pnl_pagination_bar.Controls.Add(genButton("<", pagination.currentPage - 1 + ""));
            }
            //
            for (int i = pagination.start; i <= pagination.end; i++)
            {
                String pageNumber = i + "";
                BunifuFlatButton button;
                if (i == pagination.currentPage)
                {
                    button = genActiveButton(pageNumber, pageNumber);
                }
                else
                {
                    button = genButton(pageNumber, pageNumber);
                }

                pnl_pagination_bar.Controls.Add(button);
            }
            //
            if (pagination.currentPage == pagination.totalPage)
            {
                pnl_pagination_bar.Controls.Add(genDisableButton(">", pagination.currentPage + 1 + ""));
                pnl_pagination_bar.Controls.Add(genDisableButton(">|", pagination.totalPage + ""));
            }
            else
            {
                pnl_pagination_bar.Controls.Add(genButton(">", pagination.currentPage + 1 + ""));
                pnl_pagination_bar.Controls.Add(genButton(">|", pagination.totalPage + ""));

            }
        }

        private void onPageClick(object sender, EventArgs e)
        {
            String tag = ((BunifuFlatButton)sender).Tag.ToString();
            pagination.currentPage = Util.parseToInt(tag, 1);
            mainForm.onPage();
       }
        private BunifuFlatButton genActiveButton(String text, String tag)
        {
            BunifuFlatButton btn = new BunifuFlatButton();
            btn.Active = false;
            btn.Activecolor = System.Drawing.Color.DodgerBlue;
            btn.BackColor = System.Drawing.Color.DodgerBlue;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.BorderRadius = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.DisabledColor = System.Drawing.Color.Gray;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Iconcolor = System.Drawing.Color.DodgerBlue;
            btn.Iconimage = null;
            btn.Iconimage_right = null;
            btn.Iconimage_right_Selected = null;
            btn.Iconimage_Selected = null;
            btn.IconMarginLeft = 0;
            btn.IconMarginRight = 0;
            btn.IconRightVisible = true;
            btn.IconRightZoom = 0D;
            btn.IconVisible = true;
            btn.IconZoom = 70D;
            btn.IsTab = false;
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Normalcolor = System.Drawing.Color.DodgerBlue;
            btn.OnHovercolor = System.Drawing.Color.DodgerBlue;
            btn.OnHoverTextColor = System.Drawing.Color.White;
            btn.selected = false;
            btn.Size = new System.Drawing.Size(47, 43);
            btn.TabIndex = 18;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Textcolor = System.Drawing.Color.White;
            btn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            btn.Tag = tag;
            btn.ButtonText = text;
            btn.Text = text;

            return btn;
        }
        private BunifuFlatButton genButton(String text, String tag)
        {
            BunifuFlatButton btn = new BunifuFlatButton();
            btn.Name = "btn_pagination_tag";
            btn.Active = false;
            btn.Activecolor = System.Drawing.Color.Transparent;
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.BorderRadius = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.DisabledColor = System.Drawing.Color.Gray;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Iconcolor = System.Drawing.Color.Transparent;
            btn.Iconimage = null;
            btn.Iconimage_right = null;
            btn.Iconimage_right_Selected = null;
            btn.Iconimage_Selected = null;
            btn.IconMarginLeft = 0;
            btn.IconMarginRight = 0;
            btn.IconRightVisible = true;
            btn.IconRightZoom = 0D;
            btn.IconVisible = true;
            btn.IconZoom = 70D;
            btn.IsTab = false;
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Normalcolor = System.Drawing.Color.Transparent;
            btn.OnHovercolor = System.Drawing.Color.Transparent;
            btn.OnHoverTextColor = System.Drawing.Color.Black;
            btn.selected = false;
            btn.Size = new System.Drawing.Size(47, 43);
            btn.TabIndex = 18;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Textcolor = System.Drawing.Color.Black;
            btn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            btn.Tag = tag;
            btn.ButtonText = text;
            btn.Text = text;
            btn.Click += onPageClick;
            return btn;
        }
        private BunifuFlatButton genDisableButton(String text, String tag)
        {
            BunifuFlatButton btn = new BunifuFlatButton();
            btn.Active = false;
            btn.Activecolor = System.Drawing.Color.Transparent;
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn.BorderRadius = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.DisabledColor = System.Drawing.Color.Gray;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Iconcolor = System.Drawing.Color.Transparent;
            btn.Iconimage = null;
            btn.Iconimage_right = null;
            btn.Iconimage_right_Selected = null;
            btn.Iconimage_Selected = null;
            btn.IconMarginLeft = 0;
            btn.IconMarginRight = 0;
            btn.IconRightVisible = true;
            btn.IconRightZoom = 0D;
            btn.IconVisible = true;
            btn.IconZoom = 70D;
            btn.IsTab = false;
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Margin = new System.Windows.Forms.Padding(0);
            btn.Normalcolor = System.Drawing.Color.Transparent;
            btn.OnHovercolor = System.Drawing.Color.Transparent;
            btn.OnHoverTextColor = System.Drawing.Color.Silver;
            btn.selected = false;
            btn.Size = new System.Drawing.Size(47, 43);
            btn.TabIndex = 18;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Textcolor = System.Drawing.Color.Silver;
            btn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            btn.Tag = tag;
            btn.ButtonText = text;
            btn.Text = text;

            return btn;
        }
    }
}

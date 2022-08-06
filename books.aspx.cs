using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace WebApplication3
{
    public partial class books : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string PHOTO_FOLDER_NAME = "galleryimages/booklibrary/";
            string PHOTO_HEIGHT = "300px";

            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath(PHOTO_FOLDER_NAME));


                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] { 
                    new DataColumn("ImagerName", typeof(string)),
                    new DataColumn("ImageUrl",typeof(string)) });
              
        

                List<ListItem> files = new List<ListItem>();
                int imageCount = 0;

                var divHtml = new System.Text.StringBuilder();
                foreach (string filePath in filePaths)
                {
                    imageCount++;
                    string fileName = Path.GetFileName(filePath);
                    files.Add(new ListItem(fileName, PHOTO_FOLDER_NAME + fileName));
                    dt.Rows.Add(fileName, PHOTO_FOLDER_NAME + fileName);

                    divHtml.Append("<div ");
                    divHtml.Append(" style='padding:10px;float:left' id=id" + imageCount.ToString() + ">");
                    divHtml.Append("<img height='" + PHOTO_HEIGHT + "' id=img" + imageCount.ToString() + " src='" + PHOTO_FOLDER_NAME + fileName  + "'>");
                    divHtml.Append(" <br>    PBID # " + imageCount.ToString() + "</div>");
                    divHtml.Append("</div>");
                    
                }
                divImages.Text = divHtml.ToString();
                //GridBooks.DataSource = dt;

                //GridBooks.DataBind();

                //DL_Writers.DataSource = dt;
                //DL_Writers.DataBind();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;

namespace WUNI.DAOClass
{
    internal class ReviewDAO
    {
        private string tableName;
        private DBConnection conn;
        public ReviewDAO()
        {
            this.tableName = "Review";
            this.conn = new DBConnection();
        }

        public List<Review> GetReviewListFrom(int starNumber)
        {
            List<Review> reviews = new List<Review>();

            string query = string.Format("Seclect * from {0} Where StarNumber = '{1}'", this.tableName, starNumber);
            DataTable da = conn.AdapterExcute(query);
            foreach (DataRow row in da.Rows)
            {
                string reviewID = row[0].ToString();
                string customerID = row[1].ToString();
	            string workerID = row[2].ToString()
                string comment = row[3].ToString();
                string reviewImage = row[4].ToString();
	            int starNumber = int.Parse(row[5].ToString());

                Review review = new Review(reviewID, customerID, workerID, comment, reviewImage, starNumber);
                reviews.Add(review);

            }
            return orders;

        }
        public float StarAvgOf(string WorkerID)
        {


        }

        public void Add(Review review)
        {
            string sqlStr = string.Format("Insert into {0} (ReviewID, CustomerID, WorkerID, Comment, ReviewImage, StarNumber)" +
               "VALUES('{1}', '{2}',  '{3}', '{4}', '{5}', '{6}'",
               this.tableName, review.ReviewID, review.CustomerID, review.WorkerID, review.Comment, review.ReviewImage, review.StarNumber);
            this.conn.CommandExecute(sqlStr);

        }
    }
}

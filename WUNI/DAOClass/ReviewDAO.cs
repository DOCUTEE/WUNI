using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUNI.Class;
using System.Data;

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

            string query = string.Format("Select * from {0} Where StarNumber = '{1}'", this.tableName, starNumber);
            DataTable da = conn.AdapterExcute(query);
            foreach (DataRow row in da.Rows)
            {
                string reviewID = row[0].ToString();
                string customerID = row[1].ToString();
                string workerID = row[2].ToString();
                string comment = row[3].ToString();
                string reviewImage = row[4].ToString();
	            int starNum= int.Parse(row[5].ToString());

                Review review = new Review(reviewID, customerID, workerID, comment, reviewImage, starNum);
                reviews.Add(review);

            }
            return reviews;
        }
        public float StarAvgOf(string workerID)
        {

            string query = string.Format("SELECT AVG(StarNumber) AS agvStar FROM {0} WHERE WorkerID = '{1}' GROUP BY WorkerID", this.tableName, workerID);
            DataTable da = this.conn.AdapterExcute(query);
            return float.Parse(da.Rows[0][0].ToString());


        }

        public void Add(Review review)
        {
            string sqlStr = string.Format("Insert into {0} (ReviewID, CustomerID, WorkerID, Comment, ReviewImage, StarNumber)" +
               "VALUES('{1}', '{2}',  '{3}', '{4}', '{5}', '{6}'",
               this.tableName, review.ReviewID, review.CustomerID, review.WorkerID, review.Comment, review.ReviewImage, review.StarNumber);
            this.conn.CommandExecute(sqlStr);

        }

        public Review GetReviewFrom(string reviewID)
        {
            string query = string.Format("Select * from {0} Where ReviewID = '{1}'",this.tableName,reviewID);
            DataTable da = conn.AdapterExcute(query);
            if (da.Rows.Count != 0)
            {
                Review review = new Review(
                    da.Rows[0]["ReviewID"].ToString(),
                    da.Rows[0]["CustomerID"].ToString(),
                    da.Rows[0]["WorkerID"].ToString(),
                    da.Rows[0]["Comment"].ToString(),
                    da.Rows[0]["ReviewImage"].ToString(),
                    int.Parse(da.Rows[0]["StarNumber"].ToString())
                );
                return review;
            }
            return new Review();
        }
    }
}

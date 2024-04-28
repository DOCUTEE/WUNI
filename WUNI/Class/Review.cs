using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUNI.Class
{
    public class Review
    {
        private string reviewID;
        private string customerID;
        private string workerID;
        private string comment;
        private string reviewImage;
        private int starNumber;

        public Review()
        {
            this.reviewID = string.Empty;
            this.customerID = string.Empty;
            this.workerID = string.Empty;
            this.comment = string.Empty;
            this.reviewImage = "\\Logo\\WUNI.jpg";
            this.starNumber = 0;
        }
        public Review(string reviewID, string customerID, string workerID, string comment, string reviewImage, int starNumber)
        {
            this.reviewID = reviewID;
            this.customerID = customerID;
            this.workerID = workerID;
            this.comment = comment;
            this.reviewImage = "\\ReviewImage\\" + this.reviewID.ToString() + ".png";
            this.starNumber = starNumber;
        }

        public string ReviewID { get => reviewID; set => reviewID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string Comment { get => comment; set => comment = value; }
        public string ReviewImage { get => reviewImage; set => reviewImage = value; }
        public int StarNumber { get => starNumber; set => starNumber = value; }
    }
}

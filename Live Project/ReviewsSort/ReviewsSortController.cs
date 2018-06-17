/*
add sort functionality to the Index page of the Reviews in the form of a dropdown to sort by product name and rating 

took the ViewBag property passed from the view and sorted model data according to the value of the the sort parameter
*/


            ViewBag.NameSortParm = "name";
            ViewBag.NameDescSortParm = "name_desc";
            ViewBag.RatingSortParm = "rating";
            ViewBag.RatingDescSortParm = "rating_desc";

            switch (sortOrder)
            {  //sort reviews based on "Sort by" dropdown selection
                case "name":
                    campaignsWithReviews = campaignsWithReviews.OrderBy(r => r.Name);
                    break;
                case "name_desc":
                    campaignsWithReviews = campaignsWithReviews.OrderByDescending(r => r.Name);
                    break;
                case "rating":
                    campaignsWithReviews = from campaigns in db.Campaigns
                                           from reviews in db.Reviews
                                           where campaigns.CampaignID == reviews.CampaignId
                                           orderby reviews.ProductRating
                                           select campaigns;
                    break;
                case "rating_desc":
                    campaignsWithReviews = from campaigns in db.Campaigns
                                           from reviews in db.Reviews
                                           where campaigns.CampaignID == reviews.CampaignId
                                           orderby reviews.ProductRating descending
                                           select campaigns;
                    break;
            }


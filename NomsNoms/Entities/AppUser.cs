﻿using Microsoft.AspNetCore.Identity;

namespace NomsNoms.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string KnownAs { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public int? SubscriptionId { get; set; }
        public ICollection<UserFollow> FollowedUsers { get; set; }
        public ICollection<UserFollow> FollowedByUsers { get; set; }
        public ICollection<RecipeLike> LikedRecipes { get; set; }
        public ICollection<UserMealPlan> UserMealPlans { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public Subscription Subscription { get; set; }
        public ICollection<UserFavorite> UserFavorites { get; set; }
        public ICollection<UserCollection> UserCollections { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}

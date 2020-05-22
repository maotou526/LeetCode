using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.设计推特
{
      //      设计一个简化版的推特(Twitter)，可以让用户实现发送推文，关注/取消关注其他用户，能够看见关注人（包括自己）的最近十条推文。你的设计需要支持以下的几个功能： 
      //postTweet(userId, tweetId) : 创建一条新的推文
      // getNewsFeed(userId): 检索最近的十条推文。每个推文都必须是由此用户关注的人或者是用户自己发出的。推文必须按照时间顺序由最近的开始排序。
      //follow(followerId, followeeId) : 关注一个用户
      // unfollow(followerId, followeeId): 取消关注一个用户 
      public class Twitter
      {
            List<Article> list = new List<Article>();
            List<int> users = new List<int>();//用户
            List<KeyValuePair<int, int>> relations = new List<KeyValuePair<int, int>>(); //保存关注关系
            /** Initialize your data structure here. */
            public Twitter()
            {

            }

            /** Compose a new tweet. */
            public void PostTweet(int userId, int tweetId)
            {
                  var info = new Article();
                  info.userId = userId;
                  info.tweetId = tweetId;
                  list.Add(info);
            }

            /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
            public IList<int> GetNewsFeed(int userId)
            {
                  var users = relations.Where(x => x.Key == userId).Select(x => x.Value).ToList();
                  users.Add(userId);
                  var result = new List<int>();
                  if (list.Count > 0)
                  {
                        for (int i = list.Count - 1; i >= 0 && result.Count < 10; i--)
                        {
                              var info = list[i];
                              if (users.IndexOf(info.userId) > -1)
                              {
                                    result.Add(info.tweetId);
                              }
                        }
                  }
                  return result;
            }

            /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
            public void Follow(int followerId, int followeeId)
            {
                  if (followerId != followeeId)
                  {
                        var item = new KeyValuePair<int, int>(followerId, followeeId);
                        if (!relations.Contains(item))
                        {
                              relations.Add(item);
                        }
                  }
            }

            /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
            public void Unfollow(int followerId, int followeeId)
            {
                  if (followerId != followeeId)
                  {
                        var item = new KeyValuePair<int, int>(followerId, followeeId);
                        var index = relations.IndexOf(item);
                        if (index > -1)
                        {
                              relations.RemoveAt(index);
                        }
                  }
            }
      }

      public class Article
      {
            public int tweetId;
            public int userId;
      }
}

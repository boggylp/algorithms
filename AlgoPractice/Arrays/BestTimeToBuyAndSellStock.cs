﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice.Arrays
{
    public static class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
        /// On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time.
        /// However, you can buy it then immediately sell it on the same day.
        /// Find and return the maximum profit you can achieve.
        /// 
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 7
        /// Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
        /// Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
        /// Total profit is 4 + 3 = 7.
        /// 
        /// Example 2:
        /// Input: prices = [1,2,3,4,5]
        /// Output: 4
        /// Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
        /// Total profit is 4.
        /// 
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        /// Explanation: There is no way to make a positive profit, so we never buy the stock to achieve the maximum profit of 0.
        /// </summary>
        /// <param name="prices">prices</param>
        /// <returns>max profit</returns>
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            if (prices == null || prices.Length == 0)
                return maxProfit;

            int buyingPoint = -1;
            int sellingPoint = -1;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    if (prices[i] < prices[buyingPoint])
                    {

                    }
                }
                else if (prices[i] > prices[i + 1])
                {

                }
            }
            return 0;
        }
    }
}

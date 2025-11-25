using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Udemy
{
    class MaxStockProfit
    {
    }
}
/*
function maxStockProfit(arr) {
  // take a single array and returns the max possible profit
  var maxProfit = -1;
  var buyPrice = 0;;
  var sellPrice = 0;
  
  var changeBuyPrice = true;

  for (var i=0; i<arr.length; i++){
    if(changeBuyPrice) {
      buyPrice = arr[i];
    }
    sellPrice = arr[i+1];

    if(sellPrice < buyPrice) {
      changeBuyPrice = true;
      // no need to calculate since the next price is lower
    }
    else {
      var tempProfit = sellPrice - buyPrice;
      if (tempProfit > maxProfit) {
        maxProfit = tempProfit;
      }
      changeBuyPrice = false;
    }
    console.log("buy:", buyPrice, "sell:", sellPrice, "profit:", (sellPrice - buyPrice), "changeBuyPrice", changeBuyPrice);
  }
  return maxProfit;
}

console.log(maxStockProfit([32,46,26,38,40,48,42,20]));


function maxStockProfit0 (pricesArr) {
  var maxProfit = -1;
  var buyPrice = 0;
  var sellPrice = 0;
  
  var changeBuyPrice = true;
  
  for (var i = 0; i < pricesArr.length; i++) {
    if (changeBuyPrice) buyPrice = pricesArr[i];
    sellPrice = pricesArr[i + 1];
    
    if (sellPrice < buyPrice) {
      changeBuyPrice = true;
    }
    else {
      var tempProfit = sellPrice - buyPrice;
      if (tempProfit > maxProfit) maxProfit = tempProfit;
      changeBuyPrice = false;
    }
  }
  return maxProfit;
}


function maxStockProfit1(arr) {
  // take a single array and returns the max possible profit
  var maxDiff = [];
  var maxVal = 0;
  var buyPrice = 0;;
  var sellPrice = 0;
  for (var i=0; i<arr.length; i++){
    for(var j=i+1; j<arr.length; j++) {
      // console.log("i:", i,"j:", j);
      var diff = arr[j]-arr[i];
      maxDiff.push([arr[i], arr[j], diff]);
      if(diff > maxVal){
        maxVal = diff;
        buyPrice = arr[i];
        sellPrice = arr[j];
      }

    }
  }
  console.log(maxDiff);
  console.log("buy:", buyPrice, "sell:", sellPrice, "profit:", maxVal);
  return  maxVal;
}

console.log(maxStockProfit1([32,46,26,38,40,48,42]));
*/
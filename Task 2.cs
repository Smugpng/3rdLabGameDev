using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    private float bookCost = 6f;//Price of book
    private float discountPercent =.40f; //discount for books
    private float amountOfBooks = 10f; //amount of books sold
    private float firstShippingCost = 3f; //cost for first book shipping
    private float otherShippingCost = .75f; //cost of other books shipping
    private float noDissountTotal;
    private float discountTotal;
    private float discountPrice;
    private float firstBookNormal;
    private float firstBookDisount;
    private float otherBookShipping;
    private float otherBookShippingWithDiscount;
    

    // Start is called before the first frame update


    float BookWithDiscount(float bookCost, float discountPercent) //What books cost to the bookstore
    {
        float discountPrice = bookCost * discountPercent;
        return discountPrice;
    }
    float FirstShippingPrice(float bookCost, float firstShippingCost) //cost to ship first with no discount
    {
        float firstBookNormal = bookCost + firstShippingCost;
        return firstBookNormal;
    }
    float FirstShippingWDiscount(float discountPrice, float firstShippingCost) //cost to ship first with  discount
    {
        float firstBookDisount = discountPrice + firstShippingCost;
        return firstBookDisount;
    }
    float OtherBookNumbers(float amountOfBooks) //amount of books other than the first
    {
        float otherBook = amountOfBooks - 1f;
        return otherBook;
    }
    float OtherBookShipping(float otherBook, float otherShippingCost, float bookCost) //normal cost with shipping
    {
        float otherBookShipping = (otherBook * bookCost) + (otherBook * otherShippingCost);
        return otherBookShipping;
    }
    float OtherBookShippingDiscount(float otherBook, float otherShippingCost, float discountPrice) //discount cost with shipping
    {
        float otherBookShippingWithDiscount = (otherBook * discountPrice) + (otherBook * otherShippingCost);
        return otherBookShippingWithDiscount;
    }

    float TotalWithDiscount(float firstBookDisount, float OtherBookShippingWithDiscount) //total cost of discounted books
    {
        float discountTotal = firstBookDisount + OtherBookShippingWithDiscount;
        return discountTotal;
    }
    float TotalWithOutDiscount(float firstBookNormal, float OtherBookShipping) // total cost of non discounted books
    {
        float noDissountTotal = firstBookNormal + OtherBookShipping;
        return noDissountTotal;
    }
    
    float TotalProfit(float noDissountTotal, float discountTotal) //total profit
    {
        float profitTotal = noDissountTotal - discountTotal;
        return profitTotal;
        
    }


    void Start()
    {
        discountPrice = BookWithDiscount(bookCost, discountPercent);
        firstBookNormal = FirstShippingPrice(bookCost, firstShippingCost);
        firstBookDisount = FirstShippingWDiscount(discountPrice, firstShippingCost);
        float otherBookCount = OtherBookNumbers(amountOfBooks);
        otherBookShipping = OtherBookShipping(otherBookCount, otherShippingCost, bookCost);
        otherBookShippingWithDiscount = OtherBookShippingDiscount(otherBookCount, otherShippingCost, discountPrice);
        discountTotal = TotalWithDiscount(firstBookDisount, otherBookShippingWithDiscount);
        noDissountTotal = TotalWithOutDiscount(firstBookNormal, otherBookShipping);
        float profitTotal = TotalProfit(noDissountTotal, discountTotal);

        
        Debug.Log("Discounted Price per book: $" + discountPrice);
        Debug.Log("Cost to ship first book without discount: $" + firstBookNormal);
        Debug.Log("Cost to ship first book with discount: $" + firstBookDisount);
        Debug.Log("Number of other books: " + otherBookCount);
        Debug.Log("Cost to ship other books without discount: $" + otherBookShipping);
        Debug.Log("Cost to ship other books with discount: $" + otherBookShippingWithDiscount);
        Debug.Log("Total cost with discount: $" + discountTotal);
        Debug.Log("Total cost without discount: $" + noDissountTotal);
        Debug.Log("Total profit: $" + profitTotal);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

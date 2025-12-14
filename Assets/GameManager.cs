using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("GameState")]
    public int currentMoney = 100;
    public int coffeeStock = 10;
    public int currentPrice = 5;
    public int currentDay = 1;

    private const int STOCK_COST = 10;
    private const int STOCK_GAIN = 10;
    private const int MIN_PRICE = 1;
    private const float BASE_DEMAND = 5f;

    [Header("UI References")]
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI stockText;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI summaryText;

    public GameObject inputPanel;
    void Start()
    {
        UpdateUI();
        summaryText.text = "Selamat datang di Kedai Kopi Mini Anda!";
    }

    public void UpdateUI()
    {
        moneyText.text = $"Uang: ${currentMoney}";
        stockText.text = $"Stok Kopi: {coffeeStock}";
        priceText.text = $"Harga Kopi: ${currentPrice}";
        dayText.text = $"Hari ke: {currentDay}";

    }

    public void BuyStock()
    {
        if (currentMoney >= STOCK_COST)
        {
            currentMoney -= STOCK_COST;
            coffeeStock += STOCK_GAIN;
            summaryText.text = $"Anda membeli {STOCK_GAIN} biji kopi seharga ${STOCK_COST}.";
        }
        else
        {
            summaryText.text = "Uang tidak cukup untuk membeli stok baru!";
        }
        UpdateUI();
    }

    public void ChangePrice(int amount)
    {
        currentPrice += amount;
        if (currentPrice < MIN_PRICE)
        {
            currentPrice = MIN_PRICE;
        }
        summaryText.text = $"Harga kopi diatur menjadi ${currentPrice}.";
        UpdateUI();
    }

}

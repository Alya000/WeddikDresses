using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Класс, представляющий свадебное платье
class Dress : public MonoBehaviour
{
public:
    // Сериализованные поля для кнопок и форм
    [SerializeField] private GameObject buttonAddToCart;
[SerializeField] private GameObject buttonMakingAnOrder;
[SerializeField] private GameObject formRegister;
[SerializeField] private GameObject formDecoration;
[SerializeField] private GameObject openingAnElement;
[SerializeField] public GameObject versionOne;
[SerializeField] public GameObject versionSecond;
[SerializeField] public GameObject linkOnPrefab; // Связь с другим префабом

// Сериализованные поля для других компонентов
[SerializeField] private User user;
[SerializeField] private Basket basket;
[SerializeField] public AnOpenElement _anOpenElement;
[SerializeField] public AnOpenElement _anOpenElement2;

private int _value = 0;
private bool _inBasket;

// Метод для добавления в корзину
public void AddInBasket()
{
    if (_inBasket)
    {
        FormPrimOpen();
    }
    else
    {
        basket.DeleteArray();
        buttonAddToCart.SetActive(false);
        buttonMakingAnOrder.SetActive(true);
        _inBasket = true;
        user.AddInBasketArray(gameObject);
        basket.OutputToTheScreen();
        Debug.Log("EXL");
    }
}

// Метод для открытия формы при повторном нажатии на кнопку добавления в корзину
public void FormPrimOpen()
{
    FormDecorationOpen();
}

// Метод для открытия формы регистрации
public void FormRegisterOpen()
{
    formRegister.SetActive(true);
}

// Метод для открытия формы украшения
public void FormDecorationOpen()
{
    _anOpenElement.openElement.Clear();
    versionOne.SetActive(false);
    versionSecond.SetActive(true);
    _anOpenElement.openElement.Add(gameObject);
    _anOpenElement.OutputToTheScreen();
    formDecoration.SetActive(true);
}

// Метод для открытия элемента свадебного платья
public void OpeningDress()
{
    openingAnElement.SetActive(true);
}

// Метод для открытия формы украшения в меню
public void FormDecorationOpenInMenu()
{
    _anOpenElement2.openElement.Add(gameObject);
    _anOpenElement2.openElement[0].GetComponent<Dress>()->OpenVersion();
    openingAnElement.SetActive(true);
    _anOpenElement2.OutputToTheScreen();
}

// Метод для закрытия свадебного платья
public void CloseDress()
{
    CloseVersion();
    openingAnElement.SetActive(false);
}

// Метод для закрытия версии свадебного платья
public void CloseVersion()
{
    versionOne.SetActive(true);
    versionSecond.SetActive(false);
}

private:
    // Приватный метод для открытия версии свадебного платья
    void OpenVersion()
{
    versionOne.SetActive(false);
    versionSecond.SetActive(true);
}

// Метод для закрытия элемента корзины
public void CloseBasketElement()
{
    linkOnPrefab.GetComponent<Dress>()->versionOne.SetActive(true);
    linkOnPrefab.GetComponent<Dress>()->versionSecond.SetActive(false);
}
};
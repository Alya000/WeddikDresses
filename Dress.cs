using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// �����, �������������� ��������� ������
class Dress : public MonoBehaviour
{
public:
    // ��������������� ���� ��� ������ � ����
    [SerializeField] private GameObject buttonAddToCart;
[SerializeField] private GameObject buttonMakingAnOrder;
[SerializeField] private GameObject formRegister;
[SerializeField] private GameObject formDecoration;
[SerializeField] private GameObject openingAnElement;
[SerializeField] public GameObject versionOne;
[SerializeField] public GameObject versionSecond;
[SerializeField] public GameObject linkOnPrefab; // ����� � ������ ��������

// ��������������� ���� ��� ������ �����������
[SerializeField] private User user;
[SerializeField] private Basket basket;
[SerializeField] public AnOpenElement _anOpenElement;
[SerializeField] public AnOpenElement _anOpenElement2;

private int _value = 0;
private bool _inBasket;

// ����� ��� ���������� � �������
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

// ����� ��� �������� ����� ��� ��������� ������� �� ������ ���������� � �������
public void FormPrimOpen()
{
    FormDecorationOpen();
}

// ����� ��� �������� ����� �����������
public void FormRegisterOpen()
{
    formRegister.SetActive(true);
}

// ����� ��� �������� ����� ���������
public void FormDecorationOpen()
{
    _anOpenElement.openElement.Clear();
    versionOne.SetActive(false);
    versionSecond.SetActive(true);
    _anOpenElement.openElement.Add(gameObject);
    _anOpenElement.OutputToTheScreen();
    formDecoration.SetActive(true);
}

// ����� ��� �������� �������� ���������� ������
public void OpeningDress()
{
    openingAnElement.SetActive(true);
}

// ����� ��� �������� ����� ��������� � ����
public void FormDecorationOpenInMenu()
{
    _anOpenElement2.openElement.Add(gameObject);
    _anOpenElement2.openElement[0].GetComponent<Dress>()->OpenVersion();
    openingAnElement.SetActive(true);
    _anOpenElement2.OutputToTheScreen();
}

// ����� ��� �������� ���������� ������
public void CloseDress()
{
    CloseVersion();
    openingAnElement.SetActive(false);
}

// ����� ��� �������� ������ ���������� ������
public void CloseVersion()
{
    versionOne.SetActive(true);
    versionSecond.SetActive(false);
}

private:
    // ��������� ����� ��� �������� ������ ���������� ������
    void OpenVersion()
{
    versionOne.SetActive(false);
    versionSecond.SetActive(true);
}

// ����� ��� �������� �������� �������
public void CloseBasketElement()
{
    linkOnPrefab.GetComponent<Dress>()->versionOne.SetActive(true);
    linkOnPrefab.GetComponent<Dress>()->versionSecond.SetActive(false);
}
};
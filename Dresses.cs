using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �����, ����������� ���������� ��������
public class Dresses : MonoBehaviour
{// ������ ��������� �������
    [SerializeField] public List<Dress> dresses;
    // ������� ��� ������ � ��������� ����������
    [SerializeField] private AnOpenElement _openElement;

    // ����� ��� �������� ���� ��������� �������
    public void CloseDresses()
    {   // �������� �� ���� ��������� ������� � ������
        for (int i = 0; i < dresses.Count; i++)
        {
            // ����� ������ CloseDress() ��� �������� �������� ���������� ������
            dresses[i].CloseDress();
            // ������� ��������� openElement ������ �������
            dresses[i]._anOpenElement2.openElement.Clear();
            // ����� ������ DeleteArray() ��� �������� ������� ��� �������� ������ �������
            dresses[i]._anOpenElement2.DeleteArray();
        }
    }
    // ����� ��� �������� ����������
    public void DeleteContainer()
    {
        // ����� ������ DeleteArray() ��� �������� ������� ��� �������� ������ ������� _openElement
        _openElement.DeleteArray();
    }



}

//#include <iostream>
//#include <vector>

//// ����� ��� ���������� ���������� ��������
//class Dresses
//{
//    public:
//    // ������ ��������� �������
//    std::vector<Dress*> dresses;

//    // ������� ��� ������ � ��������� ����������
//    AnOpenElement* openElement;

//    // ����� ��� �������� ���� ��������� �������
//    void CloseDresses()
//    {
//        // �������� �� ���� ��������� ������� � ������
//        for (int i = 0; i < dresses.size(); i++)
//        {
//            // ����� ������ CloseDress() ��� �������� �������� ���������� ������
//            dresses[i]->CloseDress();

//            // ������� ��������� openElement ������ ������� _anOpenElement2 ���������� ������
//            dresses[i]->_anOpenElement2->openElement.clear();

//            // ����� ������ DeleteArray() ��� �������� ������� ��� �������� ������ ������� _anOpenElement2 ���������� ������
//            dresses[i]->_anOpenElement2->DeleteArray();
//        }
//    }

//    // ����� ��� �������� ���������� (��������, ���������� � ��������� ����������)
//    void DeleteContainer()
//    {
//        // ����� ������ DeleteArray() ��� �������� ������� ��� �������� ������ ������� openElement
//        openElement->DeleteArray();
//    }
//};

//int main()
//{
//    return 0;
//}
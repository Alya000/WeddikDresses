using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Класс, управляющий свадебными платьями
public class Dresses : MonoBehaviour
{// Список свадебных платьев
    [SerializeField] public List<Dress> dresses;
    // Элемент для работы с открытыми элементами
    [SerializeField] private AnOpenElement _openElement;

    // Метод для закрытия всех свадебных платьев
    public void CloseDresses()
    {   // Итерация по всем свадебным платьям в списке
        for (int i = 0; i < dresses.Count; i++)
        {
            // Вызов метода CloseDress() для закрытия текущего свадебного платья
            dresses[i].CloseDress();
            // Очистка коллекции openElement внутри объекта
            dresses[i]._anOpenElement2.openElement.Clear();
            // Вызов метода DeleteArray() для удаления массива или ресурсов внутри объекта
            dresses[i]._anOpenElement2.DeleteArray();
        }
    }
    // Метод для удаления контейнера
    public void DeleteContainer()
    {
        // Вызов метода DeleteArray() для удаления массива или ресурсов внутри объекта _openElement
        _openElement.DeleteArray();
    }



}

//#include <iostream>
//#include <vector>

//// Класс для управления свадебными платьями
//class Dresses
//{
//    public:
//    // Список свадебных платьев
//    std::vector<Dress*> dresses;

//    // Элемент для работы с открытыми элементами
//    AnOpenElement* openElement;

//    // Метод для закрытия всех свадебных платьев
//    void CloseDresses()
//    {
//        // Итерация по всем свадебным платьям в списке
//        for (int i = 0; i < dresses.size(); i++)
//        {
//            // Вызов метода CloseDress() для закрытия текущего свадебного платья
//            dresses[i]->CloseDress();

//            // Очистка коллекции openElement внутри объекта _anOpenElement2 свадебного платья
//            dresses[i]->_anOpenElement2->openElement.clear();

//            // Вызов метода DeleteArray() для удаления массива или ресурсов внутри объекта _anOpenElement2 свадебного платья
//            dresses[i]->_anOpenElement2->DeleteArray();
//        }
//    }

//    // Метод для удаления контейнера (возможно, связанного с открытыми элементами)
//    void DeleteContainer()
//    {
//        // Вызов метода DeleteArray() для удаления массива или ресурсов внутри объекта openElement
//        openElement->DeleteArray();
//    }
//};

//int main()
//{
//    return 0;
//}
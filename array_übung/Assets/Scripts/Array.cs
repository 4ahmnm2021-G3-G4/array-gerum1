using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Array : MonoBehaviour
{
    string[] array1 = new string[4];
    float[] array2 = new float[4] { 1f, 2f, 3f, 4f };
    int[] array3 = new int[4] { 1, 2, 3, 4 };
    GameObject[] array4 = new GameObject[4];

    //1.) Durchlaufen azsgeben der Werte 
    //2.) Länge des Arrays ausgeben als Debug
    //3.) 2 Werte Direkt ändern
    //4.) Gameobjectes Images anlegen, Tag vergeben, Zuweisen und Farbe ändern


    // Start is called before the first frame update
    void Start()
    {
        foreach (float array2f in array2)
        {
            Debug.Log("Inhalt_Array2 " + array2f);
        }
        Debug.Log("Array1_Länge: " + array1.Length);
        array3[1] = 2;
        array3[2] = 1;
        array4 = GameObject.FindGameObjectsWithTag("RedImage");
        array4[2].GetComponent<Image>().color = Color.red;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Pythonchecker : MonoBehaviour
{
    private GameObject ToDoMord;
    private GameObject ToDoCal;
    public GameObject CompleteMord;
    public GameObject CloseCal;
    public GameObject CompleteCal;
    public GameObject CompletePower;
    public GameObject ToDoPower;
    public GameObject ClosePower;

    public GameObject CompleteLexe;
    public static GameObject ToDoLexe;
    public static GameObject CloseLexe;

    public GameObject CompleteWhile;
    public static GameObject ToDoWhile;
    public static GameObject CloseWhile;

    public GameObject CompleteValo;
    public  GameObject ToDoValo;
    public  GameObject CloseValo;

    public static int WhichProgram;

    private void Awake()
    {
        WhichProgram = 1;
        ClosePower = GameObject.Find("ClosePower");
        CompletePower = GameObject.Find("CompletePower");
        ToDoPower = GameObject.Find("ToDoPower");

        ToDoMord = GameObject.Find("ToDoMord");
        CompleteMord = GameObject.Find("CompleteMord");

        ToDoCal = GameObject.Find("ToDoCal");
        CloseCal = GameObject.Find("CloseCal");
        CompleteCal = GameObject.Find("CompleteCal");

        ToDoLexe = GameObject.Find("ToDoLexe");
        CloseLexe = GameObject.Find("CloseLexe");
        CompleteLexe = GameObject.Find("CompleteLexe");

        ToDoWhile = GameObject.Find("ToDoWhile");
        CloseWhile = GameObject.Find("CloseWhile");
        CompleteWhile = GameObject.Find("CompleteWhile");

        ToDoValo = GameObject.Find("ToDoValo");
        CloseValo = GameObject.Find("CloseValo");
        CompleteValo = GameObject.Find("CompleteValo");



        CompletePower.SetActive(false);
        ToDoPower.SetActive(false);
        CompleteCal.SetActive(false);
        CompleteMord.SetActive(false);
        ToDoCal.SetActive(false);

        ToDoLexe.SetActive(false);
        CompleteLexe.SetActive(false);
        CompleteWhile.SetActive(false);
        ToDoWhile.SetActive(false);

        ToDoValo.SetActive(false);
        CompleteValo.SetActive(false);

        if (Referencias.Passlvl1 == true)
        {
            WhichProgram = 2;
            ToDoMord.SetActive(false);
            CompleteMord.SetActive(true);
            ClosePower.SetActive(false);
            ToDoPower.SetActive(true);

        }
        if (Referencias.Passlvl2 == true)
        {
            WhichProgram = 3;
            ToDoPower.SetActive(false);
            CompletePower.SetActive(true);
            CloseCal.SetActive(false);
            ToDoCal.SetActive(true);
        }
        if(Referencias.Passlvl3 == true)
        {
            WhichProgram = 4;
            ToDoCal.SetActive(false);
            CompleteCal.SetActive(true);
            CloseLexe.SetActive(false);
            ToDoLexe.SetActive(true);
        }
        if(Referencias.Passlvl4 == true)
        {
            WhichProgram = 5;
            ToDoLexe.SetActive(false);
            CompleteLexe.SetActive(true);
            CloseValo.SetActive(false);
            ToDoValo.SetActive(true);
        }
        if(Referencias.Passlvl5 == true)
        {
            WhichProgram = 6;
            ToDoValo.SetActive(false);
            CompleteValo.SetActive(true);
            CloseWhile.SetActive(false);
            ToDoWhile.SetActive(true);
        }
        if (Referencias.Passlvl6 == true)
        {
            
            ToDoWhile.SetActive(false);
            CompleteWhile.SetActive(true);
        }
        Debug.Log(WhichProgram);
    }
}

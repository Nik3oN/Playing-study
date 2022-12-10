using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoEscritorio : MonoBehaviour
{
    public GameObject Descarga1;
    public GameObject Paslv1;
    public GameObject Paslv2;
    public GameObject Paslv3;
    public GameObject Paslv4;
    public GameObject Paslv5;
    public GameObject Paslv6;
    private static bool Lvl1 = true;
    private static bool Lvl2 = true;
    private static bool Lvl3 = true;
    private static bool Lvl4 = true;
    private static bool Lvl5 = true;
    private static bool Lvl6 = true;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Mordchanger.Mord == 1)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
                   Input.mousePosition
               );
            // use 'Instantiate' to clone our prefab; this 3-arg version 
            // lets us set the position and rotation for the new object
            var newprint = Instantiate(
                Descarga1,
                new Vector3(mousePosition.x, mousePosition.y, 0),
                Quaternion.identity
            );
            Mordchanger.Mord = 2;
        }
        if (Referencias.Passlvl1 == true && Lvl1 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv1,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl1 = false;
        }
        if (Referencias.Passlvl2 == true && Lvl2 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv2,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl2 = false;
        }
        if (Referencias.Passlvl3 == true && Lvl3 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv3,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl3 = false;
        }
        if (Referencias.Passlvl4 == true && Lvl4 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv4,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl4 = false;
        }
        if (Referencias.Passlvl5 == true && Lvl5 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv5,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl5 = false;
        }
        if (Referencias.Passlvl6 == true && Lvl6 == true)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(
            Input.mousePosition);
            var newprint = Instantiate(Paslv6,
            new Vector3(mousePosition.x, mousePosition.y, 0),
            Quaternion.identity);
            Lvl6 = false;
        }

    }
}

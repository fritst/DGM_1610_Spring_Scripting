using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This following line of code adds our Scriptable Object as an option in the asset menu.
[CreateAssetMenu(fileName ="New SO", menuName ="New Scriptable Object")]

public class SO : ScriptableObject
{
    public string soName;
    public string description;

    public GameObject model;
    public Color color;

    //Scriptable Objects do not use monobehavior callsbacks such as Start() and Update().

    //Scritable objects can also contain functions and conditionals.

    /*private void PrintOut(string name, string description){
      Debug.Log(name +"  "+ description);
      if(name == "Check Norris"){
        Debug.Log("Chuck Norris allows this program to run!");
      }
    }
    */
}

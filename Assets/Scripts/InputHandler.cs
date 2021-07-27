using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour {
    
    private string currentValue = "1";
    private InputField currentField;
    public char handleAxis;
    public GameObject maze;

    void Start() {
        currentField = GetComponent<InputField>();
    }

    public void CheckValue(){
        currentValue = currentField.text;
        print("currentValue: " + currentValue.ToString());
        try{
            if(float.Parse(currentValue) >= 1 && float.Parse(currentValue) <= 3f){
                if(handleAxis == 'x'){
                    maze.transform.localScale = new Vector3(float.Parse(currentValue), maze.transform.localScale.y, maze.transform.localScale.z);
                } else if(handleAxis == 'z'){
                    maze.transform.localScale = new Vector3(maze.transform.localScale.x, maze.transform.localScale.y, float.Parse(currentValue));
                }
            }
        } catch(Exception e) {
            print("Неподходящее значение: " + currentValue.ToString());
        }
    }
}

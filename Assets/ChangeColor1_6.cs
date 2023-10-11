using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor1_6 : MonoBehaviour
{
  Material mat0;
  Material mat1;
  Material mat2;
  Material mat3;
  Material mat4;
  Material mat5;

  Color defaultColor;

  // Start is called before the first frame update
  void Start()
  {
    mat0 = transform.GetChild(0).gameObject.GetComponent<Renderer>().material;
    mat1 = transform.GetChild(1).gameObject.GetComponent<Renderer>().material;
    mat2 = transform.GetChild(2).gameObject.GetComponent<Renderer>().material;
    mat3 = transform.GetChild(3).gameObject.GetComponent<Renderer>().material;
    mat4 = transform.GetChild(4).gameObject.GetComponent<Renderer>().material;
    mat5 = transform.GetChild(5).gameObject.GetComponent<Renderer>().material;
    defaultColor = mat0.color;
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void changeColor0()
  {
    mat0.color = Color.red;
  }

  public void resetColor0()
  {
    mat0.color = defaultColor;
  }

  public void changeColor1()
  {
    mat1.color = Color.red;
  }

  public void resetColor1()
  {
    mat1.color = defaultColor;
  }

  public void changeColor2()
  {
    mat2.color = Color.red;
  }

  public void resetColor2()
  {
    mat2.color = defaultColor;
  }

  public void changeColor3()
  {
    mat3.color = Color.red;
  }

  public void resetColor3()
  {
    mat3.color = defaultColor;
  }

  public void changeColor4()
  {
    mat4.color = Color.red;
  }

  public void resetColor4()
  {
    mat4.color = defaultColor;
  }

  public void changeColor5()
  {
    mat5.color = Color.red;
  }

  public void resetColor5()
  {
    mat5.color = defaultColor;
  }
}

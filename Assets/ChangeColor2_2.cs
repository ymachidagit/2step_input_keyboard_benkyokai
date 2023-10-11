using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor2_2 : MonoBehaviour
{
  Material mat0;
  Material mat1;

  Color defaultColor;

  // Start is called before the first frame update
  void Start()
  {
    mat0 = transform.GetChild(0).gameObject.GetComponent<Renderer>().material;
    mat1 = transform.GetChild(1).gameObject.GetComponent<Renderer>().material;
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
}

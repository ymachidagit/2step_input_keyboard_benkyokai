using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor2 : MonoBehaviour
{
    //二段階目のキーが注視された時に，キーの色を赤くするスクリプト
    Material mat0;
    Material mat1;
    Material mat2;
    Material mat3;
    Material mat4;

    Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        //二段階目のキーのマテリアルを取得
        mat0 = transform.GetChild(0).gameObject.GetComponent<Renderer>().material;//あ
        mat1 = transform.GetChild(1).gameObject.GetComponent<Renderer>().material;//い
        mat2 = transform.GetChild(2).gameObject.GetComponent<Renderer>().material;//う
        mat3 = transform.GetChild(3).gameObject.GetComponent<Renderer>().material;//え
        mat4 = transform.GetChild(4).gameObject.GetComponent<Renderer>().material;//お
        defaultColor = mat0.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeColor0()
    {
        mat0.color = Color.red;//キーが注視された時に実行，キーの色を赤くする
    }

    public void resetColor0()
    {
        mat0.color = defaultColor;//キーから視線が離れた時に実行，キーを元の色に戻す
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
}

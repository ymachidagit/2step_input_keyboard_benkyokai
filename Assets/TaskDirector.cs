using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TaskDirector : MonoBehaviour
{
  GameObject Key_Step1;
  GameObject Key_Step2;
  GameObject Aaiueo;
  GameObject Kaiueo;
  GameObject Saiueo;
  GameObject Taiueo;
  GameObject Naiueo;
  GameObject Other1aiueo;
  GameObject Haiueo;
  GameObject Maiueo;
  GameObject Yaiueo;
  GameObject Raiueo;
  GameObject Waiueo;
  GameObject Other2aiueo;

  [SerializeField] TMP_InputField inputfield;
  [SerializeField] AudioSource audiosource;

  // Start is called before the first frame update

  void Awake()
  {
    Key_Step1 = GameObject.Find("Key_Step1");
    Key_Step2 = GameObject.Find("Key_Step2");

    Aaiueo = GameObject.Find("Aaiueo");
    Kaiueo = GameObject.Find("Kaiueo");
    Saiueo = GameObject.Find("Saiueo");
    Taiueo = GameObject.Find("Taiueo");
    Naiueo = GameObject.Find("Naiueo");
    Other1aiueo = GameObject.Find("Other1aiueo");
    Haiueo = GameObject.Find("Haiueo");
    Maiueo = GameObject.Find("Maiueo");
    Yaiueo = GameObject.Find("Yaiueo");
    Raiueo = GameObject.Find("Raiueo");
    Waiueo = GameObject.Find("Waiueo");
    Other2aiueo = GameObject.Find("Other2aiueo");
  }
  void Start()
  {
		Key_Step1.SetActive(true);
    Key_Step2.SetActive(true);
    Aaiueo.SetActive(false);
    Kaiueo.SetActive(false);
    Saiueo.SetActive(false);
    Taiueo.SetActive(false);
    Naiueo.SetActive(false);
    Other1aiueo.SetActive(false);
    Haiueo.SetActive(false);
    Maiueo.SetActive(false);
    Yaiueo.SetActive(false);
    Raiueo.SetActive(false);
    Waiueo.SetActive(false);
    Other2aiueo.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void InputBackspace()//Backspaceキーが入力された時1文字削除する関数
  {
    audiosource.Play();
    inputfield.text = inputfield.text.Substring(0, inputfield.text.Length - 1);
  }
}

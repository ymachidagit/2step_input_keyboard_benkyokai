using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class InputDirector : MonoBehaviour
{
  GameObject A;
  GameObject K;
  GameObject S;
  GameObject T;
  GameObject N;
  GameObject Other1;
  GameObject H;
  GameObject M;
  GameObject Y;
  GameObject R;
  GameObject W;
  GameObject Other2;

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

  Char[] dakutenKoho ={'か', 'き', 'く', 'け', 'こ', 'さ', 'し', 'す', 'せ', 'そ',
                        'た', 'ち', 'つ', 'て', 'と', 'は', 'ひ', 'ふ', 'へ', 'ほ'};
  Char[] dakutenChar ={'が', 'ぎ', 'ぐ', 'げ', 'ご', 'ざ', 'じ', 'ず', 'ぜ', 'ぞ',
                        'だ', 'ぢ', 'づ', 'で', 'ど', 'ば', 'び', 'ぶ', 'べ', 'ぼ'};
  Char[] handakutenKoho = {'は', 'ひ', 'ふ', 'へ', 'ほ'};
  Char[] handakutenChar = {'ぱ', 'ぴ', 'ぷ', 'ぺ', 'ぽ'};
  Char[] smallKoho = {'つ', 'や', 'ゆ', 'よ'};
  Char[] smallChar = {'っ', 'ゃ', 'ゅ', 'ょ'};

  // Start is called before the first frame update

  void Awake()
  {
    A = GameObject.Find("A");
    K = GameObject.Find("K");
    S = GameObject.Find("S");
    T = GameObject.Find("T");
    N = GameObject.Find("N");
    Other1 = GameObject.Find("Other1");
    H = GameObject.Find("H");
    M = GameObject.Find("M");
    Y = GameObject.Find("Y");
    R = GameObject.Find("R");
    W = GameObject.Find("W");
    Other2 = GameObject.Find("Other2");

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

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void InputA()//一段階目のキーが入力された時に二段階目のキーを表示する関数
  {
    Step2SetFalse();
    Aaiueo.SetActive(true);
  }

  public void InputK()
  {
    Step2SetFalse();
    Kaiueo.SetActive(true);
  }

  public void InputS()
  {
    Step2SetFalse();
    Saiueo.SetActive(true);
  }

  public void InputT()
  {
    Step2SetFalse();
    Taiueo.SetActive(true);
  }

  public void InputN()
  {
    Step2SetFalse();
    Naiueo.SetActive(true);
  }

  public void InputOther1()
  {
    Step2SetFalse();
    Other1aiueo.SetActive(true);
  }

  public void InputH()
  {
    Step2SetFalse();
    Haiueo.SetActive(true);
  }

  public void InputM()
  {
    Step2SetFalse();
    Maiueo.SetActive(true);
  }

  public void InputY()
  {
    Step2SetFalse();
    Yaiueo.SetActive(true);
  }

  public void InputR()
  {
    Step2SetFalse();
    Raiueo.SetActive(true);
  }

  public void InputW()
  {
    Step2SetFalse();
    Waiueo.SetActive(true);
  }

  public void InputOther2()
  {
    Step2SetFalse();
    Other2aiueo.SetActive(true);
  }

  public void InputChar(string a)//二段階目のキーが入力された時に文字を入力する関数
  {
    audiosource.Play();//音声フィードバック
    Step2SetFalse();
    inputfield.text += a;
  }

  public void InputDakuten()
  {
    int dakutenIdx = Array.IndexOf(dakutenKoho, inputfield.text[inputfield.text.Length-1]);
    if (dakutenIdx != -1)
    {
      audiosource.Play();
      Step2SetFalse();
      inputfield.text = inputfield.text.Substring(0, inputfield.text.Length - 1);
      inputfield.text += dakutenChar[dakutenIdx];
    }
  }
  public void InputHandakuten()
  {
    int handakutenIdx = Array.IndexOf(handakutenKoho, inputfield.text[inputfield.text.Length-1]);
    if (handakutenIdx != -1)
    {
      audiosource.Play();
      Step2SetFalse();
      inputfield.text = inputfield.text.Substring(0, inputfield.text.Length - 1);
      inputfield.text += handakutenChar[handakutenIdx];
    }
  }
  public void InputSmall()
  {
    int smallIdx = Array.IndexOf(smallKoho, inputfield.text[inputfield.text.Length-1]);
    if (smallIdx != -1)
    {
      audiosource.Play();
      Step2SetFalse();
      inputfield.text = inputfield.text.Substring(0, inputfield.text.Length - 1);
      inputfield.text += smallChar[smallIdx];
    }
  }

  public void Step2SetFalse()
  {
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
}

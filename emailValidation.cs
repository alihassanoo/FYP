using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class emailValidation : MonoBehaviour
{
    public GameObject Fullname;
    public GameObject email;
    public GameObject password;

    private string fn;//fullname
    private string EM;//email
    private string pass;//password

    private string form;//hold alll the strings
    private bool validemail = false;
    private string[] Characters = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                   "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                   "1","2","3","4","5","6","7","8","9","0","_","-" };


    public void Signupclick()
    {
        bool name = false;
        bool mail = false;
        bool pw = false;

        if (EM != "")

        {
            EmailValidation();
            if (validemail)
            {
                if (EM.Contains("@"))
                {
                    if (EM.Contains("."))
                    {
                        mail = true;
                    }
                    else
                    {
                        Debug.LogWarning("Email is Incorrect");
                    }
                }
                else
                {
                    Debug.LogWarning("Email is Incorrect");
                }
            }


            else
            {
                Debug.LogWarning("Email is Incorrect");
            }


        }
        else
        {
            Debug.LogWarning("EMail Field  Empty");
        }

        if (pass != "")
        {
            if (pass.Length > 4)
            {
                pw = true;

            }
            else
            {
                Debug.LogWarning("Password must be greater then 4");
            }
        }
        else
        {
            Debug.LogWarning("Password Field is Empty");
        }


    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Fullname.GetComponent<InputField>().isFocused)
            {  //is focused=if you are currently editing that field

                email.GetComponent<InputField>().Select();

            }
            if (email.GetComponent<InputField>().isFocused)
            {  //is focused=if you are currently editing that field

                password.GetComponent<InputField>().Select();

            }


        }

        if (Input.GetKeyDown(KeyCode.Return))//clicking the enter key
        {
            if (pass != "" && EM != "" && fn != "")
            {
                Signupclick();
            }
        }
        fn = Fullname.GetComponent<InputField>().text;
        EM = email.GetComponent<InputField>().text;
        pass = password.GetComponent<InputField>().text;


    }

    void EmailValidation()
    {
        bool SW = false;
        bool EW = false;
        for (int i = 0; i < Characters.Length; i++)
        {
            if (EM.StartsWith(Characters[i]))
            {
                SW = true;
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (EM.EndsWith(Characters[i]))
            {
                EW = true;
            }
        }
        if (SW == true && EW == true)
        {
            validemail = true;
        }
        else
        {
            validemail = false;
        }

    }
}



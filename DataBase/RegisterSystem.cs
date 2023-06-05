using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro; //TextMeshPro İçin
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;//UI objeleri için


public class RegisterSystem : MonoBehaviour
{

    public TMP_InputField kullaniciAdi_IF, sifre_IF;

    

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }


    public void uyeligiOlustur_B() {
        if (kullaniciAdi_IF.text.Equals("") || sifre_IF.text.Equals(""))
        {
                Debug.Log("Boş BIRAKMAYINIZ!");
          
        }
        else {

                    Debug.Log("Veritabanı Bağlantısı");
                    StartCoroutine(kayitOl());
                   
        }
    }



    IEnumerator kayitOl()
    {
        WWWForm form = new WWWForm();
        form.AddField("unity", "kayitOlma");
        form.AddField("kullaniciAdi", kullaniciAdi_IF.text); 
        form.AddField("sifre", sifre_IF.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Unity_DB/userRegister.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }



}

	
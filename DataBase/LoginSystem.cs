using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LoginSystem : MonoBehaviour
{

    public TMP_InputField kullaniciAdi_IF, sifre_IF;
    

    
    void Start()
    {

    }

    public void girisYap_B() {
        if (kullaniciAdi_IF.text.Equals("") || sifre_IF.text.Equals("")) {
            Debug.Log("Boş BIRAKMAYINIZ!");
        }
        else
        {
            

           
            StartCoroutine(girisYap());
        }
    }

    IEnumerator girisYap()
    {
        WWWForm form = new WWWForm();
        form.AddField("unity", "girisYapma");
        form.AddField("kullaniciAdi", kullaniciAdi_IF.text); 
        form.AddField("sifre", sifre_IF.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/unity_DB/userRegister.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text.Contains("Giriş Başarılı")) {
                    SceneManager.LoadScene(1);
                }
                else
                    Debug.Log("Kayıt Bulunamadı");
            }
        }
    }



}

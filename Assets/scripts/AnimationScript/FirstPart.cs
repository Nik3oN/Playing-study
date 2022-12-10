using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstPart : MonoBehaviour
{
    public CanvasGroup Discordia;
    public GameObject VirusToAnimate;
    public CanvasGroup Ferrandcoff;
    public CanvasGroup FerranOn;
    public CanvasGroup DiscordNotificarions;
    public AudioSource DiscordSound;
    public GameObject ferrantodelete;
    public TextMeshProUGUI DiscordText;
    public CanvasGroup DiscordBar;
    public GameObject DiscordWrite;
    public CanvasGroup Enlace;
    int i = 0;

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(2);
        FerranOn.LeanAlpha(1, 0);
        Ferrandcoff.LeanAlpha(0, 0);
        yield return new WaitForSecondsRealtime(1);
        ferrantodelete.SetActive(false);
        DiscordNotificarions.LeanAlpha(1, 0.1f).setEaseInExpo();
        DiscordSound.Play();
    }

    private void Start()
    {
        if(i == 0)
        {
            Discordia.LeanAlpha(0, 0);
            Ferrandcoff.LeanAlpha(0, 0);
            FerranOn.LeanAlpha(0, 0);
            DiscordNotificarions.LeanAlpha(0, 0);
            DiscordNotificarions.LeanAlpha(0, 0);
            DiscordBar.LeanAlpha(0, 0);
            Enlace.LeanAlpha(0, 0);
            
        }
        else
        {
            Discordia.LeanAlpha(1, 0);
            Ferrandcoff.LeanAlpha(1, 0);
            FerranOn.LeanAlpha(1, 0);
            DiscordNotificarions.LeanAlpha(1, 0);
            DiscordNotificarions.LeanAlpha(1, 0);
            DiscordBar.LeanAlpha(1, 0);
            Enlace.LeanAlpha(1, 0);
        }
        
    }
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0)&& i == 0)
        {
            if (i == 0)
            {
                Discordia.LeanAlpha(1f, 0.5f).setEaseInCubic();
                Ferrandcoff.LeanAlpha(1, 0.5f).setEaseInCubic();
                i++;
                StartCoroutine(Wait());

            }
        }
        
    }
    public void Ferranclick()
    {
        DiscordNotificarions.LeanAlpha(0, 0.2f);
        DiscordBar.LeanAlpha(1, 0);
        StartCoroutine(DiscordDialog());
        i++;
    }

    IEnumerator DiscordDialog()
    {
        DiscordText.text = "Hola bro";
        yield return new WaitForSecondsRealtime(2);
        DiscordWrite.LeanMoveLocal(new Vector2(-20, -360), 0.3f).setEaseInExpo();
        yield return new WaitForSecondsRealtime(0.3f);
        DiscordText.text = "Hola bro\nMe has dicho que quieres aprender a programar, no?";
        yield return new WaitForSecondsRealtime(3);
        DiscordWrite.LeanMoveLocal(new Vector2(-20, -320), 0.3f).setEaseInExpo();
        yield return new WaitForSecondsRealtime(0.3f);
        DiscordText.text = "Hola bro\nMe has dicho que quieres aprender a programar, no?\nPues he encontrado un tutorial que va perfecto par ti:";
        yield return new WaitForSecondsRealtime(2);
        DiscordWrite.LeanMoveLocal(new Vector2(-20, -280), 0.3f).setEaseInExpo();
        yield return new WaitForSecondsRealtime(0.3f);
        Enlace.LeanAlpha(1, 0);
    }
}

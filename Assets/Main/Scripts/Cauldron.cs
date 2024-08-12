using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cauldron : Condition
{
    private Color currentColor = Color.white;
    public Color goalColor;

    public CauldronSurface cauldronSurface;

    public Renderer surfaceCauldronRenderer;
    public Image surfaceImage;
    public GameObject bubblesPotion;
    public ParticleSystem potionParticle;


    IEnumerator colorChanging;

    void Start()
    {

        currentColor = MakeOpaqueColor(currentColor);
        goalColor = MakeOpaqueColor(goalColor);

        if (!cauldronSurface)
        {
            cauldronSurface = transform.GetChild(0).GetComponent<CauldronSurface>();
        }

        if (!surfaceImage)
        {
            surfaceImage = GetComponentInChildren<Image>();
        }

        surfaceImage.color = currentColor;

        surfaceCauldronRenderer = cauldronSurface.GetComponent<Renderer>();
        surfaceCauldronRenderer.material.color = currentColor;



        //bubblesPotion.GetComponent<Renderer>().enabled = false;
    }


    private Color MakeOpaqueColor(Color color)
    {
        return new Color(color.r, color.g, color.b, 1f);
        Debug.Log("Changer opacité");
;   }

    public void ChangeColor(Color newColor)
    {
        newColor = MakeOpaqueColor(newColor);

        Debug.Log("Couleur actuelle : " + currentColor);
        Debug.Log("Couleur ajoutée : " + newColor);

        if(currentColor == Color.white)
        {
            currentColor = newColor;
        }
        else
        {
            currentColor += newColor;
        }

        currentColor = MakeOpaqueColor(currentColor);


        Debug.Log($"currentColor : {currentColor}");
        Debug.Log($"goalColor : {goalColor}");

        // surfacePotion.GetComponent<Renderer>().enabled = true;
        // surfacePotion.GetComponent<Renderer>().material = true;

        //surfaceCauldronRenderer.GetComponent<Renderer>().material.color = currentColor;

        //bubblesPotion.GetComponent<Renderer>().enabled = true;
        // Fonctionne ?
        //potionParticle.startColor = currentColor;

        if (currentColor == goalColor)
        {
            Debug.Log("La potion est de la bonne couleur !");
            isActive = true;
            //a
        }
        else
        {
            isActive = false;
        }


        if (colorChanging != null)
        {
            StopCoroutine(colorChanging);
        }

        colorChanging = LerpColor(surfaceImage, currentColor, 1f);

        StartCoroutine(colorChanging);

    }


    IEnumerator LerpColor(Image objImg, Color targetColor, float duration)
    {

        float time = 0f;

        Color thisColor = objImg.color;

        while (time < duration)
        {
            time += Time.deltaTime;

            objImg.color = Color.Lerp(thisColor, targetColor, time / duration);

            yield return null;
        }

        objImg.color = targetColor;

        isActive = targetColor == goalColor;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customizer : MonoBehaviour
{
    public GameObject dog;
    public Renderer ren;
    public Material[] mat;
    /*
    [Header("Main Colors Buttons")]
    public Button mainDefault;
    public Button mainBlack;
    public Button mainBlonde;
    public Button mainBrunette;
    public Button mainGray;
    public Button mainGreen;

    [Header("Accent Colors Buttons")]
    public Button accentDefault;
    public Button accentBlack;
    public Button accentBlonde;
    public Button accentBrunette;
    public Button accentGray;
    public Button accentPink;
    
    [Header("Colors")]
    public Material black;      // RGB (0.1019608f, 0.1019608f, 0.1019608f)
    public Material blonde;     // RGB (0.8470588f, 0.7529412f, 0.4705882f)
    public Material brunette;   // RGB (0.5490196f, 0.4078431f, 0.2901961f)
    public Material gray;       // RGB (0.5377358f, 0.5377358f, 0.5377358f)
    public Material mainFun;    // RGB (0.5377358f, 0.7735849f, 0.4965732f)
    public Material accentFun;  // RGB (0.9150943f, 0.4532307f, 0.8220938f)
    public Material main;       // RGB (0.2705882f, 0.3529412f, 0.3921569f)
    public Material accent;     // RGB (1, 1, 1)
    */
    [Header("Colors")]

    public Color main;
    public Color accent;
    public Color black;
    public Color blonde;
    public Color brunette;
    public Color gray;
    public Color mainFun;
    public Color accentFun;


    void Start()
    {
        ren = dog.GetComponent<Renderer>();
        mat = ren.materials;
        Resources.Load("Materials");

    }


    public void buttonPressedMainDefault()
    {
        mat[0].color = main;
       
    }

    public void buttonPressedMainBlack()
    {
        mat[0].color = black;
        
    }
    public void buttonPressedMainBlonde()
    {
        mat[0].color = blonde;
 
    }
    public void buttonPressedMainBrunette()
    {
        mat[0].color = brunette;
 
    }
    public void buttonPressedMainGray()
    {
        mat[0].color = gray;
     
    }
    public void buttonPressedMainFun()
    {
        mat[0].color = mainFun;
      
    }
    public void buttonPressedAccentDefault()
    {
        mat[1].color = accent;
     
    }

    public void buttonPressedAccentBlack()
    {
        mat[1].color = black;
       
    }
    public void buttonPressedAccentBlonde()
    {
        mat[1].color = blonde;
      
    }
    public void buttonPressedAccentBrunette()
    {
        mat[1].color = brunette;
       
    }
    public void buttonPressedAccentGray()
    {
        mat[1].color = gray;
      
    }
    public void buttonPressedAccentFun()
    {
        mat[1].color = accentFun;
     
    }

}

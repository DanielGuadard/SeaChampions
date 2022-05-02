using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{

   // public AudioSource musiquinha;
   // public Scrollbar volume;


    //Janelas principal
    public GameObject Menu_Meio, Menu_Lateral;

    //janela navegação

        public GameObject BuildYourteam_janela, Compendium_janela;


    //Botões
    public GameObject IdlePVE_Botão,Champions_Botão,Compendium_Botão,BuildYourteam_Botão,Options_Botão, Options_Botão2;




    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
       // musiquinha.volume = volume.value;

    }

    public void testando()
    {
       
    }
    

    //funções 

    public void Champions_click()
    {
        if (Compendium_Botão.activeInHierarchy == false) {
           
            Compendium_Botão.SetActive(true);
            BuildYourteam_Botão.SetActive(true);
            Options_Botão2.SetActive(true);
            Options_Botão.SetActive(false);
        }
        else 
        {

            Compendium_Botão.SetActive(false);
            BuildYourteam_Botão.SetActive(false);
            Options_Botão2.SetActive(false);
            Options_Botão.SetActive(true);
        }
        
        if (Menu_Meio.activeInHierarchy == true)
        {
            Menu_Meio.SetActive(false);
            Menu_Lateral.SetActive(true);
            Compendium_Botão.SetActive(true);
            BuildYourteam_Botão.SetActive(true);
            Options_Botão2.SetActive(true);
            Options_Botão.SetActive(false);
        }
        


    }
    public void Compemdium_click()
    {
        if (Menu_Lateral.activeInHierarchy == true && Menu_Meio.activeInHierarchy == false)
        {
            Compendium_janela.SetActive(true);
            BuildYourteam_janela.SetActive(false);
        }
        

    }
    public void BuildYourTeam_click()
    {
        if (Menu_Lateral.activeInHierarchy == true && Menu_Meio.activeInHierarchy == false)
        {
            Compendium_janela.SetActive(false);
            BuildYourteam_janela.SetActive(true);
        }

    }

   

}
